using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
public class PlayButton : MonoBehaviour
{
    public AudioSource B1utton_Click;
    public void PlayGame()
    {
        this.B1utton_Click.Play();
        Thread.Sleep(300);
        SceneManager.LoadScene("game scene");
    }
}
