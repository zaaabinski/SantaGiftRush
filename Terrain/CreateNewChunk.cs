using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateNewChunk : MonoBehaviour
{
    public GameObject terrain;
    public CreateEnv CE;
    public int i=0;
    private void Start()
    {
        StartCoroutine(returnTerrain());
    }


    IEnumerator returnTerrain()
    {
        GameObject terainPref = Instantiate(terrain);
        yield return new WaitForSeconds(0.25f);
        if(i==0)
        {
        terainPref.transform.position = new Vector2(terainPref.transform.position.x - 22, terainPref.transform.position.y);
            i++;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Terrain"))
        {
            StartCoroutine(returnTerrain());
        }
    }

}
