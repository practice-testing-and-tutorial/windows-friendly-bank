using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	class ListBank : Bank
	{
		List<IAccount> accounts = new List<IAccount>();

		public override IAccount FindAccount(string name)
		{
			int length = accounts.Count;

			for (int i = 0; i < length; i++)
			{
				if (accounts[i] == null)
					continue;

				if (accounts[i].Name == name)
				{
					return accounts[i];
				}
			}

			return null;
		}

		public override bool StoreAccount(IAccount account)
		{
			if (accounts.Contains(account))
				return false;

			accounts.Add(account);
			return true;
		}
	}
}
