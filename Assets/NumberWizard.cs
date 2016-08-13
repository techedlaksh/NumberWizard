using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

    // Use this for initialization
    int max;
    int min;
    public int guess;
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
        max = max + 1;
        NextGuess();
    }

    void NextGuess()
    {
        //guess = (max + min) / 2;
        guess = Random.Range(min, max);
        text.text = guess.ToString();
        maxGuessAllowed -= 1;
        if(maxGuessAllowed <= 0)
        {
            Application.LoadLevel("Win");
        }
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
