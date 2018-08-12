using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject[] ennemyPrefabs;
	public float[] probas;

	private float probaTotale = 0;
	private float timeSinceLastSpawn;
	private GameObject spawned;
	// Use this for initialization
	void Start () {
		Debug.Assert (ennemyPrefabs.Length == probas.Length);
		foreach (float p in probas)
			probaTotale += p;
	}
	
	// Update is called once per frame
	void Update () {
		timeSinceLastSpawn += Time.deltaTime;

		if (timeSinceLastSpawn > 100.0 / GameHandler.instance.currentLevel.spawnRate) {
			timeSinceLastSpawn = 0;
			float randVal = Random.value* probaTotale;
			int chosenOne = 0;
			foreach (float p in probas) {
				randVal -= p;
				if (randVal < 0)
					break;
				else
					chosenOne++;
			}
			spawned = Instantiate (ennemyPrefabs[chosenOne]);
		}
	}
}
