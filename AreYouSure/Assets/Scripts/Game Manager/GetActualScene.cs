using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GetActualScene : MonoBehaviour
{
       int scene;
       public static GetActualScene instance;
       void Awake()
       {
         
       }
    void Start()
    {
          scene = SceneManager.GetActiveScene().buildIndex;
           PlayerPrefs.SetInt("SCENE",scene);
    }
    public void SetScene()
    {
       
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
