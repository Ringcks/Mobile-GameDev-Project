using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SimpleTimer : MonoBehaviour
{

    public float targetTime = 60.0f;
    public TMP_Text valueText;

    void Update()
    {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

        UpdateTime();
    }

    void timerEnded()
    {
        //do your stuff here.
    }

    void UpdateTime()
    {
        // Calculate health percentage
        float value = targetTime;

        valueText.text = value.ToString("0");
    }

}
