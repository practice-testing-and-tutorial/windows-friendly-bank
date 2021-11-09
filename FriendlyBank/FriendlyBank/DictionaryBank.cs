using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	class DictionaryBank : Bank
	{
		Dictionary<string, IAccount> accounts = new Dictionary<string, IAccount>();

		public override IAccount FindAccount(string name)
		{
			if (accounts.ContainsKey(name))
				return accounts[name];

			return null;
		}

		public override bool StoreAccount(IAccount account)
		{
			if (accounts.ContainsKey(account.GetName()))
				return false;

			accounts.Add(account.GetName(), account);
			return true;
		}
	}
}
