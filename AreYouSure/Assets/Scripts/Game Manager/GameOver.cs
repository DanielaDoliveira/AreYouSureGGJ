using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
 
/*CLASSE QUE VERIFICA PONTOS E DECIDE O RESULTADO FINAL*/
public class GameOver : MonoBehaviour
{
    public GameState gameState;
    public int pointsNbr;
    public Text pointsTxt;
    public Text showMessageToPlayer;
    private bool isGameOver;
      public GameObject btnVictory,btnTryAgain;
    public int minimunToVictory;
    
      private int scene;
      void Awake()
      {
          // GameManager.instance.isgameOver = false;
      }
       void Start()
    {
          
        
         btnTryAgain.SetActive(false);
         btnVictory.SetActive(false);
       
        pointsNbr = PlayerPrefs.GetInt("RESULTS");
        pointsTxt.text = pointsNbr.ToString();
      
        scene = PlayerPrefs.GetInt("SCENE");
           VictoryOrDefeat();
        
       
      
    }
 
 
    
    //VERIFICA SE, DEPENDENDO DA QUANTIA DE PONTOS, GANHOU OU PERDEU
    public void VictoryOrDefeat()
    {
        if(pointsNbr<6)
        {
            gameState = GameState.defeat;
            showMessageToPlayer.text = "YOU FIRED!\n TOO BAD!";
        }
        else if(pointsNbr>=6)
        {
            gameState = GameState.victory;
              showMessageToPlayer.text = "YOU GOT A PROMOTION!\n VERY GOOD, MAN!";
        }
    }
    void Update() 
    {
      controlGameState();
     
   
    }

    /*VAI PARA A TELA DE VITÓRIA*/
    public void controlVictory()
    {     
          btnVictory.SetActive(true);
       
      
    }
     /*VAI PARA A TELA DE DERROTA*/
    public void controlDefeat()
    {
        
          btnTryAgain.SetActive(true);
    }
     /*COMPORTAMENTO DO BOTÃO QUE AVANÇA NA CENA*/
    public void pressBtnNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    /*COMPORTAMENTO DO BOTÃO QUE REPETE A CENA ATUAL*/
    public void pressBtnTryAgain()
    {
          scene = PlayerPrefs.GetInt("SCENE");
          GameManager.instance.timer = 10;
          GameManager.instance.isgameOver = false;
          
           SceneManager.LoadScene(scene);
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


   
   
}
