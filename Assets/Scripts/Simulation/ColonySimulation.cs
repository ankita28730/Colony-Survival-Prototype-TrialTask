public class ColonySimulation
{
    public int villagers { get; }

    public float FoodStored { get; private set; }
    public float WaterStored { get; private set; }

    public int GameDay { get; private set; }

    public float DailyFoodConsumption { get; }
    public float DailyWaterConsumption { get; }

    public bool IsStarving =>
        FoodStored <= 0f || WaterStored <= 0f;

    public float FoodDaysRemaining =>
        DailyFoodConsumption > 0f
            ? FoodStored / DailyFoodConsumption
            : 0f;

    public float WaterDaysRemaining =>
        DailyWaterConsumption > 0f
            ? WaterStored / DailyWaterConsumption
            : 0f;

    public ColonySimulation(
        PopulationConfig population,
        ConsumptionConfig consumption)
    {
        villagers = population.villagers;

        FoodStored = population.StartingFoodReserves;
        WaterStored = population.StartingWaterReserves;

        DailyFoodConsumption =
            population.villagers *
            consumption.foodPerVillagerPerDay;

        DailyWaterConsumption =
            population.villagers *
            consumption.waterPerVillagerPerDay;

        GameDay = 0;
    }

    public void AdvanceOneDay()
    {
        if (IsStarving)
            return;

        FoodStored -= DailyFoodConsumption;
        WaterStored -= DailyWaterConsumption;

        if (FoodStored < 0f)
            FoodStored = 0f;

        if (WaterStored < 0f)
            WaterStored = 0f;

        GameDay++;
    }
}