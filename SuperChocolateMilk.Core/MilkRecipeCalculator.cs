namespace SuperChocolateMilk.Core;

public class MilkRecipeCalculator
{
    public static decimal CalculateChocolateSyrupRequired(int milkVolumeM1, string richnessLevel)
    {
        if (milkVolumeM1 <= 0) return 0m;
        
        decimal baseSyrupM1 = milkVolumeM1 * 0.1m;
        
        return richnessLevel.ToUpper() switch
        {
            "LIGHT" => baseSyrupM1 * 0.75m,
            "MEDIUM" => baseSyrupM1,
            "EXTRA" => baseSyrupM1 * 1.5m,
            "ULTRA_CHOCO" => baseSyrupM1 * 2.0m,
            _ => baseSyrupM1
        };
    }

}
