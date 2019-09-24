using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class c_ActGame : MonoBehaviour {

    public short m_CardsInGame = 5;
    public short m_MatchesReached;
    public short m_PosibleMatches;
    public int m_Points;
    const int m_PointsPerMatch = 150;
    public short m_TriesFailed;
    const int m_PointsFailed = -5;
    //public c_Cards m_Cards;
    public c_Time m_Time;


    //Functions
    //Points conter
    void countPoints() {

        //La puntuacion se ira contando apartir de los intentos fallidos, combinaciones y el tiempo que se tardó el jugador
        m_Points = (m_MatchesReached * m_PointsPerMatch) + (m_TriesFailed + m_PointsFailed); //Falta el tiempo  

    }


    // Start is called before the first frame update
    void Start() {
        


    }

    // Update is called once per frame
    void Update() {


        
    }



}
