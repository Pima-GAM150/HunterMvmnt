using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    public void ResetRot()
    {
        rotateSphereXAxis.find.ResetRot();
        rotateSphereZAxis.find.ResetRot();
    }
}
