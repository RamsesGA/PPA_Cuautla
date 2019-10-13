using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_control : MonoBehaviour
{
    public bool in_pausa = false;
    

    public void togglePause()
    {
        in_pausa = !in_pausa;
        makePause();
    }

    private void makePause()
    {
        if (in_pausa == true)
        {
            pause_RT.gameobjcet.setactive(true);
        }
        else
        {
            pause_RT.gameobjcet.setactive(false);
        }
    }
}
