using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc_MoveController : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float move_Speed;
    [SerializeField] float rotate_Speed;
    [SerializeField] Joystick joystick;

    public Vector3 movement;
    public static sc_MoveController instance;

    void Start()
    {
        Time.timeScale = 1;
        rb = GetComponent<Rigidbody>();
        move_Speed = 4f;
        rotate_Speed = 720f;
        instance = this;
    }

    void Update()
    {
        GetPlayerInputTouch();
    }

    void FixedUpdate()
    {
        PlayerMove();
        RotatePlayer();
    }

    void GetPlayerInputTouch()
    {
        movement.x = joystick.Horizontal;
        movement.z = joystick.Vertical;
    }

    void PlayerMove()
    {
        rb.velocity = movement.normalized * move_Speed + new Vector3(0, rb.velocity.y, 0);
    }

    void RotatePlayer()
    {
        if (movement.x != 0 || movement.z != 0)
        {
            Quaternion toRotation = Quaternion.LookRotation(movement, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotate_Speed * Time.deltaTime);
        }
    }
}
