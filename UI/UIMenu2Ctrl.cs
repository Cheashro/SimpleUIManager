using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMenu2Ctrl : UIWindowCtrl
{

	UIMenu2View view = null;

	// UIWindowCtrl Setup
	public override void OnShow()
	{
		if (view == null)
		{
			view = windowManager.GetWindowView<UIMenu2View>("UIMenu2");
			view.back.onClick.Add(new EventDelegate(OnBack));
		}
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
		// Pop Window
		windowManager.PopWindow();
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
