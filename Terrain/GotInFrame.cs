using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotInFrame : MonoBehaviour
{
    BirdScript BS;
    public GameObject warning;
    public GameObject birdOBJ;
    SnowballThrow ST;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bird"))
        {
            BS = collision.gameObject.GetComponent<BirdScript>();
            BS.birdSpeed = 3;
        }
        if (collision.gameObject.CompareTag("Warning"))
        {
            birdOBJ = collision.gameObject;
            warning.SetActive(true);
            warning.transform.position = new Vector2(warning.transform.position.x, birdOBJ.transform.position.y);
            Destroy(collision.gameObject);
        }
        if(collision.gameObject.CompareTag("Snowman"))
        {
            ST = collision.gameObject.GetComponent<SnowballThrow>();
            ST.inframe = true;
        }
    }
}
