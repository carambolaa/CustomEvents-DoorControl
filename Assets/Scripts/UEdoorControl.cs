using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UEdoorControl : MonoBehaviour
{
    private void Awake()
    {
        UnityEvents.openDoor.AddListener(OnDoorwayOpen);
        UnityEvents.closeDoor.AddListener(OnDoorwayClose);
    }

    private void OnDoorwayOpen()
    {
        LeanTween.moveLocalY(gameObject, 8f, 1f).setEaseOutQuad();
    }
    private void OnDoorwayClose()
    {
        LeanTween.moveLocalY(gameObject, 3f, 1f).setEaseInQuad();
    }
}
