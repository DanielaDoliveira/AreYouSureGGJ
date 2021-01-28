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
    [SerializeField]private GameState gameState;

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
       gameState = GameState.playing;
       btnVictory.SetActive(false);
       btnTryAgain.SetActive(false);
   }
    
    void Update()
    {
        controlGameState();
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
    /*O BOTÃO SÓ APARECE SE O PLAYER GANHAR O JOGO*/
    public void controlVictory()
    {     
            btnVictory.SetActive(true);
    }

    /*O BOTÃO SÓ APARECE QUANDO O PLAYER FOR DERROTADO*/
    public void controlDefeat()
    {
        btnTryAgain.SetActive(true);
    }
}
