using System;
using System.Buffers.Text;
using Cpp2ILInjected;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class SettingsSoundSection : MonoBehaviour
{
	private Toggle gameSoundToggle;

	private Toggle actorsToggle;

	private Toggle chatSoundToggle;

	private Toggle musicSoundToggle;

	private Toggle SFXSoundToggle;

	private ToggleGroup voiceActors;

	private bool _originalActors;

	private bool _originalChatSound;

	private bool _originalMusicSound;

	private bool _originalSFXSound;

	private void Start()
	{
		PopulateToggles();
	}

	private void PopulateToggles()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_004e: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_0093: Expected I, but got O
		//IL_00c5: Expected O, but got I
		//IL_00dd: Expected I, but got O
		//IL_010f: Expected O, but got I
		//IL_0127: Expected I, but got O
		//IL_0159: Expected O, but got I
		//IL_0171: Expected I, but got O
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		//IL_018a: Expected O, but got Unknown
		//IL_01c6: Expected O, but got I4
		Toggle toggle = actorsToggle;
		object obj = typeof(TypeConverter<ushort, char>) + 360;
		object obj2 = (nint)0 + (nint)3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction = default(UnityAction<bool>);
		unityAction..ctor((object)this, (IntPtr)obj2);
		object obj3 = (nint)0 + (nint)832;
		toggle.onValueChanged.AddListener(unityAction);
		Toggle toggle2 = gameSoundToggle;
		object obj4 = (nint)0 + (nint)3328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction2 = default(UnityAction<bool>);
		unityAction2..ctor((object)this, (IntPtr)obj4);
		toggle2.onValueChanged.AddListener(unityAction2);
		Toggle toggle3 = chatSoundToggle;
		object obj5 = (nint)0 + (nint)3320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction3 = default(UnityAction<bool>);
		unityAction3..ctor((object)this, (IntPtr)obj5);
		toggle3.onValueChanged.AddListener(unityAction3);
		Toggle toggle4 = musicSoundToggle;
		object obj6 = (nint)0 + (nint)3336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction4 = default(UnityAction<bool>);
		unityAction4..ctor((object)this, (IntPtr)obj6);
		toggle4.onValueChanged.AddListener(unityAction4);
		Toggle sFXSoundToggle = SFXSoundToggle;
		object obj7 = (nint)0 + (nint)3344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<bool> unityAction5 = default(UnityAction<bool>);
		unityAction5..ctor((object)this, (IntPtr)obj7);
		object obj8 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		sFXSoundToggle.onValueChanged.AddListener(unityAction5);
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v19+E4]");
		bool flag = (nint)0 == 0;
		object obj10 = !flag;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		bool multipleVoiceActors = Preferences.MultipleVoiceActors;
		actorsToggle.isOn = multipleVoiceActors;
		bool chatSound = Preferences.ChatSound;
		chatSoundToggle.isOn = chatSound;
		bool backgroundMusic = Preferences.BackgroundMusic;
		musicSoundToggle.isOn = backgroundMusic;
		bool sFXSound = Preferences.SFXSound;
		SFXSoundToggle.isOn = sFXSound;
		bool gameSound = Preferences.GameSound;
		gameSoundToggle.isOn = gameSound;
	}

	private void GameSoundToggleChanged(bool isOn)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_0133: Expected O, but got I4
		//IL_0179: Expected O, but got I4
		//IL_02ab: Expected O, but got I
		//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ed: Expected O, but got Unknown
		//IL_02f6: Expected O, but got I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_031e: Expected O, but got I
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E68BC]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v17+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.GameSound = isOn;
		Toggle toggle = actorsToggle;
		bool flag2 = !isOn;
		object obj5 = !flag2;
		Toggle toggle2 = actorsToggle;
		if (obj5 != null)
		{
			goto IL_00aa;
		}
		goto IL_0191;
		IL_0343:
		Toggle sFXSoundToggle;
		bool isOn2;
		sFXSoundToggle.isOn = isOn2;
		actorsToggle.interactable = isOn;
		chatSoundToggle.interactable = isOn;
		musicSoundToggle.interactable = isOn;
		SFXSoundToggle.interactable = isOn;
		object obj6 = (nint)0 + (nint)760;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31C20");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v7+18]");
		if ((nint)0 >= (nint)1)
		{
			object obj8 = default(object);
			object obj7 = obj8 + 32;
			object obj9 = 0;
			object obj10;
			do
			{
				obj9++;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X22_v4+v164 @ X21_v6*8]");
				((Selectable)0).interactable = isOn;
				obj10 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X0_v7+18]");
			}
			while ((nint)obj10 < 0);
		}
		return;
		IL_00aa:
		toggle.isOn = _originalActors;
		chatSoundToggle.isOn = _originalChatSound;
		musicSoundToggle.isOn = _originalMusicSound;
		sFXSoundToggle = SFXSoundToggle;
		isOn2 = _originalSFXSound;
		goto IL_0343;
		IL_0191:
		_originalActors = toggle2.m_IsOn;
		Toggle toggle3 = chatSoundToggle;
		_originalChatSound = toggle3.m_IsOn;
		Toggle toggle4 = musicSoundToggle;
		_originalMusicSound = toggle4.m_IsOn;
		Toggle sFXSoundToggle2 = SFXSoundToggle;
		_originalSFXSound = sFXSoundToggle2.m_IsOn;
		toggle2.isOn = false;
		chatSoundToggle.isOn = false;
		musicSoundToggle.isOn = false;
		sFXSoundToggle = SFXSoundToggle;
		isOn2 = false;
		goto IL_0343;
		IL_0074:
		Preferences.GameSound = isOn;
		toggle = actorsToggle;
		bool flag3 = !isOn;
		toggle2 = actorsToggle;
		if (!flag3)
		{
			goto IL_00aa;
		}
		goto IL_0191;
	}

	private void ActorsToggleChanged(bool val)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		Toggle toggle = gameSoundToggle;
		if (toggle.m_IsOn)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				Preferences.MultipleVoiceActors = val;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Preferences.MultipleVoiceActors = val;
		}
	}

	private void ChatSoundToggleChanged(bool val)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		Toggle toggle = gameSoundToggle;
		if (toggle.m_IsOn)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				Preferences.ChatSound = val;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Preferences.ChatSound = val;
		}
	}

	private void SFXSoundToggleChanged(bool val)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		Toggle toggle = gameSoundToggle;
		if (toggle.m_IsOn)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				Preferences.SFXSound = val;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Preferences.SFXSound = val;
		}
	}

	public void MusicToggleChanged(bool val)
	{
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		Toggle toggle = gameSoundToggle;
		if (toggle.m_IsOn)
		{
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v3+E4]");
			if ((nint)0 != 0)
			{
				Preferences.BackgroundMusic = val;
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Preferences.BackgroundMusic = val;
		}
	}
}
