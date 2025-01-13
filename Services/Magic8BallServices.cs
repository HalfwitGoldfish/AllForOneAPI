namespace AllForOneAPI.Services
{
    public class Magic8BallServices
    {
        public string MagicBall(string question)
        {
            Random rng = new();
            return rng.Next(1, 9) switch {
                1 => "It is certain",
                2 =>  "It is decidedly so",
                3 => "Without a doubt",
                4 => "Yes definitely",
                5 => "You may rely on it",
                6 => "As I see it, yes",
                7 => "Most likely",
                8 => "Outlook good",
                _ => "Signs point to yes"
            };
        }
    }
}