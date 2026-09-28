using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MatchesHistoryList : MonoBehaviour
{
	private bool _isInitialized;

	private readonly Dictionary<int, PredictAndWinCard> _cards;

	private PredictAndWinCard cardPrefab;

	private RectTransform cardsContainer;

	private RotatingLoadingIndicator loadingIndicator;

	private GameObject emptyState;

	private ScrollRect scrollRect;

	private bool _isLoading;

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0169: Expected I, but got O
		//IL_0193: Expected O, but got I4
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		//IL_007d: Expected O, but got Unknown
		//IL_0089: Expected O, but got I
		//IL_00a1: Expected I, but got O
		//IL_00b2: Expected O, but got I
		//IL_00be: Expected O, but got I
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0101: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3904;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.3f, action);
		ScrollRect scrollRect = this.scrollRect;
		object obj6 = typeof(TypeConverter<ushort, char>) + 480;
		object obj7 = (nint)0 + (nint)3920;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction<Vector2> unityAction = default(UnityAction<Vector2>);
		unityAction..ctor((object)this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)1272;
		object obj9 = (nint)0 + (nint)3912;
		object obj10 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		scrollRect.m_OnValueChanged.AddListener(unityAction);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj9);
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v15+E4]");
		if ((nint)0 != 0)
		{
			PredictAndWinManager.OnMoreItemsLoaded += action2;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PredictAndWinManager.OnMoreItemsLoaded += action2;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0074: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3912;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		if ((nint)0 != 0)
		{
			PredictAndWinManager.OnMoreItemsLoaded -= action;
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PredictAndWinManager.OnMoreItemsLoaded -= action;
	}

	private void OnEnable()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0025: Expected O, but got I
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0066: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3928;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		emptyState.SetActive(value: false);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			PredictAndWinManager.CallWhenLoaded(action);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		PredictAndWinManager.CallWhenLoaded(action);
	}

	private void Populate()
	{
		//IL_0757: Unknown result type (might be due to invalid IL or missing references)
		//IL_075c: Expected O, but got Unknown
		//IL_0768: Expected O, but got I
		//IL_0774: Expected O, but got I
		//IL_0780: Expected O, but got I
		//IL_078f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_07a0: Expected O, but got I
		//IL_08bb: Expected O, but got I4
		//IL_07c3: Expected O, but got I
		//IL_07d3: Expected O, but got I
		//IL_0515: Expected O, but got I4
		//IL_009c: Expected O, but got I4
		//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected I4, but got Unknown
		//IL_054d: Expected O, but got I
		//IL_055d: Expected O, but got I
		//IL_0584: Expected O, but got I
		//IL_0135: Expected O, but got I4
		//IL_0145: Expected O, but got I
		//IL_05d1: Expected O, but got I4
		//IL_0601: Unknown result type (might be due to invalid IL or missing references)
		//IL_0606: Expected I4, but got Unknown
		//IL_065c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0661: Expected O, but got Unknown
		//IL_068b: Expected O, but got I4
		//IL_06c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c5: Expected O, but got Unknown
		//IL_0175: Expected O, but got I
		//IL_0185: Expected O, but got I
		//IL_01b4: Expected O, but got I
		//IL_0854: Unknown result type (might be due to invalid IL or missing references)
		//IL_0859: Expected O, but got Unknown
		//IL_0883: Expected O, but got I4
		//IL_0218: Expected O, but got I
		//IL_0719: Expected O, but got I4
		//IL_072b: Expected O, but got I4
		//IL_028c: Expected I4, but got O
		//IL_02ab: Expected I4, but got O
		//IL_03b3: Expected I4, but got O
		//IL_03dd: Expected O, but got I4
		//IL_02d8: Expected O, but got I
		//IL_033c: Expected I4, but got O
		//IL_035b: Expected I4, but got O
		//IL_0469: Expected O, but got I
		//IL_03a1: Expected I, but got O
		//IL_04c2: Expected O, but got I4
		//IL_0011: Expected O, but got I
		//IL_0034: Expected I4, but got O
		//IL_0049: Expected I, but got O
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1544;
		object obj2 = (nint)0 + (nint)2976;
		object obj3 = (nint)0 + (nint)1304;
		object obj4 = (nint)0 + (nint)1312;
		object obj5 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj6 = (nint)0 + (nint)592;
		int num = 0;
		MatchesHistoryList matchesHistoryList = this;
		nint num3 = default(nint);
		PredictAndWinCard predictAndWinCard = default(PredictAndWinCard);
		while (true)
		{
			NullReferenceException ex = (NullReferenceException)obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v5 (System.NullReferenceException)+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				ex = (NullReferenceException)obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v5 (System.NullReferenceException)+B8]");
			object obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v5+8]");
			List<object> list = (List<object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v5+8]");
			bool flag2 = (nint)0 == 0;
			int num2 = (int)num3;
			object obj13;
			object obj16;
			object obj14;
			string text;
			if (!flag2)
			{
				object obj9 = num - list._size;
				bool flag3 = (nint)obj9 < 0;
				int num4 = num ^ list._size;
				int num5 = num ^ obj9;
				int num6 = num4 & num5;
				bool flag4 = num6 < 0;
				bool flag5 = num >= list._size;
				num2 = (int)num3;
				if (flag5)
				{
					goto IL_04f3;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v5 (System.NullReferenceException)+E4]");
				bool flag6 = (nint)0 == 0;
				object obj10 = !flag6;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v5+8]");
				List<object> list2 = (List<object>)0;
				if (obj10 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj11 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v32+B8]");
					object obj12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v33+8]");
					list2 = (List<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v33+8]");
					bool flag7 = (nint)0 == 0;
					num2 = (int)num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v33+8]");
					list = (List<object>)0;
					if (flag7)
					{
						goto IL_04e5;
					}
				}
				text = (string)obj2;
				obj13 = list2.get_Item(num);
				bool flag8 = obj13 == null;
				num2 = num;
				list = list2;
				if (!flag8)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v27 (System.Object)+28]");
					list = (List<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v27 (System.Object)+28]");
					bool flag9 = (nint)0 == 0;
					obj14 = obj13;
					num2 = num;
					if (!flag9)
					{
						bool flag10 = matchesHistoryList._cards == null;
						obj14 = obj13;
						num2 = num;
						if (!flag10)
						{
							num2 = (int)list._items;
							text = (string)obj3;
							if (((Dictionary<int, object>)(object)matchesHistoryList._cards).ContainsKey((int)list._items))
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v27 (System.Object)+28]");
								list = (List<object>)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v27 (System.Object)+28]");
								bool flag11 = (nint)0 == 0;
								obj14 = obj13;
								if (!flag11)
								{
									bool flag12 = matchesHistoryList._cards == null;
									obj14 = obj13;
									if (!flag12)
									{
										num2 = (int)list._items;
										text = (string)obj4;
										object obj15 = ((Dictionary<int, object>)(object)matchesHistoryList._cards).get_Item((int)list._items);
										bool flag13 = obj15 == null;
										obj14 = obj13;
										if (!flag13)
										{
											((PredictAndWinCard)obj15).Populate((UserMatchPredictionModel)obj13);
											obj16 = obj4;
											num3 = (nint)obj13;
											goto IL_004e;
										}
									}
								}
							}
							else
							{
								num2 = (int)matchesHistoryList.cardsContainer;
								list = (List<object>)obj5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v7 (System.Collections.Generic.List`1<System.Object>)+E4]");
								bool flag14 = (nint)0 == 0;
								object obj17 = !flag14;
								if (obj17 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									matchesHistoryList = this;
								}
								text = (string)obj6;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE9D50");
								bool flag15 = (object)predictAndWinCard == null;
								obj14 = obj13;
								if (!flag15)
								{
									predictAndWinCard.Populate((UserMatchPredictionModel)obj13);
									Transform transform = predictAndWinCard.transform;
									bool flag16 = (object)transform == null;
									obj14 = obj13;
									num2 = 0;
									if (!flag16)
									{
										transform.SetSiblingIndex(num);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v27 (System.Object)+28]");
										list = (List<object>)0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v27 (System.Object)+28]");
										bool flag17 = (nint)0 == 0;
										obj14 = obj13;
										text = null;
										num2 = num;
										if (!flag17)
										{
											bool flag18 = matchesHistoryList._cards == null;
											object obj18 = !flag18;
											obj14 = obj13;
											text = null;
											num2 = num;
											if (obj18 != null)
											{
												object obj19 = (nint)0 + (nint)1320;
												object obj20 = obj19;
												((Dictionary<int, object>)(object)matchesHistoryList._cards).set_Item((int)list._items, (object)predictAndWinCard);
												obj16 = predictAndWinCard;
												num3 = (nint)list._items;
												goto IL_004e;
											}
										}
									}
								}
							}
						}
					}
				}
			}
			goto IL_04e5;
			IL_004e:
			num++;
			obj14 = obj13;
			text = (string)obj16;
			continue;
			IL_04f3:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X0_v5 (System.NullReferenceException)+E4]");
			bool flag19 = (nint)0 == 0;
			object obj21 = !flag19;
			List<object> list3 = list;
			if (obj21 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj22 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v297 @ X8_v20+B8]");
				object obj23 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v21+8]");
				list = (List<object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v21+8]");
				bool flag20 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v21+8]");
				list3 = (List<object>)0;
				if (flag20)
				{
					goto IL_04e5;
				}
			}
			bool flag21 = (object)matchesHistoryList.emptyState == null;
			list = list3;
			if (!flag21)
			{
				object obj9 = list3._size - 1;
				bool flag3 = (nint)obj9 < 0;
				int num4 = list3._size ^ 1;
				int num5 = list3._size ^ obj9;
				int num6 = num4 & num5;
				bool flag4 = num6 < 0;
				bool flag22 = flag3 == flag4;
				bool flag5 = !flag22;
				matchesHistoryList.emptyState.SetActive(flag5);
				object obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 1648;
				object obj25 = obj24;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v311 @ X0_v8+E4]");
				bool flag23 = (nint)0 == 0;
				object obj26 = !flag23;
				if (obj26 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				LayoutRebuilder.ForceRebuildLayoutImmediate(matchesHistoryList.cardsContainer);
				obj14 = "Invalid serialized DateTime data. Unable to find 'ticks' or 'dateData'." + 2120;
				Prefs.SetBool((string)obj14, value: false);
				object obj27 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
				object obj28 = obj27;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X0_v13+E4]");
				bool flag24 = (nint)0 == 0;
				object obj29 = !flag24;
				if (obj29 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				CounterBubbleManager.UpdateCounter(CounterBubbleType.PredictAndWinHistory, 0);
				matchesHistoryList._isInitialized = true;
				bool flag25 = (object)matchesHistoryList.loadingIndicator == null;
				text = null;
				object obj20 = 0;
				num2 = 0;
				list = (List<object>)1;
				if (!flag25)
				{
					break;
				}
			}
			goto IL_04e5;
			IL_04e5:
			ex = new NullReferenceException();
			goto IL_04f3;
		}
		matchesHistoryList.loadingIndicator.FinishLoading();
	}

	public void InitializeNextPage()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_00b1: Expected I, but got O
		//IL_0063: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)3896;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		Populate();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.3f, action);
	}

	private void OnValueChange(Vector2 value)
	{
		//IL_002e: Expected O, but got I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0056: Expected O, but got I4
		//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		Vector2 normalizedPosition = scrollRect.normalizedPosition;
		object obj = default(object);
		bool flag = (nint)obj < 1020054733;
		object obj2 = !flag;
		object obj3 = obj - 1020054733;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null && !_isLoading)
		{
			_isLoading = true;
			loadingIndicator.StartLoading();
			object obj6 = typeof(System.Buffers.Text.ParserHelpers) + 1544;
			object obj7 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X0_v7+E4]");
			if ((nint)0 != 0)
			{
				PredictAndWinManager.RequestMoreMatchesHistory();
				return;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			PredictAndWinManager.RequestMoreMatchesHistory();
		}
	}

	public MatchesHistoryList()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 1192;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<int, object> dictionary = default(Dictionary<int, object>);
		dictionary..ctor();
		object obj2 = this + 40;
		obj2 = dictionary;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_isLoading = true;
		base..ctor();
	}

	private void <Start>b__8_0()
	{
		if (!_isInitialized)
		{
			loadingIndicator.StartLoading();
		}
	}

	private void <InitializeNextPage>b__12_0()
	{
		loadingIndicator.FinishLoading();
		_isLoading = false;
	}
}
