using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody2D rb; // Garder le nom 'rb'
    public float moveDirectionX = 0;
    public float moveDirectionY = 0;
    public float vitesseDeplacement = 5f;
    public float jumpForce = 10f;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        moveDirectionX = Input.GetAxisRaw("Horizontal");
        moveDirectionY = Input.GetAxisRaw("Vertical");

        isGrounded = Physics2D.Raycast(transform.position, Vector2.down, 0.1f);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        // Mouvement 2D
        Vector2 movement = new Vector2(moveDirectionX * vitesseDeplacement, moveDirectionY * vitesseDeplacement);
        rb.velocity = movement;

        // Optionnel : Pour empêcher la rotation du joueur en raison des forces physiques
        rb.freezeRotation = true;
    }

    void Jump()
    {
        rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
    }
}
