using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D.Aseprite;
using UnityEngine;
using UnityEngine.UI;

public class LevelTwoSelection : MonoBehaviour
{
    public Button[] lvlButtons;
    LevelSelection levelSelection;

    // Start is called before the first frame update
    void Start()
    {
        levelSelection = FindObjectOfType<LevelSelection>();
        levelSelection.LoadStageDataToJson();
        SetStageStatus();
        
    }

    public void SetStageStatus()
    {
        for (int i = 12; i < levelSelection.stageData.levelOn.Length; i++)
        {
            if (levelSelection.stageData.levelOn[i])
            {
                lvlButtons[i - 12].interactable = true;
            }
            else
            {
                lvlButtons[i - 12].interactable = false;
            }
        }
    }


}
