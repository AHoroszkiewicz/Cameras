using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody myRigidbody;
    private Vector3 Input;
    [SerializeField] float moveSpeed = 10f;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Run();
    }

    private void Run()
    {
        Vector3 playerVelocity = new Vector3(Input.x * moveSpeed,0 , Input.y * moveSpeed);
        myRigidbody.velocity = playerVelocity;
    }

    private void OnMove(InputValue value)
    {
        Input = value.Get<Vector2>();
    }
}
