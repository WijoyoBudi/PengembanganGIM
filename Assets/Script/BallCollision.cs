using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public int speed = 30;
    public Rigidbody2D sesuatu;
    public GameObject MasterScript;
    public Animator anim;
    public AudioSource HitEffect;
    void Start()
    {
        sesuatu.velocity = new Vector2(-1,-1)* speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
 void FixedUpdate(){
    if(sesuatu.velocity.x > 0){
        sesuatu.GetComponent<Transform>().localScale = new Vector3 (1, 1, 1);
    }else {
        sesuatu.GetComponent<Transform>().localScale = new Vector3 (-1, -1, -1);
    }
}
     void OnCollisionEnter2D(Collision2D other){
        if(other.collider.name == "WallKanan" || other.collider.name == "WallKiri"){
            MasterScript.GetComponent<ScoreScript>().UpdateScore(other.collider.name);
            StartCoroutine(Jeda()); 
        }
        if (other.collider.tag=="Player"){
            HitEffect.Play();
        }

        IEnumerator Jeda()
        {
            sesuatu.velocity = Vector2.zero;
            anim.SetBool("IsMoving", false);
            sesuatu.GetComponent<Transform>().position = new Vector2 (0,0);
            yield return new WaitForSeconds(1);
            sesuatu.velocity = new Vector2(-1,-1)* speed;
            anim.SetBool("IsMoving",true);
        }
     }
}
