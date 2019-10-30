using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class DataController : MonoBehaviour {
    public int level;
    int cardsPerLVL;

    public int rows;
    public int cols;
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
        switch (level) {
            case 1: {
                    rows = 2;
                    cols = 4;
                    cardsPerLVL = 4;
                    numbers = new int[cardsPerLVL * 2];
                    for (int i = 0; i < cardsPerLVL * 2; i++)
                    {
                        numbers[i] = (i / 2);
                    }

                    break;
                }

            case 2: {
                    rows = 2;
                    cols = 5;
                    cardsPerLVL = 5;
                    numbers = new int[cardsPerLVL * 2];
                    for (int i = 0; i < cardsPerLVL * 2; i++)
                    {
                        numbers[i] = (i / 2);
                    }
                    break;
                }

            case 3: {
                    rows = 3;
                    cols = 4;
                    cardsPerLVL = 6;
                    numbers = new int[cardsPerLVL * 2];
                    for (int i = 0; i < cardsPerLVL * 2; i++)
                    {
                        numbers[i] = (i / 2);
                    }
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