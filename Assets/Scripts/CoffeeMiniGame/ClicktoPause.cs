using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClicktoPause : MonoBehaviour
{
    public TextMeshProUGUI pausetext;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 0;
            pausetext.text = "Right Click to Unpause";
        }

        if (Input.GetMouseButtonDown(1))
        {
            Time.timeScale = 1;
            pausetext.text = "Left Click to Pause";
        }
    }
}
