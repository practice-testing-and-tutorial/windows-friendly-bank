using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public abstract class Account : IAccount
	{
		private string _name;
		private decimal _balance = 0;

		public override string ToString()
		{
			return "Name: " + _name + " balance: " + _balance;
		}

		public Account(string inName, decimal inBalance)
		{
			_name = inName;
			_balance = inBalance;
		}

		public Account(string inName) : this (inName, 0){}

		public Account(System.IO.TextReader textIn)
		{
			_name = textIn.ReadLine();
			_balance = decimal.Parse(textIn.ReadLine());
		}

		public void PayInFunds(decimal amount)
		{
			_balance += amount;
		}

		public virtual bool WithdrawFunds(decimal amount)
		{
			if (_balance < amount)
				return false;

			_balance -= amount;

			return true;
		}

		public string GetName() => _name;

		public static string ValidateName(string name)
		{
			if (name == null)
				return "Name parameter null";

			string trimmedName = name.Trim();

			if (trimmedName.Length == 0)
				return "No text in name";

			return "";
		}

		public bool SetName(string inName)
		{
			string reply = ValidateName(inName);

			if (reply.Length > 0)
				return false;

			_name = inName.Trim();

			return true;
		}

		public decimal GetBalance() => _balance;

		public abstract string RudeLetterString { get; }

		public virtual void Save(System.IO.TextWriter textOut)
		{
			textOut.WriteLine(_name);
			textOut.WriteLine(_balance);
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
