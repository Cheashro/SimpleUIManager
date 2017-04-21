using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWarningView : UIWindowView
{
	public UILabel title;
	public UILabel content;
	public UIButton ok;

	void Start()
	{
		title.text = "Warning";
		content.text = "This Warning Window.";
		UILabel btnLabel = ok.gameObject.GetComponentInChildren<UILabel>();
		btnLabel.text = "OK";
	}
}
