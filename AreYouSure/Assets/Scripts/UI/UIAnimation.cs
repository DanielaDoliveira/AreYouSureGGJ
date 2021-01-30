using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIAnimation : MonoBehaviour
{
   
   public GameObject[]button;
   public GameObject logo;

   void Awake() 
   {
       logo.SetActive(false);
       StartingInvisibleButtons();
   }
    void Start()
    {
        
        StartCoroutine(MenuUIAnimation());
    }

  
    void Update()
    {
        
    }
    IEnumerator MenuUIAnimation()
    {
        yield return new WaitForSeconds(3f);
        appearLogo();
        yield return new WaitForSeconds(1f);
        appearButtons();
    }
    void appearButtons()
    {
        for(int i = 0;i<3;i++)
        {
            button[i].SetActive(true);
        }
    }

    void StartingInvisibleButtons()
    {
        
        for(int i = 0;i<3;i++)
        {
            button[i].SetActive(false);
        }
    }
    void appearLogo()
    {
        logo.SetActive(true);
    }
}
