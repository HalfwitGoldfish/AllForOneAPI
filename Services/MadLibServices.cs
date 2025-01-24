using AllForOneAPI.Models;

namespace AllForOneAPI.Services
{
    public class MadLibServices
    {
        public string MadLib( string animal, string name, string food, string toy, string age, string animal2, string name2, string food2, string toy2, string age2 )
        {
            return $"I have a {animal} Their name is {name} they like to eat {food}, and play with {toy}, they are {age} year(s) old, they have a friend who is a {animal2}, they're named {name2}, who likes to eat {food2}, and play with {toy2}, they are {age2} year(s) old.";
        }
    }
}