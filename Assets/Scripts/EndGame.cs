using UnityEngine;

public class EndGame : MonoBehaviour
{
    public FadeToWhite fade;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.root.CompareTag("Player"))

            Debug.Log("Game Complete!");

        if (fade != null)
            fade.StartFade();

        Time.timeScale = 0f;
    }
}
