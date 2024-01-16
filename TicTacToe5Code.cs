using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class TicTacToeL5Code : MonoBehaviour
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
    public Text btnText26 = null;
    public Text btnText27 = null;
    public Text btnText28 = null;
    public Text btnText29 = null;
    public Text btnText30 = null;
    public Text btnText31 = null;
    public Text btnText32 = null;
    public Text btnText33 = null;
    public Text btnText34 = null;
    public Text btnText35 = null;
    public Text btnText36 = null;
    public Text btnText37 = null;
    public Text btnText38 = null;
    public Text btnText39 = null;
    public Text btnText40 = null;
    public Text btnText41 = null;
    public Text btnText42 = null;
    public Text btnText43 = null;
    public Text btnText44 = null;
    public Text btnText45 = null;
    public Text btnText46 = null;
    public Text btnText47 = null;
    public Text btnText48 = null;
    public Text btnText49 = null;

    public Text btnReset = null;
    public Text btnNewGame = null;
    public Text msgFeedback = null;

    public Text txtPlayerX;
    public Text txtPlayerO;

    public void score()
    {
        if (btnText1.text == "X" && btnText2.text == "X" && btnText3.text == "X" && btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X" && btnText7.text == "X")
        {
            btnText1.color = Color.cyan;
            btnText2.color = Color.cyan;
            btnText3.color = Color.cyan;
            btnText4.color = Color.cyan;
            btnText5.color = Color.cyan;
            btnText6.color = Color.cyan;
            btnText7.color = Color.cyan;                
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText8.text == "X" && btnText9.text == "X" && btnText10.text == "X" && btnText11.text == "X" && btnText12.text == "X" && btnText13.text == "X" && btnText14.text == "X")
        {
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            btnText10.color = Color.red;
            btnText11.color = Color.red;
            btnText12.color = Color.red;
            btnText13.color = Color.red;
            btnText14.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText15.text == "X" && btnText16.text == "X" && btnText17.text == "X" && btnText18.text == "X" && btnText19.text == "X" && btnText20.text == "X" && btnText21.text == "X")
        {
            btnText15.color = Color.cyan;
            btnText16.color = Color.cyan;
            btnText17.color = Color.cyan;
            btnText18.color = Color.cyan;
            btnText19.color = Color.cyan;
            btnText20.color = Color.cyan;
            btnText21.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText22.text == "X" && btnText23.text == "X" && btnText24.text == "X" && btnText25.text == "X" && btnText26.text == "X" && btnText27.text == "X" && btnText28.text == "X")
        {
            btnText22.color = Color.red;
            btnText23.color = Color.red;
            btnText24.color = Color.red;
            btnText25.color = Color.red;
            btnText26.color = Color.red;
            btnText27.color = Color.red;
            btnText28.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText29.text == "X" && btnText30.text == "X" && btnText31.text == "X" && btnText32.text == "X" && btnText33.text == "X" && btnText34.text == "X" && btnText35.text == "X")
        {
            btnText29.color = Color.cyan;
            btnText30.color = Color.cyan;
            btnText31.color = Color.cyan;
            btnText32.color = Color.cyan;
            btnText33.color = Color.cyan;
            btnText34.color = Color.cyan;
            btnText35.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText36.text == "X" && btnText37.text == "X" && btnText38.text == "X" && btnText39.text == "X" && btnText40.text == "X" && btnText41.text == "X" && btnText42.text == "X")
        {
            btnText36.color = Color.red;
            btnText37.color = Color.red;
            btnText38.color = Color.red;
            btnText39.color = Color.red;
            btnText40.color = Color.red;
            btnText41.color = Color.red;
            btnText42.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText43.text == "X" && btnText44.text == "X" && btnText45.text == "X" && btnText46.text == "X" && btnText47.text == "X" && btnText48.text == "X" && btnText49.text == "X")
        {
            btnText43.color = Color.red;
            btnText44.color = Color.red;
            btnText45.color = Color.red;
            btnText46.color = Color.red;
            btnText47.color = Color.red;
            btnText48.color = Color.red;
            btnText49.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "X" && btnText8.text == "X" && btnText15.text == "X" && btnText22.text == "X" && btnText29.text == "X" && btnText36.text == "X" && btnText43.text == "X")
        {
            btnText1.color = Color.cyan;
            btnText8.color = Color.cyan;
            btnText15.color = Color.cyan;
            btnText22.color = Color.cyan;
            btnText29.color = Color.cyan;
            btnText36.color = Color.cyan;
            btnText43.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText2.text == "X" && btnText9.text == "X" && btnText16.text == "X" && btnText23.text == "X" && btnText30.text == "X" && btnText37.text == "X" && btnText44.text == "X")
        {
            btnText2.color = Color.red;
            btnText9.color = Color.red;
            btnText16.color = Color.red;
            btnText23.color = Color.red;
            btnText30.color = Color.red;
            btnText37.color = Color.red;
            btnText44.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "X" && btnText10.text == "X" && btnText17.text == "X" && btnText24.text == "X" && btnText31.text == "X" && btnText38.text == "X" && btnText45.text == "X")
        {
            btnText3.color = Color.cyan;
            btnText10.color = Color.cyan;
            btnText17.color = Color.cyan;
            btnText24.color = Color.cyan;
            btnText31.color = Color.cyan;
            btnText38.color = Color.cyan;
            btnText45.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText4.text == "X" && btnText11.text == "X" && btnText18.text == "X" && btnText25.text == "X" && btnText32.text == "X" && btnText39.text == "X" && btnText46.text == "X")
        {
            btnText4.color = Color.red;
            btnText11.color = Color.red;
            btnText17.color = Color.red;
            btnText25.color = Color.red;
            btnText32.color = Color.red;
            btnText39.color = Color.red;
            btnText46.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText5.text == "X" && btnText12.text == "X" && btnText19.text == "X" && btnText26.text == "X" && btnText33.text == "X" && btnText40.text == "X" && btnText47.text == "X")
        {
            btnText5.color = Color.cyan;
            btnText12.color = Color.cyan;
            btnText18.color = Color.cyan;
            btnText26.color = Color.cyan;
            btnText33.color = Color.cyan;
            btnText40.color = Color.cyan;
            btnText47.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText6.text == "X" && btnText13.text == "X" && btnText20.text == "X" && btnText27.text == "X" && btnText34.text == "X" && btnText41.text == "X" && btnText48.text == "X")
        {
            btnText6.color = Color.red;
            btnText13.color = Color.red;
            btnText19.color = Color.red;
            btnText27.color = Color.red;
            btnText34.color = Color.red;
            btnText41.color = Color.red;
            btnText48.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText7.text == "X" && btnText14.text == "X" && btnText21.text == "X" && btnText28.text == "X" && btnText35.text == "X" && btnText42.text == "X" && btnText49.text == "X")
        {
            btnText7.color = Color.red;
            btnText14.color = Color.red;
            btnText20.color = Color.red;
            btnText28.color = Color.red;
            btnText35.color = Color.red;
            btnText42.color = Color.red;
            btnText49.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "X" && btnText9.text == "X" && btnText17.text == "X" && btnText25.text == "X" && btnText33.text == "X" && btnText41.text == "X" && btnText49.text == "X")
        {
            btnText1.color = Color.cyan;
            btnText9.color = Color.cyan;
            btnText17.color = Color.cyan;
            btnText25.color = Color.cyan;
            btnText33.color = Color.cyan;
            btnText41.color = Color.cyan;
            btnText49.color = Color.cyan;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }
        if (btnText7.text == "X" && btnText13.text == "X" && btnText19.text == "X" && btnText25.text == "X" && btnText31.text == "X" && btnText37.text == "X" && btnText43.text == "X")
        {
            btnText7.color = Color.red;
            btnText13.color = Color.red;
            btnText19.color = Color.red;
            btnText25.color = Color.red;
            btnText21.color = Color.red;
            btnText31.color = Color.red;
            btnText37.color = Color.red;
            btnText43.color = Color.red;
            msgFeedback.text = "The winner is Player X!! :)";
            plusone = int.Parse(txtPlayerX.text);
            txtPlayerX.text = Convert.ToString(plusone + 1);
        }

        //=====================================Player O================================================

        if (btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O" && btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O" && btnText7.text == "O")
        {
            btnText1.color = Color.cyan;
            btnText2.color = Color.cyan;
            btnText3.color = Color.cyan;
            btnText4.color = Color.cyan;
            btnText5.color = Color.cyan;
            btnText6.color = Color.cyan;
            btnText7.color = Color.cyan;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText8.text == "O" && btnText9.text == "O" && btnText10.text == "O" && btnText11.text == "O" && btnText12.text == "O" && btnText13.text == "O" && btnText14.text == "O")
        {
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            btnText10.color = Color.red;
            btnText11.color = Color.red;
            btnText12.color = Color.red;
            btnText13.color = Color.red;
            btnText14.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText15.text == "O" && btnText16.text == "O" && btnText17.text == "O" && btnText18.text == "O" && btnText19.text == "O" && btnText20.text == "O" && btnText21.text == "O")
        {
            btnText15.color = Color.cyan;
            btnText16.color = Color.cyan;
            btnText17.color = Color.cyan;
            btnText18.color = Color.cyan;
            btnText19.color = Color.cyan;
            btnText20.color = Color.cyan;
            btnText21.color = Color.cyan;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText22.text == "O" && btnText23.text == "O" && btnText24.text == "O" && btnText25.text == "O" && btnText26.text == "O" && btnText27.text == "O" && btnText28.text == "O")
        {
            btnText22.color = Color.red;
            btnText23.color = Color.red;
            btnText24.color = Color.red;
            btnText25.color = Color.red;
            btnText26.color = Color.red;
            btnText27.color = Color.red;
            btnText28.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText29.text == "O" && btnText30.text == "O" && btnText31.text == "O" && btnText32.text == "O" && btnText33.text == "O" && btnText34.text == "O" && btnText35.text == "O")
        {
            btnText29.color = Color.cyan;
            btnText30.color = Color.cyan;
            btnText31.color = Color.cyan;
            btnText32.color = Color.cyan;
            btnText33.color = Color.cyan;
            btnText34.color = Color.cyan;
            btnText35.color = Color.cyan;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText36.text == "O" && btnText37.text == "O" && btnText38.text == "O" && btnText39.text == "O" && btnText40.text == "O" && btnText41.text == "O" && btnText42.text == "O")
        {
            btnText36.color = Color.red;
            btnText37.color = Color.red;
            btnText38.color = Color.red;
            btnText39.color = Color.red;
            btnText40.color = Color.red;
            btnText41.color = Color.red;
            btnText42.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText43.text == "O" && btnText44.text == "O" && btnText45.text == "O" && btnText46.text == "O" && btnText47.text == "O" && btnText48.text == "O" && btnText49.text == "O")
        {
            btnText43.color = Color.red;
            btnText44.color = Color.red;
            btnText45.color = Color.red;
            btnText46.color = Color.red;
            btnText47.color = Color.red;
            btnText48.color = Color.red;
            btnText49.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "O" && btnText8.text == "O" && btnText15.text == "O" && btnText22.text == "O" && btnText29.text == "O" && btnText36.text == "O" && btnText43.text == "O")
        {
            btnText1.color = Color.cyan;
            btnText8.color = Color.cyan;
            btnText15.color = Color.cyan;
            btnText22.color = Color.cyan;
            btnText29.color = Color.cyan;
            btnText36.color = Color.cyan;
            btnText43.color = Color.cyan;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText2.text == "O" && btnText9.text == "O" && btnText16.text == "O" && btnText23.text == "O" && btnText30.text == "O" && btnText37.text == "O" && btnText44.text == "O")
        {
            btnText2.color = Color.red;
            btnText9.color = Color.red;
            btnText16.color = Color.red;
            btnText23.color = Color.red;
            btnText30.color = Color.red;
            btnText37.color = Color.red;
            btnText44.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText3.text == "O" && btnText10.text == "O" && btnText17.text == "O" && btnText24.text == "O" && btnText31.text == "O" && btnText38.text == "O" && btnText45.text == "O")
        {
            btnText3.color = Color.cyan;
            btnText10.color = Color.cyan;
            btnText17.color = Color.cyan;
            btnText24.color = Color.cyan;
            btnText31.color = Color.cyan;
            btnText38.color = Color.cyan;
            btnText45.color = Color.cyan;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText4.text == "O" && btnText11.text == "O" && btnText18.text == "O" && btnText25.text == "O" && btnText32.text == "O" && btnText39.text == "O" && btnText46.text == "O")
        {
            btnText4.color = Color.red;
            btnText11.color = Color.red;
            btnText18.color = Color.red;
            btnText25.color = Color.red;
            btnText32.color = Color.red;
            btnText39.color = Color.red;
            btnText46.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText5.text == "O" && btnText12.text == "O" && btnText19.text == "O" && btnText26.text == "O" && btnText33.text == "O" && btnText40.text == "O" && btnText47.text == "O")
        {
            btnText5.color = Color.cyan;
            btnText12.color = Color.cyan;
            btnText19.color = Color.cyan;
            btnText26.color = Color.cyan;
            btnText33.color = Color.cyan;
            btnText40.color = Color.cyan;
            btnText47.color = Color.cyan;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText6.text == "O" && btnText13.text == "O" && btnText20.text == "O" && btnText27.text == "O" && btnText34.text == "O" && btnText41.text == "O" && btnText48.text == "O")
        {
            btnText6.color = Color.red;
            btnText13.color = Color.red;
            btnText20.color = Color.red;
            btnText27.color = Color.red;
            btnText34.color = Color.red;
            btnText41.color = Color.red;
            btnText48.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText7.text == "O" && btnText14.text == "O" && btnText21.text == "O" && btnText28.text == "O" && btnText35.text == "O" && btnText42.text == "O" && btnText49.text == "O")
        {
            btnText7.color = Color.red;
            btnText14.color = Color.red;
            btnText21.color = Color.red;
            btnText28.color = Color.red;
            btnText35.color = Color.red;
            btnText42.color = Color.red;
            btnText49.color = Color.red;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText1.text == "O" && btnText9.text == "O" && btnText17.text == "O" && btnText25.text == "O" && btnText33.text == "O" && btnText41.text == "X" && btnText49.text == "X")
        {
            btnText1.color = Color.cyan;
            btnText9.color = Color.cyan;
            btnText17.color = Color.cyan;
            btnText25.color = Color.cyan;
            btnText33.color = Color.cyan;
            btnText41.color = Color.cyan;
            btnText49.color = Color.cyan;
            msgFeedback.text = "The winner is Player O!! :)";
            plusone = int.Parse(txtPlayerO.text);
            txtPlayerO.text = Convert.ToString(plusone + 1);
        }
        if (btnText7.text == "O" && btnText13.text == "O" && btnText19.text == "O" && btnText25.text == "O" && btnText31.text == "O" && btnText37.text == "X" && btnText43.text == "X")
        {
            btnText7.color = Color.red;
            btnText13.color = Color.red;
            btnText19.color = Color.red;
            btnText25.color = Color.red;
            btnText21.color = Color.red;
            btnText31.color = Color.red;
            btnText37.color = Color.red;
            btnText43.color = Color.red;
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
    public void btnText26_Click()
    {
        if (checker == false)
        {
            btnText26.text = "X";
            checker = true;
        }
        else
        {
            btnText26.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText27_Click()
    {
        if (checker == false)
        {
            btnText27.text = "X";
            checker = true;
        }
        else
        {
            btnText27.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText28_Click()
    {
        if (checker == false)
        {
            btnText28.text = "X";
            checker = true;
        }
        else
        {
            btnText28.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText29_Click()
    {
        if (checker == false)
        {
            btnText29.text = "X";
            checker = true;
        }
        else
        {
            btnText29.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText30_Click()
    {
        if (checker == false)
        {
            btnText30.text = "X";
            checker = true;
        }
        else
        {
            btnText30.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText31_Click()
    {
        if (checker == false)
        {
            btnText31.text = "X";
            checker = true;
        }
        else
        {
            btnText31.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText32_Click()
    {
        if (checker == false)
        {
            btnText32.text = "X";
            checker = true;
        }
        else
        {
            btnText32.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText33_Click()
    {
        if (checker == false)
        {
            btnText33.text = "X";
            checker = true;
        }
        else
        {
            btnText33.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText34_Click()
    {
        if (checker == false)
        {
            btnText34.text = "X";
            checker = true;
        }
        else
        {
            btnText34.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText35_Click()
    {
        if (checker == false)
        {
            btnText35.text = "X";
            checker = true;
        }
        else
        {
            btnText35.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText36_Click()
    {
        if (checker == false)
        {
            btnText36.text = "X";
            checker = true;
        }
        else
        {
            btnText36.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText37_Click()
    {
        if (checker == false)
        {
            btnText37.text = "X";
            checker = true;
        }
        else
        {
            btnText37.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText38_Click()
    {
        if (checker == false)
        {
            btnText38.text = "X";
            checker = true;
        }
        else
        {
            btnText38.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText39_Click()
    {
        if (checker == false)
        {
            btnText39.text = "X";
            checker = true;
        }
        else
        {
            btnText39.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText40_Click()
    {
        if (checker == false)
        {
            btnText40.text = "X";
            checker = true;
        }
        else
        {
            btnText40.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText41_Click()
    {
        if (checker == false)
        {
            btnText41.text = "X";
            checker = true;
        }
        else
        {
            btnText41.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText42_Click()
    {
        if (checker == false)
        {
            btnText42.text = "X";
            checker = true;
        }
        else
        {
            btnText42.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText43_Click()
    {
        if (checker == false)
        {
            btnText43.text = "X";
            checker = true;
        }
        else
        {
            btnText43.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText44_Click()
    {
        if (checker == false)
        {
            btnText44.text = "X";
            checker = true;
        }
        else
        {
            btnText44.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText45_Click()
    {
        if (checker == false)
        {
            btnText45.text = "X";
            checker = true;
        }
        else
        {
            btnText45.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText46_Click()
    {
        if (checker == false)
        {
            btnText46.text = "X";
            checker = true;
        }
        else
        {
            btnText46.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText47_Click()
    {
        if (checker == false)
        {
            btnText47.text = "X";
            checker = true;
        }
        else
        {
            btnText47.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText48_Click()
    {
        if (checker == false)
        {
            btnText48.text = "X";
            checker = true;
        }
        else
        {
            btnText48.text = "O";
            checker = false;
        }
        score();
    }
    public void btnText49_Click()
    {
        if (checker == false)
        {
            btnText49.text = "X";
            checker = true;
        }
        else
        {
            btnText49.text = "O";
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
        btnText26.text = "";
        btnText27.text = "";
        btnText28.text = "";
        btnText29.text = "";
        btnText30.text = "";
        btnText31.text = "";
        btnText32.text = "";
        btnText33.text = "";
        btnText34.text = "";
        btnText35.text = "";
        btnText36.text = "";
        btnText37.text = "";
        btnText38.text = "";
        btnText39.text = "";
        btnText40.text = "";
        btnText41.text = "";
        btnText42.text = "";
        btnText43.text = "";
        btnText44.text = "";
        btnText45.text = "";
        btnText47.text = "";
        btnText48.text = "";
        btnText49.text = "";

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
        btnText26.color = Color.black;
        btnText27.color = Color.black;
        btnText28.color = Color.black;
        btnText29.color = Color.black;
        btnText30.color = Color.black;
        btnText31.color = Color.black;
        btnText32.color = Color.black;
        btnText33.color = Color.black;
        btnText34.color = Color.black;
        btnText35.color = Color.black;
        btnText36.color = Color.black;
        btnText37.color = Color.black;
        btnText38.color = Color.black;
        btnText39.color = Color.black;
        btnText40.color = Color.black;
        btnText41.color = Color.black;
        btnText42.color = Color.black;
        btnText43.color = Color.black;
        btnText44.color = Color.black;
        btnText45.color = Color.black;
        btnText46.color = Color.black;
        btnText47.color = Color.black;
        btnText48.color = Color.black;
        btnText49.color = Color.black;
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

