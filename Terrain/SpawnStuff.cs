using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStuff : MonoBehaviour
{
    public GameObject carrotPrefab;
    bool  spawned = false;
    public GameVariables GV;
    private void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
    }
    private void Update()
    {
         
        if(!spawned)
        {
            StartCoroutine(SpawnCarrots());
        }    
    }


    IEnumerator SpawnCarrots()
    {
        spawned = true;
        if(GV.minutes<=3)
        {
        yield return new WaitForSeconds(20);
          GameObject newCarrot =   Instantiate(carrotPrefab);
            newCarrot.transform.position = new Vector2(newCarrot.transform.position.x, Random.Range(2, 4));
            spawned = false;
        }
        else if(GV.minutes>= 3)
        {
            yield return new WaitForSeconds(35);
            GameObject newCarrot = Instantiate(carrotPrefab);
            newCarrot.transform.position = new Vector2(newCarrot.transform.position.x, Random.Range(2, 4));
            spawned = false;
        }
        else if (GV.minutes >= 5)
        {
            yield return new WaitForSeconds(50);
            GameObject newCarrot = Instantiate(carrotPrefab);
            newCarrot.transform.position = new Vector2(newCarrot.transform.position.x, Random.Range(2, 4));
            spawned = false;
        }
    }

}
