using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_control : MonoBehaviour {
    public static bool in_pausa = false;
    public GameObject pause_menu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (in_pausa)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pause_menu.SetActive(false);
        Time.timeScale = 1f;
        in_pausa = false;
    }

    void Pause()
    {
        pause_menu.SetActive(true);
        Time.timeScale = 0f;
        in_pausa = true;
    }

}
