using System;
using System.Data.SqlTypes;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Features.GameReplay;
using Kammelna.Server.Models.Clans;
using Unity.Properties;
using UnityEngine.Events;
using UnityEngine.UI;

public class MessageAddonSelector : TournamentAddonSelector
{
	private new Action m_OnValidStateChange;

	public InputField messageInput;

	public override string Title => "ThisIsFakeReceiptData" + 1304;

	public override string Subtitle => "WhiteSmoke" + 328;

	public override TournamentAddonType addonType => TournamentAddonType.Message;

	public override bool IsValid
	{
		get
		{
			//IL_00d7: Expected I4, but got O
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			InputField inputField = messageInput;
			if ((object)messageInput != null && inputField.m_Text != null)
			{
				object obj = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
				string value = inputField.m_Text.Trim();
				object obj2 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4+E4]");
				if ((nint)0 != 0)
				{
					bool flag = StringsExtensions.IsNullOrEmpty(value);
					return (byte)((flag ? 1u : 0u) ^ 1u) != 0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = StringsExtensions.IsNullOrEmpty(value);
				return (byte)((flag2 ? 1u : 0u) ^ 1u) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public override event Action OnValidStateChange
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Combine(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
		remove
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 40;
			Delegate obj3 = (Delegate)obj2;
			bool flag;
			Delegate obj5 = default(Delegate);
			do
			{
				Delegate obj4 = Delegate.Remove(obj3, value);
				if ((object)obj4 == null || obj4 == obj)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					flag = (object)obj5 == obj3;
					obj3 = obj5;
					continue;
				}
				throw new InvalidCastException();
			}
			while (!flag);
		}
	}

	private void Awake()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d0: Expected O, but got I
		//IL_00e8: Expected I, but got O
		InputField inputField = messageInput;
		object obj = typeof(GameReplayController.<OnEndRoundEventIe>d__138) + 3456;
		object obj2 = (nint)0 + (nint)1528;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		InputField.OnValidateInput onValidateInput = default(InputField.OnValidateInput);
		onValidateInput..ctor(null, (IntPtr)obj2);
		Delegate obj3 = Delegate.Combine(inputField.m_OnValidateInput, onValidateInput);
		if ((object)obj3 == null || obj3 == obj)
		{
			inputField.onValidateInput = (InputField.OnValidateInput)obj3;
			InputField inputField2 = messageInput;
			object obj4 = typeof(TypeConverter<ushort, char>) + 464;
			object obj5 = (nint)0 + (nint)2000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			UnityAction<object> unityAction = default(UnityAction<object>);
			unityAction..ctor((object)this, (IntPtr)obj5);
			((UnityEvent<object>)(object)inputField2.m_OnValueChanged).AddListener(unityAction);
			return;
		}
		throw new InvalidCastException();
	}

	public override void OnConfirm()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		InputField inputField = messageInput;
		object obj = typeof(MemberAchievementClanFeedData) + 528;
		string text = inputField.m_Text.Trim();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = text;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		eventsChannel.TriggerAddAddon((TournamentAddonModel)obj2);
	}

	public override void ShowConfirmedSelection(TournamentAddonModel tournamentAddonModel)
	{
		//IL_0100: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0029: Expected I, but got O
		//IL_0052: Expected O, but got I4
		//IL_0086: Expected O, but got I
		//IL_00bd: Expected O, but got I
		string text;
		InputField inputField;
		if (tournamentAddonModel != null)
		{
			object obj = typeof(MemberAchievementClanFeedData) + 528;
			object obj2 = obj;
			nint num = (nint)tournamentAddonModel;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v8 (Il2CppClass<TournamentAddonModel>)+130]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v5+130]");
			bool flag = num2 < 0;
			object obj3 = !flag;
			object obj4 = ~obj3;
			if (obj4 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v8 (Il2CppClass<TournamentAddonModel>)+C8]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X1_v5+130]");
				object obj5 = num3 + 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v10-8]");
				if (0 == (nint)obj2)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [tournamentAddonModel @ X1 (TournamentAddonModel)+10]");
					text = (string)0;
					inputField = messageInput;
					goto IL_00cc;
				}
			}
			throw new InvalidCastException();
		}
		inputField = messageInput;
		bool flag2 = (object)messageInput == null;
		object obj6 = !flag2;
		text = null;
		if (obj6 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00cc;
		IL_00cc:
		inputField.text = text;
	}

	public override void Clear()
	{
		messageInput.text = null;
	}

	private void <Awake>b__12_0(string _)
	{
		Action onValidStateChange = OnValidStateChange;
		if (OnValidStateChange != null)
		{
			IntPtr invoke_impl = ((Delegate)onValidStateChange).invoke_impl;
			IntPtr method_code = ((Delegate)onValidStateChange).method_code;
			IntPtr method = ((Delegate)onValidStateChange).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}
}
