using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000, min = 1, mid = 500;
    // Start is called before the first frame update
    void Start()
    {
        //Intro();
        StartGame();
    }

    void Intro()
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("Pick a number!");
        bool intro = true;
        while (intro)
        {
            Debug.Log("Are you ready to start? Press Y if Yes, N if No");
            if (Input.GetKeyDown(KeyCode.Y))
            {
                Debug.Log("Sweet, lets start");
                intro = false;
            }
            else
            {
                Debug.Log("Alright we can wait . . .");
            }
        }
    }

    void StartGame()
    {
        Debug.Log("The highest number is: " + max);
        Debug.Log("The lowest number is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500 ");
        Debug.Log("Push up for greater than 500, down for less than 500, and Enter for correct");
        max += 1;
    }
    void NextGuess()
    {
        mid = (max + min) / 2;
        Debug.Log("Is it higher or lower than ... " + mid);
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = mid;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = mid;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed your number!");
        }
    }
}
