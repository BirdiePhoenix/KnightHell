using UnityEngine;
using System.Threading.Tasks;
using System.Collections;

public class EnemyAttack : EnemyBehaviour
{
    //public EntityStats enemyStats;

    private void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    public IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemyStats.attackSpeed);
        
        player.GetComponent<PlayerHealth>().TakeDamage(enemyStats.damage);
    }
}
