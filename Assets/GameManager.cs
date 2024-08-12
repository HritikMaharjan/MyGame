using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // The player's current score
    private int score = 0;

    // Text UI element to display the score
    public Text scoreText;

    // Singleton instance
    public static GameManager instance;

    private void Awake()
    {
        // Singleton pattern to ensure only one GameManager instance exists
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Function to add score
    public void AddScore(int value)
    {
        score += value;
        UpdateScoreText();
    }

    // Function to update the score text UI
    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
