using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class c_Time : MonoBehaviour
{

    //Variables
    public Text mostrar_tiempo;         //objeto tipo texto del canvas que mostrara el tiempo restante en pantalla

    private float cronometro;
    
    
    // Start is called before the first frame update
    void Start()
    {
        cronometro = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //Variables

        float control_tiempo = Time.time - cronometro;
        string min = ((int)control_tiempo / 60).ToString("00");
        string seg = (control_tiempo % 60).ToString("00");
        string mili_seg = ((control_tiempo * 100) % 100).ToString("00");
        
        

        string string_tiempo = string.Format("{00}:{01}:{02}", min, seg, mili_seg);

        GetComponent<Text>().text = string_tiempo.ToString();
    }
}
