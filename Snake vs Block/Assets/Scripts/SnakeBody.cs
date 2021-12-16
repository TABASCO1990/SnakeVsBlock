using System.Collections.Generic;
using UnityEngine;

//Хвост змеи
public class SnakeBody : MonoBehaviour
{
    public Transform SnakeHead;
    public float CircleDiameter;
    private List<Transform> snakeCircle = new List<Transform>();
    private List<Vector3> position = new List<Vector3>();

    private void Start()
    {
        position.Add(SnakeHead.position);
    }

    private void Update()
    {
        float distance = (SnakeHead.position - position[0]).magnitude;
        
        if (distance > CircleDiameter)
        {
            // Направление от старого положения головы до нового
            Vector3 direction = (SnakeHead.position - position[0]).normalized;
            position.Insert(0,position[0]+ direction * CircleDiameter);
            position.RemoveAt(position.Count-1);
            distance -= CircleDiameter;
        }

        for (int i = 0; i < snakeCircle.Count; i++)
        {
            snakeCircle[i].position = Vector3.Lerp(position[i + 1], position[i], distance / CircleDiameter);
        }
    }

    // Добавляем к хвосту
    public void AddTail()
    {
        Transform circle = Instantiate(SnakeHead, position[position.Count - 1], Quaternion.identity,transform);
        snakeCircle.Add(circle);
        position.Add(circle.position);
    }
    // Удаляем из хвоста
    public void RemoveTail()
    {
        Destroy(snakeCircle[0].gameObject);
        snakeCircle.RemoveAt(0);
        position.RemoveAt(1);
        
    }
}
