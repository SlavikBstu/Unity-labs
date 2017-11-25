using UnityEngine;

public class DontDestroyAudio : MonoBehaviour {

	void Awake()
    {
        DontDestroyOnLoad(transform.gameObject); 
    }
}
