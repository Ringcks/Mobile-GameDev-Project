using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    Image timerBar;
    public float maxTime = 30f;
    float timeLeft;
    public float timeToChangeScene;
    public GameObject timesUpText;
    public string sceneName;

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


        if (timeLeft < maxTime || timeLeft < timeToChangeScene)
        {
            timeLeft += Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else if(timeLeft > maxTime || timeLeft < timeToChangeScene)
        {
            timesUpText.SetActive(true);
            Time.timeScale = 1.0f;
            //Invoke("LoadScene", 1.5f);

        }
        if(timeLeft > maxTime || timeLeft > timeToChangeScene)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
