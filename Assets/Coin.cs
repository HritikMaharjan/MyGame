using UnityEngine;

public class Coin : MonoBehaviour
{
    // The amount of score the coin will give when collected
    public int coinValue = 1;

    // This function is called when another object enters the collider
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object that collided with the coin is tagged as "Player"
        if (other.gameObject.CompareTag("Player"))
        {
            // Find the Game Manager and add score
            GameManager.instance.AddScore(coinValue);

            // Destroy the coin after it's collected
            Destroy(gameObject);
        }
    }
}
