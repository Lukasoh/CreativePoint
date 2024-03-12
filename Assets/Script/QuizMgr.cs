using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizMgr : MonoBehaviour
{
    public Text ScriptTxt;
    public GameObject Correct;
    public GameObject KeyBoard;
    StageLvlController stageLvlController;

    private void Start()
    {
        stageLvlController = FindObjectOfType<StageLvlController>();
    }

    public void QuizAnswer1()
    {
        if (ScriptTxt.text == "16")
        {
            Correct.SetActive(true);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer2()
    {
        if (ScriptTxt.text == "32")
        {
            Correct.SetActive(true);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer3()
    {
        if (ScriptTxt.text == "M")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer4()
    {
        if (ScriptTxt.text == "0")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer5()
    {
        if (ScriptTxt.text == "15")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer6()
    {
        if (ScriptTxt.text == "C")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer7()
    {
        if (ScriptTxt.text == "T")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer8()
    {
        if (ScriptTxt.text == "GOD")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer9()
    {
        if (ScriptTxt.text == "2")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer10()
    {
        if (ScriptTxt.text == "18")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer11()
    {
        if (ScriptTxt.text == "85")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer12()
    {
        if (ScriptTxt.text == "17")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer13()
    {
        if (ScriptTxt.text == "610")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer14()
    {
        if (ScriptTxt.text == "4")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer15()
    {
        if (ScriptTxt.text == "12")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer16()
    {
        if (ScriptTxt.text == "23")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer17()
    {
        if (ScriptTxt.text == "65188")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
    public void QuizAnswer18()
    {
        if (ScriptTxt.text == "68")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }

    public void QuizAnswer19()
    {
        if (ScriptTxt.text == "1000")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }

    public void QuizAnswer20()
    {
        if (ScriptTxt.text == "14")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }

    public void QuizAnswer21()
    {
        if (ScriptTxt.text == "9")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }

    public void QuizAnswer22()
    {
        if (ScriptTxt.text == "14")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }

    public void QuizAnswer23()
    {
        if (ScriptTxt.text == "8")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }

    public void QuizAnswer24()
    {
        if (ScriptTxt.text == "50")
        {
            Correct.SetActive(true);
            KeyBoard.SetActive(false);
            stageLvlController.CorrectAnswer();
        }
        else
        {
            ScriptTxt.text = "Wrong";

        }
    }
}

