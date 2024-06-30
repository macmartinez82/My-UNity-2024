using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mYballS : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) { rb.velocity = Vector2.up * speed; }
        float X = Input.GetAxis("Horizontal")* speed * Time.deltaTime; 
        transform.Translate (X,0,0);
    }
}
