using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSphereXAxis : MonoBehaviour
{
    public float cameraSpeed = 10f;

    private Quaternion startingRot;

    public Transform cameraPos;

    public static rotateSphereXAxis find;

    private void Awake()
    {
        startingRot = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z, transform.rotation.w);
        find = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) transform.Rotate(new Vector3(Time.deltaTime * cameraSpeed, 0f,0f));
        if (Input.GetKey(KeyCode.RightArrow)) transform.Rotate(new Vector3(Time.deltaTime * -cameraSpeed, 0f, 0f));
    }

    public Vector3 GetCameraX()
    {
        return cameraPos.TransformPoint(cameraPos.position);
    }

    public void ResetRot()
    {
        transform.rotation = startingRot;
    }
}
