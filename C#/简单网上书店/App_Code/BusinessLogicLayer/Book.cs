using System;
using System.Collections;
using System.Data;

using MyBookShop.DataAccessLayer;
using MyBookShop.DataAccessHelper;


namespace MyBookShop.BusinessLogicLayer
{
	/// <summary>
	/// ͼ�����
	/// </summary>
	public class Book
	{
		#region ˽�г�Ա

		private int _bookId;			//ͼ��ID
		private string _bookName;		//ͼ����
		private int _categoryId;		//����ID
		private double _price;			//�۸�
		private string _publisher;		//������
		private DateTime _publishDate;	//����ʱ��
		private string _author;			//����
		private int _pageNum;			//ҳ��
		private string _pictureUrl;		//ͼƬ·��
		private string _description;	//����
		private int _saleCount;	//������

		private bool _exist;			//�Ƿ���ڱ�־

		#endregion ˽�г�Ա

		#region ����
		
		public int BookID
		{
			set
			{
				this._bookId=value;
			}
			get
			{
				return this._bookId;
			}
		}
		public string BookName
		{
			set
			{
				this._bookName=value;
			}
			get
			{
				return this._bookName;
			}
		}
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
		public double Price
		{
			set
			{
				this._price=value;
			}
			get
			{
				return this._price;
			}
		}
		public string Publisher
		{
			set
			{
				this._publisher=value;
			}
			get
			{
				return this._publisher;
			}
		}
		public DateTime PublishDate
		{
			set
			{
				this._publishDate=value;
			}
			get
			{
				return this._publishDate;
			}
		}
		public string Author
		{
			set
			{
				this._author=value;
			}
			get
			{
				return this._author;
			}
		}
		public int PageNum
		{
			set
			{
				this._pageNum=value;
			}
			get
			{
				return this._pageNum;
			}
		}		
		public string PictureUrl
		{
			set
			{
				this._pictureUrl=value;
			}
			get
			{
				return this._pictureUrl;
			}
		}
		public string Description
		{
			set
			{
				this._description=value;
			}
			get
			{
				return this._description;
			}
		}
		public int SaleCount
		{
			set
			{
				this._saleCount=value;
			}
			get
			{
				return this._saleCount;
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
		/// ���ݲ���bookID����ȡͼ����ϸ��Ϣ
		/// </summary>
		/// <param name="topicID">ͼ��ID</param>
		public void LoadData(int bookID)
		{
			Database db=new Database();		//ʵ����һ��Database��

			string sql="";
			sql="Select * from [Book] where BookID = "+ bookID ;

			DataRow dr=db.GetDataRow(sql);	//����Database���GetDataRow������ѯ�û�����

			//���ݲ�ѯ�õ������ݣ��Գ�Ա��ֵ
			if(dr!=null)
			{
				this._bookId=GetSafeData.ValidateDataRow_N(dr,"BookID");
				this._bookName=GetSafeData.ValidateDataRow_S(dr,"BookName");
				this._categoryId=GetSafeData.ValidateDataRow_N(dr,"CategoryId");
				this._price=GetSafeData.ValidateDataRow_F(dr,"Price");
				this._publisher=GetSafeData.ValidateDataRow_S(dr,"Publisher");
				this._publishDate=GetSafeData.ValidateDataRow_T(dr,"PublishDate");
				this._author=GetSafeData.ValidateDataRow_S(dr,"Author");
				this._pageNum=GetSafeData.ValidateDataRow_N(dr,"PageNum");
				this._pictureUrl=GetSafeData.ValidateDataRow_S(dr,"PictureUrl");
				this._description=GetSafeData.ValidateDataRow_S(dr,"Description");
				this._saleCount=GetSafeData.ValidateDataRow_N(dr,"SaleCount");
				
				this._exist=true;
			}
			else
			{
				this._exist=false;
			}
		}

		/// <summary>
		/// �����ݿ����һ��ͼ��
		/// </summary>
		/// <param name="topicInfo">ͼ����Ϣ��ϣ��</param>
		public void Add(Hashtable bookInfo)
		{
			Database db=new Database();		//ʵ����һ��Database��
			db.Insert("[Book]",bookInfo );	//����Database���Inser��������������
		}

		/// <summary>
		/// �޸�ͼ������
		/// </summary>
		/// <param name="newBookInfo">�µ�ͼ����Ϣ��ϣ��</param>
		/// <param name="condition">Update��Where�Ӿ�</param>
		public void Update(Hashtable newBookInfo)
		{
			Database db=new Database();
			string condition = "Where BookID = "+this._bookId;
			db.Update("[Book]",newBookInfo,condition);
		}

		/// <summary>
		/// ɾ��ͼ��
		/// </summary>
		public void Delete()
		{
			Database db=new Database();
			string strSql="Delete From [Book] Where BookID = "+this._bookId;
			db.ExecuteSQL(strSql);
		}

		/// <summary>
		/// ��ѯͼ����Ϣ
		/// </summary>
		/// <param name="queryItems">��ѯ������ϣ��</param>
		/// <returns>��ѯ�����</returns>
		public static DataTable QueryBooks(Hashtable queryItems)
		{
			string where=SqlStringConstructor.GetConditionClause(queryItems);
			string sql="Select * From [Book] "+where;

			Database db = new Database();
			return db.GetDataTable(sql);
		}

		/// <summary>
		/// ��ĳ�����ԣ�������߽����ȡ���е�ͼ����Ϣ
		/// </summary>
		/// <param name="sortedColumn">��������</param>
		/// <param name="sortType">��ȡ{desc,asc}���ֱ����������</param>
		/// <returns>��ѯ�����</returns>
		public static DataTable QueryBooks(Hashtable queryItems,string sortedColumn,string sortType)
		{
			if(sortType.ToUpper()!="DESC" && sortType.ToUpper()!="ASC" && sortType!="")
				return null;

			string where=SqlStringConstructor.GetConditionClause(queryItems);
			string constrains=" Order By "+sortedColumn+" "+sortType;
			string sql="Select * From [Book] "+where+constrains;

			Database db = new Database();
			return db.GetDataTable(sql);
		}

		/// <summary>
		/// ��������ѯͼ���������
		/// </summary>
		/// <returns></returns>
		public static DataTable GetSaleCountByCategory()
		{
			string sql="Select [Category].CategoryName,sum(SaleCount) as SaleCount From [Book],[Category] "
				+"Where [Book].CategoryId=[Category].CategoryId "
				+"Group By [Category].CategoryName";

			Database db=new Database();
			DataTable dt=db.GetDataTable(sql);
			return dt;
		}

		/// <summary>
		/// ���ճ������ѯͼ���������
		/// </summary>
		/// <returns></returns>
		public static DataTable GetSaleCountByPublisher()
		{
			string sql="Select Publisher,sum(SaleCount) as SaleCount From [Book]"
				+"Group By Publisher";

			Database db=new Database();
			DataTable dt=db.GetDataTable(sql);
			return dt;
		}

		/// <summary>
		/// ���ռ۸񼶱��ѯͼ���������
		/// </summary>
		/// <returns></returns>
		public static DataTable GetSaleCountByPrice()
		{
			string sql=
				"Select SUM(SaleCount) AS SaleCount,'1~30' AS PriceGrade from [Book] where price < 30"
				+" UNION "
				+"Select SUM(SaleCount) AS SaleCount,'30~50' AS PriceGrade from [Book] where price >= 30 and price < 50"
				+" UNION "
				+"Select SUM(SaleCount) AS SaleCount,'50+' AS PriceGrade from [Book] where price >= 50 ";

			Database db=new Database();
			DataTable dt=db.GetDataTable(sql);
			return dt;
		}



		#endregion ����
	}
}