using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	public enum AccountState
	{
		New,
		Active,
		UnderAudit,
		Frozen,
		Closed
	}
}
