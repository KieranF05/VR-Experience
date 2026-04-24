using UnityEngine;

public class StartCO2 : MonoBehaviour
{
    public CO2Controller co2;

    private void Start()
    {
        if (co2 != null)
        {
            co2.StartGas();
        }
    }
}
