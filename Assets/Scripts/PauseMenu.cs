using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    float previousTimeScale = 1;

    public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
