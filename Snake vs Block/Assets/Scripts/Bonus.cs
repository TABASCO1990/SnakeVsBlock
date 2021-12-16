
using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

public class Bonus : MonoBehaviour
{
    public TextMeshPro PointsText;
    public TextMeshPro weightBonusText;
    
    [SerializeField] private int weightBonus;

    private void Start()
    {
        PointsText.SetText(PlayerControl.lengthTail.ToString());
        weightBonus = Random.Range(1, 6);
        weightBonusText.SetText(weightBonus.ToString());
    }

    private void OnTriggerEnter(Collider other)
    {
       
        if (CompareTag("Bonus"))
        {
            gameObject.SetActive(false);
            for (int i = 0; i < weightBonus; i++)
            {
                PlayerControl.component.AddTail();
                PlayerControl.lengthTail++;
                PointsText.SetText(PlayerControl.lengthTail.ToString());
            }
            weightBonus = 0;
            Destroy(gameObject);
        }
    }
}
