using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	class HashBank : IBank
	{
		Hashtable bankHashtable = new Hashtable();

		public IAccount FindAccount(string name)
		{
			// use 'as' instead of casting so that if the object is not an IAccount (or any other wrong type) it will return a 'null'
			return bankHashtable[name] as IAccount;
		}

		public bool StoreAccount(IAccount account)
		{
			bankHashtable.Add(account.GetName(), account);
			return true;
		}
	}
}
