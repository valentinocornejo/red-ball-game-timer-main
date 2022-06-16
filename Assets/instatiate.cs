using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instatiate : MonoBehaviour
{
    public GameObject originalObject1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
   
    public void InstantiateObject1()
    {
        Instantiate(originalObject1);
    }
    void OnCollisionEnter(Collision choque)
    {
        if (choque.gameObject1.name == "Sphere")
        {
            InstantiateObject1();
        }
    }
}
