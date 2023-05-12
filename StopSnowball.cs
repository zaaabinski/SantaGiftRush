using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopSnowball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                Ray ray;
                RaycastHit hit;
                ray = Camera.main.ScreenPointToRay(touch.position);
                if (Physics.Raycast(ray, out hit, Mathf.Infinity))
                {
                    if (hit.transform.gameObject.CompareTag("Snowball"))
                    {
                        Destroy(gameObject);
                        Debug.Log("Stoped");
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
