using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMovingTerrain : MonoBehaviour
{
    public TerrainMove TM;
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Terrain"))
        {
            Debug.Log("out");
            TM = collision.gameObject.GetComponent<TerrainMove>();
            TM.spd = 3;
        }
    }
}
