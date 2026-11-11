using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    [Tooltip("Hoeveel gezondheid deze pickup herstelt.")]
    public int healAmount = 25;

    private void OnTriggerEnter(Collider other)
    {
        // Kijk of het object een speler met health is.
        PlayerHealth player = other.GetComponent<PlayerHealth>();

        if (player != null)
        {
            // Alleen oppakken als de health niet vol is.
            if (player.health < player.maxHealth)
            {
                player.health += healAmount;

                // Zorg dat health niet hoger wordt dan maxHealth.
                if (player.health > player.maxHealth)
                {
                    player.health = player.maxHealth;
                }

                Debug.Log("Health restored!");
                Destroy(gameObject);
            }
            else
            {
                Debug.Log("Health already full!");
            }
        }
    }
}
