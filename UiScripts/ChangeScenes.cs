using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{
    public Animator anim;
    public GameObject canvas;
    public GameObject canvasLose;
    public GameObject pausePanel;
    public GameObject gift;
    public void Start()
    {
        gift.SetActive(true);
    }
    public void StartGame()
    {
        StartCoroutine(Starting());
    }
    public void GoShop()
    {
        StartCoroutine(Shoping());
    }
    public void GoMenu()
    {
        StartCoroutine(Menuing());
    }
    public void QuitApp()
    {
        Application.Quit();
    }
    public IEnumerator Starting()
    {
        gift.GetComponent<Image>().enabled = true;
        canvas.SetActive(false);
        gift.SetActive(true);
        anim.SetTrigger("SwapStart");
        yield return new WaitForSecondsRealtime(1.1f);
        SceneManager.LoadScene("Game");
    }
    public IEnumerator Shoping()
    {
        gift.GetComponent<Image>().enabled = true;
        canvas.SetActive(false);
        gift.SetActive(true);
        anim.SetTrigger("SwapStart");
        yield return new WaitForSecondsRealtime(1.1f);
        SceneManager.LoadScene("Shop");
    }
    public IEnumerator Menuing()
    {
        gift.GetComponent<Image>().enabled = true;
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;
        gift.SetActive(true);
        anim.SetTrigger("SwapStart");
        if (sceneName == "Game")
        {
            canvasLose.SetActive(false);
            pausePanel.SetActive(false);
            canvas.SetActive(false);

            yield return new WaitForSecondsRealtime(1.1f);
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menu");
        }
        else
        {
            canvas.SetActive(false);
            yield return new WaitForSecondsRealtime(1.1f);
            Time.timeScale = 1f;
            SceneManager.LoadScene("Menu");
        }

    }
}
