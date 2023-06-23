using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoQuaternion : MonoBehaviour
{
    public float angle = 0f;
    public float speedRotate = 3f;
    private void Update()
    {
        angle += Time.deltaTime * speedRotate;
        Vector3 up = new Vector3(0, 1, 0);
        up.Normalize();
        // float w = Mathf.Cos(angle * Mathf.Deg2Rad / 2);
        // Vector3 qv = up * Mathf.Sin(angle * Mathf.Deg2Rad / 2);
        // Quaternion q = new Quaternion(qv.x, qv.y, qv.z, w);
        // transform.rotation = q;

        // transform.rotation = Quaternion.AngleAxis(angle, up);
        transform.rotation = Quaternion.Euler(new Vector3(0, angle, 0));
    }
}
