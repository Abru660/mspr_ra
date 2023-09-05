using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class upload : MonoBehaviour
{

    public Text name;
    public Text mail;
   

    public void uploadSend()
    {
        WWWForm form = new WWWForm();
        Debug.Log("objectName " + name.text);
        form.AddField(name.GetComponent<Text>().text, mail.GetComponent<Text>().text);

        /*UnityWebRequest www = UnityWebRequest.Post("https://www.my-server.com/myform", form);
        yield return www.SendWebRequest();

        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
        }*/
    }
}
