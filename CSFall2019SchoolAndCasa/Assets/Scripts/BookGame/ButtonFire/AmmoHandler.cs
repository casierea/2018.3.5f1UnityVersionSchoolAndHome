using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]
public class AmmoHandler : MonoBehaviour
{
    private Rigidbody rigidBodyObj;
    public Vector3 forces;
    
    private void Start()
    {
        rigidBodyObj = GetComponent<Rigidbody>();
        rigidBodyObj.AddForce(forces);
        Destroy(gameObject,1f);
    }
}
