namespace Banking.Domain;

// the first thing after the colon has to be the Class we are extending
public class GoldBankAccount : BankAccount
{
    // here we are overriding the 'Deposit()' from Bank account to add a bonus
    public override void Deposit(decimal amountToDeposit)
    {
        base.Deposit(amountToDeposit * 1.10M);
    }
}
