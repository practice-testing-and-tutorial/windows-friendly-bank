using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public class BabyAccount : Account
	{
		public BabyAccount(string inName, int inBalance) : base(inName, inBalance)
		{
		}

		public override string RudeLetterString()
		{
			return "Tell daddy you are overdrawn";
		}

		public override bool WithdrawFunds(decimal amount)
		{
			if (amount > 10)
				return false;

			return base.WithdrawFunds(amount);
		}
	}
}
