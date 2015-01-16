using UnityEngine;
using System.Collections;
using DG.Tweening;


public class PlayerMovement : MonoBehaviour {

    public Transform playerTransform;

    public Vector2 playerPosition;
    public PositionCalculator pos;

	// Use this for initialization
	void Start () {
        GameMaster.instance.buttonPressed += movement;

	}
	
	// Update is called once per frame
	void Update () {
        playerPosition.x = playerTransform.position.x;
        playerPosition.y = playerTransform.position.y;
	}

    void movement(Vector2 v)
    {
        gameObject.transform.DOMove(v, 2f);
        
        //pos.generaPuntos();


    }

    
    IEnumerator waitFor()
    {
        yield return new WaitForSeconds(2.4f);
    }
    

    
}
