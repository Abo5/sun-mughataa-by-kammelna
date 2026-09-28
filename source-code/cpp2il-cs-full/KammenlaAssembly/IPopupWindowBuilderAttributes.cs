using System;
using UnityEngine;
using UnityEngine.UI;

public interface IPopupWindowBuilderAttributes
{
	IPopupWindowBuilderAttributes AddButton(PopupButton button);

	IPopupWindowBuilderAttributes AddExtraContent(GameObject content);

	IPopupWindowBuilderAttributes DisabledPrimaryButton();

	IPopupWindowBuilderAttributes WithTheme(PopupWindow.Theme theme);

	IPopupWindowBuilderAttributes WithVerticalButtons();

	IPopupWindowBuilderAttributes WithGridButtons(int columns = 2, float buttonHeight = 120f);

	IPopupWindowBuilderAttributes WithSound(GenericSoundAlbumTrack track);

	IPopupWindowBuilderAttributes WithInput(InputField.ContentType type, LocalizableText placeholder, Action<string> callback = null, Sprite icon = null);

	IPopupWindowBuilderAttributes WithInput(IPopupWindowBuilderInput inputData);

	void Show();
}
