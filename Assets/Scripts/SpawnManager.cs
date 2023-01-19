using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animal_prefabs;
    public int animal_index;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)) {
            var animal = animal_prefabs[animal_index];
            Instantiate(
                animal, 
                new Vector3(0, 0, 20),
                animal.transform.rotation
            );

        }
    }
}
