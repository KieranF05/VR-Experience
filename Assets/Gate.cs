using UnityEngine;

public class Gate : MonoBehaviour
{


    [SerializeField] Animator animator;
    [SerializeField] GameObject ActiveStrip;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        ActiveStrip.SetActive(false);
        GameEvents.current.eventCradleActive += OpenGate;
        GameEvents.current.eventCradleDeactive += CloseGate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OpenGate()
    {
        ActiveStrip.SetActive(true);
        animator.SetBool("open", true);
    }

    private void CloseGate()
    {
        ActiveStrip.SetActive(false);
        animator.SetBool("open", false);
    }

}
