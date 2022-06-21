using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placasdepresion2 : MonoBehaviour
{
    public GameObject placasensor2;
    public bool box2;
    // Start is called before the first frame update
    void Start()
    {
        box2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "box1")
        {
            box2 = true;
        }
        if (collision.gameObject.name == "box2")
        {
            box2 = true;
        }
    }
}
