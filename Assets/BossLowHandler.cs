using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLowHandler : MonoBehaviour
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
        enemieScript.hitCounter++;
        enemieScript.whatAttack += 1;

        
        
        if (hitChance > 0)
        {
            enemieScript.BossHp -= 1;
            Debug.Log("The boss has " + enemieScript.BossHp + "/20 health left");
        }
        else
        {
            Debug.Log("You missed");
        }

        
    }
}
