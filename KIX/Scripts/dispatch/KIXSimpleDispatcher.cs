﻿/**
 *  KIX Simple Dispatcher
 *  KIX Event dispatcher which fires when Unity
 *  calls 'Start' on this MonoBehaviour.
 *  
 *  @author : Robin Kollau
 *  @version: 1.0.0
 *  @date   : 20 March 2020  
 * 
 */
using UnityEngine;
[AddComponentMenu("[ KIX ] /Dispatchers/KIX_Simple_Dispatcher")]
public class KIXSimpleDispatcher : KIXDispatcher
{
    //user defined event type to dispatch at Start.
    public KIXScriptableEventType event_obj;
    [KIXDefinedType] public string EventType = "";

    /// <summary>
    /// Start
    /// Fired by Unity
    /// Fires a KIXEvent with type of EventType
    /// </summary>
    void Start()
    {
        FireKIXEvent(new KIXEvent(EventType));
    }
}
