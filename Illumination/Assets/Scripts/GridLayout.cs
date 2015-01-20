using UnityEngine;
using System.Collections;

public class GridLayout : MonoBehaviour {

	public int rows, columns;
	public GameObject cubePrefab;
	public float distanceBetweenCubes;
	// Use this for initialization
	void Start () {
		SpawnLayout ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void SpawnLayout () {
		for (int i = 0; i < rows * columns; i++) {
			int yPosition = Mathf.CeilToInt(i / columns); //returns the row into which the cube fits into
			int xPosition = i % rows; //returns which column the cube fits into
			Vector3 cubePosition = distanceBetweenCubes * (new Vector3(xPosition, 0, yPosition));
			GameObject newCube = (GameObject)Instantiate(cubePrefab, cubePosition, Quaternion.identity);
			newCube.transform.parent = transform;
		}

	}

	public void SetCamera (Camera orthoCamera){}

}
