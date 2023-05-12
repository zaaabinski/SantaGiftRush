using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnGift : MonoBehaviour
{
    public GameObject gift;
    public GameObject spawn;
    public AudioSource AS;
    public float timeBDrops;
    bool canDrop = true;

    public GameVariables GV;
    private void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
        timeBDrops = GV.SantaDrop;
    }
    public void Drop()
    {
        if (canDrop)
        {
            StartCoroutine(DropGift());
        }
    }

    IEnumerator DropGift()
    {
        AS.Play();
            canDrop = false;
            GameObject GiftPref = Instantiate(gift);
            GiftPref.transform.position = spawn.transform.position;
            Destroy(GiftPref, 5);
            yield return new WaitForSeconds(timeBDrops);
            canDrop = true;
    }


}
