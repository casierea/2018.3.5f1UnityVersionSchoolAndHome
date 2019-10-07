using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class Collections : ScriptableObject
{
   public List<Object> objectlist;
   public List<FloatData> FloatDatas;
   public List<GameObject> GameObjects;
   
   public void findObjectType(object obj)
   {
      foreach (var currentObj in objectlist)
      {
         if (currentObj == obj)
         {
            //Do work; see if you have a match with a particular obj.
            //instanticate, add to collection, use a speficic method to call.
         }
         
      }
   }
   public void AddToList(Object obj)
   {
      objectlist.Add(obj);
      //can add prefab in scene. added to collection. trigger event script, add + and add list. 
      //could have a list of collected and not collected.
   }

   public void RemovefromList(Object obj)
   {
      foreach (var currentObj in objectlist)
      {
         objectlist.Remove(obj);
      }
   }
}
