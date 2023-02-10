namespace Banking.Domain;

public class StandardBonusCalculator : ICanCalculateAccountBonuses
{
    private IProvideTheBusinessClock _businessClock;

    public StandardBonusCalculator(IProvideTheBusinessClock businessClock)
    {
        _businessClock = businessClock;
    }

    public decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit)
    {
        // GetBonus is is a private bool method declated  right below this method
        return GetsBonus(balance) ? amountToDeposit * .10M : 0;
    }

    // a private bool method  that takes a decimal as the parameter balance
    private bool GetsBonus(decimal balance)
    {
        return balance >= 5000M && _businessClock.IsDuringBusinessHours();
    }
}