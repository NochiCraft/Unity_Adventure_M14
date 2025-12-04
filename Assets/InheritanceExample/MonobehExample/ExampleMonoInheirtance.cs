using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleMonoInheirtance : MonoBehaviour
{
    void Start()
    {
        //MonoBehaviourClass monoBehaviourClass = new MonoBehaviourClass(10);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
            gameObject.AddComponent<MonoBehaviourClass>();
    }
}
