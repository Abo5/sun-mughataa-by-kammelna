using System;
using System.Buffers.Text;
using System.Collections.Generic;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

public class PopupWindowBuilder : IPopupWindowBuilderNeedsTitle, IPopupWindowBuilderNeedsBody, IPopupWindowBuilderAttributes
{
	private PopupWindowData _instance;

	public static IPopupWindowBuilderNeedsTitle CreateInfo(Action action = null, string buttonText = "OK")
	{
		PopupWindowBuilder popupWindowBuilder = CreateBuilder(PopupWindow.MessageType.Info);
		PopupButton button = PopupButton.Neutral(buttonText, action, dismiss: true);
		if (popupWindowBuilder != null)
		{
			return (IPopupWindowBuilderNeedsTitle)popupWindowBuilder.AddButton(button);
		}
		return (IPopupWindowBuilderNeedsTitle)new NullReferenceException();
	}

	public static PopupWindowBuilder CreateError(Action action = null, string buttonText = "OK")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		PopupWindowBuilder popupWindowBuilder = CreateBuilder(PopupWindow.MessageType.Error);
		if (popupWindowBuilder != null)
		{
			object text = "Drop Menu Toggle" + 3600;
			LocalizableText localizableText = TextMeshProExtensions.Localize((string)text);
			if (popupWindowBuilder._instance != null)
			{
				object text2 = "Index = {0} position = {1}" + 1736;
				object obj = popupWindowBuilder._instance + 24;
				obj = localizableText;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				LocalizableText localizableText2 = TextMeshProExtensions.Localize((string)text2);
				if (popupWindowBuilder._instance != null)
				{
					object obj2 = popupWindowBuilder._instance + 32;
					obj2 = localizableText2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					PopupButton button = PopupButton.Neutral(buttonText, action, dismiss: true);
					return (PopupWindowBuilder)popupWindowBuilder.AddButton(button);
				}
			}
		}
		return (PopupWindowBuilder)(object)new NullReferenceException();
	}

	public static void ShowError(string title, string content)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_02e1: Expected O, but got I
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0094: Expected I, but got O
		//IL_00a4: Expected O, but got I
		//IL_013a: Expected I, but got O
		//IL_00df: Expected O, but got I
		//IL_0170: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Expected O, but got Unknown
		//IL_017d: Expected I, but got O
		//IL_018d: Expected O, but got I
		//IL_022b: Expected O, but got I
		//IL_023d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Expected O, but got Unknown
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_0258: Expected I, but got O
		//IL_027c: Expected O, but got I4
		//IL_01c8: Expected O, but got I
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_01d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01db: Expected O, but got Unknown
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7968]");
		nint num = 0;
		object buttonText = "Network Authentication Required" + 3128;
		object obj4 = default(object);
		object obj5 = default(object);
		NullReferenceException ex = default(NullReferenceException);
		object obj12 = default(object);
		object obj17 = default(object);
		while (true)
		{
			PopupWindowBuilder popupWindowBuilder = CreateError(null, (string)buttonText);
			nint num2;
			if (popupWindowBuilder != null)
			{
				LocalizableText localizableText = TextMeshProExtensions.Localize(title);
				if (popupWindowBuilder._instance != null)
				{
					object obj = typeof(System.IOAsyncCallback) + 384;
					object obj2 = popupWindowBuilder._instance + 24;
					obj2 = localizableText;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					num2 = (nint)popupWindowBuilder;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+12E]");
					object obj3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0128;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v7 (Il2CppClass<PopupWindowBuilder>)+B0]");
					obj4 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X10_v12-8]");
						if (0 == (nint)obj)
						{
							break;
						}
						obj5 = obj4 + 16;
						obj3--;
						bool flag = (nint)obj3 != 1;
						obj4 = obj5;
						if (flag)
						{
							continue;
						}
						goto IL_0128;
					}
					goto IL_0235;
				}
			}
			goto IL_0292;
			IL_0292:
			ex = new NullReferenceException();
			goto IL_02a0;
			IL_02a0:
			object obj6 = obj5 + 9;
			object obj7 = num + obj6;
			object obj8 = obj7 + 312;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X8_v5+8]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v171 @ X2_v2 (should have been resolved before IL gen)");
			continue;
			IL_0209:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			object obj11 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v12+8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v188 @ X2_v6 (should have been resolved before IL gen)");
			goto IL_0235;
			IL_0235:
			object obj14 = num2 + obj4;
			object obj15 = obj14 + 312;
			num = (nint)obj15;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v262 @ X0_v18] (should have been resolved before IL gen)");
			bool flag2 = ex == null;
			object obj16 = !flag2;
			obj5 = obj4;
			if (obj16 != null)
			{
				goto IL_0161;
			}
			goto IL_0292;
			IL_0128:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num = (nint)obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v247 @ X0_v15] (should have been resolved before IL gen)");
			if (ex != null)
			{
				goto IL_0161;
			}
			goto IL_0292;
			IL_0161:
			object obj18 = typeof(System.IOAsyncCallback) + 368;
			num = (nint)ex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+12E]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X8_v3 (Il2CppClass<System.NullReferenceException>)+B0]");
				obj5 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v9-8]");
					if (0 == (nint)obj18)
					{
						break;
					}
					obj5 += 16;
					obj19--;
					if ((nint)obj19 != 1)
					{
						continue;
					}
					goto IL_0209;
				}
				goto IL_02a0;
			}
			goto IL_0209;
		}
	}

	public static IPopupWindowBuilderNeedsTitle CreateConfirm(Action confirmAction, string confirmText = "Confirm", string cancelText = "Cancel")
	{
		PopupWindowBuilder popupWindowBuilder = CreateBuilder(PopupWindow.MessageType.Action);
		PopupButton button = PopupButton.Positive(confirmText, confirmAction);
		if (popupWindowBuilder != null)
		{
			IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.AddButton(button);
			PopupButton button2 = PopupButton.Neutral(cancelText, null, dismiss: true);
			return (IPopupWindowBuilderNeedsTitle)popupWindowBuilder.AddButton(button2);
		}
		return (IPopupWindowBuilderNeedsTitle)new NullReferenceException();
	}

	public static IPopupWindowBuilderNeedsTitle CreatePurchase(Action confirmAction, int price, string confirmText = "Buy", string cancelText = "Cancel")
	{
		PopupWindowBuilder popupWindowBuilder = CreateBuilder(PopupWindow.MessageType.Action);
		PopupButton button = PopupButton.Purchase(confirmText, confirmAction, dismiss: false, price);
		if (popupWindowBuilder != null)
		{
			IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.AddButton(button);
			PopupButton button2 = PopupButton.Neutral(cancelText, null, dismiss: true);
			return (IPopupWindowBuilderNeedsTitle)popupWindowBuilder.AddButton(button2);
		}
		return (IPopupWindowBuilderNeedsTitle)new NullReferenceException();
	}

	public static PopupWindowBuilder CreateNegativeConfirm(Action confirmAction, string confirmText = "Yes", string cancelText = "Cancel")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		PopupWindowBuilder popupWindowBuilder = CreateBuilder(PopupWindow.MessageType.Action);
		if (popupWindowBuilder != null)
		{
			object text = "Complete" + 256;
			LocalizableText localizableText = TextMeshProExtensions.Localize((string)text);
			if (popupWindowBuilder._instance != null)
			{
				object text2 = "Added Tournament Prizes And Features" + 2208;
				object obj = popupWindowBuilder._instance + 24;
				obj = localizableText;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				LocalizableText localizableText2 = TextMeshProExtensions.Localize((string)text2);
				if (popupWindowBuilder._instance != null)
				{
					object obj2 = popupWindowBuilder._instance + 32;
					obj2 = localizableText2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					PopupButton button = PopupButton.Neutral(cancelText, null, dismiss: true);
					IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.AddButton(button);
					PopupButton button2 = PopupButton.Negative(confirmText, confirmAction, dismiss: true);
					return (PopupWindowBuilder)popupWindowBuilder.AddButton(button2);
				}
			}
		}
		return (PopupWindowBuilder)(object)new NullReferenceException();
	}

	public static PopupWindowBuilder CreateNegativeConfirmWithNegativeAction(Action confirmAction, Action dismissAction, string confirmText = "Yes", string cancelText = "Cancel")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0065: Expected O, but got Unknown
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		PopupWindowBuilder popupWindowBuilder = CreateBuilder(PopupWindow.MessageType.Action);
		if (popupWindowBuilder != null)
		{
			object text = "Complete" + 256;
			LocalizableText localizableText = TextMeshProExtensions.Localize((string)text);
			if (popupWindowBuilder._instance != null)
			{
				object text2 = "Added Tournament Prizes And Features" + 2208;
				object obj = popupWindowBuilder._instance + 24;
				obj = localizableText;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				LocalizableText localizableText2 = TextMeshProExtensions.Localize((string)text2);
				if (popupWindowBuilder._instance != null)
				{
					object obj2 = popupWindowBuilder._instance + 32;
					obj2 = localizableText2;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					PopupButton button = PopupButton.Neutral(cancelText, dismissAction, dismiss: true);
					IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.AddButton(button);
					PopupButton button2 = PopupButton.Negative(confirmText, confirmAction, dismiss: true);
					return (PopupWindowBuilder)popupWindowBuilder.AddButton(button2);
				}
			}
		}
		return (PopupWindowBuilder)(object)new NullReferenceException();
	}

	public static IPopupWindowBuilderNeedsTitle CreatePrompt(IPopupWindowBuilderInput inputData, string primaryText = "OK")
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		PopupWindowBuilder popupWindowBuilder = CreateBuilder(PopupWindow.MessageType.Action);
		PopupButton button = PopupButton.Positive(primaryText);
		if (popupWindowBuilder != null)
		{
			object label = "COORDINATE_TYPE_GCJ_02" + 1864;
			IPopupWindowBuilderAttributes popupWindowBuilderAttributes = popupWindowBuilder.AddButton(button);
			PopupButton button2 = PopupButton.Neutral((string)label, null, dismiss: true);
			IPopupWindowBuilderAttributes popupWindowBuilderAttributes2 = popupWindowBuilder.AddButton(button2);
			return (IPopupWindowBuilderNeedsTitle)((PopupWindowBuilder)popupWindowBuilderAttributes2).WithInput(inputData);
		}
		return (IPopupWindowBuilderNeedsTitle)new NullReferenceException();
	}

	private static PopupWindowBuilder CreateBuilder(PopupWindow.MessageType type)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1448;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj3 = default(object);
		obj3..ctor();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		PopupWindowData popupWindowData = default(PopupWindowData);
		popupWindowData..ctor();
		if (popupWindowData != null)
		{
			popupWindowData.type = type;
			if (obj3 != null)
			{
				object obj4 = obj3 + 16;
				obj4 = popupWindowData;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				return (PopupWindowBuilder)obj3;
			}
		}
		return (PopupWindowBuilder)(object)new NullReferenceException();
	}

	public static IPopupWindowBuilderNeedsTitle Create(PopupWindow.MessageType type)
	{
		return CreateBuilder(type);
	}

	public IPopupWindowBuilderNeedsBody Titled(LocalizableText title)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		if (_instance != null)
		{
			object obj = _instance + 24;
			obj = title;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return this;
		}
		return (IPopupWindowBuilderNeedsBody)new NullReferenceException();
	}

	public IPopupWindowBuilderNeedsBody Titled(string title)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		LocalizableText localizableText = TextMeshProExtensions.Localize(title);
		if (_instance != null)
		{
			object obj = _instance + 24;
			obj = localizableText;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return this;
		}
		return (IPopupWindowBuilderNeedsBody)new NullReferenceException();
	}

	public IPopupWindowBuilderAttributes WithContent(LocalizableText body)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		if (_instance != null)
		{
			object obj = _instance + 32;
			obj = body;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return this;
		}
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
	}

	public IPopupWindowBuilderAttributes WithContent(string body)
	{
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		LocalizableText localizableText = TextMeshProExtensions.Localize(body);
		if (_instance != null)
		{
			object obj = _instance + 32;
			obj = localizableText;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return this;
		}
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
	}

	public IPopupWindowBuilderAttributes AddButton(PopupButton button)
	{
		//IL_00a5: Expected O, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		PopupWindowData instance = _instance;
		if (_instance != null)
		{
			List<object> buttons = (List<object>)(object)instance.buttons;
			if (instance.buttons != null)
			{
				int version = buttons._version + 1;
				buttons._version = version;
				object[] items = buttons._items;
				if (buttons._items != null)
				{
					bool flag = buttons._size < items.Length;
					object obj = !flag;
					if (obj == null)
					{
						int size = buttons._size + 1;
						buttons._size = size;
						object obj2 = buttons._items + buttons._size;
						object obj3 = obj2 + 32;
						obj3 = button;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						return this;
					}
					((List<object>)(object)instance.buttons).AddWithResize((object)button);
					return this;
				}
			}
		}
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
	}

	public IPopupWindowBuilderAttributes AddExtraContent(GameObject content)
	{
		//IL_00a5: Expected O, but got I4
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		PopupWindowData instance = _instance;
		if (_instance != null)
		{
			List<object> extraContent = (List<object>)(object)instance.extraContent;
			if (instance.extraContent != null)
			{
				int version = extraContent._version + 1;
				extraContent._version = version;
				object[] items = extraContent._items;
				if (extraContent._items != null)
				{
					bool flag = extraContent._size < items.Length;
					object obj = !flag;
					if (obj == null)
					{
						int size = extraContent._size + 1;
						extraContent._size = size;
						object obj2 = extraContent._items + extraContent._size;
						object obj3 = obj2 + 32;
						obj3 = content;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						return this;
					}
					((List<object>)(object)instance.extraContent).AddWithResize((object)content);
					return this;
				}
			}
		}
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
	}

	public IPopupWindowBuilderAttributes WithTheme(PopupWindow.Theme theme)
	{
		PopupWindowData instance = _instance;
		if (_instance != null)
		{
			instance.theme = theme;
			return this;
		}
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
	}

	public IPopupWindowBuilderAttributes WithVerticalButtons()
	{
		PopupWindowData instance = _instance;
		if (_instance != null)
		{
			instance.buttonsOrientation = LinearLayoutGroup.Orientation.Vertical;
			return this;
		}
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
	}

	public IPopupWindowBuilderAttributes WithGridButtons(int columns = 2, float buttonHeight = 120f)
	{
		PopupWindowData instance = _instance;
		if (_instance != null)
		{
			instance.buttonsLayout = PopupWindowData.ButtonsLayout.Grid;
			instance.gridButtonColumns = columns;
			instance.gridButtonHeight = buttonHeight;
			return this;
		}
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
	}

	public IPopupWindowBuilderAttributes WithSound(GenericSoundAlbumTrack track)
	{
		PopupWindowData instance = _instance;
		System.Int32Enum? sound = (System.Int32Enum)track;
		if (_instance != null)
		{
			instance.sound = (GenericSoundAlbumTrack?)sound;
			return this;
		}
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
	}

	public IPopupWindowBuilderAttributes WithInput(InputField.ContentType type, LocalizableText placeholder, Action<string> callback = null, Sprite icon = null)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0153: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		LocalizableText placeholder2 = default(LocalizableText);
		IPopupWindowBuilderInput popupWindowBuilderInput = PopupInput.From(type, callback, placeholder2, icon);
		if (popupWindowBuilderInput != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 376;
			nint num = (nint)popupWindowBuilderInput;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X8_v6 (Il2CppClass<IPopupWindowBuilderInput>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 4;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v125 @ X8_v10] (should have been resolved before IL gen)");
			bool flag = _instance == null;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_00e0;
			}
		}
		goto IL_0161;
		IL_0161:
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
		IL_00e0:
		object obj8 = _instance + 88;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return this;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v144 @ X0_v10] (should have been resolved before IL gen)");
		if (_instance != null)
		{
			goto IL_00e0;
		}
		goto IL_0161;
	}

	public IPopupWindowBuilderAttributes WithInput(IPopupWindowBuilderInput inputData)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0021: Expected I, but got O
		//IL_0031: Expected O, but got I
		//IL_006c: Expected O, but got I
		//IL_00eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f0: Expected O, but got Unknown
		//IL_010d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0112: Expected O, but got Unknown
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_012d: Expected O, but got Unknown
		//IL_0153: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008d: Expected O, but got Unknown
		if (inputData != null)
		{
			object obj = typeof(System.IOAsyncCallback) + 376;
			nint num = (nint)inputData;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v6 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v6 (Il2CppClass<IPopupWindowBuilderInput>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00ad;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v6 (Il2CppClass<IPopupWindowBuilderInput>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X10_v6-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj3 += 16;
				obj2--;
				if ((nint)obj2 != 1)
				{
					continue;
				}
				goto IL_00ad;
			}
			object obj4 = obj3 + 4;
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v191 @ X0_v12] (should have been resolved before IL gen)");
			bool flag = _instance == null;
			object obj7 = !flag;
			if (obj7 != null)
			{
				goto IL_00e0;
			}
		}
		goto IL_0161;
		IL_0161:
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
		IL_00e0:
		object obj8 = _instance + 88;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return this;
		IL_00ad:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v129 @ X0_v9] (should have been resolved before IL gen)");
		if (_instance != null)
		{
			goto IL_00e0;
		}
		goto IL_0161;
	}

	public IPopupWindowBuilderAttributes DisabledPrimaryButton()
	{
		PopupWindowData instance = _instance;
		if (_instance != null)
		{
			instance.disabledPrimaryButton = true;
			return this;
		}
		return (IPopupWindowBuilderAttributes)new NullReferenceException();
	}

	public void Show()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00cc: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7972]");
		object obj2 = (nint)0 & (nint)1;
		PopupWindowData instance;
		PopupWindowData instance2;
		if (obj2 != null)
		{
			instance = _instance;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			instance2 = _instance;
			if (!flag)
			{
				goto IL_0088;
			}
		}
		else
		{
			_ = 1;
			instance = _instance;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v1+E4]");
			bool flag2 = (nint)0 == 0;
			object obj4 = !flag2;
			instance2 = _instance;
			if (obj4 != null)
			{
				goto IL_0088;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PopupWindow.Show(instance2);
		return;
		IL_0088:
		PopupWindow.Show(instance);
	}
}
