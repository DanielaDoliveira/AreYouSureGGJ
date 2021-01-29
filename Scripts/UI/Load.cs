using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Load : MonoBehaviour
{
  
    public string sceneToLoad;
    public float fixedTime = 3;
    
    void Start()
    {
        StartCoroutine(LoadSceneinFixedTime(sceneToLoad));  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //espera um tempo para iniciar outra cena
    public IEnumerator LoadSceneinFixedTime(string scene)
    {
       yield return new WaitForSeconds(fixedTime);
       SceneManager.LoadScene(scene);
    }
}
