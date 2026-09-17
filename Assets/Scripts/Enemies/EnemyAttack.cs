using UnityEngine;
using System.Threading.Tasks;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{

    public EntityStats enemyStats;
    private GameObject player;
    private bool isPlayerInRange = false;
    private float canAttack;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void SetIsPlayerInRange(bool _isPlayerInRange)
    {
        isPlayerInRange = _isPlayerInRange;
    }
    public bool GetIsPlayerInRange()
    {
        return isPlayerInRange;
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(enemyStats.attackSpeed <= canAttack)
            {
                other.gameObject.GetComponent<PlayerHealth>().TakeDamage(enemyStats.damage);
                canAttack = 0;
            }
            else
            {
                canAttack += Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision with " + other);
        if(other.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            //StartCoroutine(Attack());
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    //public IEnumerator Attack()
    //{
    //    yield return new WaitForSeconds(enemyStats.attackSpeed);
    //    Debug.Log("Hit!");
    //    //player.GetComponent<PlayerHealth>().TakeDamage(enemyStats.damage);
    //    if (isPlayerInRange)
    //    {
    //        StartCoroutine(Attack());
    //    }
    //}
}
