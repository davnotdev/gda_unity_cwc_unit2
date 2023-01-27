using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float timePassed = 0;
    private bool canSpawn = true;

    // Update is called once per frame
    void Update()
    {
        if (!canSpawn)
        {
            timePassed += Time.deltaTime;
        }

        if (timePassed >= 0.5f)
        {
            canSpawn = true;
            timePassed = 0.0f;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawn = false;
        }
    }
}
