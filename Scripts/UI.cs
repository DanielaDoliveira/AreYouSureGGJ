using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UI : MonoBehaviour,IUserInterface
{
   
    private Scene scene; 
    public void btnPlay()
    {
     
         SceneManager.LoadScene(2);//Acessa a tela 2, que é o dia 1
        
    }
    public void btnCredits()
    {
        SceneManager.LoadScene(1);//Acessa a tela 1(CREDITS)

    }
   
    public void btnQuit()
    {
        Application.Quit();//SAI DO JOGO
    }
}
