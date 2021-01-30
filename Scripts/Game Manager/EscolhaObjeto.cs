using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*ESTA CLASSE É A RESPONSÁVEL POR DISTRIBUIR OS PONTOS DEPENDENDO DA ESCOLHA*/
public class EscolhaObjeto : MonoBehaviour
{
    public GameObject[] objects;
    public GameState gameStateObjChoose;
    public int pointNbr;
    public string pointTxt;

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
