using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeScript : MonoBehaviour
{
    [SerializeField]
    private Transform _maze;
    private bool RotasiKiri;
    private bool RotasiKanan;
    // Start is called before the first frame update
    void Start()
    {
        RotasiKiri = false;
        RotasiKanan = false;
    }

    public void OnRotationLeft()
    {
        RotasiKiri = true;
    }
    public void OnRotationLeftStop()
    {
        RotasiKiri = false;
    }
    public void OnRotationRight()
    {
        RotasiKanan = true;
    }
    public void OnRotationRightStop()
    {
        RotasiKanan = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (RotasiKiri == true)
        {
            _maze.Rotate(0, 0, 40 * Time.deltaTime);
        }
        if (RotasiKanan == true)
        {
            _maze.Rotate(0, 0, -40 * Time.deltaTime);
        }
    }
}
