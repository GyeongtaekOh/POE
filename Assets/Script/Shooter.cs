using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : RangeUnit
{

	// Use this for initialization
	void Start () {
        SetGameEngine();
        speed = 1;
        health = 4;
        fullhealth = 5;
        attackRange = 0;
        damage = 2;
        attackSpeed = 5;
    }
	
	// Update is called once per frame
	void Update () {
        unitMove();
    }
}
