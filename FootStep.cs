﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootStep : MonoBehaviour
{
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
       void Update()
    {
        
    }
 
    private void Step()
    {
       
        audioSource.Play();
    }
}