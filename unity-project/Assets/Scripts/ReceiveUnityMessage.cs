using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ReceiveUnityMessage : MonoBehaviour
{

   
    public GameObject text_go;



    // Start is called before the first frame update
    void Start()
    {
        text_go.GetComponent<UnityEngine.UI.Text>().text = "...";
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void UpdateMessage(string text){
        print("message received from ReactJS : ");
        print(text);
        text_go.GetComponent<UnityEngine.UI.Text>().text = text;
    }
}
