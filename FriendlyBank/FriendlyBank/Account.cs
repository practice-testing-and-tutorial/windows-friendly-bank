using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public abstract class Account : IAccount
	{
		private decimal balance = 0;

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

		public decimal GetBalance() => balance;

		public abstract string RudeLetterString();
	}
}
