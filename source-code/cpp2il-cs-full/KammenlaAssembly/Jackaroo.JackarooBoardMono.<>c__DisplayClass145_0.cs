using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Dynamic.Utils;
using System.Formats.Asn1;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Threading;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using HuaweiMobileServices.Location.Location;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Server.Models;
using Sfs2X.Entities;
using Unity.Properties;
using Unity.Services.Authentication.Shared;
using UnityEngine;
using UnityEngine.AdaptivePerformance;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.Rendering;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.ResourceProviders;
using UnityEngine.TextCore;
using UnityEngine.UI;

namespace Jackaroo;

public class JackarooBoardMono : MonoBehaviour
{
	[Serializable]
	private sealed class <>c
	{
		public static readonly <>c <>9;

		public static Func<JackarooNode, JackarooNodeMono> <>9__40_0;

		public static Func<JackarooNode, JackarooNodeMono> <>9__138_1;

		public static Func<JackarooNode, JackarooNodeMono> <>9__141_3;

		public static Func<JackarooNode, JackarooNodeMono> <>9__141_1;

		public static Func<JackarooNode, JackarooNodeMono> <>9__142_1;

		public static Func<List<JackarooMarbleMono>> <>9__192_0;

		public static Action<List<JackarooMarbleMono>> <>9__192_1;

		public static Func<JackarooMarble, JackarooMarbleMono> <>9__212_1;

		public static Action<ShowConfettiAnimation> <>9__216_0;

		static <>c()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			object obj3 = obj;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}

		internal JackarooNodeMono <SetupPlantReference>b__40_0(JackarooNode node)
		{
			if (node != null)
			{
				return node.<NodeMono>k__BackingField;
			}
			return (JackarooNodeMono)(object)new NullReferenceException();
		}

		internal JackarooNodeMono <Move>b__138_1(JackarooNode node)
		{
			if (node != null)
			{
				return node.<NodeMono>k__BackingField;
			}
			return (JackarooNodeMono)(object)new NullReferenceException();
		}

		internal JackarooNodeMono <HandleSplitMove>b__141_3(JackarooNode node)
		{
			if (node != null)
			{
				return node.<NodeMono>k__BackingField;
			}
			return (JackarooNodeMono)(object)new NullReferenceException();
		}

		internal JackarooNodeMono <HandleSplitMove>b__141_1(JackarooNode node)
		{
			if (node != null)
			{
				return node.<NodeMono>k__BackingField;
			}
			return (JackarooNodeMono)(object)new NullReferenceException();
		}

		internal JackarooNodeMono <HandleSingleMove>b__142_1(JackarooNode node)
		{
			if (node != null)
			{
				return node.<NodeMono>k__BackingField;
			}
			return (JackarooNodeMono)(object)new NullReferenceException();
		}

		internal List<JackarooMarbleMono> <InitializeGuardedMarblesPool>b__192_0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			object obj = typeof(List<AdaptivePerformanceScaler>) + 1952;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			List<object> list = default(List<object>);
			list..ctor();
			return (List<JackarooMarbleMono>)(object)list;
		}

		internal void <InitializeGuardedMarblesPool>b__192_1(List<JackarooMarbleMono> list)
		{
			int version = list._version + 1;
			list._size = 0;
			list._version = version;
			if (list._size >= 1)
			{
				Array.Clear(list._items, 0, list._size);
			}
		}

		internal JackarooMarbleMono <PlayWinAnimations>b__212_1(JackarooMarble marble)
		{
			if (marble != null)
			{
				return marble.<MarbleMono>k__BackingField;
			}
			return (JackarooMarbleMono)(object)new NullReferenceException();
		}

		internal void <ResetWinAnimations>b__216_0(ShowConfettiAnimation confettiAnimation)
		{
			confettiAnimation.Reset();
		}
	}

	private sealed class <>c__DisplayClass137_0
	{
		public JackarooBoardMono <>4__this;

		public JackarooMarble marbleToDie;

		public JackarooNode graveyardNode;

		public Action onComplete;

		internal void <Plant>b__0()
		{
			<>4__this.MoveMarbleToGraveyard(marbleToDie, graveyardNode);
			JackarooMarble jackarooMarble = marbleToDie;
			jackarooMarble.<MarbleMono>k__BackingField.HideDeath();
		}

		internal void <Plant>b__1()
		{
			JackarooBoardMono jackarooBoardMono = <>4__this;
			Action action = onComplete;
			if (onComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v13.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			jackarooBoardMono.<IsAnimating>k__BackingField = false;
		}
	}

	private sealed class <>c__DisplayClass138_0
	{
		public JackarooBoardMono <>4__this;

		public JackarooMarble marble1;

		public JackarooNode startNode1;

		public JackarooNode lastNode1;

		public Action onComplete;

		internal void <Move>b__0()
		{
			<>4__this.CheckMarbleBlocksBase(marble1);
			<>4__this.CheckMarbleEntryEffect(marble1, startNode1, lastNode1);
			JackarooBoardMono jackarooBoardMono = <>4__this;
			Action action = onComplete;
			if (onComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v50.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			jackarooBoardMono.<IsAnimating>k__BackingField = false;
		}
	}

	private sealed class <>c__DisplayClass140_0
	{
		public JackarooMarble marbleToDie;

		public JackarooNode graveyardNode;

		public JackarooBoardMono <>4__this;

		internal void <HandleEatPathMove>b__0()
		{
			//IL_0026: Expected O, but got I4
			//IL_0098: Expected O, but got I4
			JackarooMarble jackarooMarble = marbleToDie;
			bool flag = marbleToDie == null;
			object obj = !flag;
			object obj2 = ~obj;
			bool flag2 = obj2 != null || graveyardNode == null;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				<>4__this.MoveMarbleToGraveyard(marbleToDie, graveyardNode);
				jackarooMarble.<MarbleMono>k__BackingField.HideDeath();
			}
		}
	}

	private sealed class <>c__DisplayClass141_0
	{
		public JackarooBoardMono <>4__this;

		public JackarooMarble marble1;

		public JackarooNode startNode1;

		public JackarooNode lastNode1;

		public JackarooMarble marble1ToDie;

		public JackarooNode graveyardNode1;

		public IReadOnlyList<JackarooNode> nodes2;

		public JackarooMarble marble2;

		public JackarooNode lastNode2;

		public JackarooNode startNode2;

		public JackarooMarble marble2ToDie;

		public JackarooNode graveyardNode2;

		public Action onComplete;

		public Action <>9__2;

		internal void <HandleSplitMove>b__0()
		{
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_00fd: Expected I, but got O
			//IL_010d: Expected O, but got I
			//IL_01d5: Expected O, but got I4
			//IL_0148: Expected O, but got I
			//IL_0236: Expected I, but got O
			//IL_0246: Expected O, but got I
			//IL_02fc: Expected O, but got I4
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Expected O, but got Unknown
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Expected O, but got Unknown
			//IL_0281: Expected O, but got I
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Expected O, but got Unknown
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Expected O, but got Unknown
			//IL_039a: Unknown result type (might be due to invalid IL or missing references)
			//IL_039f: Expected O, but got Unknown
			//IL_03a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_03aa: Expected O, but got Unknown
			//IL_04f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fc: Expected O, but got Unknown
			//IL_0512: Expected O, but got I
			//IL_0520: Expected I, but got O
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0324: Expected O, but got Unknown
			//IL_032d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0332: Expected O, but got Unknown
			//IL_056d: Expected O, but got I4
			//IL_028f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0294: Expected O, but got Unknown
			//IL_029d: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a2: Expected O, but got Unknown
			//IL_0442: Expected O, but got I
			//IL_0452: Expected O, but got I
			//IL_0474: Expected O, but got I4
			//IL_06a8: Expected O, but got I4
			//IL_04a4: Expected O, but got I4
			//IL_06bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_06c1: Expected O, but got Unknown
			//IL_06d7: Expected O, but got I
			//IL_06e8: Expected I, but got O
			//IL_0706: Expected O, but got I
			//IL_04d4: Expected O, but got I
			<>4__this.CheckMarbleBlocksBase(marble1);
			JackarooNode jackarooNode = startNode1;
			JackarooNode jackarooNode2 = lastNode1;
			<>4__this.CheckMarbleEntryEffect(marble1, startNode1, lastNode1);
			JackarooMarble jackarooMarble = marble1ToDie;
			if (marble1ToDie != null)
			{
				jackarooNode = graveyardNode1;
				if (graveyardNode1 != null)
				{
					<>4__this.MoveMarbleToGraveyard(marble1ToDie, graveyardNode1);
					jackarooMarble.<MarbleMono>k__BackingField.HideDeath();
				}
			}
			IReadOnlyList<JackarooNode> readOnlyList = nodes2;
			object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2264;
			nint num = (nint)readOnlyList;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v4 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			object obj2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v4 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0189;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v303 @ X8_v4 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
			object obj3 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X10_v12-8]");
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
				goto IL_0189;
			}
			object obj4 = num + obj3;
			object obj5 = obj4 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v335 @ X0_v45] (should have been resolved before IL gen)");
			int nodesCount = default(int);
			float durationForNodes = GetDurationForNodes(nodesCount);
			IReadOnlyList<JackarooNode> readOnlyList2 = nodes2;
			goto IL_022e;
			IL_0189:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v320 @ X0_v42] (should have been resolved before IL gen)");
			int nodesCount2 = default(int);
			durationForNodes = GetDurationForNodes(nodesCount2);
			readOnlyList2 = nodes2;
			bool flag = nodes2 == null;
			object obj6 = !flag;
			jackarooNode = null;
			if (obj6 != null)
			{
				goto IL_022e;
			}
			goto IL_05f6;
			IL_022e:
			nint num2 = (nint)readOnlyList2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02c2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v6 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
			object obj8 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X10_v7-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj8 += 16;
				obj7--;
				if ((nint)obj7 != 1)
				{
					continue;
				}
				goto IL_02c2;
			}
			object obj9 = num2 + obj8;
			object obj10 = obj9 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v389 @ X0_v37] (should have been resolved before IL gen)");
			JackarooBoardMono jackarooBoardMono = <>4__this;
			object obj12 = default(object);
			object obj11 = obj12;
			goto IL_0353;
			IL_0430:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v18+B8]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v17+18]");
			Func<object, object> selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v17+18]");
			bool flag2 = (nint)0 == 0;
			object obj14 = !flag2;
			object obj17;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v18+E4]");
				bool flag3 = (nint)0 == 0;
				object obj15 = !flag3;
				if (obj15 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj16 = obj17;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v23+B8]");
					obj13 = 0;
				}
				object obj18 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2120;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj19 = (nint)0 + (nint)1496;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj13, (IntPtr)obj19);
				object obj20 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v463 @ X8_v22+B8]");
				object obj21 = (nint)0 + (nint)24;
				obj21 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			float duration = durationForNodes / (float)obj11;
			IEnumerable<object> source2;
			IEnumerable<object> source = Enumerable.Select(source2, selector);
			object[] nodes = Enumerable.ToArray(source);
			JackarooBoardMono jackarooBoardMono2;
			Action action;
			<>4__this.MoveMarble(marble2, duration, jackarooBoardMono2._moveClips, action, null, 0, isPlant: false, (GameAction?)(object)0, (JackarooNodeMono[])nodes);
			return;
			IL_05f6:
			throw new NullReferenceException();
			IL_02c2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v372 @ X0_v33] (should have been resolved before IL gen)");
			jackarooBoardMono = <>4__this;
			bool flag4 = (object)<>4__this == null;
			object obj22 = !flag4;
			object obj23 = default(object);
			obj11 = obj23;
			if (obj22 != null)
			{
				goto IL_0353;
			}
			goto IL_05f6;
			IL_0353:
			JackarooMarble jackarooMarble2 = marble2;
			JackarooNode jackarooNode3 = lastNode2;
			jackarooBoardMono.OnPreMove(marble2, lastNode2);
			jackarooBoardMono2 = <>4__this;
			obj17 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 304;
			object obj24 = this + 120;
			action = (Action)obj24;
			Action action2;
			JackarooNode jackarooNode4;
			JackarooNode jackarooNode5;
			IEnumerable<object> enumerable;
			object obj25;
			if (obj24 != null)
			{
				obj25 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v18+E4]");
				bool flag5 = (nint)0 == 0;
				source2 = nodes2;
				action2 = action;
				jackarooNode4 = jackarooNode2;
				jackarooNode5 = jackarooNode3;
				object obj26 = obj25;
				enumerable = nodes2;
				if (!flag5)
				{
					goto IL_0430;
				}
			}
			else
			{
				object obj27 = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj28 = (nint)0 + (nint)1592;
				Action action3 = default(Action);
				action3..ctor(this, (IntPtr)obj28);
				<>9__2 = action3;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				source2 = nodes2;
				obj25 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v423 @ X0_v18+E4]");
				bool flag6 = (nint)0 == 0;
				object obj29 = !flag6;
				action = action3;
				jackarooNode2 = null;
				jackarooNode3 = (JackarooNode)obj28;
				action2 = action3;
				jackarooNode4 = null;
				jackarooNode5 = (JackarooNode)obj28;
				jackarooMarble2 = (JackarooMarble)(object)action3;
				object obj26 = obj25;
				enumerable = nodes2;
				if (obj29 != null)
				{
					goto IL_0430;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj25 = obj17;
			action = action2;
			jackarooNode2 = jackarooNode4;
			jackarooNode3 = jackarooNode5;
			source2 = enumerable;
			goto IL_0430;
		}

		internal void <HandleSplitMove>b__2()
		{
			<>4__this.CheckMarbleBlocksBase(marble2);
			JackarooNode jackarooNode = startNode2;
			<>4__this.CheckMarbleEntryEffect(marble2, startNode2, lastNode2);
			JackarooBoardMono jackarooBoardMono = <>4__this;
			JackarooMarble jackarooMarble = marble2ToDie;
			if (marble2ToDie != null)
			{
				jackarooNode = graveyardNode2;
				if (graveyardNode2 != null)
				{
					jackarooBoardMono.MoveMarbleToGraveyard(marble2ToDie, graveyardNode2);
					jackarooMarble.<MarbleMono>k__BackingField.HideDeath();
					jackarooBoardMono = <>4__this;
				}
			}
			Action action = onComplete;
			if (onComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v65.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			jackarooBoardMono.<IsAnimating>k__BackingField = false;
		}
	}

	private sealed class <>c__DisplayClass142_0
	{
		public JackarooBoardMono <>4__this;

		public JackarooMarble marble1;

		public JackarooNode startNode1;

		public JackarooNode lastNode1;

		public JackarooMarble marble1ToDie;

		public JackarooNode graveyardNode1;

		public Action onComplete;

		internal void <HandleSingleMove>b__0()
		{
			<>4__this.CheckMarbleBlocksBase(marble1);
			JackarooNode jackarooNode = startNode1;
			<>4__this.CheckMarbleEntryEffect(marble1, startNode1, lastNode1);
			JackarooBoardMono jackarooBoardMono = <>4__this;
			JackarooMarble jackarooMarble = marble1ToDie;
			if (marble1ToDie != null)
			{
				jackarooNode = graveyardNode1;
				if (graveyardNode1 != null)
				{
					jackarooBoardMono.MoveMarbleToGraveyard(marble1ToDie, graveyardNode1);
					jackarooMarble.<MarbleMono>k__BackingField.HideDeath();
					jackarooBoardMono = <>4__this;
				}
			}
			Action action = onComplete;
			if (onComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v65.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			jackarooBoardMono.<IsAnimating>k__BackingField = false;
		}
	}

	private sealed class <>c__DisplayClass143_0
	{
		public JackarooNodeMono node;

		public List<JackarooMoveStep> moveSteps;

		public int index;

		public Action<JackarooMarble, JackarooNode> stepAction;

		public bool useDefaultSound;

		public AudioClip[] audioClips;

		public JackarooBoardMono <>4__this;

		public JackarooNodeMono[] nodes;

		public Action onCompleteAction;

		public JackarooMarble marble;

		public float duration;

		public GameAction? emote;

		internal void <MoveMarble>b__0()
		{
			//IL_0280: Expected O, but got I4
			//IL_006b: Expected O, but got I
			//IL_044e: Expected O, but got I4
			//IL_01b4: Expected O, but got I4
			//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c1: Expected I4, but got Unknown
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Expected O, but got Unknown
			//IL_00fe: Expected O, but got I
			//IL_0242: Expected O, but got I
			//IL_0361: Expected O, but got I
			if ((object)node == null)
			{
				goto IL_03b4;
			}
			node.RestoreDefaultColor();
			List<object> list = (List<object>)(object)moveSteps;
			if (moveSteps != null && list._size > index)
			{
				object obj = (nint)0 + (nint)2400;
				object obj2 = ((List<object>)(object)moveSteps).get_Item(index);
				if (obj2 != null)
				{
					if (moveSteps != null)
					{
						object obj3 = ((List<object>)(object)moveSteps).get_Item(index);
						if (obj3 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v18 (System.Object)+20]");
							object obj4 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v18 (System.Object)+20]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v360 @ X8_v16+18] (should have been resolved before IL gen)");
							}
							Action<JackarooMarble, JackarooNode> action = stepAction;
							if (stepAction != null)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X8_v17 (System.Action`2<Jackaroo.JackarooMarble, Jackaroo.JackarooNode>)+18] (should have been resolved before IL gen)");
								goto IL_03e8;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v18 (System.Object)+28]");
							object obj5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v18 (System.Object)+28]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v175 @ X8_v18+18] (should have been resolved before IL gen)");
								if (useDefaultSound)
								{
									goto IL_0141;
								}
								goto IL_0247;
							}
						}
					}
					goto IL_03b4;
				}
			}
			goto IL_03e8;
			IL_0247:
			JackarooNodeMono[] array = nodes;
			if (nodes != null)
			{
				object obj6 = array.Length - 1;
				if (index == (nint)obj6)
				{
					Action action2 = onCompleteAction;
					if (onCompleteAction == null)
					{
						return;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v321.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				}
				int num = ++index;
				if ((object)<>4__this != null)
				{
					<>4__this.MoveMarble(marble, duration, audioClips, onCompleteAction, moveSteps, num, isPlant: false, emote, nodes);
					return;
				}
			}
			goto IL_03b4;
			IL_0141:
			AudioClip[] array2 = audioClips;
			if (audioClips != null)
			{
				int num2 = index;
				if (index >= array2.Length)
				{
					int num3 = index / array2.Length;
					object obj7 = num3 * array2.Length;
					num2 -= obj7;
				}
				bool flag = num2 < array2.Length;
				object obj8 = !flag;
				if (obj8 != null)
				{
					goto IL_03c2;
				}
				object obj9 = audioClips + num2;
				GameSoundManager instance = GameSoundManager.Instance;
				JackarooBoardMono jackarooBoardMono = <>4__this;
				if ((object)<>4__this != null && (object)instance != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v13+20]");
					instance.PlaySound((AudioClip)0, jackarooBoardMono._volume);
					goto IL_0247;
				}
			}
			goto IL_03b4;
			IL_03e8:
			if (useDefaultSound)
			{
				goto IL_0141;
			}
			goto IL_0247;
			IL_03b4:
			NullReferenceException ex = new NullReferenceException();
			goto IL_03c2;
			IL_03c2:
			throw new IndexOutOfRangeException();
		}
	}

	private sealed class <>c__DisplayClass144_0
	{
		public JackarooBoardMono <>4__this;

		public JackarooMarble marble1;

		public JackarooMarble marble2;

		public Action onComplete;

		internal void <SwapSimultaneous>b__0()
		{
			<>4__this.CheckMarbleBlocksBase(marble1);
		}

		internal void <SwapSimultaneous>b__1()
		{
			<>4__this.CheckMarbleBlocksBase(marble2);
			JackarooBoardMono jackarooBoardMono = <>4__this;
			Action action = onComplete;
			if (onComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			jackarooBoardMono.<IsAnimating>k__BackingField = false;
		}
	}

	private sealed class <>c__DisplayClass145_0
	{
		public JackarooBoardMono <>4__this;

		public JackarooMarble marble1;

		public JackarooMarble marble2;

		public Action onComplete;

		public JackarooNode node1;

		public Action <>9__1;

		internal void <SwapSequential>b__0()
		{
			//IL_0430: Expected O, but got I
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Expected O, but got Unknown
			//IL_004a: Expected O, but got I
			//IL_00fa: Expected O, but got I4
			//IL_00b7: Expected O, but got I4
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a0: Expected O, but got Unknown
			//IL_01c2: Expected O, but got I4
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Expected O, but got Unknown
			//IL_01fa: Expected O, but got I
			//IL_0208: Expected I, but got O
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0273: Expected O, but got Unknown
			//IL_0295: Expected O, but got I4
			//IL_02c0: Expected O, but got I4
			//IL_02d6: Expected I, but got O
			//IL_02e6: Expected O, but got I
			//IL_030f: Expected O, but got I
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Expected O, but got Unknown
			//IL_03e4: Expected O, but got I4
			bool flag = (object)<>4__this == null;
			IntPtr intPtr = default(IntPtr);
			JackarooMarble jackarooMarble = (JackarooMarble)(nint)intPtr;
			RemoteConfigModel current;
			if (!flag)
			{
				jackarooMarble = marble1;
				<>4__this.CheckMarbleBlocksBase(marble1);
				object obj = typeof(RegisteredWaitHandle) + 56;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F84]");
				object obj2 = (nint)0 & (nint)1;
				if (obj2 != null)
				{
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v25+E4]");
					if ((nint)0 != 0)
					{
						goto IL_0094;
					}
				}
				else
				{
					_ = 1;
					object obj3 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v25+E4]");
					bool flag2 = (nint)0 == 0;
					object obj4 = !flag2;
					if (obj4 != null)
					{
						goto IL_0094;
					}
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				current = RemoteConfig.Current;
				if (current != null)
				{
					goto IL_013d;
				}
			}
			goto IL_03e5;
			IL_013d:
			JackarooConfig <Jackaroo>k__BackingField = current.<Jackaroo>k__BackingField;
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			if (current.<Jackaroo>k__BackingField != null)
			{
				JackarooBoardMono jackarooBoardMono = <>4__this;
				if ((object)<>4__this != null)
				{
					object obj5 = this + 56;
					Action onCompleteAction = (Action)obj5;
					bool flag3 = obj5 == null;
					object obj6 = !flag3;
					if (obj6 == null)
					{
						object obj7 = typeof(SqlSingle[]) + 2376;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						object obj8 = (nint)0 + (nint)1640;
						Action action = default(Action);
						action..ctor(this, (IntPtr)obj8);
						<>9__1 = action;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						onCompleteAction = action;
						jackarooMarble = (JackarooMarble)(object)action;
					}
					JackarooNode jackarooNode = node1;
					if (node1 != null)
					{
						object obj9 = typeof(TypeConverter<ushort, char>) + 3128;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
						JackarooNodeMono[] array = default(JackarooNodeMono[]);
						bool flag4 = array == null;
						jackarooMarble = (JackarooMarble)1;
						if (!flag4)
						{
							bool flag5 = (object)jackarooNode.<NodeMono>k__BackingField == null;
							JackarooMarble jackarooMarble2 = (JackarooMarble)1;
							if (!flag5)
							{
								nint num = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v13 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
								jackarooMarble2 = (JackarooMarble)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag6 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v13 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
								jackarooMarble = (JackarooMarble)0;
								if (flag6)
								{
									goto IL_0401;
								}
							}
							bool flag7 = array.Length == 0;
							jackarooMarble = jackarooMarble2;
							if (flag7)
							{
								goto IL_03f3;
							}
							object obj10 = array + 32;
							obj10 = jackarooNode.<NodeMono>k__BackingField;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag8 = (object)<>4__this == null;
							jackarooMarble = (JackarooMarble)(object)jackarooNode.<NodeMono>k__BackingField;
							if (!flag8)
							{
								float duration = <Jackaroo>k__BackingField.<MinMarbleMoveDuration>k__BackingField + <Jackaroo>k__BackingField.<MinMarbleMoveDuration>k__BackingField;
								<>4__this.MoveMarble(marble2, duration, jackarooBoardMono._moveClips, onCompleteAction, null, 0, isPlant: false, (GameAction?)(object)0, array);
								return;
							}
						}
					}
				}
			}
			goto IL_03e5;
			IL_03e5:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_03f3;
			IL_0401:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
			throw new OutOfMemoryException();
			IL_03f3:
			ex = new IndexOutOfRangeException();
			goto IL_0401;
			IL_0094:
			current = RemoteConfig.Current;
			bool flag9 = current == null;
			object obj11 = !flag9;
			if (obj11 != null)
			{
				goto IL_013d;
			}
			goto IL_03e5;
		}

		internal void <SwapSequential>b__1()
		{
			<>4__this.CheckMarbleBlocksBase(marble2);
			JackarooBoardMono jackarooBoardMono = <>4__this;
			Action action = onComplete;
			if (onComplete != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v36.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			jackarooBoardMono.<IsAnimating>k__BackingField = false;
		}
	}

	private sealed class <>c__DisplayClass201_0
	{
		public int baseIndex;

		public JackarooBoardMono <>4__this;

		internal void <GetUnblockBaseAction>b__0()
		{
			<>4__this.UnblockBase(baseIndex);
		}
	}

	private sealed class <>c__DisplayClass212_0
	{
		public IReadOnlyList<JackarooNode> playerBaseNodes;

		public JackarooBoardMono <>4__this;

		internal int <PlayWinAnimations>b__0(JackarooMarble marble1, JackarooMarble marble2)
		{
			//IL_006b: Expected I4, but got O
			//IL_0011: Expected O, but got I
			if (marble1 != null)
			{
				object obj = (nint)0 + (nint)2464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97238");
				if (marble2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97238");
					int num = default(int);
					int value = default(int);
					return num.CompareTo(value);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass212_1
	{
		public int index;

		public <>c__DisplayClass212_0 CS$<>8__locals1;

		internal void <PlayWinAnimations>b__2()
		{
			GameSoundManager instance = GameSoundManager.Instance;
			<>c__DisplayClass212_0 cS$<>8__locals = CS$<>8__locals1;
			JackarooBoardMono <>4__this = cS$<>8__locals.<>4__this;
			object clip = ((List<object>)(object)<>4__this._fireWorksAudioClips).get_Item(index);
			<>c__DisplayClass212_0 cS$<>8__locals2 = CS$<>8__locals1;
			JackarooBoardMono <>4__this2 = cS$<>8__locals2.<>4__this;
			instance.PlaySound((AudioClip)clip, <>4__this2._volume);
		}
	}

	private sealed class <>c__DisplayClass215_0
	{
		public IReadOnlyList<JackarooNode> playerBaseNodes;

		internal int <AllMarblesInBaseCelebrationIe>b__0(JackarooMarble marble1, JackarooMarble marble2)
		{
			//IL_006b: Expected I4, but got O
			//IL_0011: Expected O, but got I
			if (marble1 != null)
			{
				object obj = (nint)0 + (nint)2464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97238");
				if (marble2 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97238");
					int num = default(int);
					int value = default(int);
					return num.CompareTo(value);
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	private sealed class <>c__DisplayClass24_0
	{
		public JackarooBoardMono <>4__this;

		public JackarooLastActionInfo lastActionInfo;

		public GameAction? emote;

		internal void <OnPlayerDidLastAction>b__0()
		{
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_0113: Expected O, but got I4
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Expected O, but got Unknown
			//IL_00a3: Expected O, but got I
			//IL_00b6: Expected I, but got O
			JackarooBoardMono jackarooBoardMono = <>4__this;
			object severMarbles = ((Queue<object>)(object)jackarooBoardMono._snapshotQueue).Dequeue();
			if (jackarooBoardMono.DoCheckWithServer((int[][])severMarbles))
			{
				JackarooLastActionInfo jackarooLastActionInfo = lastActionInfo;
				JackarooBoardMono jackarooBoardMono2 = <>4__this;
				int rotatedPlayerIndex = jackarooBoardMono2.<Game>k__BackingField.GetRotatedPlayerIndex(((LastActionInfo)jackarooLastActionInfo).<ActionPlayer>k__BackingField);
				JackarooMove move = <>4__this.ToJackarooMove(lastActionInfo, rotatedPlayerIndex);
				object obj = typeof(SqlSingle[]) + 2376;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj2 = (nint)0 + (nint)416;
				Action action = default(Action);
				action..ctor(<>4__this, (IntPtr)obj2);
				<>4__this.DoPlayJackarooMove(move, action, emote);
			}
			else
			{
				object obj3 = typeof(RegisteredWaitHandle) + 3136;
				object obj4 = obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v9+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
			}
		}
	}

	private sealed class <>c__DisplayClass27_0
	{
		public JackarooBoardMono <>4__this;

		public JackarooMove move;

		public GameAction? emote;

		internal void <PlayJackarooMove>b__0()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0020: Expected O, but got I
			//IL_005e: Expected I, but got O
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = (nint)0 + (nint)416;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(<>4__this, (IntPtr)obj2);
			<>4__this.DoPlayJackarooMove(move, action, emote);
		}
	}

	private sealed class <>c__DisplayClass33_0
	{
		public JackarooBoardMono <>4__this;

		public bool isTopDown;

		internal void <InitPerspective>b__0()
		{
			<>4__this.OnGamePerspectiveChanged(isTopDown);
		}
	}

	private sealed class <>c__DisplayClass46_0
	{
		public int marbleIndex;

		internal bool <DoCheckWithServer>b__0(int playerServerMarble)
		{
			//IL_000f: Expected O, but got I4
			object obj = playerServerMarble - marbleIndex;
			return obj == null;
		}
	}

	private sealed class <>c__DisplayClass46_1
	{
		public int playerServerMarble;

		internal bool <DoCheckWithServer>b__2(int marbleIndex)
		{
			//IL_000f: Expected O, but got I4
			object obj = playerServerMarble - marbleIndex;
			return obj == null;
		}
	}

	private sealed class <AllMarblesInBaseCelebrationIe>d__215 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public JackarooBoardMono <>4__this;

		public int rotatedPlayerIndex;

		private List<JackarooMarble> <marbles>5__2;

		private float <volumeStep>5__3;

		private float <pitchStep>5__4;

		private int <i>5__5;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <AllMarblesInBaseCelebrationIe>d__215(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0318: Expected I4, but got I8
			//IL_053d: Expected I4, but got O
			//IL_0021: Expected O, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Expected O, but got Unknown
			//IL_03e4: Expected O, but got I
			//IL_00c9: Expected O, but got I
			//IL_00d9: Expected O, but got I4
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e7: Expected I4, but got Unknown
			//IL_00f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Expected O, but got Unknown
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0439: Expected O, but got I4
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b6: Expected O, but got Unknown
			//IL_0134: Unsupported input type for neg.
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0139: Expected I4, but got Unknown
			//IL_04f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f6: Expected O, but got Unknown
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014c: Expected O, but got Unknown
			//IL_019e: Expected O, but got I
			//IL_01dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Expected O, but got Unknown
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Expected O, but got Unknown
			//IL_0223: Expected O, but got I
			//IL_0234: Expected I, but got O
			//IL_02d7: Expected O, but got I4
			JackarooBoardMono jackarooBoardMono = <>4__this;
			List<object> list2;
			int num5;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj != null)
				{
					goto IL_0521;
				}
				<>1__state = -1;
				object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 400;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj3 = default(object);
				obj3..ctor();
				if ((object)<>4__this != null)
				{
					JackarooBoard <Board>k__BackingField = jackarooBoardMono.<Board>k__BackingField;
					if (jackarooBoardMono.<Board>k__BackingField != null && <Board>k__BackingField._basesNodes != null)
					{
						object obj4 = (nint)0 + (nint)3000;
						object obj5 = 5 - rotatedPlayerIndex;
						int num = obj5 & 3;
						object obj6 = 0 - obj5;
						object obj7 = obj6 & 3;
						int index = ((0 >= (nint)obj6) ? (0 - obj7) : num);
						object obj8 = ((List<object>)(object)<Board>k__BackingField._basesNodes).get_Item(index);
						if (obj3 != null)
						{
							object obj9 = obj3 + 16;
							obj9 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							JackarooBoard <Board>k__BackingField2 = jackarooBoardMono.<Board>k__BackingField;
							if (jackarooBoardMono.<Board>k__BackingField != null && <Board>k__BackingField2._playersPlantedMarbles != null)
							{
								object obj10 = (nint)0 + (nint)2968;
								int index2 = rotatedPlayerIndex - 1;
								object source = ((List<object>)(object)<Board>k__BackingField2._playersPlantedMarbles).get_Item(index2);
								List<object> list = Enumerable.ToList((IEnumerable<object>)source);
								object obj11 = this + 48;
								obj11 = list;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj12 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3384;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj13 = (nint)0 + (nint)1672;
								Comparison<object> comparison = default(Comparison<object>);
								comparison..ctor(obj3, (IntPtr)obj13);
								if (obj11 != null)
								{
									((List<object>)obj11).Sort(comparison);
									double num2 = (double)jackarooBoardMono._volume * 0.25;
									<volumeStep>5__3 = (float)num2;
									list2 = (List<object>)(object)<marbles>5__2;
									if (<marbles>5__2 != null)
									{
										float num3 = jackarooBoardMono.startPitch - jackarooBoardMono.endPitch;
										object obj14 = list2._size - 1;
										float num4 = num3 / (float)obj14;
										<pitchStep>5__4 = num4;
										<i>5__5 = 0;
										num5 = 0;
										goto IL_035b;
									}
								}
							}
						}
					}
				}
			}
			else
			{
				<>1__state = -1;
				num5 = ++<i>5__5;
				list2 = (List<object>)(object)<marbles>5__2;
				if (<marbles>5__2 != null)
				{
					goto IL_035b;
				}
			}
			goto IL_052f;
			IL_052f:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
			IL_035b:
			if (num5 >= list2._size)
			{
				goto IL_0521;
			}
			object obj15 = list2.get_Item(num5);
			if (obj15 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v8 (System.Object)+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X0_v8 (System.Object)+18]");
					((JackarooMarbleMono)0).PlayEntryEffect();
					if ((object)<>4__this != null)
					{
						GameSoundManager instance = GameSoundManager.Instance;
						if ((object)instance != null)
						{
							object obj16 = <i>5__5 + 1;
							float volume = <volumeStep>5__3 * (float)obj16;
							float num6 = <pitchStep>5__4 * (float)<i>5__5;
							float pitch = jackarooBoardMono.startPitch - num6;
							AudioSource audioSource = instance.PlayClipWithExtras(jackarooBoardMono._baseEntryClip, jackarooBoardMono._soundOptions, volume, pitch);
							object obj17 = typeof(UsageHint) + 1640;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							float seconds = jackarooBoardMono._delayBetweenFireworks + jackarooBoardMono._fireworksAudioDelay;
							WaitForSeconds waitForSeconds = default(WaitForSeconds);
							waitForSeconds..ctor(seconds);
							object obj18 = this + 24;
							obj18 = waitForSeconds;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							_ = 1;
							return true;
						}
					}
				}
			}
			goto IL_052f;
			IL_0521:
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1720;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private sealed class <MovesRunnerIe>d__116 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public JackarooBoardMono <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <MovesRunnerIe>d__116(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0240: Expected O, but got I
			//IL_024c: Expected O, but got I
			//IL_0052: Expected I4, but got I8
			//IL_006e: Expected O, but got I4
			//IL_0294: Expected O, but got I4
			//IL_0021: Expected O, but got I4
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ec: Expected O, but got Unknown
			//IL_01f5: Expected O, but got I4
			//IL_003e: Expected I4, but got I8
			//IL_010f: Expected I, but got O
			//IL_0097: Expected I, but got O
			//IL_01ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected O, but got Unknown
			object obj = (nint)0 + (nint)880;
			object obj2 = (nint)0 + (nint)864;
			JackarooBoardMono jackarooBoardMono = <>4__this;
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj3 = !flag;
				if (obj3 == null)
				{
					<>1__state = -1;
					goto IL_0126;
				}
				goto IL_01bf;
			}
			<>1__state = -1;
			bool flag2 = (object)<>4__this == null;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				goto IL_01c5;
			}
			goto IL_0275;
			IL_0275:
			bool flag3 = !jackarooBoardMono.<IsAnimating>k__BackingField;
			object obj5 = !flag3;
			if (obj5 == null)
			{
				if (jackarooBoardMono._movesQueue != null)
				{
					nint num = (nint)obj2;
					object obj6 = ((Queue<object>)(object)jackarooBoardMono._movesQueue).Dequeue();
					goto IL_0126;
				}
				goto IL_01c5;
			}
			object obj7 = this + 24;
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return true;
			IL_01d3:
			NullReferenceException ex = new NullReferenceException();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			bool result = default(bool);
			return result;
			IL_01bf:
			return false;
			IL_0126:
			if ((object)<>4__this != null)
			{
				Queue<object> movesQueue = (Queue<object>)(object)jackarooBoardMono._movesQueue;
				if (jackarooBoardMono._movesQueue != null)
				{
					if (movesQueue._size > 0)
					{
						jackarooBoardMono.<IsAnimating>k__BackingField = true;
						nint num = (nint)obj;
						object obj8 = ((Queue<object>)(object)jackarooBoardMono._movesQueue).Peek();
						if (obj8 == null)
						{
							goto IL_01d3;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X0_v22 (System.Object)+28]");
						num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v229 @ X0_v22 (System.Object)+18] (should have been resolved before IL gen)");
						goto IL_0275;
					}
					jackarooBoardMono._movesRunnerIE = null;
					object obj9 = <>4__this + 272;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					goto IL_01bf;
				}
			}
			goto IL_01c5;
			IL_01c5:
			NullReferenceException ex2 = new NullReferenceException();
			goto IL_01d3;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		void IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0042: Expected O, but got I
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			object obj2 = (nint)0 + (nint)1728;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private JackarooBoard <Board>k__BackingField;

	private CanvasGroup _boardCanvasGroup;

	private float _plantReferenceMultiplier;

	private bool _playerSwitchedSeat;

	private bool _boardInitialized;

	private GameObject jackarooSpineBoard;

	private Transform _p1_PlantReference;

	private Transform _p2_PlantReference;

	private Transform _p3_PlantReference;

	private Transform _p4_PlantReference;

	private readonly Queue<int[][]> _snapshotQueue;

	private bool <Initialized>k__BackingField;

	private JackarooGame <Game>k__BackingField;

	private CardGameVisualControls _visualControls;

	private Transform _boardTransform;

	private Image <BoardImage>k__BackingField;

	private float _localPositionY;

	private float _localRotationX;

	private RectTransform _nodesParent;

	private RectTransform _effectsLayer;

	private JackarooTurnIndicator _turnIndicator;

	private JackarooNodeMono _nodePrefab;

	private Transform _p1Home;

	private Transform _graveyard1;

	private Transform _graveyard2;

	private Transform _graveyard3;

	private Transform _graveyard4;

	private GameEventsChannel _gameEventsChannel;

	private float _verticalOffset;

	private float _horizontalOffset;

	private float _baseVerticalOffset;

	private float _baseHorizontalOffset;

	private float _graveyardVerticalOffset;

	private float _graveyardHorizontalOffset;

	private JackarooMarbleMono _marblePrefab;

	private readonly Queue<Action> _movesQueue;

	private IEnumerator _movesRunnerIE;

	private AudioClip _plantAudioClip;

	private AudioClip[] _moveClips;

	private AudioClip[] _breakClips;

	private AudioClip _baseEntryClip;

	private bool _swapAtSameTime;

	private float _volume;

	private float startPitch;

	private float endPitch;

	private readonly List<JackarooMoveStep> _jackarooMoveSteps;

	private bool <IsAnimating>k__BackingField;

	private bool <IsMovingToGraveyard>k__BackingField;

	private JackarooTheme _defaultTheme;

	private JackarooThemeData _runtimeTheme;

	private Image[] _baseColors;

	private readonly List<JackarooMarbleMono> _deathMarbles;

	private List<JackarooMarbleMono> _guardedMarbles;

	private readonly List<JackarooNodeMono> _selectedNodes;

	private readonly List<JackarooNodeMono> _highlightedFirstNodes;

	private readonly List<JackarooNodeMono> _highlightedLastNodes;

	private readonly Dictionary<Card, List<JackarooMarbleMono>> _guardedMarblesDictionary;

	private PooledObjectList<List<JackarooMarbleMono>> _pooledGuardedMarbles;

	private float _blockedBaseFadeSpeed;

	private float _totalAnimationDuration;

	private List<AudioClip> _fireWorksAudioClips;

	private readonly List<int> _winnerPlayersIndices;

	private readonly List<List<JackarooMarbleMono>> _winnerPlayersMarbles;

	private float _delayBetweenFireworks;

	private ShowConfettiAnimation[] _showConfettiAnimation;

	private float _fireworksAudioDelay;

	private readonly SoundOptions _soundOptions;

	public JackarooBoard Board
	{
		get
		{
			return <Board>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 32;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public bool Initialized
	{
		get
		{
			return <Initialized>k__BackingField;
		}
		private set
		{
			<Initialized>k__BackingField = value;
		}
	}

	private static float MinDuration
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F84]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			goto IL_0100;
			IL_0100:
			JackarooConfig <Jackaroo>k__BackingField = current.<Jackaroo>k__BackingField;
			return <Jackaroo>k__BackingField.<MinMarbleMoveDuration>k__BackingField;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0100;
		}
	}

	private static float MaxDuration
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_00da: Expected O, but got I4
			//IL_0097: Expected O, but got I4
			object obj = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F85]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0074;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v4+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = !flag;
				if (obj4 != null)
				{
					goto IL_0074;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			RemoteConfigModel current = RemoteConfig.Current;
			goto IL_0100;
			IL_0100:
			JackarooConfig <Jackaroo>k__BackingField = current.<Jackaroo>k__BackingField;
			return <Jackaroo>k__BackingField.<MaxMarbleMoveDuration>k__BackingField;
			IL_0074:
			current = RemoteConfig.Current;
			bool flag2 = current == null;
			object obj5 = !flag2;
			if (obj5 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0100;
		}
	}

	private JackarooGame Game
	{
		get
		{
			return <Game>k__BackingField;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 112;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private KPlayer MyPlayer
	{
		get
		{
			if ((object)<Game>k__BackingField != null)
			{
				return <Game>k__BackingField.MyPlayer;
			}
			return (KPlayer)(object)new NullReferenceException();
		}
	}

	private int MyPlayerIndex
	{
		get
		{
			//IL_00b4: Expected I4, but got O
			if ((object)<Game>k__BackingField != null)
			{
				if (<Game>k__BackingField.IsSpectator)
				{
					return 1;
				}
				if ((object)<Game>k__BackingField != null)
				{
					CardGamePlayer myPlayer = <Game>k__BackingField.MyPlayer;
					if (myPlayer != null)
					{
						return ((KPlayer)myPlayer).<Index>k__BackingField;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public int TeamMateIndex
	{
		get
		{
			//IL_00b4: Expected I4, but got O
			if ((object)<Game>k__BackingField != null)
			{
				if (<Game>k__BackingField.IsSpectator)
				{
					return 3;
				}
				if ((object)<Game>k__BackingField != null)
				{
					CardGamePlayer myTeammate = <Game>k__BackingField.MyTeammate;
					if (myTeammate != null)
					{
						return ((KPlayer)myTeammate).<Index>k__BackingField;
					}
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (int)ex;
		}
	}

	public Image BoardImage
	{
		get
		{
			return <BoardImage>k__BackingField;
		}
		private set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			object obj = this + 136;
			obj = value;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private float VerticalOffset => _verticalOffset;

	private float HorizontalOffset => _horizontalOffset;

	private float BaseVerticalOffset => _baseVerticalOffset;

	private float BaseHorizontalOffset => _baseHorizontalOffset;

	private float GraveyardVertical2Offset => _graveyardVerticalOffset;

	private float GraveyardHorizontal2Offset => _graveyardHorizontalOffset;

	private bool IsAnimating
	{
		get
		{
			return <IsAnimating>k__BackingField;
		}
		set
		{
			<IsAnimating>k__BackingField = value;
		}
	}

	private bool IsMovingToGraveyard
	{
		get
		{
			return <IsMovingToGraveyard>k__BackingField;
		}
		set
		{
			<IsMovingToGraveyard>k__BackingField = value;
		}
	}

	public bool ShouldWait
	{
		get
		{
			//IL_00f2: Expected I4, but got O
			//IL_00d2: Expected O, but got I4
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Expected I4, but got Unknown
			if (<IsAnimating>k__BackingField)
			{
				return true;
			}
			if (<IsMovingToGraveyard>k__BackingField)
			{
				return true;
			}
			Queue<Action> movesQueue = _movesQueue;
			if (_movesQueue != null)
			{
				bool flag = movesQueue._size < 0;
				bool flag2 = movesQueue._size == 0;
				int num = movesQueue._size ^ movesQueue._size;
				int num2 = movesQueue._size & num;
				bool flag3 = num2 < 0;
				bool flag4 = flag == flag3;
				object obj = !flag2;
				return (byte)((flag4 & obj) ? 1 : 0) != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private JackarooThemeData Theme
	{
		get
		{
			if (_runtimeTheme != null)
			{
				return _runtimeTheme;
			}
			JackarooTheme defaultTheme = _defaultTheme;
			if ((object)_defaultTheme != null)
			{
				return defaultTheme.<ThemeData>k__BackingField;
			}
			return (JackarooThemeData)(object)new NullReferenceException();
		}
	}

	private void Start()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0261: Expected O, but got I
		//IL_026d: Expected O, but got I
		//IL_027c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0281: Expected O, but got Unknown
		//IL_028d: Expected O, but got I
		//IL_02b7: Expected O, but got I4
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0098: Expected I, but got O
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00bd: Expected O, but got I
		//IL_00e7: Expected I, but got O
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_010c: Expected O, but got I
		//IL_0138: Expected I, but got O
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		//IL_015d: Expected O, but got I
		//IL_0189: Expected I, but got O
		//IL_019a: Expected O, but got I
		//IL_01c6: Expected I, but got O
		//IL_01d7: Expected O, but got I
		//IL_0203: Expected I, but got O
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)128;
		object obj3 = (nint)0 + (nint)32;
		object obj4 = typeof(SqlSingle[]) + 2376;
		object obj5 = (nint)0 + (nint)440;
		object obj6 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj7 = !flag;
		if (obj7 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj8 = this + 112;
		object obj9 = default(object);
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EE90D8");
		object obj10 = this + 120;
		object obj11 = default(object);
		obj10 = obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj5);
		object obj12 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj13 = (nint)0 + (nint)448;
		((KGame)obj8).OnGameStateUpdated += action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj13);
		object obj14 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		object obj15 = (nint)0 + (nint)424;
		<Game>k__BackingField.OnPlayerSwitchSeat += playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj15);
		object obj16 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj17 = (nint)0 + (nint)432;
		<Game>k__BackingField.OnCardGameEnd += action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action3 = default(Action<bool>);
		action3..ctor((object)this, (IntPtr)obj17);
		object obj18 = (nint)0 + (nint)456;
		_gameEventsChannel.OnGamePerspectiveChanged += action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj18);
		object obj19 = (nint)0 + (nint)408;
		_gameEventsChannel.ShowUi += action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj19);
		_gameEventsChannel.HideUi += action5;
		InitializeGuardedMarblesPool();
		int num = ShortcutExtensions.DOKill(_boardCanvasGroup);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(_boardCanvasGroup, 0f, 0f);
	}

	private void OnDestroy()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_01ba: Expected I, but got O
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0045: Expected O, but got I
		//IL_0071: Expected I, but got O
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0096: Expected O, but got I
		//IL_00c2: Expected I, but got O
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Expected O, but got Unknown
		//IL_00e7: Expected O, but got I
		//IL_0113: Expected I, but got O
		//IL_0124: Expected O, but got I
		//IL_0150: Expected I, but got O
		//IL_0161: Expected O, but got I
		//IL_018d: Expected I, but got O
		object obj = typeof(SqlSingle[]) + 2376;
		object obj2 = (nint)0 + (nint)440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(this, (IntPtr)obj2);
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 1200;
		object obj4 = (nint)0 + (nint)448;
		<Game>k__BackingField.OnGameStateUpdated -= action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		KGame.PlayerSwitchSeatDelegate playerSwitchSeatDelegate = default(KGame.PlayerSwitchSeatDelegate);
		playerSwitchSeatDelegate..ctor(this, (IntPtr)obj4);
		object obj5 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1376;
		object obj6 = (nint)0 + (nint)424;
		<Game>k__BackingField.OnPlayerSwitchSeat -= playerSwitchSeatDelegate;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action2 = default(Action<object>);
		action2..ctor((object)this, (IntPtr)obj6);
		object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1304;
		object obj8 = (nint)0 + (nint)432;
		<Game>k__BackingField.OnCardGameEnd -= action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<bool> action3 = default(Action<bool>);
		action3..ctor((object)this, (IntPtr)obj8);
		object obj9 = (nint)0 + (nint)456;
		_gameEventsChannel.OnGamePerspectiveChanged -= action3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action4 = default(Action);
		action4..ctor(this, (IntPtr)obj9);
		object obj10 = (nint)0 + (nint)408;
		_gameEventsChannel.ShowUi -= action4;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action5 = default(Action);
		action5..ctor(this, (IntPtr)obj10);
		_gameEventsChannel.HideUi -= action5;
	}

	public void ShowControls()
	{
		int num = ShortcutExtensions.DOKill(_boardCanvasGroup);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(_boardCanvasGroup, 1f, 0.3f);
	}

	public void SetBoardImage(Sprite newBoardImage)
	{
		<BoardImage>k__BackingField.sprite = newBoardImage;
	}

	public void SetBoardImage(SpineRoomElement spineRoomElement, Vector2 scale, Vector2 position)
	{
		//IL_0046: Expected O, but got I4
		//IL_0059: Expected O, but got I4
		//IL_0071: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I
		RectTransform rectTransform = UIExtensions.rectTransform(spineRoomElement);
		Transform parent = <BoardImage>k__BackingField.transform;
		rectTransform.SetParent(parent, worldPositionStays: false);
		UIExtensions.SetPivot(rectTransform, (Vector2)0);
		rectTransform.localScale = (Vector3)0;
		GameObject gameObject = spineRoomElement.gameObject;
		object obj = this + 56;
		obj = gameObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X19_v3+50]");
		((Behaviour)0).enabled = false;
	}

	public void ResetJackarooBoardTheme()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0156: Expected O, but got I4
		//IL_00b7: Expected O, but got I4
		//IL_00c0: Expected O, but got I4
		//IL_00ce: Expected O, but got I4
		//IL_01aa: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_02b2: Expected O, but got I4
		//IL_023b: Expected O, but got I4
		object obj = 152989696;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F27]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			obj5 = jackarooSpineBoard;
			obj6 = jackarooSpineBoard;
			if (!flag)
			{
				goto IL_0093;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v11+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = jackarooSpineBoard;
			obj6 = jackarooSpineBoard;
			if (obj7 != null)
			{
				goto IL_0093;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6 != null;
		bool flag4 = !flag3;
		object obj8 = 0;
		UnityEngine.Object obj9 = null;
		obj5 = obj6;
		object obj10 = 0;
		UnityEngine.Object obj11 = null;
		if (flag4)
		{
			goto IL_00e1;
		}
		goto IL_01d3;
		IL_0274:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object.Destroy(obj5);
		Behaviour behaviour = <BoardImage>k__BackingField;
		bool flag5 = (object)<BoardImage>k__BackingField == null;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			goto IL_010a;
		}
		obj8 = obj10;
		obj9 = null;
		goto IL_0256;
		IL_0256:
		NullReferenceException ex = new NullReferenceException();
		obj10 = obj8;
		obj11 = obj9;
		goto IL_0274;
		IL_00e1:
		behaviour = <BoardImage>k__BackingField;
		if ((object)<BoardImage>k__BackingField != null)
		{
			goto IL_010a;
		}
		goto IL_0256;
		IL_0093:
		bool flag6 = obj5 != null;
		bool flag7 = !flag6;
		object obj13 = !flag7;
		obj8 = 0;
		obj9 = null;
		obj10 = 0;
		obj11 = null;
		if (obj13 == null)
		{
			goto IL_00e1;
		}
		goto IL_01d3;
		IL_01d3:
		obj5 = jackarooSpineBoard;
		ex = (NullReferenceException)obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v1 (System.NullReferenceException)+E4]");
		if ((nint)0 != 0)
		{
			UnityEngine.Object.Destroy(jackarooSpineBoard);
			behaviour = <BoardImage>k__BackingField;
			bool flag8 = (object)<BoardImage>k__BackingField == null;
			object obj14 = !flag8;
			obj8 = obj10;
			obj9 = null;
			if (obj14 != null)
			{
				goto IL_010a;
			}
			goto IL_0256;
		}
		goto IL_0274;
		IL_010a:
		behaviour.enabled = true;
		SetThemeAndApply((JackarooThemeData)null);
	}

	public void OnPlayerDidLastAction(JackarooLastActionInfo lastAction, GameAction? emote = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_007f: Expected O, but got I4
		//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f3: Expected O, but got Unknown
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0152: Expected O, but got I
		//IL_0163: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = "___# Content push apply failed [{0}]: {1}" + 2664;
		bool flag = ((LastActionInfo)lastAction).<Action>k__BackingField != (string)obj4;
		bool flag2 = !flag;
		object obj5 = !flag2;
		if (obj5 == null && <Game>k__BackingField.IsNewLastAction)
		{
			object obj6 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 232;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			JackarooLastActionInfo jackarooLastActionInfo = default(JackarooLastActionInfo);
			jackarooLastActionInfo..ctor(lastAction);
			object obj7 = obj2 + 24;
			obj7 = jackarooLastActionInfo;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			JackarooGame jackarooGame = <Game>k__BackingField;
			AddMarblesSnapShot(jackarooGame._p);
			object obj8 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj9 = (nint)0 + (nint)1680;
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj9);
			AddToMovesQueue(action);
		}
	}

	public JackarooServerMove ToJackarooServerMove(JackarooMove move)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0174: Expected O, but got I4
		//IL_02cb: Expected I, but got O
		//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03be: Expected O, but got Unknown
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03e6: Expected O, but got I4
		//IL_01f8: Expected I, but got O
		//IL_0283: Expected I4, but got O
		//IL_0112: Expected O, but got I
		//IL_0309: Expected O, but got I
		//IL_0311: Expected I, but got O
		//IL_0329: Expected O, but got I4
		//IL_0343: Expected O, but got I4
		JackarooMarble <Marble1>k__BackingField;
		bool flag3;
		JackarooNode jackarooNode2;
		JackarooNode jackarooNode3;
		JackarooNode jackarooNode4;
		JackarooNode jackarooNode;
		nint num;
		if (move != null)
		{
			object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
			JackarooServerActions action = JackarooActionsExtensions.ToJackarooServerAction(move.<Action>k__BackingField);
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X8_v4+E4]");
			bool flag4;
			if ((nint)0 != 0)
			{
				bool flag = JackarooGame.NeedsP2(action);
				<Marble1>k__BackingField = move.<Marble1>k__BackingField;
				bool flag2 = move.<Marble1>k__BackingField == null;
				flag3 = flag;
				jackarooNode = null;
				flag4 = flag;
				jackarooNode2 = null;
				if (!flag2)
				{
					goto IL_00ae;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag5 = JackarooGame.NeedsP2(action);
				<Marble1>k__BackingField = move.<Marble1>k__BackingField;
				bool flag6 = move.<Marble1>k__BackingField == null;
				object obj3 = !flag6;
				flag3 = flag5;
				jackarooNode = null;
				flag4 = flag5;
				jackarooNode2 = null;
				if (obj3 != null)
				{
					goto IL_00ae;
				}
			}
			bool flag7 = !flag4;
			jackarooNode3 = null;
			IntPtr intPtr = default(IntPtr);
			num = intPtr;
			jackarooNode = jackarooNode2;
			jackarooNode4 = null;
			if (!flag7)
			{
				goto IL_01cf;
			}
			goto IL_025f;
		}
		goto IL_028d;
		IL_025f:
		int p = 0;
		goto IL_03aa;
		IL_028d:
		return (JackarooServerMove)(object)new NullReferenceException();
		IL_01cf:
		JackarooMarble <Marble2>k__BackingField = move.<Marble2>k__BackingField;
		bool flag8 = move.<Marble2>k__BackingField == null;
		object obj4 = default(object);
		num = (nint)obj4;
		jackarooNode = jackarooNode2;
		jackarooNode4 = jackarooNode3;
		if (flag8)
		{
			goto IL_025f;
		}
		JackarooBoard jackarooBoard = <Board>k__BackingField;
		if (<Board>k__BackingField == null)
		{
			goto IL_028d;
		}
		object obj5 = (nint)0 + (nint)2464;
		num = (nint)obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97238");
		int num2 = default(int);
		object obj6 = num2 + 1;
		bool flag9 = obj6 == null;
		object obj7 = !flag9;
		p = ((obj7 != null) ? num2 : 0);
		jackarooNode = <Marble2>k__BackingField.<Node>k__BackingField;
		jackarooNode4 = jackarooNode3;
		goto IL_03aa;
		IL_03aa:
		object obj8 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 320;
		object obj9 = jackarooNode4 + 1;
		bool flag10 = obj9 == null;
		object obj10 = !flag10;
		int p2 = ((obj10 != null) ? ((int)jackarooNode4) : 0);
		JackarooServerActions action2 = JackarooActionsExtensions.ToJackarooServerAction(move.<Action>k__BackingField);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		JackarooServerMove jackarooServerMove = default(JackarooServerMove);
		jackarooServerMove..ctor(move.<Card>k__BackingField, action2, p2, p);
		return jackarooServerMove;
		IL_00ae:
		jackarooNode4 = <Marble1>k__BackingField.<Node>k__BackingField;
		if (<Marble1>k__BackingField.<Node>k__BackingField != null)
		{
			JackarooBoard jackarooBoard2 = <Board>k__BackingField;
			if (<Board>k__BackingField == null)
			{
				goto IL_028d;
			}
			obj4 = (nint)0 + (nint)2464;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97238");
			jackarooNode = <Marble1>k__BackingField.<Node>k__BackingField;
			JackarooNode jackarooNode5 = default(JackarooNode);
			jackarooNode4 = jackarooNode5;
		}
		bool flag11 = !flag3;
		num = (nint)obj4;
		if (!flag11)
		{
			jackarooNode2 = jackarooNode;
			jackarooNode3 = jackarooNode4;
			goto IL_01cf;
		}
		goto IL_025f;
	}

	public JackarooMove ToJackarooMove(JackarooLastActionInfo lastActionInfo, int rotatedPlayerIndex)
	{
		//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fc: Expected O, but got Unknown
		//IL_107f: Expected O, but got I4
		//IL_0685: Unknown result type (might be due to invalid IL or missing references)
		//IL_068a: Expected O, but got Unknown
		//IL_0692: Expected I, but got O
		//IL_06a2: Expected O, but got I
		//IL_07ed: Expected O, but got I4
		//IL_00a8: Expected O, but got I4
		//IL_00be: Expected O, but got I
		//IL_075c: Expected O, but got I4
		//IL_076c: Expected O, but got I
		//IL_0839: Expected O, but got I4
		//IL_0373: Expected O, but got I
		//IL_038d: Expected O, but got I4
		//IL_06dd: Expected O, but got I
		//IL_013a: Expected O, but got I4
		//IL_00f1: Expected O, but got I
		//IL_079a: Expected O, but got I
		//IL_02a0: Expected I4, but got O
		//IL_02db: Expected I4, but got O
		//IL_02eb: Expected O, but got I
		//IL_03ed: Expected O, but got I
		//IL_0403: Expected I4, but got O
		//IL_03d2: Expected O, but got I4
		//IL_0d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d88: Expected O, but got Unknown
		//IL_0d91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d96: Expected O, but got Unknown
		//IL_0dcf: Expected O, but got I
		//IL_0def: Expected O, but got I
		//IL_0877: Expected O, but got I
		//IL_0435: Unknown result type (might be due to invalid IL or missing references)
		//IL_043a: Expected O, but got Unknown
		//IL_0468: Expected O, but got I4
		//IL_0158: Expected O, but got I4
		//IL_06eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f0: Expected O, but got Unknown
		//IL_06f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fe: Expected O, but got Unknown
		//IL_0a75: Expected O, but got I
		//IL_0e7d: Expected I, but got O
		//IL_0e8d: Expected O, but got I
		//IL_08cf: Expected O, but got I
		//IL_04a0: Expected O, but got I4
		//IL_0f4c: Expected O, but got I
		//IL_0ec8: Expected O, but got I
		//IL_091e: Expected O, but got I
		//IL_04c9: Expected O, but got I4
		//IL_04d2: Expected O, but got I4
		//IL_0f80: Expected O, but got I
		//IL_0f80: Expected O, but got I
		//IL_0f91: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f96: Expected O, but got Unknown
		//IL_0f9f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa4: Expected O, but got Unknown
		//IL_0fd8: Expected O, but got I4
		//IL_0fe8: Expected O, but got I
		//IL_0b74: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b79: Expected O, but got Unknown
		//IL_0b81: Expected I, but got O
		//IL_0b91: Expected O, but got I
		//IL_093b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0940: Expected O, but got Unknown
		//IL_0948: Expected I, but got O
		//IL_0958: Expected O, but got I
		//IL_04f8: Expected O, but got I4
		//IL_0ed6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0edb: Expected O, but got Unknown
		//IL_0ee4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee9: Expected O, but got Unknown
		//IL_0c4b: Expected O, but got I4
		//IL_0c5b: Expected O, but got I
		//IL_0a12: Expected O, but got I4
		//IL_0a22: Expected O, but got I
		//IL_0d2f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d34: Expected O, but got Unknown
		//IL_0d71: Expected O, but got I
		//IL_0bcc: Expected O, but got I
		//IL_0b19: Expected O, but got I
		//IL_0993: Expected O, but got I
		//IL_0513: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_0538: Expected O, but got I4
		//IL_0c91: Expected O, but got I
		//IL_0a58: Expected O, but got I
		//IL_0c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca3: Expected O, but got Unknown
		//IL_0cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb1: Expected O, but got Unknown
		//IL_0cea: Expected O, but got I
		//IL_0d12: Expected O, but got I
		//IL_0a87: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a8c: Expected O, but got Unknown
		//IL_0a95: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a9a: Expected O, but got Unknown
		//IL_0ad3: Expected O, but got I
		//IL_0afb: Expected O, but got I
		//IL_054e: Expected I, but got O
		//IL_055e: Expected O, but got I
		//IL_0587: Expected O, but got I
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bdf: Expected O, but got Unknown
		//IL_0be8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bed: Expected O, but got Unknown
		//IL_09a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a6: Expected O, but got Unknown
		//IL_09af: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b4: Expected O, but got Unknown
		//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d0: Expected O, but got Unknown
		//IL_05e0: Expected O, but got I
		JackarooLastActionInfo jackarooLastActionInfo = default(JackarooLastActionInfo);
		bool flag = jackarooLastActionInfo == null;
		int num = rotatedPlayerIndex;
		object obj;
		int num3;
		object obj6 = default(object);
		JackarooLastActionInfo jackarooLastActionInfo3;
		int num4;
		JackarooBoard jackarooBoard2;
		List<object> playersGraveyardMarbles;
		JackarooLastActionInfo jackarooLastActionInfo2 = default(JackarooLastActionInfo);
		if (!flag)
		{
			if (jackarooLastActionInfo.<JackarooAction>k__BackingField != JackarooActions.PLANT)
			{
				if (jackarooLastActionInfo.<JackarooAction>k__BackingField > JackarooActions.BURN_MY_CARD)
				{
					if (jackarooLastActionInfo.<JackarooAction>k__BackingField != JackarooActions.BURN_OTHER_CARD)
					{
						if (jackarooLastActionInfo.<JackarooAction>k__BackingField == JackarooActions.STEAL)
						{
							return JackarooMove.GetStealMove(jackarooLastActionInfo2.<Card>k__BackingField);
						}
						if (jackarooLastActionInfo.<JackarooAction>k__BackingField != JackarooActions.BURN_OTHER_CARD_RANDOM)
						{
							goto IL_01e8;
						}
					}
				}
				else
				{
					if (jackarooLastActionInfo.<JackarooAction>k__BackingField == JackarooActions.SWAP)
					{
						JackarooBoard jackarooBoard = <Board>k__BackingField;
						bool flag2 = <Board>k__BackingField == null;
						num = rotatedPlayerIndex;
						if (!flag2)
						{
							List<JackarooNode> serverNodes = jackarooBoard._serverNodes;
							bool flag3 = jackarooBoard._serverNodes == null;
							num = rotatedPlayerIndex;
							if (!flag3)
							{
								obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
								nint num2 = (nint)serverNodes;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v7 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
								object obj2 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v7 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_071e;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v651 @ X8_v7 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+B0]");
								object obj3 = (nint)0 + (nint)8;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X10_v14-8]");
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
									goto IL_071e;
								}
								object obj4 = num2 + obj3;
								object obj5 = obj4 + 312;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v26+8]");
								num3 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v736 @ X0_v26] (should have been resolved before IL gen)");
								bool flag4 = obj6 == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
								jackarooLastActionInfo3 = (JackarooLastActionInfo)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X0_v26+8]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
								jackarooLastActionInfo = (JackarooLastActionInfo)0;
								if (!flag4)
								{
									goto IL_0dfd;
								}
							}
						}
						goto IL_0ff6;
					}
					if (jackarooLastActionInfo.<JackarooAction>k__BackingField != JackarooActions.BURN_MY_CARD)
					{
						goto IL_01e8;
					}
				}
				return JackarooMove.GetBurnCardMove(jackarooLastActionInfo2.<Card>k__BackingField, jackarooLastActionInfo.<JackarooAction>k__BackingField);
			}
			bool flag5 = <Board>k__BackingField == null;
			num = rotatedPlayerIndex;
			if (!flag5)
			{
				bool flag6 = <Board>k__BackingField.AreAllMarblesInBases(rotatedPlayerIndex);
				bool flag7 = !flag6;
				num4 = rotatedPlayerIndex;
				if (!flag7)
				{
					int teamMateIndex = GetTeamMateIndex(rotatedPlayerIndex);
					num4 = teamMateIndex;
				}
				jackarooBoard2 = <Board>k__BackingField;
				bool flag8 = <Board>k__BackingField == null;
				num = rotatedPlayerIndex;
				jackarooLastActionInfo = (JackarooLastActionInfo)rotatedPlayerIndex;
				if (!flag8)
				{
					object obj7 = 152989696;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6C]");
					object obj8 = (nint)0 & (nint)1;
					if (obj8 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6E]");
						object obj9 = (nint)0 & (nint)1;
						if (obj9 != null)
						{
							goto IL_010e;
						}
					}
					else
					{
						_ = 1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F6E]");
						object obj10 = (nint)0 & (nint)1;
						bool flag9 = obj10 == null;
						object obj11 = !flag9;
						if (obj11 != null)
						{
							goto IL_010e;
						}
					}
					_ = 1;
					playersGraveyardMarbles = (List<object>)(object)jackarooBoard2._playersGraveyardMarbles;
					bool flag10 = jackarooBoard2._playersGraveyardMarbles == null;
					num = rotatedPlayerIndex;
					jackarooLastActionInfo = (JackarooLastActionInfo)rotatedPlayerIndex;
					if (!flag10)
					{
						goto IL_03e0;
					}
				}
			}
		}
		goto IL_0ff6;
		IL_0ff6:
		NullReferenceException ex = new NullReferenceException();
		goto IL_1004;
		IL_0f5a:
		Card <Card>k__BackingField = jackarooLastActionInfo2.<Card>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v11+20]");
		nint num5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X0_v12+20]");
		return JackarooMove.GetNewSwapJackarooMove(<Card>k__BackingField, (JackarooMarble)num5, (JackarooMarble)0);
		IL_010e:
		playersGraveyardMarbles = (List<object>)(object)jackarooBoard2._playersGraveyardMarbles;
		bool flag11 = jackarooBoard2._playersGraveyardMarbles == null;
		object obj12 = !flag11;
		if (obj12 != null)
		{
			goto IL_03e0;
		}
		num = rotatedPlayerIndex;
		jackarooLastActionInfo = (JackarooLastActionInfo)rotatedPlayerIndex;
		goto IL_0ff6;
		IL_1004:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_1012;
		IL_09d4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X0_v47+8]");
		int num6 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v839 @ X0_v47] (should have been resolved before IL gen)");
		object obj13 = default(object);
		bool flag12 = obj13 == null;
		object obj14 = !flag12;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7040]");
		JackarooLastActionInfo jackarooLastActionInfo4 = (JackarooLastActionInfo)0;
		if (obj14 != null)
		{
			goto IL_0b09;
		}
		nint num7 = rotatedPlayerIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v839 @ X0_v47+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7040]");
		jackarooLastActionInfo = (JackarooLastActionInfo)0;
		goto IL_0ff6;
		IL_0b09:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X0_v45+20]");
		JackarooMarble marble = (JackarooMarble)0;
		num = num6;
		jackarooLastActionInfo = jackarooLastActionInfo4;
		goto IL_10f4;
		IL_10f4:
		JackarooBoard jackarooBoard3 = <Board>k__BackingField;
		bool flag13 = <Board>k__BackingField == null;
		num7 = rotatedPlayerIndex;
		object obj20 = default(object);
		int num9;
		JackarooLastActionInfo jackarooLastActionInfo5;
		if (!flag13)
		{
			List<JackarooNode> serverNodesAndBases = jackarooBoard3._serverNodesAndBases;
			bool flag14 = jackarooBoard3._serverNodesAndBases == null;
			num7 = rotatedPlayerIndex;
			if (!flag14)
			{
				object obj15 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
				nint num8 = (nint)serverNodesAndBases;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X8_v25 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X8_v25 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0c0d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v843 @ X8_v25 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X10_v21-8]");
					if (0 == (nint)obj15)
					{
						break;
					}
					obj17 += 16;
					obj16--;
					if ((nint)obj16 != 1)
					{
						continue;
					}
					goto IL_0c0d;
				}
				object obj18 = num8 + obj17;
				object obj19 = obj18 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v42+8]");
				num9 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v902 @ X0_v42] (should have been resolved before IL gen)");
				bool flag15 = obj20 == null;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
				jackarooLastActionInfo5 = (JackarooLastActionInfo)0;
				num7 = rotatedPlayerIndex;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v902 @ X0_v42+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
				jackarooLastActionInfo = (JackarooLastActionInfo)0;
				if (!flag15)
				{
					goto IL_0d20;
				}
			}
		}
		goto IL_0ff6;
		IL_0f09:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X0_v16+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v772 @ X0_v16] (should have been resolved before IL gen)");
		object obj21 = default(object);
		bool flag16 = obj21 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7040]");
		jackarooLastActionInfo = (JackarooLastActionInfo)0;
		if (!flag16)
		{
			goto IL_0f5a;
		}
		goto IL_0ff6;
		IL_03e0:
		object obj22 = (nint)0 + (nint)2968;
		int num10 = num4 - 1;
		num = (int)obj22;
		object source = playersGraveyardMarbles.get_Item(num10);
		object marble2 = Enumerable.First((IEnumerable<object>)source);
		object obj23 = typeof(TypeConverter<ushort, char>) + 3120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		JackarooBoard jackarooBoard4 = <Board>k__BackingField;
		bool flag17 = <Board>k__BackingField == null;
		jackarooLastActionInfo = (JackarooLastActionInfo)1;
		if (!flag17)
		{
			(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes = jackarooBoard4._homesAndBasesEntryNodes;
			bool flag18 = jackarooBoard4._homesAndBasesEntryNodes == null;
			jackarooLastActionInfo = (JackarooLastActionInfo)1;
			if (!flag18)
			{
				bool flag19 = num10 < homesAndBasesEntryNodes.Length;
				object obj24 = !flag19;
				jackarooLastActionInfo = (JackarooLastActionInfo)1;
				if (obj24 == null)
				{
					IReadOnlyList<JackarooNode> readOnlyList = default(IReadOnlyList<JackarooNode>);
					bool flag20 = readOnlyList == null;
					jackarooLastActionInfo = (JackarooLastActionInfo)1;
					if (flag20)
					{
						goto IL_0ff6;
					}
					object obj25 = jackarooBoard4._homesAndBasesEntryNodes + num10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v48+20]");
					bool flag21 = (nint)0 == 0;
					jackarooLastActionInfo2 = (JackarooLastActionInfo)1;
					if (!flag21)
					{
						nint num11 = (nint)readOnlyList;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v51 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+40]");
						jackarooLastActionInfo2 = (JackarooLastActionInfo)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag22 = ex2 == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X8_v51 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+40]");
						jackarooLastActionInfo = (JackarooLastActionInfo)0;
						if (flag22)
						{
							goto IL_1012;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X0_v75 (System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>)+18]");
					bool flag23 = (nint)0 == 0;
					jackarooLastActionInfo = jackarooLastActionInfo2;
					if (!flag23)
					{
						object obj26 = readOnlyList + 32;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v48+20]");
						obj26 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						return JackarooMove.GetPlantMove(jackarooLastActionInfo2.<Card>k__BackingField, (JackarooMarble)marble2, readOnlyList);
					}
				}
				goto IL_1004;
			}
		}
		goto IL_0ff6;
		IL_01e8:
		object obj27 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj28 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v29+E4]");
		if ((nint)0 != 0)
		{
			if (JackarooGame.IsASplit(jackarooLastActionInfo.<JackarooAction>k__BackingField))
			{
				goto IL_0254;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag24 = JackarooGame.IsASplit(jackarooLastActionInfo.<JackarooAction>k__BackingField);
			bool flag25 = !flag24;
			object obj29 = !flag25;
			if (obj29 != null)
			{
				goto IL_0254;
			}
		}
		int jackarooMoveFromCard = JackarooRules.GetJackarooMoveFromCard(jackarooLastActionInfo2.<Card>k__BackingField, jackarooLastActionInfo.<JackarooAction>k__BackingField);
		List<JackarooNode> nodes = null;
		num = 0;
		int num12 = jackarooMoveFromCard;
		jackarooLastActionInfo = (JackarooLastActionInfo)jackarooLastActionInfo.<JackarooAction>k__BackingField;
		goto IL_108d;
		IL_071e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X0_v23+8]");
		num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v680 @ X0_v23] (should have been resolved before IL gen)");
		bool flag26 = obj6 == null;
		object obj30 = !flag26;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
		jackarooLastActionInfo3 = (JackarooLastActionInfo)0;
		if (obj30 != null)
		{
			goto IL_0dfd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v680 @ X0_v23+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
		jackarooLastActionInfo = (JackarooLastActionInfo)0;
		goto IL_0ff6;
		IL_0dfd:
		JackarooBoard jackarooBoard5 = <Board>k__BackingField;
		bool flag27 = <Board>k__BackingField == null;
		num = num3;
		jackarooLastActionInfo = jackarooLastActionInfo3;
		if (!flag27)
		{
			List<JackarooNode> serverNodes2 = jackarooBoard5._serverNodes;
			bool flag28 = jackarooBoard5._serverNodes == null;
			num = num3;
			jackarooLastActionInfo = jackarooLastActionInfo3;
			if (!flag28)
			{
				nint num13 = (nint)serverNodes2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v10 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
				object obj31 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v10 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0f09;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v753 @ X8_v10 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+B0]");
				object obj32 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X10_v9-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj32 += 16;
					obj31--;
					if ((nint)obj31 != 1)
					{
						continue;
					}
					goto IL_0f09;
				}
				object obj33 = num13 + obj32;
				object obj34 = obj33 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X0_v19+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v809 @ X0_v19] (should have been resolved before IL gen)");
				bool flag29 = obj21 == null;
				object obj35 = !flag29;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7040]");
				jackarooLastActionInfo = (JackarooLastActionInfo)0;
				if (obj35 != null)
				{
					goto IL_0f5a;
				}
			}
		}
		goto IL_0ff6;
		IL_108d:
		List<JackarooNode> serverWalkingNodes;
		if (<Board>k__BackingField != null)
		{
			JackarooBoard jackarooBoard6 = <Board>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
			serverWalkingNodes = jackarooBoard6.GetServerWalkingNodes(0, num12, rotatedPlayerIndex);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7040]");
			object obj36 = (nint)0 + (nint)1;
			if (obj36 == null)
			{
				num = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
				jackarooLastActionInfo = (JackarooLastActionInfo)0;
				marble = null;
				goto IL_10f4;
			}
			JackarooBoard jackarooBoard7 = <Board>k__BackingField;
			bool flag30 = <Board>k__BackingField == null;
			num7 = rotatedPlayerIndex;
			num = num12;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
			jackarooLastActionInfo = (JackarooLastActionInfo)0;
			if (!flag30)
			{
				List<JackarooNode> serverNodesAndBases2 = jackarooBoard7._serverNodesAndBases;
				bool flag31 = jackarooBoard7._serverNodesAndBases == null;
				num7 = rotatedPlayerIndex;
				num = num12;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
				jackarooLastActionInfo = (JackarooLastActionInfo)0;
				if (!flag31)
				{
					object obj37 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
					nint num14 = (nint)serverNodesAndBases2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v35 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
					object obj38 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v35 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_09d4;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v819 @ X8_v35 (Il2CppClass<System.Collections.Generic.List`1<Jackaroo.JackarooNode>>)+B0]");
					object obj39 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X10_v27-8]");
						if (0 == (nint)obj37)
						{
							break;
						}
						obj39 += 16;
						obj38--;
						if ((nint)obj38 != 1)
						{
							continue;
						}
						goto IL_09d4;
					}
					object obj40 = num14 + obj39;
					object obj41 = obj40 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v50+8]");
					num6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v884 @ X0_v50] (should have been resolved before IL gen)");
					bool flag32 = obj13 == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7040]");
					jackarooLastActionInfo4 = (JackarooLastActionInfo)0;
					num7 = rotatedPlayerIndex;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X0_v50+8]");
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7040]");
					jackarooLastActionInfo = (JackarooLastActionInfo)0;
					if (!flag32)
					{
						goto IL_0b09;
					}
				}
			}
		}
		goto IL_0ff6;
		IL_0254:
		(int, int) jackarooMoveFromSplit = JackarooRules.GetJackarooMoveFromSplit(jackarooLastActionInfo.<JackarooAction>k__BackingField);
		bool flag33 = <Board>k__BackingField == null;
		num = rotatedPlayerIndex;
		jackarooLastActionInfo = null;
		if (flag33)
		{
			goto IL_0ff6;
		}
		num = (object)jackarooMoveFromSplit >> 32;
		JackarooBoard jackarooBoard8 = <Board>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7040]");
		List<JackarooNode> serverWalkingNodes2 = jackarooBoard8.GetServerWalkingNodes(0, num, rotatedPlayerIndex);
		nodes = serverWalkingNodes2;
		num7 = rotatedPlayerIndex;
		num12 = (int)jackarooMoveFromSplit;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7040]");
		jackarooLastActionInfo = (JackarooLastActionInfo)0;
		goto IL_108d;
		IL_1012:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		return (JackarooMove)(object)new OutOfMemoryException();
		IL_0c0d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X0_v39+8]");
		num9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v877 @ X0_v39] (should have been resolved before IL gen)");
		bool flag34 = obj20 == null;
		object obj42 = !flag34;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
		jackarooLastActionInfo5 = (JackarooLastActionInfo)0;
		if (obj42 != null)
		{
			goto IL_0d20;
		}
		num7 = rotatedPlayerIndex;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X0_v39+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E703C]");
		jackarooLastActionInfo = (JackarooLastActionInfo)0;
		goto IL_0ff6;
		IL_0d20:
		object obj43 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 248;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Card <Card>k__BackingField2 = jackarooLastActionInfo2.<Card>k__BackingField;
		JackarooActions <JackarooAction>k__BackingField = jackarooLastActionInfo.<JackarooAction>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X0_v34+20]");
		JackarooMove jackarooMove = default(JackarooMove);
		jackarooMove..ctor(<Card>k__BackingField2, <JackarooAction>k__BackingField, (JackarooMarble)0, serverWalkingNodes, marble, nodes);
		return jackarooMove;
	}

	public void PlayJackarooMove(JackarooMove move, GameAction? emote = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0039: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00a6: Expected I, but got O
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(SqlSingle[]) + 2376;
		object obj4 = (nint)0 + (nint)1688;
		object obj5 = obj2 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj2 + 24;
		obj6 = move;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		HideHighlights();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj4);
		AddToMovesQueue(action);
	}

	public void HidePMarblesPriceTags()
	{
		//IL_0195: Expected O, but got I4
		//IL_002c: Expected O, but got I4
		//IL_0047: Expected O, but got I
		//IL_0053: Expected O, but got I
		//IL_0136: Expected I, but got O
		//IL_01b9: Expected I, but got O
		//IL_006e: Expected O, but got I4
		//IL_00e8: Expected O, but got I4
		bool flag = <Board>k__BackingField == null;
		object obj = 152989696;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (!flag)
		{
			List<JackarooMarble> allMarbles = <Board>k__BackingField.GetAllMarbles();
			bool flag2 = allMarbles == null;
			obj = 152989696;
			if (!flag2)
			{
				object obj2 = (nint)0 + (nint)2752;
				obj = (nint)0 + (nint)2744;
				List<object>.Enumerator enumerator = ((List<object>)(object)allMarbles).GetEnumerator();
				num = (nint)obj2;
				if (!enumerator2.MoveNext())
				{
					enumerator2.Dispose();
					return;
				}
				object obj3 = 0;
				NullReferenceException ex = new NullReferenceException();
				object obj4 = 0;
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag3 = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag3)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj4 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BA08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void HideControls()
	{
		int num = ShortcutExtensions.DOKill(_boardCanvasGroup);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(_boardCanvasGroup, 0f, 0.3f);
	}

	private void HideControlsWithDelay(float duration = 0.3f)
	{
		int num = ShortcutExtensions.DOKill(_boardCanvasGroup);
		TweenerCore<float, float, FloatOptions> tweenerCore = DOTweenModuleUI.DOFade(_boardCanvasGroup, 0f, duration);
	}

	private void OnPlayerSwitchSeat(int userid, string error)
	{
		CardGamePlayer myPlayer = <Game>k__BackingField.MyPlayer;
		if (myPlayer == null)
		{
			return;
		}
		if (<Initialized>k__BackingField)
		{
			CardGamePlayer myPlayer2 = <Game>k__BackingField.MyPlayer;
			string dBId = myPlayer2.DBId;
			if (!int.TryParse(dBId, out var result) || result == userid)
			{
				_playerSwitchedSeat = true;
				Initialize();
			}
		}
		else
		{
			_playerSwitchedSeat = true;
			Initialize();
		}
	}

	private void OnCardGameEnd(CardGameEndScores cardGameEndScores)
	{
		//IL_001c: Expected O, but got I4
		bool flag = !<Initialized>k__BackingField;
		object obj = !flag;
		if (obj == null)
		{
			Initialize();
		}
		CardGameEndScores cardGameEndScores2 = default(CardGameEndScores);
		PlayWinAnimations(cardGameEndScores2);
		<Initialized>k__BackingField = false;
	}

	private void InitPerspective(bool isTopDown)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I4
		//IL_00d1: Expected F4, but got I4
		//IL_022a: Expected O, but got I4
		//IL_00c3: Expected F4, but got I4
		//IL_00f5: Expected F4, but got I8
		//IL_0264: Expected O, but got I4
		//IL_00e3: Expected F4, but got I8
		//IL_029e: Expected O, but got I4
		//IL_0150: Expected O, but got I4
		//IL_0165: Expected O, but got I4
		//IL_016e: Expected O, but got I4
		//IL_0177: Expected O, but got I4
		//IL_0114: Expected O, but got I4
		//IL_0301: Unknown result type (might be due to invalid IL or missing references)
		//IL_0306: Expected O, but got Unknown
		//IL_0312: Expected O, but got I
		//IL_0321: Unknown result type (might be due to invalid IL or missing references)
		//IL_0326: Expected O, but got Unknown
		//IL_0351: Expected O, but got I4
		//IL_0351: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_0132: Expected O, but got I4
		//IL_013b: Expected O, but got I4
		//IL_0195: Expected I, but got O
		//IL_01bf: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 424;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Transform transform = base.transform;
		Transform root = transform.root;
		Transform transform2 = root.transform;
		Vector3 localScale = transform2.localScale;
		bool isTablet = ScreenUtility.IsTablet;
		bool flag = !isTablet;
		object obj4 = !flag;
		object obj5 = ~obj4;
		float value = ((obj5 != null) ? 0f : 1.117782E+09f);
		bool isTablet2 = ScreenUtility.IsTablet;
		bool flag2 = !isTablet2;
		object obj6 = !flag2;
		object obj7 = ~obj6;
		float num = ((obj7 != null) ? 3.272147E+09f : 3.2594985E+09f);
		bool isTablet3 = ScreenUtility.IsTablet;
		bool flag3 = !isTablet3;
		object obj8 = !flag3;
		object obj9 = ~obj8;
		if (obj9 == null)
		{
		}
		bool isTablet4 = ScreenUtility.IsTablet;
		bool flag4 = !isTablet4;
		object obj10 = !flag4;
		object obj11 = ~obj10;
		if (obj11 == null)
		{
		}
		int num2 = ShortcutExtensions.DOKill(_boardTransform);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v3 (System.Object)+18]");
		if ((nint)0 == 1)
		{
			_boardTransform.localScale = (Vector3)0;
			_boardTransform.localEulerAngles = (Vector3)0;
			object obj12 = 0;
			object obj13 = 0;
		}
		else
		{
			_boardTransform.localScale = (Vector3)0;
			_boardTransform.localEulerAngles = (Vector3)0;
			object obj12 = 0;
			object obj13 = 0;
			value = num;
		}
		object obj14 = typeof(SqlSingle[]) + 2376;
		object obj15 = (nint)0 + (nint)1696;
		object obj16 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3296;
		UIExtensions.MoveTo(y: value, gObject: _boardTransform, isWorldPositions: false, x: (float?)(object)0, z: (float?)(object)0);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj2, (IntPtr)obj15);
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v351 @ X0_v29+E4]");
		bool flag5 = (nint)0 == 0;
		object obj18 = !flag5;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Coroutine coroutine = CoroutineDummy.WaitForSeconds(0.3f, action);
	}

	private void OnGamePerspectiveChanged(bool isTopDown)
	{
		//IL_012f: Expected O, but got I4
		//IL_015d: Expected F4, but got I4
		//IL_00ba: Expected O, but got I4
		//IL_0232: Expected O, but got I4
		//IL_014f: Expected F4, but got I4
		//IL_00ec: Expected F4, but got I4
		//IL_0179: Expected F4, but got I4
		//IL_0198: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		//IL_016b: Expected F4, but got I4
		//IL_0110: Expected F4, but got I8
		//IL_01f6: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_01da: Expected F4, but got I4
		//IL_00fe: Expected F4, but got I8
		Transform transform = base.transform;
		Transform root = transform.root;
		Transform transform2 = root.transform;
		Vector3 localScale = transform2.localScale;
		bool isTablet = ScreenUtility.IsTablet;
		bool isTablet2 = ScreenUtility.IsTablet;
		bool isTablet3 = ScreenUtility.IsTablet;
		bool isTablet4 = ScreenUtility.IsTablet;
		int num = ShortcutExtensions.DOKill(_boardTransform);
		float endValue;
		Transform boardTransform;
		float duration2;
		if (isTopDown)
		{
			bool flag = !isTablet3;
			object obj = !flag;
			object obj2 = ~obj;
			float duration = ((obj2 != null) ? 1.06451437E+09f : 1f);
			bool flag2 = !isTablet;
			object obj3 = !flag2;
			object obj4 = ~obj3;
			endValue = ((obj4 != null) ? 3.272147E+09f : 3.2594985E+09f);
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(_boardTransform, (Vector3)0, duration);
			boardTransform = _boardTransform;
			duration2 = 0f;
		}
		else
		{
			bool flag3 = !isTablet4;
			object obj5 = !flag3;
			object obj6 = ~obj5;
			float duration3 = ((obj6 != null) ? 1.06619206E+09f : 1.0682892E+09f);
			bool flag4 = !isTablet2;
			object obj7 = !flag4;
			object obj8 = ~obj7;
			endValue = ((obj8 != null) ? 0f : 1.117782E+09f);
			object obj9 = default(object);
			double num2 = (double)obj9 + -1.0;
			double num3 = num2 / 3191362028.0;
			double num4 = num3 * 3.0;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = ShortcutExtensions.DOScale(_boardTransform, (Vector3)0, duration3);
			boardTransform = _boardTransform;
			double num5 = num4 + 30.0;
			duration2 = (float)num5;
		}
		TweenerCore<Quaternion, Vector3, QuaternionOptions> tweenerCore3 = ShortcutExtensions.DOLocalRotate(boardTransform, (Vector3)0, duration2);
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore4 = ShortcutExtensions.DOLocalMoveY(_boardTransform, endValue, 0.2f);
	}

	private void OnGameStateUpdated()
	{
		//IL_002e: Expected O, but got I4
		//IL_01a7: Expected O, but got I4
		//IL_02f2: Expected O, but got I4
		//IL_03a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a6: Expected O, but got Unknown
		//IL_03ae: Expected I4, but got O
		//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cc: Expected O, but got Unknown
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_0874: Expected O, but got I4
		//IL_0405: Expected O, but got I
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bf: Expected O, but got Unknown
		//IL_07d7: Expected O, but got I4
		//IL_0440: Expected O, but got I
		//IL_0769: Unknown result type (might be due to invalid IL or missing references)
		//IL_076e: Expected O, but got Unknown
		//IL_04e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ec: Expected O, but got Unknown
		//IL_06bb: Expected O, but got I4
		//IL_0456: Unknown result type (might be due to invalid IL or missing references)
		//IL_045b: Expected O, but got Unknown
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_0474: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Expected O, but got Unknown
		//IL_0536: Expected O, but got I
		//IL_0571: Expected O, but got I
		//IL_06d2: Expected O, but got I4
		//IL_07f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fc: Expected O, but got Unknown
		//IL_0618: Unknown result type (might be due to invalid IL or missing references)
		//IL_061d: Expected O, but got Unknown
		//IL_06a4: Expected O, but got I4
		//IL_0587: Unknown result type (might be due to invalid IL or missing references)
		//IL_058c: Expected O, but got Unknown
		//IL_0595: Unknown result type (might be due to invalid IL or missing references)
		//IL_059a: Expected O, but got Unknown
		//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05aa: Expected O, but got Unknown
		//IL_0668: Expected O, but got I
		bool flag = (object)<Game>k__BackingField == null;
		IntPtr intPtr = default(IntPtr);
		int num = (int)(nint)intPtr;
		object obj8;
		if (!flag)
		{
			bool isSpectator = <Game>k__BackingField.IsSpectator;
			bool flag2 = !isSpectator;
			object obj = !flag2;
			num = 0;
			if (obj == null)
			{
				bool flag3 = (object)<Game>k__BackingField == null;
				num = 0;
				if (flag3)
				{
					goto IL_0676;
				}
				CardGamePlayer myPlayer = <Game>k__BackingField.MyPlayer;
				bool flag4 = myPlayer == null;
				num = 0;
				if (flag4)
				{
					return;
				}
			}
			JackarooGame jackarooGame = <Game>k__BackingField;
			if ((object)<Game>k__BackingField != null)
			{
				num = ((KGame)jackarooGame).<Mover>k__BackingField;
				if (((KGame)jackarooGame).<Mover>k__BackingField < 1)
				{
					return;
				}
				SetTurnIndicator(((KGame)jackarooGame).<Mover>k__BackingField);
				if (!<Initialized>k__BackingField || _playerSwitchedSeat)
				{
					_playerSwitchedSeat = false;
					Initialize();
					return;
				}
				if ((object)<Game>k__BackingField != null)
				{
					bool isSpectator2 = <Game>k__BackingField.IsSpectator;
					bool flag5 = !isSpectator2;
					object obj2 = !flag5;
					if (obj2 != null)
					{
						return;
					}
					bool flag6 = (object)<Game>k__BackingField == null;
					num = 0;
					if (!flag6)
					{
						CardGamePlayer myPlayer2 = <Game>k__BackingField.MyPlayer;
						bool flag7 = myPlayer2 == null;
						num = 0;
						if (!flag7)
						{
							SeatStatus seatStatus = myPlayer2.SeatStatus;
							if (seatStatus != SeatStatus.Idle)
							{
								return;
							}
							JackarooGame jackarooGame2 = <Game>k__BackingField;
							bool flag8 = (object)<Game>k__BackingField == null;
							num = 0;
							if (!flag8)
							{
								JackarooLastActionInfo <LastAction>k__BackingField = jackarooGame2.<LastAction>k__BackingField;
								bool flag9 = jackarooGame2.<LastAction>k__BackingField == null;
								num = 0;
								if (!flag9)
								{
									KPlayer myPlayer3 = MyPlayer;
									bool flag10 = myPlayer3 == null;
									num = 0;
									if (!flag10)
									{
										object obj3 = ((LastActionInfo)<LastAction>k__BackingField).<ActionPlayer>k__BackingField - myPlayer3.<Index>k__BackingField;
										bool flag11 = obj3 == null;
										bool flag12 = ((LastActionInfo)<LastAction>k__BackingField).<ActionPlayer>k__BackingField != myPlayer3.<Index>k__BackingField;
										if (flag12)
										{
											return;
										}
										HideHighlights();
										bool flag13 = <Board>k__BackingField == null;
										num = 0;
										if (!flag13)
										{
											IReadOnlyList<JackarooMarble> allPlantedMarbles = <Board>k__BackingField.GetAllPlantedMarbles();
											bool flag14 = allPlantedMarbles == null;
											num = 0;
											if (!flag14)
											{
												object obj4 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3416;
												num = (int)obj4;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9DB58");
												object obj5 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
												object obj6 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 824;
												IReadOnlyList<JackarooMarble> readOnlyList = allPlantedMarbles;
												object obj7 = default(object);
												object obj16 = default(object);
												object obj22 = default(object);
												while (true)
												{
													bool flag15 = obj7 == null;
													obj8 = 0;
													if (flag15)
													{
														break;
													}
													object obj9 = obj7;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20+12E]");
													object obj10 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20+12E]");
													if ((nint)0 == 0)
													{
														goto IL_04bd;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v422 @ X8_v20+B0]");
													object obj11 = (nint)0 + (nint)8;
													bool flag16 = flag12;
													object obj12;
													while (true)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X10_v16-8]");
														obj3 = 0 - obj5;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v455 @ X10_v16-8]");
														if (0 == (nint)obj5)
														{
															break;
														}
														obj12 = obj11 + 16;
														obj10--;
														obj3 = obj10 - 1;
														flag11 = obj3 == null;
														flag12 = (nint)obj10 != 1;
														obj11 = obj12;
														flag16 = flag12;
														if (flag12)
														{
															continue;
														}
														goto IL_04bd;
													}
													object obj13 = obj9 + obj11;
													object obj14 = obj13 + 312;
													obj12 = obj11;
													flag12 = flag16;
													goto IL_0797;
													IL_04bd:
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
													readOnlyList = null;
													goto IL_0797;
													IL_0797:
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v37+8]");
													num = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v479 @ X0_v37] (should have been resolved before IL gen)");
													object obj15 = obj16 & 1;
													bool flag17 = obj15 == null;
													obj8 = 0;
													if (flag17)
													{
														goto IL_071e;
													}
													if (obj7 == null)
													{
														goto IL_06a9;
													}
													object obj17 = obj7;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v23+12E]");
													object obj18 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v23+12E]");
													if ((nint)0 == 0)
													{
														goto IL_05ee;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v23+B0]");
													object obj19 = (nint)0 + (nint)8;
													bool flag18 = flag12;
													while (true)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X10_v11-8]");
														obj3 = 0 - obj6;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X10_v11-8]");
														if (0 == (nint)obj6)
														{
															break;
														}
														obj12 = obj19 + 16;
														obj18--;
														obj3 = obj18 - 1;
														flag11 = obj3 == null;
														flag12 = (nint)obj18 != 1;
														obj19 = obj12;
														flag18 = flag12;
														if (flag12)
														{
															continue;
														}
														goto IL_05ee;
													}
													object obj20 = obj17 + obj19;
													object obj21 = obj20 + 312;
													obj12 = obj19;
													flag12 = flag18;
													goto IL_0825;
													IL_0825:
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X0_v41+8]");
													num = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v541 @ X0_v41] (should have been resolved before IL gen)");
													if (obj22 != null)
													{
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v43+18]");
														if ((nint)0 != 0)
														{
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X0_v43+18]");
															((JackarooMarbleMono)0).Reset();
															num = 0;
															continue;
														}
														goto IL_0692;
													}
													goto IL_06c0;
													IL_05ee:
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
													readOnlyList = null;
													goto IL_0825;
												}
												goto IL_0684;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0676;
		IL_0684:
		NullReferenceException ex = new NullReferenceException();
		goto IL_06dd;
		IL_06dd:
		if (num == 1)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj23 = default(object);
			obj8 = obj23;
			goto IL_071e;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0676:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0684;
		IL_06c0:
		ex = new NullReferenceException();
		obj8 = 0;
		goto IL_06dd;
		IL_06a9:
		ex = new NullReferenceException();
		obj8 = 0;
		goto IL_06dd;
		IL_0692:
		ex = new NullReferenceException();
		obj8 = 0;
		goto IL_06dd;
		IL_071e:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
	}

	private void Initialize()
	{
		//IL_0068: Expected O, but got I4
		//IL_0224: Expected O, but got I4
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		//IL_0047: Expected O, but got I4
		//IL_0134: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_016c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0171: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0386: Expected O, but got I4
		<Initialized>k__BackingField = true;
		<IsAnimating>k__BackingField = false;
		Quaternion localRotation = default(Quaternion);
		if (_movesRunnerIE != null)
		{
			((Queue<object>)(object)_movesQueue).Clear();
			StopCoroutine(_movesRunnerIE);
			_movesRunnerIE = null;
			object obj = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			localRotation = (Quaternion)0;
		}
		bool flag = !_boardInitialized;
		object obj2 = !flag;
		if (obj2 == null)
		{
			_boardInitialized = true;
			Room room = <Game>k__BackingField.Room;
			JackarooAllowedRules jackarooCustomRules = SFSKammelnaRoomExtensions.GetJackarooCustomRules(room);
			int myPlayerIndex;
			if (<Game>k__BackingField.IsSpectator)
			{
				myPlayerIndex = 1;
			}
			else
			{
				CardGamePlayer myPlayer = <Game>k__BackingField.MyPlayer;
				myPlayerIndex = ((KPlayer)myPlayer).<Index>k__BackingField;
			}
			bool isSpectator = <Game>k__BackingField.IsSpectator;
			JackarooGame jackarooGame = <Game>k__BackingField;
			object obj3 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 144;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			JackarooBoard jackarooBoard = default(JackarooBoard);
			jackarooBoard..ctor(isSpectator, myPlayerIndex, ((KGame)jackarooGame).<MySeatIndex>k__BackingField, jackarooCustomRules);
			object obj4 = this + 32;
			obj4 = jackarooBoard;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X8_v22+28]");
			SetupNodes((List<JackarooNode>)0, _nodePrefab, _p1Home, _verticalOffset, _horizontalOffset, _nodesParent);
			SetupMarbles();
			localRotation = (Quaternion)_nodePrefab;
		}
		Vector3 localPosition = _boardTransform.localPosition;
		Vector3 localEulerAngles = _boardTransform.localEulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Vector3 euler = default(Vector3);
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		_boardTransform.SetLocalPositionAndRotation((Vector3)0, localRotation);
		FixBoardRotation();
		ResetMarbles();
		HideHighlights();
		<Board>k__BackingField.ResetServerNodes();
		ApplyNodesTheme();
		ColorizeNodes();
		ColorizePlayerBases();
		ColorizeMarbles();
		UnblockBase(0);
		UnblockBase(1);
		UnblockBase(2);
		UnblockBase(3);
		ResetWinAnimations();
		JackarooGame jackarooGame2 = <Game>k__BackingField;
		SetBoardState(jackarooGame2._p);
		JackarooGame jackarooGame3 = <Game>k__BackingField;
		JackarooLastActionInfo <LastAction>k__BackingField = jackarooGame3.<LastAction>k__BackingField;
		if (jackarooGame3.<LastAction>k__BackingField != null && <LastAction>k__BackingField.<Card>k__BackingField != null)
		{
			object obj6 = "___# Content push apply failed [{0}]: {1}" + 2664;
			if (((LastActionInfo)<LastAction>k__BackingField).<Action>k__BackingField == (string)obj6)
			{
				OnPlayerDidLastAction(jackarooGame3.<LastAction>k__BackingField, (GameAction?)(object)0);
			}
		}
		JackarooGame jackarooGame4 = <Game>k__BackingField;
		if (((KGame)jackarooGame4).<Mover>k__BackingField >= 1)
		{
			SetTurnIndicator(((KGame)jackarooGame4).<Mover>k__BackingField);
		}
		bool isCurrentPerspectiveTopDown = _visualControls.IsCurrentPerspectiveTopDown;
		InitPerspective(isCurrentPerspectiveTopDown);
	}

	private void SetBoardState(int[][] playersMarbles)
	{
		//IL_0034: Expected O, but got I4
		//IL_0061: Expected I4, but got O
		//IL_0069: Expected O, but got I
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a7: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00c7: Expected O, but got I
		//IL_00cf: Expected O, but got I4
		//IL_00d7: Expected I, but got O
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0897: Expected O, but got I
		//IL_08c0: Expected O, but got I
		//IL_08d1: Expected O, but got I4
		//IL_0163: Expected I, but got O
		//IL_0190: Expected O, but got I4
		//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01ba: Expected I, but got O
		//IL_01ca: Expected O, but got I
		//IL_029c: Expected O, but got I
		//IL_02be: Expected O, but got I4
		//IL_02cb: Expected I, but got O
		//IL_02dc: Expected O, but got I4
		//IL_02e1: Expected I, but got O
		//IL_0205: Expected O, but got I
		//IL_0307: Expected O, but got I
		//IL_0940: Unknown result type (might be due to invalid IL or missing references)
		//IL_0945: Expected O, but got Unknown
		//IL_03ce: Expected I, but got O
		//IL_06fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0701: Expected O, but got Unknown
		//IL_070a: Unknown result type (might be due to invalid IL or missing references)
		//IL_070f: Expected O, but got Unknown
		//IL_071f: Expected O, but got I
		//IL_0743: Expected O, but got I4
		//IL_074c: Expected O, but got I4
		//IL_09bf: Expected O, but got I
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_0342: Expected O, but got I
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_0229: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0981: Unknown result type (might be due to invalid IL or missing references)
		//IL_0986: Expected O, but got Unknown
		//IL_078b: Expected O, but got I4
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_062f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0634: Expected O, but got Unknown
		//IL_064c: Expected O, but got I
		//IL_0358: Unknown result type (might be due to invalid IL or missing references)
		//IL_035d: Expected O, but got Unknown
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_036b: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_037b: Expected O, but got Unknown
		//IL_06ef: Expected I, but got O
		//IL_0438: Expected O, but got I
		//IL_0aad: Expected O, but got I
		//IL_0687: Expected O, but got I
		//IL_04ff: Expected I, but got O
		//IL_0a45: Expected O, but got I
		//IL_0473: Expected O, but got I
		//IL_07a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ab: Expected O, but got Unknown
		//IL_0a07: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a0c: Expected O, but got Unknown
		//IL_069d: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		//IL_06ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_051f: Expected O, but got Unknown
		//IL_0489: Unknown result type (might be due to invalid IL or missing references)
		//IL_048e: Expected O, but got Unknown
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_04a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_05c5: Expected O, but got I4
		//IL_05ca: Expected I, but got O
		//IL_05df: Expected I, but got O
		object obj3;
		object obj4;
		object obj16;
		nint num6;
		object obj17;
		object obj10;
		bool flag2;
		int[][] array = default(int[][]);
		object obj15;
		nint num2 = default(nint);
		if (<Board>k__BackingField != null && array != null)
		{
			object obj = array.Length - 1;
			bool flag = obj == null;
			flag2 = array.Length < 1;
			int num = (int)array;
			int[] array2 = (int[])num2;
			if (!flag2)
			{
				object obj2 = array + 32;
				int num3 = 0;
				do
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X23_v8+v342 @ X22_v18 (System.Int32)*8]");
					array2 = (int[])0;
					num3++;
					JackarooBoard jackarooBoard = <Board>k__BackingField;
					int playerIndex = num3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X23_v8+v342 @ X22_v18 (System.Int32)*8]");
					jackarooBoard.SetBoardState(playerIndex, (int[])0);
					obj = num3 - array.Length;
					flag = obj == null;
					flag2 = num3 < array.Length;
					num = num3;
				}
				while (flag2);
			}
			obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
			obj4 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 824;
			object obj5 = (nint)0 + (nint)2968;
			array = (int[][])num;
			num2 = (nint)array2;
			int num4 = 0;
			JackarooBoard jackarooBoard2 = <Board>k__BackingField;
			if (<Board>k__BackingField != null && jackarooBoard2._playersPlantedMarbles != null)
			{
				num2 = (nint)obj5;
				object obj6 = ((List<object>)(object)jackarooBoard2._playersPlantedMarbles).get_Item(num4);
				bool flag3 = obj6 == null;
				array = (int[][])num4;
				if (!flag3)
				{
					object obj7 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3416;
					nint num5 = (nint)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v13 (Il2CppClass<System.Object>)+12E]");
					object obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v13 (Il2CppClass<System.Object>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0282;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v438 @ X8_v13 (Il2CppClass<System.Object>)+B0]");
					object obj9 = (nint)0 + (nint)8;
					bool flag4 = flag2;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X10_v29-8]");
						obj = 0 - obj7;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v471 @ X10_v29-8]");
						if (0 == (nint)obj7)
						{
							break;
						}
						obj10 = obj9 + 16;
						obj8--;
						obj = obj8 - 1;
						flag = obj == null;
						flag2 = (nint)obj8 != 1;
						obj9 = obj10;
						flag4 = flag2;
						if (flag2)
						{
							continue;
						}
						goto IL_0282;
					}
					object obj11 = num5 + obj9;
					object obj12 = obj11 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v504 @ X8_v34+8]");
					array = (int[][])0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v504 @ X8_v34] (should have been resolved before IL gen)");
					object obj13 = default(object);
					bool flag5 = obj13 == null;
					object obj14 = !flag5;
					obj15 = 0;
					obj16 = obj13;
					obj10 = obj9;
					num6 = num2;
					obj17 = obj13;
					flag2 = flag4;
					if (obj14 != null)
					{
						goto IL_02ef;
					}
					obj15 = 0;
					goto IL_05ed;
				}
			}
		}
		throw new NullReferenceException();
		IL_0abc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0a9d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X0_v25+8]");
		array = (int[][])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v754 @ X0_v25] (should have been resolved before IL gen)");
		goto IL_0a6c;
		IL_02ef:
		object obj24 = default(object);
		JackarooMarble jackarooMarble = default(JackarooMarble);
		while (true)
		{
			object obj18 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v16+12E]");
			object obj19 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v16+12E]");
			if ((nint)0 == 0)
			{
				goto IL_03bf;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X8_v16+B0]");
			object obj20 = (nint)0 + (nint)8;
			bool flag6 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X10_v24-8]");
				object obj = 0 - obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v572 @ X10_v24-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj10 = obj20 + 16;
				obj19--;
				obj = obj19 - 1;
				bool flag = obj == null;
				flag2 = (nint)obj19 != 1;
				obj20 = obj10;
				flag6 = flag2;
				if (flag2)
				{
					continue;
				}
				goto IL_03bf;
			}
			object obj21 = obj18 + obj20;
			object obj22 = obj21 + 312;
			obj10 = obj20;
			flag2 = flag6;
			goto IL_09af;
			IL_09af:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v596 @ X0_v21+8]");
			array = (int[][])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v596 @ X0_v21] (should have been resolved before IL gen)");
			object obj23 = obj24 & 1;
			if (obj23 == null)
			{
				break;
			}
			if (obj16 == null)
			{
				goto IL_080b;
			}
			object obj25 = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v26+12E]");
			object obj26 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v26+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04f0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v26+B0]");
			object obj27 = (nint)0 + (nint)8;
			bool flag7 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v19-8]");
				object obj = 0 - obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v699 @ X10_v19-8]");
				if (0 == (nint)obj4)
				{
					break;
				}
				obj10 = obj27 + 16;
				obj26--;
				obj = obj26 - 1;
				bool flag = obj == null;
				flag2 = (nint)obj26 != 1;
				obj27 = obj10;
				flag7 = flag2;
				if (flag2)
				{
					continue;
				}
				goto IL_04f0;
			}
			object obj28 = obj25 + obj27;
			object obj29 = obj28 + 312;
			obj10 = obj27;
			flag2 = flag7;
			goto IL_0a35;
			IL_0a35:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X0_v32+8]");
			array = (int[][])0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v746 @ X0_v32] (should have been resolved before IL gen)");
			if (jackarooMarble == null)
			{
				goto IL_07ed;
			}
			JackarooNode <Node>k__BackingField = jackarooMarble.<Node>k__BackingField;
			if (jackarooMarble.<Node>k__BackingField != null)
			{
				if ((object)jackarooMarble.<MarbleMono>k__BackingField != null)
				{
					jackarooMarble.<MarbleMono>k__BackingField.MoveImmediate(<Node>k__BackingField.<NodeMono>k__BackingField);
					CheckMarbleBlocksBase(jackarooMarble);
					bool flag8 = obj16 == null;
					object obj30 = !flag8;
					num6 = unchecked((nint)null);
					obj17 = obj16;
					array = (int[][])(object)jackarooMarble;
					num2 = unchecked((nint)null);
					if (obj30 != null)
					{
						continue;
					}
					goto IL_05ed;
				}
				goto IL_07cf;
			}
			goto IL_0829;
			IL_04f0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num6 = unchecked((nint)null);
			goto IL_0a35;
			IL_03bf:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num6 = unchecked((nint)null);
			goto IL_09af;
		}
		if (obj16 == null)
		{
			goto IL_0a6c;
		}
		object obj31 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
		object obj32 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v22+12E]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v22+12E]");
		if ((nint)0 == 0)
		{
			goto IL_06e0;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v610 @ X8_v22+B0]");
		object obj34 = (nint)0 + (nint)8;
		bool flag9 = flag2;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v720 @ X10_v13-8]");
			if (0 == (nint)obj31)
			{
				break;
			}
			obj10 = obj34 + 16;
			obj33--;
			flag2 = (nint)obj33 != 1;
			obj34 = obj10;
			flag9 = flag2;
			if (flag2)
			{
				continue;
			}
			goto IL_06e0;
		}
		object obj35 = obj32 + obj34;
		object obj36 = obj35 + 312;
		obj10 = obj34;
		flag2 = flag9;
		goto IL_0a9d;
		IL_07cf:
		NullReferenceException ex = new NullReferenceException();
		num2 = num6;
		OutOfMemoryException ex2 = (OutOfMemoryException)(object)ex;
		goto IL_0abc;
		IL_0282:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X0_v46+8]");
		array = (int[][])0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v469 @ X0_v46] (should have been resolved before IL gen)");
		object obj37 = default(object);
		bool flag10 = obj37 == null;
		obj15 = 0;
		obj16 = obj37;
		num6 = unchecked((nint)null);
		obj17 = obj37;
		obj15 = 0;
		num2 = unchecked((nint)null);
		if (!flag10)
		{
			goto IL_02ef;
		}
		goto IL_05ed;
		IL_05ed:
		NullReferenceException ex3 = new NullReferenceException();
		ex2 = (OutOfMemoryException)(object)ex3;
		goto IL_0abc;
		IL_0829:
		NullReferenceException ex4 = new NullReferenceException();
		num2 = num6;
		ex2 = (OutOfMemoryException)(object)ex4;
		goto IL_0abc;
		IL_06e0:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num6 = unchecked((nint)null);
		goto IL_0a9d;
		IL_0a6c:
		num2 = num6;
		ex2 = new OutOfMemoryException();
		goto IL_0abc;
		IL_080b:
		NullReferenceException ex5 = new NullReferenceException();
		num2 = num6;
		ex2 = (OutOfMemoryException)(object)ex5;
		goto IL_0abc;
		IL_07ed:
		NullReferenceException ex6 = new NullReferenceException();
		num2 = num6;
		ex2 = (OutOfMemoryException)(object)ex6;
		goto IL_0abc;
	}

	private void SetupNodes(List<JackarooNode> boardNodes, JackarooNodeMono nodePrefab, Transform p1Home, float verticalOffset, float horizontalOffset, RectTransform nodesParent)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_006e: Expected O, but got I4
		//IL_0096: Expected O, but got I4
		//IL_00ac: Expected I, but got O
		//IL_00bc: Expected O, but got I
		//IL_00e5: Expected O, but got I
		//IL_011b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_01c0: Expected O, but got I8
		//IL_0165: Expected I, but got O
		//IL_0175: Expected O, but got I
		//IL_019e: Expected O, but got I
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0293: Expected O, but got I4
		//IL_02a3: Expected O, but got I4
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c8: Expected O, but got Unknown
		//IL_0230: Expected I, but got O
		//IL_0240: Expected O, but got I
		//IL_0269: Expected O, but got I
		//IL_02df: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_0384: Expected O, but got I8
		//IL_0329: Expected I, but got O
		//IL_0339: Expected O, but got I
		//IL_0362: Expected O, but got I
		//IL_03aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_03af: Expected O, but got Unknown
		//IL_0402: Expected O, but got I
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_043e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0443: Expected O, but got Unknown
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a5: Expected O, but got Unknown
		float verticalOffset2 = default(float);
		float horizontalOffset2 = default(float);
		InitializeRing(boardNodes, nodePrefab, p1Home, verticalOffset2, horizontalOffset2, nodesParent);
		JackarooBoard jackarooBoard = <Board>k__BackingField;
		bool flag = <Board>k__BackingField == null;
		IReadOnlyList<JackarooNode> readOnlyList = (IReadOnlyList<JackarooNode>)p1Home;
		JackarooNodeMono jackarooNodeMono = nodePrefab;
		NullReferenceException ex = default(NullReferenceException);
		if (!flag)
		{
			object obj = typeof(SqlSingle[]) + 336;
			readOnlyList = jackarooBoard.<Nodes>k__BackingField;
			InitializeBases(_nodePrefab, jackarooBoard.<Nodes>k__BackingField, _baseVerticalOffset, _baseHorizontalOffset);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			Transform[] array = default(Transform[]);
			bool flag2 = array == null;
			jackarooNodeMono = (JackarooNodeMono)4;
			if (!flag2)
			{
				bool flag3 = (object)_graveyard1 == null;
				JackarooNodeMono jackarooNodeMono2 = (JackarooNodeMono)4;
				if (!flag3)
				{
					nint num = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v21 (Il2CppClass<UnityEngine.Transform[]>)+40]");
					jackarooNodeMono2 = (JackarooNodeMono)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag4 = ex == null;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v21 (Il2CppClass<UnityEngine.Transform[]>)+40]");
					jackarooNodeMono = (JackarooNodeMono)0;
					if (flag4)
					{
						goto IL_04dc;
					}
				}
				if (array.Length != 0)
				{
					object obj2 = array + 32;
					obj2 = _graveyard1;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					bool flag5 = (object)_graveyard2 == null;
					jackarooNodeMono2 = (JackarooNodeMono)(object)_graveyard1;
					if (!flag5)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v20 (Il2CppClass<UnityEngine.Transform[]>)+40]");
						jackarooNodeMono2 = (JackarooNodeMono)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag6 = ex == null;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v175 @ X8_v20 (Il2CppClass<UnityEngine.Transform[]>)+40]");
						jackarooNodeMono = (JackarooNodeMono)0;
						if (flag6)
						{
							goto IL_04dc;
						}
					}
					object obj3 = array.Length & 0xFFFFFFFEL;
					if (obj3 != null)
					{
						object obj4 = array + 40;
						obj4 = _graveyard2;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag7 = (object)_graveyard3 == null;
						jackarooNodeMono2 = (JackarooNodeMono)(object)_graveyard2;
						if (!flag7)
						{
							nint num3 = (nint)array;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v19 (Il2CppClass<UnityEngine.Transform[]>)+40]");
							jackarooNodeMono2 = (JackarooNodeMono)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
							bool flag8 = ex == null;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X8_v19 (Il2CppClass<UnityEngine.Transform[]>)+40]");
							jackarooNodeMono = (JackarooNodeMono)0;
							if (flag8)
							{
								goto IL_04dc;
							}
						}
						bool flag9 = array.Length < 2;
						object obj5 = !flag9;
						object obj6 = array.Length - 2;
						bool flag10 = obj6 == null;
						object obj7 = ~obj5;
						object obj8 = obj7 | flag10;
						if (obj8 == null)
						{
							object obj9 = array + 48;
							obj9 = _graveyard3;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							bool flag11 = (object)_graveyard4 == null;
							jackarooNodeMono2 = (JackarooNodeMono)(object)_graveyard3;
							if (!flag11)
							{
								nint num4 = (nint)array;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v18 (Il2CppClass<UnityEngine.Transform[]>)+40]");
								jackarooNodeMono2 = (JackarooNodeMono)0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
								bool flag12 = ex == null;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v18 (Il2CppClass<UnityEngine.Transform[]>)+40]");
								jackarooNodeMono = (JackarooNodeMono)0;
								if (flag12)
								{
									goto IL_04dc;
								}
							}
							object obj10 = array.Length & 0xFFFFFFFCL;
							if (obj10 != null)
							{
								object obj11 = array + 56;
								obj11 = _graveyard4;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								JackarooBoard jackarooBoard2 = <Board>k__BackingField;
								bool flag13 = <Board>k__BackingField == null;
								jackarooNodeMono = (JackarooNodeMono)(object)_graveyard4;
								if (!flag13)
								{
									object obj12 = (nint)0 + (nint)1992;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C958DC");
									IReadOnlyList<JackarooNode> graveyardsNodes = default(IReadOnlyList<JackarooNode>);
									InitializeGraveyards(_nodePrefab, array, graveyardsNodes, _graveyardVerticalOffset, _graveyardHorizontalOffset);
									Transform transform = SetupPlantReference(1);
									object obj13 = this + 64;
									obj13 = transform;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Transform transform2 = SetupPlantReference(2);
									object obj14 = this + 72;
									obj14 = transform2;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Transform transform3 = SetupPlantReference(3);
									object obj15 = this + 80;
									obj15 = transform3;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									Transform transform4 = SetupPlantReference(4);
									object obj16 = this + 88;
									obj16 = transform4;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
									return;
								}
								goto IL_04ce;
							}
						}
					}
				}
				IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
				jackarooNodeMono = jackarooNodeMono2;
			}
		}
		goto IL_04ce;
		IL_04ce:
		ex = new NullReferenceException();
		goto IL_04dc;
		IL_04dc:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
	}

	private Transform GetPlantReference(int rotatedPlayerIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_0090: Expected O, but got I
		object obj = rotatedPlayerIndex - 1;
		bool flag = (nint)obj < 3;
		object obj2 = !flag;
		object obj3 = obj - 3;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		object obj5 = obj2 & obj4;
		if (obj5 == null)
		{
			object obj6 = obj << 3;
			object obj7 = (object)this + obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v14 @ X8_v3+40]");
			return (Transform)0;
		}
		return null;
	}

	private Transform SetupPlantReference(int rotatedPlayerIndex)
	{
		//IL_0009: Expected O, but got I4
		//IL_001f: Expected O, but got I
		//IL_00f9: Expected O, but got I
		//IL_0113: Expected O, but got I4
		//IL_011e: Expected O, but got I4
		//IL_0129: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_0052: Expected O, but got I
		//IL_006c: Expected O, but got I4
		//IL_0077: Expected O, but got I4
		//IL_016a: Expected I4, but got O
		//IL_0815: Expected O, but got I4
		//IL_081d: Expected I4, but got O
		//IL_00cb: Expected I4, but got O
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01af: Expected O, but got I
		//IL_01fd: Expected O, but got I4
		//IL_0844: Expected O, but got I
		//IL_0850: Expected O, but got I
		//IL_0860: Expected O, but got I
		//IL_0870: Expected O, but got I
		//IL_0892: Expected O, but got I4
		//IL_0282: Expected I, but got O
		//IL_029b: Expected I4, but got O
		//IL_0245: Expected O, but got I4
		//IL_0771: Expected I4, but got O
		//IL_0799: Expected I4, but got O
		//IL_08b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bc: Expected O, but got Unknown
		//IL_08d2: Expected O, but got I
		//IL_08e3: Expected I, but got O
		//IL_0901: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_030f: Expected O, but got Unknown
		//IL_031b: Expected O, but got I
		//IL_0275: Expected O, but got I
		//IL_07c8: Expected I4, but got O
		//IL_0928: Expected I4, but got O
		//IL_0366: Expected I4, but got O
		//IL_043c: Expected O, but got I4
		//IL_046f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0474: Expected O, but got Unknown
		//IL_0484: Expected O, but got I
		//IL_04c9: Expected O, but got I
		//IL_051b: Expected O, but got I4
		//IL_052c: Expected O, but got I
		//IL_053d: Expected O, but got F4
		//IL_054c: Expected O, but got I4
		//IL_05a7: Expected I4, but got O
		//IL_05ac: Expected I, but got O
		//IL_05cc: Expected I4, but got O
		//IL_060c: Expected I, but got O
		//IL_062c: Expected I4, but got O
		//IL_0675: Expected I4, but got O
		//IL_067a: Expected I, but got O
		//IL_069a: Expected I4, but got O
		//IL_06d2: Expected O, but got I4
		object obj = 152989696;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F80]");
		object obj2 = (nint)0 & (nint)1;
		List<object>.Enumerator enumerator;
		if (obj2 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			enumerator = (List<object>.Enumerator)0;
			enumerator = (List<object>.Enumerator)0;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0B9]");
			object obj4 = (nint)0 & (nint)1;
			bool flag2 = obj4 == null;
			object obj5 = !flag2;
			enumerator = (List<object>.Enumerator)0;
			enumerator = (List<object>.Enumerator)0;
			if (obj5 != null)
			{
				goto IL_0085;
			}
		}
		_ = 1;
		JackarooBoard jackarooBoard = <Board>k__BackingField;
		bool flag3 = <Board>k__BackingField == null;
		int num = rotatedPlayerIndex;
		int num2 = (int)<Board>k__BackingField;
		JackarooBoardMono jackarooBoardMono = this;
		int num3 = rotatedPlayerIndex;
		if (flag3)
		{
			goto IL_07da;
		}
		goto IL_07f0;
		IL_07da:
		NullReferenceException ex = new NullReferenceException();
		List<object>.Enumerator enumerator2 = enumerator;
		goto IL_071a;
		IL_06dc:
		NullReferenceException ex2 = new NullReferenceException();
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator3 = enumerator4;
		int num4 = 0;
		List<object> list2;
		List<object> list = list2;
		enumerator = enumerator4;
		jackarooBoardMono = this;
		num3 = rotatedPlayerIndex;
		goto IL_07da;
		IL_03a3:
		JackarooBoard jackarooBoard2 = jackarooBoardMono.<Board>k__BackingField;
		bool flag4 = jackarooBoardMono.<Board>k__BackingField == null;
		List<object>.Enumerator enumerator5;
		enumerator3 = enumerator5;
		int num5;
		num3 = num5;
		object obj10 = default(object);
		if (!flag4)
		{
			(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes = jackarooBoard2._homesAndBasesEntryNodes;
			bool flag5 = jackarooBoard2._homesAndBasesEntryNodes == null;
			enumerator3 = enumerator5;
			num3 = num5;
			if (!flag5)
			{
				bool flag6 = num2 < homesAndBasesEntryNodes.Length;
				object obj6 = !flag6;
				enumerator3 = enumerator5;
				enumerator2 = enumerator;
				num3 = num5;
				if (obj6 != null)
				{
					goto IL_071a;
				}
				object obj7 = jackarooBoard2._homesAndBasesEntryNodes + num2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v7+20]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v7+20]");
				bool flag7 = (nint)0 == 0;
				enumerator3 = enumerator5;
				num3 = num5;
				if (!flag7)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v8+18]");
					JackarooNodeMono jackarooNodeMono = (JackarooNodeMono)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v8+18]");
					bool flag8 = (nint)0 == 0;
					enumerator3 = enumerator5;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v8+18]");
					num2 = 0;
					num3 = num5;
					if (!flag8)
					{
						list = (List<object>)list._size;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v8+18]");
						Vector3 position = ((JackarooNodeMono)0).Position;
						enumerator3 = (List<object>.Enumerator)jackarooBoardMono._plantReferenceMultiplier;
						object obj9 = 153100288 + 1024;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
						object arg = default(object);
						string text = string.Format((string)obj10, arg);
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						GameObject gameObject = default(GameObject);
						gameObject..ctor(text);
						bool flag9 = (object)gameObject == null;
						num4 = num5;
						num = (int)text;
						nint num6 = unchecked((nint)null);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v8+18]");
						num2 = 0;
						jackarooBoardMono = (JackarooBoardMono)(object)gameObject;
						num3 = (int)text;
						if (!flag9)
						{
							Transform transform = gameObject.transform;
							bool flag10 = (object)transform == null;
							num4 = num5;
							num = 0;
							num6 = unchecked((nint)null);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v8+18]");
							num2 = 0;
							jackarooBoardMono = (JackarooBoardMono)(object)gameObject;
							num3 = (int)text;
							if (!flag10)
							{
								transform.SetParent(jackarooNodeMono.<Transform>k__BackingField);
								bool flag11 = (object)jackarooNodeMono.<Transform>k__BackingField == null;
								num4 = num5;
								num = (int)jackarooNodeMono.<Transform>k__BackingField;
								num6 = unchecked((nint)null);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X8_v8+18]");
								num2 = 0;
								jackarooBoardMono = (JackarooBoardMono)(object)gameObject;
								num3 = (int)transform;
								if (!flag11)
								{
									Vector3 up = jackarooNodeMono.<Transform>k__BackingField.up;
									Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
									transform.position = (Vector3)0;
									return transform;
								}
							}
						}
					}
				}
			}
		}
		goto IL_07da;
		IL_0085:
		jackarooBoard = <Board>k__BackingField;
		bool flag12 = <Board>k__BackingField == null;
		object obj11 = !flag12;
		if (obj11 == null)
		{
			num = rotatedPlayerIndex;
			num2 = (int)<Board>k__BackingField;
			jackarooBoardMono = this;
			num3 = rotatedPlayerIndex;
			goto IL_07da;
		}
		goto IL_07f0;
		IL_07f0:
		bool flag13 = jackarooBoard._graveyardsNodes == null;
		num = rotatedPlayerIndex;
		list = (List<object>)152989696;
		num2 = (int)jackarooBoard;
		jackarooBoardMono = this;
		num3 = rotatedPlayerIndex;
		object obj17 = default(object);
		if (!flag13)
		{
			obj10 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 304;
			object obj12 = (nint)0 + (nint)3000;
			num2 = rotatedPlayerIndex - 1;
			object obj13 = ((List<object>)(object)jackarooBoard._graveyardsNodes).get_Item(num2);
			object obj14 = obj10;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v37+E4]");
			bool flag14 = (nint)0 == 0;
			object obj15 = !flag14;
			if (obj15 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj14 = obj10;
			}
			object obj16 = (nint)0 + (nint)3632;
			obj17 = (nint)0 + (nint)2272;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v37+B8]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v28+8]");
			Func<object, object> selector = (Func<object, object>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v28+8]");
			bool flag15 = (nint)0 == 0;
			object obj19 = !flag15;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v359 @ X0_v37+E4]");
				bool flag16 = (nint)0 == 0;
				object obj20 = !flag16;
				if (obj20 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj21 = obj10;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v34+B8]");
					obj18 = 0;
				}
				object obj22 = obj18;
				object obj23 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2120;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj24 = (nint)0 + (nint)1544;
				Func<object, object> func = default(Func<object, object>);
				func..ctor(obj18, (IntPtr)obj24);
				object obj25 = obj10;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v397 @ X8_v33+B8]");
				object obj26 = (nint)0 + (nint)8;
				obj26 = func;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				selector = func;
			}
			nint num6 = (nint)obj16;
			IEnumerable<object> source = Enumerable.Select((IEnumerable<object>)obj13, selector);
			num = (int)obj17;
			list2 = Enumerable.ToList(source);
			bool flag17 = list2 == null;
			list = (List<object>)obj13;
			jackarooBoardMono = this;
			num3 = rotatedPlayerIndex;
			if (!flag17)
			{
				object obj27 = (nint)0 + (nint)2848;
				obj10 = "Picking audio files is not supported on iOS" + 112;
				object obj22 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
				obj17 = (nint)0 + (nint)2840;
				List<object>.Enumerator enumerator6 = list2.GetEnumerator();
				JackarooNodeMono jackarooNodeMono2 = default(JackarooNodeMono);
				while (true)
				{
					num = (int)obj27;
					if (!enumerator.MoveNext())
					{
						break;
					}
					if ((object)jackarooNodeMono2 != null)
					{
						Vector3 position2 = jackarooNodeMono2.Position;
						continue;
					}
					goto IL_06dc;
				}
				num = (int)obj17;
				enumerator.Dispose();
				enumerator5 = enumerator4;
				num4 = 0;
				list = list2;
				enumerator = enumerator4;
				jackarooBoardMono = this;
				num5 = rotatedPlayerIndex;
				goto IL_03a3;
			}
		}
		goto IL_07da;
		IL_071a:
		IndexOutOfRangeException ex3 = new IndexOutOfRangeException();
		bool flag18 = num != 1;
		IndexOutOfRangeException ex4 = ex3;
		if (!flag18)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (int)obj17;
			enumerator2.Dispose();
			object obj28 = default(object);
			bool flag19 = obj28 == null;
			enumerator5 = enumerator3;
			num4 = (int)obj28;
			enumerator = enumerator2;
			num5 = num3;
			if (flag19)
			{
				goto IL_03a3;
			}
			OutOfMemoryException ex5 = new OutOfMemoryException();
			num4 = (int)obj28;
			ex4 = (IndexOutOfRangeException)(object)ex5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BA48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		Transform result = default(Transform);
		return result;
	}

	private static void RotateAndMoveBoard(Transform boardTransform, float positionY, float rotationX)
	{
		//IL_0049: Expected O, but got I4
		Vector3 localPosition = boardTransform.localPosition;
		Vector3 localEulerAngles = boardTransform.localEulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Vector3 euler = default(Vector3);
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		Quaternion localRotation = default(Quaternion);
		boardTransform.SetLocalPositionAndRotation((Vector3)0, localRotation);
	}

	private void FixBoardRotation()
	{
		//IL_0098: Expected O, but got I4
		Transform transform = base.transform;
		Transform root = transform.root;
		Transform transform2 = root.transform;
		Vector3 localScale = transform2.localScale;
		Vector3 localPosition = _boardTransform.localPosition;
		Vector3 localEulerAngles = _boardTransform.localEulerAngles;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Vector3 euler = default(Vector3);
		Quaternion quaternion = Quaternion.Internal_FromEulerRad(ref euler);
		Quaternion localRotation = default(Quaternion);
		_boardTransform.SetLocalPositionAndRotation((Vector3)0, localRotation);
	}

	private void DoPlayJackarooMove(JackarooMove move, Action onComplete = null, GameAction? emote = null)
	{
		//IL_0113: Expected I4, but got O
		//IL_0525: Expected O, but got I4
		//IL_0533: Expected O, but got I4
		//IL_0152: Expected O, but got I4
		//IL_0160: Expected O, but got I4
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_08db: Expected O, but got I4
		//IL_0436: Expected O, but got I4
		//IL_0444: Expected O, but got I4
		//IL_0464: Unknown result type (might be due to invalid IL or missing references)
		//IL_0469: Expected O, but got Unknown
		//IL_02ac: Expected O, but got I4
		//IL_02ba: Expected O, but got I4
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_0842: Expected I, but got O
		//IL_085e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0863: Expected O, but got Unknown
		//IL_01ad: Expected O, but got I4
		//IL_01bb: Expected O, but got I4
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_0904: Expected O, but got I4
		//IL_090d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0912: Expected I4, but got Unknown
		//IL_0928: Expected O, but got I4
		//IL_089a: Expected O, but got I
		//IL_05c6: Expected O, but got I4
		//IL_05d4: Expected O, but got I4
		//IL_07e8: Expected O, but got I4
		//IL_07f6: Expected O, but got I4
		//IL_0744: Expected O, but got I4
		//IL_0752: Expected O, but got I4
		//IL_04be: Expected O, but got I4
		//IL_04cc: Expected O, but got I4
		//IL_0324: Expected O, but got I4
		//IL_0332: Expected O, but got I4
		//IL_064a: Expected O, but got I4
		//IL_0658: Expected O, but got I4
		//IL_0686: Expected I4, but got O
		//IL_078c: Expected I4, but got O
		//IL_0225: Expected O, but got I4
		//IL_0233: Expected O, but got I4
		//IL_0261: Expected I4, but got O
		//IL_035c: Expected I4, but got O
		bool flag = move == null;
		bool flag2 = move.<Action>k__BackingField == JackarooActions.BURN_OTHER_CARD_RANDOM;
		if (move.<Action>k__BackingField < JackarooActions.BURN_OTHER_CARD_RANDOM)
		{
			if (move.<Action>k__BackingField == JackarooActions.BURN_MY_CARD || move.<Action>k__BackingField == JackarooActions.BURN_OTHER_CARD)
			{
				goto IL_00c9;
			}
		}
		else if (flag2 || move.<Action>k__BackingField == JackarooActions.STEAL)
		{
			goto IL_00c9;
		}
		HighlightFirstNode(move, animate: false);
		HighlightNodesAndMarbles(move);
		List<JackarooNodeMono> highlightedFirstNodes = _highlightedFirstNodes;
		HideFirstNodesHighlight(_highlightedFirstNodes);
		JackarooActions <Action>k__BackingField = move.<Action>k__BackingField;
		bool flag3 = move.<Action>k__BackingField > JackarooActions.MOVE_SPLIT_5_2;
		Action action = null;
		bool flag4 = false;
		List<JackarooNodeMono> highlightedFirstNodes2 = _highlightedFirstNodes;
		JackarooActions <Action>k__BackingField2 = move.<Action>k__BackingField;
		if (flag3)
		{
			goto IL_0138;
		}
		goto IL_03fc;
		IL_093e:
		JackarooMove move2;
		Action onComplete2;
		Move(move2, onComplete2, emote);
		return;
		IL_0830:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C9D050");
		JackarooMove jackarooMove;
		nint num = (nint)jackarooMove;
		Action action2 = (Action)(object)jackarooMove.ToString();
		object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		ArgumentOutOfRangeException ex = default(ArgumentOutOfRangeException);
		ex..ctor((string)(object)action2);
		object obj2 = (nint)0 + (nint)384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		flag4 = false;
		List<JackarooNodeMono> list = default(List<JackarooNodeMono>);
		highlightedFirstNodes2 = list;
		jackarooMove = (JackarooMove)(object)ex;
		onComplete2 = action2;
		throw new OutOfMemoryException();
		IL_06fd:
		bool flag5 = <Action>k__BackingField == JackarooActions.MOVE_SPLIT_6_1;
		move2 = move;
		onComplete2 = onComplete;
		if (!flag5)
		{
			bool flag6 = <Action>k__BackingField < JackarooActions.MOVE_SPLIT_7_0;
			object obj3 = !flag6;
			object obj4 = <Action>k__BackingField - 4096;
			bool flag7 = <Action>k__BackingField == JackarooActions.MOVE_SPLIT_7_0;
			move2 = move;
			onComplete2 = onComplete;
			if (!flag7)
			{
				flag4 = (byte)(int)action != 0;
				highlightedFirstNodes2 = highlightedFirstNodes;
				jackarooMove = move;
				goto IL_0830;
			}
		}
		goto IL_093e;
		IL_03fc:
		if (<Action>k__BackingField2 > JackarooActions.MOVE_SPLIT_1_6)
		{
			bool flag8 = <Action>k__BackingField2 < JackarooActions.MOVE_SPLIT_3_4;
			object obj5 = !flag8;
			object obj6 = <Action>k__BackingField2 - 256;
			bool flag9 = obj6 == null;
			object obj7 = ~obj5;
			object obj8 = obj7 | flag9;
			if (obj8 == null)
			{
				bool flag10 = <Action>k__BackingField2 == JackarooActions.MOVE_SPLIT_4_3;
				move2 = move;
				onComplete2 = onComplete;
				if (!flag10)
				{
					bool flag11 = <Action>k__BackingField2 < JackarooActions.MOVE_SPLIT_5_2;
					object obj3 = !flag11;
					object obj4 = <Action>k__BackingField2 - 1024;
					bool flag7 = <Action>k__BackingField2 == JackarooActions.MOVE_SPLIT_5_2;
					move2 = move;
					onComplete2 = onComplete;
					if (!flag7)
					{
						jackarooMove = move;
						goto IL_0830;
					}
				}
			}
			else
			{
				bool flag12 = <Action>k__BackingField2 == JackarooActions.MOVE_SPLIT_2_5;
				move2 = move;
				onComplete2 = onComplete;
				if (!flag12)
				{
					bool flag13 = <Action>k__BackingField2 < JackarooActions.MOVE_SPLIT_3_4;
					object obj3 = !flag13;
					object obj4 = <Action>k__BackingField2 - 256;
					bool flag7 = <Action>k__BackingField2 == JackarooActions.MOVE_SPLIT_3_4;
					jackarooMove = move;
					move2 = move;
					onComplete2 = onComplete;
					if (!flag7)
					{
						goto IL_0830;
					}
				}
			}
		}
		else
		{
			bool flag14 = <Action>k__BackingField2 < JackarooActions.MOVE_CHOICE_1;
			object obj3 = !flag14;
			object obj4 = <Action>k__BackingField2 - 16;
			bool flag7 = obj4 == null;
			bool flag15 = <Action>k__BackingField2 <= JackarooActions.MOVE_CHOICE_1;
			num = (nint)<Action>k__BackingField2;
			jackarooMove = move;
			onComplete2 = onComplete;
			if (flag15)
			{
				object obj9 = !flag7;
				object obj10 = obj3 & obj9;
				if (obj10 == null)
				{
					object obj11 = 1 << (int)num;
					flag = (byte)(obj11 & 0x10116) != 0;
					flag7 = !flag;
					obj3 = 0;
					move2 = jackarooMove;
					if (!flag7)
					{
						goto IL_093e;
					}
				}
				goto IL_0830;
			}
			bool flag16 = <Action>k__BackingField2 == JackarooActions.MOVE_CHOICE_11;
			move2 = move;
			onComplete2 = onComplete;
			if (!flag16)
			{
				bool flag17 = <Action>k__BackingField2 < JackarooActions.MOVE_SPLIT_1_6;
				obj3 = !flag17;
				obj4 = <Action>k__BackingField2 - 64;
				flag7 = <Action>k__BackingField2 == JackarooActions.MOVE_SPLIT_1_6;
				move2 = move;
				onComplete2 = onComplete;
				if (!flag7)
				{
					jackarooMove = move;
					goto IL_0830;
				}
			}
		}
		goto IL_093e;
		IL_00c9:
		highlightedFirstNodes = _highlightedFirstNodes;
		HideFirstNodesHighlight(_highlightedFirstNodes);
		<Action>k__BackingField = move.<Action>k__BackingField;
		bool flag18 = move.<Action>k__BackingField <= JackarooActions.MOVE_SPLIT_5_2;
		action = onComplete;
		flag4 = (byte)(int)onComplete != 0;
		highlightedFirstNodes2 = _highlightedFirstNodes;
		<Action>k__BackingField2 = move.<Action>k__BackingField;
		if (!flag18)
		{
			goto IL_0138;
		}
		goto IL_03fc;
		IL_0138:
		bool flag19 = <Action>k__BackingField < JackarooActions.BURN_MY_CARD;
		object obj12 = !flag19;
		object obj13 = <Action>k__BackingField - 16384;
		bool flag20 = obj13 == null;
		object obj14 = ~obj12;
		object obj15 = obj14 | flag20;
		if (obj15 == null)
		{
			bool flag21 = <Action>k__BackingField < JackarooActions.BURN_OTHER_CARD_RANDOM;
			object obj16 = !flag21;
			object obj17 = <Action>k__BackingField - 65536;
			bool flag22 = obj17 == null;
			object obj18 = ~obj16;
			object obj19 = obj18 | flag22;
			if (obj19 == null)
			{
				if (<Action>k__BackingField != JackarooActions.STEAL)
				{
					bool flag23 = <Action>k__BackingField < JackarooActions.PLANT;
					object obj3 = !flag23;
					object obj4 = <Action>k__BackingField - 131072;
					bool flag7 = obj4 == null;
					bool flag24 = <Action>k__BackingField != JackarooActions.PLANT;
					flag4 = (byte)(int)action != 0;
					highlightedFirstNodes2 = highlightedFirstNodes;
					jackarooMove = move;
					if (!flag24)
					{
						Plant(move, onComplete, emote);
						return;
					}
					goto IL_0830;
				}
			}
			else if (<Action>k__BackingField != JackarooActions.BURN_OTHER_CARD)
			{
				bool flag25 = <Action>k__BackingField < JackarooActions.BURN_OTHER_CARD_RANDOM;
				object obj3 = !flag25;
				object obj4 = <Action>k__BackingField - 65536;
				bool flag7 = obj4 == null;
				bool flag26 = <Action>k__BackingField != JackarooActions.BURN_OTHER_CARD_RANDOM;
				flag4 = (byte)(int)action != 0;
				highlightedFirstNodes2 = highlightedFirstNodes;
				jackarooMove = move;
				if (flag26)
				{
					goto IL_0830;
				}
			}
		}
		else
		{
			bool flag27 = <Action>k__BackingField < JackarooActions.MOVE_SPLIT_7_0;
			object obj20 = !flag27;
			object obj21 = <Action>k__BackingField - 4096;
			bool flag28 = obj21 == null;
			object obj22 = ~obj20;
			object obj23 = obj22 | flag28;
			if (obj23 != null)
			{
				goto IL_06fd;
			}
			if (<Action>k__BackingField == JackarooActions.SWAP)
			{
				Swap(move, onComplete);
				return;
			}
			bool flag29 = <Action>k__BackingField < JackarooActions.BURN_MY_CARD;
			object obj3 = !flag29;
			object obj4 = <Action>k__BackingField - 16384;
			if (<Action>k__BackingField != JackarooActions.BURN_MY_CARD)
			{
				flag4 = (byte)(int)action != 0;
				highlightedFirstNodes2 = highlightedFirstNodes;
				jackarooMove = move;
				goto IL_0830;
			}
		}
		<IsAnimating>k__BackingField = false;
		if (onComplete != null)
		{
			IntPtr invoke_impl = ((Delegate)onComplete).invoke_impl;
			IntPtr method_code = ((Delegate)onComplete).method_code;
			IntPtr method = ((Delegate)onComplete).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v103 @ X2_v9 (System.IntPtr) (should have been resolved before IL gen)");
			goto IL_06fd;
		}
	}

	private void AddMarblesSnapShot(int[][] serverMarbles)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_021a: Expected O, but got I4
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0098: Expected O, but got I4
		//IL_00ae: Expected O, but got I
		//IL_015c: Expected O, but got I4
		//IL_0165: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0117: Expected O, but got I4
		object obj3 = default(object);
		Array array;
		if (serverMarbles != null)
		{
			object obj = typeof(TypeConverter<ushort, char>) + 1504;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			if (serverMarbles.Length < 1)
			{
				goto IL_01b2;
			}
			object obj2 = serverMarbles + 32;
			if (obj3 != null)
			{
				object obj4 = typeof(TypeConverter<ushort, char>) + 3048;
				object obj5 = obj3 + 32;
				object obj6 = 0;
				object obj8 = default(object);
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X25_v5+v83 @ X26_v7*8]");
					if ((nint)0 == 0)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X25_v5+v83 @ X26_v7*8]");
					object obj7 = ((Array)0).Clone();
					object obj12;
					if (obj7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						if (obj8 == null)
						{
							throw new InvalidCastException();
						}
						object obj9 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v8 (System.Object)+18]");
						bool flag = (nint)obj9 < 0;
						object obj10 = !flag;
						object obj11 = ~obj10;
						obj12 = obj8;
						if (obj11 != null)
						{
							goto IL_0173;
						}
					}
					else
					{
						object obj13 = obj6;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X0_v8 (System.Object)+18]");
						bool flag2 = (nint)obj13 < 0;
						object obj14 = !flag2;
						obj12 = 0;
						if (obj14 == null)
						{
							goto IL_0173;
						}
					}
					throw new IndexOutOfRangeException();
					IL_0173:
					obj6++;
					obj5 = obj12;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					if ((nint)obj6 < serverMarbles.Length)
					{
						continue;
					}
					goto IL_01b2;
				}
			}
			else
			{
				array = (Array)obj2;
				bool flag3 = obj2 == null;
				object obj15 = !flag3;
				if (obj15 != null)
				{
					goto IL_023e;
				}
			}
		}
		goto IL_0228;
		IL_023e:
		object obj16 = array.Clone();
		throw new NullReferenceException();
		IL_0228:
		NullReferenceException ex = new NullReferenceException();
		array = (Array)(object)ex;
		goto IL_023e;
		IL_01b2:
		if (_snapshotQueue != null)
		{
			((Queue<object>)(object)_snapshotQueue).Enqueue(obj3);
			return;
		}
		goto IL_0228;
	}

	private bool CheckAndFixSyncedWithServer(int[][] serverMarbles)
	{
		//IL_0016: Expected O, but got I
		//IL_00a6: Expected O, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_0102: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F81]");
		object obj = (nint)0 & (nint)1;
		bool flag;
		bool result;
		if (obj != null)
		{
			flag = DoCheckWithServer(serverMarbles);
			bool flag2 = !flag;
			int[][] array = serverMarbles;
			result = flag;
			if (!flag2)
			{
				goto IL_006e;
			}
		}
		else
		{
			_ = 1;
			flag = DoCheckWithServer(serverMarbles);
			bool flag3 = !flag;
			object obj2 = !flag3;
			int[][] array = serverMarbles;
			result = flag;
			if (obj2 != null)
			{
				goto IL_006e;
			}
		}
		object obj3 = typeof(RegisteredWaitHandle) + 3136;
		object obj4 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v2+E4]");
		bool flag4 = (nint)0 == 0;
		object obj5 = !flag4;
		if (obj5 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		AsyncOperationHandle<SceneInstance> asyncOperationHandle = ScreenManager.ReloadScene();
		return result;
		IL_006e:
		return flag;
	}

	private bool DoCheckWithServer(int[][] severMarbles)
	{
		//IL_0b3c: Expected I4, but got O
		//IL_003a: Expected O, but got I4
		//IL_0b67: Expected O, but got I
		//IL_009d: Expected O, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e4: Expected O, but got I
		//IL_0e0c: Expected O, but got I4
		//IL_010b: Expected O, but got I
		//IL_0144: Expected O, but got I4
		//IL_017f: Expected O, but got I
		//IL_0187: Expected I, but got O
		//IL_0197: Expected O, but got I
		//IL_0251: Expected O, but got I4
		//IL_025a: Expected O, but got I4
		//IL_01d2: Expected O, but got I
		//IL_09c1: Expected O, but got I4
		//IL_09e3: Expected I, but got O
		//IL_09f3: Expected O, but got I
		//IL_02ee: Expected I, but got O
		//IL_02fe: Expected O, but got I
		//IL_0275: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Expected O, but got Unknown
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected O, but got Unknown
		//IL_0a82: Expected O, but got I4
		//IL_03a5: Expected O, but got I4
		//IL_01e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Expected O, but got Unknown
		//IL_0d82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d87: Expected O, but got Unknown
		//IL_0dca: Expected O, but got I4
		//IL_0a2e: Expected O, but got I
		//IL_0c18: Expected O, but got I
		//IL_0339: Expected O, but got I
		//IL_0c83: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c88: Expected O, but got Unknown
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Expected O, but got Unknown
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_03c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c5: Expected O, but got Unknown
		//IL_0a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a41: Expected O, but got Unknown
		//IL_0a4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4f: Expected O, but got Unknown
		//IL_0808: Unknown result type (might be due to invalid IL or missing references)
		//IL_080d: Expected O, but got Unknown
		//IL_081c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0821: Expected O, but got Unknown
		//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ee: Expected O, but got Unknown
		//IL_034f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0354: Expected O, but got Unknown
		//IL_035d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0362: Expected O, but got Unknown
		//IL_067e: Expected O, but got I
		//IL_068f: Expected O, but got I4
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0424: Expected O, but got Unknown
		//IL_042c: Expected I, but got O
		//IL_043c: Expected O, but got I
		//IL_0cb4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb9: Expected O, but got Unknown
		//IL_0ced: Expected O, but got I4
		//IL_04fe: Expected O, but got I4
		//IL_0477: Expected O, but got I
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d2: Expected O, but got Unknown
		//IL_06e8: Expected O, but got I
		//IL_06f6: Expected I, but got O
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_049b: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_0707: Expected O, but got I
		//IL_0727: Unknown result type (might be due to invalid IL or missing references)
		//IL_072c: Expected O, but got Unknown
		//IL_0747: Expected O, but got I
		//IL_0758: Expected I, but got O
		//IL_0764: Expected O, but got I
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		//IL_05b6: Expected O, but got I
		//IL_05c7: Expected I, but got O
		//IL_05d8: Expected O, but got I
		//IL_05f5: Expected O, but got I
		//IL_0613: Expected O, but got I4
		//IL_0905: Expected O, but got I4
		//IL_0919: Unknown result type (might be due to invalid IL or missing references)
		//IL_091e: Expected O, but got Unknown
		//IL_0943: Unknown result type (might be due to invalid IL or missing references)
		//IL_0948: Expected O, but got Unknown
		//IL_0972: Expected O, but got I4
		//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ad: Expected O, but got Unknown
		//IL_086f: Expected O, but got I4
		//IL_0883: Unknown result type (might be due to invalid IL or missing references)
		//IL_0888: Expected O, but got Unknown
		//IL_08c8: Expected O, but got I4
		if ((object)<Game>k__BackingField != null)
		{
			if (<Game>k__BackingField.IsSpectator)
			{
				object obj = 0;
				goto IL_0b5b;
			}
			if ((object)<Game>k__BackingField != null)
			{
				CardGamePlayer myPlayer = <Game>k__BackingField.MyPlayer;
				if (myPlayer != null)
				{
					object obj = ((KPlayer)myPlayer).<Index>k__BackingField - 1;
					goto IL_0b5b;
				}
			}
		}
		goto IL_0b00;
		IL_0b5b:
		object obj2 = (nint)0 + (nint)2960;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C9A210");
		IEnumerable<object> source = default(IEnumerable<object>);
		object[] array = Enumerable.ToArray(source);
		if (array == null)
		{
			goto IL_0ad2;
		}
		object obj3 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2248;
		object obj4 = array + 32;
		object obj5 = typeof(DataRelation) + 856;
		object obj6 = (nint)0 + (nint)2464;
		int num = 0;
		object[] array2 = array;
		object obj17 = default(object);
		object obj24 = default(object);
		object obj26 = default(object);
		object obj28 = default(object);
		object obj34 = default(object);
		Func<int, bool> func2 = default(Func<int, bool>);
		object obj40 = default(object);
		object obj45 = default(object);
		Func<object, int> func3 = default(Func<object, int>);
		Func<int, bool> func4 = default(Func<int, bool>);
		object obj56 = default(object);
		object obj59 = default(object);
		object obj69 = default(object);
		object obj70 = default(object);
		object obj71 = default(object);
		while (true)
		{
			JackarooBoard jackarooBoard = <Board>k__BackingField;
			if (<Board>k__BackingField == null || jackarooBoard._playersPlantedMarbles == null)
			{
				break;
			}
			object obj7 = (nint)0 + (nint)2968;
			object obj8 = obj7;
			object obj9 = ((List<object>)(object)jackarooBoard._playersPlantedMarbles).get_Item(num);
			bool flag = num < array2.Length;
			object obj10 = !flag;
			if (obj10 == null)
			{
				if (obj9 == null)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v14+v248 @ X25_v5 (System.Int32)*8]");
				IEnumerable<int> enumerable = (IEnumerable<int>)0;
				nint num2 = (nint)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v24 (Il2CppClass<System.Object>)+12E]");
				object obj11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v24 (Il2CppClass<System.Object>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_021b;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v573 @ X8_v24 (Il2CppClass<System.Object>)+B0]");
				object obj12 = (nint)0 + (nint)8;
				object obj13;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X10_v32-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj13 = obj12 + 16;
					obj11--;
					bool flag2 = (nint)obj11 != 1;
					obj12 = obj13;
					if (flag2)
					{
						continue;
					}
					goto IL_021b;
				}
				object obj14 = num2 + obj12;
				object obj15 = obj14 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v611 @ X0_v98] (should have been resolved before IL gen)");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v14+v248 @ X25_v5 (System.Int32)*8]");
				bool flag3 = (nint)0 == 0;
				obj13 = obj12;
				if (flag3)
				{
					break;
				}
				goto IL_02bf;
			}
			goto IL_0ac4;
			IL_08f5:
			object obj16 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "Picking audio files is not supported on iOS" + 440;
			string text = string.Format((string)format, obj17);
			object obj18 = typeof(DataRelation) + 856;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v39+E4]");
			bool flag4 = (nint)0 == 0;
			object obj20 = !flag4;
			object obj21 = null;
			object obj22 = null;
			object obj23 = obj17;
			object message = text;
			if (obj20 == null)
			{
				goto IL_099a;
			}
			goto IL_0d29;
			IL_07eb:
			num++;
			obj5 = typeof(DataRelation) + 856;
			obj3 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2248;
			bool flag5 = num != 4;
			IEnumerable<int> enumerable2;
			obj24 = enumerable2;
			array2 = array;
			if (!flag5)
			{
				return true;
			}
			continue;
			IL_0392:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj8 = 0;
			goto IL_0c08;
			IL_0c08:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X0_v47+8]");
			Func<int, bool> func = (Func<int, bool>)0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v732 @ X0_v47] (should have been resolved before IL gen)");
			object obj25 = obj26;
			bool flag7;
			while (true)
			{
				obj25--;
				if ((nint)obj25 < 1)
				{
					break;
				}
				object obj27 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 432;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj28..ctor();
				JackarooBoard jackarooBoard2 = <Board>k__BackingField;
				object obj29 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2472;
				nint num3 = (nint)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v77 (Il2CppClass<System.Object>)+12E]");
				object obj30 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v77 (Il2CppClass<System.Object>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_04d0;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v912 @ X8_v77 (Il2CppClass<System.Object>)+B0]");
				object obj31 = (nint)0 + (nint)8;
				bool flag6 = flag7;
				object obj13;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X10_v22-8]");
					if (0 == (nint)obj29)
					{
						break;
					}
					obj13 = obj31 + 16;
					obj30--;
					flag7 = (nint)obj30 != 1;
					flag6 = flag7;
					obj31 = obj13;
					if (flag7)
					{
						continue;
					}
					goto IL_04d0;
				}
				object obj32 = num3 + obj31;
				object obj33 = obj32 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1053 @ X0_v88] (should have been resolved before IL gen)");
				bool flag8 = obj34 == null;
				flag7 = flag6;
				obj13 = obj31;
				if (flag8)
				{
					goto end_IL_0cfb;
				}
				goto IL_0563;
				IL_04d0:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v950 @ X0_v85] (should have been resolved before IL gen)");
				bool flag9 = obj34 == null;
				object obj35 = !flag9;
				if (obj35 == null)
				{
					goto end_IL_0cfb;
				}
				goto IL_0563;
				IL_0563:
				if (<Board>k__BackingField == null)
				{
					goto end_IL_0cfb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97238");
				if (obj28 == null)
				{
					goto end_IL_0cfb;
				}
				object obj36 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj37 = (nint)0 + (nint)1704;
				func2..ctor(obj28, (IntPtr)obj37);
				object obj38 = (nint)0 + (nint)2624;
				obj8 = obj38;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v14+v248 @ X25_v5 (System.Int32)*8]");
				bool flag10 = Enumerable.Any((IEnumerable<int>)0, func2);
				bool flag11 = !flag10;
				object obj39 = !flag11;
				obj40 = null;
				obj24 = obj28;
				func = func2;
				if (obj39 != null)
				{
					continue;
				}
				goto IL_085f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X25_v7 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
			bool flag12 = (nint)0 < (nint)1;
			enumerable2 = (IEnumerable<int>)obj24;
			if (flag12)
			{
				goto IL_07eb;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v14+v248 @ X25_v5 (System.Int32)*8]");
			object obj41 = (nint)0 + (nint)32;
			object obj42 = obj40;
			object obj43 = 0;
			while (true)
			{
				object obj44 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 440;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				obj45..ctor();
				object obj46 = obj43;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X25_v7 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
				bool flag13 = (nint)obj46 < 0;
				object obj47 = !flag13;
				if (obj47 != null)
				{
					break;
				}
				if (obj45 == null)
				{
					goto end_IL_0cfb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X21_v18+v236 @ X22_v18*4]");
				_ = 0;
				object obj48 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2080;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj49 = (nint)0 + (nint)360;
				func3..ctor((object)this, (IntPtr)obj49);
				object obj50 = (nint)0 + (nint)3608;
				IEnumerable<int> enumerable3 = Enumerable.Select((IEnumerable<object>)obj9, func3);
				object obj51 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 1832;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj52 = (nint)0 + (nint)1712;
				func4..ctor(obj45, (IntPtr)obj52);
				object obj53 = (nint)0 + (nint)2624;
				obj8 = obj53;
				if (Enumerable.Any(enumerable3, func4))
				{
					obj43++;
					object obj54 = obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X25_v7 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
					bool flag14 = (nint)obj54 < 0;
					obj40 = null;
					enumerable2 = enumerable3;
					obj42 = null;
					func = func4;
					if (flag14)
					{
						continue;
					}
					goto IL_07eb;
				}
				goto IL_08f5;
			}
			goto IL_0ac4;
			IL_099a:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			message = text;
			goto IL_0d29;
			IL_085f:
			object obj55 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format2 = "Picking audio files is not supported on iOS" + 448;
			text = string.Format((string)format2, obj56);
			obj19 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v39+E4]");
			bool flag15 = (nint)0 == 0;
			object obj57 = !flag15;
			message = text;
			if (obj57 == null)
			{
				obj21 = null;
				obj22 = null;
				obj23 = obj56;
				goto IL_099a;
			}
			goto IL_0d29;
			IL_0a6f:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj8 = 0;
			goto IL_0d64;
			IL_021b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v593 @ X0_v95] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X8_v14+v248 @ X25_v5 (System.Int32)*8]");
			bool flag16 = (nint)0 == 0;
			object obj58 = !flag16;
			obj8 = 0;
			if (obj58 == null)
			{
				break;
			}
			goto IL_02bf;
			IL_02bf:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v249 @ X25_v7 (System.Collections.Generic.IEnumerable`1<System.Int32>)+18]");
			flag7 = obj59 != null;
			if (!flag7)
			{
				nint num4 = (nint)obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v40 (Il2CppClass<System.Object>)+12E]");
				object obj60 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v40 (Il2CppClass<System.Object>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0392;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v642 @ X8_v40 (Il2CppClass<System.Object>)+B0]");
				object obj61 = (nint)0 + (nint)8;
				bool flag17 = flag7;
				object obj13;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X10_v27-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					obj13 = obj61 + 16;
					obj60--;
					flag7 = (nint)obj60 != 1;
					flag17 = flag7;
					obj61 = obj13;
					if (flag7)
					{
						continue;
					}
					goto IL_0392;
				}
				object obj62 = num4 + obj61;
				object obj63 = obj62 + 312;
				flag7 = flag17;
				obj13 = obj61;
				goto IL_0c08;
			}
			object obj64 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			nint num5 = (nint)obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v32 (Il2CppClass<System.Object>)+12E]");
			object obj65 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v32 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0a6f;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X8_v32 (Il2CppClass<System.Object>)+B0]");
			object obj66 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v803 @ X10_v13-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj66 += 16;
				obj65--;
				if ((nint)obj65 != 1)
				{
					continue;
				}
				goto IL_0a6f;
			}
			object obj67 = num5 + obj66;
			object obj68 = obj67 + 312;
			goto IL_0d64;
			IL_0d64:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v855 @ X0_v33] (should have been resolved before IL gen)");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format3 = "Material with texture name \"" + 1688;
			text = string.Format((string)format3, obj69, obj70, obj71);
			obj19 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1028 @ X8_v39+E4]");
			bool flag18 = (nint)0 == 0;
			object obj72 = !flag18;
			message = text;
			if (obj72 == null)
			{
				obj21 = obj71;
				obj22 = obj70;
				obj23 = obj69;
				goto IL_099a;
			}
			goto IL_0d29;
			IL_0d29:
			Debug.LogError(message);
			return false;
			continue;
			end_IL_0cfb:
			break;
		}
		goto IL_0b00;
		IL_0ad2:
		JackarooBoard jackarooBoard3 = <Board>k__BackingField;
		List<object> list;
		if (<Board>k__BackingField != null)
		{
			list = (List<object>)(object)jackarooBoard3._playersPlantedMarbles;
			bool flag19 = jackarooBoard3._playersPlantedMarbles == null;
			object obj73 = !flag19;
			if (obj73 != null)
			{
				goto IL_0b16;
			}
		}
		goto IL_0b00;
		IL_0b16:
		object obj74 = list.get_Item(0);
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
		IL_0ac4:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_0ad2;
		IL_0b00:
		NullReferenceException ex3 = new NullReferenceException();
		list = (List<object>)(object)ex3;
		goto IL_0b16;
	}

	private void MoveMarbleToGraveyard(JackarooMarble marble, JackarooNode graveyardNode)
	{
		//IL_0470: Expected I, but got O
		//IL_0478: Expected I4, but got O
		//IL_003e: Expected O, but got I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_00ae: Expected O, but got I
		//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0103: Expected O, but got Unknown
		//IL_0119: Expected O, but got I
		//IL_01e2: Expected O, but got I4
		//IL_0186: Expected O, but got I4
		//IL_0295: Unknown result type (might be due to invalid IL or missing references)
		//IL_029a: Expected O, but got Unknown
		//IL_02a6: Expected O, but got I
		//IL_02b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ba: Expected O, but got Unknown
		//IL_02cc: Expected I, but got O
		//IL_02da: Expected I, but got O
		//IL_02fd: Expected I, but got O
		//IL_03a9: Expected I, but got O
		//IL_0347: Expected I, but got O
		//IL_0375: Expected I, but got O
		//IL_03c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03cd: Expected O, but got Unknown
		//IL_0415: Expected O, but got I4
		AudioClip[] breakClips = _breakClips;
		bool flag = _breakClips == null;
		nint num = (nint)graveyardNode;
		int num2 = (int)marble;
		RemoteConfigModel current;
		if (!flag)
		{
			num2 = breakClips.Length;
			int num3 = UnityEngine.Random.Range(0, breakClips.Length);
			bool flag2 = num3 < breakClips.Length;
			object obj = !flag2;
			num = 0;
			if (obj != null)
			{
				goto IL_0429;
			}
			object obj2 = _breakClips + num3;
			GameSoundManager instance = GameSoundManager.Instance;
			bool flag3 = (object)instance == null;
			num = 0;
			if (!flag3)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v7+20]");
				instance.PlaySound((AudioClip)0, _volume);
				<IsMovingToGraveyard>k__BackingField = true;
				bool flag4 = graveyardNode == null;
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v7+20]");
				num2 = 0;
				if (!flag4)
				{
					object obj3 = typeof(RegisteredWaitHandle) + 56;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F84]");
					object obj4 = (nint)0 & (nint)1;
					if (obj4 != null)
					{
						object obj5 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v25+E4]");
						if ((nint)0 != 0)
						{
							goto IL_0163;
						}
					}
					else
					{
						_ = 1;
						object obj5 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v272 @ X0_v25+E4]");
						bool flag5 = (nint)0 == 0;
						object obj6 = !flag5;
						if (obj6 != null)
						{
							goto IL_0163;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					current = RemoteConfig.Current;
					bool flag6 = current == null;
					num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v7+20]");
					num2 = 0;
					if (!flag6)
					{
						goto IL_023e;
					}
				}
			}
		}
		goto IL_041b;
		IL_041b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0429;
		IL_0437:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0163:
		current = RemoteConfig.Current;
		bool flag7 = current == null;
		object obj7 = !flag7;
		if (obj7 != null)
		{
			goto IL_023e;
		}
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v7+20]");
		num2 = 0;
		goto IL_041b;
		IL_023e:
		JackarooConfig <Jackaroo>k__BackingField = current.<Jackaroo>k__BackingField;
		bool flag8 = current.<Jackaroo>k__BackingField == null;
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v7+20]");
		num2 = 0;
		IndexOutOfRangeException ex2 = default(IndexOutOfRangeException);
		if (!flag8)
		{
			object obj8 = typeof(SqlSingle[]) + 2376;
			object obj9 = (nint)0 + (nint)368;
			object obj10 = typeof(TypeConverter<ushort, char>) + 3128;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			num = (nint)obj9;
			Action action = default(Action);
			action..ctor(this, (IntPtr)obj9);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			JackarooNodeMono[] array = default(JackarooNodeMono[]);
			bool flag9 = array == null;
			nint num4 = unchecked((nint)null);
			num2 = 1;
			if (!flag9)
			{
				bool flag10 = (object)graveyardNode.<NodeMono>k__BackingField == null;
				int num5 = 1;
				if (!flag10)
				{
					nint num6 = (nint)array;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v14 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
					num5 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					bool flag11 = ex2 == null;
					num4 = unchecked((nint)null);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v14 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
					num2 = 0;
					if (flag11)
					{
						goto IL_0437;
					}
				}
				bool flag12 = array.Length == 0;
				num4 = unchecked((nint)null);
				num2 = num5;
				if (!flag12)
				{
					object obj11 = array + 32;
					obj11 = graveyardNode.<NodeMono>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					MoveMarble(marble, <Jackaroo>k__BackingField.<MinMarbleMoveDuration>k__BackingField, _moveClips, action, null, 0, isPlant: false, (GameAction?)(object)0, array);
					return;
				}
				goto IL_0429;
			}
		}
		goto IL_041b;
		IL_0429:
		ex2 = new IndexOutOfRangeException();
		goto IL_0437;
	}

	public bool IsMe(int playerIndex)
	{
		//IL_00f8: Expected I4, but got O
		//IL_00d6: Expected O, but got I4
		int playerIndex2;
		if ((object)<Game>k__BackingField != null)
		{
			if (<Game>k__BackingField.IsSpectator)
			{
				playerIndex2 = 1;
				goto IL_00f8;
			}
			if ((object)<Game>k__BackingField != null)
			{
				CardGamePlayer myPlayer = <Game>k__BackingField.MyPlayer;
				if (myPlayer != null)
				{
					playerIndex2 = ((KPlayer)myPlayer).<Index>k__BackingField;
					goto IL_00f8;
				}
			}
		}
		goto IL_00ea;
		IL_00f8:
		if ((object)<Game>k__BackingField != null)
		{
			int rotatedPlayerIndex = <Game>k__BackingField.GetRotatedPlayerIndex(playerIndex2);
			object obj = rotatedPlayerIndex - playerIndex;
			return obj == null;
		}
		goto IL_00ea;
		IL_00ea:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}

	public bool IsMyTeam(int rotatedPlayerIndex)
	{
		//IL_0012: Expected I4, but got I8
		//IL_0020: Expected O, but got I4
		int num = (int)(rotatedPlayerIndex & 0xFFFFFFFDL);
		object obj = num - 1;
		return obj == null;
	}

	public bool IsOpponent(int rotatedPlayerIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_004d: Expected O, but got I4
		object obj = rotatedPlayerIndex - 2;
		bool flag = obj == null;
		object obj2 = !flag;
		object obj3 = ~obj2;
		if (obj3 == null)
		{
			object obj4 = rotatedPlayerIndex - 4;
			return obj4 == null;
		}
		return true;
	}

	private static int GetTeamMateIndex(int rotatedPlayerIndex)
	{
		//IL_000e: Expected O, but got I4
		//IL_0028: Expected O, but got I4
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0045: Expected O, but got I4
		//IL_00aa: Expected O, but got I
		//IL_00c7: Expected I4, but got O
		object obj = rotatedPlayerIndex - 1;
		bool flag = (nint)obj < 4;
		object obj2 = !flag;
		if (obj2 == null)
		{
			object obj3 = 119877632 + 704;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X9_v2+v12 @ X8_v1*4]");
			return 0;
		}
		int num = default(int);
		string message = num.ToString();
		object obj4 = typeof(System.IOAsyncCallback) + 2632;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		ex..ctor(message);
		object obj5 = (nint)0 + (nint)400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
		OutOfMemoryException ex2 = new OutOfMemoryException();
		return (int)ex2;
	}

	private int GetPlayerRotatedIndex(int index)
	{
		//IL_0045: Expected I4, but got O
		if ((object)<Game>k__BackingField != null)
		{
			return <Game>k__BackingField.GetRotatedPlayerIndex(index);
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	public List<JackarooMove> GetAllowedJackarooMoves(ref List<JackarooMove> allowedJackarooMoves, IReadOnlyCollection<Card> cards, JackarooLastActionInfo lastAction)
	{
		//IL_0016: Expected O, but got I
		//IL_00e0: Expected O, but got I4
		//IL_0068: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_0124: Expected O, but got I4
		//IL_00ab: Expected O, but got I4
		//IL_017c: Expected O, but got I
		//IL_01fa: Expected O, but got I8
		//IL_025f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0264: Expected O, but got Unknown
		//IL_0270: Expected O, but got I
		//IL_0385: Expected I, but got O
		//IL_02d0: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F86]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (<Initialized>k__BackingField)
			{
				goto IL_0052;
			}
		}
		else
		{
			_ = 1;
			bool flag = !<Initialized>k__BackingField;
			object obj2 = !flag;
			if (obj2 != null)
			{
				goto IL_0052;
			}
		}
		Initialize();
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F92]");
		object obj3 = (nint)0 & (nint)1;
		bool flag2 = obj3 == null;
		object obj4 = !flag2;
		if (obj4 != null)
		{
			goto IL_0085;
		}
		goto IL_0132;
		IL_0340:
		return (List<JackarooMove>)(object)new IndexOutOfRangeException();
		IL_0332:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0340;
		IL_036d:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object, object> action = default(Action<object, object>);
		object obj5;
		action..ctor((object)this, (IntPtr)obj5);
		JackarooPlayer jackarooPlayer;
		object lastPlayedCard;
		if (<Board>k__BackingField != null)
		{
			return <Board>k__BackingField.GetAllowedJackarooMoves(ref allowedJackarooMoves, cards, lastAction, ((CardGamePlayer)jackarooPlayer).<Cards>k__BackingField, (Card)lastPlayedCard, action);
		}
		goto IL_0332;
		IL_0052:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F92]");
		object obj6 = (nint)0 & (nint)1;
		if (obj6 != null)
		{
			goto IL_0085;
		}
		goto IL_0132;
		IL_0132:
		_ = 1;
		Dictionary<object, object> guardedMarblesDictionary = (Dictionary<object, object>)(object)_guardedMarblesDictionary;
		if (_guardedMarblesDictionary != null)
		{
			goto IL_0161;
		}
		goto IL_0332;
		IL_0085:
		guardedMarblesDictionary = (Dictionary<object, object>)(object)_guardedMarblesDictionary;
		bool flag3 = _guardedMarblesDictionary == null;
		object obj7 = !flag3;
		if (obj7 != null)
		{
			goto IL_0161;
		}
		goto IL_0332;
		IL_0161:
		guardedMarblesDictionary.Clear();
		if (_pooledGuardedMarbles != null)
		{
			object obj8 = (nint)0 + (nint)3768;
			object obj9 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C3728");
			JackarooGame jackarooGame = <Game>k__BackingField;
			if ((object)<Game>k__BackingField != null)
			{
				JackarooPlayer[] <JackarooPlayers>k__BackingField = jackarooGame.<JackarooPlayers>k__BackingField;
				if (jackarooGame.<JackarooPlayers>k__BackingField != null)
				{
					object obj10 = <JackarooPlayers>k__BackingField.Length & 0xFFFFFFFEL;
					if (obj10 == null)
					{
						goto IL_0340;
					}
					jackarooPlayer = <JackarooPlayers>k__BackingField[1];
					if (<JackarooPlayers>k__BackingField[1] != null)
					{
						object obj11 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 296;
						obj5 = (nint)0 + (nint)376;
						IEnumerable<object> <OrderedPlayedCards>k__BackingField = ((CardGame)jackarooGame).<OrderedPlayedCards>k__BackingField;
						if (((CardGame)jackarooGame).<OrderedPlayedCards>k__BackingField != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v269 @ X0_v8 (System.Collections.Generic.IEnumerable`1<System.Object>)+18]");
							if ((nint)0 >= (nint)1)
							{
								object obj12 = (nint)0 + (nint)1624;
								obj9 = obj12;
								object obj13 = Enumerable.Last((IEnumerable<object>)((CardGame)jackarooGame).<OrderedPlayedCards>k__BackingField);
								lastPlayedCard = obj13;
								goto IL_036d;
							}
						}
						lastPlayedCard = null;
						goto IL_036d;
					}
				}
			}
		}
		goto IL_0332;
	}

	private void SetTurnIndicator(int playerIndex)
	{
		//IL_0039: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		int rotatedPlayerIndex = <Game>k__BackingField.GetRotatedPlayerIndex(playerIndex);
		JackarooThemeData jackarooThemeData = _runtimeTheme;
		bool flag = _runtimeTheme == null;
		object obj = !flag;
		if (obj == null)
		{
			JackarooTheme defaultTheme = _defaultTheme;
			jackarooThemeData = defaultTheme.<ThemeData>k__BackingField;
		}
		Color playerColor = jackarooThemeData.GetPlayerColor(playerIndex);
		_turnIndicator.SetTurn(rotatedPlayerIndex, (Color)0);
	}

	private static JackarooNodeMono InitializeJackarooNodeMono(JackarooNodeMono nodePrefab, Vector3 position, Quaternion rotation, Transform parent, Vector3 verticalOffset, Vector3 horizontalOffset, string nodeName)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0125: Expected O, but got I
		//IL_014f: Expected O, but got I4
		//IL_0085: Expected O, but got I
		//IL_009f: Expected O, but got I4
		//IL_009f: Expected O, but got I
		//IL_00da: Expected O, but got I
		//IL_00f4: Expected O, but got I4
		//IL_00f4: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = (nint)0 + (nint)1104;
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X0_v2+E4]");
		bool flag = (nint)0 == 0;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EEA1BC");
		UnityEngine.Object obj5 = default(UnityEngine.Object);
		if ((object)obj5 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5 (UnityEngine.Object)+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5 (UnityEngine.Object)+20]");
				Vector3 localPosition = ((Transform)0).localPosition;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5 (UnityEngine.Object)+20]");
				((Transform)0).localPosition = (Vector3)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5 (UnityEngine.Object)+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5 (UnityEngine.Object)+20]");
					Vector3 localPosition2 = ((Transform)0).localPosition;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v5 (UnityEngine.Object)+20]");
					((Transform)0).localPosition = (Vector3)0;
					obj5.name = (string)rotation;
					return (JackarooNodeMono)obj5;
				}
			}
		}
		return (JackarooNodeMono)(object)new NullReferenceException();
	}

	private unsafe static void InitializeRing(List<JackarooNode> boardNodes, JackarooNodeMono nodePrefab, Transform firstNodeTransform, float verticalOffset, float horizontalOffset, RectTransform nodesParent)
	{
		//IL_0008: Expected O, but got Ref
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected I4, but got Unknown
		//IL_05ea: Expected O, but got I4
		//IL_05fe: Expected O, but got Ref
		//IL_0612: Unknown result type (might be due to invalid IL or missing references)
		//IL_0617: Expected O, but got Unknown
		//IL_0621: Unknown result type (might be due to invalid IL or missing references)
		//IL_0626: Expected O, but got Unknown
		//IL_0659: Expected O, but got I
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a6: Expected O, but got Unknown
		//IL_066e: Expected O, but got I
		//IL_0767: Expected O, but got Ref
		//IL_077e: Expected O, but got I4
		//IL_0779: Expected native int or pointer, but got O
		//IL_07c2: Expected O, but got Ref
		//IL_07d9: Expected O, but got I4
		//IL_07d4: Expected native int or pointer, but got O
		//IL_0804: Expected O, but got Ref
		//IL_081b: Expected O, but got I4
		//IL_0816: Expected native int or pointer, but got O
		//IL_083d: Expected O, but got I4
		//IL_0853: Expected O, but got I
		//IL_0873: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected O, but got Unknown
		//IL_089d: Expected O, but got I4
		//IL_0153: Expected O, but got Ref
		//IL_08b9: Expected O, but got I4
		//IL_08db: Expected O, but got I4
		//IL_08f1: Expected O, but got I
		//IL_0911: Unknown result type (might be due to invalid IL or missing references)
		//IL_0916: Expected O, but got Unknown
		//IL_0179: Expected O, but got Ref
		//IL_093b: Expected O, but got I4
		//IL_095d: Expected O, but got I4
		//IL_0973: Expected O, but got I
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_019f: Expected O, but got Ref
		//IL_09bd: Expected O, but got I4
		//IL_09df: Expected O, but got I4
		//IL_09f5: Expected O, but got I
		//IL_0a15: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1a: Expected O, but got Unknown
		//IL_01c5: Expected O, but got Ref
		//IL_0a3f: Expected O, but got I4
		//IL_01eb: Expected O, but got Ref
		//IL_0a5b: Expected O, but got I4
		//IL_0a7d: Expected O, but got I4
		//IL_0a93: Expected O, but got I
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Expected O, but got Unknown
		//IL_0211: Expected O, but got Ref
		//IL_0add: Expected O, but got I4
		//IL_0aff: Expected O, but got I4
		//IL_0b15: Expected O, but got I
		//IL_0b35: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3a: Expected O, but got Unknown
		//IL_0238: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0245: Expected O, but got Ref
		//IL_0261: Expected O, but got I
		//IL_0b5f: Expected O, but got I4
		//IL_0b81: Expected O, but got I4
		//IL_0b97: Expected O, but got I
		//IL_0bb7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bbc: Expected O, but got Unknown
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_0275: Expected O, but got Unknown
		//IL_0be1: Expected O, but got I4
		//IL_0c03: Expected O, but got I4
		//IL_0c19: Expected O, but got I
		//IL_0c39: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c3e: Expected O, but got Unknown
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_0c63: Expected O, but got I4
		//IL_0c85: Expected O, but got I4
		//IL_0c9b: Expected O, but got I
		//IL_0cbb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc0: Expected O, but got Unknown
		//IL_0ce5: Expected O, but got I4
		//IL_0d07: Expected O, but got I4
		//IL_0d1d: Expected O, but got I
		//IL_0d3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d42: Expected O, but got Unknown
		//IL_02d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Expected O, but got Unknown
		//IL_0d5c: Expected O, but got I
		//IL_0d73: Expected O, but got I4
		//IL_0d95: Expected O, but got I4
		//IL_0dab: Expected O, but got I
		//IL_0dcb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd0: Expected O, but got Unknown
		//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f9: Expected O, but got Unknown
		//IL_06e0: Expected O, but got I
		//IL_06f2: Expected O, but got I
		//IL_0e42: Expected O, but got I4
		//IL_0314: Unknown result type (might be due to invalid IL or missing references)
		//IL_0319: Expected O, but got Unknown
		//IL_0336: Expected O, but got I
		//IL_0364: Unknown result type (might be due to invalid IL or missing references)
		//IL_0369: Expected O, but got Unknown
		//IL_0382: Expected O, but got I4
		//IL_0393: Expected O, but got I4
		//IL_03fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0402: Expected O, but got Unknown
		//IL_0700: Unknown result type (might be due to invalid IL or missing references)
		//IL_0705: Expected O, but got Unknown
		//IL_0444: Expected F4, but got I
		//IL_045c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0461: Expected I4, but got Unknown
		//IL_0488: Expected O, but got Ref
		//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a6: Expected O, but got Unknown
		//IL_04b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b5: Expected O, but got Unknown
		//IL_04e8: Expected O, but got I
		//IL_0543: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_0588: Expected O, but got I4
		//IL_03a9: Expected O, but got I
		//IL_03d7: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		if ((object)firstNodeTransform != null)
		{
			Vector3 position = firstNodeTransform.position;
			Quaternion rotation = firstNodeTransform.rotation;
			int num = typeof(UsageHint) + 816;
			object obj3 = 153100288 + 1024;
			_ = 0;
			object obj4 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 156));
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format = "{0} color encoding is currently unsupported for outputting to HDR." + 1400;
			object arg = "Network Authentication Required" + 1408;
			object arg2 = default(object);
			string rotation2 = string.Format((string)format, arg, arg2);
			IntPtr intPtr = default(IntPtr);
			Vector3 horizontalOffset2 = default(Vector3);
			string nodeName = default(string);
			JackarooNodeMono jackarooNodeMono = InitializeJackarooNodeMono(nodePrefab, (Vector3)nodesParent, (Quaternion)rotation2, null, (Vector3)(nint)intPtr, horizontalOffset2, nodeName);
			if (boardNodes != null)
			{
				object obj5 = ((List<object>)(object)boardNodes).get_Item(0);
				if (obj5 != null)
				{
					object obj6 = typeof(TypeConverter<ushort, char>) + 1440;
					((JackarooNode)obj5).SetNodeMono(jackarooNodeMono);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					object item = (nint)0 + (nint)40;
					_ = 0;
					_ = 0;
					_ = 0;
					_ = 0;
					(int, Vector3, Vector3) tuple = ((int, Vector3, Vector3))System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 184));
					*((int, Vector3, Vector3)*)(nint)tuple = (5, (Vector3)item, (Vector3)0);
					object obj7 = default(object);
					if (obj7 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1-A0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1-A8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1-B8]");
						_ = 0;
						_ = 0;
						_ = 0;
						_ = 0;
						_ = 0;
						(int, Vector3, Vector3) tuple2 = ((int, Vector3, Vector3))System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 216));
						*((int, Vector3, Vector3)*)(nint)tuple2 = (5, (Vector3)item, (Vector3)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1-C0]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1-C8]");
						_ = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1-D8]");
						_ = 0;
						float num2 = 0f - horizontalOffset;
						_ = 0;
						_ = 0;
						_ = 0;
						_ = 0;
						(int, Vector3, Vector3) tuple3 = ((int, Vector3, Vector3))System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 248));
						*((int, Vector3, Vector3)*)(nint)tuple3 = (5, (Vector3)item, (Vector3)0);
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
						bool flag = (nint)0 < (nint)2;
						object obj8 = !flag;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
						object obj9 = -2;
						bool flag2 = obj9 == null;
						object obj10 = ~obj8;
						object obj11 = obj10 | flag2;
						if (obj11 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1-E0]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1-E8]");
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X29_v1-F8]");
							_ = 0;
							(int, Vector3, Vector3) tuple4 = (4, (Vector3)item, (Vector3)0);
							object obj13 = default(object);
							object obj12 = (object)(&obj13);
							_ = 0;
							_ = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1244 @ X8_v44+FF]");
							_ = 0;
							(int, Vector3, Vector3) tuple5 = (5, (Vector3)item, (Vector3)0);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
							bool flag3 = (nint)0 < (nint)4;
							object obj14 = !flag3;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
							object obj15 = -4;
							bool flag4 = obj15 == null;
							object obj16 = ~obj14;
							object obj17 = obj16 | flag4;
							if (obj17 == null)
							{
								object obj19 = default(object);
								object obj18 = (object)(&obj19);
								_ = 0;
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1278 @ X8_v52+FF]");
								_ = 0;
								(int, Vector3, Vector3) tuple6 = (5, (Vector3)item, (Vector3)0);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
								bool flag5 = (nint)0 < (nint)5;
								object obj20 = !flag5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
								object obj21 = -5;
								bool flag6 = obj21 == null;
								object obj22 = ~obj20;
								object obj23 = obj22 | flag6;
								if (obj23 == null)
								{
									object obj25 = default(object);
									object obj24 = (object)(&obj25);
									_ = 0;
									_ = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1321 @ X8_v63+FF]");
									_ = 0;
									(int, Vector3, Vector3) tuple7 = (5, (Vector3)item, (Vector3)0);
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
									bool flag7 = (nint)0 < (nint)6;
									object obj26 = !flag7;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
									object obj27 = -6;
									bool flag8 = obj27 == null;
									object obj28 = ~obj26;
									object obj29 = obj28 | flag8;
									if (obj29 == null)
									{
										object obj31 = default(object);
										object obj30 = (object)(&obj31);
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1355 @ X8_v72+FF]");
										_ = 0;
										(int, Vector3, Vector3) tuple8 = (4, (Vector3)item, (Vector3)0);
										object obj33 = default(object);
										object obj32 = (object)(&obj33);
										_ = 0;
										_ = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1388 @ X8_v80+FF]");
										_ = 0;
										(int, Vector3, Vector3) tuple9 = (5, (Vector3)item, (Vector3)0);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
										bool flag9 = (nint)0 < (nint)8;
										object obj34 = !flag9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
										object obj35 = -8;
										bool flag10 = obj35 == null;
										object obj36 = ~obj34;
										object obj37 = obj36 | flag10;
										if (obj37 == null)
										{
											object obj39 = default(object);
											object obj38 = (object)(&obj39);
											_ = 0;
											_ = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1425 @ X8_v89+FF]");
											_ = 0;
											(int, Vector3, Vector3) tuple10 = (5, (Vector3)item, (Vector3)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
											bool flag11 = (nint)0 < (nint)9;
											object obj40 = !flag11;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
											object obj41 = -9;
											bool flag12 = obj41 == null;
											object obj42 = ~obj40;
											object obj43 = obj42 | flag12;
											if (obj43 == null)
											{
												object obj44 = obj7 + 284;
												object obj46 = default(object);
												object obj45 = (object)(&obj46);
												_ = 0;
												_ = 0;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1470 @ X9_v44+FF]");
												obj44 = 0;
												(int, Vector3, Vector3) tuple11 = (5, (Vector3)item, (Vector3)0);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
												bool flag13 = (nint)0 < (nint)10;
												object obj47 = !flag13;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
												object obj48 = -10;
												bool flag14 = obj48 == null;
												object obj49 = ~obj47;
												object obj50 = obj49 | flag14;
												if (obj50 == null)
												{
													object obj51 = obj7 + 312;
													_ = 0;
													_ = 0;
													obj51 = tuple11;
													(int, Vector3, Vector3) tuple12 = (4, (Vector3)item, (Vector3)0);
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
													bool flag15 = (nint)0 < (nint)11;
													object obj52 = !flag15;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
													object obj53 = -11;
													bool flag16 = obj53 == null;
													object obj54 = ~obj52;
													object obj55 = obj54 | flag16;
													if (obj55 == null)
													{
														object obj56 = obj7 + 340;
														_ = 0;
														_ = 0;
														obj56 = tuple12;
														(int, Vector3, Vector3) tuple13 = (5, (Vector3)item, (Vector3)0);
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
														bool flag17 = (nint)0 < (nint)12;
														object obj57 = !flag17;
														Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
														object obj58 = -12;
														bool flag18 = obj58 == null;
														object obj59 = ~obj57;
														object obj60 = obj59 | flag18;
														if (obj60 == null)
														{
															_ = 0;
															_ = 0;
															(int, Vector3, Vector3) tuple14 = (5, (Vector3)item, (Vector3)0);
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
															bool flag19 = (nint)0 < (nint)13;
															object obj61 = !flag19;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
															object obj62 = -13;
															bool flag20 = obj62 == null;
															object obj63 = ~obj61;
															object obj64 = obj63 | flag20;
															if (obj64 == null)
															{
																object obj65 = obj7 + 396;
																obj65 = tuple14;
																object obj66 = (nint)0 + (nint)40;
																(int, Vector3, Vector3) tuple15 = (5, (Vector3)obj66, (Vector3)0);
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
																bool flag21 = (nint)0 < (nint)14;
																object obj67 = !flag21;
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
																object obj68 = -14;
																bool flag22 = obj68 == null;
																object obj69 = ~obj67;
																object obj70 = obj69 | flag22;
																if (obj70 == null)
																{
																	object obj71 = obj7 + 424;
																	obj71 = tuple15;
																	int value = ((int*)num)->m_value;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1657 @ X8_v138 (System.Int32)+B8]");
																	object obj72 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X8_v140+8]");
																	object obj73 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X8_v140+3C]");
																	float num3 = 0f * num2;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X8_v140+40]");
																	float num4 = 0f * num2;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1665 @ X8_v140+44]");
																	float num5 = 0f * num2;
																	Vector3 vector = (Vector3)obj66;
																	(int, Vector3, Vector3) tuple16 = (3, (Vector3)obj66, (Vector3)0);
																	object obj74 = obj7 + 452;
																	obj74 = tuple16;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
																	object obj75 = 0;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
																	if ((nint)0 < (nint)1)
																	{
																		return;
																	}
																	object obj76 = obj7 + 32;
																	object obj78 = default(object);
																	object obj77 = obj78;
																	Transform transform = null;
																	object obj79 = 0;
																	JackarooNodeMono jackarooNodeMono2 = jackarooNodeMono;
																	object obj80 = 0;
																	object arg4 = default(object);
																	float num6 = default(float);
																	while (true)
																	{
																		object obj81 = obj80 * 28;
																		object obj82 = obj76 + obj81;
																		object obj83 = obj82;
																		JackarooNodeMono jackarooNodeMono3;
																		if ((nint)obj82 >= 1)
																		{
																			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X10_v11+14]");
																			num2 = 0f;
																			obj66 = obj79 + obj82;
																			num = obj79 + 1;
																			while ((object)jackarooNodeMono2 != null)
																			{
																				Vector3 position2 = jackarooNodeMono2.Position;
																				object obj84 = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 184));
																				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
																				object format2 = "{0} color encoding is currently unsupported for outputting to HDR." + 1400;
																				object arg3 = "Network Authentication Required" + 1408;
																				string rotation3 = string.Format((string)format2, arg3, arg4);
																				jackarooNodeMono3 = InitializeJackarooNodeMono(nodePrefab, (Vector3)nodesParent, (Quaternion)rotation3, null, (Vector3)(nint)intPtr, horizontalOffset2, nodeName);
																				object obj85 = ((List<object>)(object)boardNodes).get_Item(num);
																				if (obj85 == null)
																				{
																					break;
																				}
																				((JackarooNode)obj85).SetNodeMono(jackarooNodeMono3);
																				num++;
																				obj83--;
																				bool flag23 = (nint)obj83 != 1;
																				num5 = num6;
																				obj77 = obj78;
																				num3 = verticalOffset;
																				num4 = horizontalOffset;
																				transform = null;
																				vector = (Vector3)0;
																				jackarooNodeMono2 = jackarooNodeMono3;
																				if (flag23)
																				{
																					continue;
																				}
																				goto IL_0399;
																			}
																			break;
																		}
																		goto IL_06f7;
																		IL_0399:
																		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1111 @ X0_v20+18]");
																		obj75 = 0;
																		num5 = num6;
																		obj77 = obj78;
																		num3 = verticalOffset;
																		num4 = horizontalOffset;
																		transform = null;
																		vector = (Vector3)0;
																		obj73 = obj73;
																		obj79 = obj66;
																		jackarooNodeMono2 = jackarooNodeMono3;
																		goto IL_06f7;
																		IL_06f7:
																		obj80++;
																		if (obj80 >= obj75)
																		{
																			return;
																		}
																	}
																	goto IL_05a4;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
						goto IL_05b2;
					}
				}
			}
		}
		goto IL_05a4;
		IL_05b2:
		throw new IndexOutOfRangeException();
		IL_05a4:
		NullReferenceException ex = new NullReferenceException();
		goto IL_05b2;
	}

	private void InitializeBases(JackarooNodeMono nodePrefab, IReadOnlyList<JackarooNode> ringNodes, float baseVerticalOffset, float baseHorizontalOffset)
	{
		//IL_0477: Expected O, but got I4
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_0028: Expected O, but got I4
		//IL_0050: Expected O, but got I8
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected I4, but got Unknown
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0096: Expected I, but got O
		//IL_00a6: Expected O, but got I
		//IL_0158: Expected O, but got I4
		//IL_01af: Expected O, but got I
		//IL_00e1: Expected O, but got I
		//IL_01d7: Expected O, but got I
		//IL_01ec: Expected O, but got I
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		//IL_0179: Expected O, but got Unknown
		//IL_0182: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Expected O, but got Unknown
		//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f4: Expected O, but got Unknown
		//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0507: Expected O, but got I
		//IL_053d: Expected O, but got I4
		//IL_0563: Expected O, but got I
		//IL_059b: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a0: Expected O, but got Unknown
		//IL_05cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d2: Expected O, but got Unknown
		//IL_0281: Expected O, but got I4
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02a6: Expected I, but got O
		//IL_02b6: Expected O, but got I
		//IL_0368: Expected O, but got I4
		//IL_03fe: Expected O, but got I4
		//IL_02f1: Expected O, but got I
		//IL_0383: Unknown result type (might be due to invalid IL or missing references)
		//IL_0388: Expected O, but got Unknown
		//IL_0391: Unknown result type (might be due to invalid IL or missing references)
		//IL_0396: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0304: Expected O, but got Unknown
		//IL_030d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0312: Expected O, but got Unknown
		if (ringNodes != null)
		{
			object obj = typeof(UsageHint) + 816;
			object obj2 = 153100288 + 1024;
			int num = 1;
			IReadOnlyList<JackarooNode> readOnlyList = ringNodes;
			object obj10 = default(object);
			float num5 = default(float);
			object arg = default(object);
			object arg2 = default(object);
			Vector3 horizontalOffset = default(Vector3);
			string nodeName = default(string);
			JackarooNode jackarooNode = default(JackarooNode);
			float num10 = default(float);
			object obj27 = default(object);
			float num12 = default(float);
			while (true)
			{
				object obj3 = num * 4294967277L;
				int step = 19 + obj3;
				int rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(74, step, 0, 75);
				object obj4 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
				nint num2 = (nint)readOnlyList;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v11 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v11 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_012a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v487 @ X8_v11 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
				object obj6 = (nint)0 + (nint)8;
				object obj7;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X10_v15-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj7 = obj6 + 16;
					obj5--;
					bool flag = (nint)obj5 != 1;
					obj6 = obj7;
					if (flag)
					{
						continue;
					}
					goto IL_012a;
				}
				object obj8 = num2 + obj6;
				object obj9 = obj8 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v604 @ X0_v51] (should have been resolved before IL gen)");
				obj7 = obj6;
				goto IL_019f;
				IL_012a:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v505 @ X0_v48] (should have been resolved before IL gen)");
				bool flag2 = obj10 == null;
				object obj11 = !flag2;
				if (obj11 == null)
				{
					break;
				}
				goto IL_019f;
				IL_019f:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X0_v11+18]");
				object obj12 = 0;
				(int, int) playerOffset = GetPlayerOffset(num);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v13+20]");
				Vector3 position = ((Transform)0).position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X8_v13+20]");
				Quaternion rotation = ((Transform)0).rotation;
				JackarooBoard jackarooBoard = <Board>k__BackingField;
				object obj13 = (object)playerOffset >> 32;
				int num3 = 5 - num;
				int index = ((num != 1) ? num3 : 0);
				object obj14 = (nint)0 + (nint)3000;
				object obj15 = obj14;
				object obj16 = ((List<object>)(object)jackarooBoard._basesNodes).get_Item(index);
				float num4 = num5 * (float)obj13;
				object obj17 = 0;
				int num6 = 75;
				float num9;
				float num11;
				object obj26;
				while (true)
				{
					object obj18 = obj;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v700 @ X8_v25+B8]");
					object obj19 = 0;
					object obj20 = obj17 + 1;
					float num7 = num4 * (float)obj20;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
					object format = "Picking audio files is not supported on iOS" + 2888;
					string rotation2 = string.Format((string)format, arg, arg2);
					JackarooNodeMono nodeMono = InitializeJackarooNodeMono(nodePrefab, (Vector3)_nodesParent, (Quaternion)rotation2, null, (Vector3)0, horizontalOffset, nodeName);
					object obj21 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
					nint num8 = (nint)obj16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v32 (Il2CppClass<System.Object>)+12E]");
					object obj22 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v32 (Il2CppClass<System.Object>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_033a;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v32 (Il2CppClass<System.Object>)+B0]");
					object obj23 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X10_v10-8]");
						if (0 == (nint)obj21)
						{
							break;
						}
						obj7 = obj23 + 16;
						obj22--;
						bool flag3 = (nint)obj22 != 1;
						obj23 = obj7;
						if (flag3)
						{
							continue;
						}
						goto IL_033a;
					}
					object obj24 = num8 + obj23;
					object obj25 = obj24 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v770 @ X0_v37] (should have been resolved before IL gen)");
					obj7 = obj23;
					goto IL_03ad;
					IL_03ad:
					jackarooNode.SetNodeMono(nodeMono);
					bool flag4 = (nint)obj20 != 4;
					num9 = num10;
					num11 = num5;
					obj26 = obj27;
					obj17 = obj20;
					num6 = 0;
					obj15 = 0;
					if (!flag4)
					{
						goto IL_040c;
					}
					continue;
					IL_033a:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v754 @ X0_v34] (should have been resolved before IL gen)");
					bool flag5 = jackarooNode == null;
					object obj28 = !flag5;
					if (obj28 == null)
					{
						break;
					}
					goto IL_03ad;
				}
				break;
				IL_040c:
				num++;
				bool flag6 = num != 5;
				num9 = num12;
				num11 = num5;
				obj26 = obj27;
				readOnlyList = ringNodes;
				if (!flag6)
				{
					return;
				}
			}
		}
		else
		{
			bool flag7 = <Board>k__BackingField == null;
			object obj29 = !flag7;
			if (obj29 != null)
			{
				int rotatedNextIndex2 = IntegerExtensions.GetRotatedNextIndex(74, 0, 0, 75);
				throw new NullReferenceException();
			}
		}
		throw new NullReferenceException();
	}

	private unsafe static (int, int) GetPlayerOffset(int rotatedPlayerIndex)
	{
		//IL_00dc: Expected I4, but got I8
		//IL_00e4: Expected O, but got Ref
		//IL_0188: Expected native int or pointer, but got O
		//IL_00c8: Expected O, but got Ref
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		//IL_0141: Expected O, but got I
		//IL_005a: Expected I4, but got I8
		int item;
		(int, int) tuple;
		(int, int) result = default((int, int));
		switch (rotatedPlayerIndex)
		{
		case 2:
			return (0, -1);
		case 4:
			return (0, 1);
		case 1:
			item = 1;
			tuple = ((int, int))(&result);
			break;
		case 3:
			item = -1;
			tuple = ((int, int))(&result);
			break;
		default:
		{
			int num = default(int);
			string message = num.ToString();
			object obj = typeof(System.IOAsyncCallback) + 2632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			IndexOutOfRangeException ex = default(IndexOutOfRangeException);
			ex..ctor(message);
			object obj2 = (nint)0 + (nint)392;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			return ((int, int))new OutOfMemoryException();
		}
		}
		*((int, int)*)(nint)tuple = (item, 0);
		return result;
	}

	private unsafe static void InitializeGraveyards(JackarooNodeMono nodePrefab, Transform[] firstNodeTransform, IReadOnlyList<JackarooNode> graveyardsNodes, float graveyardVerticalOffset, float graveyardHorizontalOffset)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0c52: Expected O, but got I
		//IL_0c6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c70: Expected O, but got Unknown
		//IL_0c7d: Expected I, but got O
		//IL_0c96: Expected O, but got I4
		//IL_0ca6: Expected O, but got I
		//IL_0cb6: Expected F4, but got I
		//IL_0ce6: Expected F4, but got I
		//IL_0cf6: Expected O, but got I
		//IL_0cff: Expected O, but got I4
		//IL_0ae2: Expected O, but got I4
		//IL_0def: Expected O, but got I4
		//IL_0bc8: Expected O, but got I4
		//IL_0beb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Expected O, but got Unknown
		//IL_0c0d: Expected native int or pointer, but got F4
		//IL_0c28: Expected O, but got F4
		//IL_0e46: Expected O, but got I4
		//IL_0e5c: Expected O, but got I
		//IL_0e7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e81: Expected O, but got Unknown
		//IL_0d2f: Expected I, but got O
		//IL_0d7a: Expected O, but got I
		//IL_0eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ebb: Expected O, but got Unknown
		//IL_0ec4: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec9: Expected O, but got Unknown
		//IL_05fa: Expected native int or pointer, but got F4
		//IL_0604: Invalid comparison between F4 and I4
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00e3: Expected O, but got I4
		//IL_0115: Expected O, but got I4
		//IL_012e: Expected O, but got I4
		//IL_0654: Expected native int or pointer, but got F4
		//IL_065e: Expected O, but got F4
		//IL_0181: Expected O, but got I4
		//IL_066b: Expected native int or pointer, but got F4
		//IL_0675: Invalid comparison between F4 and I4
		//IL_06c5: Expected native int or pointer, but got F4
		//IL_06cf: Expected O, but got F4
		//IL_01dd: Expected O, but got I
		//IL_01fc: Expected O, but got I4
		//IL_0744: Expected native int or pointer, but got F4
		//IL_074e: Invalid comparison between F4 and I4
		//IL_079e: Expected native int or pointer, but got F4
		//IL_07a8: Expected O, but got F4
		//IL_07b5: Expected native int or pointer, but got F4
		//IL_07bf: Invalid comparison between F4 and I4
		//IL_0258: Expected O, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_080f: Expected native int or pointer, but got F4
		//IL_0819: Expected O, but got F4
		//IL_02a0: Expected O, but got I4
		//IL_0b20: Expected O, but got I4
		//IL_0dc6: Expected O, but got I4
		//IL_085e: Expected O, but got I4
		//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b3: Expected O, but got Unknown
		//IL_02d2: Expected F4, but got I
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02eb: Expected O, but got Unknown
		//IL_0889: Expected native int or pointer, but got F4
		//IL_0893: Invalid comparison between F4 and I4
		//IL_0304: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_0344: Expected O, but got I
		//IL_035c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0361: Expected O, but got Unknown
		//IL_0369: Expected I, but got O
		//IL_0379: Expected O, but got I
		//IL_08e3: Expected native int or pointer, but got F4
		//IL_08ed: Expected O, but got F4
		//IL_090d: Expected O, but got I4
		//IL_041f: Expected O, but got I
		//IL_0450: Expected O, but got I4
		//IL_0584: Expected I, but got O
		//IL_03b4: Expected O, but got I
		//IL_0928: Expected native int or pointer, but got F4
		//IL_0932: Invalid comparison between F4 and I4
		//IL_0483: Expected I, but got O
		//IL_05cc: Expected I, but got O
		//IL_04a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ad: Expected O, but got Unknown
		//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04bb: Expected O, but got Unknown
		//IL_04cb: Expected O, but got I
		//IL_051e: Expected I, but got O
		//IL_0982: Expected native int or pointer, but got F4
		//IL_098c: Expected O, but got F4
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c7: Expected O, but got Unknown
		//IL_03dd: Expected O, but got I
		//IL_0b66: Expected O, but got I4
		//IL_09c9: Expected native int or pointer, but got F4
		//IL_09d3: Invalid comparison between F4 and I4
		//IL_0a23: Expected native int or pointer, but got F4
		//IL_0a2d: Expected O, but got F4
		//IL_0a3a: Expected native int or pointer, but got F4
		//IL_0a44: Invalid comparison between F4 and I4
		//IL_0a94: Expected native int or pointer, but got F4
		//IL_0a9e: Expected O, but got F4
		//IL_0bac: Expected O, but got I4
		object obj = typeof(TypeConverter<ushort, char>) + 1424;
		object item = (nint)0 + (nint)4008;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
		JackarooNodeMono jackarooNodeMono = (JackarooNodeMono)(typeof(UsageHint) + 816);
		nint num = (nint)jackarooNodeMono;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v102 @ X8_v5 (Il2CppClass<Jackaroo.JackarooNodeMono>)+B8]");
		nint num2 = 0;
		(Vector3, Vector3) tuple = ((Vector3, Vector3))UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6 (Il2CppStaticFields<Jackaroo.JackarooNodeMono>)+4]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6 (Il2CppStaticFields<Jackaroo.JackarooNodeMono>)+8]");
		float num3 = 0f;
		(Vector3, Vector3) tuple2 = ((Vector3)item, (Vector3)graveyardsNodes);
		object obj3 = default(object);
		bool flag = obj3 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6 (Il2CppStaticFields<Jackaroo.JackarooNodeMono>)+8]");
		float num4 = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X8_v6 (Il2CppStaticFields<Jackaroo.JackarooNodeMono>)+4]");
		object obj4 = 0;
		(Vector3, Vector3) tuple3 = ((Vector3, Vector3))UnityEngine.Object.OffsetOfInstanceIDInCPlusPlusObject;
		IReadOnlyList<JackarooNode> readOnlyList = graveyardsNodes;
		float num5 = graveyardVerticalOffset;
		Transform[] array2 = default(Transform[]);
		Vector3 verticalOffset = default(Vector3);
		Vector3 horizontalOffset = default(Vector3);
		string nodeName = default(string);
		object obj31;
		if (!flag)
		{
			_ = 0;
			(Vector3, Vector3) tuple4 = ((Vector3)item, (Vector3)graveyardsNodes);
			_ = 0;
			(Vector3, Vector3) tuple5 = ((Vector3)item, (Vector3)graveyardsNodes);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+18]");
			bool flag2 = (nint)0 < (nint)2;
			object obj5 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+18]");
			object obj6 = -2;
			bool flag3 = obj6 == null;
			object obj7 = ~obj5;
			object obj8 = obj7 | flag3;
			if (obj8 != null)
			{
				goto IL_0c3f;
			}
			_ = 0;
			nint num6 = (nint)jackarooNodeMono;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1069 @ X8_v33 (Il2CppClass<Jackaroo.JackarooNodeMono>)+B8]");
			nint num7 = 0;
			float num8 = graveyardVerticalOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X8_v35 (Il2CppStaticFields<Jackaroo.JackarooNodeMono>)+20]");
			float num9 = num8 * 0f;
			float num10 = num9 * 0.5f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BCF0D7]");
			object obj9 = 0;
			num5 = graveyardVerticalOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X8_v35 (Il2CppStaticFields<Jackaroo.JackarooNodeMono>)+44]");
			float num11 = 0f * graveyardHorizontalOffset;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X8_v35 (Il2CppStaticFields<Jackaroo.JackarooNodeMono>)+3C]");
			object obj11 = default(object);
			object obj10 = 0 * obj11;
			tuple3 = ((Vector3, Vector3))(obj10 * 63);
			num4 = num11 * -0.5f;
			(Vector3, Vector3) tuple6 = ((Vector3)item, (Vector3)graveyardsNodes);
			_ = 0;
			bool flag4 = firstNodeTransform == null;
			object obj12 = default(object);
			obj4 = obj12;
			num3 = num10;
			object obj13 = default(object);
			obj2 = obj13;
			readOnlyList = graveyardsNodes;
			tuple = tuple6;
			if (!flag4)
			{
				float num12 = (float)firstNodeTransform + 32f;
				if (graveyardsNodes != null)
				{
					object obj14 = obj3 + 32;
					object obj15 = 153100288 + 1024;
					obj4 = obj12;
					(Vector3, Vector3) tuple7 = tuple3;
					num3 = num10;
					obj2 = obj13;
					readOnlyList = graveyardsNodes;
					(Vector3, Vector3) tuple8 = ((Vector3, Vector3))0;
					object obj16 = obj3;
					tuple = tuple6;
					(Vector3, Vector3) tuple9 = ((Vector3, Vector3))146599936;
					Transform[] array = firstNodeTransform;
					object arg = default(object);
					object arg2 = default(object);
					JackarooNode jackarooNode = default(JackarooNode);
					while (true)
					{
						bool flag5 = (nint)tuple8 < array.Length;
						object obj17 = !flag5;
						if (obj17 != null)
						{
							break;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v38 (System.Single)+v280 @ X27_v8 (System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>)*8]");
						bool flag6 = (nint)0 == 0;
						tuple3 = tuple7;
						array2 = firstNodeTransform;
						num5 = num12;
						(Vector3, Vector3) tuple12;
						nint num14;
						if (!flag6)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v38 (System.Single)+v280 @ X27_v8 (System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>)*8]");
							Quaternion rotation = ((Transform)0).rotation;
							bool flag7 = (nint)tuple8 < array.Length;
							object obj18 = !flag7;
							if (obj18 != null)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v38 (System.Single)+v280 @ X27_v8 (System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>)*8]");
							bool flag8 = (nint)0 == 0;
							tuple3 = tuple7;
							array2 = firstNodeTransform;
							num5 = num12;
							if (!flag8)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v38 (System.Single)+v280 @ X27_v8 (System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>)*8]");
								Vector3 position = ((Transform)0).position;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1130 @ X24_v14+18]");
								if ((nint)0 >= (nint)1)
								{
									object obj19 = (object)tuple8 << 2;
									(Vector3, Vector3) tuple10 = tuple7;
									(Vector3, Vector3) tuple11 = ((Vector3, Vector3))0;
									while (true)
									{
										bool flag9 = (nint)tuple8 < array.Length;
										object obj20 = !flag9;
										if (obj20 != null)
										{
											break;
										}
										object obj21 = tuple11 * 24;
										object obj22 = obj14 + obj21;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1235 @ X8_v76+8]");
										num10 = 0f;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
										tuple9 = ((Vector3, Vector3))(tuple11 + 1);
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
										object format = "Picking audio files is not supported on iOS" + 2896;
										string rotation2 = string.Format((string)format, arg, arg2);
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1099 @ X8_v38 (System.Single)+v280 @ X27_v8 (System.ValueTuple`2<UnityEngine.Vector3, UnityEngine.Vector3>)*8]");
										JackarooNodeMono nodeMono = InitializeJackarooNodeMono(nodePrefab, (Vector3)0, (Quaternion)rotation2, null, verticalOffset, horizontalOffset, nodeName);
										object obj23 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
										nint num13 = (nint)graveyardsNodes;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v82 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
										obj9 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v82 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
										if ((nint)0 == 0)
										{
											goto IL_0405;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v82 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
										object obj24 = (nint)0 + (nint)8;
										object obj25;
										while (true)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X10_v12-8]");
											if (0 == (nint)obj23)
											{
												break;
											}
											obj25 = obj24 + 16;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X8_v82 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
											obj9 = -1;
											bool flag10 = (nint)obj9 != 1;
											obj24 = obj25;
											if (flag10)
											{
												continue;
											}
											goto IL_0405;
										}
										obj9 = obj24;
										object obj26 = num13 + obj24;
										object obj27 = obj26 + 312;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1298 @ X0_v66+8]");
										readOnlyList = (IReadOnlyList<JackarooNode>)0;
										object obj28 = obj19 + (object)tuple11;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1298 @ X0_v66] (should have been resolved before IL gen)");
										bool flag11 = jackarooNode == null;
										obj25 = obj24;
										tuple12 = tuple7;
										num4 = num3;
										obj4 = obj2;
										tuple3 = tuple;
										num14 = unchecked((nint)null);
										array2 = firstNodeTransform;
										num5 = num12;
										if (!flag11)
										{
											goto IL_053c;
										}
										goto IL_0acb;
										IL_0405:
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1281 @ X0_v63+8]");
										readOnlyList = (IReadOnlyList<JackarooNode>)0;
										object obj29 = obj19 + (object)tuple11;
										Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1281 @ X0_v63] (should have been resolved before IL gen)");
										bool flag12 = jackarooNode == null;
										object obj30 = !flag12;
										if (obj30 != null)
										{
											goto IL_053c;
										}
										tuple12 = tuple7;
										num4 = num3;
										obj4 = obj2;
										tuple3 = tuple;
										num14 = unchecked((nint)null);
										array2 = firstNodeTransform;
										num5 = num12;
										goto IL_0acb;
										IL_053c:
										jackarooNode.SetNodeMono(nodeMono);
										(Vector3, Vector3) tuple13 = tuple9;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+18]");
										bool flag13 = (nint)tuple13 < 0;
										tuple12 = tuple7;
										num4 = num3;
										obj4 = obj2;
										tuple10 = tuple;
										num14 = unchecked((nint)null);
										readOnlyList = null;
										tuple11 = tuple9;
										array = firstNodeTransform;
										if (flag13)
										{
											continue;
										}
										goto IL_05a7;
									}
									break;
								}
								goto IL_013b;
							}
						}
						goto IL_0acb;
						IL_05a7:
						tuple12 = tuple7;
						num4 = num3;
						obj4 = obj2;
						tuple7 = tuple;
						num14 = unchecked((nint)null);
						readOnlyList = null;
						tuple4 = tuple9;
						tuple2 = tuple8;
						obj16 = obj3;
						array = firstNodeTransform;
						goto IL_013b;
						IL_013b:
						tuple8 = ((Vector3, Vector3))(tuple8 + 1);
						if ((nint)tuple8 != 4)
						{
							continue;
						}
						return;
					}
					goto IL_0c3f;
				}
				bool flag14 = ((float*)(nint)num12)->m_value == 0f;
				obj4 = obj12;
				num3 = num10;
				obj2 = obj13;
				readOnlyList = graveyardsNodes;
				array2 = firstNodeTransform;
				tuple = tuple6;
				num5 = num12;
				if (!flag14)
				{
					Quaternion rotation3 = ((Transform)((float*)(nint)num12)->m_value).rotation;
					bool flag15 = ((float*)(nint)num12)->m_value == 0f;
					obj4 = obj12;
					num3 = num10;
					obj2 = obj13;
					readOnlyList = graveyardsNodes;
					array2 = firstNodeTransform;
					tuple = tuple6;
					num5 = num12;
					if (!flag15)
					{
						Vector3 position2 = ((Transform)((float*)(nint)num12)->m_value).position;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+18]");
						bool flag16 = (nint)0 > (nint)0;
						obj4 = obj12;
						num3 = num10;
						obj2 = obj13;
						readOnlyList = graveyardsNodes;
						array2 = firstNodeTransform;
						tuple = tuple6;
						num5 = num12;
						if (flag16)
						{
							goto IL_0ad9;
						}
						float num15 = (float)firstNodeTransform + 40f;
						bool flag17 = ((float*)(nint)num15)->m_value == 0f;
						obj4 = obj12;
						num3 = num10;
						obj2 = obj13;
						readOnlyList = graveyardsNodes;
						array2 = firstNodeTransform;
						tuple = tuple6;
						num5 = num15;
						if (!flag17)
						{
							Quaternion rotation4 = ((Transform)((float*)(nint)num15)->m_value).rotation;
							bool flag18 = ((float*)(nint)num15)->m_value == 0f;
							obj4 = obj12;
							num3 = num10;
							obj2 = obj13;
							readOnlyList = graveyardsNodes;
							array2 = firstNodeTransform;
							tuple = tuple6;
							num5 = num15;
							if (!flag18)
							{
								Vector3 position3 = ((Transform)((float*)(nint)num15)->m_value).position;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+18]");
								if ((nint)0 > (nint)0)
								{
									obj4 = obj12;
									num3 = num10;
									obj2 = obj13;
									readOnlyList = graveyardsNodes;
									array2 = firstNodeTransform;
									tuple = tuple6;
									obj31 = 1;
									num5 = num15;
									goto IL_0dd4;
								}
								bool flag19 = firstNodeTransform.Length < 3;
								object obj32 = !flag19;
								object obj33 = ~obj32;
								if (obj33 != null)
								{
									goto IL_0c3f;
								}
								float num16 = (float)firstNodeTransform + 48f;
								bool flag20 = ((float*)(nint)num16)->m_value == 0f;
								obj4 = obj12;
								num3 = num10;
								obj2 = obj13;
								readOnlyList = graveyardsNodes;
								array2 = firstNodeTransform;
								tuple = tuple6;
								num5 = num16;
								if (!flag20)
								{
									Quaternion rotation5 = ((Transform)((float*)(nint)num16)->m_value).rotation;
									bool flag21 = firstNodeTransform.Length < 3;
									object obj34 = !flag21;
									object obj35 = ~obj34;
									if (obj35 != null)
									{
										goto IL_0c3f;
									}
									bool flag22 = ((float*)(nint)num16)->m_value == 0f;
									obj4 = obj12;
									num3 = num10;
									obj2 = obj13;
									readOnlyList = graveyardsNodes;
									array2 = firstNodeTransform;
									tuple = tuple6;
									num5 = num16;
									if (!flag22)
									{
										Vector3 position4 = ((Transform)((float*)(nint)num16)->m_value).position;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+18]");
										if ((nint)0 > (nint)0)
										{
											obj4 = obj12;
											num3 = num10;
											obj2 = obj13;
											readOnlyList = graveyardsNodes;
											array2 = firstNodeTransform;
											tuple = tuple6;
											obj31 = 2;
											num5 = num16;
											goto IL_0dd4;
										}
										float num17 = (float)firstNodeTransform + 56f;
										bool flag23 = ((float*)(nint)num17)->m_value == 0f;
										obj4 = obj12;
										num3 = num10;
										obj2 = obj13;
										readOnlyList = graveyardsNodes;
										array2 = firstNodeTransform;
										tuple = tuple6;
										num5 = num17;
										if (!flag23)
										{
											Quaternion rotation6 = ((Transform)((float*)(nint)num17)->m_value).rotation;
											bool flag24 = ((float*)(nint)num17)->m_value == 0f;
											obj4 = obj12;
											num3 = num10;
											obj2 = obj13;
											readOnlyList = graveyardsNodes;
											array2 = firstNodeTransform;
											tuple = tuple6;
											num5 = num17;
											if (!flag24)
											{
												Vector3 position5 = ((Transform)((float*)(nint)num17)->m_value).position;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X0_v3+18]");
												if ((nint)0 < (nint)1)
												{
													return;
												}
												obj4 = obj12;
												num3 = num10;
												obj2 = obj13;
												readOnlyList = graveyardsNodes;
												array2 = firstNodeTransform;
												tuple = tuple6;
												obj31 = 3;
												num5 = num17;
												goto IL_0dd4;
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0acb;
		IL_0ad9:
		obj31 = 0;
		goto IL_0dd4;
		IL_0dd4:
		bool flag25 = (nint)obj31 < array2.Length;
		object obj36 = !flag25;
		if (obj36 == null)
		{
			object obj37 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
			object format2 = "Picking audio files is not supported on iOS" + 2896;
			object arg3 = default(object);
			object arg4 = default(object);
			string rotation7 = string.Format((string)format2, arg3, arg4);
			JackarooNodeMono jackarooNodeMono2 = InitializeJackarooNodeMono(nodePrefab, (Vector3)((float*)(nint)num5)->m_value, (Quaternion)rotation7, null, verticalOffset, horizontalOffset, nodeName);
			NullReferenceException ex = new NullReferenceException();
		}
		goto IL_0c3f;
		IL_0c3f:
		throw new IndexOutOfRangeException();
		IL_0acb:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0ad9;
	}

	private void SetupMarbles()
	{
		//IL_0539: Unknown result type (might be due to invalid IL or missing references)
		//IL_053e: Expected O, but got Unknown
		//IL_054d: Expected O, but got I4
		//IL_002f: Expected O, but got I4
		//IL_0649: Expected I, but got O
		//IL_0659: Expected O, but got I
		//IL_00ad: Expected O, but got I
		//IL_00d1: Expected O, but got I4
		//IL_0137: Expected O, but got I
		//IL_004a: Expected O, but got I
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05ac: Expected O, but got I
		//IL_05bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_05ea: Expected O, but got I4
		//IL_015b: Expected O, but got I
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_010f: Expected O, but got I
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a9: Expected O, but got Unknown
		//IL_01b1: Expected I, but got O
		//IL_01c1: Expected O, but got I
		//IL_0273: Expected O, but got I4
		//IL_02cd: Expected I, but got O
		//IL_02dd: Expected O, but got I
		//IL_01fc: Expected O, but got I
		//IL_0391: Expected O, but got I4
		//IL_0318: Expected O, but got I
		//IL_028e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Expected O, but got Unknown
		//IL_029c: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a1: Expected O, but got Unknown
		//IL_020a: Unknown result type (might be due to invalid IL or missing references)
		//IL_020f: Expected O, but got Unknown
		//IL_0218: Unknown result type (might be due to invalid IL or missing references)
		//IL_021d: Expected O, but got Unknown
		//IL_040d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0412: Expected O, but got Unknown
		//IL_0426: Unknown result type (might be due to invalid IL or missing references)
		//IL_042b: Expected O, but got Unknown
		//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b1: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_046d: Expected O, but got I4
		//IL_047d: Expected O, but got I
		//IL_048d: Expected O, but got I
		//IL_049d: Expected O, but got I
		//IL_0326: Unknown result type (might be due to invalid IL or missing references)
		//IL_032b: Expected O, but got Unknown
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_04dc: Expected O, but got I4
		//IL_04ec: Expected O, but got I
		//IL_04fc: Expected O, but got I
		//IL_050c: Expected O, but got I
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
		object obj2 = 153100288 + 1024;
		int num = 0;
		JackarooMarble jackarooMarble = default(JackarooMarble);
		JackarooNode jackarooNode = default(JackarooNode);
		object arg = default(object);
		object arg2 = default(object);
		JackarooMarbleMono jackarooMarbleMono = default(JackarooMarbleMono);
		object obj18 = default(object);
		bool flag9;
		do
		{
			JackarooBoard jackarooBoard = <Board>k__BackingField;
			object obj3 = ((List<object>)(object)jackarooBoard._graveyardsNodes).get_Item(num);
			object obj4 = 0;
			bool flag3;
			object obj17;
			object obj12;
			object obj13;
			object obj14;
			object obj15;
			object obj16;
			do
			{
				nint num2 = (nint)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v11 (Il2CppClass<System.Object>)+12E]");
				object obj5 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v11 (Il2CppClass<System.Object>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0093;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v520 @ X8_v11 (Il2CppClass<System.Object>)+B0]");
				object obj6 = (nint)0 + (nint)8;
				object obj7;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v322 @ X10_v20-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj7 = obj6 + 16;
					obj5--;
					bool flag = (nint)obj5 != 1;
					obj6 = obj7;
					if (flag)
					{
						continue;
					}
					goto IL_0093;
				}
				object obj8 = num2 + obj6;
				object obj9 = obj8 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v554 @ X0_v53+8]");
				object obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v554 @ X0_v53] (should have been resolved before IL gen)");
				obj7 = obj6;
				goto IL_0126;
				IL_0361:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v675 @ X0_v32] (should have been resolved before IL gen)");
				bool flag2 = <Board>k__BackingField == null;
				object obj11 = !flag2;
				if (obj11 != null)
				{
					goto IL_03d6;
				}
				goto IL_0523;
				IL_0523:
				throw new NullReferenceException();
				IL_03d6:
				jackarooMarble.SetNode(jackarooNode);
				jackarooNode.SetMarble(jackarooMarble);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				obj4++;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
				object format = " SDK from working.  If you would like to change it's implementation please override StartVivoxUnity method in " + 1696;
				string text = string.Format((string)format, arg, arg2);
				jackarooMarbleMono.name = text;
				flag3 = (nint)obj4 != 4;
				obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v19+C]");
				obj13 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v19+8]");
				obj14 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v19+4]");
				obj15 = 0;
				obj16 = obj17;
				continue;
				IL_0093:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X0_v50+8]");
				obj10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v538 @ X0_v50] (should have been resolved before IL gen)");
				bool flag4 = obj18 == null;
				object obj19 = !flag4;
				if (obj19 != null)
				{
					goto IL_0126;
				}
				goto IL_0523;
				IL_0126:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X0_v9+18]");
				Vector3 position = ((JackarooNodeMono)0).Position;
				object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 2696;
				object obj21 = obj20;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X8_v18+B8]");
				obj17 = 0;
				object obj22 = typeof(MemberAchievementClanFeedData) + 2976;
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X0_v13+E4]");
				bool flag5 = (nint)0 == 0;
				object obj24 = !flag5;
				if (obj24 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				}
				object obj25 = (nint)0 + (nint)1096;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2EEA1BC");
				JackarooBoard jackarooBoard2 = <Board>k__BackingField;
				object obj26 = ((List<object>)(object)jackarooBoard2._playersGraveyardMarbles).get_Item(num);
				object obj27 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2472;
				nint num3 = (nint)obj26;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v32 (Il2CppClass<System.Object>)+12E]");
				object obj28 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v32 (Il2CppClass<System.Object>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0245;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X8_v32 (Il2CppClass<System.Object>)+B0]");
				object obj29 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X10_v15-8]");
					if (0 == (nint)obj27)
					{
						break;
					}
					obj7 = obj29 + 16;
					obj28--;
					bool flag6 = (nint)obj28 != 1;
					obj29 = obj7;
					if (flag6)
					{
						continue;
					}
					goto IL_0245;
				}
				object obj30 = num3 + obj29;
				object obj31 = obj30 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v405 @ X8_v43] (should have been resolved before IL gen)");
				obj7 = obj29;
				goto IL_02b8;
				IL_02b8:
				jackarooMarble.SetMarbleMono(jackarooMarbleMono);
				nint num4 = (nint)obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v34 (Il2CppClass<System.Object>)+12E]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v34 (Il2CppClass<System.Object>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0361;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X8_v34 (Il2CppClass<System.Object>)+B0]");
				object obj33 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X10_v10-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj7 = obj33 + 16;
					obj32--;
					bool flag7 = (nint)obj32 != 1;
					obj33 = obj7;
					if (flag7)
					{
						continue;
					}
					goto IL_0361;
				}
				object obj34 = num4 + obj33;
				object obj35 = obj34 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v691 @ X0_v35] (should have been resolved before IL gen)");
				obj7 = obj33;
				goto IL_03d6;
				IL_0245:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v619 @ X0_v38] (should have been resolved before IL gen)");
				bool flag8 = jackarooMarble == null;
				object obj36 = !flag8;
				if (obj36 != null)
				{
					goto IL_02b8;
				}
				goto IL_0523;
			}
			while (flag3);
			num++;
			flag9 = num != 4;
			obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v19+C]");
			obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v19+8]");
			obj14 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v575 @ X8_v19+4]");
			obj15 = 0;
			obj16 = obj17;
		}
		while (flag9);
	}

	private void ResetMarbles()
	{
		//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d1: Expected O, but got Unknown
		//IL_03e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e5: Expected O, but got Unknown
		//IL_03f1: Expected O, but got I
		//IL_03fa: Expected O, but got I4
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected I4, but got Unknown
		//IL_0085: Expected I, but got O
		//IL_0095: Expected O, but got I
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_01e0: Expected I, but got O
		//IL_01f0: Expected O, but got I
		//IL_00d0: Expected O, but got I
		//IL_02a3: Expected O, but got I4
		//IL_040f: Expected O, but got I
		//IL_022b: Expected O, but got I
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_018b: Expected O, but got Unknown
		//IL_019e: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I
		//IL_0443: Expected O, but got I
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_02cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d1: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_0247: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Expected O, but got Unknown
		//IL_0375: Unknown result type (might be due to invalid IL or missing references)
		//IL_037a: Expected O, but got Unknown
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2248;
		object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2472;
		object obj3 = (nint)0 + (nint)2968;
		object obj4 = 1;
		object obj8 = default(object);
		object obj9 = default(object);
		object obj13 = default(object);
		object obj15 = default(object);
		bool flag3;
		JackarooMarble jackarooMarble = default(JackarooMarble);
		do
		{
			JackarooBoard jackarooBoard = <Board>k__BackingField;
			int index = obj4 - 1;
			object obj5 = ((List<object>)(object)jackarooBoard._playersPlantedMarbles).get_Item(index);
			nint num = (nint)obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v7 (Il2CppClass<System.Object>)+12E]");
			object obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v7 (Il2CppClass<System.Object>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0119;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v7 (Il2CppClass<System.Object>)+B0]");
			object obj7 = (nint)0 + (nint)8;
			bool flag;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X10_v15-8]");
				obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X10_v15-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj9 = obj7 + 16;
				obj6--;
				flag = (nint)obj6 != 1;
				obj7 = obj9;
				if (flag)
				{
					continue;
				}
				goto IL_0119;
			}
			object obj10 = num + obj7;
			object obj11 = obj10 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v352 @ X0_v28] (should have been resolved before IL gen)");
			object obj12 = obj13 - 1;
			bool flag2 = (nint)obj13 < 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X10_v15-8]");
			object obj14 = 0;
			obj9 = obj7;
			if (flag2)
			{
				goto IL_0005;
			}
			goto IL_01d8;
			IL_0119:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v312 @ X0_v25] (should have been resolved before IL gen)");
			obj12 = obj15 - 1;
			if ((nint)obj15 < 1)
			{
				obj14 = obj8;
				obj7 = obj9;
				goto IL_0005;
			}
			goto IL_01d8;
			IL_0005:
			obj4++;
			flag3 = (nint)obj4 == 5;
			obj8 = obj14;
			obj9 = obj7;
			continue;
			IL_01d8:
			do
			{
				nint num2 = (nint)obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v9 (Il2CppClass<System.Object>)+12E]");
				object obj16 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v9 (Il2CppClass<System.Object>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0274;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v398 @ X8_v9 (Il2CppClass<System.Object>)+B0]");
				object obj17 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X10_v8-8]");
					obj8 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v150 @ X10_v8-8]");
					if (0 == (nint)obj2)
					{
						break;
					}
					obj9 = obj17 + 16;
					obj16--;
					bool flag4 = (nint)obj16 != 1;
					obj17 = obj9;
					if (flag4)
					{
						continue;
					}
					goto IL_0274;
				}
				object obj18 = num2 + obj17;
				object obj19 = obj18 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v441 @ X0_v21] (should have been resolved before IL gen)");
				obj9 = obj17;
				goto IL_02e9;
				IL_02e9:
				jackarooMarble.<MarbleMono>k__BackingField.Stop();
				JackarooNode jackarooNode = <Board>k__BackingField.MoveMarbleFromBoardToGraveyard(jackarooMarble);
				jackarooMarble.<Node>k__BackingField.SetMarble();
				jackarooMarble.SetNode(jackarooNode);
				jackarooNode.SetMarble(jackarooMarble);
				JackarooNode <Node>k__BackingField = jackarooMarble.<Node>k__BackingField;
				jackarooMarble.<MarbleMono>k__BackingField.MoveImmediate(<Node>k__BackingField.<NodeMono>k__BackingField);
				object obj20 = obj12 - 1;
				flag = (nint)obj12 > 0;
				obj12 = obj20;
				continue;
				IL_0274:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v425 @ X0_v18] (should have been resolved before IL gen)");
				bool flag5 = jackarooMarble == null;
				object obj21 = !flag5;
				if (obj21 == null)
				{
					throw new NullReferenceException();
				}
				goto IL_02e9;
			}
			while (flag);
			obj14 = obj8;
			obj7 = obj9;
			goto IL_0005;
		}
		while (!flag3);
	}

	private void AddToMovesQueue(Action action)
	{
		//IL_0011: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		object obj = (nint)0 + (nint)872;
		((Queue<object>)(object)_movesQueue).Enqueue((object)action);
		if (_movesRunnerIE == null)
		{
			object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 456;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = default(object);
			obj3..ctor();
			_ = 0;
			object obj4 = obj3 + 32;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_movesRunnerIE = (IEnumerator)obj3;
			object obj5 = this + 272;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = StartCoroutine(_movesRunnerIE);
		}
	}

	private IEnumerator MovesRunnerIe()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 456;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private static float GetDurationForNodes(int nodesCount)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_002a: Expected O, but got I
		//IL_00da: Expected O, but got I4
		//IL_0097: Expected O, but got I4
		//IL_0128: Expected O, but got I
		//IL_01d8: Expected O, but got I4
		//IL_0195: Expected O, but got I4
		object obj = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F84]");
		object obj2 = (nint)0 & (nint)1;
		if (obj2 != null)
		{
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0074;
			}
		}
		else
		{
			_ = 1;
			object obj3 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0074;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		RemoteConfigModel current = RemoteConfig.Current;
		goto IL_0100;
		IL_0172:
		RemoteConfigModel current2 = RemoteConfig.Current;
		bool flag2 = current2 == null;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			goto IL_01fe;
		}
		goto IL_0246;
		IL_01fe:
		JackarooConfig <Jackaroo>k__BackingField = current2.<Jackaroo>k__BackingField;
		JackarooConfig <Jackaroo>k__BackingField2;
		return FloatExtensions.Map(nodesCount, 1f, 13f, <Jackaroo>k__BackingField2.<MinMarbleMoveDuration>k__BackingField, <Jackaroo>k__BackingField.<MaxMarbleMoveDuration>k__BackingField);
		IL_0246:
		throw new NullReferenceException();
		IL_0074:
		current = RemoteConfig.Current;
		bool flag3 = current == null;
		object obj6 = !flag3;
		if (obj6 != null)
		{
			goto IL_0100;
		}
		goto IL_0246;
		IL_0100:
		<Jackaroo>k__BackingField2 = current.<Jackaroo>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F85]");
		object obj7 = (nint)0 & (nint)1;
		if (obj7 != null)
		{
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				goto IL_0172;
			}
		}
		else
		{
			_ = 1;
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v133 @ X0_v6+E4]");
			bool flag4 = (nint)0 == 0;
			object obj9 = !flag4;
			if (obj9 != null)
			{
				goto IL_0172;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current2 = RemoteConfig.Current;
		goto IL_01fe;
	}

	private void Plant(JackarooMove move, Action onComplete, GameAction? emote = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_00fb: Expected I, but got O
		//IL_010b: Expected O, but got I
		//IL_01a1: Expected O, but got I
		//IL_01c5: Expected O, but got I4
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_027f: Expected O, but got Unknown
		//IL_0146: Expected O, but got I
		//IL_01eb: Expected O, but got I
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_0220: Expected O, but got I
		//IL_0251: Expected O, but got I
		//IL_0154: Unknown result type (might be due to invalid IL or missing references)
		//IL_0159: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_049f: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a4: Expected O, but got Unknown
		//IL_08ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b2: Expected O, but got Unknown
		//IL_08c8: Expected O, but got I
		//IL_048b: Expected O, but got I4
		//IL_0b0a: Expected O, but got I4
		//IL_0b22: Expected O, but got I
		//IL_0b42: Expected O, but got I
		//IL_050a: Expected O, but got I4
		//IL_09b2: Expected O, but got I4
		//IL_0949: Expected O, but got I
		//IL_0969: Expected O, but got I
		//IL_0537: Expected O, but got I
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected O, but got Unknown
		//IL_057e: Expected O, but got I4
		//IL_0c13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c18: Expected O, but got Unknown
		//IL_0c4a: Expected O, but got I4
		//IL_05b8: Expected O, but got I4
		//IL_0c82: Expected O, but got I4
		//IL_05e3: Expected O, but got I
		//IL_0c9c: Expected O, but got I
		//IL_0cab: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected O, but got Unknown
		//IL_0cb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbe: Expected O, but got Unknown
		//IL_0cf2: Expected I, but got O
		//IL_0619: Expected O, but got I
		//IL_062e: Expected O, but got I
		//IL_0d19: Expected O, but got I4
		//IL_0d2a: Expected O, but got I4
		//IL_0645: Expected I, but got O
		//IL_0656: Expected I, but got O
		//IL_0665: Unknown result type (might be due to invalid IL or missing references)
		//IL_066a: Expected O, but got Unknown
		//IL_068b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0690: Expected O, but got Unknown
		//IL_06a0: Expected O, but got I
		//IL_0d50: Expected O, but got I4
		//IL_06b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bd: Expected O, but got Unknown
		//IL_06cd: Expected O, but got I
		//IL_06e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e5: Expected O, but got Unknown
		//IL_0dd8: Expected O, but got I4
		//IL_0705: Unknown result type (might be due to invalid IL or missing references)
		//IL_070a: Expected O, but got Unknown
		//IL_0740: Expected O, but got I4
		//IL_0d66: Expected I, but got O
		//IL_0d76: Expected O, but got I
		//IL_0d98: Expected O, but got I4
		//IL_0db0: Expected O, but got I
		//IL_0dff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e04: Expected O, but got Unknown
		//IL_076a: Expected O, but got I
		//IL_07bc: Expected O, but got I4
		//IL_07fa: Expected O, but got I4
		//IL_0809: Unknown result type (might be due to invalid IL or missing references)
		//IL_080e: Expected O, but got Unknown
		//IL_09ed: Expected O, but got I
		//IL_09fd: Expected O, but got I
		//IL_0a38: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a3d: Expected O, but got Unknown
		//IL_0a53: Expected O, but got I
		//IL_0a6d: Expected O, but got I4
		//IL_0a76: Expected O, but got I4
		//IL_0a9f: Expected O, but got I4
		//IL_084e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0853: Expected O, but got Unknown
		//IL_085c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0861: Expected O, but got Unknown
		//IL_087c: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		GameAction? gameAction = emote;
		Action action = null;
		JackarooMarble <Marble1>k__BackingField;
		Action action3;
		JackarooNode jackarooNode = default(JackarooNode);
		Action action2 = default(Action);
		if (!flag)
		{
			object obj3 = obj2 + 16;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj2 + 40;
			obj4 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			<IsAnimating>k__BackingField = true;
			bool flag2 = move == null;
			gameAction = emote;
			action = action2;
			if (!flag2)
			{
				IReadOnlyList<JackarooNode> <Nodes>k__BackingField = move.<Nodes>k__BackingField;
				bool flag3 = move.<Nodes>k__BackingField == null;
				gameAction = emote;
				action = action2;
				if (!flag3)
				{
					object obj5 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
					<Marble1>k__BackingField = move.<Marble1>k__BackingField;
					nint num = (nint)<Nodes>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v9 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
					object obj6 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v9 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0187;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X8_v9 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
					object obj7 = (nint)0 + (nint)8;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X10_v15-8]");
						if (0 == (nint)obj5)
						{
							break;
						}
						obj7 += 16;
						obj6--;
						if ((nint)obj6 != 1)
						{
							continue;
						}
						goto IL_0187;
					}
					object obj8 = num + obj7;
					object obj9 = obj8 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v90+8]");
					action3 = (Action)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v524 @ X0_v90] (should have been resolved before IL gen)");
					bool flag4 = jackarooNode == null;
					gameAction = emote;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X0_v90+8]");
					action2 = (Action)0;
					action = null;
					if (!flag4)
					{
						goto IL_0264;
					}
				}
			}
		}
		goto IL_0e68;
		IL_098f:
		RemoteConfigModel current = RemoteConfig.Current;
		bool flag5 = current == null;
		object obj10 = !flag5;
		GameAction? gameAction2 = gameAction;
		if (obj10 != null)
		{
			goto IL_0bbd;
		}
		Action action4;
		action2 = action4;
		Action action5;
		action = action5;
		goto IL_0e68;
		IL_0bbd:
		JackarooConfig <Jackaroo>k__BackingField = current.<Jackaroo>k__BackingField;
		bool flag6 = current.<Jackaroo>k__BackingField == null;
		gameAction = gameAction2;
		action2 = action4;
		action = action5;
		JackarooNodeMono jackarooNodeMono;
		GameAction? gameAction3;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag6)
		{
			object obj11 = typeof(TypeConverter<ushort, char>) + 1744;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
			AudioClip[] array = default(AudioClip[]);
			bool flag7 = array == null;
			gameAction = gameAction2;
			action2 = action4;
			action = (Action)1;
			if (!flag7)
			{
				bool flag8 = array.Length == 0;
				gameAction = gameAction2;
				action2 = action4;
				action = (Action)1;
				if (!flag8)
				{
					object obj12 = (nint)0 + (nint)1560;
					object obj13 = typeof(TypeConverter<ushort, char>) + 3128;
					object obj14 = array + 32;
					obj14 = _plantAudioClip;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Action action6 = default(Action);
					action6..ctor(obj2, (IntPtr)obj12);
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
					JackarooNodeMono[] array2 = default(JackarooNodeMono[]);
					bool flag9 = array2 == null;
					gameAction = (GameAction?)(object)0;
					action2 = (Action)obj12;
					action = (Action)1;
					if (flag9)
					{
						goto IL_0e68;
					}
					bool flag10 = (object)jackarooNodeMono == null;
					Action action7 = (Action)1;
					if (!flag10)
					{
						nint num2 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v18 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
						action7 = (Action)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag11 = ex == null;
						gameAction = (GameAction?)(object)0;
						action2 = (Action)obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v404 @ X8_v18 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
						action = (Action)0;
						if (flag11)
						{
							goto IL_0e84;
						}
					}
					bool flag12 = array2.Length == 0;
					gameAction = (GameAction?)(object)0;
					action2 = (Action)obj12;
					action = action7;
					if (!flag12)
					{
						object obj15 = array2 + 32;
						obj15 = jackarooNodeMono;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						float duration = <Jackaroo>k__BackingField.<MinMarbleMoveDuration>k__BackingField + <Jackaroo>k__BackingField.<MinMarbleMoveDuration>k__BackingField;
						MoveMarble(move.<Marble1>k__BackingField, duration, array, action6, _jackarooMoveSteps, 0, isPlant: true, gameAction3, array2);
						return;
					}
				}
				goto IL_0e76;
			}
		}
		goto IL_0e68;
		IL_0e68:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0e76;
		IL_0ada:
		_ = 1;
		object obj17;
		object obj16 = obj17;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v42+E4]");
		bool flag13 = (nint)0 == 0;
		object obj18 = !flag13;
		object obj20;
		object obj19 = obj20;
		gameAction = gameAction2;
		nint num3;
		action4 = (Action)num3;
		object obj21;
		action5 = (Action)obj21;
		JackarooNodeMono jackarooNodeMono2;
		jackarooNodeMono = jackarooNodeMono2;
		GameAction? gameAction4;
		gameAction3 = gameAction4;
		action2 = (Action)num3;
		action = (Action)obj21;
		if (obj18 != null)
		{
			goto IL_098f;
		}
		goto IL_0b58;
		IL_0e76:
		ex = new IndexOutOfRangeException();
		goto IL_0e84;
		IL_0891:
		jackarooNodeMono = jackarooNode.<NodeMono>k__BackingField;
		object obj22 = typeof(RegisteredWaitHandle) + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F84]");
		object obj23 = (nint)0 & (nint)1;
		bool flag14 = obj23 == null;
		obj17 = obj22;
		obj20 = obj19;
		gameAction2 = gameAction;
		nint num4;
		num3 = num4;
		JackarooMarble jackarooMarble;
		obj21 = jackarooMarble;
		jackarooNodeMono2 = jackarooNode.<NodeMono>k__BackingField;
		gameAction4 = gameAction3;
		if (!flag14)
		{
			goto IL_0922;
		}
		goto IL_0ada;
		IL_0e84:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0187:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v87+8]");
		action3 = (Action)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v442 @ X0_v87] (should have been resolved before IL gen)");
		bool flag15 = jackarooNode == null;
		object obj24 = !flag15;
		if (obj24 != null)
		{
			goto IL_0264;
		}
		gameAction = emote;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X0_v87+8]");
		action2 = (Action)0;
		action = null;
		goto IL_0e68;
		IL_0264:
		action = (Action)(object)jackarooNode.<Marble>k__BackingField;
		object obj25 = obj2 + 24;
		obj25 = jackarooNode.<Marble>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag16 = <Board>k__BackingField == null;
		gameAction = emote;
		action2 = action3;
		if (!flag16)
		{
			<Board>k__BackingField.MoveMarbleFromGraveyardListToPlantedList(move.<Marble1>k__BackingField);
			bool flag17 = move.<Marble1>k__BackingField == null;
			gameAction = emote;
			action2 = action3;
			action = (Action)(object)move.<Marble1>k__BackingField;
			if (!flag17)
			{
				bool flag18 = <Board>k__BackingField == null;
				gameAction = emote;
				action2 = action3;
				action = (Action)(object)move.<Marble1>k__BackingField;
				if (!flag18)
				{
					bool flag19 = <Marble1>k__BackingField.<Node>k__BackingField == null;
					gameAction = emote;
					action2 = action3;
					action = (Action)(object)move.<Marble1>k__BackingField;
					if (!flag19)
					{
						<Marble1>k__BackingField.<Node>k__BackingField.SetMarble();
						move.<Marble1>k__BackingField.SetNode(jackarooNode);
						jackarooNode.SetMarble(move.<Marble1>k__BackingField);
						List<JackarooMoveStep> jackarooMoveSteps = _jackarooMoveSteps;
						bool flag20 = _jackarooMoveSteps == null;
						gameAction = emote;
						action2 = null;
						action = (Action)(object)move.<Marble1>k__BackingField;
						if (!flag20)
						{
							int version = jackarooMoveSteps._version + 1;
							jackarooMoveSteps._size = 0;
							jackarooMoveSteps._version = version;
							bool flag21 = jackarooMoveSteps._size < 1;
							gameAction = emote;
							if (!flag21)
							{
								Array.Clear(jackarooMoveSteps._items, 0, jackarooMoveSteps._size);
								gameAction = (GameAction?)(object)0;
							}
							obj19 = typeof(SqlSingle[]) + 2376;
							jackarooMarble = (JackarooMarble)obj25;
							bool flag22 = obj25 == null;
							num4 = jackarooMoveSteps._size;
							gameAction3 = emote;
							if (flag22)
							{
								goto IL_0891;
							}
							Action unblockBaseAction = GetUnblockBaseAction((JackarooMarble)obj25);
							bool flag23 = <Board>k__BackingField == null;
							action2 = (Action)jackarooMoveSteps._size;
							action = (Action)obj25;
							if (!flag23)
							{
								JackarooBoard jackarooBoard = <Board>k__BackingField;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
								JackarooNode jackarooNode2 = jackarooBoard.MoveMarbleFromBoardToGraveyard((JackarooMarble)0);
								object obj26 = obj2 + 32;
								obj26 = jackarooNode2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								bool flag24 = <Board>k__BackingField == null;
								action2 = (Action)jackarooMoveSteps._size;
								action = (Action)(object)jackarooNode2;
								if (!flag24)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
									bool flag25 = (nint)0 == 0;
									action2 = (Action)jackarooMoveSteps._size;
									action = (Action)(object)jackarooNode2;
									if (!flag25)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
										((JackarooMarble)0).SetNode((JackarooNode)obj26);
										bool flag26 = obj26 == null;
										action2 = null;
										action = (Action)obj26;
										if (!flag26)
										{
											object obj27 = (nint)0 + (nint)1552;
											object obj28 = obj26;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
											((JackarooNode)obj28).SetMarble((JackarooMarble)0);
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											num4 = (nint)obj27;
											Action action8 = default(Action);
											action8..ctor(obj2, (IntPtr)obj27);
											object obj29 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 256;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
											object obj30 = default(object);
											obj30..ctor();
											object obj31 = obj30 + 16;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
											obj31 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj32 = obj30 + 24;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+20]");
											obj32 = 0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj33 = obj30 + 40;
											obj33 = action8;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											object obj34 = obj30 + 32;
											obj34 = unblockBaseAction;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											List<object> jackarooMoveSteps2 = (List<object>)(object)_jackarooMoveSteps;
											bool flag27 = _jackarooMoveSteps == null;
											gameAction = (GameAction?)(object)0;
											action2 = (Action)obj27;
											action = unblockBaseAction;
											if (!flag27)
											{
												object obj35 = (nint)0 + (nint)2376;
												object obj36 = obj35;
												int version2 = jackarooMoveSteps2._version + 1;
												jackarooMoveSteps2._version = version2;
												object[] items = jackarooMoveSteps2._items;
												bool flag28 = jackarooMoveSteps2._items == null;
												gameAction = (GameAction?)(object)0;
												action2 = (Action)obj27;
												action = unblockBaseAction;
												if (!flag28)
												{
													bool flag29 = jackarooMoveSteps2._size < items.Length;
													object obj37 = !flag29;
													obj19 = typeof(SqlSingle[]) + 2376;
													if (obj37 == null)
													{
														int size = jackarooMoveSteps2._size + 1;
														jackarooMoveSteps2._size = size;
														object obj38 = jackarooMoveSteps2._items + jackarooMoveSteps2._size;
														object obj39 = obj38 + 32;
														obj39 = obj30;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
														gameAction = (GameAction?)(object)0;
														jackarooMarble = (JackarooMarble)obj30;
														gameAction3 = emote;
														goto IL_0891;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X8_v33+20]");
													object obj40 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v731 @ X8_v34+C0]");
													object obj41 = 0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v35+70]");
													num4 = 0;
													((List<object>)(object)_jackarooMoveSteps).AddWithResize(obj30);
													jackarooNodeMono = jackarooNode.<NodeMono>k__BackingField;
													obj22 = typeof(RegisteredWaitHandle) + 56;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F84]");
													object obj42 = (nint)0 & (nint)1;
													bool flag30 = obj42 == null;
													object obj43 = !flag30;
													gameAction = (GameAction?)(object)0;
													jackarooMarble = (JackarooMarble)obj30;
													gameAction3 = emote;
													obj17 = obj22;
													obj20 = obj19;
													gameAction2 = (GameAction?)(object)0;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v732 @ X8_v35+70]");
													num3 = 0;
													obj21 = obj30;
													jackarooNodeMono2 = jackarooNode.<NodeMono>k__BackingField;
													gameAction4 = emote;
													if (obj43 != null)
													{
														goto IL_0922;
													}
													goto IL_0ada;
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_0e68;
		IL_0922:
		obj16 = obj22;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v42+E4]");
		bool flag31 = (nint)0 == 0;
		action4 = (Action)num4;
		action5 = (Action)(object)jackarooMarble;
		obj20 = obj19;
		gameAction2 = gameAction;
		action2 = (Action)num4;
		action = (Action)(object)jackarooMarble;
		jackarooNodeMono2 = jackarooNodeMono;
		gameAction4 = gameAction3;
		if (!flag31)
		{
			goto IL_098f;
		}
		goto IL_0b58;
		IL_0b58:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		current = RemoteConfig.Current;
		bool flag32 = current == null;
		obj19 = obj20;
		action4 = action2;
		action5 = action;
		jackarooNodeMono = jackarooNodeMono2;
		gameAction3 = gameAction4;
		gameAction = gameAction2;
		if (!flag32)
		{
			goto IL_0bbd;
		}
		goto IL_0e68;
	}

	private void Move(JackarooMove move, Action onComplete, GameAction? emote = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_012b: Expected I, but got O
		//IL_013b: Expected O, but got I
		//IL_066d: Expected I, but got O
		//IL_067d: Expected O, but got I
		//IL_0176: Expected O, but got I
		//IL_0201: Expected O, but got I
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d8: Expected O, but got Unknown
		//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_0189: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_03e3: Expected O, but got I
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_0425: Expected O, but got I4
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0263: Expected O, but got Unknown
		//IL_026c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0271: Expected O, but got Unknown
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_021d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0222: Expected O, but got Unknown
		//IL_04ec: Expected O, but got I
		//IL_0735: Expected O, but got I
		//IL_0735: Expected O, but got I
		//IL_0744: Unknown result type (might be due to invalid IL or missing references)
		//IL_0749: Expected O, but got Unknown
		//IL_04aa: Expected O, but got I
		//IL_031d: Expected O, but got I
		//IL_032e: Expected I, but got O
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_030c: Expected O, but got I4
		//IL_0513: Expected O, but got I
		//IL_0523: Expected O, but got I
		//IL_0545: Expected O, but got I4
		//IL_037f: Expected O, but got I
		//IL_038f: Expected O, but got I
		//IL_03b1: Expected O, but got I4
		//IL_060c: Expected O, but got I
		//IL_0575: Expected O, but got I4
		//IL_0767: Unknown result type (might be due to invalid IL or missing references)
		//IL_076c: Expected O, but got Unknown
		//IL_0782: Expected O, but got I
		//IL_0793: Expected I, but got O
		//IL_07b1: Expected O, but got I
		//IL_05a5: Expected O, but got I
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 320;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 48;
		Action action = default(Action);
		obj4 = action;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		<IsAnimating>k__BackingField = true;
		object obj5 = obj2 + 24;
		obj5 = move.<Marble1>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj5;
		IEnumerable<object> <Nodes>k__BackingField = move.<Nodes>k__BackingField;
		object obj7 = obj2 + 32;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v5+20]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = Enumerable.Last((IEnumerable<object>)move.<Nodes>k__BackingField);
		object obj9 = obj2 + 40;
		obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2264;
		nint num = (nint)<Nodes>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		object obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_01b7;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		object obj12 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X10_v12-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj12 += 16;
			obj11--;
			if ((nint)obj11 != 1)
			{
				continue;
			}
			goto IL_01b7;
		}
		object obj13 = num + obj12;
		object obj14 = obj13 + 312;
		goto IL_064e;
		IL_05aa:
		Func<object, object> selector;
		IEnumerable<object> source = Enumerable.Select(move.<Nodes>k__BackingField, selector);
		object[] nodes = Enumerable.ToArray(source);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
		float num2;
		Action action2 = default(Action);
		MoveMarble((JackarooMarble)0, num2, _moveClips, action2, _jackarooMoveSteps, 0, isPlant: false, emote, (JackarooNodeMono[])nodes);
		return;
		IL_0242:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		action = null;
		goto IL_06c6;
		IL_06c6:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v427 @ X0_v22] (should have been resolved before IL gen)");
		float durationForNodes;
		object obj15 = default(object);
		num2 = durationForNodes / (float)obj15;
		object obj18;
		object obj20;
		if (move.<Action>k__BackingField == JackarooActions.MOVE_EAT_PATH)
		{
			List<JackarooMoveStep> jackarooMoveSteps = _jackarooMoveSteps;
			int version = jackarooMoveSteps._version + 1;
			jackarooMoveSteps._size = 0;
			jackarooMoveSteps._version = version;
			bool flag = jackarooMoveSteps._size < 1;
			GameAction? gameAction = emote;
			if (!flag)
			{
				Array.Clear(jackarooMoveSteps._items, 0, jackarooMoveSteps._size);
				jackarooMoveSteps = _jackarooMoveSteps;
				gameAction = (GameAction?)(object)0;
			}
			HandleEatPathMove(move.<Nodes>k__BackingField, jackarooMoveSteps);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v3 (System.Object)+28]");
			OnPreMove((JackarooMarble)num3, (JackarooNode)0);
			object obj16 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj17 = (nint)0 + (nint)1568;
			action2..ctor(obj2, (IntPtr)obj17);
			obj18 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 304;
			object obj19 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v46+E4]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v46+B8]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v31+10]");
				selector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v31+10]");
				bool flag2 = (nint)0 == 0;
				object obj21 = !flag2;
				if (obj21 == null)
				{
					goto IL_0553;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj19 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v46+B8]");
				obj20 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v31+10]");
				selector = (Func<object, object>)0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v31+10]");
				bool flag3 = (nint)0 == 0;
				object obj22 = !flag3;
				if (obj22 == null)
				{
					goto IL_0553;
				}
			}
			goto IL_05aa;
		}
		object obj23 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v14+20]");
		JackarooNode graveyardNode = HandleMarbleDeath((JackarooMarble)0);
		object obj24 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 208;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X0_v28+E4]");
		bool flag4 = (nint)0 == 0;
		object obj26 = !flag4;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		if (JackarooGame.IsASplit(move.<Action>k__BackingField))
		{
			object onComplete2 = obj4;
			object marble = obj5;
			IReadOnlyList<JackarooNode> <Nodes>k__BackingField2 = move.<Nodes>k__BackingField;
			object startNode = obj7;
			object lastNode = obj9;
			AudioClip[] moveClips = _moveClips;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v14+20]");
			HandleSplitMove(move, (Action)onComplete2, (JackarooMarble)marble, <Nodes>k__BackingField2, (JackarooNode)startNode, (JackarooNode)lastNode, num2, moveClips, (JackarooMarble)0, graveyardNode);
		}
		else
		{
			object onComplete3 = obj4;
			object marble2 = obj5;
			IReadOnlyList<JackarooNode> <Nodes>k__BackingField3 = move.<Nodes>k__BackingField;
			object startNode2 = obj7;
			object lastNode2 = obj9;
			AudioClip[] moveClips2 = _moveClips;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v156 @ X8_v14+20]");
			HandleSingleMove((Action)onComplete3, (JackarooMarble)marble2, <Nodes>k__BackingField3, (JackarooNode)startNode2, (JackarooNode)lastNode2, num2, moveClips2, (JackarooMarble)0, graveyardNode, emote);
		}
		return;
		IL_0553:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X0_v46+E4]");
		bool flag5 = (nint)0 == 0;
		object obj27 = !flag5;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj28 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X8_v37+B8]");
			obj20 = 0;
		}
		object obj29 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2120;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj30 = (nint)0 + (nint)1520;
		Func<object, object> func = default(Func<object, object>);
		func..ctor(obj20, (IntPtr)obj30);
		object obj31 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v36+B8]");
		object obj32 = (nint)0 + (nint)16;
		obj32 = func;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		selector = func;
		goto IL_05aa;
		IL_01b7:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		action = null;
		goto IL_064e;
		IL_064e:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v352 @ X0_v19] (should have been resolved before IL gen)");
		int nodesCount = default(int);
		durationForNodes = GetDurationForNodes(nodesCount);
		nint num4 = (nint)<Nodes>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v9 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		object obj33 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v9 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0242;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v361 @ X8_v9 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
		object obj34 = (nint)0 + (nint)8;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v403 @ X10_v7-8]");
			if (0 == (nint)obj10)
			{
				break;
			}
			obj34 += 16;
			obj33--;
			if ((nint)obj33 != 1)
			{
				continue;
			}
			goto IL_0242;
		}
		object obj35 = num4 + obj34;
		object obj36 = obj35 + 312;
		goto IL_06c6;
	}

	private void Swap(JackarooMove move, Action onComplete)
	{
		JackarooMarble <Marble1>k__BackingField = move.<Marble1>k__BackingField;
		JackarooMarble <Marble2>k__BackingField = move.<Marble2>k__BackingField;
		<IsAnimating>k__BackingField = true;
		CheckMarbleUnblockedBase(move.<Marble1>k__BackingField);
		CheckMarbleUnblockedBase(move.<Marble2>k__BackingField);
		move.<Marble1>k__BackingField.SetNode(<Marble2>k__BackingField.<Node>k__BackingField);
		<Marble2>k__BackingField.<Node>k__BackingField.SetMarble(move.<Marble1>k__BackingField);
		move.<Marble2>k__BackingField.SetNode(<Marble1>k__BackingField.<Node>k__BackingField);
		<Marble1>k__BackingField.<Node>k__BackingField.SetMarble(move.<Marble2>k__BackingField);
		if (_swapAtSameTime)
		{
			SwapSimultaneous(move.<Marble1>k__BackingField, <Marble2>k__BackingField.<Node>k__BackingField, move.<Marble2>k__BackingField, <Marble1>k__BackingField.<Node>k__BackingField, onComplete);
		}
		else
		{
			SwapSequential(move.<Marble1>k__BackingField, <Marble2>k__BackingField.<Node>k__BackingField, move.<Marble2>k__BackingField, <Marble1>k__BackingField.<Node>k__BackingField, onComplete);
		}
	}

	private void HandleEatPathMove(IReadOnlyList<JackarooNode> nodes, List<JackarooMoveStep> jackarooMoveSteps)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_002a: Expected O, but got I4
		//IL_07bc: Expected I, but got O
		//IL_07cc: Expected O, but got I
		//IL_010d: Expected O, but got I
		//IL_01a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a5: Expected O, but got Unknown
		//IL_00b2: Expected O, but got I
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cb: Expected O, but got Unknown
		//IL_01e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ee: Expected O, but got Unknown
		//IL_01f6: Expected I, but got O
		//IL_0206: Expected O, but got I
		//IL_02c0: Expected O, but got I4
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		//IL_0153: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_0168: Expected O, but got I
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_0241: Expected O, but got I
		//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d3: Expected O, but got Unknown
		//IL_045a: Expected O, but got I
		//IL_04b4: Expected O, but got I4
		//IL_02db: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e0: Expected O, but got Unknown
		//IL_02e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ee: Expected O, but got Unknown
		//IL_077a: Expected O, but got I
		//IL_078a: Expected O, but got I
		//IL_079a: Expected O, but got I
		//IL_0379: Expected O, but got I
		//IL_0386: Unknown result type (might be due to invalid IL or missing references)
		//IL_038b: Expected O, but got Unknown
		//IL_024f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_025d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0262: Expected O, but got Unknown
		//IL_04ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_04fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0502: Expected O, but got Unknown
		//IL_050b: Expected O, but got I4
		//IL_03aa: Expected I, but got O
		//IL_03ba: Expected O, but got I
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_08a6: Expected O, but got I
		//IL_0870: Unknown result type (might be due to invalid IL or missing references)
		//IL_0875: Expected O, but got Unknown
		//IL_03f5: Expected O, but got I
		//IL_054f: Expected O, but got I4
		//IL_051d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0522: Expected O, but got Unknown
		//IL_052b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_059f: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a4: Expected O, but got Unknown
		//IL_0403: Unknown result type (might be due to invalid IL or missing references)
		//IL_0408: Expected O, but got Unknown
		//IL_0411: Unknown result type (might be due to invalid IL or missing references)
		//IL_0416: Expected O, but got Unknown
		//IL_05bf: Expected O, but got I
		//IL_05c7: Expected I, but got O
		//IL_05d8: Expected I, but got O
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ec: Expected O, but got Unknown
		//IL_060d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0612: Expected O, but got Unknown
		//IL_0622: Expected O, but got I
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_063f: Expected O, but got Unknown
		//IL_064f: Expected O, but got I
		//IL_0662: Unknown result type (might be due to invalid IL or missing references)
		//IL_0667: Expected O, but got Unknown
		//IL_0687: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_06af: Expected O, but got I
		//IL_0709: Expected O, but got I4
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_007c: Expected I, but got O
		//IL_0730: Expected O, but got I
		//IL_0740: Expected O, but got I
		//IL_0750: Expected O, but got I
		//IL_0755: Expected I, but got O
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2264;
		List<JackarooMoveStep> list = jackarooMoveSteps;
		object obj2 = 0;
		object obj8 = default(object);
		object obj10 = default(object);
		JackarooNode jackarooNode = default(JackarooNode);
		object obj25 = default(object);
		Action action = default(Action);
		object obj30 = default(object);
		object obj42 = default(object);
		while (true)
		{
			nint num = (nint)nodes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v5 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			object obj3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v5 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_00f3;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X8_v5 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
			object obj4 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X10_v25-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj4 += 16;
				obj3--;
				if ((nint)obj3 != 1)
				{
					continue;
				}
				goto IL_00f3;
			}
			object obj5 = num + obj4;
			object obj6 = obj5 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X0_v68+8]");
			object obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v411 @ X0_v68] (should have been resolved before IL gen)");
			if (obj2 < obj8)
			{
				goto IL_0191;
			}
			return;
			IL_030d:
			object obj9 = obj10 + 16;
			obj9 = jackarooNode.<Marble>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Action unblockBaseAction;
			object obj11;
			if (obj9 != null)
			{
				unblockBaseAction = GetUnblockBaseAction((JackarooMarble)obj9);
				JackarooBoard jackarooBoard = <Board>k__BackingField;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v8 (System.Object)+10]");
				JackarooNode jackarooNode2 = jackarooBoard.MoveMarbleFromBoardToGraveyard((JackarooMarble)0);
				obj11 = obj10 + 24;
				obj11 = jackarooNode2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				nint num2 = (nint)nodes;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v22 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
				object obj12 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v22 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0436;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v22 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
				object obj13 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v625 @ X10_v14-8]");
					if (0 == (nint)obj)
					{
						break;
					}
					obj13 += 16;
					obj12--;
					if ((nint)obj12 != 1)
					{
						continue;
					}
					goto IL_0436;
				}
				object obj14 = num2 + obj13;
				object obj15 = obj14 + 312;
				goto IL_085d;
			}
			object obj16 = (nint)0 + (nint)2376;
			object obj17 = obj16;
			int version = jackarooMoveSteps._version + 1;
			jackarooMoveSteps._version = version;
			JackarooMoveStep[] items = jackarooMoveSteps._items;
			bool flag = jackarooMoveSteps._size < items.Length;
			object obj18 = !flag;
			if (obj18 == null)
			{
				int size = jackarooMoveSteps._size + 1;
				jackarooMoveSteps._size = size;
				object obj19 = items + jackarooMoveSteps._size;
				object obj20 = obj19 + 32;
				obj20 = 0;
				object obj21 = null;
				goto IL_0894;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v220 @ X8_v18+20]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X8_v19+C0]");
			object obj23 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v20+70]");
			list = (List<JackarooMoveStep>)0;
			object item = null;
			List<object> list2 = (List<object>)(object)jackarooMoveSteps;
			goto IL_08ab;
			IL_085d:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v649 @ X0_v27] (should have been resolved before IL gen)");
			object obj24 = obj25 - 1;
			if (obj2 == obj24)
			{
				bool flag2 = obj9 == null;
				object obj26 = !flag2;
				if (obj26 == null)
				{
					break;
				}
			}
			else
			{
				jackarooNode.SetMarble();
			}
			((JackarooMarble)obj9).SetNode((JackarooNode)obj11);
			((JackarooNode)obj11).SetMarble((JackarooMarble)obj9);
			object obj27 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj28 = (nint)0 + (nint)1576;
			nint num3 = (nint)obj28;
			action..ctor(obj10, (IntPtr)obj28);
			object obj29 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 256;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj30..ctor();
			object obj31 = obj30 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v8 (System.Object)+10]");
			obj31 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj32 = obj30 + 24;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v8 (System.Object)+18]");
			obj32 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj33 = obj30 + 40;
			obj33 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj34 = obj30 + 32;
			obj34 = unblockBaseAction;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj35 = (nint)0 + (nint)2376;
			object obj36 = obj35;
			int version2 = jackarooMoveSteps._version + 1;
			jackarooMoveSteps._version = version2;
			JackarooMoveStep[] items2 = jackarooMoveSteps._items;
			bool flag3 = jackarooMoveSteps._size < items2.Length;
			object obj37 = !flag3;
			object obj38 = ~obj37;
			nint num4;
			if (obj38 != null)
			{
				int size2 = jackarooMoveSteps._size + 1;
				jackarooMoveSteps._size = size2;
				object obj39 = items2 + jackarooMoveSteps._size;
				object obj20 = obj39 + 32;
				obj20 = obj30;
				num4 = unchecked((nint)null);
				object obj21 = obj30;
				goto IL_0894;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v223 @ X8_v34+20]");
			object obj40 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v692 @ X8_v35+C0]");
			object obj41 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v584 @ X8_v36+70]");
			list = (List<JackarooMoveStep>)0;
			num4 = unchecked((nint)null);
			item = obj30;
			list2 = (List<object>)(object)jackarooMoveSteps;
			goto IL_08ab;
			IL_08ab:
			list2.AddWithResize(item);
			goto IL_0089;
			IL_00f3:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v307 @ X0_v65+8]");
			obj7 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v307 @ X0_v65] (should have been resolved before IL gen)");
			bool flag4 = obj2 < obj42;
			list = null;
			if (!flag4)
			{
				return;
			}
			goto IL_0191;
			IL_0191:
			object obj43 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 328;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj10..ctor();
			object obj44 = obj10 + 32;
			obj44 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj45 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
			nint num5 = (nint)nodes;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			object obj46 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0282;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X8_v12 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
			object obj47 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X10_v20-8]");
				if (0 == (nint)obj45)
				{
					break;
				}
				obj47 += 16;
				obj46--;
				if ((nint)obj46 != 1)
				{
					continue;
				}
				goto IL_0282;
			}
			object obj48 = num5 + obj47;
			object obj49 = obj48 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v61+8]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v474 @ X0_v61] (should have been resolved before IL gen)");
			goto IL_030d;
			IL_0089:
			obj2++;
			continue;
			IL_0894:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			list = (List<JackarooMoveStep>)num3;
			goto IL_0089;
			IL_0436:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num3 = 0;
			goto IL_085d;
			IL_0282:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X0_v58+8]");
			num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v458 @ X0_v58] (should have been resolved before IL gen)");
			bool flag5 = jackarooNode == null;
			object obj50 = !flag5;
			if (obj50 == null)
			{
				break;
			}
			goto IL_030d;
		}
		throw new NullReferenceException();
	}

	private unsafe void HandleSplitMove(JackarooMove move, Action onComplete, JackarooMarble marble1, IReadOnlyList<JackarooNode> nodes1, JackarooNode startNode1, JackarooNode lastNode1, float duration1, AudioClip[] audioClips1, JackarooMarble marble1ToDie, JackarooNode graveyardNode1)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0071: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00c6: Expected O, but got I
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_00ee: Expected O, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0139: Unknown result type (might be due to invalid IL or missing references)
		//IL_013e: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_019b: Expected O, but got Unknown
		//IL_01ab: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dd: Expected O, but got Unknown
		//IL_020b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0210: Expected O, but got Unknown
		//IL_021c: Expected O, but got I
		//IL_022b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_024e: Expected O, but got I
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0279: Expected O, but got Unknown
		//IL_02d2: Expected I, but got O
		//IL_0301: Expected O, but got I4
		//IL_03ec: Expected O, but got I
		//IL_03fc: Expected O, but got I
		//IL_041e: Expected O, but got I4
		//IL_03c1: Expected O, but got I4
		//IL_03c1: Expected O, but got I
		//IL_0348: Expected O, but got I4
		//IL_043b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0456: Expected O, but got I
		//IL_0467: Expected I, but got O
		//IL_0485: Expected O, but got I
		//IL_0378: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 336;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = obj4 + 16;
		obj5 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj4 + 24;
		obj6 = marble1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj4 + 32;
		obj7 = startNode1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj4 + 40;
		obj8 = lastNode1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj4 + 48;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X29_v1+10]");
		obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj4 + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X29_v1+18]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = obj4 + 112;
		obj11 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		OnPreMove((JackarooMarble)obj6, (JackarooNode)obj8);
		object obj12 = obj4 + 72;
		obj12 = move.<Marble2>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj13 = obj4 + 64;
		obj13 = move.<Nodes2>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj14 = obj12;
		object obj15 = obj4 + 88;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X8_v4+20]");
		obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Object)+40]");
		object obj16 = Enumerable.Last((IEnumerable<object>)0);
		object obj17 = obj4 + 80;
		obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj18 = obj17;
		object obj19 = typeof(SqlSingle[]) + 2376;
		object obj20 = (nint)0 + (nint)1584;
		object obj21 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 304;
		object obj22 = obj4 + 96;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X8_v5+20]");
		obj22 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		JackarooNode jackarooNode = HandleMarbleDeath((JackarooMarble)obj22);
		object obj23 = obj4 + 104;
		obj23 = jackarooNode;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (obj22 != null)
		{
			ShowMarbleDeathAnimation((JackarooMarble)obj22);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action action = default(Action);
		action..ctor(obj4, (IntPtr)obj20);
		object obj24 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v49+E4]");
		bool flag = (nint)0 == 0;
		object obj25 = !flag;
		if (obj25 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj24 = obj21;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v49+B8]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v9+20]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v296 @ X8_v9+20]");
		bool flag2 = (nint)0 == 0;
		object obj27 = !flag2;
		if (obj27 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X0_v49+E4]");
			bool flag3 = (nint)0 == 0;
			object obj28 = !flag3;
			if (obj28 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj29 = obj21;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v302 @ X8_v15+B8]");
				obj26 = 0;
			}
			object obj30 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj31 = (nint)0 + (nint)1488;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj26, (IntPtr)obj31);
			object obj32 = obj21;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X8_v14+B8]");
			object obj33 = (nint)0 + (nint)32;
			obj33 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(nodes1, selector);
		object[] array = Enumerable.ToArray(source);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v3 (System.Object)+18]");
		MoveMarble((JackarooMarble)0, duration1, audioClips1, action, null, 0, isPlant: false, (GameAction?)(object)0, (JackarooNodeMono[])(object)marble1ToDie);
	}

	private unsafe void HandleSingleMove(Action onComplete, JackarooMarble marble1, IReadOnlyList<JackarooNode> nodes1, JackarooNode startNode1, JackarooNode lastNode1, float duration1, AudioClip[] audioClips1, JackarooMarble marble1ToDie, JackarooNode graveyardNode1, GameAction? emote = null)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Expected O, but got Unknown
		//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ea: Expected O, but got Unknown
		//IL_00fa: Expected O, but got I
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_0117: Expected O, but got Unknown
		//IL_014b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0150: Expected O, but got Unknown
		//IL_0166: Expected O, but got I
		//IL_0177: Expected I, but got O
		//IL_01a6: Expected O, but got I4
		//IL_02a6: Expected O, but got I
		//IL_02b6: Expected O, but got I
		//IL_02d8: Expected O, but got I4
		//IL_027b: Expected O, but got I
		//IL_01ed: Expected O, but got I4
		//IL_02f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fa: Expected O, but got Unknown
		//IL_0310: Expected O, but got I
		//IL_0321: Expected I, but got O
		//IL_033f: Expected O, but got I
		//IL_021d: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj5 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 304;
		object obj6 = obj4 + 16;
		obj6 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj7 = obj4 + 24;
		obj7 = marble1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = obj4 + 32;
		obj8 = startNode1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj9 = obj4 + 40;
		obj9 = lastNode1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj10 = obj4 + 48;
		obj10 = marble1ToDie;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj11 = obj4 + 56;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X29_v1+10]");
		obj11 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj12 = obj4 + 64;
		obj12 = onComplete;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		OnPreMove((JackarooMarble)obj7, (JackarooNode)obj9);
		object obj13 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1600;
		Action action = default(Action);
		action..ctor(obj4, (IntPtr)obj14);
		object obj15 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v29+E4]");
		bool flag = (nint)0 == 0;
		object obj16 = !flag;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj15 = obj5;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v29+B8]");
		object obj17 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v12+28]");
		Func<object, object> selector = (Func<object, object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v12+28]");
		bool flag2 = (nint)0 == 0;
		object obj18 = !flag2;
		if (obj18 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X0_v29+E4]");
			bool flag3 = (nint)0 == 0;
			object obj19 = !flag3;
			if (obj19 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj20 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X8_v18+B8]");
				obj17 = 0;
			}
			object obj21 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2120;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj22 = (nint)0 + (nint)1480;
			Func<object, object> func = default(Func<object, object>);
			func..ctor(obj17, (IntPtr)obj22);
			object obj23 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v247 @ X8_v17+B8]");
			object obj24 = (nint)0 + (nint)40;
			obj24 = func;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			selector = func;
		}
		IEnumerable<object> source = Enumerable.Select(nodes1, selector);
		object[] array = Enumerable.ToArray(source);
		object marble2 = obj7;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X29_v1+18]");
		MoveMarble((JackarooMarble)marble2, duration1, audioClips1, action, null, 0, isPlant: false, (GameAction?)(object)0, (JackarooNodeMono[])(object)graveyardNode1);
	}

	private unsafe void MoveMarble(JackarooMarble marble, float duration, AudioClip[] audioClips, Action onCompleteAction = null, List<JackarooMoveStep> moveSteps = null, int index = 0, bool isPlant = false, GameAction? emote = null, JackarooNodeMono[] nodes)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Expected O, but got Unknown
		//IL_00a6: Expected O, but got I
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Expected O, but got Unknown
		//IL_00de: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_012e: Expected O, but got I4
		//IL_0213: Expected O, but got I4
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0254: Expected O, but got I
		//IL_0267: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_0275: Expected O, but got I4
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_0195: Expected O, but got I4
		//IL_02d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Expected O, but got Unknown
		//IL_03d0: Expected O, but got I
		//IL_03ea: Expected O, but got I4
		//IL_01a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a8: Expected O, but got Unknown
		//IL_01b9: Expected O, but got I
		//IL_0319: Expected O, but got I
		//IL_0724: Expected O, but got I
		//IL_073e: Expected O, but got I4
		//IL_0747: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_0766: Expected O, but got I4
		//IL_0460: Expected O, but got I
		//IL_0428: Expected O, but got I4
		//IL_0916: Expected F4, but got I
		//IL_093f: Expected F4, but got I
		//IL_093f: Expected O, but got I
		//IL_093f: Expected O, but got I
		//IL_0953: Expected O, but got I
		//IL_0968: Expected I4, but got O
		//IL_0978: Expected O, but got I
		//IL_098b: Expected O, but got I4
		//IL_037b: Expected O, but got I
		//IL_039d: Expected O, but got I4
		//IL_099c: Expected O, but got I
		//IL_049a: Expected O, but got I
		//IL_04ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b2: Expected O, but got Unknown
		//IL_09d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d7: Expected O, but got Unknown
		//IL_09e3: Expected O, but got I
		//IL_09ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f1: Expected O, but got Unknown
		//IL_0a0c: Expected I, but got O
		//IL_07cf: Expected O, but got I
		//IL_055e: Expected O, but got I4
		//IL_0502: Expected O, but got I4
		//IL_0a96: Expected O, but got I4
		//IL_0521: Expected O, but got I4
		//IL_0864: Expected F4, but got I
		//IL_0864: Expected O, but got I4
		//IL_0864: Expected O, but got I
		//IL_0878: Expected O, but got I
		//IL_088d: Expected I4, but got O
		//IL_089d: Expected F4, but got I
		//IL_08ad: Expected O, but got I
		//IL_05cc: Expected O, but got I
		//IL_05d6: Expected I4, but got O
		//IL_05de: Expected I, but got O
		//IL_062c: Expected O, but got I
		//IL_062c: Expected F4, but got I
		//IL_062c: Expected O, but got I
		//IL_0659: Expected O, but got I4
		//IL_0669: Expected O, but got I
		//IL_0673: Expected I4, but got O
		//IL_0680: Expected I4, but got O
		//IL_0690: Expected F4, but got I
		//IL_06a0: Expected O, but got I
		//IL_06ba: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj4 = default(object);
		obj4..ctor();
		object obj8;
		object obj10;
		object obj11;
		if (obj4 != null)
		{
			object obj5 = obj4 + 24;
			List<JackarooMoveStep> list = default(List<JackarooMoveStep>);
			obj5 = list;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj4 + 56;
			obj6 = audioClips;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj4 + 64;
			obj7 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj8 = obj4 + 72;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1+10]");
			obj8 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = obj4 + 80;
			Action action = default(Action);
			obj9 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj10 = obj4 + 88;
			obj10 = marble;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj11 = obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+20]");
			bool flag = (nint)0 == 0;
			object obj12 = !flag;
			if (obj12 != null)
			{
				goto IL_0ae0;
			}
			if (obj8 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X23_v6+18]");
				if ((nint)0 < (nint)1)
				{
					goto IL_01ea;
				}
				object obj13 = obj8 + 32;
				object obj14 = 0;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X26_v16+v259 @ X24_v12*8]");
					if ((nint)0 == 0)
					{
						break;
					}
					obj14++;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v274 @ X26_v16+v259 @ X24_v12*8]");
					((JackarooNodeMono)0).SetSelectedColor();
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X23_v6+18]");
					if ((nint)obj15 < 0)
					{
						continue;
					}
					goto IL_01dd;
				}
			}
		}
		goto IL_0a9b;
		IL_056c:
		ICustomMarbleMove customMarbleMove;
		CardGameVisualControls visualControls = default(CardGameVisualControls);
		Vector3 vector;
		bool flag2;
		if ((object)customMarbleMove != null)
		{
			_ = customMarbleMove.<UseDefaultSound>k__BackingField;
			visualControls = _visualControls;
			if ((object)_visualControls != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+48]");
				vector = (Vector3)0;
				flag2 = (byte)(int)_effectsLayer != 0;
				nint num = (nint)customMarbleMove;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+58]");
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+60]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+48]");
				nint num4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+20]");
				(Sequence, bool, AudioClip, Action<JackarooMarble, JackarooNode>, AudioClip) tuple = customMarbleMove.Move((JackarooMarble)num2, num3, (JackarooNodeMono[])num4, 0, _boardTransform, visualControls.playGround, _effectsLayer);
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				Sequence sequence = default(Sequence);
				bool flag3 = sequence == null;
				object obj16 = !flag3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v25 (Il2CppClass<ICustomMarbleMove>)+180]");
				GameAction? gameAction = (GameAction?)(object)0;
				bool flag4 = (byte)(int)_effectsLayer != 0;
				int num5 = (int)visualControls.playGround;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+60]");
				float num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+20]");
				Action action2 = (Action)0;
				List<JackarooMoveStep> boardTransform = (List<JackarooMoveStep>)(object)_boardTransform;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+48]");
				Vector3 vector2 = (Vector3)0;
				Sequence sequence2 = sequence;
				if (obj16 == null)
				{
					goto IL_06d0;
				}
				goto IL_0990;
			}
		}
		goto IL_0a9b;
		IL_0336:
		object obj18;
		object obj17 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v76+E4]");
		bool flag5 = (nint)0 == 0;
		object obj19 = obj17;
		if (!flag5)
		{
			goto IL_036b;
		}
		goto IL_043e;
		IL_043e:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj20 = obj18;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v574 @ X0_v68+B8]");
		object obj21 = 0;
		AnimatedItemController animatedItemController = (AnimatedItemController)obj21;
		if (obj21 != null)
		{
			goto IL_0485;
		}
		goto IL_0a9b;
		IL_036b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v76+B8]");
		object obj22 = 0;
		animatedItemController = (AnimatedItemController)obj22;
		bool flag6 = obj22 == null;
		object obj23 = !flag6;
		if (obj23 != null)
		{
			goto IL_0485;
		}
		goto IL_0a9b;
		IL_0485:
		AnimatedItemController animatedItemController2 = animatedItemController;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+64]");
		customMarbleMove = animatedItemController2.CreateCustomMarbleAnimation((GameAction?)(object)0);
		object obj24 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj25 = obj24;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X0_v54+E4]");
		if ((nint)0 != 0)
		{
			bool flag7 = customMarbleMove;
			bool flag8 = !flag7;
			object obj26 = !flag8;
			if (obj26 != null)
			{
				goto IL_056c;
			}
			flag2 = isPlant;
			vector = (Vector3)0;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag9 = customMarbleMove;
			bool flag10 = !flag9;
			flag2 = isPlant;
			vector = (Vector3)0;
			if (!flag10)
			{
				goto IL_056c;
			}
		}
		goto IL_06d0;
		IL_0aa9:
		throw new IndexOutOfRangeException();
		IL_01dd:
		obj11 = obj8;
		goto IL_0ae0;
		IL_0ae0:
		if (obj11 != null)
		{
			goto IL_01ea;
		}
		goto IL_0a9b;
		IL_01ea:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+20]");
		nint num7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X23_v6+18]");
		bool flag11 = num7 < 0;
		object obj27 = !flag11;
		object obj30;
		if (obj27 == null)
		{
			object obj28 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+20]");
			object obj29 = obj28 + 0;
			obj30 = obj4 + 16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v9+20]");
			obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj31 = obj4 + 40;
			obj31 = 0;
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v260 @ X24_v7+3C]");
			bool flag12 = (nint)0 != 1;
			flag2 = isPlant;
			vector = (Vector3)audioClips;
			if (!flag12)
			{
				obj18 = typeof(SqlSingle[]) + 3832;
				object obj32 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X0_v51+E4]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
					object obj33 = (nint)0 & (nint)1;
					if (obj33 != null)
					{
						goto IL_0336;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
					object obj34 = (nint)0 & (nint)1;
					bool flag13 = obj34 == null;
					object obj35 = !flag13;
					if (obj35 != null)
					{
						goto IL_0336;
					}
				}
				_ = 1;
				obj17 = obj18;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v551 @ X0_v76+E4]");
				bool flag14 = (nint)0 == 0;
				object obj36 = !flag14;
				obj19 = obj17;
				if (obj36 != null)
				{
					goto IL_036b;
				}
				goto IL_043e;
			}
			goto IL_06d0;
		}
		goto IL_0aa9;
		IL_06d0:
		object obj37 = obj10;
		if (isPlant)
		{
			if (obj10 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+10]");
				object obj38 = -1;
				bool flag15 = (nint)obj38 < 3;
				object obj39 = !flag15;
				object obj40 = obj38 - 3;
				bool flag16 = obj40 == null;
				object obj41 = !flag16;
				object obj42 = obj39 & obj41;
				if (obj42 == null)
				{
					object obj43 = obj38 << 3;
					object obj44 = (object)this + obj43;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X9_v14+40]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v141 @ X9_v14+40]");
						Vector3 position = ((Transform)0).position;
						if (obj30 != null)
						{
							Vector3 position2 = ((JackarooNodeMono)obj30).Position;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+18]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+60]");
								double num8 = 0.0 * 0.5;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+18]");
								nint num9 = 0;
								Vector3 homePosition = vector;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+60]");
								Sequence sequence2 = ((JackarooMarbleMono)num9).Plant((Vector3)0, homePosition, 0f);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v25 (Il2CppClass<ICustomMarbleMove>)+180]");
								GameAction? gameAction = (GameAction?)(object)0;
								bool flag4 = flag2;
								int num5 = (int)visualControls.playGround;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+60]");
								float num6 = 0f;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+20]");
								Action action2 = (Action)0;
								List<JackarooMoveStep> boardTransform = (List<JackarooMoveStep>)(object)_boardTransform;
								Vector3 vector2 = vector;
								goto IL_0990;
							}
						}
					}
				}
			}
		}
		else if (obj10 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+60]");
				float num6 = 0f;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X8_v17+18]");
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+10]");
				nint num11 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+60]");
				Sequence sequence2 = ((JackarooMarbleMono)num10).Move((JackarooNodeMono)num11, 0f);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v619 @ X8_v25 (Il2CppClass<ICustomMarbleMove>)+180]");
				GameAction? gameAction = (GameAction?)(object)0;
				bool flag4 = flag2;
				int num5 = (int)visualControls.playGround;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v3 (System.Object)+20]");
				Action action2 = (Action)0;
				List<JackarooMoveStep> boardTransform = (List<JackarooMoveStep>)(object)_boardTransform;
				Vector3 vector2 = (Vector3)0;
				goto IL_0990;
			}
		}
		goto IL_0a9b;
		IL_0990:
		object obj45 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		object obj46 = default(object);
		if (obj46 == null)
		{
			goto IL_0a9b;
		}
		object obj47 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj48 = (nint)0 + (nint)1608;
		object a = obj46 + 128;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj4, (IntPtr)obj48);
		Delegate obj49 = Delegate.Combine((Delegate)a, tweenCallback);
		if ((object)obj49 != null)
		{
			if (obj49 == obj47)
			{
				a = obj49;
				if (obj49 == obj47)
				{
					goto IL_0b22;
				}
			}
			throw new InvalidCastException();
		}
		a = 0;
		goto IL_0b22;
		IL_0b22:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0a9b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0aa9;
	}

	private void SwapSimultaneous(JackarooMarble marble1, JackarooNode node2, JackarooMarble marble2, JackarooNode node1, Action onComplete)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b4: Expected O, but got Unknown
		//IL_00ca: Expected O, but got I
		//IL_0192: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0254: Expected O, but got I
		//IL_026f: Expected I, but got O
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02f9: Expected O, but got I4
		//IL_0324: Expected O, but got I4
		//IL_033a: Expected I, but got O
		//IL_034a: Expected O, but got I
		//IL_0388: Expected O, but got I
		//IL_03db: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_043c: Expected O, but got I4
		//IL_0457: Expected O, but got I
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_0537: Expected O, but got Unknown
		//IL_0561: Expected O, but got I4
		//IL_04d8: Expected O, but got I4
		//IL_0483: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_0600: Expected O, but got I4
		//IL_0605: Expected I, but got O
		//IL_04ef: Expected O, but got I4
		//IL_04f4: Expected I, but got O
		//IL_059f: Expected O, but got I4
		//IL_05a4: Expected I, but got O
		//IL_0643: Expected O, but got I
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_0672: Expected I, but got O
		//IL_068f: Expected O, but got I4
		//IL_0694: Expected I, but got O
		//IL_06d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d5: Expected O, but got Unknown
		//IL_06f7: Expected O, but got I4
		//IL_06fc: Expected I, but got O
		//IL_071c: Expected O, but got I4
		//IL_0747: Expected O, but got I4
		//IL_07e3: Expected O, but got I4
		//IL_07e8: Expected I, but got O
		//IL_075d: Expected I, but got O
		//IL_076d: Expected O, but got I
		//IL_078f: Expected O, but got I4
		//IL_0794: Expected I, but got O
		//IL_07bb: Expected O, but got I
		//IL_081e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0823: Expected O, but got Unknown
		//IL_087f: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 360;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		JackarooNode jackarooNode = node1;
		JackarooNode jackarooNode2 = node2;
		object obj3 = null;
		object obj5;
		object obj6;
		RemoteConfigModel current;
		Action action = default(Action);
		JackarooMarble jackarooMarble = default(JackarooMarble);
		if (!flag)
		{
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj5 = obj2 + 24;
			obj5 = marble1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj6 = obj2 + 32;
			obj6 = jackarooMarble;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 40;
			obj7 = action;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F84]");
			object obj9 = (nint)0 & (nint)1;
			if (obj9 != null)
			{
				object obj10 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v57+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0114;
				}
			}
			else
			{
				_ = 1;
				object obj10 = obj8;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X0_v57+E4]");
				bool flag2 = (nint)0 == 0;
				object obj11 = !flag2;
				if (obj11 != null)
				{
					goto IL_0114;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current = RemoteConfig.Current;
			bool flag3 = current == null;
			jackarooNode = node1;
			jackarooNode2 = node2;
			obj3 = action;
			if (!flag3)
			{
				goto IL_01ed;
			}
		}
		goto IL_0885;
		IL_08a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_04b5:
		RemoteConfigModel current2 = RemoteConfig.Current;
		bool flag4 = current2 == null;
		object obj12 = !flag4;
		if (obj12 != null)
		{
			goto IL_05d6;
		}
		GameAction? gameAction = (GameAction?)(object)0;
		nint num = unchecked((nint)null);
		action = null;
		jackarooNode = null;
		Action action2 = default(Action);
		jackarooMarble = (JackarooMarble)(object)action2;
		jackarooNode2 = (JackarooNode)(object)_moveClips;
		obj3 = obj5;
		goto IL_0885;
		IL_05d6:
		JackarooConfig <Jackaroo>k__BackingField = current2.<Jackaroo>k__BackingField;
		bool flag5 = current2.<Jackaroo>k__BackingField == null;
		gameAction = (GameAction?)(object)0;
		num = unchecked((nint)null);
		action = null;
		jackarooNode = null;
		jackarooMarble = (JackarooMarble)(object)action2;
		jackarooNode2 = (JackarooNode)(object)_moveClips;
		obj3 = obj5;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag5)
		{
			object obj13 = (nint)0 + (nint)1624;
			object obj14 = typeof(SqlSingle[]) + 2376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action3 = default(Action);
			action3..ctor(obj2, (IntPtr)obj13);
			bool flag6 = node1 == null;
			gameAction = (GameAction?)(object)0;
			num = unchecked((nint)null);
			action = null;
			jackarooNode = null;
			jackarooMarble = null;
			jackarooNode2 = (JackarooNode)obj13;
			obj3 = obj2;
			if (!flag6)
			{
				object obj15 = typeof(TypeConverter<ushort, char>) + 3128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				JackarooNodeMono[] array = default(JackarooNodeMono[]);
				bool flag7 = array == null;
				gameAction = (GameAction?)(object)0;
				num = unchecked((nint)null);
				action = null;
				jackarooNode = null;
				jackarooMarble = null;
				jackarooNode2 = (JackarooNode)obj13;
				obj3 = 1;
				if (!flag7)
				{
					bool flag8 = (object)node1.<NodeMono>k__BackingField == null;
					object obj16 = 1;
					if (!flag8)
					{
						nint num2 = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v22 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
						obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag9 = ex == null;
						gameAction = (GameAction?)(object)0;
						num = unchecked((nint)null);
						action = null;
						jackarooNode = null;
						jackarooMarble = null;
						jackarooNode2 = (JackarooNode)obj13;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X8_v22 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
						obj3 = 0;
						if (flag9)
						{
							goto IL_08a1;
						}
					}
					bool flag10 = array.Length == 0;
					gameAction = (GameAction?)(object)0;
					num = unchecked((nint)null);
					action = null;
					jackarooNode = null;
					jackarooMarble = null;
					jackarooNode2 = (JackarooNode)obj13;
					obj3 = obj16;
					if (!flag10)
					{
						object obj17 = array + 32;
						obj17 = node1.<NodeMono>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						float duration = <Jackaroo>k__BackingField.<MinMarbleMoveDuration>k__BackingField + <Jackaroo>k__BackingField.<MinMarbleMoveDuration>k__BackingField;
						MoveMarble((JackarooMarble)obj6, duration, _moveClips, action3, null, 0, isPlant: false, (GameAction?)(object)0, array);
						return;
					}
					goto IL_0893;
				}
			}
		}
		goto IL_0885;
		IL_0885:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0893;
		IL_0114:
		current = RemoteConfig.Current;
		bool flag11 = current == null;
		object obj18 = !flag11;
		if (obj18 != null)
		{
			goto IL_01ed;
		}
		jackarooNode = node1;
		jackarooNode2 = node2;
		obj3 = action;
		goto IL_0885;
		IL_01ed:
		JackarooConfig <Jackaroo>k__BackingField2 = current.<Jackaroo>k__BackingField;
		bool flag12 = current.<Jackaroo>k__BackingField == null;
		jackarooNode = node1;
		jackarooNode2 = node2;
		obj3 = action;
		if (!flag12)
		{
			object obj19 = typeof(SqlSingle[]) + 2376;
			object obj20 = (nint)0 + (nint)1616;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			action2..ctor(obj2, (IntPtr)obj20);
			bool flag13 = node2 == null;
			jackarooNode = node1;
			jackarooMarble = null;
			jackarooNode2 = (JackarooNode)obj20;
			obj3 = obj2;
			if (!flag13)
			{
				object obj21 = typeof(TypeConverter<ushort, char>) + 3128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				JackarooNodeMono[] array2 = default(JackarooNodeMono[]);
				bool flag14 = array2 == null;
				jackarooNode = node1;
				jackarooMarble = null;
				jackarooNode2 = (JackarooNode)obj20;
				obj3 = 1;
				if (!flag14)
				{
					bool flag15 = (object)node2.<NodeMono>k__BackingField == null;
					object obj22 = 1;
					if (!flag15)
					{
						nint num3 = (nint)array2;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v32 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
						obj22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag16 = ex == null;
						jackarooNode = node1;
						jackarooMarble = null;
						jackarooNode2 = (JackarooNode)obj20;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v32 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
						obj3 = 0;
						if (flag16)
						{
							goto IL_08a1;
						}
					}
					bool flag17 = array2.Length == 0;
					jackarooNode = node1;
					jackarooMarble = null;
					jackarooNode2 = (JackarooNode)obj20;
					obj3 = obj22;
					if (flag17)
					{
						goto IL_0893;
					}
					object obj23 = array2 + 32;
					obj23 = node2.<NodeMono>k__BackingField;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					float duration2 = <Jackaroo>k__BackingField2.<MinMarbleMoveDuration>k__BackingField + <Jackaroo>k__BackingField2.<MinMarbleMoveDuration>k__BackingField;
					MoveMarble((JackarooMarble)obj5, duration2, _moveClips, action2, null, 0, isPlant: false, (GameAction?)(object)0, array2);
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F84]");
					object obj24 = (nint)0 & (nint)1;
					if (obj24 != null)
					{
						object obj25 = typeof(RegisteredWaitHandle) + 56;
						object obj26 = obj25;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v43+E4]");
						if ((nint)0 != 0)
						{
							goto IL_04b5;
						}
					}
					else
					{
						_ = 1;
						object obj27 = typeof(RegisteredWaitHandle) + 56;
						object obj26 = obj27;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v362 @ X0_v43+E4]");
						bool flag18 = (nint)0 == 0;
						object obj28 = !flag18;
						if (obj28 != null)
						{
							goto IL_04b5;
						}
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					current2 = RemoteConfig.Current;
					bool flag19 = current2 == null;
					gameAction = (GameAction?)(object)0;
					num = unchecked((nint)null);
					action = null;
					jackarooNode = null;
					jackarooMarble = (JackarooMarble)(object)action2;
					jackarooNode2 = (JackarooNode)(object)_moveClips;
					obj3 = obj5;
					if (!flag19)
					{
						goto IL_05d6;
					}
				}
			}
		}
		goto IL_0885;
		IL_0893:
		ex = new IndexOutOfRangeException();
		goto IL_08a1;
	}

	private void SwapSequential(JackarooMarble marble1, JackarooNode node2, JackarooMarble marble2, JackarooNode node1, Action onComplete)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00ea: Expected O, but got I
		//IL_01aa: Expected O, but got I4
		//IL_0157: Expected O, but got I4
		//IL_024b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0250: Expected O, but got Unknown
		//IL_025c: Expected O, but got I
		//IL_0277: Expected I, but got O
		//IL_02bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c2: Expected O, but got Unknown
		//IL_02f1: Expected O, but got I4
		//IL_031c: Expected O, but got I4
		//IL_0332: Expected I, but got O
		//IL_0342: Expected O, but got I
		//IL_0378: Expected O, but got I
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_0424: Expected O, but got I4
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		JackarooNode jackarooNode = node2;
		object obj3 = null;
		object obj5;
		RemoteConfigModel current;
		if (!flag)
		{
			object obj4 = obj2 + 16;
			obj4 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj5 = obj2 + 24;
			obj5 = marble1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj6 = obj2 + 32;
			JackarooMarble jackarooMarble = default(JackarooMarble);
			obj6 = jackarooMarble;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj7 = obj2 + 40;
			obj7 = onComplete;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj8 = obj2 + 48;
			obj8 = node1;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj9 = typeof(RegisteredWaitHandle) + 56;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F84]");
			object obj10 = (nint)0 & (nint)1;
			if (obj10 != null)
			{
				object obj11 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v37+E4]");
				if ((nint)0 != 0)
				{
					goto IL_0134;
				}
			}
			else
			{
				_ = 1;
				object obj11 = obj9;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X0_v37+E4]");
				bool flag2 = (nint)0 == 0;
				object obj12 = !flag2;
				if (obj12 != null)
				{
					goto IL_0134;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			current = RemoteConfig.Current;
			bool flag3 = current == null;
			jackarooNode = node2;
			obj3 = node1;
			if (!flag3)
			{
				goto IL_01fd;
			}
		}
		goto IL_042a;
		IL_01fd:
		JackarooConfig <Jackaroo>k__BackingField = current.<Jackaroo>k__BackingField;
		bool flag4 = current.<Jackaroo>k__BackingField == null;
		jackarooNode = node2;
		obj3 = node1;
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (!flag4)
		{
			object obj13 = typeof(SqlSingle[]) + 2376;
			object obj14 = (nint)0 + (nint)1632;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			Action action = default(Action);
			action..ctor(obj2, (IntPtr)obj14);
			bool flag5 = node2 == null;
			JackarooMarble jackarooMarble = null;
			jackarooNode = (JackarooNode)obj14;
			obj3 = obj2;
			if (!flag5)
			{
				object obj15 = typeof(TypeConverter<ushort, char>) + 3128;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
				JackarooNodeMono[] array = default(JackarooNodeMono[]);
				bool flag6 = array == null;
				jackarooMarble = null;
				jackarooNode = (JackarooNode)obj14;
				obj3 = 1;
				if (!flag6)
				{
					bool flag7 = (object)node2.<NodeMono>k__BackingField == null;
					object obj16 = 1;
					if (!flag7)
					{
						nint num = (nint)array;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v13 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
						obj16 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
						bool flag8 = ex == null;
						jackarooMarble = null;
						jackarooNode = (JackarooNode)obj14;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v13 (Il2CppClass<Jackaroo.JackarooNodeMono[]>)+40]");
						obj3 = 0;
						if (flag8)
						{
							goto IL_0446;
						}
					}
					bool flag9 = array.Length == 0;
					jackarooMarble = null;
					jackarooNode = (JackarooNode)obj14;
					obj3 = obj16;
					if (!flag9)
					{
						object obj17 = array + 32;
						obj17 = node2.<NodeMono>k__BackingField;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						float duration = <Jackaroo>k__BackingField.<MinMarbleMoveDuration>k__BackingField + <Jackaroo>k__BackingField.<MinMarbleMoveDuration>k__BackingField;
						MoveMarble((JackarooMarble)obj5, duration, _moveClips, action, null, 0, isPlant: false, (GameAction?)(object)0, array);
						return;
					}
					goto IL_0438;
				}
			}
		}
		goto IL_042a;
		IL_0438:
		ex = new IndexOutOfRangeException();
		goto IL_0446;
		IL_0446:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_042a:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0438;
		IL_0134:
		current = RemoteConfig.Current;
		bool flag10 = current == null;
		object obj18 = !flag10;
		if (obj18 != null)
		{
			goto IL_01fd;
		}
		jackarooNode = node2;
		obj3 = node1;
		goto IL_042a;
	}

	private void OnPostMove(Action onComplete)
	{
		if (onComplete != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: onComplete.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		<IsAnimating>k__BackingField = false;
	}

	private void OnPreMove(JackarooMarble marble, JackarooNode targetNode)
	{
		CheckMarbleUnblockedBase(marble);
		marble.<Node>k__BackingField.SetMarble();
		marble.SetNode(targetNode);
		targetNode.SetMarble(marble);
	}

	private JackarooNode HandleMarbleDeath(JackarooMarble marbleToDie)
	{
		if (marbleToDie != null)
		{
			if (<Board>k__BackingField != null)
			{
				JackarooNode jackarooNode = <Board>k__BackingField.MoveMarbleFromBoardToGraveyard(marbleToDie);
				CheckMarbleUnblockedBase(marbleToDie);
				if (<Board>k__BackingField != null)
				{
					marbleToDie.SetNode(jackarooNode);
					if (jackarooNode != null)
					{
						jackarooNode.SetMarble(marbleToDie);
						return jackarooNode;
					}
				}
			}
			return (JackarooNode)(object)new NullReferenceException();
		}
		return null;
	}

	private void OnDeath(JackarooMarble marble, JackarooNode graveyardNode)
	{
		if (marble != null && graveyardNode != null)
		{
			MoveMarbleToGraveyard(marble, graveyardNode);
			marble.<MarbleMono>k__BackingField.HideDeath();
		}
	}

	private void CheckMarbleEntryEffect(JackarooMarble marble, JackarooNode startNode, JackarooNode lastNode)
	{
		//IL_0017: Expected O, but got I8
		//IL_0031: Expected O, but got I4
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0163: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		object obj = (long)startNode.<Type>k__BackingField & 0xFFFFFFFDL;
		bool flag = obj == null;
		object obj2 = !flag;
		if (obj2 != null || lastNode.<Type>k__BackingField != JackarooNodeType.Base)
		{
			return;
		}
		if (<Board>k__BackingField.AreAllMarblesInBases(marble.<PlayerIndex>k__BackingField))
		{
			int teamMateIndex = GetTeamMateIndex(marble.<PlayerIndex>k__BackingField);
			if (!<Board>k__BackingField.AreAllMarblesInBases(teamMateIndex))
			{
				object obj3 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 448;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj4 = default(object);
				obj4..ctor();
				_ = 0;
				object obj5 = obj4 + 32;
				obj5 = this;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				_ = marble.<PlayerIndex>k__BackingField;
				Coroutine coroutine = StartCoroutine((IEnumerator)obj4);
			}
		}
		else
		{
			marble.<MarbleMono>k__BackingField.PlayEntryEffect();
			GameSoundManager instance = GameSoundManager.Instance;
			instance.PlaySound(_baseEntryClip, _volume);
		}
	}

	public void SetDefaultTheme()
	{
		SetThemeAndApply((JackarooThemeData)null);
	}

	public unsafe void SetTheme(Color? bottom = null, Color? left = null, Color? top = null, Color? right = null, Sprite boardSprite = null, Sprite bottomMarble = null, Sprite leftMarble = null, Sprite topMarble = null, Sprite rightMarble = null, bool? colorizeNodes = null, Color? nodeDefaultColor = null, Color? nodeSelectedColor = null, Color? highlightDefaultColor = null, bool? highlightLastNode = null)
	{
		//IL_0008: Expected O, but got Ref
		//IL_0027: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_009f: Expected O, but got I
		//IL_00ad: Expected O, but got Ref
		//IL_00bb: Expected O, but got Ref
		//IL_00c9: Expected O, but got Ref
		//IL_00d7: Expected O, but got Ref
		//IL_012d: Expected O, but got Ref
		//IL_012d: Expected O, but got Ref
		//IL_012d: Expected O, but got Ref
		//IL_012d: Expected O, but got I
		//IL_012d: Expected O, but got I
		//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c0: Expected O, but got Unknown
		//IL_017c: Expected O, but got I4
		//IL_01e5: Expected O, but got I4
		object obj2 = default(object);
		object obj = (object)(&obj2);
		JackarooTheme defaultTheme = _defaultTheme;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+38]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bottom @ X1 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [left @ X2 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ X3 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [right @ X4 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+20]");
		bool? colorizeNodes2 = (bool?)(object)((nint)0 & (nint)0xFFFF);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+40]");
		bool? highlightLastNode2 = (bool?)(object)((nint)0 & (nint)0xFFFF);
		Color? bottom2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		Color? color = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 80));
		Color? top2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 112));
		Color? right2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
		JackarooThemeData <ThemeData>k__BackingField = defaultTheme.<ThemeData>k__BackingField;
		Color? left2 = color;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+18]");
		object obj4 = default(object);
		object obj5 = default(object);
		object obj6 = default(object);
		JackarooThemeData jackarooThemeData = JackarooThemeDataExtensions.With(<ThemeData>k__BackingField, bottom2, left2, top2, right2, boardSprite, bottomMarble, leftMarble, (Sprite)num, (Sprite)0, colorizeNodes2, (Color?)(object)(&obj4), (Color?)(object)(&obj5), (Color?)(object)(&obj6), highlightLastNode2);
		bool flag = jackarooThemeData == null;
		JackarooThemeData runtimeTheme = jackarooThemeData;
		if (!flag)
		{
			JackarooThemeData source = _runtimeTheme;
			bool flag2 = _runtimeTheme == null;
			object obj7 = !flag2;
			if (obj7 == null)
			{
				JackarooTheme defaultTheme2 = _defaultTheme;
				source = defaultTheme2.<ThemeData>k__BackingField;
			}
			JackarooThemeData jackarooThemeData2 = JackarooThemeDataExtensions.With(source, jackarooThemeData);
			color = (Color?)(object)0;
			runtimeTheme = jackarooThemeData2;
		}
		_runtimeTheme = runtimeTheme;
		object obj8 = this + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void SetTheme(JackarooThemeData theme)
	{
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_0087: Expected O, but got Unknown
		//IL_0043: Expected O, but got I4
		JackarooThemeData jackarooThemeData = default(JackarooThemeData);
		JackarooThemeData runtimeTheme = default(JackarooThemeData);
		if (jackarooThemeData != null)
		{
			JackarooThemeData source = _runtimeTheme;
			bool flag = _runtimeTheme == null;
			object obj = !flag;
			if (obj == null)
			{
				JackarooTheme defaultTheme = _defaultTheme;
				source = defaultTheme.<ThemeData>k__BackingField;
			}
			runtimeTheme = JackarooThemeDataExtensions.With(source, jackarooThemeData);
		}
		_runtimeTheme = runtimeTheme;
		object obj2 = this + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public unsafe void SetThemeAndApply(Color? bottom = null, Color? left = null, Color? top = null, Color? right = null, Sprite boardSprite = null, Sprite bottomMarble = null, Sprite leftMarble = null, Sprite topMarble = null, Sprite rightMarble = null, bool? colorizeNodes = null, Color? nodeDefaultColor = null, Color? nodeSelectedColor = null, Color? highlightDefaultColor = null, bool? highlightLastNode = null)
	{
		//IL_0008: Expected O, but got Ref
		//IL_007b: Expected O, but got I
		//IL_0091: Expected O, but got I
		//IL_009f: Expected O, but got Ref
		//IL_00ad: Expected O, but got Ref
		//IL_00bb: Expected O, but got Ref
		//IL_00c9: Expected O, but got Ref
		//IL_011f: Expected O, but got Ref
		//IL_011f: Expected O, but got Ref
		//IL_011f: Expected O, but got Ref
		//IL_011f: Expected O, but got I
		//IL_011f: Expected O, but got I
		object obj2 = default(object);
		object obj = (object)(&obj2);
		JackarooTheme defaultTheme = _defaultTheme;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [bottom @ X1 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [left @ X2 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [top @ X3 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [right @ X4 (System.Nullable`1<UnityEngine.Color>)+10]");
		_ = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+20]");
		bool? colorizeNodes2 = (bool?)(object)((nint)0 & (nint)0xFFFF);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+40]");
		bool? highlightLastNode2 = (bool?)(object)((nint)0 & (nint)0xFFFF);
		Color? bottom2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 48));
		Color? left2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 80));
		Color? top2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 112));
		Color? right2 = (Color?)(object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.SubtractByteOffset(ref obj2, 144));
		JackarooThemeData <ThemeData>k__BackingField = defaultTheme.<ThemeData>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+10]");
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v8 @ X29_v1+18]");
		object obj3 = default(object);
		object obj4 = default(object);
		object obj5 = default(object);
		JackarooThemeData themeAndApply = JackarooThemeDataExtensions.With(<ThemeData>k__BackingField, bottom2, left2, top2, right2, boardSprite, bottomMarble, leftMarble, (Sprite)num, (Sprite)0, colorizeNodes2, (Color?)(object)(&obj3), (Color?)(object)(&obj4), (Color?)(object)(&obj5), highlightLastNode2);
		SetThemeAndApply(themeAndApply);
	}

	public void SetThemeAndApply(JackarooThemeData theme)
	{
		//IL_03b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bd: Expected O, but got Unknown
		//IL_0177: Expected O, but got I4
		//IL_002b: Expected O, but got I4
		//IL_01b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		//IL_0366: Expected O, but got I4
		//IL_00a2: Expected O, but got I4
		//IL_0239: Expected O, but got I4
		//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e5: Expected O, but got Unknown
		//IL_013b: Expected O, but got I4
		//IL_02df: Expected O, but got I4
		JackarooThemeData jackarooThemeData = default(JackarooThemeData);
		JackarooThemeData runtimeTheme = default(JackarooThemeData);
		if (jackarooThemeData != null)
		{
			JackarooThemeData source = _runtimeTheme;
			bool flag = _runtimeTheme == null;
			object obj = !flag;
			if (obj == null)
			{
				JackarooTheme defaultTheme = _defaultTheme;
				source = defaultTheme.<ThemeData>k__BackingField;
			}
			runtimeTheme = JackarooThemeDataExtensions.With(source, jackarooThemeData);
		}
		_runtimeTheme = runtimeTheme;
		object obj2 = this + 352;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		if (_boardInitialized)
		{
			ApplyNodesTheme();
			ColorizeNodes();
			ColorizePlayerBases();
			ColorizeMarbles();
			JackarooThemeData jackarooThemeData2 = _runtimeTheme;
			bool flag2 = _runtimeTheme == null;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				JackarooTheme defaultTheme2 = _defaultTheme;
				jackarooThemeData2 = defaultTheme2.<ThemeData>k__BackingField;
			}
			object obj4 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj5 = obj4;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X0_v18+E4]");
			if ((nint)0 != 0)
			{
				bool flag3 = jackarooThemeData2.<BoardSprite>k__BackingField != null;
				bool flag4 = !flag3;
				object obj6 = !flag4;
				if (obj6 == null)
				{
					goto IL_014a;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (!(jackarooThemeData2.<BoardSprite>k__BackingField != null))
				{
					goto IL_014a;
				}
			}
			JackarooThemeData jackarooThemeData3 = _runtimeTheme;
			bool flag5 = _runtimeTheme == null;
			object obj7 = !flag5;
			if (obj7 == null)
			{
				JackarooTheme defaultTheme3 = _defaultTheme;
				jackarooThemeData3 = defaultTheme3.<ThemeData>k__BackingField;
			}
			<BoardImage>k__BackingField.sprite = jackarooThemeData3.<BoardSprite>k__BackingField;
			ReapplyActiveHighlightStates();
			return;
		}
		JackarooThemeData jackarooThemeData4 = _runtimeTheme;
		bool flag6 = _runtimeTheme == null;
		object obj8 = !flag6;
		if (obj8 == null)
		{
			JackarooTheme defaultTheme4 = _defaultTheme;
			jackarooThemeData4 = defaultTheme4.<ThemeData>k__BackingField;
		}
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X0_v5+E4]");
		if ((nint)0 != 0)
		{
			if (!(jackarooThemeData4.<BoardSprite>k__BackingField != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag7 = jackarooThemeData4.<BoardSprite>k__BackingField != null;
			bool flag8 = !flag7;
			object obj11 = !flag8;
			if (obj11 == null)
			{
				return;
			}
		}
		JackarooThemeData jackarooThemeData5 = _runtimeTheme;
		bool flag9 = _runtimeTheme == null;
		object obj12 = !flag9;
		if (obj12 == null)
		{
			JackarooTheme defaultTheme5 = _defaultTheme;
			jackarooThemeData5 = defaultTheme5.<ThemeData>k__BackingField;
		}
		<BoardImage>k__BackingField.sprite = jackarooThemeData5.<BoardSprite>k__BackingField;
		return;
		IL_014a:
		ReapplyActiveHighlightStates();
	}

	public Sprite GetPlayerMarbleSprite(int rotatedPlayerIndex)
	{
		//IL_0026: Expected O, but got I4
		JackarooThemeData jackarooThemeData = _runtimeTheme;
		bool flag = _runtimeTheme == null;
		object obj = !flag;
		if (obj == null)
		{
			JackarooTheme defaultTheme = _defaultTheme;
			if ((object)_defaultTheme != null)
			{
				jackarooThemeData = defaultTheme.<ThemeData>k__BackingField;
				if (defaultTheme.<ThemeData>k__BackingField != null)
				{
					goto IL_008c;
				}
			}
			return (Sprite)(object)new NullReferenceException();
		}
		goto IL_008c;
		IL_008c:
		return jackarooThemeData.GetPlayerMarbleSprite(rotatedPlayerIndex);
	}

	private Color GetPlayerColor(int playerIndex)
	{
		//IL_0026: Expected O, but got I4
		JackarooThemeData jackarooThemeData = _runtimeTheme;
		bool flag = _runtimeTheme == null;
		object obj = !flag;
		if (obj == null)
		{
			JackarooTheme defaultTheme = _defaultTheme;
			if ((object)_defaultTheme != null)
			{
				jackarooThemeData = defaultTheme.<ThemeData>k__BackingField;
				if (defaultTheme.<ThemeData>k__BackingField != null)
				{
					goto IL_008c;
				}
			}
			return (Color)new NullReferenceException();
		}
		goto IL_008c;
		IL_008c:
		return jackarooThemeData.GetPlayerColor(playerIndex);
	}

	private unsafe void ApplyNodesTheme()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0020: Expected O, but got I
		//IL_07b0: Expected O, but got I4
		//IL_0048: Expected O, but got I4
		//IL_006d: Expected O, but got I
		//IL_007c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0095: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a9: Expected O, but got Unknown
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00c9: Expected O, but got I
		//IL_00e3: Expected O, but got Ref
		//IL_0178: Expected O, but got I4
		//IL_0196: Expected O, but got I
		//IL_01a2: Expected O, but got I
		//IL_0696: Expected O, but got I4
		//IL_083e: Expected O, but got I4
		//IL_0118: Expected O, but got I4
		//IL_01bf: Expected O, but got I
		//IL_08a5: Expected O, but got I
		//IL_08b7: Expected O, but got Ref
		//IL_01fa: Expected O, but got I
		//IL_085f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0864: Expected O, but got Unknown
		//IL_0679: Expected O, but got I4
		//IL_02a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ae: Expected O, but got Unknown
		//IL_02cb: Expected I, but got O
		//IL_02db: Expected O, but got I
		//IL_0210: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		//IL_021e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0223: Expected O, but got Unknown
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0915: Expected O, but got I
		//IL_0928: Unknown result type (might be due to invalid IL or missing references)
		//IL_092d: Expected O, but got Unknown
		//IL_0316: Expected O, but got I
		//IL_056e: Expected O, but got I4
		//IL_0577: Expected O, but got I4
		//IL_08cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d4: Expected O, but got Unknown
		//IL_03bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c4: Expected O, but got Unknown
		//IL_03cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d2: Expected O, but got Unknown
		//IL_09f8: Expected O, but got I4
		//IL_06af: Expected O, but got I4
		//IL_032c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0331: Expected O, but got Unknown
		//IL_0347: Expected O, but got I
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_0357: Expected O, but got Unknown
		//IL_0584: Expected I, but got O
		//IL_0594: Expected O, but got I
		//IL_040c: Expected I, but got O
		//IL_041c: Expected O, but got I
		//IL_0a3a: Expected O, but got I
		//IL_05cf: Expected O, but got I
		//IL_099a: Expected O, but got I
		//IL_0457: Expected O, but got I
		//IL_06c8: Expected O, but got I4
		//IL_095c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0961: Expected O, but got Unknown
		//IL_0644: Unknown result type (might be due to invalid IL or missing references)
		//IL_0649: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_0657: Expected O, but got Unknown
		//IL_053e: Expected O, but got I
		//IL_054e: Expected O, but got I
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_05dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e2: Expected O, but got Unknown
		//IL_05f8: Expected O, but got I
		//IL_046d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0472: Expected O, but got Unknown
		//IL_0488: Expected O, but got I
		//IL_0493: Unknown result type (might be due to invalid IL or missing references)
		//IL_0498: Expected O, but got Unknown
		object obj = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 1568;
		object obj2 = (nint)0 + (nint)568;
		IEnumerable<object> highlightedLastNodes = _highlightedLastNodes;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		HashSet<JackarooNodeMono> hashSet = (HashSet<JackarooNodeMono>)obj2;
		HashSet<object> hashSet2 = default(HashSet<object>);
		hashSet2..ctor((IEnumerable<object>)_highlightedLastNodes);
		JackarooBoard jackarooBoard = <Board>k__BackingField;
		bool flag = <Board>k__BackingField == null;
		IEnumerable<object> enumerable = null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		IEnumerable<object> highlightedLastNodes2 = _highlightedLastNodes;
		if (!flag)
		{
			bool flag2 = jackarooBoard.<NodesAndBases>k__BackingField == null;
			enumerable = null;
			enumerator = (List<object>.Enumerator)0;
			highlightedLastNodes2 = _highlightedLastNodes;
			if (!flag2)
			{
				highlightedLastNodes = (IEnumerable<object>)((nint)0 + (nint)2824);
				object obj3 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3440;
				object obj4 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				object obj5 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 848;
				obj2 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
				object obj6 = (nint)0 + (nint)2816;
				List<object>.Enumerator enumerator2 = ((List<object>)(object)jackarooBoard.<NodesAndBases>k__BackingField).GetEnumerator();
				jackarooBoard = (JackarooBoard)(&enumerator);
				JackarooBoard jackarooBoard2 = default(JackarooBoard);
				object obj7 = default(object);
				bool flag6 = default(bool);
				object obj18 = default(object);
				object obj20 = default(object);
				object obj29 = default(object);
				List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
				object obj30 = default(object);
				object obj31 = default(object);
				while (true)
				{
					highlightedLastNodes2 = highlightedLastNodes;
					if (enumerator.MoveNext())
					{
						if (jackarooBoard2 != null)
						{
							ApplyNodeTheme((JackarooNodeMono)jackarooBoard2._isSpectator, (HashSet<JackarooNodeMono>)(object)hashSet2);
							hashSet = (HashSet<JackarooNodeMono>)(object)hashSet2;
							jackarooBoard = jackarooBoard2;
							continue;
						}
						NullReferenceException ex = new NullReferenceException();
						enumerable = null;
						enumerator3 = (List<object>.Enumerator)0;
						goto IL_06cd;
					}
					highlightedLastNodes2 = (IEnumerable<object>)obj6;
					enumerator.Dispose();
					highlightedLastNodes = (IEnumerable<object>)<Board>k__BackingField;
					bool flag3 = <Board>k__BackingField == null;
					enumerable = null;
					enumerator = enumerator3;
					List<object>.Enumerator enumerator4 = enumerator3;
					enumerator3 = (List<object>.Enumerator)0;
					if (flag3)
					{
						break;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F68]");
					jackarooBoard = (JackarooBoard)0;
					obj6 = (nint)0 + (nint)1992;
					highlightedLastNodes2 = (IEnumerable<object>)obj6;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C958DC");
					bool flag4 = obj7 == null;
					enumerable = null;
					enumerator4 = enumerator3;
					enumerator3 = (List<object>.Enumerator)0;
					if (flag4)
					{
						break;
					}
					object obj8 = obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v21+12E]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v21+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0277;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X8_v21+B0]");
					object obj10 = (nint)0 + (nint)8;
					bool flag5 = flag6;
					object obj12;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X10_v29-8]");
						object obj11 = 0 - obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X10_v29-8]");
						if (0 == (nint)obj3)
						{
							break;
						}
						obj12 = obj10 + 16;
						obj9--;
						obj11 = obj9 - 1;
						bool flag7 = obj11 == null;
						flag6 = (nint)obj9 != 1;
						flag5 = flag6;
						obj10 = obj12;
						if (flag6)
						{
							continue;
						}
						goto IL_0277;
					}
					object obj13 = obj8 + obj10;
					object obj14 = obj13 + 312;
					flag6 = flag5;
					obj12 = obj10;
					goto IL_088d;
					IL_088d:
					object obj15 = obj14;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v22+8]");
					highlightedLastNodes2 = (IEnumerable<object>)0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v594 @ X8_v22] (should have been resolved before IL gen)");
					jackarooBoard = (JackarooBoard)(&enumerable);
					while (true)
					{
						if (enumerable != null)
						{
							nint num = (nint)enumerable;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_039b;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
							object obj16 = (nint)0 + (nint)8;
							bool flag8 = flag6;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X10_v24-8]");
								object obj11 = 0 - obj4;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X10_v24-8]");
								if (0 == (nint)obj4)
								{
									break;
								}
								obj12 = obj16 + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v608 @ X8_v25 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
								obj15 = -1;
								obj11 = obj15 - 1;
								bool flag7 = obj11 == null;
								flag6 = (nint)obj15 != 1;
								flag8 = flag6;
								obj16 = obj12;
								if (flag6)
								{
									continue;
								}
								goto IL_039b;
							}
							obj15 = obj16;
							object obj17 = num + obj16;
							obj18 = obj17 + 312;
							flag6 = flag8;
							obj12 = obj16;
							goto IL_08fd;
						}
						NullReferenceException ex2 = new NullReferenceException();
						enumerator3 = (List<object>.Enumerator)0;
						break;
						IL_039b:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						hashSet = null;
						goto IL_08fd;
						IL_08fd:
						jackarooBoard = (JackarooBoard)obj18;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v665 @ X0_v38+8]");
						highlightedLastNodes2 = (IEnumerable<object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v665 @ X0_v38] (should have been resolved before IL gen)");
						object obj19 = obj20 & 1;
						if (obj19 != null)
						{
							if (enumerable != null)
							{
								nint num2 = (nint)enumerable;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
								obj15 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
								if ((nint)0 == 0)
								{
									goto IL_04dc;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
								object obj21 = (nint)0 + (nint)8;
								bool flag9 = flag6;
								while (true)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X10_v19-8]");
									object obj11 = 0 - obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v712 @ X10_v19-8]");
									if (0 == (nint)obj5)
									{
										break;
									}
									obj12 = obj21 + 16;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v670 @ X8_v28 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
									obj15 = -1;
									obj11 = obj15 - 1;
									bool flag7 = obj11 == null;
									flag6 = (nint)obj15 != 1;
									flag9 = flag6;
									obj21 = obj12;
									if (flag6)
									{
										continue;
									}
									goto IL_04dc;
								}
								obj15 = obj21;
								object obj22 = num2 + obj21;
								object obj23 = obj22 + 312;
								flag6 = flag9;
								obj12 = obj21;
								goto IL_098a;
							}
							NullReferenceException ex3 = new NullReferenceException();
							enumerator3 = (List<object>.Enumerator)0;
							break;
						}
						enumerator4 = enumerator3;
						enumerator3 = (List<object>.Enumerator)0;
						object obj24 = 0;
						while (true)
						{
							if (enumerable == null)
							{
								goto IL_09de;
							}
							nint num3 = (nint)enumerable;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
							obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
							if ((nint)0 == 0)
							{
								goto IL_0620;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+B0]");
							object obj25 = (nint)0 + (nint)8;
							while (true)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v506 @ X10_v7-8]");
								if (0 == (nint)obj2)
								{
									break;
								}
								obj12 = obj25 + 16;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v6 (Il2CppClass<System.Collections.Generic.IEnumerable`1<System.Object>>)+12E]");
								obj15 = -1;
								bool flag10 = (nint)obj15 != 1;
								obj25 = obj12;
								if (flag10)
								{
									continue;
								}
								goto IL_0620;
							}
							obj15 = obj25;
							object obj26 = num3 + obj25;
							object obj27 = obj26 + 312;
							obj12 = obj25;
							goto IL_0a2a;
							IL_09de:
							bool flag11 = obj24 == null;
							object obj28 = !flag11;
							if (obj28 == null)
							{
								return;
							}
							OutOfMemoryException ex4 = new OutOfMemoryException();
							if ((nint)highlightedLastNodes2 != 1)
							{
								break;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
							obj24 = obj29;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
							enumerator3 = (List<object>.Enumerator)obj29;
							continue;
							IL_0620:
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
							hashSet = null;
							goto IL_0a2a;
							IL_0a2a:
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X0_v6+8]");
							highlightedLastNodes2 = (IEnumerable<object>)0;
							Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v550 @ X0_v6] (should have been resolved before IL gen)");
							goto IL_09de;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
						return;
						IL_04dc:
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
						hashSet = null;
						goto IL_098a;
						IL_098a:
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v727 @ X0_v42+8]");
						highlightedLastNodes2 = (IEnumerable<object>)0;
						Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v727 @ X0_v42] (should have been resolved before IL gen)");
						if (obj30 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X0_v44+18]");
							ApplyNodeTheme((JackarooNodeMono)0, (HashSet<JackarooNodeMono>)(object)hashSet2);
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X0_v44+18]");
							highlightedLastNodes2 = (IEnumerable<object>)0;
							hashSet = (HashSet<JackarooNodeMono>)(object)hashSet2;
							continue;
						}
						NullReferenceException ex5 = new NullReferenceException();
						enumerator3 = (List<object>.Enumerator)0;
						break;
					}
					goto IL_06cd;
					IL_06cd:
					enumerator4 = enumerator3;
					break;
					IL_0277:
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
					hashSet = null;
					obj14 = obj31;
					goto IL_088d;
				}
			}
		}
		throw new NullReferenceException();
	}

	private void ApplyNodeTheme(JackarooNodeMono nodeMono, HashSet<JackarooNodeMono> lastHighlightedSet)
	{
		//IL_00ff: Expected O, but got I4
		//IL_0013: Expected O, but got I4
		//IL_0039: Expected O, but got I4
		//IL_00cb: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		bool flag = _runtimeTheme == null;
		object obj = !flag;
		if (obj == null)
		{
			/*Error: End of method reached without returning.*/;
		}
		nodeMono.SetDefaultColor((Color)0);
		JackarooThemeData jackarooThemeData = _runtimeTheme;
		bool flag2 = _runtimeTheme == null;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			JackarooTheme defaultTheme = _defaultTheme;
			jackarooThemeData = defaultTheme.<ThemeData>k__BackingField;
		}
		nodeMono._selectedColor = jackarooThemeData.<NodeSelectedColor>k__BackingField;
		if (!((HashSet<object>)(object)lastHighlightedSet).Contains((object)nodeMono))
		{
			bool flag3 = _runtimeTheme == null;
			object obj3 = !flag3;
			if (obj3 == null)
			{
			}
			nodeMono.ApplyHighlightTheme((Color)0);
		}
	}

	private void ColorizeNodes()
	{
		//IL_1569: Expected O, but got I4
		//IL_008e: Expected O, but got I
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a2: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_01af: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_0201: Expected O, but got I4
		//IL_032c: Expected O, but got I4
		//IL_0261: Expected O, but got I4
		//IL_036b: Expected O, but got I4
		//IL_0394: Expected O, but got I4
		//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03cc: Expected O, but got I
		//IL_040c: Expected O, but got I4
		//IL_0462: Expected O, but got I4
		//IL_048e: Expected O, but got I4
		//IL_048e: Expected O, but got I
		//IL_04d2: Expected O, but got I4
		//IL_04d7: Expected I, but got O
		//IL_15b4: Expected O, but got I4
		//IL_15b9: Expected I, but got O
		//IL_04f8: Expected O, but got I4
		//IL_0501: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected I4, but got Unknown
		//IL_050f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0514: Expected O, but got Unknown
		//IL_051f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_053f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0544: Expected O, but got Unknown
		//IL_0575: Unsupported input type for neg.
		//IL_0575: Unknown result type (might be due to invalid IL or missing references)
		//IL_057a: Expected I4, but got Unknown
		//IL_058e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0593: Expected O, but got Unknown
		//IL_059b: Expected I, but got O
		//IL_05ab: Expected O, but got I
		//IL_06a1: Expected O, but got I4
		//IL_06ba: Expected O, but got I4
		//IL_06e3: Expected O, but got I4
		//IL_06ec: Expected O, but got I4
		//IL_05e8: Expected O, but got I
		//IL_0712: Expected O, but got I
		//IL_163d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1642: Expected O, but got Unknown
		//IL_07dd: Expected O, but got I4
		//IL_0af2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af7: Expected O, but got Unknown
		//IL_0b00: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b05: Expected O, but got Unknown
		//IL_0b39: Expected O, but got I4
		//IL_0b42: Expected O, but got I4
		//IL_16cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d4: Expected O, but got Unknown
		//IL_074d: Expected O, but got I
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0603: Expected O, but got Unknown
		//IL_060c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0611: Expected O, but got Unknown
		//IL_061c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0621: Expected O, but got Unknown
		//IL_167e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1683: Expected O, but got Unknown
		//IL_0ba1: Expected O, but got I4
		//IL_07f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_07fd: Expected O, but got Unknown
		//IL_0a21: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a26: Expected O, but got Unknown
		//IL_0a3e: Expected O, but got I
		//IL_0763: Unknown result type (might be due to invalid IL or missing references)
		//IL_0768: Expected O, but got Unknown
		//IL_0771: Unknown result type (might be due to invalid IL or missing references)
		//IL_0776: Expected O, but got Unknown
		//IL_0781: Unknown result type (might be due to invalid IL or missing references)
		//IL_0786: Expected O, but got Unknown
		//IL_0ae5: Expected O, but got I4
		//IL_0847: Expected O, but got I
		//IL_0a79: Expected O, but got I
		//IL_0912: Expected O, but got I4
		//IL_0882: Expected O, but got I
		//IL_0bbc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc1: Expected O, but got Unknown
		//IL_1704: Unknown result type (might be due to invalid IL or missing references)
		//IL_1709: Expected O, but got Unknown
		//IL_0a8f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Expected O, but got Unknown
		//IL_0a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa2: Expected O, but got Unknown
		//IL_092d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0932: Expected O, but got Unknown
		//IL_0898: Unknown result type (might be due to invalid IL or missing references)
		//IL_089d: Expected O, but got Unknown
		//IL_08a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08ab: Expected O, but got Unknown
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bb: Expected O, but got Unknown
		//IL_0982: Expected O, but got I4
		//IL_0982: Expected O, but got I
		//IL_099c: Expected O, but got I4
		//IL_09d1: Expected I, but got O
		JackarooThemeData jackarooThemeData = _runtimeTheme;
		bool flag = _runtimeTheme == null;
		object obj = !flag;
		if (obj != null)
		{
			goto IL_005d;
		}
		JackarooTheme defaultTheme = _defaultTheme;
		if ((object)_defaultTheme != null)
		{
			jackarooThemeData = defaultTheme.<ThemeData>k__BackingField;
			if (defaultTheme.<ThemeData>k__BackingField != null)
			{
				goto IL_005d;
			}
		}
		goto IL_14f1;
		IL_14f1:
		NullReferenceException ex = new NullReferenceException();
		goto IL_14ff;
		IL_14ff:
		throw new IndexOutOfRangeException();
		IL_005d:
		bool flag2 = !jackarooThemeData.<ColorizeNodes>k__BackingField;
		if (flag2)
		{
			return;
		}
		object obj2 = (nint)0 + (nint)3000;
		object obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj4 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 848;
		object obj6 = default(object);
		object obj5 = obj6;
		object obj8 = default(object);
		object obj7 = obj8;
		object obj10 = default(object);
		object obj9 = obj10;
		object obj12 = default(object);
		object obj11 = obj12;
		int num = 1;
		bool flag3 = (object)<Game>k__BackingField == null;
		obj6 = obj5;
		obj8 = obj7;
		obj10 = obj9;
		obj12 = obj11;
		int rotatedPlayerIndex;
		JackarooThemeData jackarooThemeData2;
		nint num2;
		object obj14;
		if (!flag3)
		{
			rotatedPlayerIndex = <Game>k__BackingField.GetRotatedPlayerIndex(num);
			jackarooThemeData2 = _runtimeTheme;
			bool flag4 = _runtimeTheme == null;
			object obj13 = !flag4;
			if (obj13 != null)
			{
				goto IL_0277;
			}
			JackarooTheme defaultTheme2 = _defaultTheme;
			bool flag5 = (object)_defaultTheme == null;
			obj6 = obj5;
			obj8 = obj7;
			obj10 = obj9;
			obj12 = obj11;
			obj14 = 0;
			num2 = num;
			if (!flag5)
			{
				jackarooThemeData2 = defaultTheme2.<ThemeData>k__BackingField;
				bool flag6 = defaultTheme2.<ThemeData>k__BackingField == null;
				obj6 = obj5;
				obj8 = obj7;
				obj10 = obj9;
				obj12 = obj11;
				obj14 = 0;
				num2 = num;
				if (!flag6)
				{
					goto IL_0277;
				}
			}
		}
		goto IL_14f1;
		IL_0665:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X0_v90+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v777 @ X0_v90] (should have been resolved before IL gen)");
		object obj15 = default(object);
		bool flag7 = obj15 == null;
		object obj16 = 0;
		object obj17 = obj15;
		object obj18 = obj15;
		object obj19 = 0;
		obj6 = obj5;
		obj8 = obj7;
		obj10 = obj9;
		obj12 = obj11;
		obj16 = 0;
		obj14 = 0;
		if (!flag7)
		{
			goto IL_06fa;
		}
		goto IL_09df;
		IL_06fa:
		object obj27 = default(object);
		object obj30 = default(object);
		while (true)
		{
			object obj20 = obj18;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v30+12E]");
			object obj21 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v30+12E]");
			if ((nint)0 == 0)
			{
				goto IL_07ca;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X8_v30+B0]");
			object obj22 = (nint)0 + (nint)8;
			bool flag8 = flag2;
			object obj24;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X10_v53-8]");
				object obj23 = 0 - obj3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v883 @ X10_v53-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj24 = obj22 + 16;
				obj21--;
				obj23 = obj21 - 1;
				bool flag9 = obj23 == null;
				flag2 = (nint)obj21 != 1;
				obj22 = obj24;
				flag8 = flag2;
				if (flag2)
				{
					continue;
				}
				goto IL_07ca;
			}
			object obj25 = obj20 + obj22;
			object obj26 = obj25 + 312;
			obj24 = obj22;
			flag2 = flag8;
			goto IL_16ac;
			IL_17bb:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1057 @ X0_v71+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1057 @ X0_v71] (should have been resolved before IL gen)");
			goto IL_1769;
			IL_1732:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1049 @ X0_v78+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1049 @ X0_v78] (should have been resolved before IL gen)");
			if (obj27 == null)
			{
				goto IL_137c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X0_v80+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X0_v80+18]");
				((JackarooNodeMono)0).SetDefaultColor((Color)0);
				bool flag10 = obj17 == null;
				object obj28 = !flag10;
				obj18 = obj17;
				obj6 = obj5;
				obj8 = obj7;
				obj10 = obj9;
				obj12 = obj11;
				obj14 = obj19;
				num2 = unchecked((nint)null);
				if (obj28 != null)
				{
					continue;
				}
				goto IL_09df;
			}
			goto IL_13f8;
			IL_1769:
			obj6 = obj5;
			obj8 = obj7;
			obj10 = obj9;
			obj12 = obj11;
			obj14 = obj19;
			throw new OutOfMemoryException();
			IL_07ca:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_16ac;
			IL_16ac:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v907 @ X0_v32+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v907 @ X0_v32] (should have been resolved before IL gen)");
			object obj29 = obj30 & 1;
			if (obj29 != null)
			{
				if (obj17 == null)
				{
					break;
				}
				object obj31 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v67+12E]");
				object obj32 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v67+12E]");
				if ((nint)0 == 0)
				{
					goto IL_08ff;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v67+B0]");
				object obj33 = (nint)0 + (nint)8;
				bool flag11 = flag2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X10_v48-8]");
					object obj23 = 0 - obj4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1002 @ X10_v48-8]");
					if (0 == (nint)obj4)
					{
						break;
					}
					obj24 = obj33 + 16;
					obj32--;
					obj23 = obj32 - 1;
					bool flag9 = obj23 == null;
					flag2 = (nint)obj32 != 1;
					obj33 = obj24;
					flag11 = flag2;
					if (flag2)
					{
						continue;
					}
					goto IL_08ff;
				}
				object obj34 = obj31 + obj33;
				object obj35 = obj34 + 312;
				obj24 = obj33;
				flag2 = flag11;
				goto IL_1732;
			}
			if (obj17 == null)
			{
				goto IL_1769;
			}
			object obj36 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj37 = obj17;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v63+12E]");
			object obj38 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v63+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0ad2;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v921 @ X8_v63+B0]");
			object obj39 = (nint)0 + (nint)8;
			bool flag12 = flag2;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1023 @ X10_v42-8]");
				if (0 == (nint)obj36)
				{
					break;
				}
				obj24 = obj39 + 16;
				obj38--;
				flag2 = (nint)obj38 != 1;
				obj39 = obj24;
				flag12 = flag2;
				if (flag2)
				{
					continue;
				}
				goto IL_0ad2;
			}
			object obj40 = obj37 + obj39;
			object obj41 = obj40 + 312;
			obj24 = obj39;
			flag2 = flag12;
			goto IL_17bb;
			IL_08ff:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_1732;
			IL_0ad2:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj19 = 0;
			goto IL_17bb;
		}
		NullReferenceException ex2 = new NullReferenceException();
		obj6 = obj5;
		obj8 = obj7;
		obj10 = obj9;
		obj12 = obj11;
		obj14 = obj19;
		OutOfMemoryException ex3 = (OutOfMemoryException)(object)ex2;
		goto IL_19d3;
		IL_13f8:
		NullReferenceException ex4 = new NullReferenceException();
		obj6 = obj5;
		obj8 = obj7;
		obj10 = obj9;
		obj12 = obj11;
		obj14 = obj19;
		ex3 = (OutOfMemoryException)(object)ex4;
		goto IL_19d3;
		IL_09df:
		NullReferenceException ex5 = new NullReferenceException();
		ex3 = (OutOfMemoryException)(object)ex5;
		goto IL_19d3;
		IL_0277:
		Color playerColor = jackarooThemeData2.GetPlayerColor(num);
		JackarooBoard jackarooBoard = <Board>k__BackingField;
		bool flag13 = <Board>k__BackingField == null;
		obj6 = obj5;
		obj8 = obj7;
		obj10 = obj9;
		obj12 = obj11;
		obj14 = 0;
		num2 = num;
		if (!flag13)
		{
			(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes = jackarooBoard._homesAndBasesEntryNodes;
			bool flag14 = jackarooBoard._homesAndBasesEntryNodes == null;
			obj6 = obj5;
			obj8 = obj7;
			obj10 = obj9;
			obj12 = obj11;
			obj14 = 0;
			num2 = num;
			if (!flag14)
			{
				int num3 = rotatedPlayerIndex - 1;
				bool flag15 = num3 < homesAndBasesEntryNodes.Length;
				object obj42 = !flag15;
				obj6 = obj5;
				obj8 = obj7;
				obj10 = obj9;
				obj12 = obj11;
				obj14 = 0;
				num2 = num;
				if (obj42 != null)
				{
					goto IL_14ff;
				}
				object obj43 = jackarooBoard._homesAndBasesEntryNodes + num3;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v16+20]");
				object obj44 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v726 @ X8_v16+20]");
				bool flag16 = (nint)0 == 0;
				obj6 = obj5;
				obj8 = obj7;
				obj10 = obj9;
				obj12 = obj11;
				obj14 = 0;
				num2 = num;
				if (!flag16)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v17+18]");
					bool flag17 = (nint)0 == 0;
					obj6 = obj5;
					obj8 = obj7;
					obj10 = obj9;
					obj12 = obj11;
					obj14 = 0;
					num2 = num;
					if (!flag17)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v17+18]");
						((JackarooNodeMono)0).SetDefaultColor((Color)0);
						JackarooBoard jackarooBoard2 = <Board>k__BackingField;
						bool flag18 = <Board>k__BackingField == null;
						obj6 = obj5;
						obj8 = obj7;
						obj10 = obj9;
						obj12 = obj11;
						obj14 = 0;
						num2 = unchecked((nint)null);
						if (!flag18)
						{
							bool flag19 = jackarooBoard2._basesNodes == null;
							obj6 = obj5;
							obj8 = obj7;
							obj10 = obj9;
							obj12 = obj11;
							obj14 = 0;
							num2 = unchecked((nint)null);
							if (!flag19)
							{
								object obj45 = 5 - rotatedPlayerIndex;
								int num4 = obj45 & 3;
								object obj46 = 0 - obj45;
								object obj23 = 0 - obj46;
								bool flag9 = obj23 == null;
								object obj47 = obj46 & 3;
								int num5 = ((0 >= (nint)obj46) ? (0 - obj47) : num4);
								obj14 = obj2;
								object obj48 = ((List<object>)(object)jackarooBoard2._basesNodes).get_Item(num5);
								bool flag20 = obj48 == null;
								obj6 = obj5;
								obj8 = obj7;
								obj10 = obj9;
								obj12 = obj11;
								num2 = num5;
								if (!flag20)
								{
									object obj49 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3440;
									nint num6 = (nint)obj48;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v27 (Il2CppClass<System.Object>)+12E]");
									object obj50 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v27 (Il2CppClass<System.Object>)+12E]");
									if ((nint)0 == 0)
									{
										goto IL_0665;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v27 (Il2CppClass<System.Object>)+B0]");
									object obj51 = (nint)0 + (nint)8;
									bool flag21 = flag2;
									object obj24;
									while (true)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X10_v58-8]");
										obj23 = 0 - obj49;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v779 @ X10_v58-8]");
										if (0 == (nint)obj49)
										{
											break;
										}
										obj24 = obj51 + 16;
										obj50--;
										obj23 = obj50 - 1;
										flag9 = obj23 == null;
										flag2 = (nint)obj50 != 1;
										obj51 = obj24;
										flag21 = flag2;
										if (flag2)
										{
											continue;
										}
										goto IL_0665;
									}
									object obj52 = num6 + obj51;
									object obj53 = obj52 + 312;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v812 @ X8_v74+8]");
									num2 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v812 @ X8_v74] (should have been resolved before IL gen)");
									object obj54 = default(object);
									bool flag22 = obj54 == null;
									object obj55 = !flag22;
									obj16 = 0;
									obj17 = obj54;
									obj24 = obj51;
									obj18 = obj54;
									obj19 = obj14;
									flag2 = flag21;
									if (obj55 != null)
									{
										goto IL_06fa;
									}
									obj6 = obj5;
									obj8 = obj7;
									obj10 = obj9;
									obj12 = obj11;
									obj16 = 0;
									goto IL_09df;
								}
							}
						}
					}
				}
			}
		}
		goto IL_14f1;
		IL_137c:
		NullReferenceException ex6 = new NullReferenceException();
		obj6 = obj5;
		obj8 = obj7;
		obj10 = obj9;
		obj12 = obj11;
		obj14 = obj19;
		ex3 = (OutOfMemoryException)(object)ex6;
		goto IL_19d3;
		IL_19d3:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ColorizePlayerBases()
	{
		//IL_0059: Expected O, but got I4
		//IL_0108: Expected O, but got I4
		//IL_0123: Expected O, but got I4
		//IL_0150: Expected O, but got I
		//IL_01e0: Expected O, but got I4
		//IL_028f: Expected O, but got I4
		//IL_02aa: Expected O, but got I4
		//IL_02d7: Expected O, but got I
		//IL_0367: Expected O, but got I4
		//IL_0416: Expected O, but got I4
		//IL_0431: Expected O, but got I4
		//IL_045e: Expected O, but got I
		//IL_04ee: Expected O, but got I4
		//IL_059d: Expected O, but got I4
		//IL_05b8: Expected O, but got I4
		//IL_05e5: Expected O, but got I
		int rotatedPlayerIndex;
		JackarooThemeData jackarooThemeData;
		if ((object)<Game>k__BackingField != null)
		{
			rotatedPlayerIndex = <Game>k__BackingField.GetRotatedPlayerIndex(1);
			jackarooThemeData = _runtimeTheme;
			bool flag = _runtimeTheme == null;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_00bf;
			}
			JackarooTheme defaultTheme = _defaultTheme;
			if ((object)_defaultTheme != null)
			{
				jackarooThemeData = defaultTheme.<ThemeData>k__BackingField;
				if (defaultTheme.<ThemeData>k__BackingField != null)
				{
					goto IL_00bf;
				}
			}
		}
		goto IL_061c;
		IL_062a:
		throw new IndexOutOfRangeException();
		IL_061c:
		NullReferenceException ex = new NullReferenceException();
		goto IL_062a;
		IL_03cd:
		JackarooThemeData jackarooThemeData2;
		Color playerColor = jackarooThemeData2.GetPlayerColor(3);
		Image[] baseColors = _baseColors;
		int rotatedPlayerIndex2;
		int rotatedPlayerIndex3;
		JackarooThemeData jackarooThemeData3;
		if (_baseColors != null)
		{
			object obj2 = rotatedPlayerIndex2 - 1;
			bool flag2 = (nint)obj2 < baseColors.Length;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_062a;
			}
			object obj4 = (object)_baseColors + obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v13+20]");
			object obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v13+20]");
			if ((nint)0 != 0)
			{
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v93 @ X8_v14+2A8] (should have been resolved before IL gen)");
				if ((object)<Game>k__BackingField != null)
				{
					rotatedPlayerIndex3 = <Game>k__BackingField.GetRotatedPlayerIndex(4);
					jackarooThemeData3 = _runtimeTheme;
					bool flag3 = _runtimeTheme == null;
					object obj7 = !flag3;
					if (obj7 != null)
					{
						goto IL_0554;
					}
					JackarooTheme defaultTheme2 = _defaultTheme;
					if ((object)_defaultTheme != null)
					{
						jackarooThemeData3 = defaultTheme2.<ThemeData>k__BackingField;
						if (defaultTheme2.<ThemeData>k__BackingField != null)
						{
							goto IL_0554;
						}
					}
				}
			}
		}
		goto IL_061c;
		IL_00bf:
		Color playerColor2 = jackarooThemeData.GetPlayerColor(1);
		Image[] baseColors2 = _baseColors;
		int rotatedPlayerIndex4;
		JackarooThemeData jackarooThemeData4;
		if (_baseColors != null)
		{
			object obj8 = rotatedPlayerIndex - 1;
			bool flag4 = (nint)obj8 < baseColors2.Length;
			object obj9 = !flag4;
			if (obj9 != null)
			{
				goto IL_062a;
			}
			object obj10 = (object)_baseColors + obj8;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5+20]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5+20]");
			if ((nint)0 != 0)
			{
				object obj12 = obj11;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v85 @ X8_v6+2A8] (should have been resolved before IL gen)");
				if ((object)<Game>k__BackingField != null)
				{
					rotatedPlayerIndex4 = <Game>k__BackingField.GetRotatedPlayerIndex(2);
					jackarooThemeData4 = _runtimeTheme;
					bool flag5 = _runtimeTheme == null;
					object obj13 = !flag5;
					if (obj13 != null)
					{
						goto IL_0246;
					}
					JackarooTheme defaultTheme3 = _defaultTheme;
					if ((object)_defaultTheme != null)
					{
						jackarooThemeData4 = defaultTheme3.<ThemeData>k__BackingField;
						if (defaultTheme3.<ThemeData>k__BackingField != null)
						{
							goto IL_0246;
						}
					}
				}
			}
		}
		goto IL_061c;
		IL_0554:
		Color playerColor3 = jackarooThemeData3.GetPlayerColor(4);
		Image[] baseColors3 = _baseColors;
		if (_baseColors != null)
		{
			object obj14 = rotatedPlayerIndex3 - 1;
			bool flag6 = (nint)obj14 < baseColors3.Length;
			object obj15 = !flag6;
			if (obj15 != null)
			{
				goto IL_062a;
			}
			object obj16 = (object)_baseColors + obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v17+20]");
			object obj17 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X8_v17+20]");
			if ((nint)0 != 0)
			{
				object obj18 = obj17;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v212 @ X8_v18+2A8] (should have been resolved before IL gen)");
			}
		}
		goto IL_061c;
		IL_0246:
		Color playerColor4 = jackarooThemeData4.GetPlayerColor(2);
		Image[] baseColors4 = _baseColors;
		if (_baseColors != null)
		{
			object obj19 = rotatedPlayerIndex4 - 1;
			bool flag7 = (nint)obj19 < baseColors4.Length;
			object obj20 = !flag7;
			if (obj20 != null)
			{
				goto IL_062a;
			}
			object obj21 = (object)_baseColors + obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v9+20]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v9+20]");
			if ((nint)0 != 0)
			{
				object obj23 = obj22;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v89 @ X8_v10+2A8] (should have been resolved before IL gen)");
				if ((object)<Game>k__BackingField != null)
				{
					rotatedPlayerIndex2 = <Game>k__BackingField.GetRotatedPlayerIndex(3);
					jackarooThemeData2 = _runtimeTheme;
					bool flag8 = _runtimeTheme == null;
					object obj24 = !flag8;
					if (obj24 != null)
					{
						goto IL_03cd;
					}
					JackarooTheme defaultTheme4 = _defaultTheme;
					if ((object)_defaultTheme != null)
					{
						jackarooThemeData2 = defaultTheme4.<ThemeData>k__BackingField;
						if (defaultTheme4.<ThemeData>k__BackingField != null)
						{
							goto IL_03cd;
						}
					}
				}
			}
		}
		goto IL_061c;
	}

	private void ColorizeMarbles()
	{
		//IL_0810: Unknown result type (might be due to invalid IL or missing references)
		//IL_0815: Expected O, but got Unknown
		//IL_0824: Unknown result type (might be due to invalid IL or missing references)
		//IL_0829: Expected O, but got Unknown
		//IL_0835: Expected O, but got I
		//IL_009d: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		//IL_00cf: Expected O, but got I4
		//IL_0860: Expected O, but got I4
		//IL_010f: Expected O, but got I4
		//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01e2: Expected I, but got O
		//IL_01f2: Expected O, but got I
		//IL_02e8: Expected O, but got I4
		//IL_02f1: Expected O, but got I4
		//IL_0302: Expected O, but got I4
		//IL_022d: Expected O, but got I
		//IL_09cd: Expected O, but got I
		//IL_0319: Expected O, but got I4
		//IL_0322: Expected O, but got I4
		//IL_0889: Unknown result type (might be due to invalid IL or missing references)
		//IL_088e: Expected O, but got Unknown
		//IL_045e: Expected O, but got I4
		//IL_032f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0334: Expected O, but got Unknown
		//IL_033d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0342: Expected O, but got Unknown
		//IL_0374: Expected O, but got I4
		//IL_0395: Expected O, but got I4
		//IL_091b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Expected O, but got Unknown
		//IL_03ce: Expected O, but got I
		//IL_0243: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_0251: Unknown result type (might be due to invalid IL or missing references)
		//IL_0256: Expected O, but got Unknown
		//IL_0261: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Expected O, but got Unknown
		//IL_08ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cf: Expected O, but got Unknown
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_047e: Expected O, but got Unknown
		//IL_0696: Unknown result type (might be due to invalid IL or missing references)
		//IL_069b: Expected O, but got Unknown
		//IL_06b3: Expected O, but got I
		//IL_03e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e9: Expected O, but got Unknown
		//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f7: Expected O, but got Unknown
		//IL_0402: Unknown result type (might be due to invalid IL or missing references)
		//IL_0407: Expected O, but got Unknown
		//IL_075a: Expected O, but got I4
		//IL_04c8: Expected O, but got I
		//IL_06ee: Expected O, but got I
		//IL_0593: Expected O, but got I4
		//IL_0503: Expected O, but got I
		//IL_0775: Unknown result type (might be due to invalid IL or missing references)
		//IL_077a: Expected O, but got Unknown
		//IL_0950: Unknown result type (might be due to invalid IL or missing references)
		//IL_0955: Expected O, but got Unknown
		//IL_0704: Unknown result type (might be due to invalid IL or missing references)
		//IL_0709: Expected O, but got Unknown
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_0717: Expected O, but got Unknown
		//IL_05ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b3: Expected O, but got Unknown
		//IL_0519: Unknown result type (might be due to invalid IL or missing references)
		//IL_051e: Expected O, but got Unknown
		//IL_0527: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_0537: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_0602: Expected O, but got I
		//IL_061c: Expected O, but got I4
		//IL_0625: Expected O, but got I4
		//IL_062d: Expected I, but got O
		//IL_063e: Expected O, but got I4
		object obj = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj2 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 824;
		object obj3 = (nint)0 + (nint)2968;
		int num = 1;
		int rotatedPlayerIndex;
		JackarooThemeData jackarooThemeData;
		object obj5;
		nint num2;
		if ((object)<Game>k__BackingField != null)
		{
			rotatedPlayerIndex = <Game>k__BackingField.GetRotatedPlayerIndex(num);
			jackarooThemeData = _runtimeTheme;
			bool flag = _runtimeTheme == null;
			object obj4 = !flag;
			if (obj4 != null)
			{
				goto IL_0125;
			}
			JackarooTheme defaultTheme = _defaultTheme;
			bool flag2 = (object)_defaultTheme == null;
			obj5 = 0;
			num2 = num;
			if (!flag2)
			{
				jackarooThemeData = defaultTheme.<ThemeData>k__BackingField;
				bool flag3 = defaultTheme.<ThemeData>k__BackingField == null;
				obj5 = 0;
				num2 = num;
				if (!flag3)
				{
					goto IL_0125;
				}
			}
		}
		goto IL_07e1;
		IL_02aa:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X0_v49+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v389 @ X0_v49] (should have been resolved before IL gen)");
		object obj6 = default(object);
		bool flag4 = obj6 == null;
		object obj7 = !flag4;
		object obj8 = 0;
		object obj9 = obj6;
		obj5 = 0;
		if (obj7 != null)
		{
			goto IL_03ab;
		}
		obj8 = 0;
		object obj10 = 0;
		goto IL_064c;
		IL_03ab:
		object obj11 = obj6;
		object obj20 = default(object);
		object obj26 = default(object);
		Sprite playerMarbleSprite;
		bool flag6 = default(bool);
		while (true)
		{
			object obj12 = obj11;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v16+12E]");
			object obj13 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v16+12E]");
			if ((nint)0 == 0)
			{
				goto IL_044b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v476 @ X8_v16+B0]");
			object obj14 = (nint)0 + (nint)8;
			bool flag5 = flag6;
			object obj16;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X10_v24-8]");
				object obj15 = 0 - obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X10_v24-8]");
				if (0 == (nint)obj)
				{
					break;
				}
				obj16 = obj14 + 16;
				obj13--;
				obj15 = obj13 - 1;
				bool flag7 = obj15 == null;
				flag6 = (nint)obj13 != 1;
				flag5 = flag6;
				obj14 = obj16;
				if (flag6)
				{
					continue;
				}
				goto IL_044b;
			}
			object obj17 = obj12 + obj14;
			object obj18 = obj17 + 312;
			flag6 = flag5;
			obj16 = obj14;
			goto IL_08f8;
			IL_08f8:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v533 @ X0_v26+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v533 @ X0_v26] (should have been resolved before IL gen)");
			object obj19 = obj20 & 1;
			if (obj19 == null)
			{
				break;
			}
			if (obj9 == null)
			{
				goto IL_07b4;
			}
			object obj21 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v26+12E]");
			object obj22 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v26+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0580;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v26+B0]");
			object obj23 = (nint)0 + (nint)8;
			bool flag8 = flag6;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X10_v19-8]");
				object obj15 = 0 - obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X10_v19-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj16 = obj23 + 16;
				obj22--;
				obj15 = obj22 - 1;
				bool flag7 = obj15 == null;
				flag6 = (nint)obj22 != 1;
				flag8 = flag6;
				obj23 = obj16;
				if (flag6)
				{
					continue;
				}
				goto IL_0580;
			}
			object obj24 = obj21 + obj23;
			object obj25 = obj24 + 312;
			flag6 = flag8;
			obj16 = obj23;
			goto IL_097e;
			IL_097e:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v683 @ X0_v37+8]");
			num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v683 @ X0_v37] (should have been resolved before IL gen)");
			if (obj26 == null)
			{
				goto IL_079e;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X0_v39+18]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v686 @ X0_v39+18]");
				((JackarooMarbleMono)0).SetImage(playerMarbleSprite);
				bool flag9 = obj9 == null;
				object obj27 = !flag9;
				obj10 = 0;
				num2 = (nint)playerMarbleSprite;
				obj11 = obj9;
				obj5 = 0;
				if (obj27 != null)
				{
					continue;
				}
				goto IL_064c;
			}
			goto IL_07ca;
			IL_0580:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj5 = 0;
			goto IL_097e;
			IL_044b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj5 = 0;
			goto IL_08f8;
		}
		if (obj9 != null)
		{
			object obj28 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344;
			object obj29 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v22+12E]");
			object obj30 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v22+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0747;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X8_v22+B0]");
			object obj31 = (nint)0 + (nint)8;
			bool flag10 = flag6;
			object obj16;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X10_v13-8]");
				if (0 == (nint)obj28)
				{
					break;
				}
				obj16 = obj31 + 16;
				obj30--;
				flag6 = (nint)obj30 != 1;
				flag10 = flag6;
				obj31 = obj16;
				if (flag6)
				{
					continue;
				}
				goto IL_0747;
			}
			object obj32 = obj29 + obj31;
			object obj33 = obj32 + 312;
			flag6 = flag10;
			obj16 = obj31;
			goto IL_0a1b;
		}
		goto IL_07ec;
		IL_0a3a:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0125:
		playerMarbleSprite = jackarooThemeData.GetPlayerMarbleSprite(num);
		JackarooBoard jackarooBoard = <Board>k__BackingField;
		bool flag11 = <Board>k__BackingField == null;
		obj5 = 0;
		num2 = num;
		if (!flag11)
		{
			bool flag12 = jackarooBoard._playersGraveyardMarbles == null;
			obj5 = 0;
			num2 = num;
			if (!flag12)
			{
				int num3 = rotatedPlayerIndex - 1;
				obj5 = obj3;
				object obj34 = ((List<object>)(object)jackarooBoard._playersGraveyardMarbles).get_Item(num3);
				bool flag13 = obj34 == null;
				num2 = num3;
				if (!flag13)
				{
					object obj35 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3416;
					nint num4 = (nint)obj34;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v12 (Il2CppClass<System.Object>)+12E]");
					object obj36 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v12 (Il2CppClass<System.Object>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_02aa;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v358 @ X8_v12 (Il2CppClass<System.Object>)+B0]");
					object obj37 = (nint)0 + (nint)8;
					bool flag14 = flag6;
					object obj16;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v29-8]");
						object obj15 = 0 - obj35;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X10_v29-8]");
						if (0 == (nint)obj35)
						{
							break;
						}
						obj16 = obj37 + 16;
						obj36--;
						obj15 = obj36 - 1;
						bool flag7 = obj15 == null;
						flag6 = (nint)obj36 != 1;
						flag14 = flag6;
						obj37 = obj16;
						if (flag6)
						{
							continue;
						}
						goto IL_02aa;
					}
					object obj38 = num4 + obj37;
					object obj39 = obj38 + 312;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v33+8]");
					num2 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v424 @ X8_v33] (should have been resolved before IL gen)");
					bool flag15 = obj6 == null;
					obj8 = 0;
					obj9 = obj6;
					flag6 = flag14;
					obj16 = obj37;
					obj8 = 0;
					obj10 = obj5;
					if (!flag15)
					{
						goto IL_03ab;
					}
					goto IL_064c;
				}
			}
		}
		goto IL_07e1;
		IL_07ec:
		OutOfMemoryException ex = new OutOfMemoryException();
		goto IL_0a3a;
		IL_07ca:
		NullReferenceException ex2 = new NullReferenceException();
		ex = (OutOfMemoryException)(object)ex2;
		goto IL_0a3a;
		IL_07e1:
		throw new NullReferenceException();
		IL_064c:
		NullReferenceException ex3 = new NullReferenceException();
		obj5 = obj10;
		ex = (OutOfMemoryException)(object)ex3;
		goto IL_0a3a;
		IL_0747:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		obj5 = 0;
		goto IL_0a1b;
		IL_079e:
		NullReferenceException ex4 = new NullReferenceException();
		ex = (OutOfMemoryException)(object)ex4;
		goto IL_0a3a;
		IL_07b4:
		NullReferenceException ex5 = new NullReferenceException();
		ex = (OutOfMemoryException)(object)ex5;
		goto IL_0a3a;
		IL_0a1b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v30+8]");
		num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v691 @ X0_v30] (should have been resolved before IL gen)");
		goto IL_07ec;
	}

	public void HighlightMoves(List<JackarooMove> moves, bool highlightGuarded = true, bool animateFirstNode = true)
	{
		//IL_0389: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_002b: Expected O, but got I
		//IL_02de: Expected O, but got I4
		List<JackarooMove> list = default(List<JackarooMove>);
		bool flag = list == null;
		object obj = 152989696;
		if (!flag)
		{
			obj = (nint)0 + (nint)2792;
			List<object>.Enumerator enumerator = ((List<object>)(object)list).GetEnumerator();
			object obj2 = (nint)0 + (nint)2800;
			bool flag3 = default(bool);
			bool flag2 = !flag3;
			bool flag4 = flag3;
			List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
			JackarooMove jackarooMove = default(JackarooMove);
			if (!flag2)
			{
				while (true)
				{
					list = (List<JackarooMove>)obj2;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					if (jackarooMove != null)
					{
						bool flag5 = jackarooMove.<Action>k__BackingField == JackarooActions.BURN_OTHER_CARD_RANDOM;
						if (jackarooMove.<Action>k__BackingField < JackarooActions.BURN_OTHER_CARD_RANDOM)
						{
							if (jackarooMove.<Action>k__BackingField == JackarooActions.BURN_MY_CARD || jackarooMove.<Action>k__BackingField == JackarooActions.BURN_OTHER_CARD)
							{
								continue;
							}
						}
						else if (flag5 || jackarooMove.<Action>k__BackingField == JackarooActions.STEAL)
						{
							continue;
						}
						HighlightFirstNode(jackarooMove, animateFirstNode);
						HighlightNodesAndMarbles(jackarooMove);
						HighlightGuardedMarbles(jackarooMove);
						flag3 = animateFirstNode;
						continue;
					}
					goto IL_02c3;
				}
			}
			else
			{
				while (true)
				{
					list = (List<JackarooMove>)obj2;
					if (!enumerator2.MoveNext())
					{
						break;
					}
					bool flag6 = jackarooMove == null;
					flag3 = flag4;
					if (!flag6)
					{
						bool flag7 = jackarooMove.<Action>k__BackingField == JackarooActions.BURN_OTHER_CARD_RANDOM;
						if (jackarooMove.<Action>k__BackingField < JackarooActions.BURN_OTHER_CARD_RANDOM)
						{
							if (jackarooMove.<Action>k__BackingField == JackarooActions.BURN_MY_CARD || jackarooMove.<Action>k__BackingField == JackarooActions.BURN_OTHER_CARD)
							{
								continue;
							}
						}
						else if (flag7 || jackarooMove.<Action>k__BackingField == JackarooActions.STEAL)
						{
							continue;
						}
						HighlightFirstNode(jackarooMove, animateFirstNode);
						HighlightNodesAndMarbles(jackarooMove);
						flag4 = animateFirstNode;
						continue;
					}
					goto IL_02c3;
				}
			}
			enumerator2.Dispose();
			return;
		}
		goto IL_03ba;
		IL_03ba:
		NullReferenceException ex = new NullReferenceException();
		bool flag8 = (nint)list != 1;
		NullReferenceException ex2 = ex;
		List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
		List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
		if (!flag8)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			list = (List<JackarooMove>)obj;
			enumerator3.Dispose();
			object obj3 = default(object);
			if (obj3 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			enumerator4 = (List<object>.Enumerator)obj3;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BAC8");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_02c3:
		NullReferenceException ex4 = new NullReferenceException();
		enumerator3 = enumerator4;
		enumerator4 = (List<object>.Enumerator)0;
		goto IL_03ba;
	}

	public void HighlightMove(JackarooMove move, bool highlightGuarded = false, bool animateFirstNode = false)
	{
		bool flag = move.<Action>k__BackingField == JackarooActions.BURN_OTHER_CARD_RANDOM;
		if (move.<Action>k__BackingField < JackarooActions.BURN_OTHER_CARD_RANDOM)
		{
			if (move.<Action>k__BackingField == JackarooActions.BURN_MY_CARD || move.<Action>k__BackingField == JackarooActions.BURN_OTHER_CARD)
			{
				return;
			}
		}
		else if (flag || move.<Action>k__BackingField == JackarooActions.STEAL)
		{
			return;
		}
		HighlightFirstNode(move, animateFirstNode);
		HighlightNodesAndMarbles(move);
		if (highlightGuarded)
		{
			HighlightGuardedMarbles(move);
		}
	}

	public void HighlightMove2(JackarooMove move, bool animateFirstNode = false)
	{
		if (move.<Action>k__BackingField != JackarooActions.BURN_MY_CARD && move.<Action>k__BackingField != JackarooActions.BURN_OTHER_CARD && move.<Action>k__BackingField != JackarooActions.BURN_OTHER_CARD_RANDOM)
		{
			HighlightFirstNode2(move, animateFirstNode);
			HighlightNodesAndMarbles2(move);
		}
	}

	private void HighlightNodesAndMarbles(JackarooMove move)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0050: Expected I, but got O
		//IL_0060: Expected O, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a1: Expected O, but got I4
		//IL_009b: Expected O, but got I
		//IL_01d8: Expected I, but got O
		//IL_01e8: Expected O, but got I
		//IL_029b: Expected O, but got I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I
		//IL_0223: Expected O, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_034f: Expected O, but got I
		//IL_03ce: Expected O, but got I
		//IL_043b: Expected O, but got I
		IReadOnlyList<JackarooNode> <Nodes>k__BackingField = move.<Nodes>k__BackingField;
		if (move.<Nodes>k__BackingField == null)
		{
			return;
		}
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2264;
		nint num = (nint)<Nodes>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v174 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		object obj4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v230 @ X10_v14-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 = obj3 + 16;
			obj2--;
			bool flag = (nint)obj2 != 1;
			obj3 = obj4;
			if (flag)
			{
				continue;
			}
			goto IL_00e4;
		}
		object obj5 = num + obj3;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v338 @ X0_v29] (should have been resolved before IL gen)");
		object obj8 = default(object);
		object obj7 = obj8 - 1;
		bool flag2 = (nint)obj8 < 1;
		obj4 = obj3;
		if (!flag2)
		{
			goto IL_0183;
		}
		return;
		IL_0183:
		object obj9 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
		object obj10 = 0;
		object obj15 = default(object);
		while (true)
		{
			nint num2 = (nint)<Nodes>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v10 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v10 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_026c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v10 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
			object obj12 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v9-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj4 = obj12 + 16;
				obj11--;
				bool flag3 = (nint)obj11 != 1;
				obj12 = obj4;
				if (flag3)
				{
					continue;
				}
				goto IL_026c;
			}
			object obj13 = num2 + obj12;
			object obj14 = obj13 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v413 @ X0_v22] (should have been resolved before IL gen)");
			obj4 = obj12;
			goto IL_02e1;
			IL_026c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v397 @ X0_v19] (should have been resolved before IL gen)");
			bool flag4 = obj15 == null;
			object obj16 = !flag4;
			if (obj16 == null)
			{
				break;
			}
			goto IL_02e1;
			IL_02e1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v7+18]");
			HighlightNode((JackarooNodeMono)0);
			if (move.<Action>k__BackingField == JackarooActions.MOVE_EAT_PATH)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v7+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v7+20]");
					ShowMarbleDeathAnimation((JackarooMarble)0);
				}
				if (obj10 != obj7)
				{
					goto IL_01a6;
				}
			}
			else
			{
				if (obj10 != obj7)
				{
					goto IL_01a6;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v7+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v7+20]");
					ShowMarbleDeathAnimation((JackarooMarble)0);
				}
			}
			List<KPlayer> players = <Game>k__BackingField.Players;
			JackarooMarble <Marble1>k__BackingField = move.<Marble1>k__BackingField;
			int index = <Marble1>k__BackingField.<PlayerIndex>k__BackingField - 1;
			object obj17 = ((List<object>)(object)players).get_Item(index);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v12 (System.Object)+10]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v425 @ X0_v7+18]");
			HighlightLastNode((int)num3, (JackarooNodeMono)0);
			goto IL_01a6;
			IL_01a6:
			obj10++;
			if (obj10 != obj8)
			{
				continue;
			}
			return;
		}
		throw new NullReferenceException();
		IL_00e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v284 @ X0_v26] (should have been resolved before IL gen)");
		obj7 = obj8 - 1;
		if ((nint)obj8 < 1)
		{
			return;
		}
		goto IL_0183;
	}

	private void HighlightNodesAndMarbles2(JackarooMove move)
	{
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0050: Expected I, but got O
		//IL_0060: Expected O, but got I
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_0197: Expected O, but got Unknown
		//IL_01a1: Expected O, but got I4
		//IL_009b: Expected O, but got I
		//IL_01d8: Expected I, but got O
		//IL_01e8: Expected O, but got I
		//IL_029b: Expected O, but got I4
		//IL_0133: Unknown result type (might be due to invalid IL or missing references)
		//IL_0138: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_02f3: Expected O, but got I
		//IL_0223: Expected O, but got I
		//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Expected O, but got Unknown
		//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02bb: Expected O, but got Unknown
		//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c9: Expected O, but got Unknown
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_0236: Expected O, but got Unknown
		//IL_023f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0244: Expected O, but got Unknown
		//IL_0349: Expected O, but got I
		//IL_03b6: Expected O, but got I
		IReadOnlyList<JackarooNode> <Nodes2>k__BackingField = move.<Nodes2>k__BackingField;
		if (move.<Nodes2>k__BackingField == null)
		{
			return;
		}
		object obj = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2264;
		nint num = (nint)<Nodes2>k__BackingField;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00e4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v172 @ X8_v7 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		object obj4;
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X10_v14-8]");
			if (0 == (nint)obj)
			{
				break;
			}
			obj4 = obj3 + 16;
			obj2--;
			bool flag = (nint)obj2 != 1;
			obj3 = obj4;
			if (flag)
			{
				continue;
			}
			goto IL_00e4;
		}
		object obj5 = num + obj3;
		object obj6 = obj5 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v334 @ X0_v27] (should have been resolved before IL gen)");
		object obj8 = default(object);
		object obj7 = obj8 - 1;
		bool flag2 = (nint)obj8 < 1;
		obj4 = obj3;
		if (!flag2)
		{
			goto IL_0183;
		}
		return;
		IL_0183:
		object obj9 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
		object obj10 = 0;
		object obj16 = default(object);
		while (true)
		{
			nint num2 = (nint)<Nodes2>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v10 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			object obj11 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v10 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_026c;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X8_v10 (Il2CppClass<System.Collections.Generic.IReadOnlyList`1<Jackaroo.JackarooNode>>)+B0]");
			object obj12 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v9-8]");
				if (0 == (nint)obj9)
				{
					break;
				}
				obj4 = obj12 + 16;
				obj11--;
				bool flag3 = (nint)obj11 != 1;
				obj12 = obj4;
				if (flag3)
				{
					continue;
				}
				goto IL_026c;
			}
			object obj13 = num2 + obj12;
			object obj14 = obj13 + 312;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v409 @ X0_v20] (should have been resolved before IL gen)");
			obj4 = obj12;
			goto IL_02e1;
			IL_02e1:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v7+18]");
			HighlightNode((JackarooNodeMono)0);
			if (obj10 == obj7)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v7+20]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v7+20]");
					ShowMarbleDeathAnimation((JackarooMarble)0);
				}
				List<KPlayer> players = <Game>k__BackingField.Players;
				JackarooMarble <Marble2>k__BackingField = move.<Marble2>k__BackingField;
				int index = <Marble2>k__BackingField.<PlayerIndex>k__BackingField - 1;
				object obj15 = ((List<object>)(object)players).get_Item(index);
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v12 (System.Object)+10]");
				nint num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v7+18]");
				HighlightLastNode((int)num3, (JackarooNodeMono)0);
			}
			obj10++;
			if (obj10 != obj8)
			{
				continue;
			}
			return;
			IL_026c:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v393 @ X0_v17] (should have been resolved before IL gen)");
			bool flag4 = obj16 == null;
			object obj17 = !flag4;
			if (obj17 == null)
			{
				break;
			}
			goto IL_02e1;
		}
		throw new NullReferenceException();
		IL_00e4:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v280 @ X0_v24] (should have been resolved before IL gen)");
		obj7 = obj8 - 1;
		if ((nint)obj8 < 1)
		{
			return;
		}
		goto IL_0183;
	}

	private void HighlightNode(JackarooNodeMono node)
	{
		//IL_0071: Expected O, but got I4
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bf: Expected O, but got Unknown
		node.SetSelectedColor();
		List<object> selectedNodes = (List<object>)(object)_selectedNodes;
		int version = selectedNodes._version + 1;
		selectedNodes._version = version;
		object[] items = selectedNodes._items;
		bool flag = selectedNodes._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = selectedNodes._size + 1;
			selectedNodes._size = size;
			object obj2 = items + selectedNodes._size;
			object obj3 = obj2 + 32;
			obj3 = node;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			selectedNodes.AddWithResize((object)node);
		}
	}

	private static void HideNodesHighlight(List<JackarooNodeMono> nodes)
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_018b: Expected I, but got O
		//IL_0121: Expected I, but got O
		//IL_00d3: Expected O, but got I4
		object obj2 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		nint num = default(nint);
		if (nodes != null)
		{
			object obj = (nint)0 + (nint)2848;
			obj2 = (nint)0 + (nint)2840;
			List<object>.Enumerator enumerator = ((List<object>)(object)nodes).GetEnumerator();
			num = (nint)obj;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				goto IL_004e;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj3 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj2;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				goto IL_004e;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BA48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_004e:
		int version = nodes._version + 1;
		nodes._size = 0;
		nodes._version = version;
		if (nodes._size >= 1)
		{
			Array.Clear(nodes._items, 0, nodes._size);
		}
	}

	private void HighlightFirstNode(JackarooMove move, bool animate)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		JackarooMarble <Marble1>k__BackingField = move.<Marble1>k__BackingField;
		JackarooNode <Node>k__BackingField = <Marble1>k__BackingField.<Node>k__BackingField;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!(<Node>k__BackingField.<NodeMono>k__BackingField != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = <Node>k__BackingField.<NodeMono>k__BackingField != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		HighlightFirstNode(<Node>k__BackingField.<NodeMono>k__BackingField, animate);
	}

	private void HighlightFirstNode2(JackarooMove move, bool animate)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_00e2: Expected O, but got I4
		JackarooMarble <Marble2>k__BackingField = move.<Marble2>k__BackingField;
		JackarooNode <Node>k__BackingField = <Marble2>k__BackingField.<Node>k__BackingField;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v3+E4]");
		if ((nint)0 != 0)
		{
			if (!(<Node>k__BackingField.<NodeMono>k__BackingField != null))
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = <Node>k__BackingField.<NodeMono>k__BackingField != null;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				return;
			}
		}
		HighlightFirstNode(<Node>k__BackingField.<NodeMono>k__BackingField, animate);
	}

	public void HighlightFirstNode(JackarooNodeMono node, bool animate = true)
	{
		//IL_0098: Expected O, but got I4
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		node.ShowHighlight();
		if (animate)
		{
			node.StartHighlightAnimation();
		}
		List<object> highlightedFirstNodes = (List<object>)(object)_highlightedFirstNodes;
		int version = highlightedFirstNodes._version + 1;
		highlightedFirstNodes._version = version;
		object[] items = highlightedFirstNodes._items;
		bool flag = highlightedFirstNodes._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = highlightedFirstNodes._size + 1;
			highlightedFirstNodes._size = size;
			object obj2 = items + highlightedFirstNodes._size;
			object obj3 = obj2 + 32;
			obj3 = node;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			highlightedFirstNodes.AddWithResize((object)node);
		}
	}

	private void HideFirstNodesHighlight(List<JackarooNodeMono> highlightedFirstNodes)
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_00de: Expected O, but got I4
		bool flag = highlightedFirstNodes == null;
		List<JackarooNodeMono> list = highlightedFirstNodes;
		object obj2 = default(object);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			object obj = (nint)0 + (nint)2848;
			obj2 = (nint)0 + (nint)2840;
			List<object>.Enumerator enumerator = ((List<object>)(object)highlightedFirstNodes).GetEnumerator();
			list = (List<JackarooNodeMono>)obj;
			if (!enumerator2.MoveNext())
			{
				enumerator2.Dispose();
				goto IL_0059;
			}
			NullReferenceException ex = new NullReferenceException();
			object obj3 = 0;
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag2 = (nint)list != 1;
		NullReferenceException ex3 = ex2;
		if (!flag2)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			list = (List<JackarooNodeMono>)obj2;
			enumerator2.Dispose();
			object obj4 = default(object);
			if (obj4 == null)
			{
				goto IL_0059;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BA48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0059:
		int version = highlightedFirstNodes._version + 1;
		highlightedFirstNodes._size = 0;
		highlightedFirstNodes._version = version;
		if (highlightedFirstNodes._size >= 1)
		{
			Array.Clear(highlightedFirstNodes._items, 0, highlightedFirstNodes._size);
		}
	}

	private void HighlightLastNode(int marbleIndex, JackarooNodeMono node)
	{
		//IL_0160: Expected O, but got I4
		//IL_004e: Expected O, but got I4
		//IL_00bf: Expected O, but got I4
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ff: Expected O, but got Unknown
		//IL_0108: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		JackarooThemeData jackarooThemeData = _runtimeTheme;
		if (_runtimeTheme != null)
		{
			if (!jackarooThemeData.<HighlightLastNode>k__BackingField)
			{
				return;
			}
		}
		else
		{
			JackarooTheme defaultTheme = _defaultTheme;
			jackarooThemeData = defaultTheme.<ThemeData>k__BackingField;
			bool flag = !jackarooThemeData.<HighlightLastNode>k__BackingField;
			object obj = !flag;
			if (obj == null)
			{
				return;
			}
		}
		int rotatedIndex = default(int);
		Color playerColor = jackarooThemeData.GetPlayerColor(rotatedIndex);
		node.SetHighlightColor((Color)0);
		node.ShowHighlight();
		List<object> highlightedLastNodes = (List<object>)(object)_highlightedLastNodes;
		int version = highlightedLastNodes._version + 1;
		highlightedLastNodes._version = version;
		object[] items = highlightedLastNodes._items;
		bool flag2 = highlightedLastNodes._size < items.Length;
		object obj2 = !flag2;
		if (obj2 == null)
		{
			int size = highlightedLastNodes._size + 1;
			highlightedLastNodes._size = size;
			object obj3 = items + highlightedLastNodes._size;
			object obj4 = obj3 + 32;
			obj4 = node;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			highlightedLastNodes.AddWithResize((object)node);
		}
	}

	private void HideLastNodesHighlight(List<JackarooNodeMono> highlightedLastNodes)
	{
		//IL_024a: Expected O, but got I4
		//IL_00d1: Expected O, but got I
		//IL_01d7: Expected O, but got I
		//IL_0185: Expected O, but got I4
		JackarooThemeData jackarooThemeData = _runtimeTheme;
		bool flag = _runtimeTheme == null;
		object obj = !flag;
		if (obj != null)
		{
			goto IL_006d;
		}
		JackarooTheme defaultTheme = _defaultTheme;
		bool flag2 = (object)_defaultTheme == null;
		List<JackarooNodeMono> list = highlightedLastNodes;
		if (!flag2)
		{
			jackarooThemeData = defaultTheme.<ThemeData>k__BackingField;
			bool flag3 = defaultTheme.<ThemeData>k__BackingField == null;
			list = highlightedLastNodes;
			if (!flag3)
			{
				goto IL_006d;
			}
		}
		goto IL_0258;
		IL_0100:
		int version = highlightedLastNodes._version + 1;
		highlightedLastNodes._size = 0;
		highlightedLastNodes._version = version;
		if (highlightedLastNodes._size >= 1)
		{
			Array.Clear(highlightedLastNodes._items, 0, highlightedLastNodes._size);
		}
		return;
		IL_0258:
		NullReferenceException ex = new NullReferenceException();
		bool flag4 = (nint)list != 1;
		NullReferenceException ex2 = ex;
		List<object>.Enumerator enumerator = default(List<object>.Enumerator);
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj2 = (nint)0 + (nint)2840;
			list = (List<JackarooNodeMono>)obj2;
			enumerator.Dispose();
			object obj3 = default(object);
			if (obj3 == null)
			{
				goto IL_0100;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			object obj4 = obj3;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BA48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_006d:
		if (!jackarooThemeData.<HighlightLastNode>k__BackingField)
		{
			return;
		}
		bool flag5 = highlightedLastNodes == null;
		list = highlightedLastNodes;
		if (!flag5)
		{
			List<object>.Enumerator enumerator2 = ((List<object>)(object)highlightedLastNodes).GetEnumerator();
			object obj5 = (nint)0 + (nint)2848;
			list = (List<JackarooNodeMono>)obj5;
			if (!enumerator.MoveNext())
			{
				enumerator.Dispose();
				goto IL_0100;
			}
			NullReferenceException ex4 = new NullReferenceException();
			object obj4 = 0;
		}
		goto IL_0258;
	}

	private void ShowMarbleDeathAnimation(JackarooMarble marble)
	{
		//IL_0076: Expected O, but got I4
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b6: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		marble.<MarbleMono>k__BackingField.ShowDeath();
		List<object> deathMarbles = (List<object>)(object)_deathMarbles;
		int version = deathMarbles._version + 1;
		deathMarbles._version = version;
		object[] items = deathMarbles._items;
		bool flag = deathMarbles._size < items.Length;
		object obj = !flag;
		if (obj == null)
		{
			int size = deathMarbles._size + 1;
			deathMarbles._size = size;
			object obj2 = items + deathMarbles._size;
			object obj3 = obj2 + 32;
			obj3 = marble.<MarbleMono>k__BackingField;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
		else
		{
			deathMarbles.AddWithResize((object)marble.<MarbleMono>k__BackingField);
		}
	}

	public void HideHighlights()
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_020a: Expected I, but got O
		//IL_004a: Expected I, but got O
		//IL_005d: Expected O, but got I4
		//IL_0196: Expected I, but got O
		//IL_0147: Expected O, but got I4
		object obj2 = default(object);
		nint num = default(nint);
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (_deathMarbles != null)
		{
			object obj = (nint)0 + (nint)2776;
			obj2 = (nint)0 + (nint)2768;
			List<object>.Enumerator enumerator = ((List<object>)(object)_deathMarbles).GetEnumerator();
			num = (nint)obj;
			object obj3;
			if (!enumerator2.MoveNext())
			{
				num = (nint)obj2;
				enumerator2.Dispose();
				obj3 = 0;
				goto IL_0063;
			}
			NullReferenceException ex = new NullReferenceException();
			obj3 = 0;
		}
		goto IL_0234;
		IL_0234:
		NullReferenceException ex2 = new NullReferenceException();
		bool flag = num != 1;
		NullReferenceException ex3 = ex2;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj2;
			enumerator2.Dispose();
			object obj4 = default(object);
			bool flag2 = obj4 == null;
			object obj3 = obj4;
			if (flag2)
			{
				goto IL_0063;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			obj3 = obj4;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
		return;
		IL_0063:
		List<JackarooMarbleMono> deathMarbles = _deathMarbles;
		if (_deathMarbles != null)
		{
			int version = deathMarbles._version + 1;
			deathMarbles._size = 0;
			deathMarbles._version = version;
			if (deathMarbles._size >= 1)
			{
				Array.Clear(deathMarbles._items, 0, deathMarbles._size);
			}
			HideGuardedMarblesHighlight();
			HideFirstNodesHighlight(_highlightedFirstNodes);
			HideNodesHighlight(_selectedNodes);
			HideLastNodesHighlight(_highlightedLastNodes);
			return;
		}
		goto IL_0234;
	}

	private void ReapplyActiveHighlightStates()
	{
		//IL_02b8: Expected O, but got I4
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_02ce: Expected I, but got O
		//IL_0065: Expected I, but got O
		//IL_0098: Expected O, but got I4
		//IL_0240: Expected I, but got O
		//IL_019e: Expected O, but got I4
		//IL_030e: Expected I, but got O
		//IL_00ed: Expected I, but got O
		//IL_0120: Expected O, but got I4
		//IL_01c5: Expected O, but got I4
		//IL_0340: Expected I, but got O
		//IL_01ec: Expected O, but got I4
		bool flag = _selectedNodes == null;
		List<object>.Enumerator enumerator = (List<object>.Enumerator)0;
		object obj2 = default(object);
		nint num = default(nint);
		if (!flag)
		{
			object obj = (nint)0 + (nint)2848;
			obj2 = (nint)0 + (nint)2840;
			List<object>.Enumerator enumerator2 = ((List<object>)(object)_selectedNodes).GetEnumerator();
			List<object>.Enumerator enumerator3 = default(List<object>.Enumerator);
			JackarooNodeMono jackarooNodeMono = default(JackarooNodeMono);
			List<object>.Enumerator enumerator7 = default(List<object>.Enumerator);
			List<object>.Enumerator enumerator9 = default(List<object>.Enumerator);
			List<object>.Enumerator enumerator4 = default(List<object>.Enumerator);
			while (true)
			{
				num = (nint)obj;
				List<object>.Enumerator enumerator5;
				if (enumerator3.MoveNext())
				{
					if ((object)jackarooNodeMono != null)
					{
						jackarooNodeMono.SetSelectedColor();
						continue;
					}
					NullReferenceException ex = new NullReferenceException();
					enumerator = enumerator4;
					enumerator5 = enumerator4;
					enumerator4 = (List<object>.Enumerator)0;
					break;
				}
				num = (nint)obj2;
				enumerator3.Dispose();
				bool flag2 = _highlightedFirstNodes == null;
				enumerator = enumerator4;
				enumerator5 = enumerator4;
				enumerator4 = (List<object>.Enumerator)0;
				if (flag2)
				{
					break;
				}
				List<object>.Enumerator enumerator6 = ((List<object>)(object)_highlightedFirstNodes).GetEnumerator();
				while (true)
				{
					num = (nint)obj;
					if (enumerator7.MoveNext())
					{
						if ((object)jackarooNodeMono != null)
						{
							jackarooNodeMono.ShowHighlight();
							continue;
						}
						NullReferenceException ex2 = new NullReferenceException();
						enumerator = enumerator4;
						enumerator5 = enumerator4;
						enumerator4 = (List<object>.Enumerator)0;
						break;
					}
					num = (nint)obj2;
					enumerator7.Dispose();
					bool flag3 = _highlightedLastNodes == null;
					enumerator = enumerator4;
					enumerator5 = enumerator4;
					enumerator4 = (List<object>.Enumerator)0;
					if (flag3)
					{
						break;
					}
					List<object>.Enumerator enumerator8 = ((List<object>)(object)_highlightedLastNodes).GetEnumerator();
					while (true)
					{
						num = (nint)obj;
						if (enumerator9.MoveNext())
						{
							if ((object)jackarooNodeMono == null)
							{
								break;
							}
							jackarooNodeMono.ShowHighlight();
							continue;
						}
						enumerator9.Dispose();
						return;
					}
					NullReferenceException ex3 = new NullReferenceException();
					enumerator = enumerator4;
					enumerator5 = enumerator4;
					enumerator4 = (List<object>.Enumerator)0;
					break;
				}
				break;
			}
		}
		NullReferenceException ex4 = new NullReferenceException();
		bool flag4 = num != 1;
		NullReferenceException ex5 = ex4;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			num = (nint)obj2;
			enumerator.Dispose();
			object obj3 = default(object);
			if (obj3 == null)
			{
				return;
			}
			OutOfMemoryException ex6 = new OutOfMemoryException();
			List<object>.Enumerator enumerator4 = (List<object>.Enumerator)obj3;
			ex5 = (NullReferenceException)(object)ex6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BA48");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void ClearGuardedMarbles()
	{
		((Dictionary<object, object>)(object)_guardedMarblesDictionary).Clear();
	}

	private void InitializeGuardedMarblesPool()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_024f: Expected O, but got I4
		//IL_0095: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_02f1: Expected O, but got I4
		//IL_0287: Expected O, but got I
		//IL_0297: Expected O, but got I
		//IL_02b9: Expected O, but got I4
		//IL_0477: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_0492: Expected O, but got I
		//IL_049a: Expected I, but got O
		//IL_04ab: Expected I, but got O
		//IL_04c9: Expected O, but got I
		//IL_0350: Expected O, but got I4
		//IL_0359: Expected O, but got I4
		//IL_0361: Expected I, but got O
		//IL_0372: Expected O, but got I4
		//IL_037a: Expected I, but got O
		//IL_0382: Expected I, but got O
		//IL_0321: Expected O, but got I
		//IL_012e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected O, but got Unknown
		//IL_013f: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_0181: Expected O, but got I4
		//IL_020f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		//IL_01b1: Expected O, but got I4
		//IL_03e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03eb: Expected O, but got Unknown
		//IL_0401: Expected O, but got I
		//IL_0409: Expected I, but got O
		//IL_041a: Expected I, but got O
		//IL_0438: Expected O, but got I
		//IL_0453: Expected O, but got I4
		//IL_045b: Expected I, but got O
		//IL_01e1: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F49]");
		object obj3 = (nint)0 & (nint)1;
		object obj4;
		if (obj3 != null)
		{
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v38+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			if (!flag)
			{
				goto IL_0085;
			}
		}
		else
		{
			_ = 1;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v38+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			if (obj6 != null)
			{
				goto IL_0085;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v38+B8]");
		object obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+30]");
		Func<object> func = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+30]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		object obj9 = obj4;
		if (obj8 != null)
		{
			goto IL_00d2;
		}
		goto IL_02cf;
		IL_00d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v38+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = default(object);
		object obj10 = obj11;
		nint num2 = default(nint);
		nint num = num2;
		nint num4 = default(nint);
		nint num3 = num4;
		object obj12 = obj4;
		Func<object> func2 = func;
		if (!flag4)
		{
			goto IL_011f;
		}
		goto IL_03a0;
		IL_03a0:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		obj11 = obj10;
		num2 = num;
		num4 = num3;
		func = func2;
		goto IL_011f;
		IL_011f:
		object obj13 = typeof(List<Tween>) + 2992;
		object obj14 = (nint)0 + (nint)3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v38+B8]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v20+38]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X8_v20+38]");
		bool flag5 = (nint)0 == 0;
		object obj16 = !flag5;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v38+E4]");
			bool flag6 = (nint)0 == 0;
			object obj17 = !flag6;
			if (obj17 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				object obj18 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v186 @ X8_v26+B8]");
				obj15 = 0;
			}
			object obj19 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 816;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj20 = (nint)0 + (nint)1512;
			num4 = (nint)obj20;
			Action<object> action2 = default(Action<object>);
			action2..ctor(obj15, (IntPtr)obj20);
			object obj21 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v25+B8]");
			object obj22 = (nint)0 + (nint)56;
			obj22 = action2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj11 = 0;
			num2 = (nint)action2;
			action = action2;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C3500");
		PooledObjectList<List<JackarooMarbleMono>> pooledGuardedMarbles = default(PooledObjectList<List<JackarooMarbleMono>>);
		_pooledGuardedMarbles = pooledGuardedMarbles;
		object obj23 = this + 416;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return;
		IL_0085:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v38+B8]");
		obj7 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+30]");
		func = (Func<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v4+30]");
		bool flag7 = (nint)0 == 0;
		obj9 = obj4;
		if (!flag7)
		{
			goto IL_00d2;
		}
		goto IL_02cf;
		IL_02cf:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v4+E4]");
		bool flag8 = (nint)0 == 0;
		object obj24 = !flag8;
		if (obj24 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj25 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v11+B8]");
			obj7 = 0;
		}
		object obj26 = typeof(System.Dynamic.Utils.EmptyReadOnlyCollection<ParameterExpression>) + 1936;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj27 = (nint)0 + (nint)1504;
		num4 = (nint)obj27;
		Func<object> func3 = default(Func<object>);
		func3..ctor(obj7, (IntPtr)obj27);
		object obj28 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X8_v9+B8]");
		object obj29 = (nint)0 + (nint)48;
		obj29 = func3;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj4 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v38+E4]");
		bool flag9 = (nint)0 == 0;
		object obj30 = !flag9;
		obj11 = 0;
		num2 = (nint)func3;
		func = func3;
		obj10 = 0;
		num = (nint)func3;
		num3 = (nint)obj27;
		obj12 = obj4;
		func2 = func3;
		if (obj30 != null)
		{
			goto IL_011f;
		}
		goto IL_03a0;
	}

	private void ReleasePooledGuardedMarbles()
	{
		//IL_0011: Expected O, but got I
		object obj = (nint)0 + (nint)3768;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C3728");
	}

	private void AddGuardedMarble(Card card, JackarooMarbleMono marble)
	{
		//IL_0011: Expected O, but got I
		//IL_014c: Expected O, but got I
		//IL_004d: Expected O, but got I
		//IL_0078: Expected O, but got I4
		//IL_01af: Expected O, but got I4
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ef: Expected O, but got Unknown
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fd: Expected O, but got Unknown
		//IL_00da: Expected O, but got I4
		//IL_0115: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Expected O, but got Unknown
		//IL_0123: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		object obj = (nint)0 + (nint)2008;
		if (((Dictionary<object, object>)(object)_guardedMarblesDictionary).TryGetValue((object)card, out object value))
		{
			object obj2 = (nint)0 + (nint)2272;
			bool flag = ((List<object>)value).Contains((object)marble);
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 == null)
			{
				int version = ((List<object>)value)._version + 1;
				((List<object>)value)._version = version;
				object[] items = ((List<object>)value)._items;
				bool flag3 = ((List<object>)value)._size < items.Length;
				object obj4 = !flag3;
				if (obj4 == null)
				{
					int size = ((List<object>)value)._size + 1;
					((List<object>)value)._size = size;
					object obj5 = items + ((List<object>)value)._size;
					object obj6 = obj5 + 32;
					obj6 = marble;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				}
				else
				{
					((List<object>)value).AddWithResize((object)marble);
				}
			}
		}
		else
		{
			object obj7 = (nint)0 + (nint)3760;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @39C364C");
			List<object> list = default(List<object>);
			int version2 = list._version + 1;
			list._version = version2;
			object[] items2 = list._items;
			bool flag4 = list._size < items2.Length;
			object obj8 = !flag4;
			if (obj8 == null)
			{
				int size2 = list._size + 1;
				list._size = size2;
				object obj9 = items2 + list._size;
				object obj10 = obj9 + 32;
				obj10 = marble;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				list.AddWithResize((object)marble);
			}
			((Dictionary<object, object>)(object)_guardedMarblesDictionary).Add((object)card, (object)list);
		}
	}

	public unsafe void HighlightGuardedMarbles(JackarooMove move)
	{
		//IL_0038: Expected O, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Ref, but got Unknown
		//IL_014a: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		JackarooMove jackarooMove = default(JackarooMove);
		bool flag = jackarooMove == null;
		IntPtr intPtr = default(IntPtr);
		ref object reference = ref *(object*)intPtr;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			bool flag2 = _guardedMarblesDictionary == null;
			reference = ref *(object*)intPtr;
			if (!flag2)
			{
				object obj = (nint)0 + (nint)2008;
				if (!((Dictionary<object, object>)(object)_guardedMarblesDictionary).TryGetValue((object)jackarooMove.<Card>k__BackingField, out *(object*)(this + 376)))
				{
					return;
				}
				bool flag3 = _guardedMarbles == null;
				jackarooMove = (JackarooMove)(object)jackarooMove.<Card>k__BackingField;
				if (!flag3)
				{
					List<object>.Enumerator enumerator = ((List<object>)(object)_guardedMarbles).GetEnumerator();
					object obj2 = (nint)0 + (nint)2776;
					jackarooMove = (JackarooMove)obj2;
					if (!enumerator2.MoveNext())
					{
						enumerator2.Dispose();
						return;
					}
					NullReferenceException ex = new NullReferenceException();
					object obj3 = 0;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag4 = (nint)jackarooMove != 1;
		NullReferenceException ex3 = ex2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj4 = (nint)0 + (nint)2768;
			jackarooMove = (JackarooMove)obj4;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	public unsafe void HighlightGuardedMarbles(GameCard card)
	{
		//IL_0038: Expected O, but got I
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected Ref, but got Unknown
		//IL_014a: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00f8: Expected O, but got I4
		GameCard gameCard = default(GameCard);
		bool flag = (object)gameCard == null;
		IntPtr intPtr = default(IntPtr);
		ref object reference = ref *(object*)intPtr;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!flag)
		{
			bool flag2 = _guardedMarblesDictionary == null;
			reference = ref *(object*)intPtr;
			if (!flag2)
			{
				object obj = (nint)0 + (nint)2008;
				if (!((Dictionary<object, object>)(object)_guardedMarblesDictionary).TryGetValue((object)((UiCard)gameCard).card, out *(object*)(this + 376)))
				{
					return;
				}
				bool flag3 = _guardedMarbles == null;
				gameCard = (GameCard)(object)((UiCard)gameCard).card;
				if (!flag3)
				{
					List<object>.Enumerator enumerator = ((List<object>)(object)_guardedMarbles).GetEnumerator();
					object obj2 = (nint)0 + (nint)2776;
					gameCard = (GameCard)obj2;
					if (!enumerator2.MoveNext())
					{
						enumerator2.Dispose();
						return;
					}
					NullReferenceException ex = new NullReferenceException();
					object obj3 = 0;
				}
			}
		}
		NullReferenceException ex2 = new NullReferenceException();
		bool flag4 = (nint)gameCard != 1;
		NullReferenceException ex3 = ex2;
		if (!flag4)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			object obj4 = (nint)0 + (nint)2768;
			gameCard = (GameCard)obj4;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex4 = new OutOfMemoryException();
			object obj3 = obj5;
			ex3 = (NullReferenceException)(object)ex4;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void HideGuardedMarblesHighlight()
	{
		//IL_0012: Expected O, but got I
		//IL_001e: Expected O, but got I
		//IL_007b: Expected O, but got I4
		if (_guardedMarbles == null)
		{
			return;
		}
		object obj = (nint)0 + (nint)2776;
		object obj2 = (nint)0 + (nint)2768;
		List<object>.Enumerator enumerator = ((List<object>)(object)_guardedMarbles).GetEnumerator();
		object obj3 = obj;
		List<object>.Enumerator enumerator2 = default(List<object>.Enumerator);
		if (!enumerator2.MoveNext())
		{
			enumerator2.Dispose();
			return;
		}
		NullReferenceException ex = new NullReferenceException();
		bool flag = (nint)obj != 1;
		object obj4 = 0;
		NullReferenceException ex2 = ex;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
			obj3 = obj2;
			enumerator2.Dispose();
			object obj5 = default(object);
			if (obj5 == null)
			{
				return;
			}
			OutOfMemoryException ex3 = new OutOfMemoryException();
			obj4 = obj5;
			ex2 = (NullReferenceException)(object)ex3;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @223BB08");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
	}

	private void CheckMarbleBlocksBase(JackarooMarble marbleToMove)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_04a8: Expected O, but got I
		//IL_04be: Expected O, but got I
		//IL_04d8: Expected O, but got I4
		//IL_0313: Expected O, but got I4
		//IL_032e: Expected O, but got I4
		//IL_035e: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0393: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_021f: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+1]");
		object obj4 = (nint)0 & (nint)0x80;
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 != null)
		{
			return;
		}
		int rotatedPlayerIndex;
		if (marbleToMove != null)
		{
			JackarooNode <Node>k__BackingField = marbleToMove.<Node>k__BackingField;
			if (marbleToMove.<Node>k__BackingField != null)
			{
				if (<Node>k__BackingField.<Type>k__BackingField != JackarooNodeType.Base)
				{
					if (<Node>k__BackingField.<Type>k__BackingField != JackarooNodeType.BaseEntry)
					{
						return;
					}
					JackarooBoard jackarooBoard = <Board>k__BackingField;
					if (<Board>k__BackingField != null)
					{
						(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes = jackarooBoard._homesAndBasesEntryNodes;
						if (jackarooBoard._homesAndBasesEntryNodes != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v19 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+28]");
							(JackarooNode, JackarooNode) tuple = ((JackarooNode, JackarooNode))0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v19 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+28]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v178 @ X10_v6 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
								if (0 != (nint)marbleToMove)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v19 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+38]");
									(JackarooNode, JackarooNode) tuple2 = ((JackarooNode, JackarooNode))0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v19 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+38]");
									if ((nint)0 == 0)
									{
										goto IL_047b;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v179 @ X10_v8 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
									if (0 != (nint)marbleToMove)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v19 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+48]");
										(JackarooNode, JackarooNode) tuple3 = ((JackarooNode, JackarooNode))0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v19 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+48]");
										if ((nint)0 == 0)
										{
											goto IL_047b;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X10_v10 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
										if (0 != (nint)marbleToMove)
										{
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v19 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+58]");
											(JackarooNode, JackarooNode) tuple4 = ((JackarooNode, JackarooNode))0;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v19 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+58]");
											if ((nint)0 == 0)
											{
												goto IL_047b;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v23 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
											if (0 != (nint)marbleToMove || marbleToMove.<PlayerIndex>k__BackingField == 4)
											{
												return;
											}
											rotatedPlayerIndex = 4;
										}
										else
										{
											bool flag2 = marbleToMove.<PlayerIndex>k__BackingField == 3;
											rotatedPlayerIndex = 3;
											if (flag2)
											{
												return;
											}
										}
									}
									else
									{
										bool flag3 = marbleToMove.<PlayerIndex>k__BackingField != 2;
										rotatedPlayerIndex = 2;
										if (!flag3)
										{
											return;
										}
									}
								}
								else
								{
									if (marbleToMove.<PlayerIndex>k__BackingField == 1)
									{
										return;
									}
									rotatedPlayerIndex = 1;
								}
								goto IL_0470;
							}
						}
					}
				}
				else
				{
					JackarooBoard jackarooBoard2 = <Board>k__BackingField;
					if (<Board>k__BackingField != null)
					{
						(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes2 = jackarooBoard2._homesAndBasesEntryNodes;
						if (jackarooBoard2._homesAndBasesEntryNodes != null)
						{
							rotatedPlayerIndex = marbleToMove.<PlayerIndex>k__BackingField;
							object obj6 = marbleToMove.<PlayerIndex>k__BackingField - 1;
							bool flag4 = (nint)obj6 < homesAndBasesEntryNodes2.Length;
							object obj7 = !flag4;
							if (obj7 != null)
							{
								goto IL_0489;
							}
							object obj8 = (object)jackarooBoard2._homesAndBasesEntryNodes + obj6;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v14+28]");
							object obj9 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v14+28]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v15+20]");
								object obj10 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v15+20]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v165 @ X8_v16+10]");
									if ((nint)0 != marbleToMove.<PlayerIndex>k__BackingField)
									{
										goto IL_0470;
									}
									return;
								}
								return;
							}
						}
					}
				}
			}
		}
		goto IL_047b;
		IL_0470:
		BlockBase(rotatedPlayerIndex);
		return;
		IL_0489:
		throw new IndexOutOfRangeException();
		IL_047b:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0489;
	}

	private unsafe void BlockBase(int rotatedPlayerIndex)
	{
		//IL_0016: Expected O, but got I
		//IL_0024: Expected O, but got I4
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected I4, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_007f: Unsupported input type for neg.
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected I4, but got Unknown
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00c1: Expected I, but got O
		//IL_00d1: Expected O, but got I
		//IL_00f1: Expected O, but got I4
		//IL_0112: Expected O, but got I4
		//IL_0249: Expected I, but got O
		//IL_0259: Expected O, but got I
		//IL_02f7: Expected O, but got I
		//IL_031b: Expected O, but got I4
		//IL_0397: Expected O, but got I4
		//IL_01e8: Expected O, but got I
		//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f6: Expected O, but got Unknown
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_03d1: Expected O, but got I
		//IL_03da: Unknown result type (might be due to invalid IL or missing references)
		//IL_03df: Expected O, but got Unknown
		//IL_03ef: Expected I, but got O
		//IL_03ff: Expected O, but got I
		//IL_0421: Expected O, but got I4
		//IL_0340: Expected O, but got I
		//IL_0349: Unknown result type (might be due to invalid IL or missing references)
		//IL_034e: Expected O, but got Unknown
		//IL_035e: Expected O, but got I
		//IL_02b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b5: Expected O, but got Unknown
		JackarooBoard jackarooBoard = <Board>k__BackingField;
		object obj = (nint)0 + (nint)3000;
		object obj2 = 5 - rotatedPlayerIndex;
		int num = obj2 & 3;
		object obj3 = 0 - obj2;
		object obj4 = obj3 & 3;
		int index = ((0 >= (nint)obj3) ? (0 - obj4) : num);
		object obj5 = obj;
		object obj6 = ((List<object>)(object)jackarooBoard._basesNodes).get_Item(index);
		object obj7 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2264;
		object obj8 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 2488;
		object obj9 = obj7;
		nint num2 = (nint)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v20 (Il2CppClass<System.Object>)+12E]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v20 (Il2CppClass<System.Object>)+12E]");
		bool flag = (nint)0 == 0;
		object obj11 = 0;
		float num4 = default(float);
		float num3 = num4;
		float num6 = default(float);
		float num5 = num6;
		object obj12 = obj7;
		object obj13 = 0;
		if (!flag)
		{
			goto IL_0120;
		}
		goto IL_01a1;
		IL_01a1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v308 @ X0_v20] (should have been resolved before IL gen)");
		object obj14 = default(object);
		if (obj13 >= obj14)
		{
			return;
		}
		goto IL_0241;
		IL_0241:
		nint num7 = (nint)obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v11 (Il2CppClass<System.Object>)+12E]");
		object obj15 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v11 (Il2CppClass<System.Object>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_02dd;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v11 (Il2CppClass<System.Object>)+B0]");
		int num8 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X10_v9 (System.Int32)-8]");
			if (0 == (nint)obj8)
			{
				break;
			}
			num = num8 + 16;
			obj15--;
			bool flag2 = (nint)obj15 != 1;
			num8 = num;
			if (flag2)
			{
				continue;
			}
			goto IL_02dd;
		}
		object obj16 = num7 + ((int*)num8)->m_value;
		object obj17 = obj16 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X0_v15+8]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v418 @ X0_v15] (should have been resolved before IL gen)");
		num = num8;
		goto IL_0375;
		IL_02dd:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v402 @ X0_v12+8]");
		obj5 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v402 @ X0_v12] (should have been resolved before IL gen)");
		object obj18 = default(object);
		bool flag3 = obj18 == null;
		object obj19 = !flag3;
		if (obj19 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0375;
		IL_0120:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v20 (Il2CppClass<System.Object>)+B0]");
		int num9 = (int)((nint)0 + (nint)8);
		while (true)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X10_v15 (System.Int32)-8]");
			if (0 == (nint)obj9)
			{
				break;
			}
			num = num9 + 16;
			obj10--;
			bool flag4 = (nint)obj10 != 1;
			num3 = num4;
			num5 = _blockedBaseFadeSpeed;
			obj12 = obj9;
			obj13 = obj11;
			num9 = num;
			if (flag4)
			{
				continue;
			}
			goto IL_01a1;
		}
		object obj20 = num2 + ((int*)num9)->m_value;
		object obj21 = obj20 + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v348 @ X0_v24] (should have been resolved before IL gen)");
		object obj22 = default(object);
		bool flag5 = obj11 >= obj22;
		num3 = num4;
		num5 = _blockedBaseFadeSpeed;
		num = num9;
		obj13 = obj11;
		if (!flag5)
		{
			goto IL_0241;
		}
		return;
		IL_0375:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v9+20]");
		bool flag6 = (nint)0 == 0;
		object obj23 = !flag6;
		if (obj23 == null)
		{
			num4 = _blockedBaseFadeSpeed * (float)obj13;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v384 @ X0_v9+18]");
			((JackarooNodeMono)0).ShowBlocked(_blockedBaseFadeSpeed, num4);
			obj11 = obj13 + 1;
			obj9 = obj7;
			num2 = (nint)obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v20 (Il2CppClass<System.Object>)+12E]");
			obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v268 @ X8_v20 (Il2CppClass<System.Object>)+12E]");
			bool flag7 = (nint)0 == 0;
			object obj24 = !flag7;
			if (obj24 != null)
			{
				goto IL_0120;
			}
			num3 = num4;
			num5 = _blockedBaseFadeSpeed;
			obj12 = obj7;
			obj13 = obj11;
			goto IL_01a1;
		}
	}

	private void CheckMarbleUnblockedBase(JackarooMarble marbleToMove)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_02d6: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_0306: Expected O, but got I4
		//IL_0114: Expected O, but got I
		//IL_016d: Expected O, but got I
		//IL_01c6: Expected O, but got I
		//IL_021f: Expected O, but got I
		object obj = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
		object obj3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X8_v4+1]");
		object obj4 = (nint)0 & (nint)0x80;
		bool flag = obj4 == null;
		object obj5 = !flag;
		if (obj5 != null)
		{
			return;
		}
		if (marbleToMove != null)
		{
			JackarooNode <Node>k__BackingField = marbleToMove.<Node>k__BackingField;
			if (marbleToMove.<Node>k__BackingField != null)
			{
				if (<Node>k__BackingField.<Type>k__BackingField == JackarooNodeType.Base)
				{
					UnblockBase(marbleToMove.<PlayerIndex>k__BackingField);
					return;
				}
				if (<Node>k__BackingField.<Type>k__BackingField != JackarooNodeType.BaseEntry)
				{
					return;
				}
				JackarooBoard jackarooBoard = <Board>k__BackingField;
				if (<Board>k__BackingField != null)
				{
					(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes = jackarooBoard._homesAndBasesEntryNodes;
					if (jackarooBoard._homesAndBasesEntryNodes != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+28]");
						(JackarooNode, JackarooNode) tuple = ((JackarooNode, JackarooNode))0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+28]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X10_v4 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
							if (0 == (nint)marbleToMove)
							{
								UnblockBase(1);
								return;
							}
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+38]");
							(JackarooNode, JackarooNode) tuple2 = ((JackarooNode, JackarooNode))0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+38]");
							if ((nint)0 != 0)
							{
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X10_v6 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
								if (0 == (nint)marbleToMove)
								{
									UnblockBase(2);
									return;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+48]");
								(JackarooNode, JackarooNode) tuple3 = ((JackarooNode, JackarooNode))0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+48]");
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X10_v8 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
									if (0 == (nint)marbleToMove)
									{
										UnblockBase(3);
										return;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+58]");
									(JackarooNode, JackarooNode) tuple4 = ((JackarooNode, JackarooNode))0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X8_v12 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+58]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v13 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
										if (0 == (nint)marbleToMove)
										{
											UnblockBase(4);
										}
										return;
									}
								}
							}
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	private Action GetUnblockBaseAction(JackarooMarble marble)
	{
		//IL_0016: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0102: Expected O, but got I
		//IL_011c: Expected O, but got I4
		//IL_009a: Expected O, but got I
		//IL_00b0: Expected O, but got I
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_005d: Expected O, but got I
		//IL_0150: Expected O, but got I
		//IL_0166: Expected O, but got I
		//IL_0180: Expected O, but got I4
		//IL_0286: Expected O, but got I
		//IL_0442: Expected O, but got I4
		//IL_0503: Unknown result type (might be due to invalid IL or missing references)
		//IL_0508: Expected O, but got Unknown
		//IL_047a: Unknown result type (might be due to invalid IL or missing references)
		//IL_047f: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a7: Expected O, but got Unknown
		//IL_02fe: Expected O, but got I
		//IL_04c2: Expected O, but got I
		//IL_04d3: Expected I, but got O
		//IL_0450: Expected O, but got I4
		//IL_0376: Expected O, but got I
		//IL_045e: Expected O, but got I4
		//IL_03ee: Expected O, but got I
		//IL_046c: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F4E]");
		object obj = (nint)0 & (nint)1;
		object obj2;
		object obj4;
		if (obj != null)
		{
			obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E5]");
			object obj3 = (nint)0 & (nint)1;
			bool flag = obj3 == null;
			obj4 = obj2;
			if (!flag)
			{
				goto IL_0082;
			}
		}
		else
		{
			_ = 1;
			obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 304;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45E5]");
			object obj5 = (nint)0 & (nint)1;
			bool flag2 = obj5 == null;
			object obj6 = !flag2;
			obj4 = obj2;
			if (obj6 != null)
			{
				goto IL_0082;
			}
		}
		_ = 1;
		object obj7 = obj4;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X8_v21+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v22+1]");
		object obj9 = (nint)0 & (nint)0x80;
		bool flag3 = obj9 == null;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			goto IL_018e;
		}
		goto IL_0437;
		IL_0437:
		return null;
		IL_04e6:
		return (Action)(object)new IndexOutOfRangeException();
		IL_04d8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_04e6;
		IL_0082:
		object obj11 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v27+B8]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v28+1]");
		object obj13 = (nint)0 & (nint)0x80;
		if (obj13 == null)
		{
			goto IL_018e;
		}
		goto IL_0437;
		IL_018e:
		if (marble != null)
		{
			JackarooNode <Node>k__BackingField = marble.<Node>k__BackingField;
			if (marble.<Node>k__BackingField != null)
			{
				if (<Node>k__BackingField.<Type>k__BackingField != JackarooNodeType.BaseEntry)
				{
					goto IL_0437;
				}
				JackarooBoard jackarooBoard = <Board>k__BackingField;
				if (<Board>k__BackingField != null)
				{
					(JackarooNode, JackarooNode)[] homesAndBasesEntryNodes = jackarooBoard._homesAndBasesEntryNodes;
					if (jackarooBoard._homesAndBasesEntryNodes != null)
					{
						if (homesAndBasesEntryNodes.Length == 0)
						{
							goto IL_04e6;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v9 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+28]");
						(JackarooNode, JackarooNode) tuple = ((JackarooNode, JackarooNode))0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v9 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+28]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X10_v4 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
							if (0 != (nint)marble)
							{
								if (homesAndBasesEntryNodes.Length == 1)
								{
									goto IL_04e6;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v9 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+38]");
								(JackarooNode, JackarooNode) tuple2 = ((JackarooNode, JackarooNode))0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v9 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+38]");
								if ((nint)0 == 0)
								{
									goto IL_04d8;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v148 @ X10_v7 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
								if (0 != (nint)marble)
								{
									if (homesAndBasesEntryNodes.Length == 2)
									{
										goto IL_04e6;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v9 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+48]");
									(JackarooNode, JackarooNode) tuple3 = ((JackarooNode, JackarooNode))0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v9 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+48]");
									if ((nint)0 == 0)
									{
										goto IL_04d8;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X10_v9 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
									if (0 != (nint)marble)
									{
										if (homesAndBasesEntryNodes.Length == 3)
										{
											goto IL_04e6;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v9 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+58]");
										(JackarooNode, JackarooNode) tuple4 = ((JackarooNode, JackarooNode))0;
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v9 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>[])+58]");
										if ((nint)0 == 0)
										{
											goto IL_04d8;
										}
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X8_v17 (System.ValueTuple`2<Jackaroo.JackarooNode, Jackaroo.JackarooNode>)+20]");
										if (0 != (nint)marble)
										{
											goto IL_0437;
										}
										object obj14 = 4;
									}
									else
									{
										object obj14 = 3;
									}
								}
								else
								{
									object obj14 = 2;
								}
							}
							else
							{
								object obj14 = 1;
							}
							object obj15 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 376;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							object obj16 = default(object);
							obj16..ctor();
							if (obj16 != null)
							{
								object obj17 = obj16 + 24;
								obj17 = this;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								object obj18 = typeof(SqlSingle[]) + 2376;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj19 = (nint)0 + (nint)1648;
								Action action = default(Action);
								action..ctor(obj16, (IntPtr)obj19);
								return action;
							}
						}
					}
				}
			}
		}
		goto IL_04d8;
	}

	private unsafe void UnblockBase(int playerIndex)
	{
		//IL_0010: Expected O, but got I
		//IL_06cc: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_06f7: Expected O, but got I4
		//IL_0700: Expected O, but got I4
		//IL_0036: Expected O, but got I
		//IL_0044: Expected O, but got I4
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected I4, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Expected O, but got Unknown
		//IL_006b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_008b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected I4, but got Unknown
		//IL_0716: Expected I, but got O
		//IL_0744: Expected O, but got I4
		//IL_074d: Expected O, but got I4
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00df: Expected O, but got Unknown
		//IL_00e7: Expected I, but got O
		//IL_00f7: Expected O, but got I
		//IL_01c0: Expected I, but got O
		//IL_07b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07bb: Expected O, but got Unknown
		//IL_07ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_07cf: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e3: Expected O, but got Unknown
		//IL_07eb: Expected I4, but got O
		//IL_080d: Expected O, but got Ref
		//IL_0779: Unknown result type (might be due to invalid IL or missing references)
		//IL_077e: Expected O, but got Unknown
		//IL_01df: Expected O, but got I
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ed: Expected O, but got Unknown
		//IL_0623: Expected O, but got I4
		//IL_0158: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Expected O, but got Unknown
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_02e9: Expected I, but got O
		//IL_087e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0883: Expected O, but got Unknown
		//IL_04d7: Expected O, but got I4
		//IL_04e0: Expected O, but got I4
		//IL_0825: Unknown result type (might be due to invalid IL or missing references)
		//IL_082a: Expected O, but got Unknown
		//IL_0308: Unknown result type (might be due to invalid IL or missing references)
		//IL_030d: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_031b: Expected O, but got Unknown
		//IL_094e: Expected O, but got I4
		//IL_0296: Expected O, but got I4
		//IL_0598: Expected I, but got O
		//IL_0434: Expected I, but got O
		//IL_08b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b7: Expected O, but got Unknown
		//IL_05b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05bc: Expected O, but got Unknown
		//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_05ca: Expected O, but got Unknown
		//IL_0453: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_0466: Expected O, but got Unknown
		//IL_03e1: Expected O, but got I4
		//IL_04b7: Expected O, but got I
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F95]");
		object obj = 0;
		JackarooBoard jackarooBoard = <Board>k__BackingField;
		bool flag = <Board>k__BackingField == null;
		object obj2 = 0;
		bool flag6 = default(bool);
		object obj11;
		object obj3;
		int num3;
		int num = default(int);
		nint num4;
		if (!flag)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F67]");
			obj = 0;
			bool flag2 = jackarooBoard._basesNodes == null;
			obj2 = 0;
			obj3 = 152989696;
			if (!flag2)
			{
				obj = (nint)0 + (nint)3000;
				object obj4 = 5 - num;
				int num2 = obj4 & 3;
				object obj5 = 0 - obj4;
				object obj6 = 0 - obj5;
				bool flag3 = obj6 == null;
				num3 = obj5 & 3;
				num = ((0 >= (nint)obj5) ? (-num3) : num2);
				num4 = (nint)obj;
				object obj7 = ((List<object>)(object)jackarooBoard._basesNodes).get_Item(num);
				bool flag4 = obj7 == null;
				obj2 = 0;
				obj3 = 152989696;
				if (!flag4)
				{
					object obj8 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 3440;
					nint num5 = (nint)obj7;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v17 (Il2CppClass<System.Object>)+12E]");
					object obj9 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v17 (Il2CppClass<System.Object>)+12E]");
					if ((nint)0 == 0)
					{
						goto IL_01b1;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X8_v17 (Il2CppClass<System.Object>)+B0]");
					int num6 = (int)((nint)0 + (nint)8);
					bool flag5 = flag6;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X10_v30 (System.Int32)-8]");
						obj6 = 0 - obj8;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X10_v30 (System.Int32)-8]");
						if (0 == (nint)obj8)
						{
							break;
						}
						num2 = num6 + 16;
						obj9--;
						obj6 = obj9 - 1;
						flag3 = obj6 == null;
						flag6 = (nint)obj9 != 1;
						flag5 = flag6;
						num6 = num2;
						if (flag6)
						{
							continue;
						}
						goto IL_01b1;
					}
					object obj10 = num5 + ((int*)num6)->m_value;
					obj11 = obj10 + 312;
					flag6 = flag5;
					num2 = num6;
					goto IL_07a7;
				}
			}
		}
		goto IL_075b;
		IL_075b:
		throw new NullReferenceException();
		IL_07a7:
		obj3 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
		object obj12 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 848;
		jackarooBoard = (JackarooBoard)(typeof(UnityEngine.TextCore.HorizontalAlignment) + 2344);
		num3 = (int)obj11;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v18+8]");
		num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v412 @ X8_v18] (should have been resolved before IL gen)");
		obj = (object)(&obj2);
		object obj13 = default(object);
		object obj16 = default(object);
		object obj18 = default(object);
		object obj28 = default(object);
		object obj29 = default(object);
		object obj22;
		while (true)
		{
			if (obj13 != null)
			{
				object obj14 = obj13;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v22+12E]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v22+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02da;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v22+B0]");
				int num7 = (int)((nint)0 + (nint)8);
				bool flag7 = flag6;
				int num2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X10_v25 (System.Int32)-8]");
					object obj6 = 0 - obj3;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v560 @ X10_v25 (System.Int32)-8]");
					if (0 == (nint)obj3)
					{
						break;
					}
					num2 = num7 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v22+12E]");
					num3 = (int)(-1);
					obj6 = num3 - 1;
					bool flag3 = obj6 == null;
					flag6 = num3 != 1;
					flag7 = flag6;
					num7 = num2;
					if (flag6)
					{
						continue;
					}
					goto IL_02da;
				}
				num3 = ((int*)num7)->m_value;
				object obj15 = obj14 + ((int*)num7)->m_value;
				obj16 = obj15 + 312;
				flag6 = flag7;
				num2 = num7;
				goto IL_0853;
			}
			NullReferenceException ex = new NullReferenceException();
			break;
			IL_02da:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_0853;
			IL_0853:
			obj = obj16;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X0_v30+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v581 @ X0_v30] (should have been resolved before IL gen)");
			object obj17 = obj18 & 1;
			if (obj17 != null)
			{
				if (obj13 != null)
				{
					object obj19 = obj13;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v25+12E]");
					num3 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v25+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0425;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v25+B0]");
					int num8 = (int)((nint)0 + (nint)8);
					bool flag8 = flag6;
					int num2;
					while (true)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X10_v20 (System.Int32)-8]");
						object obj6 = 0 - obj12;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X10_v20 (System.Int32)-8]");
						if (0 == (nint)obj12)
						{
							break;
						}
						num2 = num8 + 16;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X8_v25+12E]");
						num3 = (int)(-1);
						obj6 = num3 - 1;
						bool flag3 = obj6 == null;
						flag6 = num3 != 1;
						flag8 = flag6;
						num8 = num2;
						if (flag6)
						{
							continue;
						}
						goto IL_0425;
					}
					num3 = ((int*)num8)->m_value;
					object obj20 = obj19 + ((int*)num8)->m_value;
					object obj21 = obj20 + 312;
					flag6 = flag8;
					num2 = num8;
					goto IL_08e0;
				}
				NullReferenceException ex2 = new NullReferenceException();
				break;
			}
			obj2 = obj13;
			obj22 = 0;
			object obj23 = 0;
			while (true)
			{
				if (obj2 == null)
				{
					goto IL_0934;
				}
				object obj24 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v5+12E]");
				num3 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v5+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0589;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v5+B0]");
				int num9 = (int)((nint)0 + (nint)8);
				int num2;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X10_v7 (System.Int32)-8]");
					if (0 == (nint)jackarooBoard)
					{
						break;
					}
					num2 = num9 + 16;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X8_v5+12E]");
					num3 = (int)(-1);
					bool flag9 = num3 != 1;
					num9 = num2;
					if (flag9)
					{
						continue;
					}
					goto IL_0589;
				}
				num3 = ((int*)num9)->m_value;
				object obj25 = obj24 + ((int*)num9)->m_value;
				object obj26 = obj25 + 312;
				num2 = num9;
				goto IL_0980;
				IL_0934:
				bool flag10 = obj23 == null;
				object obj27 = !flag10;
				if (obj27 == null)
				{
					return;
				}
				OutOfMemoryException ex3 = new OutOfMemoryException();
				if (num != 1)
				{
					break;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0B80");
				obj23 = obj28;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB0BB0");
				obj22 = obj28;
				continue;
				IL_0589:
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
				num4 = unchecked((nint)null);
				goto IL_0980;
				IL_0980:
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X0_v4+8]");
				num = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v518 @ X0_v4] (should have been resolved before IL gen)");
				goto IL_0934;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1C99C14");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @6CB03A0");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2B060");
			return;
			IL_0425:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			num4 = unchecked((nint)null);
			goto IL_08e0;
			IL_08e0:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X0_v34+8]");
			num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v643 @ X0_v34] (should have been resolved before IL gen)");
			if (obj29 != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v36+18]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X0_v36+18]");
					((JackarooNodeMono)0).HideBlocked(_blockedBaseFadeSpeed);
					num = 0;
					continue;
				}
				NullReferenceException ex4 = new NullReferenceException();
				break;
			}
			NullReferenceException ex5 = new NullReferenceException();
			break;
		}
		obj2 = obj13;
		obj22 = 0;
		goto IL_075b;
		IL_01b1:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
		num4 = unchecked((nint)null);
		object obj30 = default(object);
		obj11 = obj30;
		goto IL_07a7;
	}

	private void UnblockAllBases()
	{
		UnblockBase(0);
		UnblockBase(1);
		UnblockBase(2);
		UnblockBase(3);
	}

	private void PlayWinAnimations(CardGameEndScores cardGameEndScores)
	{
		//IL_001b: Expected O, but got I
		//IL_0069: Expected O, but got I
		//IL_0080: Expected O, but got I
		//IL_0095: Expected O, but got I
		//IL_00e3: Expected O, but got I4
		//IL_01c0: Expected O, but got I4
		//IL_0107: Expected O, but got I
		//IL_0129: Expected O, but got I
		//IL_0153: Expected O, but got I4
		//IL_01fe: Expected O, but got I
		//IL_0213: Expected O, but got I
		//IL_0261: Expected O, but got I4
		//IL_02c1: Expected O, but got I
		//IL_02d1: Expected O, but got I
		//IL_0285: Expected O, but got I
		//IL_02a7: Expected O, but got I
		//IL_032b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0330: Expected O, but got Unknown
		//IL_033f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0350: Expected O, but got I
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		//IL_0434: Unknown result type (might be due to invalid IL or missing references)
		//IL_0439: Expected O, but got Unknown
		//IL_04e9: Expected O, but got I4
		//IL_04f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f7: Expected I4, but got Unknown
		//IL_0500: Unknown result type (might be due to invalid IL or missing references)
		//IL_0505: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0513: Expected O, but got Unknown
		//IL_0544: Unsupported input type for neg.
		//IL_0544: Unknown result type (might be due to invalid IL or missing references)
		//IL_0549: Expected I4, but got Unknown
		//IL_0c14: Expected O, but got I
		//IL_0c33: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Expected O, but got Unknown
		//IL_056d: Expected O, but got I
		//IL_058f: Expected O, but got I
		//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b5: Expected O, but got Unknown
		//IL_05cb: Expected O, but got I
		//IL_05dc: Expected I, but got O
		//IL_0650: Expected O, but got I4
		//IL_0668: Unknown result type (might be due to invalid IL or missing references)
		//IL_066d: Expected O, but got Unknown
		//IL_0693: Expected O, but got I4
		//IL_0745: Expected O, but got I4
		//IL_0745: Expected O, but got I
		//IL_0802: Expected O, but got I
		//IL_0812: Expected O, but got I
		//IL_0834: Expected O, but got I4
		//IL_083d: Expected O, but got I4
		//IL_084d: Expected O, but got I
		//IL_0ca1: Expected O, but got I
		//IL_0cd6: Expected O, but got I
		//IL_0782: Expected O, but got I
		//IL_0792: Expected O, but got I
		//IL_07b4: Expected O, but got I4
		//IL_07bd: Expected O, but got I4
		//IL_08d9: Expected O, but got I
		//IL_08ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f1: Expected O, but got Unknown
		//IL_087d: Expected O, but got I4
		//IL_0cfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d01: Expected O, but got Unknown
		//IL_0d17: Expected O, but got I
		//IL_0d28: Expected I, but got O
		//IL_0d46: Expected O, but got I
		//IL_07db: Expected O, but got I
		//IL_08bb: Expected O, but got I4
		//IL_08ad: Expected O, but got I
		//IL_092f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0934: Expected O, but got Unknown
		//IL_0986: Expected I, but got O
		//IL_0a01: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a06: Expected O, but got Unknown
		//IL_0a54: Expected O, but got I4
		//IL_0a6e: Expected O, but got I4
		//IL_0a8e: Expected I, but got O
		//IL_0afa: Expected O, but got I
		//IL_0372: Expected O, but got I
		//IL_037a: Expected I4, but got O
		//IL_0b63: Expected O, but got I
		//IL_0b76: Expected I, but got O
		//IL_0b82: Expected O, but got I
		//IL_0b8a: Expected I4, but got O
		List<int> winnerPlayersIndices = _winnerPlayersIndices;
		if (_winnerPlayersIndices != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X8_v3 (System.Collections.Generic.List`1<System.Int32>)+1C]");
			object obj = (nint)0 + (nint)1;
			_ = 0;
			CardGameEndScores cardGameEndScores2 = default(CardGameEndScores);
			int firstWinnerIndex = GetFirstWinnerIndex(cardGameEndScores2);
			List<int> winnerPlayersIndices2 = _winnerPlayersIndices;
			if (_winnerPlayersIndices != null)
			{
				object obj2 = (nint)0 + (nint)1336;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
				object obj3 = (nint)0 + (nint)1;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
				object obj4 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
				if ((nint)0 != 0)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
					nint num = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v240 @ X9_v7+18]");
					bool flag = num < 0;
					object obj5 = !flag;
					int rotatedNextIndex;
					if (obj5 == null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj6 = (nint)0 + (nint)1;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
						nint num2 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
						object obj7 = num2 + 0;
						rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(firstWinnerIndex, 2, 1, 5);
						object obj8 = 0;
						int num3 = 5;
						int num4 = 1;
					}
					else
					{
						_winnerPlayersIndices.AddWithResize(firstWinnerIndex);
						winnerPlayersIndices2 = _winnerPlayersIndices;
						rotatedNextIndex = IntegerExtensions.GetRotatedNextIndex(firstWinnerIndex, 2, 1, 5);
						bool flag2 = _winnerPlayersIndices == null;
						object obj8 = 0;
						int num3 = 5;
						int num4 = 1;
						if (flag2)
						{
							goto IL_0ba8;
						}
					}
					object obj9 = obj2;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+1C]");
					object obj10 = (nint)0 + (nint)1;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
					object obj11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
					if ((nint)0 != 0)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
						nint num5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v241 @ X9_v10+18]");
						bool flag3 = num5 < 0;
						object obj12 = !flag3;
						if (obj12 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj13 = (nint)0 + (nint)1;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+10]");
							nint num6 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X20_v5 (System.Collections.Generic.List`1<System.Int32>)+18]");
							object obj14 = num6 + 0;
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v321 @ X8_v8+20]");
							object obj15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X8_v77+C0]");
							object obj16 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v484 @ X8_v78+70]");
							int num4 = 0;
							winnerPlayersIndices2.AddWithResize(rotatedNextIndex);
						}
						List<int> winnerPlayersIndices3 = _winnerPlayersIndices;
						if (_winnerPlayersIndices != null)
						{
							object obj17 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 304;
							object obj18 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
							object obj19 = (nint)0 + (nint)1664;
							int num7 = rotatedNextIndex;
							int num8 = 0;
							object obj21 = default(object);
							Comparison<object> comparison = default(Comparison<object>);
							Func<object, object> func2 = default(Func<object, object>);
							object obj50 = default(object);
							TweenCallback tweenCallback = default(TweenCallback);
							object obj52 = default(object);
							TweenCallback tweenCallback2 = default(TweenCallback);
							TweenCallback tweenCallback3 = default(TweenCallback);
							do
							{
								int num9 = num8;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v11 (System.Collections.Generic.List`1<System.Int32>)+18]");
								if ((nint)num9 >= (nint)0)
								{
									return;
								}
								object obj20 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 384;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj21..ctor();
								if (obj21 == null)
								{
									break;
								}
								object obj22 = obj21 + 24;
								obj22 = this;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								if (_winnerPlayersIndices == null)
								{
									break;
								}
								int num10 = _winnerPlayersIndices.get_Item(num8);
								if ((object)<Game>k__BackingField == null)
								{
									break;
								}
								int rotatedPlayerIndex = <Game>k__BackingField.GetRotatedPlayerIndex(num10);
								JackarooBoard jackarooBoard = <Board>k__BackingField;
								if (<Board>k__BackingField == null || jackarooBoard._basesNodes == null)
								{
									break;
								}
								object obj23 = 5 - rotatedPlayerIndex;
								int num11 = obj23 & 3;
								object obj24 = 0 - obj23;
								object obj25 = obj24 & 3;
								int index = ((0 >= (nint)obj24) ? (0 - obj25) : num11);
								object obj26 = (nint)0 + (nint)3000;
								object obj27 = ((List<object>)(object)jackarooBoard._basesNodes).get_Item(index);
								object obj28 = obj21 + 16;
								obj28 = obj27;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								JackarooBoard jackarooBoard2 = <Board>k__BackingField;
								if (<Board>k__BackingField == null || jackarooBoard2._playersPlantedMarbles == null)
								{
									break;
								}
								int num12 = rotatedPlayerIndex - 1;
								object obj29 = (nint)0 + (nint)2968;
								object source = ((List<object>)(object)jackarooBoard2._playersPlantedMarbles).get_Item(num12);
								object obj30 = (nint)0 + (nint)2240;
								List<object> list = Enumerable.ToList((IEnumerable<object>)source);
								object obj31 = typeof(Action<CriteriaSection.PerformanceCriteria>) + 3384;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj32 = (nint)0 + (nint)1656;
								comparison..ctor(obj21, (IntPtr)obj32);
								if (list == null)
								{
									break;
								}
								list.Sort(comparison);
								ShowConfettiAnimation[] showConfettiAnimation = _showConfettiAnimation;
								if (_showConfettiAnimation == null)
								{
									break;
								}
								bool flag4 = num12 < showConfettiAnimation.Length;
								object obj33 = !flag4;
								if (obj33 != null)
								{
									goto IL_0bb6;
								}
								object obj34 = _showConfettiAnimation + num12;
								JackarooThemeData jackarooThemeData = _runtimeTheme;
								bool flag5 = _runtimeTheme == null;
								object obj35 = !flag5;
								if (obj35 == null)
								{
									JackarooTheme defaultTheme = _defaultTheme;
									if ((object)_defaultTheme == null)
									{
										break;
									}
									jackarooThemeData = defaultTheme.<ThemeData>k__BackingField;
									if (defaultTheme.<ThemeData>k__BackingField == null)
									{
										break;
									}
								}
								Color playerColor = jackarooThemeData.GetPlayerColor(num10);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v40+20]");
								if ((nint)0 == 0)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v40+20]");
								((ShowConfettiAnimation)0).SetColor((Color)0);
								object obj36 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v74+E4]");
								object obj37;
								Func<object, object> selector;
								object obj39;
								if ((nint)0 != 0)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v74+B8]");
									obj37 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v64+40]");
									selector = (Func<object, object>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v64+40]");
									bool flag6 = (nint)0 == 0;
									object obj38 = !flag6;
									obj39 = 0;
									if (obj38 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v64+40]");
										Func<object, object> func = (Func<object, object>)0;
										goto IL_085b;
									}
								}
								else
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									obj36 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v74+B8]");
									obj37 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v64+40]");
									Func<object, object> func = (Func<object, object>)0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v64+40]");
									bool flag7 = (nint)0 == 0;
									object obj40 = !flag7;
									obj39 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v643 @ X8_v64+40]");
									selector = (Func<object, object>)0;
									if (obj40 == null)
									{
										goto IL_085b;
									}
								}
								goto IL_0c95;
								IL_085b:
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v634 @ X0_v74+E4]");
								bool flag8 = (nint)0 == 0;
								object obj41 = !flag8;
								if (obj41 == null)
								{
									Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									object obj42 = obj17;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v653 @ X8_v70+B8]");
									obj37 = 0;
								}
								object obj43 = typeof(Func<AndroidJavaObject, IList<HWLocation>>) + 2088;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								object obj44 = (nint)0 + (nint)1528;
								func2..ctor(obj37, (IntPtr)obj44);
								object obj45 = obj17;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v626 @ X8_v69+B8]");
								object obj46 = (nint)0 + (nint)64;
								obj46 = func2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								obj39 = 0;
								selector = func2;
								goto IL_0c95;
								IL_0c95:
								object obj47 = (nint)0 + (nint)3616;
								IEnumerable<object> source2 = Enumerable.Select(list, selector);
								List<object> list2 = Enumerable.ToList(source2);
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v40+20]");
								object obj48 = (nint)0 + (nint)80;
								obj48 = list2;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v594 @ X8_v40+20]");
								Sequence s = ((ShowConfettiAnimation)0).PlayWin();
								object obj49 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 392;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj50..ctor();
								if (obj50 == null)
								{
									break;
								}
								object obj51 = obj50 + 24;
								obj51 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								if (_fireWorksAudioClips == null)
								{
									break;
								}
								_ = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								tweenCallback..ctor(obj50, (IntPtr)obj19);
								float num13 = _delayBetweenFireworks * 0f;
								float atPosition = num13 + _fireworksAudioDelay;
								Sequence sequence = TweenSettingsExtensions.InsertCallback(s, atPosition, tweenCallback);
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								obj52..ctor();
								if (obj52 == null)
								{
									break;
								}
								object obj53 = obj52 + 24;
								obj53 = obj21;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								List<AudioClip> fireWorksAudioClips = _fireWorksAudioClips;
								if (_fireWorksAudioClips == null)
								{
									break;
								}
								object obj54 = fireWorksAudioClips._size - 1;
								bool flag9 = obj54 == null;
								object obj55 = !flag9;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
								tweenCallback2..ctor(obj52, (IntPtr)obj19);
								float atPosition2 = _delayBetweenFireworks + _fireworksAudioDelay;
								Sequence sequence2 = TweenSettingsExtensions.InsertCallback(s, atPosition2, tweenCallback2);
								List<int> winnerPlayersIndices4 = _winnerPlayersIndices;
								if (_winnerPlayersIndices == null)
								{
									break;
								}
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v52 (System.Collections.Generic.List`1<System.Int32>)+18]");
								object obj56 = -1;
								bool flag10 = num8 != (nint)obj56;
								int num3 = 0;
								int num4 = 0;
								if (!flag10)
								{
									atPosition2 = _totalAnimationDuration;
									Sequence sequence3 = TweenSettingsExtensions.AppendInterval(s, _totalAnimationDuration);
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
									object obj57 = (nint)0 + (nint)208;
									tweenCallback3..ctor(_gameEventsChannel, (IntPtr)obj57);
									object obj58 = (nint)0 + (nint)2512;
									num4 = (int)obj58;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
									num3 = 0;
								}
								object obj59 = (nint)0 + (nint)2408;
								num7 = (int)obj59;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
								num8++;
								winnerPlayersIndices3 = _winnerPlayersIndices;
							}
							while (_winnerPlayersIndices != null);
						}
					}
				}
			}
		}
		goto IL_0ba8;
		IL_0bb6:
		throw new IndexOutOfRangeException();
		IL_0ba8:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0bb6;
	}

	private int GetFirstWinnerIndex(CardGameEndScores cardGameEndScores)
	{
		//IL_0247: Expected I4, but got O
		int index;
		if ((object)<Game>k__BackingField != null)
		{
			if (<Game>k__BackingField.IsSpectator)
			{
				if (cardGameEndScores != null)
				{
					return cardGameEndScores.<WinnerTeamIndex>k__BackingField;
				}
			}
			else if (cardGameEndScores != null && (object)<Game>k__BackingField != null)
			{
				int myTeamIndex = <Game>k__BackingField.MyTeamIndex;
				if (cardGameEndScores.<WinnerTeamIndex>k__BackingField == myTeamIndex)
				{
					if ((object)<Game>k__BackingField != null)
					{
						if (<Game>k__BackingField.IsSpectator)
						{
							return 1;
						}
						if ((object)<Game>k__BackingField != null)
						{
							CardGamePlayer myPlayer = <Game>k__BackingField.MyPlayer;
							if (myPlayer != null)
							{
								return ((KPlayer)myPlayer).<Index>k__BackingField;
							}
						}
					}
				}
				else if ((object)<Game>k__BackingField != null)
				{
					if (<Game>k__BackingField.IsSpectator)
					{
						index = 1;
						goto IL_0247;
					}
					if ((object)<Game>k__BackingField != null)
					{
						CardGamePlayer myPlayer2 = <Game>k__BackingField.MyPlayer;
						if (myPlayer2 != null)
						{
							index = ((KPlayer)myPlayer2).<Index>k__BackingField;
							goto IL_0247;
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
		IL_0247:
		return IntegerExtensions.GetRotatedNextIndex(index, 1, 1, 5);
	}

	private IEnumerator AllMarblesInBaseCelebrationIe(int rotatedPlayerIndex)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void ResetWinAnimations()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_014c: Expected O, but got I4
		//IL_00a5: Expected O, but got I
		//IL_00b5: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00e7: Expected O, but got I4
		//IL_018a: Expected O, but got I
		//IL_019a: Expected O, but got I
		//IL_01aa: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_0214: Expected O, but got I4
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0281: Expected O, but got I
		//IL_0292: Expected I, but got O
		//IL_02b0: Expected O, but got I
		//IL_0244: Expected O, but got I
		object obj = 152989696;
		object obj2 = typeof(InvitationsNotifier.<>c__DisplayClass16_0) + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E7F50]");
		object obj3 = (nint)0 & (nint)1;
		ShowConfettiAnimation[] showConfettiAnimation;
		ShowConfettiAnimation[] showConfettiAnimation2;
		object obj4;
		if (obj3 != null)
		{
			showConfettiAnimation = _showConfettiAnimation;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+E4]");
			bool flag = (nint)0 == 0;
			object obj5 = obj4;
			showConfettiAnimation2 = _showConfettiAnimation;
			if (!flag)
			{
				goto IL_0099;
			}
		}
		else
		{
			_ = 1;
			showConfettiAnimation = _showConfettiAnimation;
			obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+E4]");
			bool flag2 = (nint)0 == 0;
			object obj6 = !flag2;
			object obj5 = obj4;
			showConfettiAnimation2 = _showConfettiAnimation;
			if (obj6 != null)
			{
				goto IL_0099;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		obj4 = obj2;
		object obj7 = (nint)0 + (nint)2320;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+B8]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+48]");
		Action<object> action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+48]");
		bool flag3 = (nint)0 == 0;
		object obj9 = !flag3;
		IEnumerable<object> enumerable = showConfettiAnimation2;
		object obj10 = obj7;
		IEnumerable<object> enumeration = showConfettiAnimation2;
		if (obj9 == null)
		{
			goto IL_01f2;
		}
		goto IL_0249;
		IL_01f2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+E4]");
		bool flag4 = (nint)0 == 0;
		object obj11 = !flag4;
		if (obj11 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj12 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v10+B8]");
			obj8 = 0;
		}
		object obj13 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj14 = (nint)0 + (nint)1536;
		Action<object> action2 = default(Action<object>);
		action2..ctor(obj8, (IntPtr)obj14);
		object obj15 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v9+B8]");
		object obj16 = (nint)0 + (nint)72;
		obj16 = action2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		obj10 = obj7;
		action = action2;
		enumeration = enumerable;
		goto IL_0249;
		IL_0249:
		ArraysExtensions.ForEach(enumeration, action);
		return;
		IL_0099:
		obj10 = (nint)0 + (nint)2320;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v114 @ X0_v3+B8]");
		obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+48]");
		action = (Action<object>)0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X8_v4+48]");
		bool flag5 = (nint)0 == 0;
		object obj17 = !flag5;
		enumeration = showConfettiAnimation;
		if (obj17 == null)
		{
			obj7 = obj10;
			enumerable = showConfettiAnimation;
			goto IL_01f2;
		}
		goto IL_0249;
	}

	public JackarooBoardMono()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_0029: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003e: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0430: Unknown result type (might be due to invalid IL or missing references)
		//IL_0435: Expected O, but got Unknown
		//IL_006b: Expected F4, but got I
		//IL_0087: Expected F4, but got I
		//IL_00a3: Expected F4, but got I
		//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Expected O, but got Unknown
		//IL_00f7: Expected F4, but got I
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_0126: Expected O, but got I
		//IL_0144: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Expected O, but got Unknown
		//IL_0180: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bc: Expected O, but got Unknown
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Expected O, but got Unknown
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_022f: Expected O, but got Unknown
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_026b: Expected O, but got Unknown
		//IL_0284: Unknown result type (might be due to invalid IL or missing references)
		//IL_0289: Expected O, but got Unknown
		//IL_02b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b7: Expected O, but got Unknown
		//IL_02d8: Expected F4, but got I
		//IL_02e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_02ec: Expected O, but got Unknown
		//IL_0302: Expected O, but got I
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032a: Expected O, but got Unknown
		//IL_0343: Unknown result type (might be due to invalid IL or missing references)
		//IL_0348: Expected O, but got Unknown
		//IL_0363: Expected O, but got I
		//IL_0381: Unknown result type (might be due to invalid IL or missing references)
		//IL_0386: Expected O, but got Unknown
		//IL_03ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bf: Expected O, but got Unknown
		//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f6: Expected O, but got Unknown
		object obj = typeof(List<Tween>) + 3992;
		object obj2 = typeof(List<Tween>) + 4008;
		object obj3 = typeof(List<AdaptivePerformanceScaler>) + 1952;
		object obj4 = typeof(List<AdaptivePerformanceScaler>) + 1984;
		_plantReferenceMultiplier = 0.75f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Queue<object> queue = default(Queue<object>);
		queue..ctor();
		object obj5 = this + 96;
		obj5 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253288]");
		_localPositionY = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253288]");
		_verticalOffset = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253288]");
		_graveyardVerticalOffset = 0f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Queue<object> queue2 = default(Queue<object>);
		queue2..ctor();
		_movesQueue = (Queue<Action>)(object)queue2;
		object obj6 = this + 264;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_volume = 0.3f;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253290]");
		startPitch = 0f;
		object obj7 = typeof(List<AdaptivePerformanceScaler>) + 1968;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj8 = (nint)0 + (nint)2368;
		List<object> list = default(List<object>);
		list..ctor(13);
		_jackarooMoveSteps = (List<JackarooMoveStep>)(object)list;
		object obj9 = this + 328;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list2 = default(List<object>);
		list2..ctor();
		_deathMarbles = (List<JackarooMarbleMono>)(object)list2;
		object obj10 = this + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list3 = default(List<object>);
		list3..ctor();
		_guardedMarbles = (List<JackarooMarbleMono>)(object)list3;
		object obj11 = this + 376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list4 = default(List<object>);
		list4..ctor();
		_selectedNodes = (List<JackarooNodeMono>)(object)list4;
		object obj12 = this + 384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list5 = default(List<object>);
		list5..ctor();
		_highlightedFirstNodes = (List<JackarooNodeMono>)(object)list5;
		object obj13 = this + 392;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		List<object> list6 = default(List<object>);
		list6..ctor();
		_highlightedLastNodes = (List<JackarooNodeMono>)(object)list6;
		object obj14 = this + 400;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj15 = typeof(ConditionalWeakTable<System.Net.HttpWebRequest, Mono.Http.NtlmSession>.CreateValueCallback) + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Dictionary<object, object> dictionary = default(Dictionary<object, object>);
		dictionary..ctor();
		_guardedMarblesDictionary = (Dictionary<Card, List<JackarooMarbleMono>>)(object)dictionary;
		object obj16 = this + 408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [7253298]");
		_blockedBaseFadeSpeed = 0f;
		object obj17 = typeof(List<AdaptivePerformanceScaler>) + 1800;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)1328;
		List<int> list7 = default(List<int>);
		list7..ctor(2);
		_winnerPlayersIndices = list7;
		object obj19 = this + 440;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj20 = typeof(IEnumerator<KeyValuePair<int, (RTHandle, int)>>) + 3752;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj21 = (nint)0 + (nint)2976;
		List<object> list8 = default(List<object>);
		list8..ctor(8);
		_winnerPlayersMarbles = (List<List<JackarooMarbleMono>>)(object)list8;
		object obj22 = this + 448;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		_delayBetweenFireworks = 0.1f;
		_fireworksAudioDelay = 0.5f;
		object obj23 = typeof(System.Formats.Asn1.SetOfValueComparer) + 1016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		SoundOptions soundOptions = default(SoundOptions);
		soundOptions..ctor(SoundOptions.Channel.SFX, SoundOptions.Mode.Instant);
		_soundOptions = soundOptions;
		object obj24 = this + 480;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	private int <DoCheckWithServer>b__46_1(JackarooMarble marble)
	{
		//IL_0065: Expected I4, but got O
		//IL_0052: Expected O, but got I
		if (marble != null)
		{
			JackarooBoard jackarooBoard = <Board>k__BackingField;
			if (<Board>k__BackingField != null)
			{
				object obj = (nint)0 + (nint)2464;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2C97238");
				int result = default(int);
				return result;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		return (int)ex;
	}

	private void <MoveMarbleToGraveyard>b__47_0()
	{
		<IsMovingToGraveyard>k__BackingField = false;
	}
}
