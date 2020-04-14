using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EndingScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI endingtext;
    void Start()
    {
        if(ScoreScript.scoreP1 > ScoreScript.scoreP2){
        endingtext.text = "Player 1 Win";
        }else if(ScoreScript.scoreP1 < ScoreScript.scoreP2){
        endingtext.text = "Player 2 Win"; 
        }else {
            endingtext.text = "Draw";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
