using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System.Runtime.InteropServices; // important


public class SendMessageToReact : MonoBehaviour
{

    // start react unity web gl
    [DllImport("__Internal")]
    private static extern void ButtonClicked (int count);
    // end react unity web gl

    private int count = 0;
    

    public GameObject btn_go;


    // Start is called before the first frame update
    void Start()
    {   
        Button btn = btn_go.GetComponent<UnityEngine.UI.Button>();
		btn.onClick.AddListener(SendMessageToReactJS);
    }

    void SendMessageToReactJS(){
        count = count+1;
        print("send message to react");
        print(count);
        #if UNITY_WEBGL == true && UNITY_EDITOR == false
            ButtonClicked(count);
        #endif
	}
}
