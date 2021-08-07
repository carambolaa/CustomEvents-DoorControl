using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControl : MonoBehaviour
{
    private void Start()
    {
        GameEvents.current.onDoorwayTriggerEnter += OnDoorwayOpen;
        GameEvents.current.onDoorwayTriggerExit += OnDoorwayClose;
    }

    private void OnDoorwayOpen()
    {
        LeanTween.moveLocalY(gameObject, 8f, 1f).setEaseOutQuad();
    }
    private void OnDoorwayClose()
    {
        LeanTween.moveLocalY(gameObject, 3f, 1f).setEaseInQuad();
    }

    private void OnDestroy()
    {
        GameEvents.current.onDoorwayTriggerEnter -= OnDoorwayOpen;
        GameEvents.current.onDoorwayTriggerExit -= OnDoorwayClose;
    }
}
