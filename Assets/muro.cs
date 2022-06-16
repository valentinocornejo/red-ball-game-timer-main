using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muro : MonoBehaviour
{
    public GameObject pared;
    public placasdepresion valor1;
    public placasdepresion2 valor2;
    public bool primerbox1;
    public bool primerbox2;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        primerbox1 = valor1.box1;
        primerbox2 = valor2.box2;
        if (primerbox1 == true && primerbox2 == true)
        {
            Destroy(this.gameObject);
        }
    }
}
