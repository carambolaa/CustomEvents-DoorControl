using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UEtriggerArea : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEvents.openDoor.Invoke();
    }
    public void OnTriggerExit(Collider other)
    {
        UnityEvents.closeDoor.Invoke();
    }
}
