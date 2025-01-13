using AllForOneAPI.Models;

namespace AllForOneAPI.Services
{
    public class MadLibServices
    {
        public string MadLib(MadLibModel madLibModel)
        {
            return $"I have a {madLibModel.animal} Their name is {madLibModel.name} they like to eat {madLibModel.food}, and play with {madLibModel.toy}, they are {madLibModel.age} year(s) old, they have a friend who is a {madLibModel.animal2}, they're named {madLibModel.name2}, who likes to eat {madLibModel.food2}, and play with {madLibModel.toy2}, they are {madLibModel.age2} year(s) old.";
        }
    }
}