using System;
using System.Collections.Generic;

class Program
{
    private static Dictionary<Ingredient, int> totalIngredients = new Dictionary<Ingredient, int>();
    private static Dictionary<Type, int> batchesMade = new Dictionary<Type, int>();

    static void Main()
    {
        Console.WriteLine("Welcome to the bakery!");

        while (true)
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Make Muffins");
            Console.WriteLine("2. Make Cheesecake");
            Console.WriteLine("3. Make Danish Cream");
            Console.WriteLine("4. Make Pumpkin Pie");
            Console.WriteLine("5. Make Cake");
            Console.WriteLine("6. Get Total Ingredients");
            Console.WriteLine("7. Get Total Mixing Time");
            Console.WriteLine("8. Exit");

            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    HandleMuffinSelection();
                    break;
                case "2":
                    HandleCheesecakeSelection();
                    break;
                case "3":
                    HandleCreamSelection();
                    break;
                case "4":
                    HandlePumpkinPieSelection();
                    break;
                case "5":
                    HandleCakeSelection();
                    break;
                case "6":
                    DisplayTotalIngredients();
                    break;
                case "7":
                    DisplayTotalMixingTime();
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    static void HandleMuffinSelection()
    {
        var muffin = new Muffin(MuffinType.Blueberry);
        AddIngredients(muffin.GetIngredients(), typeof(Muffin), 1);
    }

    static void HandleCheesecakeSelection()
    {

        var cheesecake = new Cheesecake();
        AddIngredients(cheesecake.GetIngredients(), typeof(Cheesecake), 1);
    }
    static void HandleCreamSelection()
{

    var cream = new Cream();
    AddIngredients(cream.GetIngredients(), typeof(Cream), 1);
}

static void HandlePumpkinPieSelection()
{

    var pumpkinPie = new PumpkinPie();
    AddIngredients(pumpkinPie.GetIngredients(), typeof(PumpkinPie), 1);
}

static void HandleCakeSelection()
{
 
    var cake = new Cake();
    AddIngredients(cake.GetIngredients(), typeof(Cake), 1);
}


public class Cream
{
    public Dictionary<Ingredient, int> GetIngredients()
    {

        return new Dictionary<Ingredient, int>();
    }

    public int GetMixingTime()
    {
        return 12; 
    }
}


public class PumpkinPie
{
    public Dictionary<Ingredient, int> GetIngredients()
    {

        return new Dictionary<Ingredient, int>();
    }

    public int GetMixingTime()
    {
        return 20; 
    }
}
public class Cake
{
    public Dictionary<Ingredient, int> GetIngredients()
    {

        return new Dictionary<Ingredient, int>();
    }

    public int GetMixingTime()
    {
        return 25; 
    }
}

    static void AddIngredients(Dictionary<Ingredient, int> ingredients, Type recipeType, int batchCount)
    {
        foreach (var ingredient in ingredients)
        {
            if (totalIngredients.ContainsKey(ingredient.Key))
                totalIngredients[ingredient.Key] += ingredient.Value;
            else
                totalIngredients[ingredient.Key] = ingredient.Value;
        }

        if (batchesMade.ContainsKey(recipeType))
            batchesMade[recipeType] += batchCount;
        else
            batchesMade[recipeType] = batchCount;
    }

    static void DisplayTotalIngredients()
    {
        Console.WriteLine("\nTotal Ingredients Needed:");
        foreach (var ingredient in totalIngredients)
            Console.WriteLine($"{ingredient.Key}: {ingredient.Value}");
    }

    static void DisplayTotalMixingTime()
    {
        int totalMixingTime = 0;
        if (batchesMade.ContainsKey(typeof(Muffin)))
            totalMixingTime += new Muffin(MuffinType.None).GetMixingTime() * batchesMade[typeof(Muffin)];



        Console.WriteLine($"Total Mixing Time Needed: {totalMixingTime} minutes");
    }

public class Muffin
{
    private MuffinType Type { get; set; }

    public Muffin(MuffinType type)
    {
        Type = type;
    }

    public Dictionary<Ingredient, int> GetIngredients()
    {
        return new Dictionary<Ingredient, int>();
    }

    public int GetMixingTime()
    {
        return 10;
    }
}

public class Cheesecake
{
    public Dictionary<Ingredient, int> GetIngredients()
    {

        return new Dictionary<Ingredient, int>();
    }
    public int GetMixingTime()
    {
        return 15;
    }
}


public enum MuffinType
{
    None,
    Blueberry,
    Poppy,
    Vanilla,
    Chocolate
}

public enum Ingredient
{
    Flour,
    Sugar,
    Egg,
    Water
}
}