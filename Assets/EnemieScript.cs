﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int BossHp = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BossHp <= 0)
        {
            Destroy(gameObject);
            Debug.Log("test");
        }
    }
}
