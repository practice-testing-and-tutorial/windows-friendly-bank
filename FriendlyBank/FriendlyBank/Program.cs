using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyBank
{
	class Program
	{
		static void Main(string[] args)
		{
			IAccount account = new CustomerAccount("Bob", 100);

			string newName;

			while (true)
			{
				Console.Write("Enter new name: ");
				newName = Console.ReadLine();

				string reply = Account.ValidateName(newName);

				if (reply.Length == 0)
				{
					break;
				}

				Console.WriteLine("Invalid name: " + reply);
			}

			account.SetName(newName);
		}
	}
}
