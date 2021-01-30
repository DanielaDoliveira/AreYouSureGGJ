using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*CLASSE QUE VERIFICA PONTOS E DECIDE O RESULTADO FINAL*/
public class GameOver : MonoBehaviour
{
    public int pointsNbr;
    public Text pointsTxt;
    public Text showMessageToPlayer;
       void Start()
    {
        
        pointsNbr = PlayerPrefs.GetInt("RESULTS");
        pointsTxt.text = pointsNbr.ToString();
        VictoryOrDefeat();
    }

    //VERIFICA SE, DEPENDENDO DA QUANTIA DE PONTOS, GANHOU OU PERDEU
    public void VictoryOrDefeat()
    {
        if(pointsNbr<50)
        {
            showMessageToPlayer.text = "YOU FIRED! TOO BAD!";
        }
        else if(pointsNbr>=50)
        {
              showMessageToPlayer.text = "YOU GOT A PROMOTION! VERY GOOD, MAN!";
        }
    }
    void Update() 
    {
      
    }
   
}
