using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Text;

public class AutoChat : MonoBehaviour {

	public InputField TextContent;
	public GameObject DialogRect;
	public Text TextView;
	List<String> DialogList = new List<String> ();
	String GetReply(String input){
		return "Hello";
	}

	public void ChangeText(){
		DialogList.Add (TextContent.text);
		TextView.text += TextContent.text + "\n";
		TextContent.text = GetReply (TextContent.text);
		DialogList.Add (TextContent.text);
		TextView.text += TextContent.text + "\n";
	}

	static bool print_flag = true;
	public void PrintDialog(){
		if (print_flag) {
			DialogRect.SetActive (true);
			String DialogContent = "";
			for (int i = 0; i < DialogList.Count; i++) {
				DialogContent += DialogList [i] + "\n";
			}
			TextView.text = DialogContent;
		} else {
			DialogRect.SetActive (false);
			TextView.text = "";
		}
		print_flag = !print_flag;
	}
}
