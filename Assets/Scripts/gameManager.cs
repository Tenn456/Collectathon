using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public int objNum;
    public GameObject objCollect;

    public Transform leftTop;
    public Transform rightBottom;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < objNum; i++)
        {
            float newX = Random.Range(leftTop.position.x, rightBottom.position.x);
            float newZ = Random.Range(rightBottom.position.z, leftTop.position.z);
            Vector3 newPos = new Vector3(newX, 2.24f, newZ);
            GameObject newObj = Instantiate(objCollect, newPos, Quaternion.identity);
        }
    }
}
