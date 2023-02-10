namespace Banking.Domain;

// A Job description. Any class that implements this interface is promising it "Can Do" this job description
public interface ICanCalculateAccountBonuses
{
    // creates a decimal that is the result of the `GetDepositBonusFor()` method. 
    //  - this method is located in `StandardBonusCalculator.cs` 
    decimal GetDepositBonusFor(decimal balance, decimal amountToDeposit);
}