namespace AllForOneAPI.Services
{
    public class Add2NumbersServices
    {
        public string Add(string num1, string num2)
        {
            int parsedNum1;
            int parsedNum2;
            bool numericNum1 = int.TryParse(num1, out parsedNum1);
            bool numericNum2 = int.TryParse(num2, out parsedNum2);
            if (numericNum1 && numericNum2)
                return $"The Sum of {parsedNum1} and {parsedNum2} is {parsedNum1 + parsedNum2}.";
            
            return $"error '{num1}' and '{num2}' are not valid integers";
        }
    }
}