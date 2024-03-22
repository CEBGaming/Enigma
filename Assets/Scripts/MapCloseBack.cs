using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapCloseBack : MonoBehaviour
{
    public GameObject MBackClicked;
    public int mapbackclick;

    public GameObject MapMoveClicked;
    public int mapmovclick;

    public GameObject MapBG;
    public GameObject BackMap;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mapbackclick = MBackClicked.GetComponent<MoveMapBack>().MapOff;
        mapbackclick = MBackClicked.GetComponent<MoveBack>().OffMap;

        if (mapbackclick >= 1)
        {
            //gameObject.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            //MapBG.SetActive(false);
            MapBG.GetComponent<SpriteRenderer>().enabled = false;
            //MapMoveClicked.GetComponent<OpenMap1>().MovClick = 0;

        }
    }
}
