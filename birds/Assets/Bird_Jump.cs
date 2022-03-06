using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird_Jump : MonoBehaviour
{

    Rigidbody2D rb;
    public float JumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * JumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (Score.score > Score.BestScore)
        {
            Score.BestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
