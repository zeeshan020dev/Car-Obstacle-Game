using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;

    private void OnTriggerEnter(Collider other)
    {
        // Check if player touched the coin (ensure Player tag is set)
        if (other.CompareTag("Player"))
        {
            // Add score via the singleton
            if (ScoreManager.instance != null)
            {
                ScoreManager.instance.AddScore(coinValue);
            }

            // Destroy the coin
            Destroy(gameObject);
        }
    }
}
