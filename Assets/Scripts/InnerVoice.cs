using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerVoice : MonoBehaviour {

    public AudioClip WhatHappened;
    public AudioClip GoodLandingArea;

    private AudioSource audioSource;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        audioSource.clip = WhatHappened;
        audioSource.Play();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnFindClearArea()
    {
        audioSource.clip = GoodLandingArea;
        audioSource.Play();

        Invoke("CalHeli", GoodLandingArea.length + 1f);
    }

    void CalHeli()
    {
        SendMessageUpwards("OnMakeInitialHeliCall");
    }
}
