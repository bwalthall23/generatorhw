using UnityEngine;
using System.Collections;

public class citygen : MonoBehaviour {

	public Transform building, streetlamp, stoplight, car, trianglebuilding;

		int buildingcount = 0;


	// Update is called once per frame
	void Update () {
		if (buildingcount < 200){
			float randomNumber = Random.Range (0f, 100f);
			if (randomNumber < 10f){
				Instantiate (streetlamp, new Vector3( Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
				             }
			else if(randomNumber < 30f && randomNumber > 10f){
				Instantiate (stoplight, new Vector3( Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
					             }
			else if(randomNumber < 50f && randomNumber >30f){
				Instantiate (car, new Vector3( Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
						             }
			else if (randomNumber <	75f && randomNumber > 50f){
				Instantiate (building, new Vector3( Random.Range (-100f, 100f), 0f, Random.Range (-100f, 100f)), Quaternion.identity);
							             }
			else if (randomNumber <100f && randomNumber > 75f){
				Instantiate (trianglebuilding, new Vector3( Random.Range (-100f, 100f), 0f, Random.Range (-100f, 2f)), Quaternion.identity);
								             }
			buildingcount += 1;
								             }
								        
	
	}
}
