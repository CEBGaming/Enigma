using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButtonMenu : MonoBehaviour
{
    public int MenuOff = 0;

    public GameObject ue;
    public int men;

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
            MenuOff = 1;
        }
    }
}
