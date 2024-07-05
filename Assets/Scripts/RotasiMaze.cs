using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class RotasiMaze : MonoBehaviour
{
    [SerializeField]
    private Transform _mazeTransform;
    private float keKanan;
    private float keKiri;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _mazeTransform.Rotate(0, 0, 0 * 100 * Time.deltaTime);
    }
}
