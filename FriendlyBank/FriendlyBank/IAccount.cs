using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public interface IAccount
	{
		void PayInFunds(decimal amount);
		bool WithdrawFunds(decimal amount);
		decimal Balance { get; }
		string RudeLetterString { get; }
		string Name { get; }
		void Save(System.IO.TextWriter textOut);
		bool Save(string filename);
	}
}
