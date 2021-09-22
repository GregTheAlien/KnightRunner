using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    Animator anim;
    public float amountOfForce;
    bool onGround;
    //string level;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //scoreText.text = GlobalVar.score.ToString();
        //GlobalVar.GetScore();
        //highScoreText.text = GlobalVar.highScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        //Anim();
        if(Input.GetMouseButtonDown(0) && onGround)
        {
            onGround = false;
            anim.SetBool("jumping", true);
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * amountOfForce, ForceMode2D.Impulse);
        }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        onGround = true;
        anim.SetBool("jumping", false);
        //CheckScore();
        //EndGame();
    }

    /*
    void CheckScore()
    {
        if(GlobalVar.score > GlobalVar.highScore)
        {
            GlobalVar.highScore = GlobalVar.score;
            highScoreText.text = GlobalVar.highScore.ToString();
        }
    }

    void EndGame()
    {
        GlobalVar.SetScore();
        level = SceneManager.GetActiveScene().name;
        GlobalVar.score = 0;
        SceneManager.LoadScene(level);
    }
    void Anim()
    {
        print(rb.velocity);
        if (rb.velocity.y > 0.1f)
        {
            sr.sprite = rising;
        }
        else if (rb.velocity.y < -0.3f)
        {
            sr.sprite = falling;
        }
        else
            sr.sprite = neutral;
    }
    */
}
