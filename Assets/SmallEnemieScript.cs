using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallEnemieScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int smallDudeHp = 100;
    void Start()
    {
        HeartManager.instance.SetVisibleHearts(10);
    }

    // Update is called once per frame
    void Update()
    {
        if (smallDudeHp <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }
    }
}
