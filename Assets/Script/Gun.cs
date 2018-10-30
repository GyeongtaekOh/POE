using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {
    public GameObject Bullets;
    float range = 8F;
    GameObject Enemy;
    GameEngine GE;
    // Use this for initialization
    void Start () {
        GE = GameObject.Find("GameEngine").GetComponent<GameEngine>();
        Enemy =  GameObject.Find("Team2R");
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void FireEnemyBullet()
    {
        if (!GE.gameOver)
        {
            float distance = Vector2.Distance(transform.position, Enemy.transform.position);
            if (Enemy != null && distance <= range)
            {
                GameObject bullet = (GameObject)Instantiate(Bullets);
                SpriteRenderer sprite = bullet.GetComponent<SpriteRenderer>();
                sprite.sortingLayerName = "units";
                bullet.transform.position = transform.position;
                Vector2 diraction = Enemy.transform.position - bullet.transform.position;
                bullet.GetComponent<Bullet>().SetDirection(diraction);
            }
        }
    }
}
