using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameUi : MonoBehaviour
{
    public GameObject LosePanel, Ui, Buttons, PauseMenu,Darkener, OptionsMenu;
    public void PauseGame()
    {

        Buttons.SetActive(false);
        Darkener.SetActive(true);
        Time.timeScale = 0f;
        PauseMenu.SetActive(true);

    }
    public void UnPauseGame()
    {
        PauseMenu.SetActive(false);
        Darkener.SetActive(false);
        Time.timeScale = 1f;
        Buttons.SetActive(true);
    }
    public void RestartScene()
    {
        PauseMenu.SetActive(false);
        Darkener.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }
    public void Options()
    {
        Buttons.SetActive(false);
        Darkener.SetActive(true);
        Time.timeScale = 0f;
        OptionsMenu.SetActive(true);
    }
    public void UnOptions()
    {
        OptionsMenu.SetActive(false);
        Darkener.SetActive(false);
        Time.timeScale = 1f;
        Buttons.SetActive(true);
    }
}
