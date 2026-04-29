using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject endUI;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))

            Debug.Log("Game Complete!");

        if (endUI != null)
            endUI.SetActive(true);
    }
}
