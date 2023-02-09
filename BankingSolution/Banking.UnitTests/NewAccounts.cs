using Banking.Domain;

namespace Banking.UnitTests;

public class NewAccounts
{
    [Fact]
    public void NewAccountsHaveTheCorrectOpeningBalance()
    {
        // Given I have a brand new bank account
        var account = new BankAccount(new DummyBonusCalculator);

        // When I ask that account for it's balance
        // we use decimal data type so it knows that Get.Balance() will return a variable
        decimal openingBalance = account.GetBalance();

        // Then it has a balance of $5,000.00
        Assert.Equal(5000M, openingBalance);
    }
}
