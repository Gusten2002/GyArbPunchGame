﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScriptHandler : MonoBehaviour
{
    // Start is called before the first frame update

    SmallEnemieScript smallEnemieScript = new SmallEnemieScript();
    void Start()
    {
        smallEnemieScript = GameObject.Find("LittleMan").GetComponent<SmallEnemieScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Thing() 
    {
        int hitChance = Random.Range(0, 100);

        
        
        if (hitChance > 87)
        {
            smallEnemieScript.smallDudeHp -= 50;
            Debug.Log("The boss has " + smallEnemieScript.smallDudeHp + "/100 health left");
        }
        else
        {
            Debug.Log("You missed");
        }

        
    }

}