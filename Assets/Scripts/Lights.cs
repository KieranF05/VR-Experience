using UnityEngine;

public class Lights : MonoBehaviour
{
    public Light[] labLights;

    private bool activated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (activated) return;

        if (other.CompareTag("cradleBall"))
        {
            Debug.Log("Energy Core Inserted");

            ActivatePower();

        }
    }


    void ActivatePower()
    {
        activated = true;

        foreach (Light light in labLights)
        {
            if (light != null)
                light.enabled = true;

        }
    }
}


