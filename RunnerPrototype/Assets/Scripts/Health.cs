using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //[SerializeField] public float Hp = 3;
   // public float Hp = 3;


   
    private void Update()
    {
       /* if(transform.position.y <= -2)
        {
            Death();
        }*/
    }

    private void Death()
    {
        //Destroy(gameObject);
        UnityEditor.EditorApplication.isPaused = true;
    }
}
