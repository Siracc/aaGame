using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveController : MonoBehaviour
{
    Rigidbody2D _rgdb;
    [SerializeField] float _speed;
    GameObject _background;
  

    private void Awake()
    {
        _rgdb = GetComponent<Rigidbody2D>();
        _background = GameObject.FindGameObjectWithTag("Background");

    }
    private void Start()
    {
        
    }

    private void FixedUpdate()
    {
        Onclick();
    }

    void Move()
    {
        _rgdb.velocity = new Vector2(0, 1 * Time.deltaTime * _speed);  
    }

    void Onclick()
    {        
        Move();        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("BigCircle"))
        {
            transform.SetParent(collision.transform);
            _speed = 0;            
        }

        if (collision.gameObject.CompareTag("SmallCircle"))
        {
            _background.GetComponent<SpriteRenderer>().color = Color.red;           
            
        }
    }    
}
