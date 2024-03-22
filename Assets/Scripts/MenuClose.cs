using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuClose : MonoBehaviour
{
    public GameObject BackClicked;
    public int backclick;

    public GameObject MenuClicked;
    public int menclick;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        backclick = BackClicked.GetComponent<BackButtonMenu>().MenuOff;

        if (backclick == 1)
        {
            //gameObject.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            MenuClicked.GetComponent<OpenMenu>().ClickMenu = 0;

        }

    }
}
