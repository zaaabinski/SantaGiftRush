using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWarningOff : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Bird"))
        {
            gameObject.SetActive(false);
        }
    }
}
