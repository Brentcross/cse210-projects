// cream.cs

using System.Collections.Generic;

public class Cream
{
    public Dictionary<Ingredient, int> GetIngredients()
    {
        return new Dictionary<Ingredient, int>
        {
            { Ingredient.Butter, 2 },
            { Ingredient.CremeCheese, 1 },
            { Ingredient.Sugar, 8 },
            { Ingredient.LemonJuice, 1 },
            { Ingredient.Egg, 2 }
        };
    }
  public int GetMixingTime()
    {
        return 5;
    }

}
