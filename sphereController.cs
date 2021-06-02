using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereController : MonoBehaviour
{
    Transform cube_tr1;
    Transform cube_tr2;
    Transform cube_tr3;
    public GameObject mycube1;
    public GameObject mycube2;
    public GameObject mycube3;
    
    void Start()
    {
        cube_tr1 = mycube1.GetComponent<Transform>();
        cube_tr2 = mycube2.GetComponent<Transform>();
        cube_tr3 = mycube3.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        cube_tr1.Rotate(0,6,0);
        cube_tr2.Rotate(0,6,0);
        cube_tr3.Rotate(0,6,0);
    }
}
