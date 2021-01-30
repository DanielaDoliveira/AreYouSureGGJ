using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscolhaObjeto : MonoBehaviour
{
    public GameObject[] objects;
    public GameState gameStateObjChoose;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }

    
    public void ChoseCorrectObject()
    {
       gameStateObjChoose = GameState.victory;
       GameManager.instance.gameState = gameStateObjChoose;
    }
      public void ChoseWrongObject()
    {
        gameStateObjChoose = GameState.defeat;
       GameManager.instance.gameState = gameStateObjChoose;
    }
}
