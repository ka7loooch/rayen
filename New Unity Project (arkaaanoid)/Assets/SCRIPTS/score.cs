using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scoreText;
        int Score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.name == "square")
        {
            //this line will just add 1 point to the score
            Score++;
            //this line will convert the int score variable to a string variable
            scoreText.text = Score.ToString();
        }
    }
}
