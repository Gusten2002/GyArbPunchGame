using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScriptHandler : MonoBehaviour
{
    // Start is called before the first frame update

    EnemieScript enemieScript = new EnemieScript();
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Thing() 
    {
        int hitChance = Random.Range(0, 100);

        
        
        if (hitChance > 80)
        {
            enemieScript.BossHp -= 50;
            Debug.Log("The boss has " + enemieScript.BossHp + "/100 health left");
        }

        
    }

}
