using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] protected EntityStats playerStatsSO;
    private float currentHealth;
    public float CurrentHealth
    {
        get { return currentHealth; }
        set { currentHealth = value; }
    }

    private float maxHealth;
    public float MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MaxHealth = playerStatsSO.maxHealth;
        CurrentHealth = playerStatsSO.maxHealth;
        Debug.Log(CurrentHealth);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
