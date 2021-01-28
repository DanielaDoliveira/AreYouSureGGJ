using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonAnimations : MonoBehaviour
{
   
   
    public Animator clicked_animation;
    void Start()
    {
        
    }

  
   public void SetPlayBtnAnimation()
   {
       clicked_animation.SetTrigger("playClicked");
   }
   public void SetCreditsButtonAnimation()
   {
       clicked_animation.SetTrigger("credit");
   }

     public void SetQuitButtonAnimation()
   {
       clicked_animation.SetTrigger("exit");
   }

}
