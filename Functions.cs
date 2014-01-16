using System;
using System.Runtime.InteropServices;
namespace Functions
{
	/// <summary>
	/// Summary description for SuperString.
	/// </summary>
	///
    
	public class SuperString 
	{
		private string MyString = "";
		public SuperString()
		{
		}

		public SuperString(string str) 
		{
			MyString = str;
		}

		public string Left(int length)
		{
		  string tmpstr = MyString.Substring(0, length);
		  return tmpstr;
		}

		public string Right(int length)
		{
			string tmpstr = MyString.Substring(MyString.Length - length, length);
			return tmpstr;
		}

		public string Mid(int startIndex, int length)
		{
			string tmpstr = MyString.Substring(startIndex, length);
			return tmpstr;
		}

		public string Mid(int startIndex)
		{
			string tmpstr = MyString.Substring(startIndex);
			return tmpstr;
		}

		// string to SuperString
		// DBBool.dbTrue and false to DBBool.dbFalse:
		public static implicit operator SuperString(string x) 
		{
			SuperString s = new SuperString(x);
			return s;
		}

		public override string ToString() 
		{
			return MyString;
		}


		// Explicit conversion from SuperString to string. Throws an 
		// exception if the given DBBool is dbNull, otherwise returns
		// true or false:
		public static explicit operator string(SuperString x) 
		{
			return x.MyString;
		}


	}
}
