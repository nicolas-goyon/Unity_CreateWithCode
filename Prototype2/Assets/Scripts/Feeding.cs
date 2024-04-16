using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeding : MonoBehaviour
{
    [SerializeField]
    private int animalsLayer = 6;
    public void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.layer == animalsLayer) {
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
