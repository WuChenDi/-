using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

using MyBookShop.DataAccessHelper;
using MyBookShop.DataAccessLayer;

namespace MyBookShop.BusinessLogicLayer
{
	/// <summary>
	/// Cart ��ժҪ˵����
	/// </summary>
	public class Cart
	{
		#region ˽�г�Ա

		private int _cartId;		//������ID
		private int _userId;		//�û�ID
		private ArrayList _books=new ArrayList();		//�������еĹ�����ID����
		private ArrayList _amount=new ArrayList();		//�������й�����������

		private bool _exist;			//�Ƿ���ڱ�־

		#endregion ˽�г�Ա

		#region ����
		
		public int CartId
		{
			set
			{
				this._cartId=value;
			}
			get
			{
				return this._cartId;
			}
		}
		public int UserId
		{
			set
			{
				this._userId=value;
			}
			get
			{
				return this._userId;
			}
		}
		public ArrayList Books
		{
			set
			{
				this._books=value;
			}
			get
			{
				return this._books;
			}
		}
		public ArrayList Amount
		{
			set
			{
				this._amount=value;
			}
			get
			{
				return this._amount;
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
		/// ���ݲ���userId����ȡ��������ϸ��Ϣ
		/// </summary>
		/// <param name="userId">�û�ID</param>
		public void LoadData(int userId)
		{
			Database db=new Database();		//ʵ����һ��Database��

			string sql="";
			sql="Select * from [Cart] where UserID = "+ userId ;

			SqlDataReader reader=db.GetDataReader(sql);	//����Database���GetDataRow������ѯ�û�����

			//���ݲ�ѯ�õ������ݣ��Գ�Ա��ȫ��ֵ
			while(reader.Read())
			{
				if(this._cartId==0)
				{
					this._cartId=GetSafeData.ValidateDataReader_N(reader,"CartId");
					this._userId=GetSafeData.ValidateDataReader_N(reader,"UserId");	
				}
				this._books.Add(GetSafeData.ValidateDataReader_N(reader,"BookId"));
				this._amount.Add(GetSafeData.ValidateDataReader_N(reader,"Amount"));
				
				this._exist=true;
			}
			if(this._cartId==0)
			{
				this._exist=false;
			}
		}

		/// <summary>
		/// �����ݿ����һ���������е�һ��ͼ��
		/// </summary>
		/// <param name="topicInfo">�������е�һ��ͼ�����Ϣ��ϣ��</param>
		public void Add(Hashtable cartInfo)
		{
			Database db=new Database();		//ʵ����һ��Database��
			db.Insert("[Cart]",cartInfo );	//����Database���Inser��������������
		}

		/// <summary>
		/// �޸Ĺ������е�һ��ͼ������
		/// </summary>
		/// <param name="newCartInfo">�µĹ�������Ϣ��ϣ��</param>
		/// <param name="condition">Update��Where�Ӿ�</param>
		public void Update(Hashtable newCartInfo,int cartId)
		{
			Database db=new Database();
			string condition = "Where CartID = "+cartId.ToString();
			db.Update("[Cart]",newCartInfo,condition);
		}

		/// <summary>
		/// ɾ������������
		/// </summary>
		public void Delete()
		{
			Database db=new Database();
			string strSql="Delete From [Cart] Where CartID = "+this._cartId;
			db.ExecuteSQL(strSql);
		}

		/// <summary>
		/// ɾ����������ĳ��ͼ��
		/// </summary>
		/// <param name="cartId">��Ҫɾ������������Ŀ���</param>
		public void RemoveBook(int cartId)
		{
			Database db=new Database();
			string strSql="Delete From [Cart] Where cartId = "+cartId.ToString();
			db.ExecuteSQL(strSql);
		}

		/// <summary>
		/// ��ѯuserId�Ĺ������е���Ϣ������DataTable����
		/// </summary>
		/// <param name="userId">�û����</param>
		/// <returns>��������ϢDataTable</returns>
		public static DataTable Query(int userId)
		{
			string sql="";
			sql="Select * From [Cart],[Book] Where [Cart].UserId = "+userId
				+" And [Cart].bookId=[Book].bookId";
			Database db=new Database();
			return db.GetDataTable(sql);
		}

		#endregion ����
	}
}
