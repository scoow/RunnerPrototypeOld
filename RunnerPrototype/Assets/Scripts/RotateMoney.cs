using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMoney : MonoBehaviour
{
   
    void Update()
    {
        transform.Rotate(0,0,90f * Time.deltaTime);
    }
}
