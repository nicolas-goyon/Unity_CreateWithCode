using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    private float shootDelay = 1f;

    [SerializeField]
    private GameObject bulletPrefab;

    private float lastShootTime = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        lastShootTime += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space) && lastShootTime >= shootDelay) {
            Vector3 shootingPosition = transform.position + new Vector3(0, 0.5f, 0);
            Instantiate(bulletPrefab, shootingPosition, Quaternion.identity);
            lastShootTime = 0f;
        }
        
    }
}
