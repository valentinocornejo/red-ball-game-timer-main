using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class restlife : MonoBehaviour
{
    public float restarvida = 1; 


   
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<vidas>() != null)
        {
            other.gameObject.GetComponent<vidas>().QuitarVida(restarvida);
        }
    }
}
