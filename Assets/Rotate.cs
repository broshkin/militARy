using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public GameObject camera;
    public float x;
    public float y;
    public float z;
    float r;
    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.FindGameObjectWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
        var lol = camera.transform.rotation * Quaternion.Euler(x, y, z);
        float AngleX = Mathf.SmoothDampAngle(transform.eulerAngles.x, lol.eulerAngles.x, ref r, 0.02f);
        float AngleY = Mathf.SmoothDampAngle(transform.eulerAngles.y, lol.eulerAngles.y, ref r, 0.02f);
        float AngleZ = Mathf.SmoothDampAngle(transform.eulerAngles.z, lol.eulerAngles.z, ref r, 0.02f);
        transform.rotation = Quaternion.Euler(AngleX, AngleY, AngleZ);
    }
}
