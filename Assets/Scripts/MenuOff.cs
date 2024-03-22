using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuOff : MonoBehaviour
{
    public GameObject Kitch;
    public GameObject Liv;
    public GameObject Bed;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.SetActive(false);
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        Kitch.SetActive(false);
        Liv.SetActive(false);
        Bed.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
