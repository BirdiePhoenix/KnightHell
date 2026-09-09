using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float enemySpeed = 2.0f;

    public Rigidbody2D enemyRb;
    private GameObject player;
    private Vector2 moveDirection;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookDirection = (player.transform.position - transform.position).normalized;
        //enemyRb.AddForce(lookDirection * enemySpeed);
        enemyRb.MovePosition(enemyRb.position + (lookDirection * enemySpeed) * Time.fixedDeltaTime);
    }

    private void FixedUpdate()
    {
        //enemyRb.MovePosition(enemyRb.position + ())
    }
}
