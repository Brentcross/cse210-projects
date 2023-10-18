public enum Ingredient
{
    Water,
    Egg,
    Oil,
    Sugar,
    Vanilla,
    Blueberry,
    Poppy,
    ChocolateChips,
    Cocoa,
    Flour,
    CremeCake,
    CakeBase,
    SourCream,
    CremeCheese,
    LemonJuice,
    Butter,
    AlmondExtract,
    Milk,
    PumpkinBase,
    PumpkinCans,
    Salt
}

public static class IngredientExtensions
{

    public static string ToReadableString(this Ingredient ingredient)
    {
        switch (ingredient)
        {
            case Ingredient.Water: return "Water (in pounds)";
            case Ingredient.Egg: return "Egg (in bags)";
            case Ingredient.Oil: return "Oil (in pounds)";
            case Ingredient.Sugar: return "Sugar (in pounds)";
            case Ingredient.Vanilla: return "Vanilla (bottles)";
            case Ingredient.Blueberry: return "Blueberry (in pounds)";
            case Ingredient.Poppy: return "Poppy (in pounds)";
            case Ingredient.ChocolateChips: return "Chocolate Chips (in pounds)";
            case Ingredient.Cocoa: return "Cocoa (in pounds)";
            case Ingredient.Flour: return "Flour (in pounds)";
            case Ingredient.CremeCake: return "Creme Cake (bags)";
            case Ingredient.CakeBase: return "Cake Base (bags)";
            case Ingredient.SourCream: return "Sour Cream (bags)";
            case Ingredient.CremeCheese: return "Creme Cheese (blocks)";
            case Ingredient.LemonJuice: return "Lemon Juice (in pounds)";
            case Ingredient.Butter: return "Butter(in pounds)";
            case Ingredient.AlmondExtract: return "Almond Extract (in pounds)";
            case Ingredient.Milk: return "Milk (in pounds)";
            case Ingredient.PumpkinBase: return "Pumpkin Base (bags)";
            case Ingredient.PumpkinCans: return "Pumpkin Cans";
            case Ingredient.Salt: return "Salt (in ounces)";
            default: throw new System.ArgumentException($"Unknown ingredient: {ingredient}");

        }
    }
}
