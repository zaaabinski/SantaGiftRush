using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    Rigidbody2D rb;
    ParticleSystem PS;
    Vector2 moveDirection;
    GameObject santaTarget;

    private void Start()
    {
        StartCoroutine(Fly());
        PS = GetComponentInChildren<ParticleSystem>();
    }

    IEnumerator Fly()
    {
        yield return new WaitForSeconds(0.2f);
        rb = GetComponent<Rigidbody2D>();
        santaTarget = GameObject.Find("Santa");
        moveDirection = (santaTarget.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 10f);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("Santa"))
        {
            PS.Play();
        }
    }
}
