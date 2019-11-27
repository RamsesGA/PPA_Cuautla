using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class c_Score : MonoBehaviour {

    public tiempo m_Time;
    public float m_Points;
    public short m_TriesFailed;
    const int m_PointsFailed = -5;
    const int m_PointsPerMatch = 150;
    public short m_MatchesReached;

    public GameObject Panel_fin;

    // Start is called before the first frame update
    void PointsCount() {
        m_Points = ((m_MatchesReached * m_PointsPerMatch) + (m_TriesFailed + m_PointsFailed) * m_Time.control_tiempo); 
        GetComponent<Text>().text = m_Points.ToString();
    }


    void EndGame() {
        Time.timeScale = 0f;
        Panel_fin.SetActive(true);
        PointsCount();
    }
   
}
