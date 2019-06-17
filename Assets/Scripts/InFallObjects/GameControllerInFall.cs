using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControllerInFall : MonoBehaviour
{

    public GameObject Soul;
    public GameObject Hazard;
    public Transform SoulSpawnPoint;
    public Transform HazardSpawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        SpawnWaves();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnWaves()
    {
        Instantiate(Soul, SoulSpawnPoint.position, Quaternion.identity);
        Instantiate(Hazard, HazardSpawnPoint.position, Quaternion.identity);
    }

}
