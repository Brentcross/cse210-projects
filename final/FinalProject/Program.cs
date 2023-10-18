using System;
using System.Collections.Generic;
using System.Linq;

namespace BakingApplication
{
    class Program
    {
        private static Dictionary<Ingredient, int> ingredientsInBasket = new Dictionary<Ingredient, int>();
        private static int totalMixingTime = 0;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                DisplayMenu();
                int choice = int.Parse(Console.ReadLine());

                Type[] bakedGoodsTypes = GetBakedGoodsTypes();
                if (choice >= 1 && choice <= bakedGoodsTypes.Length)
                {
                    HandleBakedGoodSelection(bakedGoodsTypes[choice - 1]);
                }
                else if (choice == bakedGoodsTypes.Length + 1)
                {
                    DisplayTotalMixingTime();
                }
                else if (choice == bakedGoodsTypes.Length + 2)
                {
                    DisplayIngredients();
                }
                else if (choice == bakedGoodsTypes.Length + 3)
                {
                    break;
                }
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Select a baked good to add to your basket:");
            Type[] bakedGoodsTypes = GetBakedGoodsTypes();
            for (int i = 0; i < bakedGoodsTypes.Length; i++)
            {
                var nameAttribute = (BakedGoodNameAttribute)bakedGoodsTypes[i].GetCustomAttributes(typeof(BakedGoodNameAttribute), false).FirstOrDefault();
                Console.WriteLine($"{i + 1}. {nameAttribute?.Name ?? bakedGoodsTypes[i].Name}");
            }

            Console.WriteLine($"{bakedGoodsTypes.Length + 1}. Display total mixing time");
            Console.WriteLine($"{bakedGoodsTypes.Length + 2}. Display ingredients");
            Console.WriteLine($"{bakedGoodsTypes.Length + 3}. Exit");
        }

        private static Type[] GetBakedGoodsTypes()
        {
            return AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => typeof(BakedGood).IsAssignableFrom(p) && !p.IsAbstract)
                .ToArray();
        }
        private static void HandleBakedGoodSelection(Type bakedGoodType)
        {
            BakedGood bakedGood;

    if (bakedGoodType == typeof(Muffin))
    {
        Console.WriteLine("Choose the muffin type:");
        Console.WriteLine("1. Blueberry");
        Console.WriteLine("2. Poppy");
        Console.WriteLine("3. Vanilla");
        Console.WriteLine("4. Chocolate");

        int choice;
        if(!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 4)
        {
            Console.WriteLine("Invalid selection. Returning to the main menu.");
            return;
        }

        var muffinType = (MuffinType)choice;
        bakedGood = new Muffin(muffinType);
    }
    else
    {
        bakedGood = (BakedGood)Activator.CreateInstance(bakedGoodType);
    }
            totalMixingTime += bakedGood.GetMixingTime(); 
            AddIngredients(bakedGood.GetIngredients());
    


}
        private static void AddIngredients(Dictionary<Ingredient, int> ingredientsToAdd)
        {
            foreach (var ingredient in ingredientsToAdd)
            {
                if (ingredientsInBasket.ContainsKey(ingredient.Key))
                {
                    ingredientsInBasket[ingredient.Key] += ingredient.Value;
                }
                else
                {
                    ingredientsInBasket[ingredient.Key] = ingredient.Value;
                }
            }
        }
        

        private static void DisplayTotalMixingTime()
        {
            Console.WriteLine($"Total mixing time: {totalMixingTime} minutes of mixing time alone");
            Console.ReadLine();

        }

        private static void DisplayIngredients()
        {
            Console.WriteLine("Ingredients required for the day:");
            foreach (var ingredient in ingredientsInBasket)
            {
                Console.WriteLine($"{ingredient.Key.ToReadableString()}: {ingredient.Value}");
            }
            Console.ReadLine();
        }
    }
    
}
