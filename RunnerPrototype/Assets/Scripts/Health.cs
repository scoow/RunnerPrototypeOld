using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    //[SerializeField] public float Hp = 3;
   // public float Hp = 3;


    private void OnTriggerEnter(Collider other)
    {
        TriggerComponent triggerComponent = other.GetComponent<TriggerComponent>();
        if (triggerComponent != null) // 
        {
            GameManager.instance.DecreaseHP();
            Debug.Log("-1HP");

            if(GameManager.instance._hp <= 0)
            {
                Debug.Log("YOU LOST");
                Death();
            }

        }
    }
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
