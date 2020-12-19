using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MagicNumbers : MonoBehaviour
{
    int mini = 1;
    int maxi = 1000;
    bool gameOver = true;
    int guess;
    public Text makeUp;
    public Text guessIs;
    public Text howMany;
    public Text again;
    int count = 0;
    //float time;
    //public Text timer;


    void Start()
    {
        makeUp.text = ("Make up a number from ") + (mini) + (" to ") + (maxi) +
           (".\n\nPress Left Shift when you're ready and I will make my guesses.") +
           ("\n\nIf it's too big, click Down Arrow.\nIf it's smaller than your number click Up Arrow.") +
           ("\n\nIf I'm right click Enter to finish.\n\nLet's start!");
    }

    // Update is called once per frame
    void Update()
    {
        //time += Time.deltaTime;
        //timer.text = time.ToString("f2") + "s";
        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                GuessNumber();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                maxi = guess;
                GuessNumber();
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                mini = guess;
                GuessNumber();
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                howMany.text = count.ToString("Victory!. \nIt took me only ") + (count) + (" times to guess") +
                    ("\n\nPress Space if you want to play again");

            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                again.text = ("Let's play again! Press Left Shift");
                guess = 0;
                mini = 1;
                maxi = 1000;
                count = 0;
                gameOver = true;
            }
        }
    }
    void GuessNumber()
    {
        guess = (mini + maxi) / 2;
        guessIs.text = ("Is it ") + (guess) + ("?");
        count++;
    }

}



