public interface IAccount
{
	void PayInFunds(decimal amount);
	bool WithdrawFunds(decimal amount);
	decimal GetBalance();
	string RudeLetterString();
}

public abstract class Account : IAccount
{
	private decimal balance = 0;

	public void PayInFunds(decimal amount)
	{
		balance += amount;
	}

	public virtual WithdrawFunds(decimal amount)
	{
		if (balance < amount)
			return false;
		
		balance -= amount;

		return true;
	}

	public decimal GetBalance() => balance;

	public abstract string RudeLetterString();
}