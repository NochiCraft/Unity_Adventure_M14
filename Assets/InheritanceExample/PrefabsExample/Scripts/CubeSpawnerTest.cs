using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawnerTest : MonoBehaviour
{
    [SerializeField] private GameObject _cubeTestPrefab;
    private GameObject _cubeTest;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            _cubeTest = Instantiate(_cubeTestPrefab);
            
            SetStartedValues();
        }

        if (Input.GetKey(KeyCode.W))
        {
            if (_cubeTest != null)
            {
                _cubeTest.transform.position += new Vector3(0, 0, 1);
            }     
        }

        if (Input.GetKey(KeyCode.Q))
        {
            if (_cubeTest != null)
            {
                _cubeTest.transform.Rotate(0, -1, 0);
            }        
        }
    }
    private void SetStartedValues()
    {
        _cubeTest.transform.position = new Vector3(0, 0, 0);
        _cubeTest.transform.rotation = Quaternion.Euler(0, 90, 0);
        _cubeTest.transform.localScale = new Vector3(2, 2, 2);
    }

}
