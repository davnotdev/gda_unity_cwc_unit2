using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animal_prefabs;

    private float spawn_range = 15.0f;
    private float start_delay = 2;
    private float spawn_interval = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimal", start_delay, spawn_interval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAnimal()
    {
        int random_animal_idx = Random.Range(0, animal_prefabs.Length);
        var animal = animal_prefabs[random_animal_idx];

        float random_position_x = Random.Range(-spawn_range, spawn_range);

        Instantiate(
            animal,
            new Vector3(random_position_x, 0, 20),
            animal.transform.rotation
        );
    }
}
