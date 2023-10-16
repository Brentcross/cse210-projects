using System.Collections.Generic;

public class Cake
{
    public Dictionary<Ingredient, int> GetIngredients()
    {
        return new Dictionary<Ingredient, int>
        {
            { Ingredient.Water, 30 },
            { Ingredient.Oil, 5 },
            { Ingredient.CakeBase, 2 }
        };
    }
  public int GetMixingTime()
    {
        return 7;
    }
}
