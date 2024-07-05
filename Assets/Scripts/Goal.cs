using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Kode akan dijalankan ketika ada object lain masuk ke dalam trigger
        SceneManager.LoadScene("GameOver");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
