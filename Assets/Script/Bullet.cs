using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    float speed = 10f;
    Vector3 _direction;
    bool isReady;
    public Units Enemy;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isReady)
        {
            Vector3 position = transform.position;

            position += _direction * speed * Time.deltaTime;
            position.z = 1;

            transform.position = position;

            //Vector2 min = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 1));
            //Vector2 max = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 1));

            //if ((transform.position.x < min.x) || (transform.position.x > max.x) || (transform.position.y < min.y) || (transform.position.y > max.y))
            //{
            //    Destroy(gameObject);
            //}
        }
    }
    void Awake()
    {
        isReady = false;
        GameObject temp = GameObject.FindGameObjectWithTag("Team2Units");
        Enemy = temp.GetComponent<Units>();
    }
    public void SetDirection(Vector2 direction)
    {
        _direction = direction.normalized;
        isReady = true;
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Team2Units")
        {
            Destroy(gameObject);
            //Enemy.takeDamage();
        }
    }
}
