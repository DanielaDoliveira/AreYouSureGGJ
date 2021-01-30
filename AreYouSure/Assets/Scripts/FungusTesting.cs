using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class FungusTesting : MonoBehaviour
{
    private Flowchart fc;
    // Start is called before the first frame update
    void Start()
    {
        fc = GetComponent<Flowchart>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            fc.ExecuteBlock("Start");
        }

       
    }
}
