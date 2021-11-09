using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public class BabyAccount : Account
	{
		private string _parentName;

		public BabyAccount(string inName, int inBalance, string parentName) : base(inName, inBalance)
		{
			_parentName = parentName;
		}

		public BabyAccount(System.IO.TextReader textIn) : base(textIn)
		{
			_parentName = textIn.ReadLine();
		}

		public override string RudeLetterString => "Tell daddy you are overdrawn";

		public override bool WithdrawFunds(decimal amount)
		{
			if (amount > 10)
				return false;

			return base.WithdrawFunds(amount);
		}

		public override void Save(System.IO.TextWriter textOut)
		{
			base.Save(textOut);
			textOut.WriteLine(_parentName);
		}
	}
}
