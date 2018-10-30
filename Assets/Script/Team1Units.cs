using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team1Units : MonoBehaviour {
    //GameObject[] target;
    //GameObject[] target;
    public int speed = 3;
    int range = 6;

    // Use this for initialization
    void Start () {
        //target = GameObject.FindGameObjectsWithTag("Team1Units");
        
    }
	
	// Update is called once per frame
	void Update () {
        Findclosestunit();
        
        //target = GameObject.FindGameObjectsWithTag("Team1Units");
        //foreach (GameObject tar in target)
        //{
        //    if (Vector2.Distance(transform.position, tar.transform.position) > range)
        //    {
        //        transform.position = Vector2.MoveTowards(transform.position, tar.transform.position, speed * Time.deltaTime);
        //    }
        //}
    }
    public GameObject Findclosestunit()
    {
        GameObject[] target;
        target = GameObject.FindGameObjectsWithTag("Team1Units");
        GameObject closest = null;
        float distance = Mathf.Infinity;
        Vector2 position = transform.position;
        foreach (GameObject tar in target)
        {
            Vector2 diff = tar.transform.position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance)
            {
                closest = tar;
                distance = curDistance;
                if (Vector2.Distance(transform.position, tar.transform.position) > range)
                {
                    transform.position = Vector2.MoveTowards(transform.position, closest.transform.position, speed * Time.deltaTime);
                }
            }
        }
        
        return closest;
    }
}
