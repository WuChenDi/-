using System;
using System.Collections;

namespace MyBookShop.DataAccessHelper
{
	/// <summary>
	/// SQLString 的摘要说明。
	/// </summary>
	public class SqlStringConstructor
	{
		public static String GetQuotedString(String pStr)
		{
			return ("'" + pStr.Replace("'","''") + "'");
		}
		public static String GetConditionClause(Hashtable queryItems)
		{

			int Count = 0;
			String Where = "";
			foreach(DictionaryEntry item in queryItems)
			{
				if (Count == 0)
					Where = " Where ";
				else
					Where += " And ";

				
				if(item.Value.GetType().ToString()=="System.String" || item.Value.GetType().ToString()=="System.DateTime")
				{
					Where += "[" + item.Key.ToString() + "]" 
						+ "Like " 
						+ SqlStringConstructor.GetQuotedString("%"
						+ item.Value.ToString()
						+ "%");
				}
				else
				{
					Where += "[" + item.Key.ToString() + "]" + "= " + item.Value.ToString();
				}
				Count ++;
			}
			return Where;
		}
	}
}
