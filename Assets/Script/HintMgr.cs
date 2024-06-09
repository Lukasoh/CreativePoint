using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HintMgr : MonoBehaviour
{
    RewardedAdManager rewardedAdManager;

    public HintData hintData;

    public Button[] hintBtn;
    public GameObject[] lockImg;
    public GameObject[] hintPnl;

    private int currentNum;
    public int startNum;

    [ContextMenu("To Json Data")]
    public void SaveProgressToJson()
    {
        string jsonData = JsonUtility.ToJson(hintData, true);
        string path = Path.Combine(Application.persistentDataPath, "hintData.json");

        File.WriteAllText(path, jsonData);
    }

    [ContextMenu("From Json Data")]
    public void LoadProgressFromJson()
    {
        string path = Path.Combine(Application.persistentDataPath, "hintData.json");
        if (!File.Exists(path))
        {
            HintData hintData = new HintData();
            hintData.SetDefault();
            string newHintData = JsonUtility.ToJson(hintData, true);
            File.WriteAllText(path, newHintData);
        }

        string jsonData = File.ReadAllText(path);
        hintData = JsonUtility.FromJson<HintData>(jsonData);

    }

    // Start is called before the first frame update
    void Start()
    {
        rewardedAdManager = FindObjectOfType<RewardedAdManager>();

        LoadProgressFromJson();
        string currentSN = SceneManager.GetActiveScene().name;
        string sceneNum = currentSN.Substring(4);
        currentNum = int.Parse(sceneNum);
        startNum = (currentNum - 1) * 3;
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckHintData();
    }

    void CheckHintData()
    {
        if(!hintData.userHint[startNum])
        {
            hintBtn[0].interactable = true;
            hintBtn[1].interactable = false;
            hintBtn[2].interactable = false;

            lockImg[0].SetActive(true);
            lockImg[1].SetActive(true);
            lockImg[2].SetActive(true);
            lockImg[3].SetActive(false);
            lockImg[4].SetActive(false);
            lockImg[5].SetActive(false);
        }
        else if(hintData.userHint[startNum] && !hintData.userHint[startNum + 1])
        {
            hintBtn[0].interactable = true;
            hintBtn[1].interactable = true;
            hintBtn[2].interactable = false;

            lockImg[0].SetActive(false);
            lockImg[1].SetActive(true);
            lockImg[2].SetActive(true);
            lockImg[3].SetActive(true);
            lockImg[4].SetActive(false);
            lockImg[5].SetActive(false);
        }

        else if(hintData.userHint[startNum + 1] && !hintData.userHint[startNum + 2])
        {
            hintBtn[0].interactable = true;
            hintBtn[1].interactable = true;
            hintBtn[2].interactable = true;

            lockImg[0].SetActive(false);
            lockImg[1].SetActive(false);
            lockImg[2].SetActive(true);
            lockImg[3].SetActive(true);
            lockImg[4].SetActive(true);
            lockImg[5].SetActive(false);
        }
        else
        {
            hintBtn[0].interactable = true;
            hintBtn[1].interactable = true;
            hintBtn[2].interactable = true;

            lockImg[0].SetActive(false);
            lockImg[1].SetActive(false);
            lockImg[2].SetActive(false);
            lockImg[3].SetActive(true);
            lockImg[4].SetActive(true);
            lockImg[5].SetActive(true);
        }
    }
    



    public void ClickBtn1()
    {
        if (!hintData.userHint[startNum]) 
        {
            rewardedAdManager.ShowRewardedAd();
        }
        else
        {
            hintPnl[0].SetActive(true);
        }
    }

    public void ClickBtn2()
    {
        if (!hintData.userHint[startNum + 1])
        {
            rewardedAdManager.ShowRewardedAd();
        }
        else
        {
            hintPnl[1].SetActive(true);
        }
    }

    public void ClickBtn3()
    {
        if (!hintData.userHint[startNum + 2])
        {
            rewardedAdManager.ShowRewardedAd();
        }
        else
        {
            hintPnl[2].SetActive(true);
        }
    }
}
[System.Serializable]
public class HintData
{
    public bool[] userHint = new bool[72];

    public void SetDefault()
    {
        for(int i = 0; i < userHint.Length; i++)
        {
            userHint[i] = false;
        }
    }
}


