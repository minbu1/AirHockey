using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoalScript : MonoBehaviour
{
    public TextMeshProUGUI LeftScore;
    public TextMeshProUGUI RightScore;

    Vector3 startPos;
    int rightScore = 0;
    int leftScore = 0;

    private void Start()
    {
        startPos = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RightGate")
        {
            rightScore += 1;
            transform.position = startPos;
        }
        if(collision.gameObject.tag == "LeftGate")
        {
            leftScore += 1;
            transform.position = startPos;
        }
    }
    private void DisplayScore()
    {
        LeftScore.text = leftScore.ToString();
        RightScore.text = rightScore.ToString();
    }
    private void Update()
    {
        DisplayScore();
    }
}
