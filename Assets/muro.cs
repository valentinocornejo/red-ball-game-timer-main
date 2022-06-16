using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muro : MonoBehaviour
{
    public GameObject pared;
    placasdepresion valor1;
    placasdepresion2 valor2;
    public int box1 = 0;
    public int box2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        box1 = valor1.box1;
        box2 = valor2.box2;
    }

    // Update is called once per frame
    void Update()
    {
        if(box1 >= 1 && box2 >= 1)
        {
            Destroy(this.gameObject);
        }
    }
}
