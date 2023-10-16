// time.cs

public static class MixingTime
{
    public static int Muffin => 15;  // minutes
    public static int Cheesecake => 30;  // minutes
    public static int DanishCream => 8;  // minutes
    public static int PumpkinPie => 12;  // minutes
    public static int Cake => 7;  // minutes

    public static int GetMixingTimeForBakedGood(string bakedGoodName)
    {
        switch (bakedGoodName.ToLower())
        {
            case "muffin":
                return Muffin;
            case "cheesecake":
                return Cheesecake;
            case "danishcream":
                return DanishCream;
            case "pumpkinpie":
                return PumpkinPie;
            case "cake":
                return Cake;
            default:
                throw new System.ArgumentException($"Unknown baked good: {bakedGoodName}");
        }
    }
}

