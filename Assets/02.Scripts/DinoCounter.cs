using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DinoCounter : MonoBehaviour
{
    public TextMeshPro dinoCounText;
    public Transform dinoParant;
    void Start()
    {
        
    }

    void Update()
    {
        dinoCounText.text = dinoParant.childCount.ToString();           
    }
}
