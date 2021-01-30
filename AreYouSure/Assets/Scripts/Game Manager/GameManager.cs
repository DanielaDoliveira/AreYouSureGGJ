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
    
    public bool isgameOver;
   
     public GameObject[] characterVector;
     public Image[] characterImage;

  
   
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
      
         isgameOver = false;
    

       gameState = GameState.playing;
     //  btnVictory.SetActive(false);
     //  btnTryAgain.SetActive(false);
    
   
   }

   
    
    void Update()
    {
       
        
       

    }
   
   
}
