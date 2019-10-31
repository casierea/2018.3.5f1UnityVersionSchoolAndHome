using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestroyObj : MonoBehaviour
{
    public float objLastsTime = 3;
    
    IEnumerator Start()
    {
        yield return new WaitForSeconds(objLastsTime);
        Destroy(gameObject);
    }
}
   
