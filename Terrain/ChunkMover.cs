using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkMover : MonoBehaviour
{
    private void OnCollisionExit2D(Collision2D collision)
    {
            Debug.Log("out");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("out");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("in");
    }
}

