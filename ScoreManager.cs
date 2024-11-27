using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI textUI;
    public void AddScore(int p)
    {
        score = score + p;
        textUI.text = "Puntaje:" + score;

    }
}
