using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float Speed;
    private Vector2 moveVelocity;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        
    }

    void Update()
    {
        Vector2 moveInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        //transform.Rotate(Vector3.forward * -RotationSpeed * Time.deltaTime);
        moveVelocity = moveInput.normalized * Speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.deltaTime);
    }
}
