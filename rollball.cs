using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rollball : MonoBehaviour
{
    public float speed = 5.0f;
    public Rigidbody2D moVUp;

    void Update()
    {
        // Get input from the horizontal axis (A/D keys or Left/Right Arrow keys)
        float moveX = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
       // Move the circle along the X-axis
        transform.Translate(moveX, 0, 0);
        if (Input.GetKey(KeyCode.UpArrow)) { moVUp.velocity = Vector2.up * speed; }
    }
}

   /* public Vector3 lefT;
    public Vector3 righT;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow)) { transform.position += lefT * Time.deltaTime; }
        if (Input.GetKey(KeyCode.RightArrow)) { transform.position += righT * Time.deltaTime; }
    }
}*/
