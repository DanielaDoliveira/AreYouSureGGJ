using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButtonBehaviour : MonoBehaviour
{
    public void btnBack()
    {
        SceneManager.LoadScene(0);//ACESSA A TELA DE USER INTERFACE
    }
    

    
}
