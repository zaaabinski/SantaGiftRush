using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudScript : MonoBehaviour
{
    public GameVariables GV;
    public Stamina Stam;
    public SpriteRenderer SR;
    private void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
        Stam = GameObject.Find("Santa").GetComponent<Stamina>();
        SR = GameObject.Find("VisionBlock").GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Vision"))
        {

            SR.enabled = true;
        }
        if(collision.gameObject.CompareTag("Nose"))
        {
            Stam.drain *= 2;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Vision"))
        {
            SR.enabled = false;
        }
        if (collision.gameObject.CompareTag("Nose"))
        {
            Stam.drain /= 2;
        }
    }
    void Update()
    {
       transform.position += Vector3.right *2 * Time.deltaTime;
    }
}
