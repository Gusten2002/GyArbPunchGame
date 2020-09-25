using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MediumButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Random generator = new Random();
        int attack = 6;
        int attackChance = generator.Next(10);

        for (int i = 0; i < 10; i + 2)
        {
            if (attackChance == i)
            {
                
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
