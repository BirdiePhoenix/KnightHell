using UnityEngine;
using System.Threading.Tasks;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{

    public EntityStats enemyStats;
    private GameObject player;
    private bool isPlayerInRange = false;

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

    private void OnTriggerEnter2D(Collider2D collider)
    {
        Debug.Log("Collision with " + collider);
        if(collider.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            StartCoroutine(Attack());
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
        }
    }

    public IEnumerator Attack()
    {
        yield return new WaitForSeconds(enemyStats.attackSpeed);
        Debug.Log("Hit!");
        //player.GetComponent<PlayerHealth>().TakeDamage(enemyStats.damage);
        if (isPlayerInRange)
        {
            StartCoroutine(Attack());
        }
    }
}
