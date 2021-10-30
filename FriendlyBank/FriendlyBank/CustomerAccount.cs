using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public class CustomerAccount : Account
	{
		public CustomerAccount(string inName, decimal inBalance) : 
			base (inName, inBalance){}

		public override string RudeLetterString()
		{
			return "You are overdrawn";
		}

		public bool Save(string filename)
		{
			try
			{
				System.IO.TextWriter textOut =
					new System.IO.StreamWriter(filename);

				textOut.WriteLine(GetName());
				textOut.WriteLine(GetBalance());
				textOut.Close();
			}
			catch
			{
				return false;
			}

			return false;
		}

		public static CustomerAccount Load(string filename)
		{
			CustomerAccount result = null;
			System.IO.TextReader textIn = null;

			try
			{
				textIn = new System.IO.StreamReader(filename);
				string nameText = textIn.ReadLine();
				string balanceText = textIn.ReadLine();
				decimal balance = decimal.Parse(balanceText);
				result = new CustomerAccount(nameText, balance);
			}
			catch
			{
				return null;
			}
			finally
			{
				if (textIn != null) textIn.Close();
			}

			return result;
		}
	}
}
