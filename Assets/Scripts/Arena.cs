using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arena : MonoBehaviour
{
	public GameObject miniboss;
	public GameObject bigEnemy;
	public GameObject smallEnemy;
	public GameObject debufferEnemy;

    private List<GameObject> enemies = new List<GameObject>();

    private void Start()
    {
        for (int i = 0; i < 3; i++) {
            GameObject instantiated = Object.Instantiate(bigEnemy, new Vector2(0.0f, 0.0f), Quaternion.identity);
        	this.enemies.Add(instantiated);
        }

        for (int i = 0; i < 2; i++) {
            GameObject instantiated = Object.Instantiate(smallEnemy, new Vector2(0.0f, 0.0f), Quaternion.identity);
            this.enemies.Add(instantiated);
        }

        for (int i = 0; i < 1; i++) {
            GameObject instantiated = Object.Instantiate(miniboss, new Vector2(0.0f, 0.0f), Quaternion.identity);
            this.enemies.Add(instantiated);
        }

        for (int i = 0; i < 1; i++) {
            GameObject instantiated = Object.Instantiate(debufferEnemy, new Vector2(0.0f, 0.0f), Quaternion.identity);
            this.enemies.Add(instantiated);
        }
    }

    private void Update()
    {
        
    }

    private void OnDestroy()
    {
        foreach (GameObject enemy in this.enemies) {
            Object.Destroy(enemy);
        }

        Object.Destroy(this.gameObject);
    }
}
