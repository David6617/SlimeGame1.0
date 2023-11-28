using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMIddleScript : MonoBehaviour
{
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); //finds a GameObject with the tag "logic" and just adds the component to this value basically like calling a class/object
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logic.addScore();
    }
}
