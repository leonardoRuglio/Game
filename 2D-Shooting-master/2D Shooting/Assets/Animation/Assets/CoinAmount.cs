using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinAmount : MonoBehaviour
{
    private int lastScore = ScoreTextScript.coinAmount;
    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        text.text = lastScore.ToString();
    }

}
