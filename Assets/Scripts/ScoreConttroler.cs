using System.Collections;
using System.Collections.Generic;
using TMPro;
using System;
using UnityEngine;

public class ScoreConttroler : MonoBehaviour
{
    int _score;
    public static ScoreConttroler Instance = null; 

    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        if (Instance != null) Destroy(this);
        else Instance = this;  

            _score = 0;  

        scoreText.text = _score.ToString();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            AddScore();
            Debug.Log("Score" + _score);
        }
    }*/
    public void AddScore()
    {
        _score++;
        scoreText.text = _score.ToString();

    }
    public int GetScore()
    {
        return _score;  
    }
   public void SetScore(int score)
    {
        _score = score;
    }
}
