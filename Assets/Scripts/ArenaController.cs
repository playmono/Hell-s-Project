using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaController : MonoBehaviour
{
    public List<GameObject> arenas = new List<GameObject>();

    private GameObject currentArena;
    private List<GameObject> arenasLeft = new List<GameObject>();

    private void Start()
    {
        this.nextArena();
    }

    private void Update()
    {
        if (Input.GetKeyUp("space")) {
            this.nextArena();
        }
    }

    private void LoadArena(GameObject arena)
    {
        GameObject.Destroy(this.currentArena);
        this.currentArena = Instantiate(arena, new Vector2(0.0f, 0.0f), Quaternion.identity);
        this.arenasLeft.Remove(arena);
    }

    private void nextArena()
    {
        if (this.arenasLeft.Count == 0) {
            foreach (GameObject arena in arenas) {
                this.arenasLeft.Add(arena);
            }
        }

        GameObject randomArena = this.arenasLeft[Random.Range(0, this.arenasLeft.Count)];

        this.LoadArena(randomArena);
    }
}
