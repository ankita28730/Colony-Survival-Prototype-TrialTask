using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [Header("UI References")]
    [SerializeField] private TMP_Text foodText;
    [SerializeField] private TMP_Text waterText;
    [SerializeField] private TMP_Text foodDaysText;
    [SerializeField] private TMP_Text waterDaysText;
    [SerializeField] private TMP_Text dayText;
    [SerializeField] private TMP_Text starvingText;

    private ColonySimulation simulation;
    private float timer;

    private void Start()
    {
        PopulationConfig population = LoadPopulation();
        ConsumptionConfig consumption = LoadConsumption();

        simulation = new ColonySimulation(population, consumption);

        starvingText.gameObject.SetActive(false);

        UpdateUI();
    }

    private void Update()
    {
        if (simulation == null || simulation.IsStarving)
            return;

        timer += Time.deltaTime;

        if (timer >= 1f)
        {
            timer = 0f;

            simulation.AdvanceOneDay();

            UpdateUI();

            if (simulation.IsStarving)
            {
                starvingText.gameObject.SetActive(true);
            }
        }
    }

    private void UpdateUI()
    {
        foodText.text =
            $"Food: {simulation.FoodStored:0}";

        waterText.text =
            $"Water: {simulation.WaterStored:0}";

        foodDaysText.text =
            $"Food Days: {simulation.FoodDaysRemaining:0.0}";

        waterDaysText.text =
            $"Water Days: {simulation.WaterDaysRemaining:0.0}";

        dayText.text =
            $"Day: {simulation.GameDay}";
    }

    private PopulationConfig LoadPopulation()
    {
        TextAsset file = Resources.Load<TextAsset>("population");

        return JsonUtility.FromJson<PopulationConfig>(file.text);
    }

    private ConsumptionConfig LoadConsumption()
    {
        TextAsset file = Resources.Load<TextAsset>("consumption");

        return JsonUtility.FromJson<ConsumptionConfig>(file.text);
    }
}