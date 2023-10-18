using System.Collections.Generic;

[BakedGoodName("Cake")]
public class Cake : BakedGood
{
    public override Dictionary<Ingredient, int> GetIngredients()
    {
        return new Dictionary<Ingredient, int>
        {
            { Ingredient.Water, 30 },
            { Ingredient.Oil, 5 },
            { Ingredient.CakeBase, 2 }
        };
    }

    public override int GetMixingTime()
    {
        return 7;
    }
}
