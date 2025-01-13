namespace AllForOneAPI.Services
{
    public class GuessItServices
    {
        public string GuessItEasy(string guess)
        {
            int parsedGuess;
            bool numeric = int.TryParse(guess, out parsedGuess);
            
            Random rng = new();
            int num = rng.Next(1, 11);
            if (numeric)
            {
                if (parsedGuess == num)
                    return "You got it!";

                if (parsedGuess > num)
                    return $"Sorry, that was too high. It was {num}.";

                if (parsedGuess < num)
                    return $"Sorry, that was too low. It was {num}.";
            }
            return $"Please enter a valid Integer";
        }

        public string GuessItMedium(string guess)
        {
            int parsedGuess;
            bool numeric = int.TryParse(guess, out parsedGuess);
            
            Random rng = new();
            int num = rng.Next(1, 51);
            if (numeric)
            {
                if (parsedGuess == num)
                    return "You got it!";

                if (parsedGuess > num)
                    return $"Sorry, that was too high. It was {num}.";

                if (parsedGuess < num)
                    return $"Sorry, that was too low. It was {num}.";
            }
            return $"Please enter a valid Integer";
        }

        public string GuessItHard(string guess)
        {
            int parsedGuess;
            bool numeric = int.TryParse(guess, out parsedGuess);
            
            Random rng = new();
            int num = rng.Next(1, 101);
            if (numeric)
            {
                if (parsedGuess == num)
                    return "You got it!";

                if (parsedGuess > num)
                    return $"Sorry, that was too high. It was {num}.";

                if (parsedGuess < num)
                    return $"Sorry, that was too low. It was {num}.";
            }
            return $"Please enter a valid Integer";
        }
    }
}