// time.cs

public static class MixingTime
{
    public static int Muffin => 10; 
    public static int Cake => 7;
    public static int Cream => 5; 
    public static int Pumpkin => 15; 
    public static int Cheesecake => 25; 

    public static int GetMixingTimeForBakedGood(string bakedGoodName)
    {
        switch (bakedGoodName.ToLower())
        {
            case "muffin":
                return Muffin;
            case "cake":
                return Cake;
            case "cream":
                return Cream;
            case "pumpkin":
                return Pumpkin;
            case "cheesecake":
                return Cheesecake;
            default:
                throw new System.ArgumentException($"Unknown baked good: {bakedGoodName}");
        }
    }
}
