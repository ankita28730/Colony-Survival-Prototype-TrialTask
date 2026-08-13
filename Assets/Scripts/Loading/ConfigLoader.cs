using UnityEngine;

public class ConfigLoader : MonoBehaviour
{
    public PopulationConfig Population { get; private set; }
    public ConsumptionConfig Consumption { get; private set; }

    private void Awake()
    {
        LoadConfigs();
    }

    private void LoadConfigs()
    {
        TextAsset populationFile =
            Resources.Load<TextAsset>("Population");

        TextAsset consumptionFile =
            Resources.Load<TextAsset>("Consumption");

        if (populationFile == null)
        {
            Debug.LogError("population.json could not be found.");
            return;
        }

        if (consumptionFile == null)
        {
            Debug.LogError("consumption.json could not be found.");
            return;
        }

        Population =
            JsonUtility.FromJson<PopulationConfig>(
                populationFile.text);

        Consumption =
            JsonUtility.FromJson<ConsumptionConfig>(
                consumptionFile.text);

        Debug.Log("Configuration loaded successfully.");
    }
}