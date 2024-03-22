using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMug : MonoBehaviour
{

    public GameObject Mug;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X");
        Mug.transform.Translate(x, 0, 0);
    }
}
