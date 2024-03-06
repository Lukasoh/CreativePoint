using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundMgr : MonoBehaviour
{
    public Text OnTxt;
    public Text OffTxt;
    
    
    

   
    
    public void SoundOn()
    {
        AudioListener.volume = 1;

       

        
        
    }

    public void SoundOff()
    {
        AudioListener.volume = 0;

        

    }


    


    

}
