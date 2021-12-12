using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider2D other)
    {
        if (other.transform.tag == "Player")
        {
            SceneManager.LoadScene("1F");
        }
    }
}
