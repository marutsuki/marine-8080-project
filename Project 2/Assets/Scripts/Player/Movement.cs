﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector3 velocity;
    public Vector3 additionalV;
    public Vector3 acceleration;
    [Range(0, 50)] public float accelerationAmount = 5f;
    public float jumpSpeed;
    public float maxSpeed = 10f;
    public float gravity = -9.81f;
    public float gravityScale = 1f;
    public bool inAir;
    public bool inJump;
    public CharacterController cc;
    public Animator anim;
    public Transform groundCheck;
    public Transform model;
    public Vector3 groundCheckPosition;
    public LayerMask groundMask;
    public float maxRestrictSpeedScale = 1f;
    public bool isSliding = false;
    float speedScale = 1f;
    float jumptime = 0.8f;
    float maxAirVelocity = 10f;
    public bool initialJump;
    public float timer;
    public float recoverDuration = 2f;
    private float inAirDelay = 0.1f;
    private float inAirTimer;

    // Start is called before the first frame update
    void Start()
    {
        inAirTimer = 0.1f;
        velocity = Vector3.zero;
        gravityScale = 1f;
        timer = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        CalculateAirborne();
        HandleAdditionalV();
        Move();
        CalculateGravity();
        cc.Move(velocity * Time.deltaTime);
        groundCheckPosition = groundCheck.position;
    }

    void Move()
    {
        float x = Input.GetAxis("Horizontal");
        if (inAir)
        {
            ControlAirVelocity(x);
        }
        else
        {
            ControlGroundVelocity(x);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            if (!inAir && Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
                initialJump = true;
            }
        }
        //  Change the jump height based on how long the player is holding the jump button on the first jump
        else if (initialJump && inJump && velocity.y > 0 && velocity.y < jumpSpeed * 0.75f)
        {
            velocity.y -= jumpSpeed * 0.05f;
        }
        velocity.z = 0;
        if (speedScale < 1f)
        {
            RegainControl();
        }
    }

    public void Jump()
    {
        Debug.Log("jump");
        maxAirVelocity = 10f;
        //  Prevents height from decaying if it is not the first jump
        initialJump = false;
        velocity.y = jumpSpeed;
        inJump = true;
    }

    void CalculateAirborne()
    {

        if (Physics.CheckSphere(groundCheck.position, 0.25f, groundMask))
        {
            maxAirVelocity = 10f;
            inAir = false;
            if (velocity.y < 0)
            {
                inAirTimer = inAirDelay;
                inJump = false;
                initialJump = false;
            }
        }
        else
        {
            if (inAirTimer <= 0f)
            {
                inAir = true;
            }
            else
            {
                inAirTimer -= Time.deltaTime;
            }
        }
    }

    void CalculateGravity()
    {
        velocity.y += gravityScale * gravity * Time.deltaTime + additionalV.y;
        if (!inAir && velocity.y < 0)
        {
            velocity.y = -3f;
        }
    }
    public void AddVelocity(Vector3 v)
    {
        additionalV += v;
    }

    public void HandleAdditionalV()
    {
        if (Mathf.Abs(additionalV.magnitude) <= (Vector3.one * 5f * Time.deltaTime).magnitude)
        {
            additionalV = Vector3.zero;
        }
        else
        {
            additionalV -= additionalV.normalized * 10f * Time.deltaTime;
        }

    }
    public void CeaseControl()
    {
        speedScale = 0.001f;
        timer = recoverDuration;
    }
    public void RegainControl()
    {
        speedScale = speedScale*1.1f;
        if (speedScale > maxRestrictSpeedScale)
        {
            speedScale = maxRestrictSpeedScale;
        }
        Recover();
    }
    public void Recover()
    {
        timer -= Time.deltaTime;
        if (timer < 0f)
        {
            isSliding = false;
            maxRestrictSpeedScale = 1f;
        }
    }
    public void ControlGroundVelocity(float x)
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || isSliding)
        {
            velocity.x += x * accelerationAmount * speedScale;
        }
        else
        {
            velocity.x = Mathf.Lerp(velocity.x, 0f, Time.deltaTime * 15f);
            if (velocity.x < 0.05f && velocity.x > -0.05f)
            {
                velocity.x = 0f;
            }
        }
        if (velocity.x > maxSpeed)
        {
            velocity.x = maxSpeed;
        }
        else if (velocity.x < -maxSpeed)
        {
            velocity.x = -maxSpeed;
        }
        velocity.x += additionalV.x;
    }
    public void ControlAirVelocity(float x)
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            velocity.x += x * accelerationAmount * speedScale * 0.25f;
        }
        else
        {
            velocity.x = Mathf.Lerp(velocity.x, 0f, Time.deltaTime * 5f);
            if (velocity.x < 0.05f && velocity.x > -0.05f)
            {
                velocity.x = 0f;
            }
        }
        velocity.x += additionalV.x;
        velocity.x = Mathf.Min(velocity.x, maxAirVelocity);
        velocity.x = Mathf.Max(velocity.x, -maxAirVelocity);
        maxAirVelocity -= Time.deltaTime * (maxAirVelocity - 5f) / (maxSpeed) * 5f;
    }
}