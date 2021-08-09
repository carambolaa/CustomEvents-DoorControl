using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public static class UnityEvents
{
    public static UnityEvent openDoor = new UnityEvent();
    public static UnityEvent closeDoor = new UnityEvent();
    public static MyEvent Door = new MyEvent();
}

public class MyEvent : UnityEvent<int> { }
