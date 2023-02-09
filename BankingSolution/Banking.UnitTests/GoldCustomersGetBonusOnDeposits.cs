namespace Banking.UnitTests;

public class GoldCustomersGetBonusOnDeposits
{
    [Fact]
    public void BonusAppliedToDeposit()
    {
        var account = new BankAccount(new DummyBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;

        account.Deposit(amountToDeposit);// <- THIS IS THE SYSTEM UNDER TEST

        Assert.Equal(openingBalance + amountToDeposit + 10M, account.GetBalance());
    }
}
