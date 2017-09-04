using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public Transform playerSpawnPoints;
    public GameObject landingAreaPrefab;

    private bool reSpawn = false;
    private Transform[] spawnPoints;
    private bool lastToggle = false;
    
	void Start () {
        spawnPoints = playerSpawnPoints.GetComponentsInChildren<Transform>();
    }

    // Update is called once per frame
    void Update () {
		if (lastToggle != reSpawn)
        {
            ReSpawn();
            reSpawn = false;
        }
        else
        {
            lastToggle = reSpawn;
        }
	}

    void ReSpawn()
    {
        int i = Random.Range(1, spawnPoints.Length);

        transform.position = spawnPoints[i].transform.position;


    }

    void OnFindClearArea()
    {
        Invoke("DropFlare", 3f);
    }

    private void DropFlare()
    {
        Instantiate(landingAreaPrefab, transform.position, transform.rotation);
    }
}
