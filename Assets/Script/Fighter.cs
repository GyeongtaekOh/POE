using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MeleeUnit
{

    // Use this for initialization
    void Start() {
        SetGameEngine();
        speed = 3;
        health = 5;
        attackSpeed = 5;
        //if(team == 0)
        //{
        //    health1 = 5;
        //    health2 = 100;
        //}
        //else if (team == 1)
        //{
        //    health2 = 5;
        //    health1 = 100;
        //}
        //health = 5;
        attackRange = 0;
        damage = 1;
    }

    // Update is called once per frame
    void Update() {
        unitMove();

    }
    
}

