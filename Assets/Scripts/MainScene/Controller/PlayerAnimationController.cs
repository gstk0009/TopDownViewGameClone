using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    private static readonly int isWalking = Animator.StringToHash("isWalking");

    protected Animator animator;
    protected TopDownController controller;

    private readonly float magnituteThreshold = 0.5f;
    
    protected void Start()
    {
        animator = GetComponentInChildren<Animator>();
        controller = GetComponent<TopDownController>();

        controller.OnMoveEvent += Move;
    }

    private void Move(Vector2 vector)
    {
        animator.SetBool(isWalking, vector.magnitude > magnituteThreshold);
    }
}
