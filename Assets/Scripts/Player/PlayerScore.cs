using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScore : MonoBehaviour
{
    public int Score = 1;
    public int ScoreTime = 0;

    public Text TxtScore; // Text => le composant UI attaché à l'objet 
    public Text TxtScoreTime;
    public Text TxtScoreEnd;
    public GameObject PnlGameOver; 

    // Start is called before the first frame update

    void Start() 
    {
        TxtScore.text =  Score + " hearts";
        TxtScoreTime.text =  TxtScoreTime + " ";
    }

    void Update() 
    {
        if(Score != 0 ) {
        ScoreTime++;

        }
        TxtScoreTime.text =  ScoreTime + " ";
        TxtScoreEnd.text =  ScoreTime + " ";
    }

    public void AddScore()
    {
        Score++;
        TxtScore.text =  Score + " hearts";
    }

    public void ReduceScore()
    {
        Score--;
        TxtScore.text =  Score + " hearts";

        if(Score < 1)
        {
            PnlGameOver.SetActive(true);
            Time.timeScale = 0f;
        }
    }

}
