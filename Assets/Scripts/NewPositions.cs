using UnityEngine;
using System.Collections;

public class NewPosition : MonoBehaviour {

    public Vector2 posiButton;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        posiButton.x = gameObject.transform.position.x;
        posiButton.y = gameObject.transform.position.y;
    }
}
