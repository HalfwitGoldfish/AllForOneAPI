namespace AllForOneAPI.Services
{
    public class OddOrEvenServices
    {
        public string OddOrEven(string num)
        {
            int parsedNum;
            bool numeric = int.TryParse(num, out parsedNum);
            if(numeric){
                if(parsedNum % 2 == 0){
                    return $"{parsedNum} is an even number";
                }
                return $"{parsedNum} in an odd number";
            }
            return $"error '{num}' is not a valid integer";
        }
    }
}