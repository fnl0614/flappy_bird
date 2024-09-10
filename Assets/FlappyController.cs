using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyController : MonoBehaviour
{
    Rigidbody2D rb;
    /*[SerializeField]*/ float jumpPower = 3;
    public int score ;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
              rb.velocity = Vector2.up * jumpPower;  
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        score++;
        Debug.Log("Score : " + score);

    }
}
