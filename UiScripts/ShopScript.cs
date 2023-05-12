using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;



public class ShopScript : MonoBehaviour
{
    public int coins = 10, slays, santa, reind, gifts;
    public TMP_Text coinsText;
    public TMP_Text slaysText;
    public TMP_Text santaText;
    public TMP_Text reindText;
    public TMP_Text giftsText;

    public TMP_Text santaPriceText;
    public TMP_Text slaysPriceText;
    public TMP_Text reindPriceText;
    public TMP_Text giftsPriceText;
    int  santaPrice, slaysPrice, reindPrice, giftPrice;
    public GameObject  santaPriceGo, slaysPriceGo, reindPriceGo, giftPriceGo;
    public GameObject sUP, slayUP, rUP, gUP, adUp;
    public AudioSource buy;
    public AudioSource buttonAS;
    public void SlaysUp()
    {
        if ((coins >= slaysPrice) && (slays == 1))
        {
            slays = 2;
            PlayerPrefs.SetInt("Slays", slays);
            coins -= 400;
            PlayerPrefs.SetInt("Coins", coins);
            slaysText.text = "Lv 2";
            slaysPrice = 600;
            buy.Play();
            Close();
        }
        else if ((coins >= slaysPrice) && (slays == 2))
        {
            slays = 3;
            PlayerPrefs.SetInt("Slays", slays);
            coins -= 600;
            PlayerPrefs.SetInt("Coins", coins);
            slaysText.text = "Lv 3 MAX";
            buy.Play();
            Close();
        }
        else
        {
            adUp.SetActive(true);
        }
    }
    public void SantaUp()
    {
        if ((coins >= santaPrice) && (santa == 1))
        {
            santa = 2;
            PlayerPrefs.SetInt("Santa", santa);
            coins -= 100;
            PlayerPrefs.SetInt("Coins", coins);
            santaText.text = "Lv 2";
            santaPrice = 200;
            buy.Play();
            Close();
        }
        else if ((coins >= santaPrice) && (santa == 2))
        {
            santa = 3;
            PlayerPrefs.SetInt("Santa", santa);
            coins -= 200;
            PlayerPrefs.SetInt("Coins", coins);
            santaText.text = "Lv 3";
            santaPrice = 300;
            buy.Play();
            Close();
        }
        else if ((coins >= santaPrice) && (santa == 3))
        {
            santa = 4;
            PlayerPrefs.SetInt("Santa", santa);
            coins -= 300;
            PlayerPrefs.SetInt("Coins", coins);
            santaText.text = "Lv 4 MAX";
            santaPriceGo.SetActive(false);
            buy.Play();
            Close();
        }
        else
        {
            adUp.SetActive(true);
        }
    }
    public void ReindUp()
    {
        if ((coins >= reindPrice) && (reind == 1))
        {
            reind = 2;
            PlayerPrefs.SetInt("Reind", reind);
            coins -= 200;
            PlayerPrefs.SetInt("Coins", coins);
            reindText.text = "Lv 2";
            reindPrice = 500;
            buy.Play();
            Close();
        }
        else if ((coins >= reindPrice) && (reind == 2))
        {
            reind = 3;
            PlayerPrefs.SetInt("Reind", reind);
            coins -= 500;
            PlayerPrefs.SetInt("Coins", coins);
            reindText.text = "Lv 3 MAX";
            reindPriceGo.SetActive(false);
            buy.Play();
            Close();
        }
        else
        {
            adUp.SetActive(true);
        }
    }
    public void GiftsUp()
    {
        if(coins>= giftPrice)
        {
        coins -= 99 + gifts;
        PlayerPrefs.SetInt("Coins", coins);
            gifts++;
            giftPrice++;
        giftsText.text = "Lv " + gifts;
        PlayerPrefs.SetInt("Gifts", gifts+1);
            buy.Play();
        Close();
        }
        else
        {
            adUp.SetActive(true);
        }
    }
    public void Start()
    {
        coins = PlayerPrefs.GetInt("Coins", 0);
        slays = PlayerPrefs.GetInt("Slays", 1);
        santa = PlayerPrefs.GetInt("Santa", 1);
        reind = PlayerPrefs.GetInt("Reind", 1);
        gifts = PlayerPrefs.GetInt("Gifts", 1);
        //setting gifts price
        giftsText.text = "Lv " + gifts;
        giftPrice = 99 + gifts;
        //seting slays text
        if (slays == 1)
        {
            slaysPrice = 400;
            slaysText.text = "Lv 1";
        }
        if (slays == 2)
        {
            slaysPrice = 600;
            slaysText.text = "Lv 2";
        }
        if (slays == 3)
        {
            slaysText.text = "Lv 3 MAX";
            slaysPriceGo.SetActive(false);

        }
        //seting santa text 
        if (santa == 1)
        {
            santaText.text = "Lv 1";
            santaPrice = 100;
        }
        if (santa == 2)
        {
            santaText.text = "Lv 2";
            santaPrice = 200;
        }
        if (santa == 3)
        {
            santaText.text = "Lv 3";
            santaPrice = 300;
        }
        if (santa == 4)
        {
            santaText.text = "Lv 4 MAX";
            santaPriceGo.SetActive(false);

        }
        //seting reind text
        if (reind == 1)
        {
            reindText.text = "Lv 1";
            reindPrice = 200;
        }
        if (reind == 2)
        {
            reindText.text = "Lv 2";
            reindPrice = 500;
        }
        if (reind == 3)
        {
            reindText.text = "Lv 3 MAX";
            reindPriceGo.SetActive(false);

        }
       
    }

    private void Update()
    {
        coinsText.text = coins.ToString();
        slaysPriceText.text = slaysPrice.ToString();
        santaPriceText.text = santaPrice.ToString();
        reindPriceText.text = reindPrice.ToString();
        giftsPriceText.text = giftPrice.ToString();
        // slaysPriceText.text = slaysPrice.ToString();
    }

    public void ShowSanta()
    {
        buttonAS.Play();
        sUP.SetActive(true);
    }
    public void ShowSlays()
    {
        buttonAS.Play();
        slayUP.SetActive(true);
    }
    public void ShowReind()
    {
        buttonAS.Play();
        rUP.SetActive(true);
    }
    public void ShowGift()
    {
        buttonAS.Play();
        gUP.SetActive(true);
    }


    public void Close()
    {
        buttonAS.Play();
        sUP.SetActive(false);
        rUP.SetActive(false);
        gUP.SetActive(false);
        slayUP.SetActive(false);
        adUp.SetActive(false);
    }

}
