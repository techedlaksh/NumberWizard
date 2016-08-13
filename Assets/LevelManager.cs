using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {
    
    public void LoadLevel(string name)
    {
        //Debug.Log("Level loaded " + name);
        Application.LoadLevel(name);
    }

    public void StopLevel(string name)
    {
        Debug.Log("I want to quit!");
        Application.Quit();
    }
}
