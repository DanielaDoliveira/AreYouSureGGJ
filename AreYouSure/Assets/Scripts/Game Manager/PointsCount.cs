using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointsCount : MonoBehaviour
{

     public int pointsNbr;
    public Text pointsTxt;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PointsDeclaration()
    {
        pointsNbr = 0;
        pointsTxt.text = pointsNbr.ToString();
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
}
