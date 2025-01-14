using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpHeight = 5f;
    public float gravity = 9.81f;
    private float verticalSpeed;

    void Update()
    {
        // Horizontal & Vertical Movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 moveDir = new Vector3(horizontal, 0f, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(moveDir, Space.World);

        // Simple ground check (no bool used)
        if (transform.position.y <= 0.5f)
        {
            verticalSpeed = 0f;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                verticalSpeed = jumpHeight;
            }
        }
        else
        {
            // Gravity
            verticalSpeed -= gravity * Time.deltaTime;
        }

        // Apply jump or fall
        transform.Translate(0f, verticalSpeed * Time.deltaTime, 0f, Space.World);
    }
}