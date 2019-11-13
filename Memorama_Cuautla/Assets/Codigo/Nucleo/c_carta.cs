using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class c_carta : MonoBehaviour
{

    [SerializeField]
    private c_SceneControl controller;

    [SerializeField]
    public GameObject Carta;
    private int _id;

    //-----
    public void OnMouseDown()
    {
        if (Carta.activeSelf)
        {
            Carta.SetActive(false);
            controller.CardRevealed(this);
        }
    }

    //-----
    public int id
    {
        get { return _id; }
    }

    //-----
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
