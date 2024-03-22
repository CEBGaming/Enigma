using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    public int OffMap = 0;

    public GameObject MapBG;
    public GameObject BackMap;
    public GameObject CharIcon;

    public GameObject Kitch;
    public GameObject Liv;
    public GameObject Bed;

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
            //OffMap = 1;
            BackMap.GetComponent<SpriteRenderer>().enabled = false;
            MapBG.GetComponent<SpriteRenderer>().enabled = false;
            CharIcon.GetComponent<SpriteRenderer>().enabled = false;

            Kitch.SetActive(false);
            Liv.SetActive(false);
            Bed.SetActive(false);
        }
    }
}
