using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movballr : MonoBehaviour
{
    public Vector3 moVR;
    void Update()
    {
        transform.position += moVR * Time.deltaTime;
    }
}
