using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameEngine : MonoBehaviour {
    public bool gameOver = false;
    public GameObject FighterT1;
    public GameObject FighterT2;
    public GameObject ShooterT1;
    public GameObject ShooterT2;
    public GameObject TankerT1;
    public GameObject TankerT2;
    public List<GameObject> Team1 = new List<GameObject>();
    public List<GameObject> Team2 = new List<GameObject>();
    int maxX = 40;
    int minX = 2;
    int maxY = 25;
    int minY = 25;
    public float startTime = 0;
    public Text Timer;
    
    void Start () {
        startTime = Time.time;
        for (int i = 0; i < 5; i++)
        {
            GenerateMeleeUnits();
        }
        for (int i = 0; i < 5; i++)
        {
            GenerateRangeUnits();
        }
        for (int i = 0; i < 3; i++)
        {
            GenerateTanker();
        }
        InvokeRepeating("SpawnUnitsTeam1", 0f, 5f);
        InvokeRepeating("SpownUnitsTeam2", 0f, 5f);
    }
	
	// Update is called once per frame
	void Update () {
        float t = Time.time - startTime;

        string minutes = ((int)t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        Timer.text = "Time " + minutes + ":" + seconds;
        

    }
    void GenerateMeleeUnits()
    {
        if (!gameOver)
        {
            GameObject T1 = (GameObject)Instantiate(FighterT1);
            int x = UnityEngine.Random.Range(-maxX, -minX);
            int y = UnityEngine.Random.Range(-maxY, minY);
            T1.transform.position = new Vector3(x, y, 1);
            SpriteRenderer sprite = T1.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T1.GetComponent<Fighter>().team = 0;
            Team1.Add(T1);
        }
        if (!gameOver)
        {
            GameObject T2 = (GameObject)Instantiate(FighterT2);
            int x = UnityEngine.Random.Range(maxX, minX);
            int y = UnityEngine.Random.Range(-maxY, minY);
            T2.transform.position = new Vector3(x, y, 1);
            SpriteRenderer sprite = T2.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T2.GetComponent<Fighter>().team = 1;
            Team2.Add(T2);
        }
    }
    void GenerateRangeUnits()
    {
        if (!gameOver)
        {
            GameObject T1 = (GameObject)Instantiate(ShooterT1);
            int x = UnityEngine.Random.Range(-maxX, minX);
            int y = UnityEngine.Random.Range(-maxY, maxY);
            T1.transform.position = new Vector3(x, y, 1);
            SpriteRenderer sprite = T1.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T1.GetComponent<Shooter>().team = 0;
            Team1.Add(T1);
        }
        if (!gameOver)
        {
            GameObject T2 = (GameObject)Instantiate(ShooterT2);
            int x = UnityEngine.Random.Range(maxX, -minX);
            int y = UnityEngine.Random.Range(-maxY, maxY);
            T2.transform.position = new Vector3(x, y, 1);
            SpriteRenderer sprite = T2.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T2.GetComponent<Shooter>().team = 1;
            Team2.Add(T2);
        }
    }
    void GenerateTanker()
    {
        if (!gameOver)
        {
            GameObject T1 = (GameObject)Instantiate(TankerT1);
            int x = UnityEngine.Random.Range(-maxX, minX);
            int y = UnityEngine.Random.Range(-maxY, maxY);
            T1.transform.position = new Vector3(x, y, 1);
            SpriteRenderer sprite = T1.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T1.GetComponent<Tanker>().team = 0;
            Team1.Add(T1);
        }
        if (!gameOver)
        {
            GameObject T2 = (GameObject)Instantiate(TankerT2);
            int x = UnityEngine.Random.Range(maxX, -minX);
            int y = UnityEngine.Random.Range(-maxY, maxY);
            T2.transform.position = new Vector3(x, y, 1);
            SpriteRenderer sprite = T2.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T2.GetComponent<Tanker>().team = 1;
            Team2.Add(T2);
        }
    }
    void SpawnUnitsTeam1()
    {
        int z = UnityEngine.Random.Range(1, 4);
        if (!gameOver && z == 1)
        {
            GameObject T1 = (GameObject)Instantiate(FighterT1);
            T1.transform.position = new Vector3(-37f, -8.5f, 1);
            SpriteRenderer sprite = T1.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T1.GetComponent<Fighter>().team = 0;
            Team1.Add(T1);
        }
        else if (!gameOver && z == 2)
        {
            GameObject T12 = (GameObject)Instantiate(ShooterT1);
            T12.transform.position = new Vector3(-37f, -8.5f, 1);
            SpriteRenderer sprite = T12.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T12.GetComponent<Shooter>().team = 0;
            Team1.Add(T12);
        }
        else if (!gameOver && z == 3)
        {
            GameObject T13 = (GameObject)Instantiate(TankerT1);
            T13.transform.position = new Vector3(-37f, -8.5f, 1);
            SpriteRenderer sprite = T13.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T13.GetComponent<Tanker>().team = 0;
            Team1.Add(T13);
        }
    }
    void SpownUnitsTeam2()
    {
        int A = UnityEngine.Random.Range(1, 4);
        if (!gameOver && A==1 )
        {
            GameObject T2 = (GameObject)Instantiate(FighterT2);
            T2.transform.position = new Vector3(37f, 10.5f, 1);
            SpriteRenderer sprite = T2.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T2.GetComponent<Fighter>().team = 1;
            Team2.Add(T2);
        }
        else if (!gameOver && A == 2)
        {
            GameObject T22 = (GameObject)Instantiate(ShooterT2);
            T22.transform.position = new Vector3(37f, 10.5f, 1);
            SpriteRenderer sprite = T22.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T22.GetComponent<Shooter>().team = 1;
            Team2.Add(T22);
        }
        else if (!gameOver && A == 3)
        {
            GameObject T23 = (GameObject)Instantiate(TankerT2);
            T23.transform.position = new Vector3(37f, 10.5f, 1);
            SpriteRenderer sprite = T23.GetComponent<SpriteRenderer>();
            sprite.sortingLayerName = "units";
            T23.GetComponent<Tanker>().team = 1;
            Team2.Add(T23);
        }
    }
 }
