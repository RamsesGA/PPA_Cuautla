using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class c_carta : MonoBehaviour
{
    public  GameObject Carta;
    [SerializeField]
    private c_SceneControl controller;
    private int _id;

    //  Unity methods
    public void OnMouseDown()
    {
        if (Carta.activeSelf)
        {
            Carta.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    //  Getters
    public int id
    {
        get { return _id; }
    }

    //  Methods
    public void ChangeSprite(int id, Sprite image)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }

    public void Unreveal()
    {
        Carta.SetActive(true);
    }
}
