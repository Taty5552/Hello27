using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public float speed = 1.2f;
    public int level = 1;
    public int health = 5;
    void Start()
    {
        health += level;
        //новое значение здоровья NPC
        print("Жизней: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
