using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class FishInteraction : MonoBehaviour
{
    public AudioSource audioSource;
    public Animator animator;

    private XRGrabInteractable grab;

    private void Awake()
    {
        grab = GetComponent<XRGrabInteractable>();

        grab.selectEntered.AddListener(OnGrab);
        grab.selectExited.AddListener(OnRelease);
    }

    void OnGrab(SelectEnterEventArgs args)
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }

        if (animator != null)
        {
            animator.SetBool("IsHeld", true);
        }

    }

   

    void OnRelease(SelectExitEventArgs args)
    {
        if (audioSource != null)
        {
            audioSource.Stop();
        }

        if (animator != null)
        {
            animator.SetBool("IsHeld", false);
        }
    }
}
