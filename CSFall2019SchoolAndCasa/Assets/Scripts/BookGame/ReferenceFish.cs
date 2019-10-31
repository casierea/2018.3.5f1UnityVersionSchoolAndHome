using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReferenceFish : MonoBehaviour
{
   public SelectRandomObj SRO;
   public GameObject placeOfFish;

   public void displayFish()
   {
      Instantiate(SRO.SelectedObject,placeOfFish.transform.position,Quaternion.identity);
   }
}
