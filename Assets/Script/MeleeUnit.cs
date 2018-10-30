using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeUnit : Units
{


    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
    }
    //private void OnCollisionEnter2D(Collision2D collision)
    //{
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
    private void OnCollisionStay2D(Collision2D collision)
    {
        //Debug.Log(time);
        if (team == 1)
        {
            if (collision.gameObject.tag == "Team1Units")
            {
                //InvokeRepeating("takeDamage", 0f, attackSpeed);

                collision.gameObject.GetComponent<Units>().takeDamage(damage);
                //takeDamage();
            }
            }
        else if (team == 0)
        {
            if (collision.gameObject.tag == "Team2Units")
            {

                //InvokeRepeating("takeDamage", 0f, attackSpeed);
                collision.gameObject.GetComponent<Units>().takeDamage(damage);
                //takeDamage();
            }
        }
    }
}
