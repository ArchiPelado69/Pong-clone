using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    TextMeshProUGUI player_1_Score;
    TextMeshProUGUI player_2_Score;
    public int P1_Score = 0;
    public int P2_Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        player_1_Score = GameObject.Find("Score_P1").GetComponent<TextMeshProUGUI>();
        player_2_Score = GameObject.Find("Score_P2").GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        player_1_Score.text = "" + P1_Score;
        player_2_Score.text = "" + P2_Score;
    }
}
