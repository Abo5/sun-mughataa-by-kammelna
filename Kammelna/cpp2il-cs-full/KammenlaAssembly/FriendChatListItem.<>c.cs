using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using ListView;
using Newtonsoft.Json.Linq.JsonPath;
using TMPro;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class FriendChatListItem : ListViewItem<IListViewItemData<int>, int>
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<PrivateMessageModel, long> <>9__22_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(DebugUI.BitField) + 3112;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal long <UpdateView>b__22_0(PrivateMessageModel model)
		{
			//IL_0035: Expected I8, but got O
			if (model != null)
			{
				return model.timestamp;
			}
			NullReferenceException ex = new NullReferenceException();
			return (long)ex;
		}
	}

	private AvatarInitializer profileInitializer;

	private TextMeshProUGUI time;

	private TextMeshProUGUI lastMessage;

	private TextMeshProUGUI counter;

	private Image lastMessageStatusIcon;

	private Sprite readIcon;

	private Sprite unreadIcon;

	private Sprite emptyIcon;

	private Color readColor;

	private Color unreadColor;

	private RectTransform content;

	private GameObject timeGameObject;

	private const string NoLastMessageText = "Press to chat";

	private FriendProfileHolder profileHolder;

	private ListViewScroller parentListController;

	private float swipeSnapDist;

	private float swipeDeleteDist;

	private bool snapped;

	private bool ignoreSwipe;

	private bool HasUnreadMessages
	{
		get
		{
			//IL_0010: Expected O, but got I
			//IL_00dd: Expected I4, but got O
			//IL_0080: Expected O, but got I
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Expected O, but got Unknown
			//IL_00bd: Expected O, but got I4
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Expected I4, but got Unknown
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
			object obj = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+60]");
				bool flag = (nint)0 < (nint)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+60]");
				bool flag2 = (nint)0 == 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+60]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+60]");
				object obj2 = num ^ 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1+60]");
				object obj3 = 0 & obj2;
				bool flag3 = (nint)obj3 < 0;
				bool flag4 = flag == flag3;
				object obj4 = !flag2;
				return (byte)((flag4 & obj4) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 2776;
		object obj2 = (nint)0 + (nint)2552;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CounterBubbleManager.CounterUpdated counterUpdated = default(CounterBubbleManager.CounterUpdated);
		counterUpdated..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.OnCounterUpdated += counterUpdated;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_006a: Expected I, but got O
		//IL_0094: Expected O, but got I4
		object obj = typeof(CardUtils.<>c) + 2776;
		object obj2 = (nint)0 + (nint)2552;
		object obj3 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		CounterBubbleManager.CounterUpdated counterUpdated = default(CounterBubbleManager.CounterUpdated);
		counterUpdated..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		CounterBubbleManager.OnCounterUpdated -= counterUpdated;
	}

	private void Reset()
	{
		//IL_000c: Expected O, but got I
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		object obj = (nint)0 + (nint)3616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj2 = this + 128;
		object obj3 = default(object);
		obj2 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override void Setup(IListViewItemData<int> datum, bool firstTime)
	{
		//IL_000c: Expected O, but got I
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0035: Expected I, but got O
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0113: Expected O, but got Unknown
		//IL_0197: Expected O, but got I
		//IL_00c9: Expected O, but got I
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		object obj = (nint)0 + (nint)1472;
		((ListViewItem<object, int>)(object)this).Setup((object)datum, firstTime);
		if (datum != null)
		{
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1424;
			object obj3 = obj2;
			nint num = (nint)datum;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v7 (Il2CppClass<ListView.IListViewItemData`1<System.Int32>>)+40]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X1_v4+40]");
			if (num2 != 0)
			{
				goto IL_0141;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1960");
			object obj4 = default(object);
			profileHolder = (FriendProfileHolder)obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v8+10]");
			_ = 0;
			object obj5 = this + 248;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag = !firstTime;
			ListViewScroller listViewScroller = null;
			if (!flag)
			{
				object obj6 = (nint)0 + (nint)456;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D31634");
				ListViewScroller listViewScroller2 = default(ListViewScroller);
				parentListController = listViewScroller2;
				object obj7 = this + 264;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				listViewScroller = listViewScroller2;
			}
			object obj8 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
			AvatarData avatarData = default(AvatarData);
			avatarData..ctor((FriendProfile)0, alsoAnimate: false);
			if ((object)profileInitializer != null)
			{
				profileInitializer.Initialize(avatarData);
				UpdateView();
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0141;
		IL_0141:
		throw new InvalidCastException();
	}

	public void Initialize()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0058: Expected O, but got I
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 1776;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
		AvatarData avatarData = default(AvatarData);
		avatarData..ctor((FriendProfile)0, alsoAnimate: false);
		profileInitializer.Initialize(avatarData);
		UpdateView();
	}

	private void UpdateView()
	{
		//IL_03ae: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		//IL_03c5: Expected O, but got I
		//IL_03d5: Expected O, but got I
		//IL_03f7: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		//IL_008a: Expected O, but got I4
		//IL_032a: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_0414: Unknown result type (might be due to invalid IL or missing references)
		//IL_0419: Expected O, but got Unknown
		//IL_042f: Expected O, but got I
		//IL_0440: Expected I, but got O
		//IL_045e: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_0135: Expected I8, but got I
		//IL_00ba: Expected O, but got I
		//IL_015d: Expected O, but got I
		//IL_0571: Expected O, but got I
		//IL_0184: Expected O, but got I
		//IL_01d4: Expected O, but got I
		//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e9: Expected O, but got Unknown
		//IL_0211: Expected O, but got I4
		//IL_0219: Unknown result type (might be due to invalid IL or missing references)
		//IL_021e: Expected O, but got Unknown
		//IL_024c: Expected O, but got I4
		//IL_0494: Expected O, but got I
		//IL_04a4: Expected O, but got I
		//IL_023e: Expected O, but got I4
		//IL_02ab: Expected O, but got I
		//IL_02bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02e8: Expected O, but got I4
		//IL_02f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f5: Expected O, but got Unknown
		//IL_04c2: Expected O, but got I4
		//IL_04ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_04cf: Expected O, but got Unknown
		//IL_04ff: Expected O, but got I4
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_053c: Expected O, but got I4
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
		object obj = 0;
		object obj2 = typeof(DebugUI.BitField) + 3112;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v5+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj3 = obj2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v5+B8]");
		object obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v27+8]");
		Func<object, long> keySelector = (Func<object, long>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X8_v27+8]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v5+E4]");
			bool flag3 = (nint)0 == 0;
			object obj7 = !flag3;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj8 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v286 @ X8_v33+B8]");
				obj5 = 0;
			}
			object obj9 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2768;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj10 = (nint)0 + (nint)664;
			Func<object, long> func = default(Func<object, long>);
			func..ctor(obj5, (IntPtr)obj10);
			object obj11 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X8_v32+B8]");
			object obj12 = (nint)0 + (nint)8;
			obj12 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			keySelector = func;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X8_v3+58]");
		IOrderedEnumerable<object> source = Enumerable.OrderByDescending((IEnumerable<object>)0, keySelector);
		object obj13 = Enumerable.FirstOrDefault(source);
		TextMeshProUGUI textMeshProUGUI2;
		if (obj13 != null)
		{
			TextMeshProUGUI textMesh = lastMessage;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v9 (System.Object)+10]");
			TextMeshProExtensions.FixArabic(textMesh, (string)0);
			TextMeshProUGUI textMeshProUGUI = lastMessage;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X0_v9 (System.Object)+20]");
			string sinceText = ((FriendChatListItem)(object)textMeshProUGUI).GetSinceText(0L);
			TextMeshProExtensions.FixArabic(time, sinceText);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
			object obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v13+60]");
			UpdateCounter(0);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v14+60]");
			bool flag4 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v14+60]");
			bool flag5 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v14+60]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v14+60]");
			object obj16 = num ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v14+60]");
			object obj17 = 0 & obj16;
			bool flag6 = (nint)obj17 < 0;
			bool flag7 = flag4 == flag6;
			object obj18 = !flag5;
			object obj19 = flag7 & obj18;
			object obj20 = ~obj19;
			if (obj20 == null)
			{
				object obj21 = 176;
			}
			else
			{
				object obj21 = 168;
			}
			Image image = lastMessageStatusIcon;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+v334 @ X8_v17]");
			image.sprite = (Sprite)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
			object obj22 = 0;
			textMeshProUGUI2 = lastMessage;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v18+60]");
			bool flag8 = (nint)0 < (nint)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v18+60]");
			bool flag9 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v18+60]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v18+60]");
			object obj23 = num2 ^ 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v18+60]");
			object obj24 = 0 & obj23;
			bool flag10 = (nint)obj24 < 0;
			bool flag11 = flag8 == flag10;
			object obj25 = !flag9;
			object obj26 = flag11 & obj25;
			object obj27 = ~obj26;
			if (obj27 == null)
			{
			}
			bool flag12 = flag8 == flag10;
			object obj28 = !flag9;
			object obj29 = flag12 & obj28;
			object obj30 = ~obj29;
			if (obj30 == null)
			{
			}
			bool flag13 = flag8 == flag10;
			object obj31 = !flag9;
			object obj32 = flag13 & obj31;
			object obj33 = ~obj32;
			if (obj33 == null)
			{
			}
			bool flag14 = flag8 == flag10;
			object obj34 = !flag9;
			object obj35 = flag14 & obj34;
			object obj36 = ~obj35;
			if (obj36 != null)
			{
			}
		}
		else
		{
			object text = "Picking audio files is not supported on iOS" + 1480;
			TextMeshProExtensions.Localize(lastMessage, (string)text);
			UpdateCounter(0);
			lastMessageStatusIcon.sprite = emptyIcon;
			textMeshProUGUI2 = lastMessage;
		}
		textMeshProUGUI2.color = (Color)0;
		bool flag15 = obj13 == null;
		bool active = !flag15;
		timeGameObject.SetActive(active);
	}

	private unsafe void OnCounterUpdated(CounterBubbleType type, int newCount, string extra)
	{
		if (type == CounterBubbleType.PrivateChat)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
			int num = (int)((nint)0 + (nint)16);
			string text = ((int*)num)->ToString();
			if (!(extra != text))
			{
				UpdateView();
			}
		}
	}

	private void UpdateCounter(int count)
	{
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0072: Expected O, but got Unknown
		//IL_011c: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_00e9: Expected O, but got I4
		//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f6: Expected I4, but got Unknown
		int num = default(int);
		string text = num.ToString();
		counter.text = text;
		Transform transform = counter.transform;
		Transform parent = transform.parent;
		int num2 = ShortcutExtensions.DOKill(parent, complete: true);
		object obj = typeof(UsageHint) + 816;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v4+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X8_v5+C]");
		object obj4 = default(object);
		float duration = 0f * (float)obj4;
		float elasticity = default(float);
		Tweener tweener = ShortcutExtensions.DOPunchScale(parent, (Vector3)10, duration, 0, elasticity);
		GameObject gameObject = parent.gameObject;
		bool flag = num < 0;
		bool flag2 = num == 0;
		int num3 = num ^ num;
		int num4 = num & num3;
		bool flag3 = num4 < 0;
		bool flag4 = flag == flag3;
		object obj5 = !flag2;
		bool active = (byte)((flag4 & obj5) ? 1 : 0) != 0;
		gameObject.SetActive(active);
	}

	private string GetSinceText(long Ticks)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f0: Expected O, but got Unknown
		//IL_051a: Expected O, but got I4
		//IL_0083: Expected O, but got I4
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_01f1: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_031b: Expected O, but got I4
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_016b: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		//IL_0262: Expected O, but got I4
		//IL_01c6: Expected I8, but got I4
		//IL_0445: Expected O, but got I4
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a3: Expected O, but got Unknown
		//IL_02c5: Expected O, but got I4
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		//IL_04a8: Expected O, but got I4
		//IL_038c: Expected O, but got I4
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_03ef: Expected O, but got I4
		//IL_02e4: Expected O, but got I4
		//IL_04c7: Expected O, but got I4
		//IL_040e: Expected O, but got I4
		object obj = typeof(DataRelation) + 712;
		object obj2 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 1032;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		DateTime utcNow = DateTime.UtcNow;
		DateTime dateTime = new DateTime(Ticks, DateTimeKind.Utc);
		TimeSpan timeSpan = utcNow - dateTime;
		object obj5 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v9+E4]");
		bool flag2 = (nint)0 == 0;
		object obj6 = !flag2;
		if (obj6 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj7 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
		TimeSpan timeSpan2 = default(TimeSpan);
		int days = timeSpan2.Days;
		object obj8 = obj2;
		object obj11;
		int num;
		object obj14;
		int num2;
		if (days >= 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v13+E4]");
			bool flag3 = (nint)0 == 0;
			object obj9 = !flag3;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int days2 = timeSpan2.Days;
			object obj10 = obj7;
			obj11 = "DNQUALIFIER" + 1456;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v42+E4]");
			bool flag4 = (nint)0 == 0;
			object obj12 = !flag4;
			object obj13 = 0;
			num = days2;
			obj14 = obj11;
			num2 = days2;
			if (obj12 == null)
			{
				goto IL_019a;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v13+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			int hours = timeSpan2.Hours;
			object obj16 = obj2;
			if (hours >= 1)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v17+E4]");
				bool flag6 = (nint)0 == 0;
				object obj17 = !flag6;
				if (obj17 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int hours2 = timeSpan2.Hours;
				object obj10 = obj7;
				obj14 = "getSecondRescanTask" + 3264;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v42+E4]");
				bool flag7 = (nint)0 == 0;
				object obj18 = !flag7;
				num2 = hours2;
				if (obj18 == null)
				{
					object obj13 = 0;
					obj11 = obj14;
					num = hours2;
					goto IL_019a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v17+E4]");
				bool flag8 = (nint)0 == 0;
				object obj19 = !flag8;
				if (obj19 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				int minutes = timeSpan2.Minutes;
				object obj20 = obj2;
				if (minutes >= 1)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v21+E4]");
					bool flag9 = (nint)0 == 0;
					object obj21 = !flag9;
					if (obj21 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int minutes2 = timeSpan2.Minutes;
					object obj10 = obj7;
					obj14 = "m_StencilDeferredPS" + 1888;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v42+E4]");
					bool flag10 = (nint)0 == 0;
					object obj22 = !flag10;
					num2 = minutes2;
					if (obj22 == null)
					{
						object obj13 = 0;
						obj11 = obj14;
						num = minutes2;
						goto IL_019a;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X0_v21+E4]");
					bool flag11 = (nint)0 == 0;
					object obj23 = !flag11;
					if (obj23 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					}
					int seconds = timeSpan2.Seconds;
					object obj10 = obj7;
					obj14 = "rightCtrl" + 1672;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v168 @ X0_v42+E4]");
					bool flag12 = (nint)0 == 0;
					object obj24 = !flag12;
					num2 = seconds;
					if (obj24 == null)
					{
						object obj13 = 0;
						obj11 = obj14;
						num = seconds;
						goto IL_019a;
					}
				}
			}
		}
		goto IL_01b9;
		IL_01b9:
		return LocalizationUtil.Localize((string)obj14, num2);
		IL_019a:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj14 = obj11;
		num2 = num;
		goto IL_01b9;
	}

	public void OnSwiping(SwipeGesture swipe)
	{
		//IL_01ad: Expected O, but got I4
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_003e: Invalid comparison between F4 and I4
		//IL_0105: Expected O, but got I4
		//IL_0174: Expected F4, but got I4
		//IL_01f1: Expected O, but got I4
		bool flag = !ignoreSwipe;
		object obj = !flag;
		if (obj == null && (!DirectionExtensions.IsVertical(swipe.CardinalDirection) || !(swipe.TravelDistance < 1.128792E+09f)))
		{
			object obj2 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v185 @ X0_v5+E4]");
			if ((nint)0 != 0)
			{
				if (DOTween.IsTweening(content))
				{
					goto IL_00c0;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag2 = DOTween.IsTweening(content);
				bool flag3 = !flag2;
				object obj4 = !flag3;
				if (obj4 != null)
				{
					goto IL_00c0;
				}
			}
			parentListController.enabled = false;
			object obj5 = swipe.EndPosition - swipe.StartPosition;
			float scaleFactor = ScreenUtility.ScaleFactor;
			float num = (float)obj5 * scaleFactor;
			bool flag4 = !snapped;
			float num2 = 0f;
			if (!flag4)
			{
				num2 = swipeSnapDist;
			}
			float value = num - num2;
			UIExtensions.MoveTo(x: value, gObject: content, isWorldPositions: false, y: (float?)(object)0);
			return;
		}
		goto IL_00c0;
		IL_00c0:
		ignoreSwipe = true;
	}

	public void OnSwipe(SwipeGesture gesture)
	{
		//IL_0051: Expected O, but got F4
		//IL_00bf: Invalid comparison between F4 and I4
		//IL_00cd: Invalid comparison between O and F4
		//IL_00fa: Expected F4, but got I4
		ignoreSwipe = false;
		parentListController.enabled = true;
		Transform transform = content.transform;
		Vector3 vector = transform.localPosition;
		object obj = 0f - swipeDeleteDist;
		object obj2 = default(object);
		if (obj2 < obj)
		{
			Unfriend();
		}
		Transform transform2 = content.transform;
		Vector3 vector2 = transform2.localPosition;
		float num = 0f - swipeSnapDist;
		float num2 = (float)obj2 - num;
		bool flag = num2 < 0f;
		float endValue = ((obj2 >= (object)num) ? 0f : num);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveX(content, endValue, 0.2f);
		snapped = flag;
	}

	public void OpenChat()
	{
		//IL_0062: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0037: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
		object obj = 0;
		object obj2 = typeof(UsageHint) + 24;
		_ = 1;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X9_v4+B8]");
		object obj4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
		((UserChatPopup)obj4).Open(0);
	}

	public void Unfriend()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_0090: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)2544;
		object obj3 = typeof(System.Buffers.Text.ParserHelpers) + 1432;
		object msgTitle = "Complete" + 288;
		object msgBody = "placementId" + 3152;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v4+E4]");
		bool flag = (nint)0 == 0;
		object obj5 = !flag;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		PopupWindow.ShowNegativeConfirm((string)msgTitle, (string)msgBody, action);
	}

	public FriendChatListItem()
	{
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7252B30]");
		_ = 0;
		((ListViewItem<object, int>)(object)this)..ctor();
	}

	private void <Unfriend>b__33_0()
	{
		//IL_008b: Expected O, but got I
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FriendChatListItem)+100]");
		object obj = 0;
		object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 1528;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
			FriendsManager.RemoveFriend(0);
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X8_v3+10]");
			FriendsManager.RemoveFriend(0);
		}
	}
}
