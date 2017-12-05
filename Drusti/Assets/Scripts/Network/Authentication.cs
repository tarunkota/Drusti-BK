using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.Networking;
using System.Collections;

public class Authentication : MonoBehaviour {

	public InputField Username;
	public InputField password;



	// Use this for initialization
	void Start () {
		
	}
	
	public void login()
	{
		StartCoroutine(Auth());
	}



	IEnumerator Auth()
    {
	List<IMultipartFormSection> form = new List<IMultipartFormSection>();
	form.Add(new MultipartFormDataSection("username", "p@p.com"));
	form.Add(new MultipartFormDataSection("password", "a"));

	UnityWebRequest request = UnityWebRequest.Post("http://127.0.0.1:8000/api-token-auth/", form);
	request.SetRequestHeader("Accept", "application/json");
	yield return request.Send();
	Debug.Log(request.error);










		// Debug.Log("SENDING REQUEST");
       
        // // WWWForm form = new WWWForm();
        // // form.AddField( "username", "password" );
		
        
		// Dictionary<string, string> headers = form.headers;
		// headers["content-type"] = "application/json";
		
		
		// string url = "http://127.0.0.1:8000/api-token-auth/";

        // // Add a custom header to the request.
        // // In this case a basic authentication to access a password protected resource.
        // headers["Authorization"] = "Basic " + System.Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(Username.text+":"+password.text));

        // // Post a request to an URL with our custom headers
        // WWW www = new WWW(url, form.data, headers);
        // yield return www;
        // //.. process results from WWW request here...
        // //.. process results from WWW request here...
		// Debug.Log(www.text);
		// // if(www.text=="{\"detail\":\"JSON parse error - No JSON object could be decoded\"}")
		// // 	Debug.Log(www.text);
	}


	// Update is called once per frame
	void Update () {
		
	}
}
