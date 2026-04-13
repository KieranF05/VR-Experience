using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameTimer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public float startDelay = 2f;
    public TMP_Text timerText; 

    private bool timerIsRunning = false;

    void Start()
    {
        Invoke(nameof(StartTimer), startDelay);
    }

    void StartTimer()
    {
        timerIsRunning = true;
    }

    void Update()
    {
        if (!timerIsRunning) return;

        timeRemaining -= Time.deltaTime;

        if (timeRemaining <= 0f)
        {
            timeRemaining = 0f;
            UpdateTimerDisplay(timeRemaining); // show 0 immediately
            timerIsRunning = false;
            EndGame();
            return;
        }

        UpdateTimerDisplay(timeRemaining);
    }

    void UpdateTimerDisplay(float time)
    {
        if (timerText == null) return;

        int seconds = Mathf.FloorToInt(time);
        timerText.text = seconds.ToString();
    }

    void EndGame()
    {
        Debug.Log("Game Over!");

        if (timerText != null)
            timerText.text = "GAME OVER";

        Invoke(nameof(RestartScene), 2f); // optional delay so player can see message
    }

    void RestartScene()
    {
        Time.timeScale = 1f; // just in case anything slowed time
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}