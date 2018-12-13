using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fist : MonoBehaviour {

    protected bool clicked;
    public GameObject body;
    public GameObject fist;
    public float positionX;
    public float positionY;
    public float positionZ;
    protected float x;
    void Start () 
    {
        clicked = false;
        x = 0;
        positionX = 0;
        positionY = 0;
        positionZ = 0;
}
	
	void Update () 
    {
        if (Input.GetMouseButton(0) && clicked == false)
        {
            x = 0;
            clicked = true;
        }
        if (Input.GetMouseButton(1) && clicked == true)
        {
            transform.position -= transform.forward * x;
            clicked = false;
            fist.transform.parent = body.transform;
            positionX = body.transform.position.x;
            positionY = body.transform.position.y;
            positionZ = body.transform.position.z;
            fist.transform.position = new Vector3(0.6f, 0.1f, 0.97f);
            fist.transform.rotation = new Quaternion(0, 0, 0, 0);
        }
        if (clicked == true)
        {
            transform.position += transform.forward * 0.1F;
            x += 0.1F;
            fist.transform.parent = null;
        }
    }
}
