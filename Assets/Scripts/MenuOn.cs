using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOn : MonoBehaviour
{
    public GameObject MenuClicked;
    public int menclick;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        menclick = MenuClicked.GetComponent<OpenMenu>().ClickMenu;

        if (menclick == 1)
        {
            
            //gameObject.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;

        }
    }
}
