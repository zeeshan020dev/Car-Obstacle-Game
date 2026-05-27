using UnityEngine;
using TMPro; // Include TMPro namespace

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; // Singleton for easy access
    public TMP_Text scoreText;
    private int score = 0;

    private void Awake()
    {
        instance = this; // Set up the singleton
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
