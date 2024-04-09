using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    float previousTimeScale = 1;

    public static bool isPaused;
    public GameObject pauseMenu;

    public void OpenPauseMenu()
    {
        if(isPaused)
        {
            pauseMenu.SetActive(true);
        }
        else
        {
            pauseMenu.SetActive(false);
        }
    }

    public void TogglePause()
    {
        if(Time.timeScale > 0)
        {
            previousTimeScale = Time.timeScale;
            Time.timeScale = 0;
            //AudioListener.pause = true;
            //pauseLabel.enabled = true;

            isPaused = true;
        }
        else if(Time.timeScale == 0)
        {
            Time.timeScale = previousTimeScale;
            //AudioListener.pause = false;
            //pauseLabel.enabled = false;

            isPaused = false;
        }
    }
}
