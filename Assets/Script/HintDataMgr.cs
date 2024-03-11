using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using UnityEngine.SceneManagement;

public class HintDataMgr : MonoBehaviour
{

    
    
    public Button[] btn;
    public GameObject HintPnl1, HintPnl2, HintPnl3;
    public GameObject Asw1, Asw2, Asw3;
    public HintData hintData;
    public string stage;


    [ContextMenu("To Json Data")]
    void SavePlayerDataToJson()
    {
        string jsonData = JsonUtility.ToJson(hintData, true);
        string path = Path.Combine(Application.persistentDataPath, "hintData.json");
        File.WriteAllText(path, jsonData);

    }
    [ContextMenu("From Json Data")]
    void LoadPlayerDataToJson()
    {
        string path = Path.Combine(Application.persistentDataPath, "hintData.json");
        if (!File.Exists(path))
        {
            HintData hintData = new HintData();
            string newHintData = JsonUtility.ToJson(hintData, true);
            File.WriteAllText(path, newHintData);
        }
        string jsonData = File.ReadAllText(path);
        hintData = JsonUtility.FromJson<HintData>(jsonData);

    }

    // Start is called before the first frame update
    void Start()
    {
        LoadPlayerDataToJson();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (hintData.HoneSeen)
        {
            btn[0].onClick.AddListener(HintOneShow);
            btn[1].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }

        if (hintData.HtwoSeen)
        {
            btn[1].onClick.AddListener(HintTwoShow);
            btn[2].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();
        }
        if (hintData.HthreeSeen)
        {
            btn[2].onClick.AddListener(HintThreeShow);
            SavePlayerDataToJson();
        }
        if (hintData.Q2HoneSeen)
        {
            btn[3].onClick.AddListener(HintOneShow);
            btn[4].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q2HtwoSeen)
        {
            btn[4].onClick.AddListener(HintTwoShow);
            btn[5].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q2HthreeSeen)
        {
            btn[5].onClick.AddListener(HintThreeShow);
            
            SavePlayerDataToJson();

        }
        if (hintData.Q3HoneSeen)
        {
            btn[6].onClick.AddListener(HintOneShow);
            btn[7].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q3HtwoSeen)
        {
            btn[7].onClick.AddListener(HintTwoShow);
            btn[8].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q3HthreeSeen)
        {
            btn[8].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q4HoneSeen)
        {
            btn[9].onClick.AddListener(HintOneShow);
            btn[10].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q4HtwoSeen)
        {
            btn[10].onClick.AddListener(HintTwoShow);
            btn[11].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q4HthreeSeen)
        {
            btn[11].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q5HoneSeen)
        {
            btn[12].onClick.AddListener(HintOneShow);
            btn[13].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q5HtwoSeen)
        {
            btn[13].onClick.AddListener(HintTwoShow);
            btn[14].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q5HthreeSeen)
        {
            btn[14].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q6HoneSeen)
        {
            btn[15].onClick.AddListener(HintOneShow);
            btn[16].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q6HtwoSeen)
        {
            btn[16].onClick.AddListener(HintTwoShow);
            btn[17].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q6HthreeSeen)
        {
            btn[17].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q7HoneSeen)
        {
            btn[18].onClick.AddListener(HintOneShow);
            btn[19].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q7HtwoSeen)
        {
            btn[19].onClick.AddListener(HintTwoShow);
            btn[20].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q7HthreeSeen)
        {
            btn[20].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q8HoneSeen)
        {
            btn[21].onClick.AddListener(HintOneShow);
            btn[22].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q8HtwoSeen)
        {
            btn[22].onClick.AddListener(HintTwoShow);
            btn[23].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q8HthreeSeen)
        {
            btn[23].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q9HoneSeen)
        {
            btn[24].onClick.AddListener(HintOneShow);
            btn[25].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q9HtwoSeen)
        {
            btn[25].onClick.AddListener(HintTwoShow);
            btn[26].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q9HthreeSeen)
        {
            btn[26].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q10HoneSeen)
        {
            btn[27].onClick.AddListener(HintOneShow);
            btn[28].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q10HtwoSeen)
        {
            btn[28].onClick.AddListener(HintTwoShow);
            btn[29].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q10HthreeSeen)
        {
            btn[29].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q11HoneSeen)
        {
            btn[30].onClick.AddListener(HintOneShow);
            btn[31].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q11HtwoSeen)
        {
            btn[31].onClick.AddListener(HintTwoShow);
            btn[32].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q11HthreeSeen)
        {
            btn[32].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q12HoneSeen)
        {
            btn[33].onClick.AddListener(HintOneShow);
            btn[34].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q12HtwoSeen)
        {
            btn[34].onClick.AddListener(HintTwoShow);
            btn[35].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q12HthreeSeen)
        {
            btn[35].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q13HoneSeen)
        {
            btn[36].onClick.AddListener(HintOneShow);
            btn[37].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q13HtwoSeen)
        {
            btn[37].onClick.AddListener(HintTwoShow);
            btn[38].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q13HthreeSeen)
        {
            btn[38].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q14HoneSeen)
        {
            btn[39].onClick.AddListener(HintOneShow);
            btn[40].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q14HtwoSeen)
        {
            btn[40].onClick.AddListener(HintTwoShow);
            btn[41].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q14HthreeSeen)
        {
            btn[41].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q15HoneSeen)
        {
            btn[42].onClick.AddListener(HintOneShow);
            btn[43].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q15HtwoSeen)
        {
            btn[43].onClick.AddListener(HintTwoShow);
            btn[44].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q15HthreeSeen)
        {
            btn[44].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q16HoneSeen)
        {
            btn[45].onClick.AddListener(HintOneShow);
            btn[46].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q16HtwoSeen)
        {
            btn[46].onClick.AddListener(HintTwoShow);
            btn[47].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q16HthreeSeen)
        {
            btn[47].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q17HoneSeen)
        {
            btn[48].onClick.AddListener(HintOneShow);
            btn[49].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q17HtwoSeen)
        {
            btn[49].onClick.AddListener(HintTwoShow);
            btn[50].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q17HthreeSeen)
        {
            btn[50].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q18HoneSeen)
        {
            btn[51].onClick.AddListener(HintOneShow);
            btn[52].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q18HtwoSeen)
        {
            btn[52].onClick.AddListener(HintTwoShow);
            btn[53].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q18HthreeSeen)
        {
            btn[53].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q19HoneSeen)
        {
            btn[54].onClick.AddListener(HintOneShow);
            btn[55].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q19HtwoSeen)
        {
            btn[55].onClick.AddListener(HintTwoShow);
            btn[56].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q19HthreeSeen)
        {
            btn[56].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q20HoneSeen)
        {
            btn[57].onClick.AddListener(HintOneShow);
            btn[58].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q20HtwoSeen)
        {
            btn[58].onClick.AddListener(HintTwoShow);
            btn[59].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q20HthreeSeen)
        {
            btn[59].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q21HoneSeen)
        {
            btn[60].onClick.AddListener(HintOneShow);
            btn[61].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q21HtwoSeen)
        {
            btn[61].onClick.AddListener(HintTwoShow);
            btn[62].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q21HthreeSeen)
        {
            btn[62].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q22HoneSeen)
        {
            btn[63].onClick.AddListener(HintOneShow);
            btn[64].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q22HtwoSeen)
        {
            btn[64].onClick.AddListener(HintTwoShow);
            btn[65].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q22HthreeSeen)
        {
            btn[65].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q23HoneSeen)
        {
            btn[66].onClick.AddListener(HintOneShow);
            btn[67].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q23HtwoSeen)
        {
            btn[67].onClick.AddListener(HintTwoShow);
            btn[68].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q23HthreeSeen)
        {
            btn[68].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }
        if (hintData.Q24HoneSeen)
        {
            btn[69].onClick.AddListener(HintOneShow);
            btn[70].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q24HtwoSeen)
        {
            btn[70].onClick.AddListener(HintTwoShow);
            btn[71].GetComponent<Button>().interactable = true;
            SavePlayerDataToJson();

        }
        if (hintData.Q24HthreeSeen)
        {
            btn[71].onClick.AddListener(HintThreeShow);

            SavePlayerDataToJson();

        }


    }

    
    public void HintOneShow()
    {
        HintPnl1.SetActive(!HintPnl1.activeSelf);
        Asw1.SetActive(true);

    }

