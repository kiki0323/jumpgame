using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turret : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Bulletshot", 0, 2f);
    }

    void Bulletshot()
    {
        Instantiate(bullet, new Vector3(Random.Range(-3,3), 4, 0), Quaternion.identity);

    }
}
