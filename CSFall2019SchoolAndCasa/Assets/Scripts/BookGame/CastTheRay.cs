using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastTheRay : MonoBehaviour
{
    public float Distance;
    
    void Update()
    {
        RaycastHit Hit;
        
        if(Physics.Raycast (transform.position, transform.TransformDirection( Vector3.forward), out Hit))
        {
            
        }
    }
}
