using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerComponent : MonoBehaviour
{
    [SerializeField] private TypeOfTrigger _typeOfTrigger;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>() != null)
            return;

       // switch (_typeOfTrigger)
        
      
    }

    private enum TypeOfTrigger
    {
        DamageTrigger,
        MovingObstacleTrigger,
        SpringboardTrigger,
        FallingTrigger,
        EndOfTileTrigger

    }
}
