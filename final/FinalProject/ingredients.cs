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
            case Ingredient.Water: return "Water";
            case Ingredient.Egg: return "Egg";
            case Ingredient.Oil: return "Oil";
            case Ingredient.Sugar: return "Sugar";
            case Ingredient.Vanilla: return "Vanilla";
            case Ingredient.Blueberry: return "Blueberry";
            case Ingredient.Poppy: return "Poppy";
            case Ingredient.ChocolateChips: return "Chocolate Chips";
            case Ingredient.Cocoa: return "Cocoa";
            case Ingredient.Flour: return "Flour";
            case Ingredient.CremeCake: return "Creme Cake";
            case Ingredient.CakeBase: return "Cake Base";
            case Ingredient.SourCream: return "Sour Cream";
            case Ingredient.CremeCheese: return "Creme Cheese";
            case Ingredient.LemonJuice: return "Lemon Juice";
            case Ingredient.Butter: return "Butter";
            case Ingredient.AlmondExtract: return "Almond Extract";
            case Ingredient.Milk: return "Milk";
            case Ingredient.PumpkinBase: return "Pumpkin Base";
            case Ingredient.PumpkinCans: return "Pumpkin Cans";
            case Ingredient.Salt: return "Salt";
            default: throw new System.ArgumentException($"Unknown ingredient: {ingredient}");

        }
    }
}
