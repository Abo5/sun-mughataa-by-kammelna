using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using UnityEngine;

public abstract class KGameVisualControls : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<Userbox, bool> <>9__14_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1208;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal bool <get_ActiveUserBoxes>b__14_0(Userbox u)
		{
			//IL_0067: Expected I4, but got O
			if ((object)u != null)
			{
				GameObject gameObject = u.gameObject;
				if ((object)gameObject != null)
				{
					return gameObject.activeInHierarchy;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <>c__DisplayClass22_0
	{
		public KPlayer player;

		internal bool <GetNextPlayerUserbox>b__0(Userbox u)
		{
			//IL_0053: Expected I4, but got O
			if ((object)u != null)
			{
				object obj = (object)u.<player>k__BackingField - (object)player;
				return obj == null;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	protected Userbox[] allUserboxes;

	protected GameObject bottomWatcher;

	private GameObject bottomPlayer;

	protected GameEventsChannel gameEventChannel;

	protected KGame _game;

	private Hand _hand;

	protected Hand hand
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Expected O, but got Unknown
			//IL_0125: Expected O, but got I4
			//IL_00c2: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_01a6: Expected O, but got I
			//IL_01d0: Expected O, but got I4
			//IL_0176: Expected O, but got I4
			//IL_0187: Expected O, but got I4
			object obj = 152993792;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B7F]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 72;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
				bool flag = (nint)0 == 0;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				_ = 1;
				obj4 = this + 72;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X0_v10+E4]");
				bool flag2 = (nint)0 == 0;
				object obj9 = !flag2;
				obj7 = (UnityEngine.Object)obj4;
				obj8 = obj4;
				if (obj9 != null)
				{
					goto IL_00a0;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = obj7 != null;
			bool flag4 = !flag3;
			object obj10 = !flag4;
			obj4 = obj8;
			object obj11 = 0;
			UnityEngine.Object obj12 = null;
			if (obj10 != null)
			{
				goto IL_00dd;
			}
			goto IL_019a;
			IL_00dd:
			return (Hand)obj4;
			IL_019a:
			object obj13 = (nint)0 + (nint)96;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v2+E4]");
			bool flag5 = (nint)0 == 0;
			object obj15 = !flag5;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			Hand hand = default(Hand);
			obj8 = hand;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return hand;
			IL_00a0:
			bool flag6 = obj5 != null;
			bool flag7 = !flag6;
			obj11 = 0;
			obj12 = null;
			obj8 = obj4;
			if (!flag7)
			{
				goto IL_00dd;
			}
			goto IL_019a;
		}
	}

	public bool IsCurrentPerspectiveTopDown
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00b2: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8BCD]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			return Preferences.IsPerspectiveTopDown;
			IL_0074:
			return Preferences.IsPerspectiveTopDown;
		}
		private set
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00ae: Expected O, but got I4
			object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B80]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Preferences.IsPerspectiveTopDown = value;
			return;
			IL_0074:
			Preferences.IsPerspectiveTopDown = value;
		}
	}

	public Userbox[] Userboxes => allUserboxes;

	public Userbox[] ActiveUserBoxes
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_00db: Expected O, but got I4
			//IL_0173: Expected O, but got I
			//IL_0183: Expected O, but got I
			//IL_01a5: Expected O, but got I4
			//IL_0052: Expected O, but got I4
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0113: Expected O, but got I
			//IL_0124: Expected I, but got O
			//IL_0142: Expected O, but got I
			//IL_0082: Expected O, but got I
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1208;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj2 = obj;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+8]");
			Func<object, bool> predicate = (Func<object, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v6+8]");
			bool flag2 = (nint)0 == 0;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v3+E4]");
				bool flag3 = (nint)0 == 0;
				object obj6 = !flag3;
				if (obj6 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj7 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X8_v12+B8]");
					obj4 = 0;
				}
				object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 176;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj9 = (nint)0 + (nint)3112;
				Func<object, bool> func = default(Func<object, bool>);
				func..ctor(obj4, (IntPtr)obj9);
				object obj10 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v11+B8]");
				object obj11 = (nint)0 + (nint)8;
				obj11 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				predicate = func;
			}
			IEnumerable<object> source = Enumerable.Where(allUserboxes, predicate);
			return (Userbox[])Enumerable.ToArray(source);
		}
	}

	private void Awake()
	{
		//IL_0005: Expected I, but got O
		//IL_0015: Expected O, but got I
		//IL_0025: Expected O, but got I
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KGameVisualControls>)+178]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X8_v1 (Il2CppClass<KGameVisualControls>)+180]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v2 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0038: Expected I, but got O
		object obj = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (Il2CppClass<KGameVisualControls>)+190]");
		Action<bool> action = default(Action<bool>);
		action..ctor((object)this, (IntPtr)0);
		gameEventChannel.OnGamePerspectiveChanged -= action;
	}

	protected virtual void Init()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_029c: Expected O, but got I
		//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b0: Expected O, but got Unknown
		//IL_02da: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0063: Expected I, but got O
		//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_0305: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Expected O, but got Unknown
		//IL_0125: Expected I, but got O
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_0327: Expected O, but got Unknown
		//IL_010c: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_0206: Expected I, but got O
		//IL_01d9: Expected O, but got I4
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_035e: Expected O, but got I4
		//IL_0266: Expected I, but got O
		//IL_0276: Expected O, but got I
		//IL_0286: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj7 = default(object);
		Action action = default(Action);
		Delegate obj15 = default(Delegate);
		Action action2 = default(Action);
		Delegate obj19 = default(Delegate);
		Action<bool> action3 = default(Action<bool>);
		while (true)
		{
			object obj2 = (nint)0 + (nint)136;
			object obj3 = typeof(SqlSingle[]) + 2376;
			object obj4 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = !flag;
			if (obj5 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
			object obj6 = this + 64;
			obj6 = obj7;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4 (Il2CppClass<KGameVisualControls>)+1A0]");
			action..ctor(this, (IntPtr)0);
			object obj8 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
			object obj9 = obj6 + 240;
			Delegate obj10 = (Delegate)obj9;
			while (true)
			{
				Delegate obj11 = Delegate.Combine(obj10, action);
				if ((object)obj11 != null)
				{
					Delegate obj12 = (Delegate)obj3;
					if (obj11 != obj3)
					{
						object obj13 = 0;
						Delegate obj14 = null;
						goto IL_01ec;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
				bool flag2 = (object)obj15 == obj10;
				obj10 = obj15;
				if (!flag2)
				{
					continue;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				nint num2 = (nint)this;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X8_v18 (Il2CppClass<KGameVisualControls>)+1B0]");
				action2..ctor(this, (IntPtr)0);
				object obj16 = _game + 248;
				Delegate obj17 = (Delegate)obj16;
				while (true)
				{
					Delegate obj18 = Delegate.Combine(obj17, action2);
					object obj13;
					Delegate obj14;
					Delegate obj12;
					if ((object)obj18 != null)
					{
						obj12 = (Delegate)obj3;
						bool flag3 = obj18 == obj3;
						obj13 = 0;
						obj14 = null;
						if (!flag3)
						{
							break;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0C814");
					bool flag4 = (object)obj19 == obj17;
					obj17 = obj19;
					obj13 = 0;
					obj14 = obj19;
					obj12 = obj18;
					if (flag4)
					{
						goto end_IL_00b1;
					}
				}
				goto IL_01ec;
				IL_01ec:
				throw new InvalidCastException();
				continue;
				end_IL_00b1:
				break;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			nint num3 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v11 (Il2CppClass<KGameVisualControls>)+190]");
			action3..ctor((object)this, (IntPtr)0);
			gameEventChannel.OnGamePerspectiveChanged += action3;
			object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1624;
			object obj21 = obj20;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X0_v21+E4]");
			bool flag5 = (nint)0 == 0;
			object obj22 = !flag5;
			if (obj22 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			bool isPerspectiveTopDown = Preferences.IsPerspectiveTopDown;
			nint num4 = (nint)this;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v15 (Il2CppClass<KGameVisualControls>)+188]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v217 @ X8_v15 (Il2CppClass<KGameVisualControls>)+190]");
			object obj24 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v205 @ X3_v5 (should have been resolved before IL gen)");
		}
	}

	protected virtual void OnGamePerspectiveChanged(bool isTopDown)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00ae: Expected O, but got I4
		object obj = typeof(System.Buffers.Text.ParserHelpers) + 1624;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E8B80]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v1+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Preferences.IsPerspectiveTopDown = isTopDown;
		return;
		IL_0074:
		Preferences.IsPerspectiveTopDown = isTopDown;
	}

	protected virtual void OnBecomingWatcher()
	{
		bottomPlayer.SetActive(value: false);
		bottomWatcher.SetActive(value: true);
		gameEventChannel.TriggerBecomingWatcher();
	}

	protected virtual void OnBecomingPlayer()
	{
		bottomWatcher.SetActive(value: false);
		bottomPlayer.SetActive(value: true);
		gameEventChannel.TriggerBecomingPlayer();
	}

	public Userbox GetActiveUserbox(KPlayer player)
	{
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0061: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0156: Expected O, but got I
		Userbox[] array = allUserboxes;
		if (allUserboxes != null)
		{
			if (array.Length < 1)
			{
				goto IL_0156;
			}
			object obj = allUserboxes + 32;
			object obj2 = 0;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X23_v4+v45 @ X22_v5*8]");
				Component component = (Component)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X23_v4+v45 @ X22_v5*8]");
				if ((nint)0 == 0)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X23_v4+v45 @ X22_v5*8]");
				GameObject gameObject = ((Component)0).gameObject;
				if ((object)gameObject == null)
				{
					break;
				}
				if (gameObject.activeInHierarchy)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v41 @ X20_v6 (UnityEngine.Component)+198]");
					if (0 == (nint)player)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X23_v4+v45 @ X22_v5*8]");
						return (Userbox)0;
					}
				}
				obj2++;
				if ((nint)obj2 < array.Length)
				{
					continue;
				}
				goto IL_0156;
			}
		}
		return (Userbox)(object)new NullReferenceException();
		IL_0156:
		return null;
	}

	public virtual Userbox GetNextPlayerUserbox(KPlayer player)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_008f: Expected I, but got O
		//IL_00b3: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Expected O, but got Unknown
		//IL_021a: Expected O, but got I
		//IL_0103: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_015f: Expected O, but got I4
		//IL_0169: Unknown result type (might be due to invalid IL or missing references)
		//IL_016e: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_01a5: Expected O, but got I4
		//IL_01cd: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1216;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		Func<object, bool> func = null;
		if (!flag)
		{
			object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 176;
			object obj4 = (nint)0 + (nint)3120;
			object obj5 = (nint)0 + (nint)1960;
			object obj6 = obj2 + 16;
			obj6 = player;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Userbox[] activeUserBoxes = ActiveUserBoxes;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Func<object, bool> func2 = default(Func<object, bool>);
			func2..ctor(obj2, (IntPtr)obj4);
			int num = ArraysExtensions.FindIndex(activeUserBoxes, func2);
			object obj7 = num + 1;
			bool flag2 = obj7 == null;
			object obj8 = 0;
			func = func2;
			if (flag2)
			{
				object obj9 = typeof(System.IOAsyncCallback) + 2632;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				IndexOutOfRangeException ex = default(IndexOutOfRangeException);
				ex..ctor();
				object obj10 = (nint)0 + (nint)3320;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
				OutOfMemoryException ex2 = new OutOfMemoryException();
				goto IL_0237;
			}
			Userbox[] activeUserBoxes2 = ActiveUserBoxes;
			bool flag3 = activeUserBoxes2 == null;
			obj8 = 0;
			func = func2;
			if (!flag3)
			{
				Userbox[] activeUserBoxes3 = ActiveUserBoxes;
				bool flag4 = activeUserBoxes3 == null;
				obj8 = 0;
				func = func2;
				if (!flag4)
				{
					object obj11 = num + 1;
					object obj12 = obj11 / activeUserBoxes2.Length;
					object obj13 = obj12 * activeUserBoxes2.Length;
					object obj14 = obj11 - obj13;
					bool flag5 = (nint)obj14 < activeUserBoxes3.Length;
					object obj15 = !flag5;
					if (obj15 == null)
					{
						object obj16 = (object)activeUserBoxes3 + obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v206 @ X8_v6+20]");
						return (Userbox)0;
					}
					goto IL_0237;
				}
			}
		}
		throw new NullReferenceException();
		IL_0237:
		return (Userbox)(object)new IndexOutOfRangeException();
	}
}
