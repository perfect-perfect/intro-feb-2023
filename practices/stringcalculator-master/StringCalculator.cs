
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {


        string[] nums = { };
        if (numbers != "")
        {
            nums = numbers.Split(',', '\n');

            if (numbers.StartsWith("//"))
            {
                string newNumbers = numbers[2..];
                char delimiter = numbers[0];
                nums = newNumbers.Split(',', '\n', delimiter);
            }
            
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
