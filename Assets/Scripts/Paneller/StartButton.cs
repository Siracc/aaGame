using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StartButton : MonoBehaviour
{
    public void StartOnClick()
    {
        if (PlayerPrefs.GetInt("Seviye") == 1)
        {
            SceneManager.LoadScene(1);
        }
        else if (PlayerPrefs.GetInt("Seviye") == 2)
        {
            SceneManager.LoadScene(2);
        }

       else SceneManager.LoadScene(1);
    }
}
