using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{
    public Button[] lvlButtons;
    public StageData stageData;
    
    // Start is called before the first frame update
    void Start()
    {
        LoadStageDataToJson();
        stageData.CheckDefault();
        SetStageStatus();
    }


    [ContextMenu("To Json Data")]
    public void SaveStageDataToJson()
    {
        string jsonData = JsonUtility.ToJson(stageData, true);
        string path = Path.Combine(Application.persistentDataPath, "stageData.json");
        File.WriteAllText(path, jsonData);

    }
    [ContextMenu("From Json Data")]
    public void LoadStageDataToJson()
    {
        string path = Path.Combine(Application.persistentDataPath, "stageData.json");
        if (!File.Exists(path))
        {
            StageData stageData = new StageData();   
            string newStageData = JsonUtility.ToJson(stageData, true);
            stageData.levelOn[0] = true;
            File.WriteAllText(path, newStageData);
            
        }
        string jsonData = File.ReadAllText(path);
        stageData = JsonUtility.FromJson<StageData>(jsonData);


    }

    

    public void LevelManager(int currentScene)
    {
        for (int i = 0; i < stageData.levelOn.Length; i++)
        {
            if (currentScene == i + 3)
            {
                if(i != stageData.levelOn.Length - 1)
                {
                    stageData.levelOn[i + 1] = true;
                }
                
            }
        }
        SaveStageDataToJson();
    }

    public void SetStageStatus()
    {
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (stageData.levelOn[i])
            {
                lvlButtons[i].interactable = true;
            }
            else
            {
                lvlButtons[i].interactable = false;
            }
        }
    }

}

[System.Serializable]

public class StageData
{
    public bool[] levelOn = new bool[24];

    public void CheckDefault()
    {
        if (levelOn[0] == false)
        {
            levelOn[0] = true;
        }
    }
}

