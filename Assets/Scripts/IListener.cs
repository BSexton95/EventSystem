using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IListener
{
    public void Invoke(GameObject sender);   
}
