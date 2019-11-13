using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Repetir_fondo : MonoBehaviour {

    private float groundHorizontalLength;
    private BoxCollider2D groundCollider;

    private void Awake(){
        groundCollider = GetComponent<BoxCollider2D>();
    }

    void Start(){
        groundHorizontalLength = groundCollider.size.x;
    }

    private void RepositionBackground(){
        Vector2 groundOffSet = new Vector2(groundHorizontalLength * 2.0f, 0);
        transform.position = (Vector2)transform.position + groundOffSet;
    }


    void Update(){
        if (transform.position.x <= -groundHorizontalLength){
            RepositionBackground();
        }
    }
}
