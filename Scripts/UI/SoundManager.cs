using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    private bool canPlayIntro;
     public AudioSource audio_Intro, fxSoundControl,fxPlayClicked;


    //if (FindObjectsByType(typeof(PlaySong)).Length > 1) {
 
    void Awake()
    {
      
       if(instance!=null)
       {
           Destroy(gameObject);
       }
       else
       {
           instance = this;
       }
     
     

         DontDestroyOnLoad(gameObject);
    }
     void Start()
     {
         
     }
       //SOM DO BOTÃO DO MENU
    public void TitleMenuSongButtons(AudioClip clip)
    {
        fxSoundControl.Play();
    }
    
     //SOM DO BOTÃO DO MENU
    public void TitleMenuSongPlay(AudioClip clip)
    {
        fxPlayClicked.Play();
    }
    

   
  

}
