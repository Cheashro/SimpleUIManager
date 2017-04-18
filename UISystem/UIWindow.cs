using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIWindowCtrl : MonoBehaviour
{
	protected UIWindowManager windowManager = null;

	void Start()
	{
		windowManager = UIWindowManager.Instance;
	}

	public virtual void OnShow() { }

	public virtual void OnHide() { }

	public virtual void Destroy() { }

	void OnDestroy()
	{
		windowManager = null;
	}
}

public class UIWindowView : MonoBehaviour
{
	public WindowLayer UILayer = WindowLayer.Normal;
	public int UIDepth = 0;
	UIPanel panel;

	void Start()
	{
		panel = gameObject.GetComponent<UIPanel>();
		Debug.Assert(panel != null, string.Format("{0} doesn't have UIPanel.", this.name));
		panel.sortingOrder = (int)UILayer;
		panel.depth = UIDepth;
	}
}