﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_Obs : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        Debug.Log("Collision Detected");
        Destroy(other.gameObject);
    }
}
