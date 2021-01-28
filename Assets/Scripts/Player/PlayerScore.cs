using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerScore : MonoBehaviour
{
    public int Score = 0;

    public Text TxtScore; // Text => le composant UI attaché à l'objet 
    public GameObject PnlGameOver; 

    // Start is called before the first frame update

    void Start() 
    {
        TxtScore.text = "Score = " + Score;
    }

    void Update() 
    {
        
    }

    public void AddScore()
    {
        Score++;
        TxtScore.text = "Score = " + Score;
    }

    public void ReduceScore()
    {
        Score--;
        TxtScore.text = "Score = " + Score;

        if(Score < 0)
        {
            PnlGameOver.SetActive(true);
        }
    }

}
