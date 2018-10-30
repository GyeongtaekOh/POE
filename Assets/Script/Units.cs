using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Units : MonoBehaviour {

    public int speed { get; set; }
    public int health { get; set; }

    public int attackSpeed { get; set; }
    //public int health1 { get; set; }
    //public int health2 { get; set; }
    public int fullhealth { get; set; }
    public string unitType { get; set; }
    public int attackRange { get; set; }
    public int damage { get; set; }
    public int defence { get; set; }
    public int team { get; set; }
    //public bool lastDirection { get; set; }
    public GameObject closest { get; set; }
    public GameEngine GE;
    public GameObject lifebar;
    public GameObject BuildingTarget;
    public bool destoy = true;
    // Use this for initialization

    void Start () {
    }
	
	// Update is called once per frame
	void Update () {

    }

    public void SetGameEngine()
    {
        GE = GameObject.Find("GameEngine").GetComponent<GameEngine>();
    }
    public  Units()
    {

    }
    protected void attact()
    {

    }
   
    public void Newtarget()
    {
        List <GameObject> EnemyUnits;
        if (team == 1)
        {
            EnemyUnits = GE.Team1;
        }
        else
        {
            EnemyUnits = GE.Team2;
        }

        closest = EnemyUnits[0];

        foreach (GameObject newT in EnemyUnits)
        {
            if (Vector2.Distance(transform.position, closest.transform.position) > Vector2.Distance (transform.position,newT.transform.position))
            {
                closest = newT;
            }
        }
    }
    public void unitMove()
    {
        try
        {
            
            if (Vector2.Distance(transform.position, closest.transform.position) > attackRange)
            {
                transform.position = Vector2.MoveTowards(transform.position, closest.transform.position, speed * Time.deltaTime);
                //lastDirection = true;
            }
        }
        catch
        {
            Newtarget();
        }
    }
    public void takeDamage(int damageToGive)
    {
        health -= damageToGive;
        lifebar.transform.localScale = new Vector3(health, 1, 1);

        if (health <=0)
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
            Newtarget();
        }
    }
}

