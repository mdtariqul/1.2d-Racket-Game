using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;

public class StartButton : MonoBehaviour
{
    public AudioSource B1utton_Click;
    public int t;
    public void StartGame()
    {
        if (t == 2)
        {
            this.B1utton_Click.Play();
            Thread.Sleep(300);
        }
        SceneManager.LoadScene("Start");
    }
   
   
  
}
