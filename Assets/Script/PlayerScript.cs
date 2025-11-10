using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxis("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;

    }
    
    void FixedUpdate()
    {
        playerSpeed += 0.1f * Time.fixedDeltaTime;
        rb.linearVelocity = new Vector2(0, playerDirection.y * playerSpeed);
        
    }
}
