using UnityEngine;

public class Drawer : MonoBehaviour
{
    public Vector3 openPosition;
    public float speed = 3f;

    private Vector3 closedPosition;
    private bool isOpen = false;
    public Drawer drawer;

    void Start()
    {
        closedPosition = transform.localPosition;
    }

    public void Open()
    {
        isOpen = true;
    }


    void OpenDrawer()
    {
        drawer.Open();
    }

    void Update()
    {
        if (!isOpen) return;

        transform.localPosition = Vector3.Lerp(
            transform.localPosition,
            openPosition,
            Time.deltaTime * speed
        );
    }
}