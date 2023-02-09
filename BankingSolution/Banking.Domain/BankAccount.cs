namespace Banking.Domain;

public class BankAccount
{
    private decimal _balance = 5000M; // State - "Fields" variable
    // example of interfaces
    private ICanCalculateAccountBonuses _bonusCalculator;

    // this is a constructor. Constructors are for Required Dependences when creating a class
    // this means we have to include a bonus calculator where we create a new BankAccount
    public BankAccount(ICanCalculateAccountBonuses bonusCalculator)
    {
        _bonusCalculator = bonusCalculator;
    }

    public void Deposit(decimal amountToDeposit)
    {
        // Write the code you wish you had
        decimal bonus = _bonusCalculator.GetDepositBonusFor(_balance, amountToDeposit);
        _balance += amountToDeposit + bonus;
    }

    public decimal GetBalance()
    {
        return _balance;
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        if (NotOverdraft(amountToWithdraw))
        {
            _balance -= amountToWithdraw;
        }
        else
        {
            throw new AccountOverdraftException();
        }

    }


    // "Never type private, always refactor to it" - Corey Haines.
    private bool NotOverdraft(decimal amountToWithdraw)
    {
        return _balance >= amountToWithdraw;
    }
}