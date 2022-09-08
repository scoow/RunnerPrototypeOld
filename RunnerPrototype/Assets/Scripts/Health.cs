using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float Hp = 3;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Death")
        {
            Hp -= 1;
            Debug.Log("-1HP");

            if(Hp < 0)
            {
                Debug.Log("YOU LOST");
                Death();

            }

        }
        
    }
    private void Update()
    {
        if(transform.position.y <= -2)
        {
            Death();
        }
    }

    private void Death()
    {
        Destroy(gameObject);
        UnityEditor.EditorApplication.isPaused = true;
    }
}
