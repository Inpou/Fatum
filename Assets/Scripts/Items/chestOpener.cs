using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chestOpener : MonoBehaviour {

	private Animator _animator;
	// Use this for initialization
	void Start () {
		_animator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		_animator.SetBool("playerNear",true);
	}

	private void OnTriggerExit(Collider other)
	{
		_animator.SetBool("playerNear",false);
	}
}
