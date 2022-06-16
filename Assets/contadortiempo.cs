using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class contadortiempo : MonoBehaviour
{
    public Text txtTime;
    public Text txtTimeFloored;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //txtTime.text = Time.time.ToString();
        txtTimeFloored.text = Mathf.FloorToInt(Time.time).ToString();
    }
}
