using UnityEngine;
using System.Collections;

public class HelloWorldGreeterScript : MonoBehaviour {

    public bool isWaving;

    private Animator _animator; 
	// Use this for initialization
	void Start () {

        _animator = GetComponent<Animator>();
        
    }
	
	// Update is called once per frame
	void Update () {

        _animator.SetBool("isWaving", isWaving);
    }


    public void OnRayCastHit(Vector3 vector)
    {

        
          isWaving = !isWaving;

        if(isWaving)
        {
            var audio = GetComponent<AudioSource>();
            audio.Play(15000);
        }

    }

}
