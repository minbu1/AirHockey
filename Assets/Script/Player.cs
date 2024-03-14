using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public enum ControlType { ArrowKeys, WASD }
    public ControlType controlType;

    public float speed = 10;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = 0;
        float moveVertical = 0;

        // Determine input based on control type
        switch (controlType)
        {
            case ControlType.ArrowKeys:
                moveHorizontal = Input.GetKey(KeyCode.RightArrow) ? 1 : (Input.GetKey(KeyCode.LeftArrow) ? -1 : 0);
                moveVertical = Input.GetKey(KeyCode.UpArrow) ? 1 : (Input.GetKey(KeyCode.DownArrow) ? -1 : 0);
                break;
            case ControlType.WASD:
                moveHorizontal = Input.GetKey(KeyCode.D) ? 1 : (Input.GetKey(KeyCode.A) ? -1 : 0);
                moveVertical = Input.GetKey(KeyCode.W) ? 1 : (Input.GetKey(KeyCode.S) ? -1 : 0);
                break;
        }

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        rb.velocity = movement.normalized * speed;
    }
}