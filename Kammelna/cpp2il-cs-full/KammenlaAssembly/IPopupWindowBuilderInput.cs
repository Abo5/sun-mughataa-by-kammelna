using System;
using UnityEngine;

public interface IPopupWindowBuilderInput
{
	IPopupWindowBuilderInput WithIcon(Sprite icon);

	IPopupWindowBuilderInput WithPlaceholder(string placeholder);

	IPopupWindowBuilderInput WithPlaceholder(LocalizableText placeholder);

	IPopupWindowBuilderInput SetCallback(Action<string> callback);

	PopupWindowInputData Build();
}
