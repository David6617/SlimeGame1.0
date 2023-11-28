using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flyStrength;
    public LogicScript logic;
    public bool SlimeLife = true;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && SlimeLife == true)
        {
            myRigidbody.velocity = Vector2.up * flyStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        SlimeLife = false;
    }
}
