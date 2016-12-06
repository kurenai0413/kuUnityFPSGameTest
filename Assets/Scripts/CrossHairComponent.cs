using UnityEngine;
using System.Collections;

public class CrossHairComponent : MonoBehaviour {

    public Texture CrossHairTexture = null;

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}

    void OnApplicationFocus(bool focusState)
    {
        if (focusState)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    void OnGUI()
    {
        if (CrossHairTexture != null)
        {
            GUI.color = new Color(1, 1, 1, 0.8f);
            Rect drawRect = new Rect((Screen.width * 0.5f - CrossHairTexture.width * 0.5f),
                                     (Screen.height * 0.5f - CrossHairTexture.height * 0.5f),
                                     CrossHairTexture.width, 
                                     CrossHairTexture.height);
            GUI.DrawTexture(drawRect, CrossHairTexture);
        }
    }
}
