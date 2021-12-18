using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class btnFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip hoverSound;
    public AudioClip enterSound;

    public GameObject _SonundOff;
    public GameObject _SonundOn;
    

    public void HoverFx()
    {
        myFx.PlayOneShot(hoverSound);
    }
    public void EnterrFx()
    {
        myFx.PlayOneShot(enterSound);
    }

    public void SoundOff()
    {
        AudioListener.volume = 0;
        _SonundOff.SetActive(false);
        _SonundOn.SetActive(true);
    }
    public void SoundOn()
    {
        AudioListener.volume = 1;
        _SonundOn.SetActive(false);
        _SonundOff.SetActive(true);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
