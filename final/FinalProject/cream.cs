using System.Collections.Generic;

[BakedGoodName("Cream")]
public class Cream : BakedGood
{
    public override Dictionary<Ingredient, int> GetIngredients()
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

    public override int GetMixingTime()
    {
        return 5;
    }
}
