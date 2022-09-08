
using System;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.InputSystem.InputAction;



public class Player : MonoBehaviour
{
    
    public PlayerControls Controls;
    public InputAction Test;         
    public float time;    
   
    
    


    
    public static bool IsGrounded { get; internal set; }
    public float speed = 10f;
    private float Speedturns = 15f;
    
    internal static object position;

    private void Awake()
    {
        Controls = new PlayerControls();
    }
   

    private void OnEnable()
    {
       Controls.ActionMap.Enable();      
              
       
    }   

    


    void Update()
    {

        transform.Translate (Vector3.forward * speed * Time.deltaTime);   
        


        {
            time += Time.deltaTime;
                                   
                var value = Controls.ActionMap.Movement.ReadValue<Vector2>();

            transform.position += new Vector3(value.x, 0, value.y)* Speedturns * Time.deltaTime;
        }
        {           

            if (Input.GetKey(KeyCode.Space))
             transform.Translate(new Vector3(0, 0.1f, 0));             


        }

          
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }


}
