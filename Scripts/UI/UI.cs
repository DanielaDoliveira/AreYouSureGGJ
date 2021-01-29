using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour,IUserInterface
{
   
    private Scene scene; 
    public ButtonAnimations buttonAnimations;
    public AudioClip clickButtonsong,clickPlay;
    public void btnPlay()
    {
          ClickSong();
          buttonAnimations.SetPlayBtnAnimation();
          Invoke("loadPlayScene",1f);
    }
    public void btnCredits()
    {
         ClickSong();
        buttonAnimations.SetCreditsButtonAnimation();
        Invoke("loadCreditsScene",1f);

    }
   
    public void btnQuit()
    {
         ClickSong();
        buttonAnimations.SetQuitButtonAnimation();
        Invoke("exitGame",1f);
    }


    public void loadPlayScene()
    {
         SceneManager.LoadScene(3);//Acessa a tela 3, que é o dia 1
    }
    public void loadCreditsScene()
    {
          SceneManager.LoadScene(2);//Acessa a tela 2(CREDITS)
    }
    public void exitGame()
    {
         Application.Quit();//SAI DO JOGO
    }

    public void ClickSong()
    {
        SoundManager.instance.TitleMenuSongButtons(clickButtonsong);
    }
    public void ClickPlay()
    {
         SoundManager.instance.TitleMenuSongPlay(clickPlay);
    }
   
}
