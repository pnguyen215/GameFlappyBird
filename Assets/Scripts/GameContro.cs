using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameContro : MonoBehaviour {

    public static GameContro instance;
    public GameObject gameOverText;
    public bool gameOver = false;
    public Text scoretext;
    public float scrollSpeed = -1.5f;

    private int score = 0;


	// Use this for initialization
	void Awake () {
        if (instance == null)
        {
            instance = this;
        }
		else if (instance!= null)
        {
            Destroy(gameObject);
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
	}

    public void BirdScored()
    {
        if (gameOver)
        {
            return;
        }
        score++;
        scoretext.text = "Score: " + score.ToString();
    }

    public void BirdDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }
}
