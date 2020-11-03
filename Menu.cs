using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    [Header("Screens")]
    public GameObject mainScreen;
    public GameObject newScreen;
    public GameObject settingsScreen;

    [Header("Buttons")]
    public TMP_Dropdown dropDownButton;
    public Button startButton;

    [Header("Info")]
    public TMP_InputField nameInput;
    public string playerNameInput = "";



    [Header("Stats Text")]
    public TextMeshProUGUI healthText;
    public TextMeshProUGUI strengthText;
    public TextMeshProUGUI dexterityText;
    public TextMeshProUGUI lightText;
    public TextMeshProUGUI darkText;

    private StatsList statsList;

    //private key varibales
    string healthKey = "Health";
    string strengthKey = "Strength";
    string dexterityKey = "Dexterity";
    string lighthKey = "Light";
    string darkKey = "Dark";
    string playerName = "playerName";
    string className = "className";


    public void Start()
    {
         statsList = new StatsList();
    }
    public void Update()
    {
        if (nameInput != null && dropDownButton.value != 0)
        {
            startButton.interactable = true;
        }
        else
            startButton.interactable = false;

        OnDroppdownChange();

    }


    public void OnStartButton()
    {
        playerNameInput = nameInput.text;
        PlayerPrefs.SetString(playerName, playerNameInput);

        SceneManager.LoadScene(1);
    }
    public void OnNewButton()
    {
        SetCorrectScreen(newScreen);
    }
    public void OnSettingButton()
    {
        SetCorrectScreen(settingsScreen);
    }
    public void OnBackButton()
    {
        SetCorrectScreen(mainScreen);
    }
    public void OnQuitButtonn()
    {
        Application.Quit();
        Debug.Log("Quit Game Button was pressed");
    }

    public void OnDroppdownChange()
    {
        if (dropDownButton.value == 0)
        {
            healthText.text = "0";
            strengthText.text = "0";
            dexterityText.text = "0";
            lightText.text = "0";
            darkText.text = "0";
        }
        if (dropDownButton.value == 1)
        {
            healthText.text = statsList.knight.health.ToString();
            strengthText.text = statsList.knight.strength.ToString();
            dexterityText.text = statsList.knight.dexterity.ToString();
            lightText.text = statsList.knight.light.ToString();
            darkText.text = statsList.knight.dark.ToString();

            PlayerPrefs.SetInt(healthKey, statsList.knight.health);
            PlayerPrefs.SetInt(strengthKey, statsList.knight.strength);
            PlayerPrefs.SetInt(dexterityKey, statsList.knight.dexterity);
            PlayerPrefs.SetInt(lighthKey, statsList.knight.light);
            PlayerPrefs.SetInt(darkKey, statsList.knight.dark);

            PlayerPrefs.SetString(className, statsList.knight.name);

        }
        if (dropDownButton.value == 2)
        {
            healthText.text = statsList.pirate.health.ToString();
            strengthText.text = statsList.pirate.strength.ToString();
            dexterityText.text = statsList.pirate.dexterity.ToString();
            lightText.text = statsList.pirate.light.ToString();
            darkText.text = statsList.pirate.dark.ToString();

            PlayerPrefs.SetInt(healthKey, statsList.pirate.health);
            PlayerPrefs.SetInt(strengthKey, statsList.pirate.strength);
            PlayerPrefs.SetInt(dexterityKey, statsList.pirate.dexterity);
            PlayerPrefs.SetInt(lighthKey, statsList.pirate.light);
            PlayerPrefs.SetInt(darkKey, statsList.pirate.dark);

            PlayerPrefs.SetString(className, statsList.pirate.name);
        }
        if (dropDownButton.value == 3)
        {
            healthText.text = statsList.sellsword.health.ToString();
            strengthText.text = statsList.sellsword.strength.ToString();
            dexterityText.text = statsList.sellsword.dexterity.ToString();
            lightText.text = statsList.sellsword.light.ToString();
            darkText.text = statsList.sellsword.dark.ToString();

            PlayerPrefs.SetInt(healthKey, statsList.sellsword.health);
            PlayerPrefs.SetInt(strengthKey, statsList.sellsword.strength);
            PlayerPrefs.SetInt(dexterityKey, statsList.sellsword.dexterity);
            PlayerPrefs.SetInt(lighthKey, statsList.sellsword.light);
            PlayerPrefs.SetInt(darkKey, statsList.sellsword.dark);

            PlayerPrefs.SetString(className, statsList.sellsword.name);
        }
        if (dropDownButton.value == 4)
        {
            healthText.text = statsList.darkMage.health.ToString();
            strengthText.text = statsList.darkMage.strength.ToString();
            dexterityText.text = statsList.darkMage.dexterity.ToString();
            lightText.text = statsList.darkMage.light.ToString();
            darkText.text = statsList.darkMage.dark.ToString();

            PlayerPrefs.SetInt(healthKey, statsList.darkMage.health);
            PlayerPrefs.SetInt(strengthKey, statsList.darkMage.strength);
            PlayerPrefs.SetInt(dexterityKey, statsList.darkMage.dexterity);
            PlayerPrefs.SetInt(lighthKey, statsList.darkMage.light);
            PlayerPrefs.SetInt(darkKey, statsList.darkMage.dark);

            PlayerPrefs.SetString(className, statsList.darkMage.name);
        }
    }

    public void SetCorrectScreen(GameObject screen)
    {
        mainScreen.SetActive(false);
        newScreen.SetActive(false);

        screen.SetActive(true);
    }

}
