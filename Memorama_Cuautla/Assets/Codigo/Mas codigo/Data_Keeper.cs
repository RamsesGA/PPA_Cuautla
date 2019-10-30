using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data_Keeper : MonoBehaviour
{
    public int level;
    public int number_of_cards;
    public bool main_screen;

    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

}