    public void HintTwoShow()
    {
        HintPnl2.SetActive(!HintPnl2.activeSelf);
        Asw2.SetActive(true);

    }
    public void HintThreeShow()
    {
        HintPnl3.SetActive(!HintPnl3.activeSelf);
        Asw3.SetActive(true);

    }

    public void Q1HintOnetrue()
    {
        hintData.HoneSeen = true;
    }

    public void Q1HintTwotrue()
    {
        hintData.HtwoSeen = true;
    }
    
    public void Q1HintThreetrue()
    {
        hintData.HthreeSeen = true;
    }
    public void Q2HintOnetrue()
    {
        hintData.Q2HoneSeen = true;
    }

    public void Q2HintTwotrue()
    {
        hintData.Q2HtwoSeen = true;
    }

    public void Q2HintThreetrue()
    {
        hintData.Q2HthreeSeen = true;
    }

    public void Q3HintOnetrue()
    {
        hintData.Q3HoneSeen = true;
    }

    public void Q3HintTwotrue()
    {
        hintData.Q3HtwoSeen = true;
    }

    public void Q3HintThreetrue()
    {
        hintData.Q3HthreeSeen = true;
    }

    public void Q4HintOnetrue()
    {
        hintData.Q4HoneSeen = true;
    }

    public void Q4HintTwotrue()
    {
        hintData.Q4HtwoSeen = true;
    }

