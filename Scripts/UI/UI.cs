using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour,IUserInterface
{
   
    private Scene scene; 
    public ButtonAnimations buttonAnimations;
    public void btnPlay()
    {
          buttonAnimations.SetPlayBtnAnimation();
          Invoke("loadPlayScene",1f);
    }
    public void btnCredits()
    {
        buttonAnimations.SetCreditsButtonAnimation();
        Invoke("loadCreditsScene",1f);

    }
   
    public void btnQuit()
    {
        buttonAnimations.SetQuitButtonAnimation();
        Invoke("exitGame",1f);
    }


    public void loadPlayScene()
    {
         SceneManager.LoadScene(2);//Acessa a tela 2, que é o dia 1
    }
    public void loadCreditsScene()
    {
          SceneManager.LoadScene(1);//Acessa a tela 1(CREDITS)
    }
    public void exitGame()
    {
         Application.Quit();//SAI DO JOGO
    }
}
