using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateSphereZAxis : MonoBehaviour
{
    public float cameraSpeed = 10f;

    private Quaternion startingRot;

    public Transform cameraPos;

    public static rotateSphereZAxis find;

    private void Awake()
    {
        startingRot = new Quaternion(transform.rotation.x,transform.rotation.y,transform.rotation.z,transform.rotation.w);
        find = this;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow)) transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * -cameraSpeed));
        if (Input.GetKey(KeyCode.DownArrow)) transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * cameraSpeed));
    }

    public Vector3 GetCameraZ()
    {
        return cameraPos.TransformPoint(cameraPos.position);
    }

    public void ResetRot()
    {
        transform.rotation = startingRot;
    }
}
