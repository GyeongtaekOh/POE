using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buildings : MonoBehaviour {
    public int health { get; set; }
    public int team { get; set; }
    public GameObject lifebar;
    public GameEngine GE;
    public Units Uni;

    // Use this for initialization
    void Start () {
        GE = GameObject.Find("GameEngine").GetComponent<GameEngine>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    //private void OnCollisionStay2D(Collision2D collision)
    //{
    //    //Debug.Log(time);
    //    if (team == 1)
    //    {
    //        if (collision.gameObject.tag == "Team1Units")
    //        {
    //            //InvokeRepeating("takeDamage", 0f, attackSpeed);

    //            collision.gameObject.GetComponent<Units>().takeDamage(damage);
    //            //takeDamage();
    //        }
    //    }
    //    else if (team == 0)
    //    {
    //        if (collision.gameObject.tag == "Team2Units")
    //        {

    //            //InvokeRepeating("takeDamage", 0f, attackSpeed);
    //            collision.gameObject.GetComponent<Units>().takeDamage(damage);
    //            //takeDamage();
    //        }
    //    }
    //}
    public void takeDamage(int damageToGive)
    {
        health -= damageToGive;
        lifebar.transform.localScale = new Vector3(health, 1, 1);

        if (health <= 0)
        {
            Destroy(gameObject);
            if (team == 1)
            {
                GE.Team2.Remove(gameObject);
            }
            else if (team == 0)
            {
                GE.Team1.Remove(gameObject);
            }
        }
    }
}