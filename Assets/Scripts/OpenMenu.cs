using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{
    public int ClickMenu = 0;
    public GameObject Cli;

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
            Cli.GetComponent<BackButtonMenu>().MenuOff = 0;
            ClickMenu += 1;
        }
    }
}
