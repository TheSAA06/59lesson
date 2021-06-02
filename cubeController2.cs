using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController2 : MonoBehaviour
{
    // Start is called before the first frame update
    MeshRenderer capsule_tr;
    public GameObject mycapsule;
    void Start()
    {
        capsule_tr = mycapsule.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    { 
        capsule_tr.enabled = false;
    }
}
