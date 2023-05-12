using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Localization.Settings;


public class ChangeLocale : MonoBehaviour
{
    public Sprite plS, engS;
    public GameObject lanButton;
    private bool pl = true;
    string sceneName;
    private void Awake()
    {
        Scene currentScene = SceneManager.GetActiveScene();
         sceneName = currentScene.name;
        StartCoroutine(WaitForStart());
    }
    public void ChangeIt()
    {
      
        if (pl)
        {
            StartCoroutine(Change(0));
            pl = false;
            if (sceneName == "Menu")
            {
            lanButton.GetComponent<Image>().sprite = engS;
            }
        }
        else
        {
            StartCoroutine(Change(1));
            pl = true;
            if (sceneName == "Menu")
            {
                lanButton.GetComponent<Image>().sprite = plS;
            }
        }
    }

    IEnumerator WaitForStart()
    {
        yield return LocalizationSettings.InitializationOperation;
        if (PlayerPrefs.GetInt("lang", 0) == 1)
        {
            StartCoroutine(Change(1));
            pl = true;
             if (sceneName == "Menu")
            {
            lanButton.GetComponent<Image>().sprite = plS;
            }
        }
        else
        {
            StartCoroutine(Change(0));
            pl = false;
            if (sceneName == "Menu")
            {
                lanButton.GetComponent<Image>().sprite = engS;
            }
        }
    }

    IEnumerator Change(int localeID)
    {
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localeID];
        PlayerPrefs.SetInt("lang", localeID);
    }
}
