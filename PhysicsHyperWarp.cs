using System;
using UnityEngine;


[KSPAddon(KSPAddon.Startup.Flight, false)]
public class PhysicsHyperWarp : MonoBehaviour
{
	public void Awake() { }

	public void Start() 
	{
		print ("hey I'm starting");
		TimeWarp t = TimeWarp.fetch;
		for(int i = 0; i < t.physicsWarpRates.Length; i++) {
			print (t.physicsWarpRates[i]);
		}
		Single[] finalArray = new Single[ t.physicsWarpRates.Length + 4 ];
		for(int i = 0; i < t.physicsWarpRates.Length; i++) {
			finalArray[i] = t.physicsWarpRates[i];
		}
		finalArray[4] = 5;
		finalArray[5] = 6;
		finalArray[6] = 7;
		finalArray[7] = 8;
		t.physicsWarpRates = finalArray;

		print ("hey mission complete");
	}

}



