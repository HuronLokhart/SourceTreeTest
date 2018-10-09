using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour
{
    Vector3 startingPosOne;
    Vector3 startingPosTwo;
    Rigidbody2D rb2D;
    public float maxSpeed;

    void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Use this for initialization
    void Start()
    {
        startingPosOne = PlayerOneSlime.S.transform.position;
        startingPosTwo = PlayerTwoSlime.S.transform.position;
    }

    void FixedUpdate()
    {
        if (rb2D.velocity.magnitude > maxSpeed)
        {
            rb2D.velocity = rb2D.velocity.normalized * maxSpeed;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(rb2D.velocity.magnitude);
    }

 

}
