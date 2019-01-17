/**********************************************************
 * ˵�����û���User
 * ���ߣ�
 * �������ڣ�
 *********************************************************/
using System;
using System.Collections;
using System.Data;

using MyBookShop.DataAccessLayer;
using MyBookShop.DataAccessHelper;

namespace MyBookShop.BusinessLogicLayer
{
	/// <summary>
	/// User ��ժҪ˵����
	/// </summary>
	public class User
	{
		#region ˽�г�Ա

		private int _userID;		//�û�ID
		private string _loginName;	//�û���¼��
		private string _userName;	//�û�����
		private string _password;	//�û�����
		private string _address;	//�û���ַ
		private string _zip;		//�û��ʱ�

		private bool _exist;		//�Ƿ���ڱ�־

		#endregion ˽�г�Ա

		#region ����
		
		public int UserID
		{
			set
			{
				this._userID=value;
			}
			get
			{
				return this._userID;
			}
		}
		public string LoginName
		{
			set
			{
				this._loginName=value;
			}
			get
			{
				return this._loginName;
			}
		}
		public string UserName
		{
			set
			{
				this._userName=value;
			}
			get
			{
				return this._userName;
			}
		}
		public string Password
		{
			set
			{
				this._password=value;
			}
			get
			{
				return this._password;
			}
		}
		public string Address
		{
			set
			{
				this._address=value;
			}
			get
			{
				return this._address;
			}
		}
		public string Zip
		{
			set
			{
				this._zip=value;
			}
			get
			{
				return this._zip;
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
		/// ���ݲ���loginName����ȡ�û���ϸ��Ϣ
		/// </summary>
		/// <param name="loginName">�û���¼��</param>
		public void LoadData(string loginName)
		{
			Database db=new Database();		//ʵ����һ��Database��

			string sql="";
			sql="Select * from [User] where LoginName = "
				+SqlStringConstructor.GetQuotedString(loginName);

			DataRow dr=db.GetDataRow(sql);	//����Database���GetDataRow������ѯ�û�����

			//���ݲ�ѯ�õ������ݣ��Գ�Ա��ֵ
			if(dr!=null)
			{
				this._userID=GetSafeData.ValidateDataRow_N(dr,"UserID");
				this._loginName=GetSafeData.ValidateDataRow_S(dr,"loginName");
				this._userName=GetSafeData.ValidateDataRow_S(dr,"UserName");
				this._password=GetSafeData.ValidateDataRow_S(dr,"PassWord");
				this._address=GetSafeData.ValidateDataRow_S(dr,"Address");
				this._zip=GetSafeData.ValidateDataRow_S(dr,"Zip");
			
				this._exist=true;
			}
			else
			{
				this._exist=false;
			}
		}

		/// <summary>
		/// ���ݲ���loginName����ȡ�û���ϸ��Ϣ
		/// </summary>
		/// <param name="userId">�û�ID</param>
		public void LoadData(int userId)
		{
			Database db=new Database();		//ʵ����һ��Database��

			string sql="";
			sql="Select * from [User] where UserId = "+userId.ToString();

			DataRow dr=db.GetDataRow(sql);	//����Database���GetDataRow������ѯ�û�����

			//���ݲ�ѯ�õ������ݣ��Գ�Ա��ֵ
			if(dr!=null)
			{
				this._userID=GetSafeData.ValidateDataRow_N(dr,"UserID");
				this._loginName=GetSafeData.ValidateDataRow_S(dr,"loginName");
				this._userName=GetSafeData.ValidateDataRow_S(dr,"UserName");
				this._password=GetSafeData.ValidateDataRow_S(dr,"PassWord");
				this._address=GetSafeData.ValidateDataRow_S(dr,"Address");
				this._zip=GetSafeData.ValidateDataRow_S(dr,"Zip");
			
				this._exist=true;
			}
			else
			{
				this._exist=false;
			}
		}

		/// <summary>
		/// �����ݿ����һ���û�
		/// </summary>
		/// <param name="htUserInfo">�û���Ϣ��ϣ��</param>
		public void Add(Hashtable userInfo)
		{
			Database db=new Database();		//ʵ����һ��Database��
			db.Insert("[User]",userInfo );	//����Database���GetDataRow������ѯ�û�����
		}

		/// <summary>
		/// �ж��Ƿ���ڵ�¼��ΪloginName���û�
		/// </summary>
		/// <param name="loginName">�û���¼��</param>
		/// <returns>������ڣ�����true�����򣬷���false</returns>
		public static bool HasUser(string loginName)
		{
			Database db=new Database();
			
			string sql="";
			sql="Select * from [User] where [LoginName] = "
				+SqlStringConstructor.GetQuotedString(loginName);

			DataRow row=db.GetDataRow(sql);
			if(row!=null)
				return true;
			else
				return false;
		}
		#endregion ����
	}
}
