using UnityEngine;
using TMPro;

public class SurvivalScore : MonoBehaviour
{
    private float timeAlive;
    private bool isAlive;


    public TMP_Text scoreText;

    void Start()
    {
        timeAlive = 0f;
        isAlive = true;
    }

    void Update()
    {
        if (isAlive)
        {
            timeAlive += Time.deltaTime;
            UpdateScoreUI();
        }
    }

    public void PlayerDied()
    {
        isAlive = false;
        Debug.Log("Time Alive: " + timeAlive + " seconds");
    }

    private void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Time Alive: " + Mathf.FloorToInt(timeAlive) + "s"; // Display the score in seconds
        }
    }
}
