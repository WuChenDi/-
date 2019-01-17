using System;
using System.Data;
using System.Collections;

using MyBookShop.DataAccessLayer;
using MyBookShop.DataAccessHelper;

namespace MyBookShop.BusinessLogicLayer
{
	/// <summary>
	/// Category ��ժҪ˵����
	/// </summary>
	public class Category
	{
		#region ˽�г�Ա

		private int _categoryId;			//ͼ�����ID
		private string _categoryName;		//ͼ�������

		private bool _exist;				//�Ƿ���ڱ�־

		#endregion ˽�г�Ա

		#region ����
		
		public int CategoryID
		{
			set
			{
				this._categoryId=value;
			}
			get
			{
				return this._categoryId;
			}
		}
		public string CategoryName
		{
			set
			{
				this._categoryName=value;
			}
			get
			{
				return this._categoryName;
			}
		}
		public bool Exist
		{
			get
			{
				return this._exist;
			}
		}

		#endregion ����

		#region ����
		
		/// <summary>
		/// ���ݲ���categoryId����ȡͼ�������ϸ��Ϣ
		/// </summary>
		/// <param name="topicID">ͼ�����ID</param>
		public void LoadData(int categoryId)
		{
			Database db=new Database();		//ʵ����һ��Database��

			string sql="";
			sql="Select * from [Category] where CategoryId = "+ categoryId ;

			DataRow dr=db.GetDataRow(sql);	//����Database���GetDataRow������ѯ�û�����

			//���ݲ�ѯ�õ������ݣ��Գ�Ա��ֵ
			if(dr!=null)
			{
				this._categoryId=GetSafeData.ValidateDataRow_N(dr,"CategoryId");
				this._categoryName=GetSafeData.ValidateDataRow_S(dr,"CategoryName");
				
				this._exist=true;
			}
			else
			{
				this._exist=false;
			}
		}

		/// <summary>
		/// ���ݲ�ѯ������ϣ��,��ѯ����
		/// </summary>
		/// <param name="queryItems">��ѯ������ϣ��</param>
		/// <returns>��ѯ�������DataTable</returns>
		public static DataTable Query(Hashtable queryItems)
		{
			string where=SqlStringConstructor.GetConditionClause(queryItems);
			string sql="Select * From [Category]"+where;
			Database db = new Database();
			return db.GetDataTable(sql);
		}
		#endregion ����
	}
}
