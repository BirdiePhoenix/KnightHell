using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //[SerializeField] private float enemySpeed = 2.0f;
    public EntityStats enemyStats;

    public Rigidbody2D enemyRb;
    private GameObject player;
    private float distance;
    [SerializeField] private float stoppingDistance;
    public EnemyAttack enemyAttack;
    private Vector2 moveDirection;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(player.transform.position, transform.position);
        Vector2 lookDirection = (player.transform.position - transform.position).normalized;
        //enemyRb.AddForce(lookDirection * enemySpeed);

        //Checks if the distance between the player and the enemy is greater than the stopping distance
        if (distance > stoppingDistance)
        {
            enemyRb.MovePosition(enemyRb.position + lookDirection * enemyStats.movementSpeed * Time.fixedDeltaTime);
        }
        else
        {
            enemyAttack.Attack();
        }
        
    }

    private void FixedUpdate()
    {
        //enemyRb.MovePosition(enemyRb.position + ())
    }
}
