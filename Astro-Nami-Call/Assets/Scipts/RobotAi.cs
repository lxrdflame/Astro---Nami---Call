using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotAi : MonoBehaviour
{
    private GameObject Players;

    public float speed = 3.0f;
    public float stoppingDistance = 2.0f;
    [SerializeField] float destroyDelay = 1f;
    // public int damageAmount = 10;
    //public playerHealth playerHealth1;
    // public CharacterController characterController;

    private Rigidbody2D rb;

    public GameObject explosion;

    SpriteRenderer sr;
    RobotAi Ai;
    private GameObject Parent;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        Ai = GetComponent<RobotAi>();
        Players = GameObject.FindGameObjectWithTag("Player");

       
    }

   

    private void Update()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, Players.transform.position);
        if (distanceToPlayer < stoppingDistance)
        {
            Vector2 direction = (Players.transform.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }

        float distanceToPlayer2 = Vector2.Distance(transform.position, Players.transform.position);
        if (distanceToPlayer2 < stoppingDistance)
        {
            Vector2 direction = (Players.transform.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime, Space.World);
        }
        Transform parentTransform = transform.parent;

        Parent = parentTransform.gameObject;


       // Parent.transform.position = transform.position;


    }
    
    

   
}
