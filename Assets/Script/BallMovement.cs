using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public float Movementspeed;
    public float extraspeed;
    public float maxspeed;
    int hitcounter = 0;
    void Start()
    {
        StartCoroutine(this.Startball());
    }

    void PositionBall(bool isStartingPlayer1)
    {
     

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
       
        if (isStartingPlayer1)
        { 
            this.gameObject.transform.localPosition = new Vector3(-100, 0, 2);
        }
        else
        {
            this.gameObject.transform.localPosition = new Vector3(100, 0, 2);
        }
    } 

    public IEnumerator Startball(bool isStartingplayer1 = true)
    {
     
        this.PositionBall(isStartingplayer1);

        this.hitcounter = 0;
        yield return new WaitForSeconds(2);
        if (isStartingplayer1)
        {
            this.MoveBall(new Vector2(-1, 0));
        }
        else
        {
            this.MoveBall(new Vector2(1, 0));
        }

    }

    public void MoveBall(Vector2 dir)
    {
        dir = dir.normalized;
        float speed = this.Movementspeed + this.hitcounter * extraspeed;
        Rigidbody2D rigidbody2D = this.gameObject.GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = dir * speed;


    }

    public void IncreaseHitCounter()
    {

    if (this.hitcounter * this.extraspeed <= this.maxspeed)
        {
            this.hitcounter++;
        }
    }
}
