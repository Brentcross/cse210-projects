using System.Collections.Generic;

[BakedGoodName("Muffin")]
public class Muffin : BakedGood
{
    private MuffinType _type;

    private readonly Dictionary<Ingredient, int> _baseIngredients = new Dictionary<Ingredient, int>
    {
        { Ingredient.Water, 32 },
        { Ingredient.CremeCake, 2 },
        { Ingredient.Egg, 2 },
        { Ingredient.Oil, 30 }
    };

    public Muffin(MuffinType type)
    {
        _type = type;
    }

    public override Dictionary<Ingredient, int> GetIngredients()
    {
        var ingredients = new Dictionary<Ingredient, int>(_baseIngredients);

        switch (_type)
        {
            case MuffinType.Blueberry:
                ingredients[Ingredient.Blueberry] = 24;
                break;
            case MuffinType.Poppy:
                ingredients[Ingredient.Poppy] = 6;
                ingredients[Ingredient.AlmondExtract] = 1;
                break;
            case MuffinType.Vanilla:
                ingredients[Ingredient.Vanilla] = 2; 
                ingredients[Ingredient.ChocolateChips] = 22;
                break;
            case MuffinType.Chocolate:
                ingredients[Ingredient.Cocoa] = 6;
                ingredients[Ingredient.ChocolateChips] = 24;
                break;
            default:
                throw new System.ArgumentException("Invalid muffin type");
        }

        return ingredients;
    }

    public override int GetMixingTime()
    {
        return 10; 
    }

    public MuffinType GetMuffinType()
    {
        return _type;
    }

    public void SetMuffinType(MuffinType type)
    {
        _type = type;
    }
}
