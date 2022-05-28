using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class RestartButton : MonoBehaviour
{

    public void RestartOnClick()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("Save"));
        Time.timeScale = 1;
    }
}
