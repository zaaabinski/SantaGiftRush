using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatchCoins : MonoBehaviour
{
    public GameVariables GV;
    public AudioSource AS;
    SnowballMove SM;
    void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Coin1"))
        {
            GV.coins += 1;
            PlayerPrefs.SetInt("Coins", GV.coins);
            Destroy(collision.gameObject);
            AS.Play();
        }
        if (collision.gameObject.CompareTag("Coin3"))
        {
            GV.coins += 3;
            PlayerPrefs.SetInt("Coins", GV.coins);
            Destroy(collision.gameObject);
            AS.Play();
        }
        if (collision.gameObject.CompareTag("Coin5"))
        {
            GV.coins += 5;
            PlayerPrefs.SetInt("Coins", GV.coins);
            Destroy(collision.gameObject);
            AS.Play();
        }
        if(collision.gameObject.CompareTag("Snowball"))
        {
            SM = collision.GetComponent<SnowballMove>();
            SM.moveSpeed = 0;
            GV.SlaysHit++;
            Collider2D CCC = collision.GetComponent<CircleCollider2D>();
            CCC.enabled = false;
            Destroy(collision.gameObject,0.5f);
        }
    }
}
