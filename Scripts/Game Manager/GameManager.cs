using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public enum GameState
{
    playing,
    victory,
    defeat
}
public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject btnVictory,btnTryAgain;
    public GameState gameState;
    public float timer;
    public Text timeTxt;

    /*O GAME MANAGER CONTROLA A PASSAGEM DAS FASES DE ACORDO COM O SISTEMA DE 
    VITÓRIA OU REPETE A CENA CASO HAJA DERROTA*/
   void Awake()
   {
       /*PERSISTÊNCIA DO OBJETO GAME MANAGER NA CENA*/
       if(instance == null)
       {
           instance = this;
       }
       else
       {
           Destroy(gameObject);
       }
       DontDestroyOnLoad(gameObject);
   }
   void Start()
   {
       timer = 50f;
       
        timeTxt.text = timer.ToString();
       gameState = GameState.playing;
       btnVictory.SetActive(false);
       btnTryAgain.SetActive(false);
   }
     public void countDown()
    {
      if(timer>0)
      {
          timer -= 1*Time.deltaTime;
          timeTxt.text = timer.ToString("F0");
      }
    }
    void Update()
    {
        controlGameState();
        countDown();
    }
    /*CONTROLA A ATIVAÇÃO DOS BOTÕES TRY AGAIN E NEXT LEVEL ATRAVÉS DOS ESTADOS DO JOGO DE VITÓRIA
    E DERROTA*/
    public void controlGameState()
    {
        if(gameState == GameState.victory)
        {
            controlVictory();
        }
        else if (gameState == GameState.defeat)
        {
            controlDefeat();
        }
    }
    /*COMPORTAMENTO DO BOTÃO QUE AVANÇA NA CENA*/
    public void pressBtnNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    /*COMPORTAMENTO DO BOTÃO QUE REPETE A CENA ATUAL*/
    public void pressBtnTryAgain()
    {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    /*VAI PARA A TELA DE VITÓRIA*/
    public void controlVictory()
    {     
        SceneManager.LoadScene("victory");
            //btnVictory.SetActive(true);
    }

    /*VAI PARA A TELA DE DERROTA*/
    public void controlDefeat()
    {
          SceneManager.LoadScene("GameOver");
        //btnTryAgain.SetActive(true);
    }

   
}
