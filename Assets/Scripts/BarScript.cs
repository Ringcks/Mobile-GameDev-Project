using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BarScript : MonoBehaviour
{
    public Image healthBar;
    public GameObject player;
    private PlayerHp playerHpScript;
    public TMP_Text valueText;

    // Start is called before the first frame update
    void Start()
    {
        playerHpScript = player.GetComponent<PlayerHp>();

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
        float healthPercentage = playerHpScript.Hp / playerHpScript.MaxHp;
        float value = playerHpScript.Hp / 10;

        valueText.text = value.ToString("0") + "%";

        // Set health bar fill amount
        healthBar.fillAmount = healthPercentage;
    }
}
