using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController3 : MonoBehaviour
{
    Transform capsule_tr;
    AudioSource capsule_au;
    public GameObject mycapsule;
    // Start is called before the first frame update
    void Start()
    {
        capsule_tr = mycapsule.GetComponent<Transform>();
        capsule_au = mycapsule.GetComponent<AudioSource>();
        capsule_au.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        capsule_au.Play();
        capsule_tr.Rotate(10,0,0);
    }
}
