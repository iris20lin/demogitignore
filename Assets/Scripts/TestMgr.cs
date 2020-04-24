using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMgr : MonoBehaviour
{

    public GameObject prefab;
    public Transform canvas;  // parent;


    private Vector3 position = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        position.x = -300;
        for (int i = 0; i < 10; i++)
        {
            GameObject newObject = Instantiate(prefab, canvas);
            newObject.name = "coin_" + i;

            //重新計算位置
            position.x += 70; //step
            newObject.GetComponent<Transform>().localPosition = position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
