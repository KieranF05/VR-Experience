using UnityEngine;
using UnityEngine.XR;

public class HMD_Manager : MonoBehaviour
{
    [SerializeField] GameObject xrPlayer;
    [SerializeField] GameObject fpsPlayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Using Device:" + XRSettings.loadedDeviceName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
