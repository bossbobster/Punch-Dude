using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FistExplosion : MonoBehaviour {

    public GameObject fist1;
    public GameObject fist2;
    public GameObject explosion;

    void Start()
    {

    }
    void Update()
    {

    }

    private void OnCollisionStay(Collision other)
    {
        explosion.SetActive(true);
        Destroy(fist1, 0.5f);
        Destroy(fist2, 0.5f);
    }

}
