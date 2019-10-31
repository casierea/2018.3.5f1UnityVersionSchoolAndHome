using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnMouse : MonoBehaviour
{
   public UnityEvent OnMouseDownEvent;

   private void OnMouseDown()
   {
      OnMouseDownEvent.Invoke();
   }

   public UnityEvent OnmouseUpEvent;

   private void OnMouseUp()
   {
      OnmouseUpEvent.Invoke();
   }
}
