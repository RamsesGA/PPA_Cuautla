using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour {

    RectTransform m_RectTransform;
    float  m_YAxis = -1038.0f;

    // Start is called before the first frame update
    void Start() {

        m_RectTransform = GetComponent<RectTransform>();
        //Initiate the y position

        

    }

    void Update() {

        m_RectTransform.anchoredPosition = new Vector2(0, m_YAxis);
        m_YAxis += 0.7f;
        if (m_YAxis == 1000.0f) {
            //Salir de la escena

        }
    }
}
