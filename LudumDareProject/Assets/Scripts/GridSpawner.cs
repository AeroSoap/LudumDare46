using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Josh

public class GridSpawner : MonoBehaviour {

	public GameObject Camera;
	public GameObject Grid;

	// Start is called before the first frame update
	void Start() {
		for(int i = -2; i <= 2; i++) {
			for(int j = -2; j <= 2; j++) {
				GridMover grid = Instantiate(Grid, new Vector3(0, 0), Quaternion.identity).GetComponent<GridMover>();
				grid.Init(i, j, Camera);
			}
		}
	}
}
