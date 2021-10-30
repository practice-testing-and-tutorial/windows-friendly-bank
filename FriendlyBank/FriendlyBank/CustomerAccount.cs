using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public class CustomerAccount : Account
	{
		public CustomerAccount(string inName, int inBalance) : 
			base (inName, inBalance){}

		public override string RudeLetterString()
		{
			return "You are overdrawn";
		}
	}
}
