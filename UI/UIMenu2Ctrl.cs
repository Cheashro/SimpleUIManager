using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenu2Ctrl : UIWindowCtrl
{

	UIMenu2View view = null;

	// UIWindowCtrl Setup
	public override void OnShow()
	{
		view = windowManager.GetWindowView<UIMenu2View>("UIMenu2");
	}

	public override void OnHide()
	{
		if (view != null && view.gameObject != null)
			Destroy(view.gameObject);
		view = null;
	}

	public override void Destroy()
	{
		if (view != null && view.gameObject != null)
			Destroy(view.gameObject);
		view = null;
	}

	// Button Event
	void OnBack()
	{
		// Show Next Window
	}

	void OnDestroy()
	{
		if (view != null)
		{
			Destroy(view.gameObject);
			view = null;
		}
	}
}
