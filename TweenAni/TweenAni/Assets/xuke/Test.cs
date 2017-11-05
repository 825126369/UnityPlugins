using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
	public GameObject obj;
	public LTDescr ltd = null;
	// Use this for initialization
	void Start () {
		//obj = gameObject;
		LeanTween.init (1000);
		LTDescr ltd = LeanTween.move (obj, new Vector3 (100, 100, 0), 0.3f).setLoopPingPong ();
		//LeanTween.cancel (ltd.id);
		StartCoroutine (AAA ());

		ltd = LeanTween.value (0f, 100f, 0.5f).setLoopPingPong ().setOnUpdate ((x) => {
			obj.transform.position = new Vector3 (x, x, x);
		}).setOnCompleteOnRepeat (true).setDelay (2f);

		Debug.Log ("AAA: "+Mathf.Epsilon);
		//LeanTween.reset ();
	}

	IEnumerator AAA()
	{
		yield return new WaitForSeconds (2f);
		//LeanTween.cancel (ltd.id);
		//Destroy (obj);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Time.unscaledDeltaTime:"+Time.unscaledDeltaTime);
		Debug.Log ("Time.delatTime: " + Time.deltaTime);

	}
}
