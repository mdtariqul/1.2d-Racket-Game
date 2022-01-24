using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIp2 : MonoBehaviour
{
    public float MovementSpeed;
    public GameObject Ball;

    public void Start()
    {
        this.gameObject.transform.localPosition = new Vector3(342, 0, 0);
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(this.transform.position.y - Ball.transform.position.y) > 100)
        {
            if(this.transform.position.y < Ball.transform.position.y)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1)* MovementSpeed;
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1)* MovementSpeed;
            }
        }
    }

}
