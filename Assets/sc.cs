﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{
     // Start is called before the first frame update
    public int speed = 30;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector2(-1,1)*speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
