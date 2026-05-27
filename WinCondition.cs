using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    // Drag your WinPanel object into this field in the Inspector
    public GameObject winPanel;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that touched the endpoint has the tag "Player"
        if (other.CompareTag("Player"))
        {
            // Activate the Win Panel
            winPanel.SetActive(true);

            // Optional: Freeze the game time
            Time.timeScale = 0f;
            Debug.Log("Player won!");
        }
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
