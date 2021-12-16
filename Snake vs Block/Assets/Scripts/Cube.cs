using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;
public class Cube : MonoBehaviour
{
    public int weightCube;
    public TextMeshPro weightCubeText;
    private void Start()
    {
        weightCube = Random.Range(2, 2);
        weightCubeText.SetText(weightCube.ToString());
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            for (int i = 0; i < weightCube; i++)
            {
                PlayerControl.component.RemoveTail();
                PlayerControl.lengthTail--;
                weightCube--;
                if(weightCube<1)
                    Destroy(gameObject);
                
                weightCubeText.SetText(weightCube.ToString());
            }
            
        }
    }

}
