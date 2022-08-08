using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement; 
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    // Start is called before the first frame update'
    [SerializeField] float force = 1f;
    [SerializeField] float speed = 1f;

    bool isDead;

    public Rigidbody2D rb;

    public Animator birdAnimator;

    public GameObject replayButton;

    public GameObject startButton;

    void Start()
    {
        Time.timeScale = 0;

        int ttt = 0;

        int yyy = 0;

        int ty = 0;

        int fs = 0;

        rb.velocity = Vector2.right * speed;

        isDead = false;

        replayButton.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isDead)
        {
            rb.velocity = new Vector2(1, 0) * speed;
            

            rb.AddForce(Vector2.up * force);
        }
    }
    private void FixedUpdate()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;

        rb.velocity = Vector2.zero;

        replayButton.SetActive(true);

        birdAnimator.SetBool("isDead", true);
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
        replayButton.SetActive(false);
    }
    public void UnFreeze()
    {
        Time.timeScale = 1.0f;

        startButton.SetActive(false);
    }    
}
