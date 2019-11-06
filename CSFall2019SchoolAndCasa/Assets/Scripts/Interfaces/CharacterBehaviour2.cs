using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 [RequireComponent(typeof(CharacterController))]
 public class CharacterBehaviour2 : MonoBehaviour
    {
    
    public CharacterBase character;
    public bool canMove = true;
    
     private CharacterController controller;
     private WaitForSeconds wffuobj;
       private void Awake()
            {
            controller = GetComponent<CharacterController>();
            character.Controller = controller;
            }
           IEnumerator Start()
              {
                while (canMove) 
                {
                    character.Move();
                    Debug.Log("movvvvvve");
                    yield return wffuobj;
                }
     }
}
