namespace AllForOneAPI.Services
{
    public class ReverseItAlphanumericServices
    {
        public string ReverseItAlpha(string input)
        {
            string reverse = "";
            for(int i = input.Length - 1; i >= 0; i--){
                reverse += input[i];
            }
            return $"Your input of '{input}' when reversed comes out as '{reverse}'";
        }
    }
}