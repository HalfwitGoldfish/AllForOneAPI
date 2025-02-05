namespace AllForOneAPI.Services
{
    public class AskingQuestionsServices
    {
        public string NameAndTime(string name, string time)
        {
            return $"Your name is {name}, and the time you woke up is {time}.";
        }
    }
}