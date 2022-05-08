using UnityEngine;
using System.Collections;

public class csAnimationSpin : MonoBehaviour {

    Animator an;

	void Update () {
        an = gameObject.GetComponent<Animator>();
        //an.gameObject.GetComponent<Animator>().Play();
	}
}
