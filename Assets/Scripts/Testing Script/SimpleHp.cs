using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class SimpleHp : MonoBehaviour
{
    public Image healthBar;
    public GameObject player;
    private PlayerHp playerHpScript;
    public float targetTime = 60.0f;
    public TMP_Text valueText;

    void Update()
    {


    }

    void Dead()
    {
        //do your stuff here.
    }

    void UpdateHealthBar()
    {
        // Calculate health percentage
        float healthPercentage = playerHpScript.Hp / playerHpScript.MaxHp;

        // Set health bar fill amount
        healthBar.fillAmount = healthPercentage;
    }

}
