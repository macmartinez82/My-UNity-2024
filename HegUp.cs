using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class HegUp : MonoBehaviour
{
  public Rigidbody2D rb;
  public float Amount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow)) { rb.velocity = Vector2.up * Amount; } 
        float Mov = Input.GetAxis("Horizontal") * Amount * Time.deltaTime;
        transform.Translate(Mov,0,0);   
    }
}
