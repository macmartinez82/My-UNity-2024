using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testdeletedafter : MonoBehaviour
{
    public Rigidbody2D rB;
    public float qtty;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) { rB.velocity = Vector2.up * qtty; }
        else if (Input.GetKeyDown(KeyCode.S)) { rB.velocity = Vector2.down * qtty; }
      
    }
}
