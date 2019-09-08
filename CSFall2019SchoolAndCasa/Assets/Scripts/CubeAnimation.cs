using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimation : MonoBehaviour
{
   private Animator animator;
   private bool tutorialanimating = false;

   void Start()
   {
      animator = GetComponent<Animator>();
   }

   void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space)&& !tutorialanimating)
      {
         animator.SetBool("tutorialanimating", true);
         tutorialanimating = true;
      }
     else if (Input.GetKeyDown(KeyCode.Space)&& tutorialanimating)
      {
         animator.SetBool("tutorialanimating",false);
         tutorialanimating = false;
      }
   }

   void TopFunction()
   {
      Debug.Log("Made it to the top!");
   }
}
