using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class UpClickMouse : MonoBehaviour
{
    public UnityEvent OnMouseUpEvent;

    private void OnMouseUp()
    {
        OnMouseUpEvent.Invoke();
    }
}



  
