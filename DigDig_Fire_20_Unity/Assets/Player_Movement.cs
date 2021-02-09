using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public int MoveSpeed = 100;
    public Rigidbody2D rb;
    Vector2 angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        angle.x = Input.GetAxis("Horizontal");
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + angle * Time.fixedDeltaTime);
    }
}
