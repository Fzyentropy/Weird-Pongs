using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static int score;
    private int highscore;
    public TMP_Text textScore;
    public TMP_Text Highscore;
    
    void Start()
    {
        Cursor.visible = false;
        // Cursor.lockState = CursorLockMode.Confined;
        textScore = GameObject.Find("Score").GetComponent<TMP_Text>();
        Highscore = GameObject.Find("Highscore").GetComponent<TMP_Text>();
        score = 0;

    }

    // Update is called once per frame
    void Update()
    {
        textScore.text = score.ToString();
        if (score > highscore)
        {
            highscore = score;
        }

        Highscore.text = highscore.ToString();

    }
}
