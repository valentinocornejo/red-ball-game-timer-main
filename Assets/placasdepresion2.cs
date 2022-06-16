using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placasdepresion2 : MonoBehaviour
{
    public GameObject placapresion2;
    public int box2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "box1")
        {
            box2 += 1;
        }
        if (collision.gameObject.name == "box2")
        {
            box2 += 1;
        }
    }
}
