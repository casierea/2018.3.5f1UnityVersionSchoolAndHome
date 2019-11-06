using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class CharacterMoveJump : CharacterController,IMove
{
   public override void Move()
   {
      location.x = Input.GetAxis("Horizontal") * moveSpeed;
   }
}
