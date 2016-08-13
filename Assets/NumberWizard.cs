using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    int guess;
    int maxGuessAllowed = 5;
    public Text text;

    void Start () {
        StartGame();
    }

    // Start the Game
    void StartGame()
    {
        max = 1000;
        min = 1;
        guess = 500;
        max = max + 1;
        min = min - 1;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        text.text = guess.ToString();
        maxGuessAllowed -= 1;
        if(maxGuessAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
    }

    void Again()
    {
        print("Wanna play again?");
    }

    // Update is called once per frame
    void Update () {
	    if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            GuessHigher();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            GuessLower();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Application.LoadLevel("Lose");    
        }
        else if (Input.GetKeyDown(KeyCode.Y))
        {
            print("Yes!");
            StartGame();
        }
        else if (Input.GetKeyDown(KeyCode.N))
        {
            print("No!");
            print("Thank you for playing!");
        }

    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
}
