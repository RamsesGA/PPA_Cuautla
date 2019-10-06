using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Transiciones_escena : MonoBehaviour
{
    public Animator transition_Anim;
    public string scene_name;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(LoadScene());
        }
    }

    IEnumerator LoadScene()
    {
        transition_Anim.SetTrigger("Fin");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(scene_name);
    }
}
