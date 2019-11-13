using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll_fondo : MonoBehaviour
{
    private Rigidbody2D rigidBody2D;
    public float scrollSpeed = 1.0f;

    private void Awake(){
        rigidBody2D = GetComponent<Rigidbody2D>();
    }


    void Start(){
        rigidBody2D.velocity = new Vector2(scrollSpeed, 0);
    }

    void Update(){
    }
}
