
using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;


public class Bonus : MonoBehaviour
{
    public int weightBonus; // Вес шара
    public TextMeshPro weightBonusText;
    
    private void Start()
    {
        weightBonus = Random.Range(1, 6);
        weightBonusText.SetText(weightBonus.ToString());
   
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (CompareTag("Bonus"))
        {
            
           // gameObject.SetActive(false);
            for (int i = 0; i < weightBonus; i++)
            {
                PlayerControl.component.AddTail();
                PlayerControl.lengthTail++;
            }
            weightBonus = 0;
            
            Destroy(gameObject);
            
        }
    }
}
