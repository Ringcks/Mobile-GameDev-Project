using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BossBarScript : MonoBehaviour
{
    public Image healthBar;
    public GameObject boss;
    private BossBehaviour bossHp;

    // Start is called before the first frame update
    void Start()
    {
        bossHp = boss.GetComponent<BossBehaviour>();

        // Set the initial health bar fill amount based on player's health
        UpdateHealthBar();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        // Calculate health percentage
        float healthPercentage = bossHp.Hp / bossHp.MaxHp;

        // Set health bar fill amount
        healthBar.fillAmount = healthPercentage;
    }
}
