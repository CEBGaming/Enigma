using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHover : MonoBehaviour
{
    
    void Start()
    {
        //gameObject.SetActive(true);
        ///gameObject.GetComponent<SpriteRenderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        //gameObject.SetActive(false);
        //Hovering += 1;
        //gameObject.GetComponent<SpriteRenderer>().enabled = false;
        gameObject.GetComponent<SpriteRenderer>().color = new Color32 (252, 159, 0, 255);
    }
    
    void OnMouseExit()
    {
        //gameObject.SetActive(true);
        //gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<SpriteRenderer>().color = new Color32 (255, 255, 255, 255);
    }
}
