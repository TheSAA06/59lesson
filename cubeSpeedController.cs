using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeSpeedController : MonoBehaviour
{
    Transform  cube_tr;
    public int speed = 0;
    void Start()
    {
        cube_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        cube_tr.Rotate(0,speed,0);
    }
}
