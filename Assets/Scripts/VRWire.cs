using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class VRWire : MonoBehaviour
{
    public XRSocketInteractor correctSocket;
    private bool isConnected = false;

    public void CheckConnection(XRSocketInteractor socket)
    {
        if (socket == correctSocket)
        {
            isConnected = true;
            Debug.Log("Correct wire!");
        }
        else
        {
            Debug.Log("Wrong socket!");
        }
    }

    public bool IsConnected()
    {
        return isConnected;
    }
}