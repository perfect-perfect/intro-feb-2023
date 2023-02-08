namespace Banking.Domain;

public class BankAccount
{
    private decimal _balance = 5000M; // State - "Fields" variable
    public void Deposit(decimal amountToDeposit)
    {
        _balance += amountToDeposit;
    }

    public decimal GetBalance()
    {
  
        return _balance; // Hard code it "Sliming"
    }

    public void Withdraw(decimal amountToWithdraw)
    {
        // CTRL-R + CTRL-M ==> to take a a thing and extract it into a new mothod.
        if (NotOverDraft(amountToWithdraw))
        {
            _balance -= amountToWithdraw;
        } else
        {
            throw new AccountOverdraftException();
        }

    }

    private bool NotOverDraft(decimal amountToWithdraw)
    {
        return _balance >= amountToWithdraw;
    }
}