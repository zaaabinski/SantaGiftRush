using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallWhenColided : MonoBehaviour
{
    CircleCollider2D m_Collider;
    bool hit = false;
    public Animator anim;
    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        m_Collider = GetComponent<CircleCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        /*if (collision.gameObject.CompareTag("Santa")) ;
        {
            Debug.Log("Its santa");
        }*/
        //when hit change sprite to destroyed
        if (collision.gameObject.CompareTag("Terrain"))
        {
            hit = true;
        }
        else
        {
        hit = true;
        }
    }
    private void Update()
    {
        if (hit == true)
        {
            StartCoroutine("disable");
        }
    }
    IEnumerator disable()
    {
        hit = false;
        m_Collider.enabled = false;
        anim.SetTrigger("Break");
        yield return new WaitForSeconds(0.75f);
    }

}
