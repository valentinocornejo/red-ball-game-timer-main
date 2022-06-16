using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class vidas : MonoBehaviour
{
    public Text ContadorVidas;
    public float vidasiniciales = 3;
    public float actualvida;

    public bool inmortal = false;
    public float tiempoInmortal = 1.0f;


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
        if (inmortal) return;
        actualvida -=restarvida;
        StartCoroutine(TiempoInmortal());
    }

    public void Muerte()
    {
        Destroy(this.gameObject);
    }

    IEnumerator TiempoInmortal()
    {
        inmortal = true;
        yield return new WaitForSeconds(1);
        inmortal = false;
    }
  


}
