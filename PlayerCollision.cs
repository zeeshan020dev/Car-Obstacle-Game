using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    // Reference the Game Over Panel in the Inspector
    public GameObject gameOverPanel;

    void OnCollisionEnter(Collision collision)
    {
        // Check if the collided object has the "Obstacle" tag
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            ShowGameOver();
        }
    }

    void ShowGameOver()
    {
        gameOverPanel.SetActive(true); // Make the UI visible
        Time.timeScale = 0f; // Optional: Pause the game
    }
}
