using System;
using System.Buffers.Text;
using System.Data;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class TournamentPrizeSelector : MonoBehaviour
{
	private TournamentCreationPopup manager;

	private TournamentPrizeEditView prizeEditView;

	private Button firstPrizeButton;

	private Button secondPrizeButton;

	private GameObject firstPrizeAddArea;

	private GameObject firstPrizeEditArea;

	private GameObject secondPrizeAddArea;

	private GameObject secondPrizeEditArea;

	private TextMeshProUGUI firstPrizeText;

	private TextMeshProUGUI secondPrizeText;

	private GameObject firstPrizePlusIcon;

	private Image secondPrizeButtonIcon;

	private TextMeshProUGUI secondPrizeButtonLabel;

	[NonSerialized]
	public int firstPrizeAces;

	[NonSerialized]
	public int secondPrizeAces;

	private const float INACTIVE_ELEMENT_ALPHA = 0.6f;

	public int totalPrize => secondPrizeAces + firstPrizeAces;

	public int GetMinimumPrize()
	{
		//IL_0041: Expected I4, but got O
		if ((object)manager != null)
		{
			return manager.GetMinimumPrize();
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private void Start()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_003d: Expected I, but got O
		//IL_006f: Expected O, but got I
		//IL_0087: Expected I, but got O
		Button button = firstPrizeButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)1248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
		Button button2 = secondPrizeButton;
		object obj3 = (nint)0 + (nint)1256;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction2 = default(UnityAction);
		unityAction2..ctor(this, (IntPtr)obj3);
		button2.m_OnClick.AddListener(unityAction2);
		UIExtensions.SetAlpha(secondPrizeButtonIcon, 0.6f);
		UIExtensions.SetAlpha(secondPrizeButtonLabel, 0.6f);
	}

	private void FirstPrizeButtonClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_015a: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00da: Expected O, but got Unknown
		//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_01ae: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CB1]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			obj5 = prizeEditView;
			obj6 = prizeEditView;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = prizeEditView;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = prizeEditView;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		if (obj8 != null)
		{
			goto IL_00c6;
		}
		goto IL_01c1;
		IL_00c6:
		object obj11 = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 1200;
		object obj12 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v22+E4]");
		if ((nint)0 != 0)
		{
			Debug.LogError(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.LogError(message);
		return;
		IL_01c1:
		prizeEditView.Populate(this, TournamentPrizeEditView.TournamentPrize.FirstPrize);
		TournamentPrizeEditView tournamentPrizeEditView = prizeEditView;
		tournamentPrizeEditView.popup.PopFromCenter();
		tournamentPrizeEditView.acesPrizeInput.Select();
		return;
		IL_0091:
		bool flag5 = obj5 == null;
		bool flag6 = !flag5;
		obj9 = 0;
		obj10 = null;
		if (!flag6)
		{
			goto IL_00c6;
		}
		goto IL_01c1;
	}

	private void SecondPrizeButtonClicked()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0168: Expected O, but got I4
		//IL_00b3: Expected O, but got I4
		//IL_00c1: Expected O, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0295: Expected O, but got I4
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_01b3: Expected O, but got I4
		//IL_01bc: Expected O, but got I4
		//IL_01ca: Expected O, but got I4
		//IL_02bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c1: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6CB2]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = prizeEditView;
			obj6 = prizeEditView;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = prizeEditView;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = prizeEditView;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 == null;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		object obj9 = 0;
		UnityEngine.Object obj10 = null;
		object obj11 = 0;
		UnityEngine.Object obj12 = null;
		if (obj8 != null)
		{
			goto IL_00d4;
		}
		goto IL_01dd;
		IL_00d4:
		object obj13 = typeof(DataRelation) + 856;
		object message = "___# Content push apply failed [{0}]: {1}" + 1200;
		object obj14 = obj13;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X0_v32+E4]");
		if ((nint)0 != 0)
		{
			Debug.LogError(message);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Debug.LogError(message);
		return;
		IL_01dd:
		if (firstPrizeAces != 0)
		{
			prizeEditView.Populate(this, TournamentPrizeEditView.TournamentPrize.SecondPrize);
			TournamentPrizeEditView tournamentPrizeEditView = prizeEditView;
			tournamentPrizeEditView.popup.PopFromCenter();
			tournamentPrizeEditView.acesPrizeInput.Select();
			return;
		}
		object obj15 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object obj16 = obj15;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X0_v2+E4]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		if (obj17 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object message2 = "startPosition" + 3952;
		PopupWindow.ShowError((string)message2);
		return;
		IL_0091:
		bool flag6 = obj5 == null;
		bool flag7 = !flag6;
		obj9 = 0;
		obj10 = null;
		obj11 = 0;
		obj12 = null;
		if (!flag7)
		{
			goto IL_00d4;
		}
		goto IL_01dd;
	}

	public unsafe void OnPrizeChanged()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_059d: Expected O, but got I4
		//IL_0046: Expected I, but got O
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_0132: Expected O, but got I4
		//IL_01df: Expected O, but got I4
		//IL_0175: Expected I, but got O
		//IL_01a7: Expected O, but got I4
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_0205: Unknown result type (might be due to invalid IL or missing references)
		//IL_020a: Expected O, but got Unknown
		//IL_02ab: Expected O, but got I4
		//IL_02b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b8: Expected I4, but got Unknown
		//IL_0608: Expected O, but got I4
		//IL_031a: Expected F8, but got I4
		//IL_063d: Expected F4, but got I4
		//IL_0646: Expected O, but got I4
		//IL_0377: Expected F4, but got I4
		//IL_0380: Expected O, but got I4
		//IL_03dd: Expected F4, but got I4
		//IL_03e6: Expected O, but got I4
		//IL_0443: Expected F4, but got I4
		//IL_044c: Expected O, but got I4
		//IL_0498: Expected F4, but got I4
		//IL_04a1: Expected O, but got I4
		//IL_0526: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 3400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		object obj2 = 153100288 + 1024;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
		object[] array = default(object[]);
		bool flag = array == null;
		int num = default(int);
		bool flag2 = (byte)(&num) != 0;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		bool flag5;
		if (!flag)
		{
			object obj3 = default(object);
			bool flag3 = obj3 == null;
			flag2 = (byte)(&num) != 0;
			if (!flag3)
			{
				nint num2 = (nint)array;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
				flag2 = false;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				bool flag4 = ex == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X8_v17 (Il2CppClass<System.Object[]>)+40]");
				flag5 = false;
				if (flag4)
				{
					goto IL_056d;
				}
			}
			if (array.Length == 0)
			{
				goto IL_0557;
			}
			object text = "utf-32" + 3856;
			object obj4 = array + 32;
			obj4 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			LocalizableText text2 = TextMeshProExtensions.LocalizeWith((string)text, array);
			TextMeshProExtensions.Localize(firstPrizeText, text2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object[] array2 = default(object[]);
			bool flag6 = array2 == null;
			object obj5 = 0;
			int num3 = default(int);
			flag2 = (byte)(&num3) != 0;
			if (!flag6)
			{
				object obj6 = default(object);
				bool flag7 = obj6 == null;
				flag2 = (byte)(&num3) != 0;
				if (!flag7)
				{
					nint num4 = (nint)array2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
					flag2 = false;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag8 = ex == null;
					obj5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v256 @ X8_v16 (Il2CppClass<System.Object[]>)+40]");
					flag5 = false;
					if (flag8)
					{
						goto IL_056d;
					}
				}
				bool flag9 = array2.Length == 0;
				obj5 = 0;
				if (flag9)
				{
					goto IL_0557;
				}
				object text3 = "utf-32" + 3864;
				object obj7 = array2 + 32;
				obj7 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				LocalizableText text4 = TextMeshProExtensions.LocalizeWith((string)text3, array2);
				TextMeshProExtensions.Localize(secondPrizeText, text4);
				bool flag10 = secondPrizeAces < 0;
				bool flag11 = secondPrizeAces == 0;
				int num5 = secondPrizeAces ^ secondPrizeAces;
				int num6 = secondPrizeAces & num5;
				bool flag12 = num6 < 0;
				bool flag13 = flag10 == flag12;
				object obj8 = !flag11;
				bool flag14 = (byte)((flag13 & obj8) ? 1 : 0) != 0;
				bool flag15 = firstPrizeAces == 0;
				bool flag16 = !flag15;
				bool flag17 = firstPrizeAces != 0 && flag14;
				double num7 = ((firstPrizeAces != 0) ? 1.0 : 1058642330.0);
				bool flag18 = !flag17;
				object obj9 = !flag18;
				if (obj9 == null)
				{
					secondPrizeAces = 0;
				}
				bool flag19 = (object)firstPrizeEditArea == null;
				double num8 = 1.0;
				float num9 = 1.0586423E+09f;
				obj5 = 0;
				flag2 = flag16;
				if (!flag19)
				{
					firstPrizeEditArea.SetActive(flag16);
					bool flag20 = (object)firstPrizeAddArea == null;
					num8 = 1.0;
					num9 = 1.0586423E+09f;
					obj5 = 0;
					flag2 = flag16;
					if (!flag20)
					{
						bool flag21 = firstPrizeAces == 0;
						firstPrizeAddArea.SetActive(flag21);
						bool flag22 = (object)firstPrizePlusIcon == null;
						num8 = 1.0;
						num9 = 1.0586423E+09f;
						obj5 = 0;
						flag2 = flag21;
						if (!flag22)
						{
							bool flag23 = firstPrizeAces == 0;
							firstPrizePlusIcon.SetActive(flag23);
							bool flag24 = (object)secondPrizeEditArea == null;
							num8 = 1.0;
							num9 = 1.0586423E+09f;
							obj5 = 0;
							flag2 = flag23;
							if (!flag24)
							{
								secondPrizeEditArea.SetActive(flag17);
								bool flag25 = (object)secondPrizeAddArea == null;
								num8 = 1.0;
								num9 = 1.0586423E+09f;
								obj5 = 0;
								flag2 = flag17;
								if (!flag25)
								{
									bool active = (byte)((flag17 ? 1u : 0u) ^ 1u) != 0;
									secondPrizeAddArea.SetActive(active);
									UIExtensions.SetAlpha(secondPrizeButtonIcon, (float)num7);
									UIExtensions.SetAlpha(secondPrizeButtonLabel, (float)num7);
									bool flag26 = (object)manager == null;
									num8 = 1.0;
									num9 = (float)num7;
									obj5 = 0;
									flag2 = false;
									if (!flag26)
									{
										manager.OnPrizeChanged();
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0557;
		IL_0557:
		ex = new IndexOutOfRangeException();
		flag5 = flag2;
		goto IL_056d;
		IL_056d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	public void ClearInput()
	{
		firstPrizeAces = 0;
		OnPrizeChanged();
	}
}
