using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Managers.Achievemenets;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class EndGameAchievementItem : MonoBehaviour
{
	private sealed class <>c__DisplayClass16_0
	{
		public EndGameAchievementItem <>4__this;

		public GameAchievementViewModel achievement;

		public List<AchievementLevelModel> levels;

		public Func<UserAchievementModel, bool> <>9__2;

		internal void <LoadCurrentLevelImage>b__0(PlayerProfileModel profile)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_00c1: Expected O, but got I4
			//IL_00ca: Expected O, but got I4
			//IL_0071: Expected O, but got I4
			//IL_0269: Expected O, but got I4
			//IL_0292: Unknown result type (might be due to invalid IL or missing references)
			//IL_0297: Expected I4, but got Unknown
			//IL_02cc: Expected O, but got I4
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_0149: Expected O, but got I4
			//IL_036d: Expected O, but got I4
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Expected O, but got Unknown
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_016b: Expected O, but got Unknown
			//IL_0181: Expected O, but got I
			//IL_018f: Expected I, but got O
			//IL_021f: Expected O, but got I4
			EndGameAchievementItem endGameAchievementItem = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				bool flag = endGameAchievementItem.image == null;
				bool flag2 = !flag;
				object obj3 = 0;
				UnityEngine.Object obj4 = null;
				if (!flag2)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag3 = endGameAchievementItem.image == null;
				bool flag4 = !flag3;
				object obj5 = !flag4;
				object obj3 = 0;
				UnityEngine.Object obj4 = null;
				if (obj5 != null)
				{
					return;
				}
			}
			int num;
			List<object> list;
			if (profile != null && profile.<gameAchievements>k__BackingField != null)
			{
				object obj6 = this + 40;
				Func<object, bool> predicate = (Func<object, bool>)obj6;
				bool flag5 = obj6 == null;
				object obj7 = !flag5;
				if (obj7 == null)
				{
					object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj9 = (nint)0 + (nint)3000;
					Func<object, bool> func = default(Func<object, bool>);
					func..ctor((object)this, (IntPtr)obj9);
					<>9__2 = func;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					predicate = func;
				}
				object obj10 = Enumerable.FirstOrDefault(profile.<gameAchievements>k__BackingField, predicate);
				if (obj10 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v13 (System.Object)+1C]");
					num = 0;
					list = (List<object>)(object)levels;
					bool flag6 = levels == null;
					object obj11 = !flag6;
					if (obj11 == null)
					{
						throw new NullReferenceException();
					}
					goto IL_024a;
				}
			}
			list = (List<object>)(object)levels;
			num = 1;
			goto IL_024a;
			IL_024a:
			int num2 = list._size;
			object obj12 = num - list._size;
			bool flag7 = (nint)obj12 < 0;
			int num3 = num ^ list._size;
			int num4 = num ^ obj12;
			int num5 = num3 & num4;
			bool flag8 = num5 < 0;
			bool flag9 = flag7 == flag8;
			object obj13 = !flag9;
			object obj14 = ~obj13;
			if (obj14 == null)
			{
				num2 = num;
			}
			EndGameAchievementItem endGameAchievementItem2 = <>4__this;
			GameAchievementViewModel gameAchievementViewModel = achievement;
			int num6 = num2 - 1;
			bool flag10 = num < 0;
			bool flag11 = num == 0;
			int num7 = num ^ num;
			int num8 = num & num7;
			bool flag12 = num8 < 0;
			bool flag13 = flag10 == flag12;
			object obj15 = !flag11;
			object obj16 = flag13 & obj15;
			object obj17 = ~obj16;
			int index = ((obj17 == null) ? num6 : 0);
			object obj18 = list.get_Item(index);
			Image image = endGameAchievementItem2.image;
			string <id>k__BackingField = gameAchievementViewModel.<id>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X0_v7 (System.Object)+10]");
			UIExtensions.LoadAchievementImage(image, <id>k__BackingField, 0);
		}

		internal bool <LoadCurrentLevelImage>b__2(UserAchievementModel ua)
		{
			//IL_0074: Expected I4, but got O
			if (ua != null)
			{
				GameAchievementViewModel gameAchievementViewModel = achievement;
				if (achievement != null)
				{
					return ua.<gameAchievementId>k__BackingField == gameAchievementViewModel.<id>k__BackingField;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}

		internal void <LoadCurrentLevelImage>b__1(KammelnaError _)
		{
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Expected O, but got Unknown
			//IL_0107: Expected O, but got I4
			EndGameAchievementItem endGameAchievementItem = <>4__this;
			object obj = typeof(MemberAchievementClanFeedData) + 2976;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v4+E4]");
			if ((nint)0 != 0)
			{
				if (!(endGameAchievementItem.image != null))
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag = endGameAchievementItem.image != null;
				bool flag2 = !flag;
				object obj3 = !flag2;
				if (obj3 == null)
				{
					return;
				}
			}
			EndGameAchievementItem endGameAchievementItem2 = <>4__this;
			GameAchievementViewModel gameAchievementViewModel = achievement;
			object obj4 = ((List<object>)(object)levels).get_Item(0);
			Image image = endGameAchievementItem2.image;
			string <id>k__BackingField = gameAchievementViewModel.<id>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v11 (System.Object)+10]");
			UIExtensions.LoadAchievementImage(image, <id>k__BackingField, 0);
		}
	}

	private GameObject normalView;

	private GameObject bigView;

	private Image image;

	private TextMeshProUGUI[] texts;

	private CanvasGroup group;

	private Button closeButton;

	private GameAchievementViewModel <Achievement>k__BackingField;

	private Action m_OnClick;

	public GameAchievementViewModel Achievement
	{
		get
		{
			return <Achievement>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 80;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public event Action OnClick
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 88;
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
			object obj2 = this + 88;
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
		Button button = closeButton;
		object obj = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		object obj2 = (nint)0 + (nint)784;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UnityAction unityAction = default(UnityAction);
		unityAction..ctor(this, (IntPtr)obj2);
		button.m_OnClick.AddListener(unityAction);
	}

	private void Click()
	{
		Action onClick = this.OnClick;
		if (this.OnClick != null)
		{
			IntPtr invoke_impl = ((Delegate)onClick).invoke_impl;
			IntPtr method_code = ((Delegate)onClick).method_code;
			IntPtr method = ((Delegate)onClick).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v3 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
		}
	}

	public void Populate(GameAchievementViewModel achievement, bool visible = true)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_00d9: Expected O, but got I4
		//IL_010b: Expected F4, but got I4
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0071: Expected O, but got I4
		//IL_0093: Expected O, but got I
		//IL_0093: Expected O, but got I
		//IL_009c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		object obj = this + 80;
		obj = achievement;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		LoadCurrentLevelImage(achievement);
		TextMeshProUGUI[] array = texts;
		if (array.Length >= 1)
		{
			object obj2 = array + 32;
			object obj3 = 0;
			do
			{
				object obj4 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X24_v4+v64 @ X23_v5*8]");
				nint num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X8_v5+20]");
				TextMeshProExtensions.FixArabic((TextMeshProUGUI)num, (string)0);
				obj3++;
			}
			while ((nint)obj3 < array.Length);
		}
		bool flag = !visible;
		object obj5 = !flag;
		object obj6 = ~obj5;
		float alpha = ((obj6 != null) ? 0f : 1f);
		group.alpha = alpha;
	}

	private void LoadCurrentLevelImage(GameAchievementViewModel achievement)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_0086: Expected O, but got I
		//IL_00e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ee: Expected O, but got Unknown
		//IL_0104: Expected O, but got I
		//IL_0115: Expected I, but got O
		//IL_0129: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_0144: Expected O, but got I
		//IL_0155: Expected I, but got O
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0198: Expected O, but got I4
		object obj = typeof(DebugUI.BitField) + 1416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 24;
		obj4 = achievement;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj4;
		object obj6 = obj2 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v71 @ X8_v4+38]");
		obj6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj6;
		if (obj6 == null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v5+18]");
		if ((nint)0 != 0)
		{
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)2984;
			Action<object> action = default(Action<object>);
			action..ctor(obj2, (IntPtr)obj9);
			object obj10 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 2504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj11 = (nint)0 + (nint)2992;
			Action<System.Int32Enum> action2 = default(Action<System.Int32Enum>);
			action2..ctor(obj2, (IntPtr)obj11);
			object obj12 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj13 = obj12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X0_v17+E4]");
			bool flag = (nint)0 == 0;
			object obj14 = !flag;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerProfilesHandler.RequestMyProfile(action, (Action<KammelnaError>)(object)action2);
		}
	}

	public void SetVisible(bool visible)
	{
		//IL_001a: Expected O, but got I4
		//IL_004c: Expected F4, but got I4
		bool flag = !visible;
		object obj = !flag;
		object obj2 = ~obj;
		float alpha = ((obj2 != null) ? 0f : 1f);
		group.alpha = alpha;
	}

	public void SetBigView()
	{
		normalView.SetActive(value: false);
		bigView.SetActive(value: true);
	}
}
