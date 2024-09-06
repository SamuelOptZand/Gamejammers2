using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEditor.UI;
using UnityEngine;
using UnityEngine.UI;

public class PanalButtons : MonoBehaviour
{
    public GameObject panal;

    public void PanlButton()
    {
        panal.SetActive(!panal.activeSelf);
    }

    
}
        

