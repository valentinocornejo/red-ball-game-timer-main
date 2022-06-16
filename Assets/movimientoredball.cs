using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movimientoredball : MonoBehaviour
{
    public float jumpheight = 5.0f;
    public bool salto;
    public bool hit;
    private Rigidbody rb;
    public bool muerte;
   
    public float launchForce;






    public Text ContadorVidas;
    public float vidasiniciales = 3;
    public float actualvida;

    public bool inmortal = false;
    public float tiempoInmortal = 1.0f;




    void Start()
    {
        muerte = false;
        salto = false;
        rb = GetComponent<Rigidbody>();


        actualvida = vidasiniciales;

    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(-0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0.1f, 0, 0);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(0, 0, -0.1f);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(0, 0, 0.1f);
        }

      

        if(transform.position.y <= -2)
        {
            transform.position = new Vector3(20, 1, 0);
        }

        if (salto == true)
        {
         
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.velocity = Vector3.up * jumpheight;
                salto = false;
            }

            
        }




        if (actualvida > vidasiniciales)
        {
            actualvida = vidasiniciales;
        }
        if (actualvida <= 0)
        {
            Muerte();
            muerte = true;
            if(muerte == true)
            {
                SceneManager.LoadScene("Pantalladeinicio");
            }
        }

        ContadorVidas.text = actualvida.ToString();

    }
    void OnCollisionStay(Collision Col)
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = Vector3.up * jumpheight;

        }
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Piso")
        {
            salto = true;
        }



        if (collision.gameObject.name == "spike")
        {
            transform.position = new Vector3(20, 1, 0);

        }
        if (collision.gameObject.name == "spike2")
        {
            transform.position = new Vector3(20, 1, 0);
            actualvida -= 1;
        }
        if (collision.gameObject.name == "spike3")
        {
            transform.position = new Vector3(20, 1, 0);
        }
        if (collision.gameObject.name == "spike4")
        {
            transform.position = new Vector3(20, 1, 0);
        }
        if (collision.gameObject.name == "spike5")
        {
            transform.position = new Vector3(20, 1, 0);
        }
        if (collision.gameObject.name == "spike6")
        {
            transform.position = new Vector3(20, 1, 0);
        }

        if(collision.gameObject.CompareTag("Trampolin"))
        {
            rb.velocity = Vector3.up * launchForce;
        }

    }




    public void QuitarVida(float restarvida)
    {
        if (inmortal) return;
        actualvida -= restarvida;
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
