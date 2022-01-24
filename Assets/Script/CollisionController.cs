using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public int level;
    public BallMovement ballMovement;
    public ScoreController scoreController;
    public Player1Move p1;
    public Player2Move p2;
    public AIScoreController CscoreController;

    

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "Player1")
        {
            x = 1;
        }
        else
        {
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHight;

        this.ballMovement.IncreaseHitCounter();
        this.ballMovement.MoveBall(new Vector2(x, y));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
        {
            this.BounceFromRacket(collision);
        }
        else if (collision.gameObject.name == "wall3")
        {
           

            StartCoroutine(this.ballMovement.Startball(true));
            //  Debug.Log("Collision with left wall");
            if (level == 1)
            {
                this.CscoreController.GoalPlayer2();
            }
            else
            {
                this.scoreController.GoalPlayer2();
                this.p2.Start();
            }
            this.p1.Start();
            

        }
        else if (collision.gameObject.name == "wall4")
        {
           

            StartCoroutine(this.ballMovement.Startball(false));
            // Debug.Log("Collision with Right wall");
            if (level == 1)
            {
                this.CscoreController.GoalPlayer1();
            }
            else
            {
                this.scoreController.GoalPlayer1();
                this.p2.Start();
            }
            this.p1.Start();
            

        }

    }
}
