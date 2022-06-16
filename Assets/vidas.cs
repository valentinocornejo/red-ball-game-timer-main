using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class vidas : MonoBehaviour
{
    public Text ContadorVidas;
    public float vidasiniciales = 3;
    public float actualvida;
    

    private void Update()
    {
        if(actualvida > vidasiniciales)
        {
            actualvida = vidasiniciales;
        }
        if(actualvida <= 0)
        {
            Muerte();
        }

        ContadorVidas.text = actualvida.ToString();

       
    }

    private void Start()

    {
        actualvida = vidasiniciales;
    }

    public void QuitarVida(float restarvida)
    {
        actualvida -=restarvida;
    }

    public void Muerte()
    {
        Destroy(this.gameObject);
    }

   


}
