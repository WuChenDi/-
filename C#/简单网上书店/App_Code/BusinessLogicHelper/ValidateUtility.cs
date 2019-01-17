using System;

namespace MyBookShop.BusinessLogicHelper
{
	/// <summary>
	/// ������֤������,�ṩ��һϵ����֤���ݵľ�̬����
	/// </summary>
	public class ValidateUtility
	{
		#region ��֤��������
		/// <summary>
		/// ��֤һ�������ܷ�ת��Ϊ�ַ�������
		/// </summary>
		/// <param name="val">����֤����</param>
		/// <returns>�����,����true;����,����false</returns>
		public static bool IsString(object val)
		{
			try
			{
				Convert.ToString(val);
				return true;
			}
			catch
			{
				return false;
			}
		}

		public static bool IsDouble(object val)
		{
			try
			{
				Convert.ToDouble(val);
				return true;
			}
			catch
			{
				return false;
			}
		}
		public static bool IsInt(object val)
		{
			try
			{
				Convert.ToInt32(val);
				return true;
			}
			catch
			{
				return false;
			}
		}
		public static bool IsDateTime(object val)
		{
			try
			{
				Convert.ToDateTime(val);
				return true;
			}
			catch
			{
				return false;
			}
		}

		#endregion ��֤��������

	}
}
