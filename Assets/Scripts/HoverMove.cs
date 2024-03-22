using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverMove : MonoBehaviour
{
    public SpriteRenderer MoveSprite;
    public Sprite MoveSpriteGold;
    public Sprite MoveSpriteRed;

    // Start is called before the first frame update
    void Start()
    {
        ChangeSpriteRed();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver()
    {
        ChangeSpriteGold();
    }

    void OnMouseExit()
    {
        ChangeSpriteRed();
    }

    void ChangeSpriteGold()
    {
        MoveSprite.sprite = MoveSpriteGold;
    }

    void ChangeSpriteRed()
    {
        MoveSprite.sprite = MoveSpriteRed;
    }
}
