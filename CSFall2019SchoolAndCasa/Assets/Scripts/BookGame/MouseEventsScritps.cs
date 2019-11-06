
using System;
using UnityEngine;
using UnityEngine.Events;
public class MouseEventsScritps : MonoBehaviour
{
    public UnityEvent MouseDownEvent;
    private void OnMouseDown()
    {
        //single mouse script/ click and stop
        MouseDownEvent.Invoke();
    }
}
