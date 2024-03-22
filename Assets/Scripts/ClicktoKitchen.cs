using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClicktoKitchen : MonoBehaviour
{
    public SpriteRenderer BackGround;
    public Sprite KitchenBG;

    public SpriteRenderer Cor;
    public GameObject CorOb;

    public GameObject Kettl;

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
            ChangeSpriteBG();
        }
    }

    void ChangeSpriteBG()
    {
        BackGround.sprite = KitchenBG;
        CorOb.SetActive(false);
        Kettl.SetActive(true);
    }
}
