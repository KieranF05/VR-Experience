using UnityEngine;

public class Wire : MonoBehaviour
{
    public string correctSocketID;

    public float snapDistance = 0.5f; // how close before snapping

    private WireSocket currentSocket;
    private bool isSnapped = false;

    void Update()
    {
        if (isSnapped || currentSocket == null) return;

        float distance = Vector3.Distance(transform.position, currentSocket.snapPoint.position);

        if (distance <= snapDistance)
        {
            SnapToSocket(currentSocket);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        WireSocket socket = other.GetComponent<WireSocket>();

        if (socket != null)
        {
            currentSocket = socket;
        }
    }

    void OnTriggerExit(Collider other)
    {
        WireSocket socket = other.GetComponent<WireSocket>();

        if (socket == currentSocket)
        {
            currentSocket = null;
        }
    }

    void SnapToSocket(WireSocket socket)
    {
        transform.position = socket.snapPoint.position;
        transform.rotation = socket.snapPoint.rotation;

        transform.SetParent(socket.snapPoint);

        isSnapped = true;

        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
            rb.isKinematic = true;

        Debug.Log("Snapped!");
    }

    public bool IsCorrect()
    {
        return currentSocket != null && currentSocket.id == correctSocketID;
    }
}