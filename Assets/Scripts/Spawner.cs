using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject _spawnedObject;
    // Start is called before the first frame update
    void Start()
    {
        // Menentukan posisi spawn
        Vector3 spawnPosition = new Vector3(-4.81f, 3.53f, 0);
        // Menentukan rotasi spawn
        Quaternion spawnRotation = Quaternion.Euler(0, 0, 0);
        // Spawn object dengan posisi dan rotasi tertentu
        Instantiate(_spawnedObject, spawnPosition, spawnRotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
