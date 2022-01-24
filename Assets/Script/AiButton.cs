using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
public class AiButton : MonoBehaviour
{
    public AudioSource B1utton_Click;
    public void PlayAiGame()
    {
        this.B1utton_Click.Play();
        Thread.Sleep(300);
        SceneManager.LoadScene("AAIgame scene 1");
    }
}
