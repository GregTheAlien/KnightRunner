using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    Rigidbody2D rb;
    public float amountOfForce;
    //int score;
    string level;
    public Text scoreText;
    public Text highScoreText;

    public Sprite neutral, falling, rising;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.sprite = neutral;
        rb = GetComponent<Rigidbody2D>();
        print("Score: " + GlobalVar.score);
        scoreText.text = GlobalVar.score.ToString();
        GlobalVar.GetScore();
        highScoreText.text = GlobalVar.highScore.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        Anim();
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(Vector2.up * amountOfForce, ForceMode2D.Impulse);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        PipeController pc;
        pc = other.GetComponent<PipeController>();
        GlobalVar.score += pc.points;
        print("Score: " + GlobalVar.score);
        scoreText.text = GlobalVar.score.ToString();
        CheckScore();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        CheckScore();
        EndGame();
    }

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
}
