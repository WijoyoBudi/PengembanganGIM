using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    public int counter = 30;
    public Text TimerText;
    // Start is called before the first frame update
    void Start()
    {
        TimerText.text = counter.ToString();
        StartCoroutine(HitungMundur());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator HitungMundur(){
        while(counter>0){
            yield return new WaitForSeconds(1);
            counter -= 1;
            TimerText.text = counter.ToString();
        }

        TimerText.text = "GAME OVER";
    }
}
