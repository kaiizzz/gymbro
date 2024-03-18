using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5.0f;
    private int COUNT = 0;

    [SerializeField] private GameObject bulletPrefab;


    public void doSomething() {
        Debug.Log("I am doing something");
    }
}
