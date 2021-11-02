using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public abstract class Bank : IBank
	{
		public abstract IAccount FindAccount(string name);

		public abstract bool StoreAccount(IAccount account);
	}
}
