using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement3SCR : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector3 vec = new Vector3(2, 0, 0);
        transform.Translate(vec);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec2 = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0);
        transform.Translate(vec2);
    }
}
