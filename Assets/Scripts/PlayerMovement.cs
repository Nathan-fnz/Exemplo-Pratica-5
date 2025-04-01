using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;
    public float jump = 10f;

    private Rigidbody2D rigidbody2D;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        MovePlayer();
        JumpPlayer();
    }

    private void MovePlayer()
    {
        float xInput = Input.GetAxisRaw("Horizontal");

        transform.position += Vector3.right * xInput * speed * Time.deltaTime;
    }

    private void JumpPlayer()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rigidbody2D.AddForce(Vector2.up * jump, ForceMode2D.Impulse);
        }
    }
}
