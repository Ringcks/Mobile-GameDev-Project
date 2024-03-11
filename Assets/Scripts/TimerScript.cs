using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 30f;
    float timeLeft;
    public GameObject timesUpText;

    // Start is called before the first frame update
    void Start()
    {
        timesUpText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(timeLeft < maxTime)
        {
            timeLeft += Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            timesUpText.SetActive(true);
            Time.timeScale = 1.0f;
        }
    }
}
