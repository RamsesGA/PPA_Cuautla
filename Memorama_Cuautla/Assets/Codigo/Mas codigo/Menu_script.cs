using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_script : MonoBehaviour {
    public void cambio_escena(string _nombre_escena) {
        SceneManager.LoadScene(_nombre_escena); //Application.LoadLevel(_nombre_escena);
    }
}
