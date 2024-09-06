using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttonscenechanger : MonoBehaviour
{
    public void Changescene(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}