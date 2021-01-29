using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    private bool canPlayIntro;
     public AudioSource audio_Intro, fxSoundControl;


    //if (FindObjectsByType(typeof(PlaySong)).Length > 1) {
 
    void Awake()
    {
    
          if(instance == null)
       {
           instance = this;
       }
       else
       {
           Destroy(gameObject);
       }
       DontDestroyOnLoad(gameObject);
    }
     void Start()
     {
          audio_Intro.UnPause();
     }
       //SOM DO BOTÃO DO MENU
    public void TitleMenuSongButtons(AudioClip clip)
    {
        fxSoundControl.Play();
    }
  
    

   
  

}
