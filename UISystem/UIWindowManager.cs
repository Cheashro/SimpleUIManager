using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum WindowLayer {
	Background = 0,
	Normal = 1,
	Top = 2,
}

public class UIWindowManager : Singleton<UIWindowManager> {

	GameObject uiBase = null;
	Stack<UIWindowCtrl> windowStack = null;

	public void Initialize() {
		uiBase = CreateUIBase();
		windowStack = new Stack<UIWindowCtrl>();
	}

	public T ShowWindow<T>(bool hasBackground = false) where T : UIWindowCtrl
	{
		// Get Window Controller and Call Controller Show
		T controller = null;
		if (!gameObject.TryGetComponent<T>(out controller))
			controller = gameObject.AddComponent<T>();
		controller.OnShow();

		// Hide Top Window
		if (!hasBackground && windowStack.Count > 0)
		{
			UIWindowCtrl topWindow = windowStack.Peek();
			topWindow.OnHide();
		}

		// Push Window into stack
		windowStack.Push(controller);

		return controller;
	}

	public void HideWindow<T>() where T : UIWindowCtrl
	{
		T controller = null;
		if (gameObject.TryGetComponent<T>(out controller))
			controller.OnHide();
	}

	public void RemoveWindow<T>() where T : UIWindowCtrl
	{
		T controller = null;
		if (gameObject.TryGetComponent<T>(out controller))
		{
			controller.Destroy();
			windowStack.RemoveItem<UIWindowCtrl>(controller);
		}
	}

	public void PopWindow()
	{
		// Remove Top Window
		UIWindowCtrl controller = windowStack.Pop();
		if (controller != null)
			controller.Destroy();
		// Call New Top Window Show
		controller = windowStack.Peek();
		controller.OnShow();
	}

	public T GetWindowView<T>(string windowName) where T : UIWindowView
	{
		GameObject prefab = Resources.Load(Path.Combine("UI/", windowName)) as GameObject;
		Debug.Assert(prefab != null, string.Format("{0} is not a validity prefab.", windowName));
		GameObject windowObj = NGUITools.AddChild(uiBase, prefab);
		return windowObj.GetComponent<T>();
	}

	GameObject CreateUIBase()
	{
		GameObject ui = GameObject.Instantiate(Resources.Load("UI/UIBase")) as GameObject;
		return ui;
	}
}
