using UnityEngine;

public class CoinCollectible : MonoBehaviour
{
    public int coinValue = 1; // Amount to add per coin

    private void OnTriggerEnter(Collider other)
    {
        // Check if the object colliding has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // --- Add Score Logic Here ---
            // Example: ScoreManager.instance.AddScore(coinValue);
            Debug.Log("Coin collected!");

            // Destroy the coin object
            Destroy(gameObject);
        }
    }
}
