using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class TicTacToeL3Code : MonoBehaviour
{
    Boolean checker;
    int plusone;

    public Text btnText1 = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;
    public Text btnText10 = null;
    public Text btnText11 = null;
    public Text btnText12 = null;
    public Text btnText13 = null;
    public Text btnText14 = null;
    public Text btnText15 = null;
    public Text btnText16 = null;
    public Text btnText17 = null;
    public Text btnText18 = null;
    public Text btnText19 = null;
    public Text btnText20 = null;
    public Text btnText21 = null;
    public Text btnText22 = null;
    public Text btnText23 = null;
    public Text btnText24 = null;
    public Text btnText25 = null;

    public Text btnReset = null;
    public Text btnNewGame = null;
    public Text msgFeedback = null;

    public Text txtPlayerX;
    public Text txtPlayerO;

    public void score()
    {
        if (btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X" && btnText4.text == "X" && btnText5.text == "X")
        {
            btnText1.color = Color.cyan;
            btnText2.color = Color.cyan;
            btnText3.color = Color.cyan;
            btnText4.color = Color.cyan;
            btnText5.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText6.text == "X" && btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X" && btnText10.text == "X")
        {
            btnText6.color = Color.red;
            btnText7.color = Color.red;
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            btnText10.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText11.text == "X" && btnText12.text == "X" && btnText13.text == "X" && btnText14.text == "X" && btnText15.text == "X")
        {
            btnText11.color = Color.cyan;
            btnText12.color = Color.cyan;
            btnText13.color = Color.cyan;
            btnText14.color = Color.cyan;
            btnText15.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText16.text == "X" && btnText17.text == "X" && btnText18.text == "X" && btnText19.text == "X" && btnText20.text == "X")
        {
            btnText16.color = Color.red;
            btnText17.color = Color.red;
            btnText18.color = Color.red;
            btnText19.color = Color.red;
            btnText20.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText21.text == "X" && btnText22.text == "X" && btnText23.text == "X" && btnText24.text == "X" && btnText25.text == "X")
        {
            btnText21.color = Color.cyan;
            btnText22.color = Color.cyan;
            btnText23.color = Color.cyan;
            btnText24.color = Color.cyan;
            btnText25.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "X" && btnText6.text == "X" && btnText11.text == "X" && btnText16.text == "X" && btnText21.text == "X")
        {
            btnText1.color = Color.red;
            btnText6.color = Color.red;
            btnText11.color = Color.red;
            btnText16.color = Color.red;
            btnText21.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText2.text == "X" && btnText7.text == "X" && btnText12.text == "X" && btnText17.text == "X" && btnText22.text == "X")
        {
            btnText2.color = Color.cyan;
            btnText7.color = Color.cyan;
            btnText12.color = Color.cyan;
            btnText17.color = Color.cyan;
            btnText22.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "X" && btnText8.text == "X" && btnText13.text == "X" && btnText18.text == "X" && btnText23.text == "X")
        {
            btnText3.color = Color.red;
            btnText8.color = Color.red;
            btnText13.color = Color.red;
            btnText18.color = Color.red;
            btnText23.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText4.text == "X" && btnText9.text == "X" && btnText14.text == "X" && btnText19.text == "X" && btnText24.text == "X")
        {
            btnText4.color = Color.cyan;
            btnText9.color = Color.cyan;
            btnText14.color = Color.cyan;
            btnText19.color = Color.cyan;
            btnText24.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText5.text == "X" && btnText10.text == "X" && btnText15.text == "X" && btnText20.text == "X" && btnText25.text == "X")
        {
            btnText5.color = Color.red;
            btnText10.color = Color.red;
            btnText15.color = Color.red;
            btnText20.color = Color.red;
            btnText25.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1 );
        }
        if (btnText1.text == "X" && btnText7.text == "X" && btnText13.text == "X" && btnText19.text == "X" && btnText25.text == "X")
        {
            btnText1.color = Color.cyan;
            btnText7.color = Color.cyan;
            btnText13.color = Color.cyan;
            btnText19.color = Color.cyan;
            btnText25.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText5.text == "X" && btnText9.text == "X" && btnText13.text == "X" && btnText17.text == "X" && btnText21.text == "X")
        {
            btnText1.color = Color.red;
            btnText7.color = Color.red;
            btnText13.color = Color.red;
            btnText19.color = Color.red;
            btnText25.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone +  1);
        }

        //=====================================Player O================================================

        if (btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O" && btnText4.text == "O" && btnText5.text == "O")
        {
            btnText1.color = Color.blue;
            btnText2.color = Color.blue;
            btnText3.color = Color.blue;
            btnText4.color = Color.blue;
            btnText5.color = Color.blue;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText6.text == "O" && btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O" && btnText10.text == "O")
        {
            btnText6.color = Color.red;
            btnText7.color = Color.red;
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            btnText10.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText11.text == "O" && btnText12.text == "O" && btnText13.text == "O" && btnText14.text == "O" && btnText15.text == "O")
        {
            btnText11.color = Color.blue;
            btnText12.color = Color.blue;
            btnText13.color = Color.blue;
            btnText14.color = Color.blue;
            btnText15.color = Color.blue;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText16.text == "O" && btnText17.text == "O" && btnText18.text == "O" && btnText19.text == "O" && btnText20.text == "O")
        {
            btnText16.color = Color.red;
            btnText17.color = Color.red;
            btnText18.color = Color.red;
            btnText19.color = Color.red;
            btnText20.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText21.text == "O" && btnText22.text == "O" && btnText23.text == "O" && btnText24.text == "O" && btnText25.text == "O")
        {
            btnText21.color = Color.blue;
            btnText22.color = Color.blue;
            btnText23.color = Color.blue;
            btnText24.color = Color.blue;
            btnText25.color = Color.blue;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "O" && btnText6.text == "O" && btnText11.text == "O" && btnText16.text == "O" && btnText21.text == "O")
        {
            btnText1.color = Color.red;
            btnText6.color = Color.red;
            btnText11.color = Color.red;
            btnText16.color = Color.red;
            btnText21.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText2.text == "O" && btnText7.text == "O" && btnText12.text == "O" && btnText17.text == "O" && btnText22.text == "O")
        {
            btnText2.color = Color.blue;
            btnText7.color = Color.blue;
            btnText12.color = Color.blue;
            btnText17.color = Color.blue;
            btnText22.color = Color.blue;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "O" && btnText8.text == "O" && btnText13.text == "O" && btnText18.text == "O" && btnText23.text == "O")
        {
            btnText3.color = Color.red;
            btnText8.color = Color.red;
            btnText13.color = Color.red;
            btnText18.color = Color.red;
            btnText23.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText4.text == "O" && btnText9.text == "O" && btnText14.text == "O" && btnText19.text == "O" && btnText24.text == "O")
        {
            btnText4.color = Color.blue;
            btnText9.color = Color.blue;
            btnText14.color = Color.blue;
            btnText19.color = Color.blue;
            btnText24.color = Color.blue;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText5.text == "O" && btnText10.text == "O" && btnText15.text == "O" && btnText20.text == "O" && btnText25.text == "O")
        {
            btnText5.color = Color.red;
            btnText10.color = Color.red;
            btnText15.color = Color.red;
            btnText20.color = Color.red;
            btnText25.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "O" && btnText7.text == "O" && btnText13.text == "O" && btnText19.text == "O" && btnText25.text == "O")
        {
            btnText1.color = Color.blue;
            btnText7.color = Color.blue;
            btnText13.color = Color.blue;
            btnText19.color = Color.blue;
            btnText25.color = Color.blue;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText5.text == "O" && btnText9.text == "O" && btnText13.text == "O" && btnText17.text == "O" && btnText21.text == "O")
        {
            btnText5.color = Color.red;
            btnText9.color = Color.red;
            btnText13.color = Color.red;
            btnText17.color = Color.red;
            btnText21.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
    }
    public void btnText1_Click()
    {
        if (checker == false)
        {
            btnText1.text = "X";
            checker = true;
        }
        else
        {
            btnText1.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText2_Click()
    {
        if (checker == false)
        {
            btnText2.text = "X";
            checker = true;
        }
        else
        {
            btnText2.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText3_Click()
    {
        if (checker == false)
        {
            btnText3.text = "X";
            checker = true;
        }
        else
        {
            btnText3.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText4_Click()
    {
        if (checker == false)
        {
            btnText4.text = "X";
            checker = true;
        }
        else
        {
            btnText4.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText5_Click()
    {
        if (checker == false)
        {
            btnText5.text = "X";
            checker = true;
        }
        else
        {
            btnText5.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText6_Click()
    {
        if (checker == false)
        {
            btnText6.text = "X";
            checker = true;
        }
        else
        {
            btnText6.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText7_Click()
    {
        if (checker == false)
        {
            btnText7.text = "X";
            checker = true;
        }
        else
        {
            btnText7.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText8_Click()
    {
        if (checker == false)
        {
            btnText8.text = "X";
            checker = true;
        }
        else
        {
            btnText8.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText9_Click()
    {
        if (checker == false)
        {
            btnText9.text = "X";
            checker = true;
        }
        else
        {
            btnText9.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText10_Click()
    {
        if (checker == false)
        {
            btnText10.text = "X";
            checker = true;
        }
        else
        {
            btnText10.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText11_Click()
    {
        if (checker == false)
        {
            btnText11.text = "X";
            checker = true;
        }
        else
        {
            btnText11.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText12_Click()
    {
        if (checker == false)
        {
            btnText12.text = "X";
            checker = true;
        }
        else
        {
            btnText12.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText13_Click()
    {
        if (checker == false)
        {
            btnText13.text = "X";
            checker = true;
        }
        else
        {
            btnText13.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText14_Click()
    {
        if (checker == false)
        {
            btnText14.text = "X";
            checker = true;
        }
        else
        {
            btnText14.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText15_Click()
    {
        if (checker == false)
        {
            btnText15.text = "X";
            checker = true;
        }
        else
        {
            btnText15.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText16_Click()
    {
        if (checker == false)
        {
            btnText16.text = "X";
            checker = true;
        }
        else
        {
            btnText16.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText17_Click()
    {
        if (checker == false)
        {
            btnText17.text = "X";
            checker = true;
        }
        else
        {
            btnText17.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText18_Click()
    {
        if (checker == false)
        {
            btnText18.text = "X";
            checker = true;
        }
        else
        {
            btnText18.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText19_Click()
    {
        if (checker == false)
        {
            btnText19.text = "X";
            checker = true;
        }
        else
        {
            btnText19.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText20_Click()
    {
        if (checker == false)
        {
            btnText20.text = "X";
            checker = true;
        }
        else
        {
            btnText20.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText21_Click()
    {
        if (checker == false)
        {
            btnText21.text = "X";
            checker = true;
        }
        else
        {
            btnText21.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText22_Click()
    {
        if (checker == false)
        {
            btnText22.text = "X";
            checker = true;
        }
        else
        {
            btnText22.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText23_Click()
    {
        if (checker == false)
        {
            btnText23.text = "X";
            checker = true;
        }
        else
        {
            btnText23.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText24_Click()
    {
        if (checker == false)
        {
            btnText24.text = "X";
            checker = true;
        }
        else
        {
            btnText24.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText25_Click()
    {
        if (checker == false)
        {
            btnText25.text = "X";
            checker = true;
        }
        else
        {
            btnText25.text = "O";
            checker = false;
        }
        score();
    }

    public void btnReset_Click()
    {
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";
        btnText10.text = "";
        btnText11.text = "";
        btnText12.text = "";
        btnText13.text = "";
        btnText14.text = "";
        btnText15.text = "";
        btnText16.text = "";
        btnText17.text = "";
        btnText18.text = "";
        btnText19.text = "";
        btnText20.text = "";
        btnText21.text = "";
        btnText22.text = "";
        btnText23.text = "";
        btnText24.text = "";
        btnText25.text = "";


        btnText1.color = Color.black;
        btnText2.color = Color.black;
        btnText3.color = Color.black;
        btnText4.color = Color.black;
        btnText5.color = Color.black;
        btnText6.color = Color.black;
        btnText7.color = Color.black;
        btnText8.color = Color.black;
        btnText9.color = Color.black;
        btnText10.color = Color.black;
        btnText11.color = Color.black;
        btnText12.color = Color.black;
        btnText13.color = Color.black;
        btnText14.color = Color.black;
        btnText15.color = Color.black;
        btnText16.color = Color.black;
        btnText17.color = Color.black;
        btnText18.color = Color.black;
        btnText19.color = Color.black;
        btnText20.color = Color.black;
        btnText21.color = Color.black;
        btnText22.color = Color.black;
        btnText23.color = Color.black;
        btnText24.color = Color.black;
        btnText25.color = Color.black;
    }
    public void btnNewGame_Click()
    {
        btnReset_Click();
        txtPlayerX.text = "";
        txtPlayerO.text = "";
    }
    public void LoadNextScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int nextSceneIndex = (currentSceneIndex + 1) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(nextSceneIndex);
    }

    // Function to load the previous scene in the build settings
    public void LoadPreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int previousSceneIndex = (currentSceneIndex - 1 + SceneManager.sceneCountInBuildSettings) % SceneManager.sceneCountInBuildSettings;
        SceneManager.LoadScene(previousSceneIndex);
    }
}

