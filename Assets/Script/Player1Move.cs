using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Move : MonoBehaviour
{

    public float movementspreed;

   public  void Start()
    {
        this.gameObject.transform.localPosition = new Vector3(-800, 0, 0);
    }


    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementspreed;
    }
}
