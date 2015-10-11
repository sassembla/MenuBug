using UnityEngine;
using UnityEditor;

public class SampleWindow : EditorWindow {

	[MenuItem("SampleWindow/Open")]
	public static void Open () {
		GetWindow<SampleWindow>();
	}

	void OnGUI () {
		if (Event.current.type == EventType.ValidateCommand) {
		    Debug.Log("event fired:" + Event.current.commandName);
		}
	}
}
