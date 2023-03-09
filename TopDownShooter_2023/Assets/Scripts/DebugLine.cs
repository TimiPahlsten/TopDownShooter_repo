using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugLine : MonoBehaviour
{

    private float q = 0.0f;

    void Update()
    {
        // always draw a 5-unit colored line from the origin
        Color color = new Color(q, q, 1.0f);
        Debug.DrawLine(Vector3.zero, new Vector3(0, 15, 0), color);
        q = q + 0.01f;

        if (q > 1.0f)
        {
            q = 0.0f;
        }
    }

}
