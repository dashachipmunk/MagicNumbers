using System.Collections;

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MyMagic : MonoBehaviour
{
    public int min = 1;
    public int max;
    bool gameOver = true;
    int myGuess;
    public Text makeUp;
    public Text guessIs;
    public Text howMany;
    public int count = 0;
    //public MagicItself computer;

    void Start()
    {
        max = Random.Range(10, 10000);
        print("Your max is " + max);
        makeUp.text = "Make up a number from 1 to " + max + "\nPress Left Shift when you are ready." +
            "Press Up if the number is bigger." + "\nPress Down if it's lesser." + "\nClick Enter if the number is the one you thought.";
    }

    // Update is called once per frame
    void Update()
    {

        if (gameOver)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                GuessNumber();
            }
            if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                max = myGuess;
                GuessNumber();
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                min = myGuess;
                GuessNumber();
            }
            if (Input.GetKeyDown(KeyCode.Return))
            {
                howMany.text = "It took " + count + " times to guess";
            }
        }
    }
    void GuessNumber()
    {

        myGuess = (min + max) / 2;
        guessIs.text = "Is it " + myGuess + "?";
        count++;
    }
}



