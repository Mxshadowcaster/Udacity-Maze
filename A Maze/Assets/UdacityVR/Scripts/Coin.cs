using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

	
	// TODO: Create variables to reference the game objects we need access to
	// Declare a GameObject named 'coinPoofPrefab' and assign the 'CoinPoof' prefab to the field in Unity
	public GameObject coinPoof;
	

	// void Update () {
	// 	// OPTIONAL-CHALLENGE: Animate the coin rotating
	// 	// TIP: You could use a method from the Transform class
	// }


	public void OnCoinClicked () {
			Debug.Log ("OnCoinClicked was called");
		
			if (gameObject != null) {
			/// Called when the 'Coin' game object is clicked
			Instantiate(coinPoof, transform.position, Quaternion.Euler(-90, 0, 0));
			/// - Displays a poof effect (handled by the 'CoinPoof' prefab)
			
			/// - Plays an audio clip (handled by the 'CoinPoof' prefab)
			Destroy(gameObject);
			/// - Removes the coin from the scene
			}
			
		
		
			// Prints to the console when the method is called

			// TODO: Display the poof effect and remove the coin from the scene
			// Use Instantiate() to create a clone of the 'CoinPoof' prefab at this coin's position and with the 'CoinPoof' prefab's rotation
			// Use Destroy() to delete the coin after for example 0.5 seconds
		}

		
	}

