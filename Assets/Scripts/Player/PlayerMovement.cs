using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour
{
    //[SerializeField] private float moveSpeed = 5f;
    private Vector2 moveInput;

    private Rigidbody2D rb;
    public EntityStats playerStats;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        moveInput = context.ReadValue<Vector2>();
    }

    private void Update()
    {
        rb.MovePosition(rb.position + moveInput * playerStats.movementSpeed * Time.deltaTime);
    }
}
