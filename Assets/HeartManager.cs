using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartManager : MonoBehaviour
{

    public static HeartManager instance;

    [SerializeField]
    GameObject heartPrefab;

    [SerializeField]
    int width = 5;
    
    [SerializeField]
    int height = 4;

    List<GameObject> hearts = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {

        instance = this;

        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                GameObject newHeart = Instantiate(heartPrefab);
                newHeart.transform.position = new Vector3(
                    transform.position.x + x,
                    transform.position.y - y
                );
                hearts.Add(newHeart);
            }
        }

        SetVisibleHearts(15);
    }

    public void SetVisibleHearts(int numHearts)
    {
        for (int i = 0; i < hearts.Count; i++)
        {
            if (i < numHearts)
            {
                hearts[i].gameObject.SetActive(true);
            }
            else {
                hearts[i].gameObject.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
