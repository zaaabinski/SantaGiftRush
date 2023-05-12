using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SantaHit : MonoBehaviour
{
    public GameVariables GV;
    public GameObject UiLooks;
    public GameObject buttonsUi;
    public Santa st;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Santa") || collision.gameObject.CompareTag("Gift") || collision.gameObject.CompareTag("Cloud"))
        {
        }
        if(collision.gameObject.CompareTag("Terrain")|| collision.gameObject.CompareTag("House"))
        {
            GV.SlaysHit = GV.SlaysLv;
        }
        if (collision.gameObject.CompareTag("Bird"))
        {
            GV.SlaysHit++;
            Destroy(collision.gameObject);
        }

        
    }
    private void Update()
    {
        if (GV.SlaysHit >= GV.SlaysLv)
        {

            GV.gameSpeed=0;
            UiLooks.SetActive(false);
            buttonsUi.SetActive(false);
            st.MoveStopD();
            GV.GameOver = true;
            // SceneManager.LoadScene("Menu");
        }
    }
}
