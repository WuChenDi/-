using System;
using System.Collections;

using MyBookShop.BusinessLogicLayer;
using MyBookShop.DataAccessHelper;

namespace MyBookShop.BusinessLogicHelper
{
	public class BookHelper
	{
		public static bool Add(Hashtable bookInfo,ref ArrayList WarningMessageList)
		{
			bool result = true;
			WarningMessageList.Clear();
			Hashtable quoetedBookInfo=new Hashtable();

			foreach(DictionaryEntry item in bookInfo)
			{
				switch(item.Key.ToString())
				{
					case "BookName":
					{
						if(item.Value.ToString()=="")
						{
							result=false;
							WarningMessageList.Add("警告:图书名称不能为空!");
						}
						else if(!ValidateUtility.IsString(item.Value))
							{
								result=false;
								WarningMessageList.Add("警告:图书名称数据类型错误!");
							}
						else
							quoetedBookInfo.Add("BookName",SqlStringConstructor.GetQuotedString(item.Value.ToString()));
						break;
					}
					case "CategoryId":
					{
						if(item.Value.ToString()=="")
						{
							result=false;
							WarningMessageList.Add("警告:图书类别ID不能为空!");
						}
						else if(!ValidateUtility.IsDouble(item.Value))
						{
							result=false;
							WarningMessageList.Add("警告:图书类别ID类型错误!");
						}
						else
							quoetedBookInfo.Add("CategoryId",item.Value.ToString());
						break;
					}
					case "Price":
					{
						if(item.Value.ToString()=="")
						{
							result=false;
							WarningMessageList.Add("警告:图书价格数不能为空!");
						}
						else if(!ValidateUtility.IsDouble(item.Value))
						{
							result=false;
							WarningMessageList.Add("警告:图书价格数据类型错误!");
						}
						else
							quoetedBookInfo.Add("Price",item.Value.ToString());
						break;
					}
					case "Publisher":
					{
						if(item.Value.ToString()=="")
						{
							result=false;
							WarningMessageList.Add("警告:出版社不能为空!");
						}
						else if(!ValidateUtility.IsString(item.Value))
						{
							result=false;
							WarningMessageList.Add("警告:出版社数据类型错误!");
						}
						else
							quoetedBookInfo.Add("Publisher",SqlStringConstructor.GetQuotedString(item.Value.ToString()));
						break;
					}
					case "PublishDate":
					{
						if(!ValidateUtility.IsDateTime(item.Value))
						{
							result=false;
							WarningMessageList.Add("警告:图书出版日期数据类型错误!");
						}
						else
							quoetedBookInfo.Add("PublishDate",SqlStringConstructor.GetQuotedString(item.Value.ToString()));

						break;
					}
					case "Author":
					{
						if(item.Value.ToString()=="")
						{
							result=false;
							WarningMessageList.Add("警告:作者不能为空!");
						}
						else if(!ValidateUtility.IsString(item.Value))
						{
							result=false;
							WarningMessageList.Add("警告:图书名称数据类型错误!");
						}
						else
							quoetedBookInfo.Add("Author",SqlStringConstructor.GetQuotedString(item.Value.ToString()));
						break;
					}
					case "PageNum":
					{
						if(!ValidateUtility.IsInt(item.Value))
						{
							result=false;
							WarningMessageList.Add("警告:图书页数数据类型错误!");
						}
						else
							quoetedBookInfo.Add("PageNum",item.Value.ToString());
						break;
					}
					case "PictureUrl":
					{
						if(!ValidateUtility.IsString(item.Value))
						{
							result=false;
							WarningMessageList.Add("警告:图片路径数据类型错误!");
						}
						else
							quoetedBookInfo.Add("PictureUrl",SqlStringConstructor.GetQuotedString(item.Value.ToString()));
						break;
					}
					case "Description":
					{
						if(!ValidateUtility.IsString(item.Value))
						{
							result=false;
							WarningMessageList.Add("警告:图书页数数据类型错误!");
						}
						else if(item.Value.ToString().Length>1000)
						{
							result=false;
							WarningMessageList.Add("警告:请把图书简介字符在1000字之内!");
						}
						else
							quoetedBookInfo.Add("Description",SqlStringConstructor.GetQuotedString(item.Value.ToString()));
						break;
					}
					case "SaleCount":
					{
						if(!ValidateUtility.IsString(item.Value))
						{
							result=false;
							WarningMessageList.Add("警告:销售量数据类型错误!");
						}
						else
							quoetedBookInfo.Add("SaleCount",item.Value.ToString());
						break;
					}
				}
			}

			if (result)
			{
				Book book=new Book();
				book.Add(quoetedBookInfo);
			}
			return result;
		}
	}
}