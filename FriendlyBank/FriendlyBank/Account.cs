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

		public string GetName() => name;

		public decimal GetBalance() => balance;

		public abstract string RudeLetterString();
	}
}
