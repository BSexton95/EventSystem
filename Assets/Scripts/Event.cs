using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Event")]
public class Event : ScriptableObject
{
    //All Listerers for this event
    private List<IListener> _listeners;

    /// <summary>
    /// Add a new listener for this even
    /// </summary>
    /// <param name="listener">A reference to the listener object</param>
    public void AddListener(IListener listener)
    {
        if (_listeners == null)
            _listeners = new List<IListener>();

        _listeners.Add(listener);
    }

    /// <summary>
    /// Raises the event and invokes all listeners
    /// </summary>
    /// <param name="sender">The game object that raised this event</param>
    public void Raise(GameObject sender = null)
    {
        //Return if there are no listeners for this event
        if (_listeners == null)
            return;


        ///Tell each listener in the list to perform whaterver action they're waiting to do.
        foreach (IListener listener in _listeners)
        {
            listener.Invoke(sender);
        }
    }
}
