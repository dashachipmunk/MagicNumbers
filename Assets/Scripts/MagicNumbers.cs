using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MagicNumbers : MonoBehaviour
{
    string number = "";
    int mini = 1;
    bool gameOver = true;
    int guess;
    public Text makeUp;
    public Text guessIs;
    public Text howMany;
    public Text again;
    public Text sizeInput;
    int count = 0;
   
    KeyCode[] keyCodes = {KeyCode.Alpha0, KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4,
            KeyCode.Alpha5, KeyCode.Alpha6, KeyCode.Alpha7, KeyCode.Alpha8, KeyCode.Alpha9};

    void Start()
    {
        makeUp.text = ("Make up a number from 1 to a number you'll type. You can do it now.") +
          (".\n\nPress Left Shift when you're ready and I will make my guesses.") +
          ("\n\nIf it's too big, click Down Arrow.\nIf it's smaller than your number click Up Arrow.") +
          ("\n\nIf I'm right click Enter to finish.\n\nLet's start!");
    }

    // Update is called once per frame
    void Update()
    {
        foreach (KeyCode code in keyCodes)
        {
            if (Input.GetKeyDown(code))
            {
                string codeStr = code.ToString();
                number += codeStr[codeStr.Length - 1];
                print(number);
            }
        }
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                GuessNumber();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                number = guess.ToString();
                GuessNumber();
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                mini = guess;
                GuessNumber();
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                howMany.text = "Victory!\nIt took me only " + count + " times to guess" +
                    "\n\nPress Space if you want to play again";
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                again.text = "Let's play again! Type in the max number and press Left Shift";
                guess = 0;
                mini = 1;
                number = "";
                count = 0;
                gameOver = true;
            }
        }
    }
    void GuessNumber()
    {
        int max = Convert.ToInt32(number);
        guess = (mini + max) / 2;
        guessIs.text = "Is it " + guess + "?";
        count++;
    }
}



