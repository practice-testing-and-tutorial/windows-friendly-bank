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

public class CustomerAccount : Account
{
	public override string RudeLetterString()
	{
		return "You are overdrawn";
	}
}

public class  BabyAccount : Account
{
	public override string RudeLetterString()
	{
		return "Tell daddy you are overdrawn";
	}

	public override bool WithdrawFunds(decimal amount)
	{
		if (amount > 10)
			return false;
		
		return base.WithdrawFunds(amount);
	}
}