    public void Q4HintThreetrue()
    {
        hintData.Q4HthreeSeen = true;
    }

    public void Q5HintOnetrue()
    {
        hintData.Q5HoneSeen = true;
    }

    public void Q5HintTwotrue()
    {
        hintData.Q5HtwoSeen = true;
    }

    public void Q5HintThreetrue()
    {
        hintData.Q5HthreeSeen = true;
    }

    public void Q6HintOnetrue()
    {
        hintData.Q6HoneSeen = true;
    }

    public void Q6HintTwotrue()
    {
        hintData.Q6HtwoSeen = true;
    }

    public void Q6HintThreetrue()
    {
        hintData.Q6HthreeSeen = true;
    }
    public void Q7HintOnetrue()
    {
        hintData.Q7HoneSeen = true;
    }

    public void Q7HintTwotrue()
    {
        hintData.Q7HtwoSeen = true;
    }

    public void Q7HintThreetrue()
    {
        hintData.Q7HthreeSeen = true;
    }
    public void Q8HintOnetrue()
    {
        hintData.Q8HoneSeen = true;
    }

    public void Q8HintTwotrue()
    {
        hintData.Q8HtwoSeen = true;
    }

    public void Q8HintThreetrue()
    {
        hintData.Q8HthreeSeen = true;
    }
    public void Q9HintOnetrue()
    {
        hintData.Q9HoneSeen = true;
    }

    public void Q9HintTwotrue()
    {
        hintData.Q9HtwoSeen = true;
    }

    public void Q9HintThreetrue()
    {
        hintData.Q9HthreeSeen = true;
    }
    public void Q10HintOnetrue()
    {
        hintData.Q10HoneSeen = true;
    }

    public void Q10HintTwotrue()
    {
        hintData.Q10HtwoSeen = true;
    }

    public void Q10HintThreetrue()
    {
        hintData.Q10HthreeSeen = true;
    }
    public void Q11HintOnetrue()
    {
        hintData.Q11HoneSeen = true;
    }

    public void Q11HintTwotrue()
    {
        hintData.Q11HtwoSeen = true;
    }

    public void Q11HintThreetrue()
    {
        hintData.Q11HthreeSeen = true;
    }
    public void Q12HintOnetrue()
    {
        hintData.Q12HoneSeen = true;
    }

    public void Q12HintTwotrue()
    {
        hintData.Q12HtwoSeen = true;
    }

    public void Q12HintThreetrue()
    {
        hintData.Q12HthreeSeen = true;
    }
    public void Q13HintOnetrue()
    {
        hintData.Q13HoneSeen = true;
    }

    public void Q13HintTwotrue()
    {
        hintData.Q13HtwoSeen = true;
    }

    public void Q13HintThreetrue()
    {
        hintData.Q13HthreeSeen = true;
    }
    public void Q14HintOnetrue()
    {
        hintData.Q14HoneSeen = true;
    }

    public void Q14HintTwotrue()
    {
        hintData.Q14HtwoSeen = true;
    }

    public void Q14HintThreetrue()
    {
        hintData.Q14HthreeSeen = true;
    }
    public void Q15HintOnetrue()
    {
        hintData.Q15HoneSeen = true;
    }

    public void Q15HintTwotrue()
    {
        hintData.Q15HtwoSeen = true;
    }

    public void Q15HintThreetrue()
    {
        hintData.Q15HthreeSeen = true;
    }
    public void Q16HintOnetrue()
    {
        hintData.Q16HoneSeen = true;
    }

    public void Q16HintTwotrue()
    {
        hintData.Q16HtwoSeen = true;
    }

    public void Q16HintThreetrue()
    {
        hintData.Q16HthreeSeen = true;
    }
    public void Q17HintOnetrue()
    {
        hintData.Q17HoneSeen = true;
    }

    public void Q17HintTwotrue()
    {
        hintData.Q17HtwoSeen = true;
    }

    public void Q17HintThreetrue()
    {
        hintData.Q17HthreeSeen = true;
    }
    public void Q18HintOnetrue()
    {
        hintData.Q18HoneSeen = true;
    }

    public void Q18HintTwotrue()
    {
        hintData.Q18HtwoSeen = true;
    }

