using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class c_carta : MonoBehaviour {

    [SerializeField]
    public GameObject Carta;


    public void OnMouseDown()
    {

        if (Carta.activeSelf)
        {

            Carta.SetActive(false);

        }

    }

}
