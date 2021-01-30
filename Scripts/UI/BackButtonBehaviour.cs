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
       
        SceneManager.LoadScene(1);//ACESSA A TELA DE UI
    }
      public void ClickSong()
    {
        SoundManager.instance.TitleMenuSongButtons(clickButtonsong);
    }

    
}
