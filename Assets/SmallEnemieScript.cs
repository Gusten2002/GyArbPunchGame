using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallEnemieScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int smallDudeHp = 20;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (smallDudeHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
