using UnityEngine;

[CreateAssetMenu(fileName = "EntityStats", menuName = "Scriptable Objects/EntityStats")]
public class EntityStats : ScriptableObject
{
    public float maxHealth;
    public float currentHealth;
    public float damage;
    public float movementSpeed;
    public float attackSpeed;
}
