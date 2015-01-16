using UnityEngine;
using System.Collections;

public class NewPositions : MonoBehaviour {

   

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        GameMaster.instance.newPosition(new Vector2(gameObject.transform.position.x, gameObject.transform.position.y));
    }
}
