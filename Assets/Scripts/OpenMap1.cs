using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMap1 : MonoBehaviour
{
    public GameObject MapMove;
    public int MovClick;

    public GameObject MapBG;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovClick = MapMove.GetComponent<MoveClicked>().MoveClick;

        if (MovClick == 1)
        {

            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            MapBG.SetActive(true);

        }
    }
}
