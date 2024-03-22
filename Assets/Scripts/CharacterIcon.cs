using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterIcon : MonoBehaviour
{

    public SpriteRenderer CharaIcon;
    public Sprite Bedroom;
    //public Sprite LivingRoom;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = false;
        BedroomIcon();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void BedroomIcon()
    {
        CharaIcon.sprite = Bedroom;
    }

}
