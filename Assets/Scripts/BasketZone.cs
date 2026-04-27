using UnityEngine;

public class BasketZone : MonoBehaviour
{
    public string requiredTag;
    public int requiredCount = 2;

    private int currentCount = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(requiredTag))
        {
            currentCount++;
            Debug.Log(requiredTag + " added: " + currentCount);
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
