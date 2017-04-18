using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameObjectExtensionMethods{
	public static bool TryGetComponent<T>(this GameObject go, out T component)
	{
		component = go.GetComponent<T>();
		return component != null;
	}
}

public static class StackExtensionMethods
{
	public static bool RemoveItem<T>(this Stack<T> stack, T item)
	{
		if (!stack.Contains(item))
			return false;

		Stack<T> popStack = new Stack<T>();
		T popItem = default(T);
		do
		{
			popItem = stack.Pop();
			popStack.Push(popItem);
		} while (!popItem.Equals(item));

		popStack.Pop();

		for (int i = 0; i < popStack.Count; i++)
		{
			stack.Push(popStack.Pop());
		}
		return true;
	}
}
