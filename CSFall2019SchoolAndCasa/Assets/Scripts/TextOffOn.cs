using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextOffOn : MonoBehaviour
{

   public void OnOffText(UnityEngine.UI.Text text)
   {
      text.gameObject.active = !text.gameObject.active;
   }
}
