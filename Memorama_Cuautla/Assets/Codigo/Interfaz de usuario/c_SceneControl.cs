using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class c_SceneControl : MonoBehaviour {

    public const int griRows = 2;
    public const int griCols = 4;
    public const float offsetX = 4f;
    public const float offsetY = 5f;


    [SerializeField]
    private c_carta OriginalCard;
    [SerializeField]
    private Sprite[] images;

    public int score = 0;


    // Start is called before the first frame update
    void Start() {

        Vector3 startPos = OriginalCard.transform.position;
        int[] numbers = { 0, 0, 1, 1, 2, 2, 3, 3 };
        numbers = shuffleArray(numbers);
        for (int i = 0; i < griCols; i++)
        {
            for (int j = 0; j < griRows; j++)
            {
                c_carta card;
                if (i == 0 && j == 0)
                {
                    card = OriginalCard;
                }
                else
                {
                    card = Instantiate(OriginalCard) as c_carta;
                }
                int index = j * griCols + i;
                int id = numbers[index];
                //card.ChangeSprite(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = (offsetY * j) + startPos.y;

                card.transform.position = new Vector3(posX, posY, startPos.z);

            }


        }

    }

    private int[] shuffleArray(int[] numbers)
    {
        int[] newArray = numbers.Clone() as int[];

        for (int i = 0; i < newArray.Length; i++)
        {

            int temp = newArray[i];
            int r = Random.Range(i, newArray.Length);
            newArray[i] = newArray[r];
            newArray[r] = temp;
        }
        return newArray;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
