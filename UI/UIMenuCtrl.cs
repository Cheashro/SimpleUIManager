using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenuCtrl : UIWindowCtrl {

	UIMenuView view = null;

	// UIWindowCtrl Setup
	public override void OnShow()
	{
		view = windowManager.GetWindowView<UIMenuView>("UIMenu");
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
	void OnNextWindow()
	{
		// Show Next Window
		windowManager.ShowWindow<UIMenu2Ctrl>();
	}

	void OnPopWindow()
	{
		// Show Pop Window
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
