using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    [SerializeField][Range(0f, 10f)] private float moveSpeed = 5f;
    private TopDownController controller;
    private Rigidbody2D movementRigdbody;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        movementRigdbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        // FixedUpdated - 물리(Rigidbody) 관련 업데이트
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * moveSpeed;

        movementRigdbody.velocity = direction;
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }
}
