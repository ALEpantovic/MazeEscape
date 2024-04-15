using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float startingTime = 60;
    public bool timerIsRunning = true;
    public TMP_Text timeText;
    public float timeRemaining;
    public GameObject objectToMove;
    public GameObject targetObject;
    private Vector3 initialPosition;

    void Start()
    {
        timeRemaining = startingTime;
        initialPosition = objectToMove.transform.position;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            timeRemaining -= Time.deltaTime;

            // Optionally reset the timer when it reaches 0
            if (timeRemaining <= 0)
            {
                timeRemaining = startingTime;
                // Optionally handle timer completion logic here
            }

            DisplayTime(timeRemaining);

            float progress = 1 - Mathf.Clamp01(timeRemaining / startingTime);
            Vector3 newPosition = Vector3.Lerp(initialPosition, targetObject.transform.position, progress);
            objectToMove.transform.position = newPosition;
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // AddTime function to increase remaining time
    public void AddTime(float timeToAdd)
    {
        timeRemaining += timeToAdd;
        DisplayTime(timeRemaining); // Update UI immediately
    }
}
