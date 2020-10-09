using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        hpHandler = GameObject.Find("Heart (0)").GetComponent<HPhandler>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HPCheck()
    {

    }
}
