using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleLocalization;
using System;
using System.IO;
using UnityEngine.UI;

public class MultiLanguage : MonoBehaviour
{
    
    static void Awake()
    {
        LocalizationManager.Read();

        switch (Application.systemLanguage)
        {
            case SystemLanguage.English:
                LocalizationManager.Language = "English";
                PlayerPrefs.SetString("English", LocalizationManager.Language);
                break;
            case SystemLanguage.Korean:
                LocalizationManager.Language = "Korean";
                PlayerPrefs.SetString("Korean", LocalizationManager.Language);
                break;
        }
    }

    public void Language(string language)
    {
        LocalizationManager.Language = language;
        
    }

   

    
}
