using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveClicked : MonoBehaviour
{
    public int MoveClick = 0;

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
            //MoveClick = 1;
            //MapBG.SetActive(true);
            MapBG.GetComponent<SpriteRenderer>().enabled = true;
            //BackMap.SetActive(true);
            BackMap.GetComponent<SpriteRenderer>().enabled = true;
            CharIcon.GetComponent<SpriteRenderer>().enabled = true;

            Kitch.SetActive(true);
            Liv.SetActive(true);
            Bed.SetActive(true);
        }
    }
}
