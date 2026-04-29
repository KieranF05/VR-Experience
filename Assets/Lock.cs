using UnityEngine;

public class Lock : MonoBehaviour
{

    [SerializeField] GameObject door;
    [SerializeField] GameObject handle;
    [SerializeField] GameObject key;
    private bool locked;
    AudioSource audioSource;
    private bool opened = false;
    public HingeJoint doorHinge;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        locked = true;
        door.GetComponent<Rigidbody>().isKinematic = true;
        handle.GetComponent<BoxCollider>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "key" && locked)
        {
            UnlockDoor();
            audioSource = GetComponent<AudioSource>();
            if (audioSource != null)
                audioSource.Play();
        }
    }


    private void UnlockDoor()
    {
        door.GetComponent<Rigidbody>().isKinematic = false;
        handle.GetComponent<BoxCollider>().enabled = true;
        this.GetComponent<Rigidbody>().isKinematic = false;
        locked = false;

        opened = true;

        if (door != null)
        {
            JointLimits limits = doorHinge.limits;

            limits.min = 0;
            limits.max = 90;

            doorHinge.limits = limits;

            doorHinge.GetComponent<Rigidbody>().AddTorque(Vector3.up * 5f, ForceMode.Impulse);



        }
    }
}
