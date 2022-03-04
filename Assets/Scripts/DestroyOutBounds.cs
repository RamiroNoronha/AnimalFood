using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float downBound = -10.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < downBound)
        {
            Debug.Log("GameOver!!!");
            Destroy(gameObject);
        }
    }
}
