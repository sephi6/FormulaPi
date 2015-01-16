using UnityEngine;
using System.Collections;

public class GameMaster : MonoBehaviour {

    public static GameMaster instance;

    public delegate void newPositions(Vector2 v);
    public event newPositions buttonPressed;
   // public delegate void crashEvent();
  //  public event crashEvent crash;


    public Vector2 nextPosition;

	// Use this for initialization
	void Start () {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Debug.LogError("Se ha detectado más de una instancia");
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void newPosition(Vector2 v){
        nextPosition = v;
        buttonPressed(v);
    }

   // public void crashEvent(){

  //  }
    
}
