using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseAudio : MonoBehaviour
{
 
    void Start()
    {
        SoundManager.instance.audio_Intro.Stop();  //Pára completamente a música. 
    }

    
    void Update()
    {
        
    }
}
