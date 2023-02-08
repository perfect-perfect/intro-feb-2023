
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        string[] nums = { };
        if (numbers != "")
        {
            nums = numbers.Split(',', '\n');
        }

        if (nums.Length == 0)
        {
            return 0;
        } else
        {
            int sum = 0;
            int numberAsInt = 0;
            foreach (string number in nums) 
            {
                numberAsInt = int.Parse(number);
                sum += numberAsInt; 
            }
            return sum;
        }
    }
}
