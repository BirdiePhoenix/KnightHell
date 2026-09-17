using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public EntityStats playerStats;

    private void Start()
    {
        playerStats.currentHealth = playerStats.maxHealth;
    }

    public void EditHealth(float damage)
    {
        playerStats.currentHealth -= damage;
        Debug.Log($"You took {damage} damage. Current health: {playerStats.currentHealth}");

        if (playerStats.currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        // Handle player death (e.g., reload scene, show game over screen, etc.)
        Debug.Log("Player has died.");
        
        if(playerStats.currentHealth <= 0)
        {
            playerStats.currentHealth = 0;
        }
    }
}
