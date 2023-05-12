using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddStamina : MonoBehaviour
{
    public GameVariables GV;
    public Slider SD;
    public GameObject santa;
    AudioSource AS;
    private void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
        SD = GameObject.Find("Stamina").GetComponent<Slider>();
        santa = GameObject.Find("Santa");
        AS = santa.GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Santa"))
        {
            AS.Play();
            GV.ReindStam = GV.MaxStam;
            SD.value = GV.MaxStam;
            Destroy(gameObject);
        }
    }
    private void Update()
    {
        transform.position += Vector3.left * 3 * Time.deltaTime*GV.gameSpeed;
    }
}