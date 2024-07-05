using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update");
    }

    void Awake()
    {
        Debug.Log("Awake");
    }

    void OnEnable()
    {
        Debug.Log("On Enable");
    }

    void LateUpdate()
    {
        Debug.Log("Late Update");
    }

    void OnDisable()
    {
        Debug.Log("On Disable");
    }

    void OnDestroy()
    {
        Debug.Log("On Destroy");
    }

    void OnApplicationQuit()
    {
        Debug.Log("On Application Quit");
    }
}
