using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainMove : MonoBehaviour
{
    public int spd;
    public GameVariables GV;
    private void Start()
    {
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
        if (GV.terrainCount == 0)
        {
            StartCoroutine(StartUp());
        }
    }
    void Update()
    {
        transform.position += Vector3.left * spd * Time.deltaTime * GV.gameSpeed;
    }

    IEnumerator StartUp()
    {
        yield return new WaitForSeconds(0.5f);
            spd = 3;
            GV.terrainCount++;
    }

}
