using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;
using TMPro;
public class Cube : MonoBehaviour
{
    public int weightCube;
    public TextMeshPro weightCubeText;

    private MeshRenderer _meshRenderer;
    Gradient gradient;
    GradientColorKey[] colorKey;
    GradientAlphaKey[] alphaKey;
    private Renderer _renderer;
    private AudioSource _audioBlock;
    public float tim;
    
    private void Awake()
    {
        _audioBlock = GetComponent<AudioSource>();
        weightCube = Random.Range(1, 15);
        weightCubeText.SetText(weightCube.ToString());
        _renderer = GetComponent<Renderer>();
        
       Gradient g = new Gradient();
       GradientColorKey[] gck = new GradientColorKey[2];
       GradientAlphaKey[] gak = new GradientAlphaKey[2];
       gck[0].color = new Color(0.1f, 0.05f, 0f);
       gck[0].time = 1.0F;
       gak[0].alpha = 0F;
       gak[0].time = 1.0F;
       
       gck[1].color = Color.red;
       gck[1].time = -1.0F;
       gak[1].alpha = 0.0F;
       gak[1].time = -1.0F;
       
       g.SetKeys(gck, gak);
       _renderer.material.color = g.Evaluate(weightCube/15f);
    }
    private void OnTriggerEnter(Collider other)
    {
        PlayerControl.lengthTail--; 
        PlayerControl.component.RemoveTail();
        weightCube--; 
        weightCubeText.SetText(weightCube.ToString());
        
        Debug.Log(weightCube.ToString());
            if (weightCube < 1)
            {
                Destroy(gameObject);
            }
    }

    private void OnTriggerExit(Collider other)
    {
        
        
    }
}
