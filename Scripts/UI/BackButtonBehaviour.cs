using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BackButtonBehaviour : MonoBehaviour
{
    public void btnBack()
    {
        SceneManager.LoadScene(1);//ACESSA A TELA DE USER INTERFACE
    }
    

    
}
