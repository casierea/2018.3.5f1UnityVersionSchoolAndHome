using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodayneClass : MonoBehaviour
{

    public GameAction GameActionObj;
    
    public void Talk()
    {
        Debug.Log("Rodayne");
    }
    // Update is called once per frame
   
    private void Awake()
    {
    GameActionObj.action += Talk;    
    }
    void Start()
    {
       
    }
}
