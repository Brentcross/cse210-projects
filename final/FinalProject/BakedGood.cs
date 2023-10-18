using System.Collections.Generic;

public abstract class BakedGood
{
    public abstract Dictionary<Ingredient, int> GetIngredients();
    public abstract int GetMixingTime();
}
