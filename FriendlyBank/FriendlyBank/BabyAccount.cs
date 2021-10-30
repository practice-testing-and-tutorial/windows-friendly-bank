using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public class BabyAccount : Account
	{
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
