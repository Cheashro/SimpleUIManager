using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenuView : UIWindowView {

	public UILabel title;
	public UIButton nextMenu;
	public UIButton popWindow;

	void Start()
	{
		title.text = "Menu 1";

		UILabel nextLabel = nextMenu.gameObject.GetComponentInChildren<UILabel>();
		UILabel popLabel = popWindow.gameObject.GetComponentInChildren<UILabel>();
		nextLabel.text = "Next Window";
		popLabel.text = "Pop Winsow";
	}
}
