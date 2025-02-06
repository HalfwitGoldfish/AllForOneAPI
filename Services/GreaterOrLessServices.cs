namespace AllForOneAPI.Services
{
    public class GreaterOrLessServices
    {
        public string GreaterOrLess(string num1, string num2)
        {
            int parsed1;
            int parsed2;
            bool numeric = int.TryParse( num1, out parsed1 );
            bool numeric2 = int.TryParse( num2, out parsed2 );

            if ( numeric && numeric2 )
            {
                if(parsed1 < parsed2){
                    return $"{parsed1} is less than {parsed2} : {parsed2} is greater than {parsed1}";
                }else if(parsed1 > parsed2){
                    return $"{parsed1} is greater than {parsed2} : {parsed2} is less than {parsed1}";
                }else{
                    return $"{parsed1} is equal to {parsed2}";
                }
            }
            return $"either {num1} or {num2} is not a valid integer";
        }
    }
}