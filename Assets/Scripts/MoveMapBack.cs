using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveMapBack : MonoBehaviour
{
    public int OffMap = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OffMap = 1;
        }
    }
}
