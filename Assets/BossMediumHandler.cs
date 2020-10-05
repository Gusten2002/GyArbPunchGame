using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMediumHandler : MonoBehaviour
{
    // Start is called before the first frame update
    
    EnemieScript enemieScript = new EnemieScript();
    void Start()
    {
        enemieScript = GameObject.Find("BigMan").GetComponent<EnemieScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void Thing() 
    {
        int hitChance = Random.Range(0, 100);

        
        
        if (hitChance > 50)
        {
            enemieScript.BossHp -= 15;
            Debug.Log("The boss has " + enemieScript.BossHp + "/100 health left");
        }
        else
        {
            Debug.Log("You missed");
        }

        
    }
}
