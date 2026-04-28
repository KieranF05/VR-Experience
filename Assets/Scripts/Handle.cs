using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class Handle : MonoBehaviour
{
    public XRSimpleInteractable interactable;

    void Start()
    {
        interactable.enabled = false;
    }

    public void Unlock()
    {
        interactable.enabled = true;    
    }

}
