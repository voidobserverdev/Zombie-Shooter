using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 15f;
    [SerializeField] private Rigidbody2D playerRb;

    private PlayerControls playerControls;
    private Vector2 moveInput;

    void Awake()
    {
        playerControls = new PlayerControls();
    }

    void OnEnable()
    {
        playerControls.Player.Enable();
    }

    void OnDisable()
    {
        playerControls.Player.Disable();
    }

    void Update()
    {
        //Fix diagonal speed
        moveInput = playerControls.Player.Move.ReadValue<Vector2>();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        playerRb.linearVelocityX = moveInput.x * moveSpeed;
        playerRb.linearVelocityY = moveInput.y * moveSpeed;
    }
}
