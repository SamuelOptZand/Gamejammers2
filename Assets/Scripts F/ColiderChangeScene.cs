using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ColiderChangeScene : MonoBehaviour
{
    public string sceneName;

    //private void OnTrigerEnter(Collider other)
    //{
    //    if (other.CompareTag("player"))
    //    {
    //        SceneManager.LoadScene(sceneName);
    //    }
   // }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}