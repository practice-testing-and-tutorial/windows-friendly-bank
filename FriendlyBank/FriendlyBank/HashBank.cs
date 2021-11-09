using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	class HashBank : Bank
	{
		Hashtable bankHashtable = new Hashtable();

		public override IAccount FindAccount(string name)
		{
			// use 'as' instead of casting so that if the object is not an IAccount (or any other wrong type) it will return a 'null'
			return bankHashtable[name] as IAccount;
		}

		public override bool StoreAccount(IAccount account)
		{
			bankHashtable.Add(account.GetName(), account);
			return true;
		}

		public void Save(System.IO.TextWriter textOut)
		{
			textOut.WriteLine(bankHashtable.Count);

			foreach (IAccount account in bankHashtable.Values)
			{
				textOut.WriteLine(account.GetType().Name);
				account.Save(textOut);
			}
		}

		public static HashBank Load(System.IO.TextReader textIn)
		{
			HashBank result = new HashBank();
			string countString = textIn.ReadLine();
			int count = int.Parse(countString);

			for (int i = 0; i < count; i++)
			{
				string className = textIn.ReadLine();
				IAccount account = AccountFactory.MakeAccount(className, textIn);
				result.bankHashtable.Add(account.GetName(), account);
			}

			return result;
		}
	}
}
