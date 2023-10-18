using System.Collections.Generic;

[BakedGoodName("Cheesecake")]
public class Cheesecake : BakedGood
{
    public override Dictionary<Ingredient, int> GetIngredients()
    {
        return new Dictionary<Ingredient, int>
        {
            { Ingredient.CremeCheese, 3 },
            { Ingredient.Sugar, 25 },
            { Ingredient.Flour, 4 },
            { Ingredient.Salt, 2 },
            { Ingredient.Vanilla, 15 },
            { Ingredient.SourCream, 5 },
            { Ingredient.Egg, 15 },
            { Ingredient.Milk, 9 }
        };
    }

    public override int GetMixingTime()
    {
        return MixingTime.Cheesecake; 
    }
}
