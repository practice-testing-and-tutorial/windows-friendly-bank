using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public abstract class Account : IAccount
	{
		private string name;
		private decimal balance = 0;

		public override string ToString()
		{
			return "Name: " + name + " balance: " + balance;
		}

		public Account(string inName, decimal inBalance)
		{
			name = inName;
			balance = inBalance;
		}

		public Account(string inName) : this (inName, 0){}

		public Account(System.IO.StreamReader textIn)
		{
			name = textIn.ReadLine();
			balance = decimal.Parse(textIn.ReadLine());
		}

		public void PayInFunds(decimal amount)
		{
			balance += amount;
		}

		public virtual bool WithdrawFunds(decimal amount)
		{
			if (balance < amount)
				return false;

			balance -= amount;

			return true;
		}

		public string Name => name;

		public decimal Balance => balance;

		public abstract string RudeLetterString { get; }

		public virtual void Save(System.IO.TextWriter textOut)
		{
			textOut.WriteLine(Name);
			textOut.WriteLine(Balance);
		}

		public bool Save(string filename)
		{
			System.IO.TextWriter textOut = null;

			try
			{
				textOut = new System.IO.StreamWriter(filename);

				Save(textOut);
			}
			catch
			{
				return false;
			}
			finally
			{
				if (textOut != null) textOut.Close();
			}

			return true;
		}
	}
}
