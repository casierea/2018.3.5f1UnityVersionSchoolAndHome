using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class CoRoutines2 : MonoBehaviour
{
    private WaitForSeconds wfs;
    public float holdTime = 0.1f;
    public bool CanRun { get; set; } = true;
    
    public UnityEvent OnRunEvent;
    private void Awake()
    {
        wfs = new WaitForSeconds(holdTime);    
    }

    public void Run()
    {
        StartCoroutine(OnStart());
    }
    
    private IEnumerator OnStart()
    {
        while (CanRun)
        {
            OnRunEvent.Invoke();
            print("run");
            yield return wfs;
        }
    }
}
