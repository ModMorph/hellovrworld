using UnityEngine;
using System.Collections;

public class HelloWorldGreeter : MonoBehaviour {

    public bool isWaving;

    private bool _lastSetting;

    private Animator _animator; 
	// Use this for initialization
	void Start () {

        _animator = GetComponent<Animator>();
        _animator.SetBool("isWaving", isWaving);
        _lastSetting = isWaving; 
    }
	
	// Update is called once per frame
	void Update () {

        if(isWaving != _lastSetting)
        {
            _animator.SetBool("isWaving", isWaving);
            _lastSetting = isWaving; 
        }
        
    }


    public void OnRayCastHit(Vector3 vector)
    {
          isWaving = !isWaving;
    }

    public void SayHelloVRWorld()
    {
        var audio = GetComponent<AudioSource>();
        audio.Play(5000);
    }

}
