using System.Collections.Generic;

public class Muffin
{
    private MuffinType Type { get; set; }

    private readonly Dictionary<Ingredient, int> baseIngredients = new Dictionary<Ingredient, int>
    {
        { Ingredient.Water, 32 },
        { Ingredient.CremeCake, 2 },
        { Ingredient.Egg, 2 },
        { Ingredient.Oil, 30 }
        
    };

    public Muffin(MuffinType type)
    {
        Type = type;
        
    }

    public Dictionary<Ingredient, int> GetIngredients()
    {
        var ingredients = new Dictionary<Ingredient, int>(baseIngredients);

        switch (Type)
        {
            case MuffinType.Blueberry:
                ingredients.Add(Ingredient.Blueberry, 24);
                break;
            case MuffinType.Poppy:
                ingredients.Add(Ingredient.Poppy, 6);
                ingredients.Add(Ingredient.AlmondExtract, 1);
                break;
            case MuffinType.Vanilla:
                ingredients.Add(Ingredient.Vanilla, 2); 
                ingredients.Add(Ingredient.ChocolateChips, 22);
                break;
            case MuffinType.Chocolate:
                ingredients.Add(Ingredient.Cocoa, 6);
                ingredients.Add(Ingredient.ChocolateChips, 24);
                break;
            default:
                throw new System.ArgumentException("Invalid muffin type");
        }

        return ingredients;
    }
    public int GetMixingTime()
    {
        return 10; 
    }

}