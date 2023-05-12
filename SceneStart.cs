using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneStart : MonoBehaviour
{
    public Animator anim;
    public GameObject gift;
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName == "Menu")
        {
            gameObject.GetComponent<Image>().enabled = false;
        }
        else
        anim.SetTrigger("NewScene");
    }
    private void Update()
    {
        if(anim.GetCurrentAnimatorStateInfo(0).normalizedTime > 1)
        {
            gameObject.GetComponent<Image>().enabled = true;
            gameObject.SetActive(false);
            //anim.SetTrigger("back");
        }
    }
}
