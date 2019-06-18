using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControllerInFall : MonoBehaviour
{

    public GameObject soul;
    public GameObject hazard;
    public Transform soulSpawnPoint;
    public Transform hazardSpawnPoint;
    public Text soulsText;

    // Start is called before the first frame update
    void Start()
    {
        SpawnWaves();
    }

    // Update is called once per frame
    void Update()
    {
        soulsText.text = "Souls: " + PlayerStats.GetSouls();
    }

    public void SpawnWaves()
    {
        Instantiate(soul, soulSpawnPoint.position, Quaternion.identity);
        Instantiate(hazard, hazardSpawnPoint.position, Quaternion.identity);
    }

}
