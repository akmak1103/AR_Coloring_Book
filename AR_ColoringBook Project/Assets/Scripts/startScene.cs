﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startScene : MonoBehaviour
{
    public void loadSc() {
        SceneManager.LoadScene("SampleScene");
    }
}