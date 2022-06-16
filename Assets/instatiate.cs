using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instatiate : MonoBehaviour
{
    public GameObject originalObject;

    public bool toco;

    // Start is called before the first frame update
    void Start()
    {
        toco = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (toco)
        {
            for (int i = 0; i < 5; i++)
            {
                Instantiate(originalObject);
            }
        }
    }
   
   
    void OnCollisionEnter(Collision choque)
    {
        if (choque.gameObject.name == "Sphere")
        {
            toco = true;
        }
    }
}
