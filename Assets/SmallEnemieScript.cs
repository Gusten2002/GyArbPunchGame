using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallEnemieScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static int hitCounter;
    public static int whatAttack;
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
            SceneManager.LoadScene(1);
        }

        HeartManager.instance.SetVisibleHearts(smallDudeHp);
    }
}
