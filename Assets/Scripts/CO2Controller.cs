using UnityEngine;
using System.Collections;

public class CO2Controller : MonoBehaviour
{
    public  ParticleSystem gas;
    public float fogStart = 30f;
    public float fogEnd = 10f;

    private bool active = false;

    void Update()
    {
        if (active)
        {
            RenderSettings.fogEndDistance -= Time.deltaTime * 2f;

        }
    }

    public void StartGas()
    {
        active = true;

        if (gas != null)
            gas.Play();

        RenderSettings.fog = true;
        RenderSettings.fogEndDistance = fogStart;
    }

    public void StopGas()
    {
        active = false;

        if (gas != null)
            gas.Stop();

        RenderSettings.fogEndDistance = fogEnd;
    
    }

}
