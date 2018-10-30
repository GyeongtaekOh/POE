using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tanker : MeleeUnit
{

	// Use this for initialization
	void Start () {
        SetGameEngine();
        speed = 2;
        health = 7;
        attackSpeed = 5;
        attackRange = 0;
        damage = 1;
    }
	
	// Update is called once per frame
	void Update () {
        unitMove();
    }
}
