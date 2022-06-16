using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiodeEscena : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Load()
    {
      
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
        {
            SceneManager.LoadScene("Pantalladeinicio");
        }
        

    }
}
