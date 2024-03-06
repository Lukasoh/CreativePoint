using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelTwoSelection : MonoBehaviour
{
    public Button[] lvlButtons;

    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt", 14);

        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i + 14> levelAt)
                lvlButtons[i].interactable = false;
        }
    }

    
}
