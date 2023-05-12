using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundScript : MonoBehaviour
{
    public GameObject musicButton;
    public Sprite on,off;
    private void Start()
    {
        AudioListener.volume = PlayerPrefs.GetInt("Sounds", 1);
        if (AudioListener.volume == 1)
        {
            musicButton.GetComponent<Image>().sprite = on;
        }
        else if (AudioListener.volume == 0)
        {
            musicButton.GetComponent<Image>().sprite = off;
        }
    }

    public void ChangeMusic()
    {
        if(AudioListener.volume == 1)
        {
            AudioListener.volume =0;
            musicButton.GetComponent<Image>().sprite = off;
            PlayerPrefs.SetInt("Sounds", 0);
        }
        else if (AudioListener.volume == 0)
        {
            AudioListener.volume = 1;
            musicButton.GetComponent<Image>().sprite = on;
            PlayerPrefs.SetInt("Sounds", 1);
        }
    }    

}
