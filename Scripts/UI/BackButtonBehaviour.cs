using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButtonBehaviour : MonoBehaviour
{
    public ButtonAnimations btnAnim;
      public AudioClip clickButtonsong;
    public void btnBack()
    {
         ClickSong();
        btnAnim.SetBackButtonAnimation();
        Invoke("LoadIntroScene",1f);
    }

    public void LoadIntroScene()
    {
       
        SceneManager.LoadScene(0);//ACESSA A TELA DE INTRO
    }
      public void ClickSong()
    {
        SoundManager.instance.TitleMenuSongButtons(clickButtonsong);
    }

    
}
