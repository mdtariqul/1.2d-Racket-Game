using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioSource WallSound;
    public AudioSource batSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "wall3" || collision.gameObject.name == "wall4")
            this.WallSound.Play();
        else if (collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2")
            this.batSound.Play();

    }
}
