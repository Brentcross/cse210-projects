using System.Collections.Generic;

public class Pumpkin
{
    public Dictionary<Ingredient, int> GetIngredients()
    {
        return new Dictionary<Ingredient, int>
        {
            { Ingredient.PumpkinCans, 18 },
            { Ingredient.PumpkinBase, 2 },
            { Ingredient.Egg, 2 },
            { Ingredient.Water, 36 }
        };
    }
  public int GetMixingTime()
    {
        return 15;
    }

}
