using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWarningCtrl : UIWindowCtrl
{

	UIWarningView view = null;

	// UIWindowCtrl Setup
	public override void OnShow()
	{
		if (view == null)
		{
			view = windowManager.GetWindowView<UIWarningView>("UIWarning");
			view.ok.onClick.Add(new EventDelegate(OnOK));
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
	void OnOK()
	{
		// Remove self
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
