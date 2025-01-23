using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f; 
    public float jumpHeight = 5f; // Left for possible expansion, no gravity used

    void Update()
    {
        // Basic left-right-up movement
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, vertical, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement, Space.World);

        // Rotate based on left (-180) or right (0)
        if (horizontal < 0)
            transform.eulerAngles = new Vector3(0f, -180f, 0f);
        else if (horizontal > 0)
            transform.eulerAngles = new Vector3(0f, 0f, 0f);
    }
}