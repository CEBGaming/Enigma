using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public int lives;
    public TextMeshProUGUI scoreTxt;
    public GameObject[] LivesImage;

    public int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        lives = 3;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Coffee"))
        {

            Destroy(collision.gameObject);
            score += 10;
            scoreTxt.text = score.ToString("0000");

            if (score == 1000)
            {
                SceneManager.LoadScene("SceneTwo");
            }
        }

        if (collision.gameObject.CompareTag("Milk"))
        {

            Destroy(collision.gameObject);

            if (lives <= 0)
            {
                SceneManager.LoadScene("GameOverCoffee");
            }

            else
            {
                lives--;
                LivesImage[lives].SetActive(false);
            }
        }
    }
}
