using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerStats : MonoBehaviour
{
    [Header("Info Text")]
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI classNameText;

    [Header("Stats Text")]
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI strengthText;
    public TextMeshProUGUI dexterityText;
    public TextMeshProUGUI lightText;
    public TextMeshProUGUI darkText;

    [Header("Base Stats")]
    public int baseHealth;
    public int baseStrength;
    public int baseDexterity;
    public int baseLight;
    public int baseDark;

    private void Start()
    {
        SetUIValues();
    }


    void SetUIValues()
    {
        //getting all the variables set
        baseHealth = PlayerPrefs.GetInt("Health");
        baseStrength = PlayerPrefs.GetInt("Strength");
        baseDexterity = PlayerPrefs.GetInt("Dexterity");
        baseLight = PlayerPrefs.GetInt("Light");
        baseDark = PlayerPrefs.GetInt("Dark");

        //setting the ui text stats
        healthText.text = baseHealth.ToString();
        strengthText.text = baseStrength.ToString();
        dexterityText.text = baseDexterity.ToString();
        lightText.text = baseLight.ToString();
        darkText.text = baseDark.ToString();

        // more info
        nameText.text = PlayerPrefs.GetString("playerName");
        classNameText.text = PlayerPrefs.GetString("className");
    }
}
