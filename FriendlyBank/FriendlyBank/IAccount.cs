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
		decimal GetBalance();
		string RudeLetterString { get; }
		string GetName();
		bool SetName(string inName);
		void Save(System.IO.TextWriter textOut);
		bool Save(string filename);
	}
}
