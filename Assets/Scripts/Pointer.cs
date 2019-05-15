using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Pointer : MonoBehaviour
{
    public Transform center;

    private int sceneIndex;

    private void Start()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
}

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(center);
        Vector3 target = new Vector3(rotateSphereZAxis.find.GetCameraZ().x,0f, rotateSphereXAxis.find.GetCameraX().z);
        transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime);

        RaycastHit currentHit;
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out currentHit, Mathf.Infinity, LayerMask.GetMask("Default")) && Input.GetMouseButtonDown(0))
        {
            if (currentHit.collider.gameObject.tag == "Win") SceneManager.LoadScene(sceneIndex + 1); 
        }
    }
}
