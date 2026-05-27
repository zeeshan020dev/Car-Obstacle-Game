using UnityEngine;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject pauseScreenUI;
    public GameObject onScreenUI;
    public void pauseGame()
    {
        Time.timeScale = 0f;
        pauseScreenUI.SetActive(true);
        onScreenUI.SetActive(false);
    }
    public void resumeGame()
    {
        Time.timeScale = 1f;
        pauseScreenUI.SetActive(false);
        onScreenUI.SetActive(true);

    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision is Detected with " + collision.gameObject.name);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
