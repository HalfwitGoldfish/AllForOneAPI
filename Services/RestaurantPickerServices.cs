using AllForOneAPI.Models;

namespace AllForOneAPI.Services
{
    public class RestaurantPickerServices
    {
        public List<RestaurantPickerModel> RestaurantPickerRestaurants =
        [
            new RestaurantPickerModel { Type = "Chinese", Restaurant = ["Golden Palace", "China Village", "Yen Du", "Sun Wong Kee", "The Chopstick", "Louies Chinese Restaurant", "Shermans Chinese Buffet", "Johnny Wokker", "New Shanghai", "M Kitchen Buffet"] },

            new RestaurantPickerModel { Type = "Italian", Restaurant = ["Olive Garden", "Pietros", "De Vega Brothers", "Brick House Restaurant and Lounge", "Angelinas", "De Parsia Restaurant", "Noni Vita", "Nonas Restaurant", "De Vincis Delecatessen", "Mezzo"] },

            new RestaurantPickerModel { Type = "American", Restaurant =["Flips Burgers", "Apple Bees Grill and Bar", "Fat City Brew and BBQ", "BJs Restaurant and Brewhouse", "Bourbon Street Bar and Grill", "El Rancho Inn Stake and Lobster House", "Heritage Dining and Provisions", "Victory Grill", "Waterloo Club", "Cast Iron Trading"] }
        ];

        public string RestaurantPicker(string type)
        {
            Random rng = new();
            int num = rng.Next(0, 10);
            if (type.ToLower() == "chinese")
                return $"Because you picked '{RestaurantPickerRestaurants[0].Type} Food', I recommend '{RestaurantPickerRestaurants[0].Restaurant![num]}'";

            if (type.ToLower() == "italian")
                return $"Because you picked '{RestaurantPickerRestaurants[1].Type} Food', I recommend '{RestaurantPickerRestaurants[1].Restaurant![num]}'";

            if (type.ToLower() == "american")
                return $"Because you picked '{RestaurantPickerRestaurants[2].Type} Food', I recommend '{RestaurantPickerRestaurants[2].Restaurant![num]}'";

            return $"the options are 'Chinese', 'Italian', and 'American'";
        }
    }
}