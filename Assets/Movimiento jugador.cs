using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // --- VARIABLES DE MOVIMIENTO ---
    [Header("Movement Settings")]
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    // --- VARIABLES PARA GROUND CHECK ---
    [Header("Ground Check Settings")]
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    // --- VARIABLES PRIVADAS ---
    private CharacterController controller;
    private Vector3 velocity;
    private bool isGrounded;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // --- Lógica de Movimiento ---
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGrounded && velocity.y < 0) { velocity.y = -2f; }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
        if (Input.GetButtonDown("Jump") && isGrounded) { velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity); }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    // ¡LA FUNCIÓN ONTRIGGERENTER HA SIDO ELIMINADA DE AQUÍ!
}