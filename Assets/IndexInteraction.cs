using UnityEngine;
using System.Collections;
using Leap.Unity;
public class IndexInteraction : MonoBehaviour {

	public ControllerScript controller;

	private void LeftMouseClick(){
		ColoringScript script = this.GetComponent<ColoringScript>();
		if(script && controller){
			controller.setCurrentSelected (script);
		}
	}

	void OnTriggerEnter(Collider col){
        FingerModel finger = col.gameObject.GetComponentInParent<FingerModel>();
        if (finger)
        {
            //Debug.Log ("Finger " + finger.fingerType);
            if (finger.fingerType == Leap.Finger.FingerType.TYPE_INDEX)
            {
                Debug.Log("Colouring Zone Touched");
                LeftMouseClick();
            }
        }
    }
}
