using UnityEngine;

public class BasketZone : MonoBehaviour
{
    public string requiredTag;
    public int requiredCount = 2;

    public AudioSource audioSource;

    private int currentCount = 0;

    public AudioClip correctSound;
    public AudioClip wrongSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(requiredTag))
        {
            currentCount++;
            Debug.Log(requiredTag + " added: " + currentCount);

            if (audioSource != null && correctSound != null)
                audioSource.PlayOneShot(correctSound);
        }

        else
        {
            Debug.Log("Wrong item");

            if (audioSource != null && wrongSound != null)
                audioSource.PlayOneShot(wrongSound);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(requiredTag))
        {
            currentCount--;
        }
    }

    public bool IsComplete()
    {
        return currentCount >= requiredCount;
    }
}
