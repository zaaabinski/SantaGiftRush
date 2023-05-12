using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public GameVariables GV;
    public int birdSpeed = 0;
    //[SerializeField] Animator anim;
    private void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
    }
    private void Awake()
    {
        birdSpeed = 0;
    }
    void Update()
    {
        transform.position += Vector3.left * birdSpeed * Time.deltaTime * GV.gameSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Santa"))
        {
           // anim.SetTrigger("Hit");
            GV.SlaysHit++;
            Destroy(gameObject);
        }
    }
}
