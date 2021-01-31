using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimeCount : MonoBehaviour
{
     public float timer;
    public Text timeTxt;
    public PointsCount pointsCount;
    void Start()
    {
        
        timeTxt.text = timer.ToString();
     
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


    // Update is called once per frame
    void Update()
    {
        countDown();
    }

    public void verifyIftimeFinished()
    {
        if(timer <= 0)
        {
           pointsCount.transferPointsDataGameOver();
           // GameManager.instance.isgameOver = true;
             LoadGameOver();
           
            
            
        }

    }
     
     public void LoadGameOver()
    {
    
        // if(GameManager.instance.isgameOver)
      //   {
               if(SceneManager.GetActiveScene().buildIndex!=4)//Game Over com ID = 4
       {
             SceneManager.LoadScene(4);
   
     //  }
         }
        
      
      
        
    }
}
