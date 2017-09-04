using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioSystem : MonoBehaviour {

    public AudioClip initHeliCall;
    public AudioClip initHeliReply;

    private AudioSource audioSource;

    // Use this for initialization
    void Start () {
        audioSource = GetComponent<AudioSource>();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMakeInitialHeliCall()
    {
        audioSource.clip = initHeliCall;
        audioSource.Play();
        Invoke("InitialReply", initHeliCall.length + 1f);
    }


    void InitialReply()
    {
        audioSource.clip = initHeliReply;
        audioSource.Play();
        BroadcastMessage("OnDispatchHelicopter");
    }
}
