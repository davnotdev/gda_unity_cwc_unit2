using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontal_input;
    public float speed = 10.0f;

    public float x_range = 10.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -x_range)
        {
            transform.position = new Vector3(-x_range, transform.position.y, transform.position.z);
        }
        if (transform.position.x > x_range)
        {
            transform.position = new Vector3(x_range, transform.position.y, transform.position.z);
        }
        horizontal_input = Input.GetAxis("Horizontal");
        transform.transform.Translate(Vector3.right * horizontal_input * Time.deltaTime * speed);
    }
}
