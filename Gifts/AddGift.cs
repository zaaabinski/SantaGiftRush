/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddGift : MonoBehaviour
{
    public GameVariables GV;
    public SpawnGift SG;
    private void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
        SG = GameObject.Find("GiftSpawn").GetComponent<SpawnGift>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Santa"))
        {
            Debug.Log("Its santa");
            if(SG.Capacity < GV.SackCap)
            {
                SG.Capacity++;
                Destroy(gameObject);
            }
        }
        Debug.Log("asdas");
    }
    private void Update()
    {
        transform.position += Vector3.left * 4 * Time.deltaTime;
    }
}*/
