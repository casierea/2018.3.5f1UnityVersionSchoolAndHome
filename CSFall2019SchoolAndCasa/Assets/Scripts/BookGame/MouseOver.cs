using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseOver : MonoBehaviour
{
    public UnityEvent OnMouseOverEvent;

    private void OnMouseOver()
    {
        OnMouseOverEvent.Invoke();
    }
}
