using UnityEngine;
using System.Collections;

public class EndIntroTrigger : MonoBehaviour {

	public void End() {
		SendMessageUpwards("LoadLevel");
	}
}
