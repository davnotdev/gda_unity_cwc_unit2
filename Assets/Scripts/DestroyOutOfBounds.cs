using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float top_bound = 30.0f;
    private float bottom_bound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > top_bound)
        {
            Destroy(gameObject);
        } else if (transform.position.z < bottom_bound) 
        {
            Destroy(gameObject);
            Debug.Log("Game Over!");
        }
    }
}