    public void Q18HintThreetrue()
    {
        hintData.Q18HthreeSeen = true;
    }
    public void Q19HintOnetrue()
    {
        hintData.Q19HoneSeen = true;
    }

    public void Q19HintTwotrue()
    {
        hintData.Q19HtwoSeen = true;
    }

    public void Q19HintThreetrue()
    {
        hintData.Q19HthreeSeen = true;
    }
    public void Q20HintOnetrue()
    {
        hintData.Q20HoneSeen = true;
    }

    public void Q20HintTwotrue()
    {
        hintData.Q20HtwoSeen = true;
    }

    public void Q20HintThreetrue()
    {
        hintData.Q20HthreeSeen = true;
    }
    public void Q21HintOnetrue()
    {
        hintData.Q21HoneSeen = true;
    }

    public void Q21HintTwotrue()
    {
        hintData.Q21HtwoSeen = true;
    }

    public void Q21HintThreetrue()
    {
        hintData.Q21HthreeSeen = true;
    }
    public void Q22HintOnetrue()
    {
        hintData.Q22HoneSeen = true;
    }

    public void Q22HintTwotrue()
    {
        hintData.Q22HtwoSeen = true;
    }

    public void Q22HintThreetrue()
    {
        hintData.Q22HthreeSeen = true;
    }
    public void Q23HintOnetrue()
    {
        hintData.Q23HoneSeen = true;
    }

    public void Q23HintTwotrue()
    {
        hintData.Q23HtwoSeen = true;
    }

    public void Q23HintThreetrue()
    {
        hintData.Q23HthreeSeen = true;
    }
    public void Q24HintOnetrue()
    {
        hintData.Q24HoneSeen = true;
    }

    public void Q24HintTwotrue()
    {
        hintData.Q24HtwoSeen = true;
    }

    public void Q24HintThreetrue()
    {
        hintData.Q24HthreeSeen = true;
    }


}

[System.Serializable]
public class HintData
{
    
    public bool HoneSeen;
    public bool HtwoSeen;
    public bool HthreeSeen;
    public bool Q2HoneSeen;
    public bool Q2HtwoSeen;
    public bool Q2HthreeSeen;
    public bool Q3HoneSeen;
    public bool Q3HtwoSeen;
    public bool Q3HthreeSeen;
    public bool Q4HoneSeen;
    public bool Q4HtwoSeen;
    public bool Q4HthreeSeen;
    public bool Q5HoneSeen;
    public bool Q5HtwoSeen;
    public bool Q5HthreeSeen;
    public bool Q6HoneSeen;
    public bool Q6HtwoSeen;
    public bool Q6HthreeSeen;
    public bool Q7HoneSeen;
    public bool Q7HtwoSeen;
    public bool Q7HthreeSeen;
    public bool Q8HoneSeen;
    public bool Q8HtwoSeen;
    public bool Q8HthreeSeen;
    public bool Q9HoneSeen;
    public bool Q9HtwoSeen;
    public bool Q9HthreeSeen;
    public bool Q10HoneSeen;
    public bool Q10HtwoSeen;
    public bool Q10HthreeSeen;
    public bool Q11HoneSeen;
    public bool Q11HtwoSeen;
    public bool Q11HthreeSeen;
    public bool Q12HoneSeen;
    public bool Q12HtwoSeen;
    public bool Q12HthreeSeen;
    public bool Q13HoneSeen;
    public bool Q13HtwoSeen;
    public bool Q13HthreeSeen;
    public bool Q14HoneSeen;
    public bool Q14HtwoSeen;
    public bool Q14HthreeSeen;
    public bool Q15HoneSeen;
    public bool Q15HtwoSeen;
    public bool Q15HthreeSeen;
    public bool Q16HoneSeen;
    public bool Q16HtwoSeen;
    public bool Q16HthreeSeen;
    public bool Q17HoneSeen;
    public bool Q17HtwoSeen;
    public bool Q17HthreeSeen;
    public bool Q18HoneSeen;
    public bool Q18HtwoSeen;
    public bool Q18HthreeSeen;
    public bool Q19HoneSeen;
    public bool Q19HtwoSeen;
    public bool Q19HthreeSeen;
    public bool Q20HoneSeen;
    public bool Q20HtwoSeen;
    public bool Q20HthreeSeen;
    public bool Q21HoneSeen;
    public bool Q21HtwoSeen;
    public bool Q21HthreeSeen;
    public bool Q22HoneSeen;
    public bool Q22HtwoSeen;
    public bool Q22HthreeSeen;
    public bool Q23HoneSeen;
    public bool Q23HtwoSeen;
    public bool Q23HthreeSeen;
    public bool Q24HoneSeen;
    public bool Q24HtwoSeen;
    public bool Q24HthreeSeen;
}
