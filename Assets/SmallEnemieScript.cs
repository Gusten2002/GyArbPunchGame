using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SmallEnemieScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int hitCounter;
    public int whatAttack;
    public int smallDudeHp = 20;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (smallDudeHp <= 0)
        {
            Debug.Log("hit counter " + hitCounter + "\nWhat attack " + whatAttack);
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }

        HeartManager.instance.SetVisibleHearts(smallDudeHp);
    }
}
