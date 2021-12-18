using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelCurrentText : MonoBehaviour
{
    public Text Text;


    private void Start()
    {
        Text.text = (SceneManager.GetActiveScene().buildIndex).ToString();
    }
}
