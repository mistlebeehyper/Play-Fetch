using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float SpawnTimer;

    // Update is called once per frame
    void Update()
    {
        if (SpawnTimer > 0)
        {
            SpawnTimer -= Time.deltaTime;
        }

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space ) && SpawnTimer <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            SpawnTimer = 2.0f;
        }
    }
}
