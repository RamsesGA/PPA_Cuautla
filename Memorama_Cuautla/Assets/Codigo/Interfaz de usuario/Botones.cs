using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Botones : MonoBehaviour {

    public void Salir() {

        Application.Quit();

    }

    public void Jugar(string SceneName) {

        SceneManager.LoadScene(2);

    }
 
}
