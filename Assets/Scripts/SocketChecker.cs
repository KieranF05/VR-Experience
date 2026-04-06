using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

public class SocketChecker : MonoBehaviour
{
    public XRSocketInteractor socket;

    void OnEnable()
    {
        socket.selectEntered.AddListener(OnPlugInserted);
    }

    void OnDisable()
    {
        socket.selectEntered.RemoveListener(OnPlugInserted);
    }

    void OnPlugInserted(SelectEnterEventArgs args)
    {
        VRWire wire = args.interactableObject.transform.GetComponent<VRWire>();

        if (wire != null)
        {
            wire.CheckConnection(socket);
        }
    }
}
