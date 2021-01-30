using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextAnimationOrder : MonoBehaviour
{
  
    public GameObject globalGO;
    public Text teamLogo;
    public Animator anim;
    
    void Awake()
    {
     
    }
    void Start()
    {
    
        //SoundManager.instance.audio_Intro.Play();  
        teamLogo.text = " ";
         StartCoroutine("GlobalGameJamLogo");
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    IEnumerator teamLogoAnim()
    {
         
         teamLogo.text = "O RESTO TEAM";
         yield return new WaitForSeconds(0.5f);
        anim.SetTrigger("fade");
    }
       
   public IEnumerator GlobalGameJamLogo()
    {
        globalGO.SetActive(true);
        yield return new WaitForSeconds(6f);
        globalGO.SetActive(false);
        StartCoroutine(teamLogoAnim());
    }
}
