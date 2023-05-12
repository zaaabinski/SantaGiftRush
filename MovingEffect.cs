using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingEffect : MonoBehaviour
{

    public float lenght, startpos;
    public GameObject cam;
    public float parallaxEffect;
    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }
    void FixedUpdate()
    {
        float dist = (cam.transform.position.x * parallaxEffect);
        float temp = (cam.transform.position.x * (1 - parallaxEffect));

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (temp > startpos + lenght) startpos += lenght;
        else if (temp < startpos - lenght) startpos -= lenght;
    }
}
