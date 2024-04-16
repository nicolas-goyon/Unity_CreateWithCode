using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFlight : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.0f;
    [SerializeField]
    private float topBound = 10.0f;

    [SerializeField]
    private bool isBottomBound = false;


    // Update is called once per frame
    void Update()
    {

        Vector3 movementDelta = speed * Time.deltaTime * Vector3.forward;
        Vector3 newPosition = transform.position + movementDelta;

        if ((newPosition.z < topBound && !isBottomBound) || (newPosition.z > topBound && isBottomBound)) { 
            transform.Translate(movementDelta);
        }
        
        if (newPosition.z > topBound && !isBottomBound) { 
            Destroy(gameObject);
        }

        if (newPosition.z < topBound && isBottomBound) {
            Destroy(gameObject);
        }
        
    }
}
