using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class ExitButton : MonoBehaviour
{
    public AudioSource B1utton_Click;
    public void quitGame()
    {
        this.B1utton_Click.Play();
        Thread.Sleep(300);
        Application.Quit();
    }
}
