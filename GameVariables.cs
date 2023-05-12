using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class GameVariables : MonoBehaviour
{
    //game speed
    public float gameSpeed = 1;
    bool adding = false;
    public int terrainCount = 0;
    public Santa santaScript;
    // santa upgrades
    public int SantaDrop = 3;
    public int SantaLv = 1;

    // Slays upgrades
    public int SlaysHit;
    public int SlaysLv = 1;

    // gifts upgrades
    public int GiftsScore;
    public int GiftsLv = 1;
    public int GiftMult = 1;
    

    // reind upgrades
    public int ReindStam;
    public int ReindLv = 1;
    public int MaxStam = 30;
    public Slider SD;
    public Animator reindAnim;
    public bool GameOver = false;
    public GameObject End;
    public GameObject Darker;

    public int GiftsIn = 0;
    public int score;
    public int coins;
    public int meters;
    public int Highscore;
    public TMP_Text endScore, endMeters, endGifts, HS;

    
    public TMP_Text coinsText;

    bool passed = true; bool done;
    public int minutes = 0;
    private void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
        ReindLv = PlayerPrefs.GetInt("Reind", 1);
        SlaysLv = PlayerPrefs.GetInt("Slays", 1);
        SantaLv = PlayerPrefs.GetInt("Santa", 1);
        GiftsLv = PlayerPrefs.GetInt("Gifts",1);

        GiftMult = (GiftsLv - 1)/2;
        GiftsScore = GiftsLv-1;

        if (ReindLv == 1)
        {
            ReindStam = 30;
            MaxStam = 30;
            SD.maxValue = 30;
            SD.minValue = 0;
            SD.value = 30 ;
        }
        else if (ReindLv == 2)
        {
            ReindStam = 45;
            MaxStam = 45;
            SD.maxValue = 45;
            SD.minValue = 0;
            SD.value = 45;
        }
        else if (ReindLv == 3)
        {
            ReindStam = 60;
            MaxStam = 60;
            SD.maxValue = 60;
            SD.minValue = 0;
            SD.value = 60;
        }

        if(SantaLv==1)
        {
            santaScript.moveSpeed = 4;
        }
        else if(SantaLv==2)
        {
            santaScript.moveSpeed = 5;
        }
        else if (SantaLv == 3)
        {
            santaScript.moveSpeed = 6;
        }
        else if (SantaLv == 4)
        {
            santaScript.moveSpeed = 7;
        }
    }



    private void Update()
    {
        if ((gameSpeed < 2) && (!adding))
        {
            StartCoroutine(IncreaseGameSpeed());
        }
        if((GameOver)&&(!done))
        {
            reindAnim.gameObject.GetComponent<Animator>().enabled = false;
             done = true;
             End.SetActive(true);
            Darker.SetActive(true);
           
             /*string scoreSt = "Score : ", MetersSt = "Meters traveled : ", giftSt = "Gifts delivered : ";
             //endScore.text = scoreSt + score.ToString();
             endMeters.text = MetersSt + meters.ToString();
             endGifts.text = giftSt + GiftsIn.ToString();*/

            Highscore = PlayerPrefs.GetInt("HScore", 0);
            if(Highscore >= score)
            {
                HS.text = "Highscore : " + Highscore.ToString();
            }
            else
            {
                HS.text = "New Highscore : " + score.ToString();
                PlayerPrefs.SetInt("HScore", score);
            }
            

        }
        coinsText.text = coins.ToString();
        if (passed == true)
        {
            StartCoroutine(CountMinutes());
        }
    }
    IEnumerator IncreaseGameSpeed()
    {
        adding = true;
        yield return new WaitForSeconds(1);
        gameSpeed += 0.003f;
        adding = false;
    }

    IEnumerator CountMinutes()
    {
        passed = false;
        yield return new WaitForSeconds(60);
        minutes++;
        passed = true;
    }
}
