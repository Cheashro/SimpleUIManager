using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenu2View : UIWindowView
{

	public UILabel title;
	public UIButton back;

	void Start()
	{
		title.text = "Menu 2";

		UILabel backLabel = back.gameObject.GetComponentInChildren<UILabel>();
		backLabel.text = "Back";
	}
}
