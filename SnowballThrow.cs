using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballThrow : MonoBehaviour
{
    public GameObject TP;
    public GameObject snowball;
    bool hasThrown = false; 
    public bool inframe = false;
    int count = 0;
    private void Update()
    {
        if((!hasThrown)&&(inframe)&&count<1)
        {
            StartCoroutine(Throw());
        }
    }
    IEnumerator Throw()
    {
        hasThrown = true;
        GameObject newBall = Instantiate(snowball);
       // newBall.transform.parent = gameObject.transform;
        newBall.transform.position = new Vector2(TP.transform.position.x, TP.transform.position.y);
        count++;
        yield return new WaitForSeconds(3.5f);
        hasThrown = false;
    }
}
