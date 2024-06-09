using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.SimpleLocalization;
using System;
using System.IO;
using UnityEngine.UI;

public class MultiLanguage : MonoBehaviour
{

    void Awake()
    {
        
        LocalizationManager.Read();

        
        string defaultLanguage = Application.systemLanguage == SystemLanguage.Korean ? "Korean" : "English";
        string savedLanguage = PlayerPrefs.GetString("Language", defaultLanguage);

        
        LocalizationManager.Language = savedLanguage;

        
        if (PlayerPrefs.GetString("Language", "") == "")
        {
            Language(savedLanguage);
        }
    }

    public void Language(string language)
    {
        
        LocalizationManager.Language = language;

        
        PlayerPrefs.SetString("Language", language);
        PlayerPrefs.Save();

        
        Debug.Log("Language set to: " + language);
    }



}
