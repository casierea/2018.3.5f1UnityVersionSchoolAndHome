using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrigAnim : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
   
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("OpenSaysMe");
    }

    private void OnTriggerExit(Collider other)
    {
        anim.enabled = false;
    }

    void AnimPause()
    {
        anim.enabled = false;
    }
}
