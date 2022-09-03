using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float maxSpeed = 4;

    [SerializeField]
    private Rigidbody rb;
    private float currentSpeed;
    PlayerInputActions playerInputActions;

    private void Awake()
    {
        playerInputActions = new PlayerInputActions();

        playerInputActions.Player.Enable();
    }

    private void Start()
    {
        currentSpeed = maxSpeed;
    }

    private void FixedUpdate()
    {
        var inputVector = playerInputActions.Player.Movements.ReadValue<Vector2>();
        rb.velocity = new Vector3(inputVector.x * currentSpeed, rb.velocity.y, inputVector.y * currentSpeed);
    }
}
