using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
     // Start is called before the first frame update
    public int speed = 30;
    public Rigidbody2D sesuatu;
    public Animator anim; 
    void Start()
    {
        sesuatu.velocity = new Vector2(-1,1)*speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (sesuatu.velocity.x > 0){ // bola bergerak ke kanan
        sesuatu.GetComponent<Transform>().localScale = new Vector3(1,1,1);
        }else{
        sesuatu.GetComponent<Transform>().localScale = new Vector3(-1,-1,-1);    
        }
    }
}
