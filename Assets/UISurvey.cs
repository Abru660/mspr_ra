using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using UnityEditor;
    public class UISurvey : MonoBehaviour
    {

        public GameObject anwers;
        //public QAClass1 formattedAnswers;
        public GameObject capture;
        public GameObject cancel;
        public Text name;
        public Text mail;

        // Start is called before the first frame update
        void Start()
        {
            //anwers = GameObject.Find("QuestionPanel");
            //formattedAnswers = new QAClass1();
            //OnOffComponent(anwers);
            anwers.SetActive(false);

        }

        // Update is called once per frame
        void Update()
        {

        }

        public static void OnOffComponent(GameObject gameObject)
        {
            if (!gameObject.activeSelf)
            {
                gameObject.SetActive(true);
            }
            else
            {
                gameObject.SetActive(false);
            }
        }

        public void onCaptureButtonClick()
        {
            OnOffComponent(anwers);
            OnOffComponent(capture);
        }

        public void onCancelClick()
        {
            OnOffComponent(anwers);
            OnOffComponent(capture);
        }

    }
/*
[System.Serializable]
public class QAClass1
{

    public string Name;

    public string Email;

    

}
*/
