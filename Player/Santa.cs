using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Santa : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;
    public GameVariables GV;
    public Animator anim;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GV = GameObject.Find("GameControll").GetComponent<GameVariables>();
    }
    private void Update()
    {
        transform.eulerAngles = new Vector3(0, 0, rb.velocity.y * 1f);
        if (rb.position.y > 5f)
        {
            rb.position = new Vector2(gameObject.transform.position.x, 5f);
        }
    }
    public void MoveUP()
    {
            anim.SetTrigger("Up");
            rb.velocity = Vector2.up * moveSpeed;
    }
    public void MoveDown()
    {
        anim.SetTrigger("Down");
        rb.velocity = Vector2.down * moveSpeed;

    }
    public void MoveStopU()
    {
        rb.velocity = Vector2.zero;
        anim.SetTrigger("StopU");
    }
    public void MoveStopD()
    {
        rb.velocity = Vector2.zero;
        anim.SetTrigger("StopD");
    }
}
