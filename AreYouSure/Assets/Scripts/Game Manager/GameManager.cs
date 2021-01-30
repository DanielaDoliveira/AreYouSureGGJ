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
  
    public GameState gameState;
    public float timer;
    public Text timeTxt;
     public int pointsNbr;
    public Text pointsTxt;
    public bool isgameOver;
   
     public GameObject[] characterVector;
     public Image[] characterImage;
     [Header("Posição anterior do vetor e próxima posição")]
   public int next = 0;//colocado na posição do vetor de personagem.
   public int previous = 0;
 

    /*O GAME MANAGER CONTROLA A PASSAGEM DAS FASES DE ACORDO COM O SISTEMA DE 
    VITÓRIA OU REPETE A CENA CASO HAJA DERROTA
    - O GAME MANAGER TAMBÉM CONTA OS PONTOS E MARCA O TIMER*/
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
     
       TimeAndPointsDeclaration();
       gameState = GameState.playing;
     //  btnVictory.SetActive(false);
     //  btnTryAgain.SetActive(false);
   
   }

    public void TimeAndPointsDeclaration()
    {
        timer = 10f;
        timeTxt.text = timer.ToString();
        pointsNbr = 0;
        pointsTxt.text = pointsNbr.ToString();
    }
  
     public void countDown()
    {
      if(timer>=0)
      {
          timer -= 1*Time.deltaTime;
          timeTxt.text = timer.ToString("F0");
      }
      verifyIftimeFinished();
    }
    public void verifyIftimeFinished()
    {
        if(timer <= 0)
        {
            transferPointsDataGameOver();
           //  timeTxt.text = timer.ToString("F0");
             isgameOver = true;
             if(isgameOver)
             {
             
                  SceneManager.LoadScene("GameOver");
             }
            
        }

    }

 
    public void AddPoints()
    {
        pointsNbr +=1;
        pointsTxt.text = pointsNbr.ToString();

    }
     public void SubPoints()
    {
          pointsNbr -=1;
          pointsTxt.text = pointsNbr.ToString();
    }

    public void transferPointsDataGameOver()
    {
        PlayerPrefs.SetInt("RESULTS",pointsNbr);

    }
    
    void Update()
    {
       
        countDown();
      

    }
   
    

   

    /*A CADA ACERTO OU ERRO, É PASSADO PARA O PRÓXIMO PERSONAGEM*/
    public void afterChooseObject()
    {
         next +=1;
         previous = next - 1;
        characterImage[next].enabled = true;
        characterImage[previous].enabled = false;
       
       
       
         
        
    }
    public void CharacterType()
    {
        
    }

   
}
