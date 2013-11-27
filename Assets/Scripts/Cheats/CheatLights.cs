﻿using UnityEngine;
using System.Collections;

public class CheatLights:MonoBehaviour {
	public string[] cheat;

	private int index = 0;

	void Update() {
		if(Input.anyKeyDown) {
			if(Input.GetKeyDown(cheat[index])) {
				index++;
			} else {
				index = 0;
			}
		}	

		if(index == cheat.Length) {
			Light light = GameObject.Find("Main Light").GetComponent<Light>();

			if(light.intensity == 0.1f) {
				light.intensity = 1;
			} else if(light.intensity == 1) {
				light.intensity = 0.1f;
			}

			index = 0;
		}
	}
}
