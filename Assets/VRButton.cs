using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class VRButton : MonoBehaviour
{
    public int buttonID;
    public PuzzleManager puzzleManager;

    private XRSimpleInteractable interactable;

    public Vector3 pressedOffset = new Vector3(0, -0.01f, 0);
    private Vector3 startPos;
    Renderer rend;
    AudioSource audioSource;

    void Awake()
    {
        interactable = GetComponent<XRSimpleInteractable>();
        interactable.selectEntered.AddListener(OnPressed);
    }

    void Start()
    {
        startPos = transform.localPosition;
        rend = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            
        }
    }

    void OnPressed(SelectEnterEventArgs args)
    {
        Press();
    }

    
    void OnMouseDown()
    {
        Debug.Log("Mouse clicked button: " + buttonID);
        Press();
    }

    void Press()
    {
        Debug.Log("Button pressed: " + buttonID);

        transform.localPosition = startPos + pressedOffset;

        if (rend != null)
            rend.material.color = Color.green;

        puzzleManager.PressButton(buttonID);

        Invoke(nameof(ResetPosition), 0.2f);

        if (audioSource != null)
            audioSource.Play();

    }

    void ResetPosition()
    {
        transform.localPosition = startPos;
        if (rend != null)
            rend.material.color = Color.grey;
    }
}