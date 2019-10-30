using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class c_SceneControl : MonoBehaviour
{
    public int level = 0;
    public int level_to_load = 0;
    public int number_of_cards = 0;
    public Data_Keeper local_data_keep = null;
    public bool loading_from_mainscreen = false;
    
    public const int griRows = 2;
    public const int griCols = 4;
    public const float offsetX = 4f;
    public const float offsetY = 5f;
    private int _score = 0;

    private c_carta firstReveaLed;
    private c_carta sconReveaLed;

    [SerializeField]
    private c_carta OriginalCard;
    [SerializeField]
    private Sprite[] images;

    [SerializeField]
    private Text scoreLabel;
    public int score = 0;

    void Start()
    {
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

                card.ChangeSprite(id, images[id]);

                float posX = (offsetX * i) + startPos.x;
                float posY = (offsetY * j) + startPos.y;

                card.transform.position = new Vector3(posX, posY, startPos.z);

            }
        }

    }

    //-----
    public bool canReveal
    {
        get { return sconReveaLed = null; }
    }

    //-----
    public void CardRevealed(c_carta card)
    {
        if (firstReveaLed == null)
        {
            firstReveaLed = card;
        }
        else
        {
            sconReveaLed = card;
            StartCoroutine(CheckedMatch());
        }
    }

    //-----
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

    //-----
    private IEnumerator CheckedMatch()
    {
        if (firstReveaLed.id == sconReveaLed.id)
        {
            _score++;
            scoreLabel.text = "Score: " + _score;
        }
        else
        {
            yield return new WaitForSeconds(0.5f);

            firstReveaLed.Unreveal();
            sconReveaLed.Unreveal();
        }
        firstReveaLed = null;
        sconReveaLed = null;
    }

    void cardCoparion(List<int> _c)
    {

    }

    public void CheckForDataKeep()
    {
        Data_Keeper dkc;

        dkc = GameObject.FindObjectOfType<Data_Keeper>();

        if (dkc != null)
        {
            local_data_keep = dkc;
            level_to_load = local_data_keep.level;
            number_of_cards = local_data_keep.number_of_cards;
            loading_from_mainscreen = local_data_keep.main_screen;
        }
        else
        {
            Debug.Log("No se encontró el data keeper");
        }
    }
    
}