namespace AllForOneAPI.Services
{
    public class ReverseItNumericServices
    {
        public string ReverseItNum(string num)
        {
            int parsedNum;
            bool numeric = int.TryParse(num, out parsedNum);
            if(numeric){
                int left = parsedNum;
                int reverse = 0;
                while(Convert.ToBoolean(left)){
                    int r = left % 10;
                    reverse = reverse * 10 + r;
                    left /= 10;
                }
                return $"Your number of '{parsedNum}' when reversed is '{reverse}'";
            }
            return $"error '{num}' is not a valid integer";
        }
    }
}