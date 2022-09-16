using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject _endText;
    [SerializeField]
    private CubeColorBehaviour _cubeColorBehaviour;

    private void OnTriggerEnter(Collider other)
    {
        _endText.SetActive(true);
        _cubeColorBehaviour.ChangeColor();
    }
}
