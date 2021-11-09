using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public class ArrayBank : Bank
	{
		private IAccount[] accounts;

		public ArrayBank(int bankSize)
		{
			accounts = new IAccount[bankSize];
		}

		public override IAccount FindAccount(string name)
		{
			for (int i = 0; i < accounts.Length; i++)
			{
				if (accounts[i] == null)
					continue;

				if (accounts[i].GetName() == name)
				{
					return accounts[i];
				}
			}

			return null;
		}

		public override bool StoreAccount(IAccount account)
		{
			for (int i = 0; i < accounts.Length; i++)
			{
				if (accounts[i] == null)
				{
					accounts[i] = account;
					return true;
				}
			}

			return false;
		}
	}
}
