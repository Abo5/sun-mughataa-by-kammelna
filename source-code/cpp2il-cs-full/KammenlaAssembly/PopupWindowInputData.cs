using System;
using UnityEngine;
using UnityEngine.UI;

public class PopupWindowInputData
{
	public InputField.ContentType type;

	public LocalizableText placeholder;

	public Sprite icon;

	public Action<string> callback;
}
