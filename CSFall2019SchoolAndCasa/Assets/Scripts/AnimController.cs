using UnityEngine;
[CreateAssetMenu]
public class AnimController : ScriptableObject
{
   public string animName = "walk";
   public void AnimCall(Animator animator)
   {
      animator.SetTrigger(name);
   }
}
