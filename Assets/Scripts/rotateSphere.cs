using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSphere : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Rotate(new Vector3(Time.deltaTime * 5, 0f,0f));
        if (Input.GetKey(KeyCode.RightArrow)) transform.Rotate(new Vector3(Time.deltaTime * -5, 0f, 0f));
        if (Input.GetKey(KeyCode.UpArrow)) transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * -5));
        if (Input.GetKey(KeyCode.DownArrow)) transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * 5));
    }
}
