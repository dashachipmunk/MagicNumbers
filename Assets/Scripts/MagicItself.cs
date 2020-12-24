using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using System;
using UnityEngine.UI;



public class MagicItself : MonoBehaviour
{

    int min = 1;
    public int max;
    int number;
    bool gameOver = true;
    int guess;
    public Text howMany;
    public Text myNumber;
    public int count = 0;

    void Start()
    {
        max = Random.Range(10, 10000);
        print("My max is " + max);
        number = Random.Range(min, max);
        myNumber.text ="My number is " + number;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameOver)
        {
            GuessNumber();
            while (number != guess)
            {
                if (number < guess)
                {
                    max = guess;
                    GuessNumber();
                }
                if (number > guess)
                {
                    min = guess;
                    GuessNumber();
                }
            }

            if (number == guess)
            {
                howMany.text = "It took " + count + " times to guess";
            }

            gameOver = false;
        }
    }
    void GuessNumber()
    {
        guess = (min + max) / 2;
        count++;
    }
    
}


