using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class placasdepresion : MonoBehaviour
{
    public GameObject muro;
    public int box = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(box == 2)
        {
            Muerte();
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "box1")
        {
            box += 1;
        }
        if (collision.gameObject.name == "box2")
        {
            box += 1;
        }
    }

    public void Muerte()
    {
        Destroy(this.gameObject);
    }
}
