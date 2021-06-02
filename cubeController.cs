using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour
{

    Transform cube_tr;
    Transform capsule_tr;
    public GameObject mycapsule;

    void Start()
    {
        cube_tr = GetComponent<Transform>();
        capsule_tr = mycapsule.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            cube_tr.Translate(0,0,1f);
        }
        if (Input.GetKeyDown("a"))
        {
            cube_tr.Translate(-1f,0,0);
        }
        if (Input.GetKeyDown("d"))
        {
            cube_tr.Translate(1f,0,0);
        }
        if (Input.GetKeyDown("s"))
        {
            cube_tr.Translate(0,0,-1f);
        }
    }

    void OnMouseDown()
    {
        cube_tr.Rotate(0,2,0);
        capsule_tr.Translate(-1,0,0);
    }
}
