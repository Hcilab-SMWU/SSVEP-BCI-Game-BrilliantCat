using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Text

using static Score;

public class FinalScore : MonoBehaviour
{
    public Text CatText;

    public int ScoreF;
    //public static Score instance;

    // void Awake()
    // {
    //     instance=this;
    // }
    
    void Start()
    {
        ScoreF = Score.CatScore;
    }

    public void Update()
    {
        CatText.text = "Score : " + ScoreF;
    }
}
