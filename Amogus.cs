using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Amogus : MonoBehaviour
{
    public int health = 100;
    public int level = 3;
    public float speed = 1.2f;
    void Start()
    {
        health += level;
        print(health);
    }
    void Update()
    {
        Vector3 newPosition;
        newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
