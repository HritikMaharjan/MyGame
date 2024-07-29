using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeScript : MonoBehaviour
{
    
    int speed = 2;
    void Start()
    {
       
    }

    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime,
            0, Input.GetAxis("Vertical") * speed * Time.deltaTime));
    }
}