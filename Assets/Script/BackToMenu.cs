using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Threading;
public class BackToMenu : MonoBehaviour
{

    public AudioSource B1utton_Click;
    public void Mune()
    {
        this.B1utton_Click.Play();
        Thread.Sleep(300);
        SceneManager.LoadScene("menu");
    }


}
