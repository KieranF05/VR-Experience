using UnityEngine;

public class VRPuzzleManager : MonoBehaviour
{
    public VRWire[] wires;
    public DoorVR door;
    private bool solved = false;

    void Update()
    {
        if (!solved && AllConnected())
        {
            solved = true;
            door.OpenDoor();
        }
    }

    bool AllConnected()
    {
        foreach (VRWire wire in wires)
        {
            if (!wire.IsConnected())
                return false;
        }
        return true;
    }
}
