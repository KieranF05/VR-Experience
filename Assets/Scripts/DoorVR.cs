using UnityEngine;

public class DoorVR : MonoBehaviour
{
    public Transform openTarget;
    public float speed = 2f;
    private bool opening = false;

    public void OpenDoor()
    {
        opening = true;
    }

    void Update()
    {
        if (opening)
        {
            transform.position = Vector3.Lerp(
                transform.position,
                openTarget.position,
                Time.deltaTime * speed
            );
        }
    }
}