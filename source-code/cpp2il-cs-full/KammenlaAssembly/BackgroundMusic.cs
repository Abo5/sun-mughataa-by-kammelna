using System.Buffers.Text;
using Cpp2ILInjected;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
	private AudioSource _audioSource;

	private void Awake()
	{
		//IL_000c: Expected O, but got I
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3608;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 32;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		InitSoundState();
	}

	private void InitSoundState()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0107: Expected O, but got I4
		//IL_00bd: Expected O, but got I4
		//IL_0147: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E611A]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				goto IL_007d;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 != null)
			{
				goto IL_007d;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.GameSoundState soundState = Preferences.SoundState;
		bool flag2 = soundState == Preferences.GameSoundState.AllOn;
		object obj6 = !flag2;
		if (obj6 != null)
		{
			goto IL_00a3;
		}
		goto IL_0155;
		IL_00a3:
		bool flag3 = soundState < (Preferences.GameSoundState)3;
		object obj7 = !flag3;
		if (obj7 == null)
		{
			_audioSource.Stop();
		}
		return;
		IL_0155:
		_audioSource.Play();
		return;
		IL_007d:
		soundState = Preferences.SoundState;
		if (soundState != Preferences.GameSoundState.AllOn)
		{
			goto IL_00a3;
		}
		goto IL_0155;
	}

	public void Play()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		_audioSource.Play();
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		_audioSource.mute = false;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Preferences.BackgroundMusic = true;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.BackgroundMusic = true;
	}

	public void Pause()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		_audioSource.Pause();
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		_audioSource.mute = true;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			Preferences.BackgroundMusic = false;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.BackgroundMusic = false;
	}
}
