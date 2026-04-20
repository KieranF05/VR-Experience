using UnityEngine;

public class DrawerController : MonoBehaviour
{
    public Vector3 openOffset = new Vector3(0, 0, 0.3f);
    public float speed = 2f;

    private Vector3 closedPos;
    private Vector3 openPos;
    private bool isOpening = false;
    AudioSource audioSource;

    void Start()
    {
        closedPos = transform.localPosition;
        openPos = closedPos + openOffset;
    }

    void Update()
    {
        if (isOpening)
        {
            transform.localPosition = Vector3.Lerp(
                transform.localPosition,
                openPos,
                Time.deltaTime * speed
            );

            if (Vector3.Distance(transform.localPosition, openPos) < 0.001f)
            {
                transform.localPosition = openPos;
                isOpening = false;
            }
        }
    }

    public void OpenDrawer()
    {
        isOpening = true;
        audioSource = GetComponent<AudioSource>();
        if (audioSource != null)
            audioSource.Play();
    }
}