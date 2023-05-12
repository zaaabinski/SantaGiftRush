using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{
    public float spd;
    public GameVariables GV;
    private void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * spd * Time.deltaTime * GV.gameSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("BG2"))
        {
            gameObject.transform.position = new Vector3(0, 10, 0);
        }
    }
}
