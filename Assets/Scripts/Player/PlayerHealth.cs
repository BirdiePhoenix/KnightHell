using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private PlayerStats playerStats;

    private void Start()
    {
        
    }

    public void EditHealth(float damage)
    {
        if(playerStats.CurrentHealth > 0)
        {
            playerStats.CurrentHealth -= damage;
            Debug.Log($"You took {damage} damage. Current health: {playerStats.CurrentHealth}");
        }

        if (playerStats.CurrentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Handle player death (e.g., reload scene, show game over screen, etc.)
        Debug.Log("Player has died.");

        if (playerStats.CurrentHealth <= 0)
        {
            playerStats.CurrentHealth = 0;
        }
    }
}
