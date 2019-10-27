using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEvent : MonoBehaviour
{
//On collision collect and destroy object
	
    private void OnTriggerEnter(Collider trig)
    {
        //if (trig.gameObject.tag == "object")
        //{
            Destroy(gameObject);
        //}
    }
}