using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorBehaviour : MonoBehaviour
{
    private MeshRenderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    public void ChangeColor()
    {
        _renderer.material.color = Color.red;
    }
}
