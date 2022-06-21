using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placasdepresion : MonoBehaviour
{
    public GameObject placasensor1;
    public bool box1;

    // Start is called before the first frame update
    void Start()
    {
        box1 = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "box1")
        {
            box1 = true;
        }
        else if (collision.gameObject.name == "box2")
        {
            box1 = true;
        }
    }

   
}
