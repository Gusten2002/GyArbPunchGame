using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemieScript : MonoBehaviour
{
    // Start is called before the first frame update
    SmallEnemieScript smallEnemieScript;
    public int hitCounter;
    public int whatAttack;
    public int BossHp = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (BossHp <= 0)
        {
            Debug.Log("Small Boss: hit counter " + SmallEnemieScript.hitCounter + "\nwhat attack " + SmallEnemieScript.whatAttack);
            Debug.Log("Big Boss: hit counter " + hitCounter + "\nwhat attack " + whatAttack);
            Destroy(gameObject);
        }
        HeartManager.instance.SetVisibleHearts(BossHp);
    }
}
