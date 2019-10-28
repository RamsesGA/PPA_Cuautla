using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DataController : MonoBehaviour {
    public int level;
    int cardsPerLVL = 3;

    public int rows = 2;
    public int cols = 4;
    public float X = 4f;
    public float Y = 5f;
    public int[] numbers;

    // Start is called before the first frame update
    void Start() {
        DontDestroyOnLoad(this.gameObject);  
    }

    public void setLVL(int inLevel) {
        level = inLevel;
        // Vamos a hacer un nuevo espacio de memoria basado
        // en el numero de cartas
        numbers = new int[8/*cardsPerLVL * 2*/];
        switch (level) {
            case 1: {
                    for (int i = 0; i < cardsPerLVL * 2; i++)
                    {
                        numbers[i] = (i / 2);
                    }

                    break;
                }

            case 2:
                {
                    break;
                }

            default:
                {
                    Debug.Log("Error");
                    break;
                }
            
        }

    }

}