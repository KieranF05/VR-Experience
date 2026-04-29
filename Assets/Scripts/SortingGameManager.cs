using UnityEngine;

public class SortingGameManager : MonoBehaviour
{
    public BasketZone coalBasket;
    public BasketZone energyBasket;
    public GameObject door;
    public HingeJoint doorHinge;
    public AudioSource doorAudio;

    private bool opened = false;

    void Update()
    {
        if (opened) return;

        if (coalBasket.IsComplete() && energyBasket.IsComplete())
        {
            OpenDoor();
        }
    }

    void OpenDoor()
    {
        opened = true;

        Debug.Log("Puzzle Complete!");

        if (door != null)
        {
            JointLimits limits = doorHinge.limits;

            limits.min = 0;
            limits.max = 90;

            doorHinge.limits = limits;

            doorHinge.GetComponent<Rigidbody>().AddTorque(Vector3.up * 5f, ForceMode.Impulse);
        }

        if (doorAudio != null)
        {
            doorAudio.Play();
        }
    }
}
