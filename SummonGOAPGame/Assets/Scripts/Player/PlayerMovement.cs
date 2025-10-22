using System;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Vector2 moveDirection;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void MoveHandler(InputController input)
    {
        moveDirection = input.moveDir;
        rb.linearVelocity = new Vector2(moveDirection.x * speed, moveDirection.y * speed);

    }
}
