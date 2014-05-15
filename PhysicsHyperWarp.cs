using System;
using UnityEngine;
using KSP.IO;


[KSPAddon(KSPAddon.Startup.Flight, false)]
public class PhysicsHyperWarp : MonoBehaviour
{
	public void Awake() { }

	public void Start() 
	{
		int number_of_rates, last_rate=5;
		PluginConfiguration config = PluginConfiguration.CreateForType<PhysicsHyperWarp>();

		print ("hey I'm starting");
		TimeWarp t = TimeWarp.fetch;
		for(int i = 0; i < t.physicsWarpRates.Length; i++) {
			print (t.physicsWarpRates[i]);
		}
		config.load();
		number_of_rates = config.GetValue<int>("Number of Rates", 4);
		Single[] finalArray = new Single [t.physicsWarpRates.Length + number_of_rates];
		for(int i = 0; i < t.physicsWarpRates.Length; i++) {
			finalArray[i] = t.physicsWarpRates[i];
		}
		for (int i = 0; i < number_of_rates; i++) {
			last_rate = config.GetValue<int>("Rate"+i, last_rate + 1);
			finalArray[t.physicsWarpRates.Length + i] = last_rate;
		}
		t.physicsWarpRates = finalArray;

		print ("hey mission complete");
	}

}



