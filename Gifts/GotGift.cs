using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotGift : MonoBehaviour
{
    public GameObject cookie;
    public GameVariables GV;
    private void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Gift"))
        {
                cookie.SetActive(false);
                GV.score += 10+GV.GiftsScore;
                Destroy(other.gameObject);


            int coin = PlayerPrefs.GetInt("Coins",0);
            coin += 1 + GV.GiftMult;
            PlayerPrefs.SetInt("Coins", coin);
            GV.coins += 1 + GV.GiftMult;
            GV.GiftsIn += 1;
        }
    }
}
