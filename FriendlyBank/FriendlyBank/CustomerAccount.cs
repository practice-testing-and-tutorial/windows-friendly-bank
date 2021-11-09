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

		public CustomerAccount(System.IO.TextReader textIn) : 
			base (textIn) {}

		public override string RudeLetterString	=> "You are overdrawn";

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

		public static CustomerAccount Load(System.IO.TextReader textIn)
		{
			CustomerAccount result;

			try
			{
				string name = textIn.ReadLine();
				string balanceText = textIn.ReadLine();
				decimal balance = decimal.Parse(balanceText);
				result = new CustomerAccount(name, balance);
			}
			catch
			{
				return null;
			}

			return result;
		}
	}
}
