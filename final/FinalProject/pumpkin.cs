using System.Collections.Generic;

[BakedGoodName("Pumpkin")]
public class Pumpkin : BakedGood
{
    public override Dictionary<Ingredient, int> GetIngredients()
    {
        return new Dictionary<Ingredient, int>
        {
            { Ingredient.PumpkinCans, 18 },
            { Ingredient.PumpkinBase, 2 },
            { Ingredient.Egg, 2 },
            { Ingredient.Water, 36 }
        };
    }

    public override int GetMixingTime()
    {
        return 15;
    }
}
