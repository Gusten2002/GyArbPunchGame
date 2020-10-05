﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowScriptHandler : MonoBehaviour
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

        
        
        if (hitChance > 0)
        {
            smallEnemieScript.smallDudeHp -= 5;
            Debug.Log("The boss has " + smallEnemieScript.smallDudeHp + "/100 health left");
        }
        else
        {
            Debug.Log("You missed");
        }

        
    }
}
