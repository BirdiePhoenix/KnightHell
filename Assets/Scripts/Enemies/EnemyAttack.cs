using UnityEngine;
using System.Threading.Tasks;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public EntityStats enemyStats;
    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Collision");
        if(collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Hit!");
        }
    }

    public IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemyStats.attackSpeed);
        
        player.GetComponent<PlayerHealth>().TakeDamage(enemyStats.damage);
    }
}
