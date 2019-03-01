using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour {

	// Explicit command for auxilary GameObjects w/o a designated script
	void Awake () {
        DontDestroyOnLoad(gameObject);
	}
}
