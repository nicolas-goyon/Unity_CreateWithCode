using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropelerSpinn : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationSpeed * Time.deltaTime * Vector3.forward);
        
    }
}
