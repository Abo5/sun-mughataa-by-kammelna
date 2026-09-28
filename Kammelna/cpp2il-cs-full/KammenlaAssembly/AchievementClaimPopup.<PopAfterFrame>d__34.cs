using System;
using System.Buffers.Text;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Xml.Schema;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using GoogleMobileAds.Ump.Api;
using Kammelna.Server;
using Kammelna.Server.Models.Clans;
using Microsoft.Extensions.DependencyInjection.ServiceLookup;
using Newtonsoft.Json.Linq.JsonPath;
using Sfs2X.Entities;
using TMPro;
using Unity.Properties;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class AchievementClaimPopup : MonoBehaviour
{
	private sealed class QueuedItem
	{
		public readonly string Id;

		public readonly int Level;

		public readonly Action OnClaim;

		public QueuedItem(string id, int level, Action onClaim)
		{
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Expected O, but got Unknown
			object obj = this + 16;
			obj = id;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj2 = this + 32;
			obj2 = onClaim;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	private sealed class <>c__DisplayClass20_0
	{
		public string achievementId;

		public int levelId;

		public Action onClaim;

		internal void <Enqueue>b__0(AchievementClaimPopup p)
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_002a: Expected O, but got I
			//IL_010d: Expected O, but got I4
			//IL_0092: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			//IL_0189: Expected O, but got I
			//IL_014b: Expected O, but got I
			//IL_01ab: Expected O, but got I4
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Expected I4, but got Unknown
			//IL_021d: Expected O, but got I4
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Expected O, but got Unknown
			//IL_0284: Expected O, but got I
			object obj = typeof(SqlSingle[]) + 2304;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B16]");
			object obj2 = (nint)0 & (nint)1;
			if (obj2 != null)
			{
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v17+E4]");
				bool flag = (nint)0 == 0;
				object obj4 = obj3;
				if (!flag)
				{
					goto IL_007c;
				}
			}
			else
			{
				_ = 1;
				object obj3 = obj;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v17+E4]");
				bool flag2 = (nint)0 == 0;
				object obj5 = !flag2;
				object obj4 = obj3;
				if (obj5 != null)
				{
					goto IL_007c;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj6 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X0_v8+B8]");
			object obj7 = (nint)0 + (nint)8;
			obj7 = p;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			string text = achievementId;
			goto IL_0171;
			IL_0171:
			object obj8 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+B8]");
			object obj9 = 0;
			string text2 = text.Trim();
			object obj10 = levelId - 1;
			bool flag3 = (nint)obj10 < 0;
			bool flag4 = obj10 == null;
			int num = levelId ^ 1;
			int num2 = levelId ^ obj10;
			int num3 = num & num2;
			bool flag5 = num3 < 0;
			bool flag6 = flag3 == flag5;
			object obj11 = !flag4;
			object obj12 = flag6 & obj11;
			object obj13 = ~obj12;
			int num4 = ((obj13 != null) ? 1 : levelId);
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v5+8]");
			((AchievementClaimPopup)0).EnqueueInstance(text2, num4, onClaim);
			return;
			IL_007c:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v17+B8]");
			object obj14 = (nint)0 + (nint)8;
			obj14 = p;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			text = achievementId;
			bool flag7 = achievementId == null;
			object obj15 = !flag7;
			if (obj15 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0171;
		}
	}

	private sealed class <>c__DisplayClass28_0
	{
		public AchievementClaimPopup <>4__this;

		public QueuedItem next;

		public CanvasGroup cg;

		public float half;

		internal void <SwapTo>b__0()
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Expected O, but got Unknown
			//IL_008c: Expected O, but got I
			//IL_00ac: Expected O, but got I
			//IL_00bf: Expected O, but got I4
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Expected O, but got Unknown
			//IL_00e4: Expected O, but got I
			//IL_011e: Expected O, but got I4
			//IL_016e: Expected O, but got I
			//IL_017a: Expected O, but got I
			//IL_0186: Expected O, but got I
			object obj = <>4__this + 136;
			obj = next;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			AchievementClaimPopup achievementClaimPopup = <>4__this;
			<>4__this.Bind(achievementClaimPopup._current);
			AchievementClaimPopup achievementClaimPopup2 = <>4__this;
			object obj2 = typeof(UsageHint) + 816;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X8_v9+B8]");
			object obj4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v10+14]");
			object obj5 = (nint)0 * (nint)1063675494;
			achievementClaimPopup2.iconGroup.localScale = (Vector3)0;
			object obj6 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
			object obj7 = (nint)0 + (nint)3288;
			cg.alpha = 0f;
			object obj8 = obj6;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v159 @ X0_v11+E4]");
			bool flag = (nint)0 == 0;
			object obj9 = !flag;
			if (obj9 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			Sequence sequence = DOTween.Sequence();
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30596A0");
			AchievementClaimPopup achievementClaimPopup3 = <>4__this;
			object obj10 = (nint)0 + (nint)2904;
			object obj11 = (nint)0 + (nint)2864;
			object obj12 = (nint)0 + (nint)2408;
			TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(achievementClaimPopup3.iconGroup, 1f, half);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Sequence s = default(Sequence);
			Tween t = default(Tween);
			Sequence sequence2 = TweenSettingsExtensions.Join(s, t);
			TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade(cg, 1f, half);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
			Tween t2 = default(Tween);
			Sequence sequence3 = TweenSettingsExtensions.Join(s, t2);
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
			<>4__this.UpdateQueueCounter();
		}
	}

	private sealed class <>c__DisplayClass29_0
	{
		public QueuedItem q;

		internal bool <Bind>b__0(UserAchievementModel u)
		{
			//IL_0074: Expected I4, but got O
			if (u != null)
			{
				QueuedItem queuedItem = q;
				if (q != null)
				{
					return u.<gameAchievementId>k__BackingField == queuedItem.Id;
				}
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	private sealed class <PopAfterFrame>d__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public AchievementClaimPopup <>4__this;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <PopAfterFrame>d__34(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Expected O, but got Unknown
			//IL_0109: Expected O, but got I4
			//IL_0040: Expected I4, but got I8
			//IL_035b: Expected I4, but got O
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Expected O, but got Unknown
			//IL_016e: Expected O, but got I4
			//IL_00c8: Expected O, but got I4
			//IL_00d1: Expected O, but got I4
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Expected O, but got Unknown
			//IL_01ba: Expected O, but got I4
			//IL_0202: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Expected O, but got Unknown
			//IL_021f: Expected O, but got I
			//IL_0232: Expected O, but got I4
			//IL_024c: Expected O, but got I
			//IL_0261: Unknown result type (might be due to invalid IL or missing references)
			//IL_0266: Expected O, but got Unknown
			//IL_02a3: Expected F4, but got I
			//IL_02a3: Expected O, but got I
			//IL_02b3: Expected O, but got I
			//IL_02df: Expected O, but got I
			//IL_031f: Expected O, but got I
			if (<>1__state != 0)
			{
				if (<>1__state == 1)
				{
					AchievementClaimPopup achievementClaimPopup = <>4__this;
					<>1__state = -1;
					if ((object)<>4__this != null)
					{
						object obj = typeof(MemberAchievementClanFeedData) + 2976;
						object obj2 = obj;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v9+E4]");
						if ((nint)0 != 0)
						{
							bool flag = achievementClaimPopup.iconGroup;
							bool flag2 = !flag;
							object obj3 = !flag2;
							object obj4 = 0;
							if (obj3 == null)
							{
								goto IL_00df;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							bool flag3 = achievementClaimPopup.iconGroup;
							bool flag4 = !flag3;
							object obj4 = 0;
							if (flag4)
							{
								goto IL_00df;
							}
						}
						object obj5 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
						object obj6 = obj5;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v209 @ X0_v11+E4]");
						bool flag5 = (nint)0 == 0;
						object obj7 = !flag5;
						if (obj7 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						int num = DOTween.Kill(achievementClaimPopup.iconGroup);
						if ((object)achievementClaimPopup.iconGroup != null)
						{
							object obj8 = typeof(UsageHint) + 816;
							object obj9 = obj8;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X8_v18+B8]");
							object obj10 = 0;
							achievementClaimPopup.iconGroup.localScale = (Vector3)0;
							Sequence sequence = DOTween.Sequence();
							object obj11 = (nint)0 + (nint)3288;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30596A0");
							object obj12 = <>4__this + 120;
							object obj13 = default(object);
							obj12 = obj13;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X19_v7-18]");
							nint num2 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X19_v7-10]");
							TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale((Transform)num2, 1f, 0f);
							object obj14 = (nint)0 + (nint)2904;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
							Tween t = default(Tween);
							Sequence sequence2 = TweenSettingsExtensions.Append((Sequence)obj12, t);
							object obj15 = (nint)0 + (nint)2408;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v147 @ X19_v7-8]");
							if ((nint)0 != 0)
							{
								object obj16 = (nint)0 + (nint)2480;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CFF124");
								SingleSound singleSound = default(SingleSound);
								SoundChannel.PlaySFXSound(singleSound);
								return <>1__state == 0;
							}
						}
					}
					NullReferenceException ex = new NullReferenceException();
					return (byte)(int)ex != 0;
				}
				goto IL_00df;
			}
			object obj17 = this + 24;
			obj17 = 0;
			_ = 4294967295L;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return <>1__state == 0;
			IL_00df:
			return <>1__state == 0;
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
			object obj2 = (nint)0 + (nint)1976;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	private static readonly AddressReference<AchievementClaimPopup> Address;

	private PopupUI popup;

	private Achievement achievementUi;

	private Button actionButton;

	private TextMeshProUGUI actionLabel;

	private TextMeshProUGUI headline;

	private TextMeshProUGUI achievementName;

	private TextMeshProUGUI pointsText;

	private TextMeshProUGUI queueCounter;

	private RectTransform iconGroup;

	private float popDuration;

	private Ease popEase;

	private TrophySoundAlbum trophySoundAlbum;

	private Sequence _popSeq;

	private readonly Queue<QueuedItem> _queue;

	private QueuedItem _current;

	private bool _visible;

	private const string BTN_CLAIM = "Claim";

	private const string BTN_UPG = "Upgrade";

	private static AchievementClaimPopup _instance;

	public static void Enqueue(string achievementId, int levelId, Action onClaim = null)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_008a: Expected O, but got I4
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00fb: Expected O, but got I4
		//IL_0279: Expected O, but got I
		//IL_0288: Unknown result type (might be due to invalid IL or missing references)
		//IL_028d: Expected O, but got Unknown
		//IL_02b7: Expected O, but got I4
		//IL_0141: Expected O, but got I
		//IL_0206: Expected O, but got I4
		//IL_02ea: Expected O, but got I
		//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fe: Expected O, but got Unknown
		//IL_0314: Expected O, but got I
		//IL_0325: Expected I, but got O
		//IL_0334: Unknown result type (might be due to invalid IL or missing references)
		//IL_0339: Expected O, but got Unknown
		//IL_0363: Expected O, but got I4
		//IL_0188: Expected O, but got I4
		//IL_0246: Expected O, but got I
		//IL_02d5: Expected O, but got I
		//IL_01e2: Expected O, but got I
		//IL_01e2: Expected O, but got I
		//IL_01e2: Expected O, but got I
		object obj = typeof(XmlSchemaInclude) + 3640;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = obj2 + 16;
		obj3 = achievementId;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj4 = obj2 + 32;
		obj4 = onClaim;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		bool flag = string.IsNullOrWhiteSpace((string)obj3);
		bool flag2 = !flag;
		object obj5 = !flag2;
		if (obj5 != null)
		{
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		if ((nint)0 < (nint)1)
		{
			return;
		}
		object obj6 = typeof(SqlSingle[]) + 2304;
		object obj7 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v14+E4]");
		bool flag3 = (nint)0 == 0;
		object obj8 = !flag3;
		if (obj8 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj7 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v14+B8]");
		object obj9 = 0;
		object obj10 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj11 = obj10;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X0_v15+E4]");
		bool flag4 = (nint)0 == 0;
		object obj12 = !flag4;
		if (obj12 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v7+8]");
		bool flag5 = (UnityEngine.Object)0 != null;
		object obj13 = obj6;
		if (flag5)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v20+E4]");
			bool flag6 = (nint)0 == 0;
			object obj14 = !flag6;
			if (obj14 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				obj13 = obj6;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v20+B8]");
			object obj15 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X8_v22+8]");
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+10]");
			nint num2 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+20]");
			((AchievementClaimPopup)num).EnqueueInstance((string)num2, (int)num3, (Action)0);
			return;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v20+E4]");
		bool flag7 = (nint)0 == 0;
		object obj16 = !flag7;
		if (obj16 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj13 = obj6;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v20+B8]");
		object obj17 = 0;
		object obj18 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 1016;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj19 = (nint)0 + (nint)1952;
		Action<object> action = default(Action<object>);
		action..ctor(obj2, (IntPtr)obj19);
		object obj20 = typeof(System.Buffers.Text.ParserHelpers) + 1616;
		object obj21 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v250 @ X0_v23+E4]");
		bool flag8 = (nint)0 == 0;
		object obj22 = !flag8;
		if (obj22 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		object obj23 = (nint)0 + (nint)1792;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2F80C64");
	}

	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_01cc: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0241: Unknown result type (might be due to invalid IL or missing references)
		//IL_0246: Expected O, but got Unknown
		//IL_025c: Expected O, but got I
		//IL_026a: Expected I, but got O
		//IL_00e2: Expected O, but got I
		//IL_0297: Expected O, but got I
		//IL_02b1: Expected O, but got I4
		//IL_02ba: Expected O, but got I4
		//IL_02c3: Expected O, but got I4
		//IL_02d4: Expected O, but got I4
		//IL_02dd: Expected O, but got I4
		//IL_0323: Expected O, but got I4
		//IL_017b: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BB2]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v19+E4]");
			bool flag = (nint)0 == 0;
			obj5 = actionButton;
			obj6 = actionButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = actionButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v19+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = actionButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag3 = obj6;
		bool flag4 = !flag3;
		UnityAction unityAction = null;
		UnityAction unityAction2 = null;
		if (flag4)
		{
			goto IL_00cc;
		}
		goto IL_0223;
		IL_018b:
		PreparePopSequence();
		return;
		IL_0394:
		PopupUI popupUI = popup;
		if (popupUI.<IsCurrentlyShown>k__BackingField)
		{
			popupUI.ShrinkToParent();
			PreparePopSequence();
			return;
		}
		goto IL_018b;
		IL_0158:
		UnityEngine.Object obj8;
		bool flag5 = obj8;
		bool flag6 = !flag5;
		object obj9 = !flag6;
		if (obj9 == null)
		{
			goto IL_018b;
		}
		goto IL_0394;
		IL_0091:
		bool flag7 = obj5;
		bool flag8 = !flag7;
		object obj10 = !flag8;
		unityAction = null;
		unityAction2 = null;
		if (obj10 == null)
		{
			goto IL_00cc;
		}
		goto IL_0223;
		IL_0223:
		Button button = actionButton;
		object obj11 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 3408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj12 = (nint)0 + (nint)1664;
		UnityAction unityAction3 = default(UnityAction);
		unityAction3..ctor(this, (IntPtr)obj12);
		button.m_OnClick.AddListener(unityAction3);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BB6]");
		object obj13 = (nint)0 & (nint)1;
		bool flag9 = obj13 == null;
		object obj14 = !flag9;
		object obj15 = 0;
		object obj16 = 0;
		unityAction = unityAction3;
		object obj17 = 0;
		object obj18 = 0;
		UnityAction unityAction4 = unityAction3;
		if (obj14 != null)
		{
			goto IL_0117;
		}
		goto IL_02f3;
		IL_00cc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BB6]");
		object obj19 = (nint)0 & (nint)1;
		bool flag10 = obj19 == null;
		obj17 = obj15;
		obj18 = obj16;
		unityAction4 = unityAction;
		if (!flag10)
		{
			goto IL_0117;
		}
		goto IL_02f3;
		IL_02f3:
		_ = 1;
		object obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v6+E4]");
		bool flag11 = (nint)0 == 0;
		object obj21 = !flag11;
		obj8 = popup;
		obj15 = obj17;
		obj16 = obj18;
		unityAction = unityAction4;
		UnityEngine.Object obj22 = popup;
		if (obj21 != null)
		{
			goto IL_0158;
		}
		goto IL_035d;
		IL_0117:
		obj20 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v166 @ X0_v6+E4]");
		bool flag12 = (nint)0 == 0;
		obj8 = popup;
		obj22 = popup;
		if (!flag12)
		{
			goto IL_0158;
		}
		goto IL_035d;
		IL_035d:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj22)
		{
			goto IL_018b;
		}
		goto IL_0394;
	}

	private void OnDisable()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		object obj = this + 120;
		if (obj != null && TweenExtensions.IsActive((Tween)obj))
		{
			TweenExtensions.Kill((Tween)obj);
		}
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void OnDestroy()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		object obj = this + 120;
		if (obj != null && TweenExtensions.IsActive((Tween)obj))
		{
			TweenExtensions.Kill((Tween)obj);
		}
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void PreparePopSequence()
	{
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_0235: Expected O, but got Unknown
		//IL_023b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0240: Expected O, but got Unknown
		//IL_0212: Expected O, but got I4
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I
		//IL_00e5: Expected O, but got I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f9: Expected O, but got Unknown
		//IL_0123: Expected O, but got I4
		//IL_0155: Expected O, but got I
		//IL_018e: Expected O, but got I
		//IL_01ba: Expected O, but got I
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = this + 120;
		if (obj2 != null && TweenExtensions.IsActive((Tween)obj2))
		{
			TweenExtensions.Kill((Tween)obj2);
		}
		_popSeq = null;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v6+E4]");
		if ((nint)0 != 0)
		{
			if (!iconGroup)
			{
				return;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = iconGroup;
			bool flag2 = !flag;
			object obj4 = !flag2;
			if (obj4 == null)
			{
				return;
			}
		}
		object obj5 = typeof(UsageHint) + 816;
		object obj6 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v8+B8]");
		object obj7 = 0;
		iconGroup.localScale = (Vector3)0;
		object obj8 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj9 = obj8;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X0_v15+E4]");
		bool flag3 = (nint)0 == 0;
		object obj10 = !flag3;
		if (obj10 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Sequence sequence = DOTween.Sequence();
		object obj11 = (nint)0 + (nint)3288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30596A0");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(iconGroup, 1f, popDuration);
		object obj12 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Sequence s = default(Sequence);
		Tween t = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Append(s, t);
		object obj13 = (nint)0 + (nint)2384;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30506C0");
		Sequence popSeq = default(Sequence);
		_popSeq = popSeq;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void KillPopSequence()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_006a: Expected O, but got I4
		object obj = this + 120;
		if (obj != null && TweenExtensions.IsActive((Tween)obj))
		{
			TweenExtensions.Kill((Tween)obj);
		}
		obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void EnqueueInstance(string achievementId, int levelId, Action onClaim = null)
	{
		//IL_001f: Expected O, but got I4
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00e1: Expected O, but got I4
		bool flag = string.IsNullOrWhiteSpace(achievementId);
		if (levelId < 1)
		{
			return;
		}
		bool flag2 = !flag;
		object obj = !flag2;
		if (obj == null)
		{
			string text = achievementId.Trim();
			object obj2 = typeof(XmlSchemaInclude) + 3672;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj3 = default(object);
			obj3..ctor();
			object obj4 = obj3 + 16;
			obj4 = text;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj5 = obj3 + 32;
			obj5 = onClaim;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			((Queue<object>)(object)_queue).Enqueue(obj3);
			bool flag3 = !_visible;
			object obj6 = !flag3;
			if (obj6 == null)
			{
				ShowNext();
			}
			UpdateQueueCounter();
		}
	}

	private void ShowNext()
	{
		//IL_008a: Expected O, but got I4
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Expected O, but got Unknown
		//IL_00b4: Expected O, but got I
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0184: Expected O, but got Unknown
		//IL_0243: Expected O, but got I4
		//IL_019f: Expected O, but got I
		//IL_01ad: Expected I, but got O
		//IL_01bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c1: Expected O, but got Unknown
		//IL_01eb: Expected O, but got I4
		//IL_0135: Expected O, but got I4
		Queue<object> queue = (Queue<object>)(object)_queue;
		if (queue._size != 0)
		{
			object obj = queue.Dequeue();
			if (_visible)
			{
				SwapTo((QueuedItem)obj);
				return;
			}
			object obj2 = this + 136;
			obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_visible = true;
			object obj3 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3000;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj4 = (nint)0 + (nint)1656;
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj4);
			object obj5 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj6 = obj5;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X0_v27+E4]");
			bool flag = (nint)0 == 0;
			object obj7 = !flag;
			if (obj7 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerProfilesHandler.RequestMyProfile(action);
			return;
		}
		if (!_visible)
		{
			return;
		}
		object obj8 = 152985600;
		object obj9 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BB6]");
		object obj10 = (nint)0 & (nint)1;
		UnityEngine.Object obj12;
		UnityEngine.Object obj13;
		if (obj10 != null)
		{
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v9+E4]");
			bool flag2 = (nint)0 == 0;
			obj12 = popup;
			obj13 = popup;
			if (!flag2)
			{
				goto IL_0112;
			}
		}
		else
		{
			_ = 1;
			object obj11 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X0_v9+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			obj12 = popup;
			obj13 = popup;
			if (obj14 != null)
			{
				goto IL_0112;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj13)
		{
			goto IL_029a;
		}
		goto IL_02dc;
		IL_029a:
		PopupUI popupUI = popup;
		if (popupUI.<IsCurrentlyShown>k__BackingField)
		{
			popupUI.ShrinkToParent();
		}
		goto IL_02dc;
		IL_02dc:
		_visible = false;
		return;
		IL_0112:
		bool flag4 = obj12;
		bool flag5 = !flag4;
		object obj15 = !flag5;
		if (obj15 != null)
		{
			goto IL_029a;
		}
		goto IL_02dc;
	}

	private void SwapTo(QueuedItem next)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0375: Expected O, but got I4
		//IL_00d4: Expected O, but got I
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_0389: Unknown result type (might be due to invalid IL or missing references)
		//IL_038e: Expected O, but got Unknown
		//IL_03ec: Expected O, but got I4
		//IL_03f5: Expected O, but got I4
		//IL_0155: Expected O, but got I4
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected O, but got Unknown
		//IL_0423: Expected O, but got I
		//IL_01e0: Expected O, but got I
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0462: Expected O, but got Unknown
		//IL_048c: Expected O, but got I4
		//IL_0219: Expected O, but got I
		//IL_0244: Expected F4, but got I
		//IL_0254: Expected O, but got I
		//IL_0296: Expected F4, but got I
		//IL_0296: Expected O, but got I
		//IL_02ab: Expected O, but got I
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02df: Expected O, but got Unknown
		//IL_02f5: Expected O, but got I
		//IL_0306: Expected I, but got O
		//IL_0317: Expected O, but got I
		//IL_032d: Expected O, but got I
		object obj = typeof(XmlSchemaInclude) + 3648;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		object obj3 = typeof(MemberAchievementClanFeedData) + 2976;
		object obj4 = obj2 + 16;
		obj4 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj5 = obj2 + 24;
		obj5 = next;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj6 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v11+E4]");
		if ((nint)0 != 0)
		{
			if ((bool)iconGroup)
			{
				goto IL_00c8;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag = iconGroup;
			bool flag2 = !flag;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00c8;
			}
		}
		object obj8 = this + 136;
		obj8 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Bind((QueuedItem)obj8);
		UpdateQueueCounter();
		return;
		IL_0163:
		object targetOrId = iconGroup;
		object obj9 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		object obj10 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v8+E4]");
		bool flag3 = (nint)0 == 0;
		object obj11 = iconGroup;
		if (!flag3)
		{
			goto IL_01b8;
		}
		goto IL_04ac;
		IL_04ac:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		targetOrId = obj11;
		goto IL_01b8;
		IL_01b8:
		int num = DOTween.Kill(targetOrId);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+20]");
		int num2 = DOTween.Kill(0);
		double num3 = (double)popDuration * 0.5;
		Sequence sequence = DOTween.Sequence();
		object obj12 = (nint)0 + (nint)3288;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @30596A0");
		RectTransform target = iconGroup;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+28]");
		TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOScale(target, 0.9f, 0f);
		object obj13 = (nint)0 + (nint)2904;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Sequence s = default(Sequence);
		Tween t = default(Tween);
		Sequence sequence2 = TweenSettingsExtensions.Join(s, t);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+20]");
		nint num4 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+28]");
		TweenerCore<float, float, FloatOptions> tweenerCore2 = DOTweenModuleUI.DOFade((CanvasGroup)num4, 0f, 0f);
		object obj14 = (nint)0 + (nint)2864;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
		Tween t2 = default(Tween);
		Sequence sequence3 = TweenSettingsExtensions.Join(s, t2);
		object obj15 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj16 = (nint)0 + (nint)1960;
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(obj2, (IntPtr)obj16);
		object obj17 = (nint)0 + (nint)2512;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		object obj18 = (nint)0 + (nint)2408;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3050858");
		return;
		IL_00c8:
		object obj19 = (nint)0 + (nint)3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
		object obj20 = obj2 + 32;
		object obj21 = default(object);
		obj20 = obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj22 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X0_v25+E4]");
		object obj23;
		if ((nint)0 != 0)
		{
			bool flag4 = (UnityEngine.Object)obj20;
			bool flag5 = !flag4;
			obj23 = 0;
			if (!flag5)
			{
				goto IL_0163;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = (UnityEngine.Object)obj20;
			bool flag7 = !flag6;
			object obj24 = !flag7;
			obj23 = 0;
			if (obj24 != null)
			{
				goto IL_0163;
			}
		}
		GameObject gameObject = iconGroup.gameObject;
		object obj25 = (nint)0 + (nint)616;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
		object obj26 = default(object);
		obj20 = obj26;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		targetOrId = iconGroup;
		object obj27 = typeof(System.Runtime.Remoting.Messaging.CallContextSecurityData) + 3848;
		obj10 = obj27;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X8_v8+E4]");
		bool flag8 = (nint)0 == 0;
		object obj28 = !flag8;
		obj23 = obj26;
		obj11 = iconGroup;
		if (obj28 != null)
		{
			goto IL_01b8;
		}
		goto IL_04ac;
	}

	private unsafe void Bind(QueuedItem q)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00d5: Expected O, but got I4
		//IL_16c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cb: Expected O, but got Unknown
		//IL_16d7: Expected O, but got I
		//IL_1701: Expected O, but got I4
		//IL_1896: Expected O, but got I
		//IL_18a6: Expected O, but got I
		//IL_18ae: Expected I, but got O
		//IL_18c3: Expected O, but got I
		//IL_18f1: Expected O, but got I4
		//IL_013d: Expected O, but got I
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_015f: Expected O, but got Unknown
		//IL_027f: Expected I, but got O
		//IL_0287: Expected O, but got Ref
		//IL_0294: Expected I, but got O
		//IL_029c: Expected O, but got Ref
		//IL_01d6: Expected O, but got I4
		//IL_01db: Expected I, but got O
		//IL_01e3: Expected O, but got Ref
		//IL_01fe: Expected I, but got O
		//IL_0206: Expected O, but got Ref
		//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fb: Expected O, but got Unknown
		//IL_0411: Expected O, but got I
		//IL_0455: Unknown result type (might be due to invalid IL or missing references)
		//IL_045a: Expected I4, but got Unknown
		//IL_048f: Expected O, but got I4
		//IL_0497: Unknown result type (might be due to invalid IL or missing references)
		//IL_049c: Expected O, but got Unknown
		//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_0306: Expected O, but got I
		//IL_0317: Expected I, but got O
		//IL_0328: Expected O, but got I
		//IL_0330: Expected I, but got O
		//IL_0368: Expected O, but got I4
		//IL_0570: Unknown result type (might be due to invalid IL or missing references)
		//IL_0575: Expected O, but got Unknown
		//IL_057f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_059a: Expected O, but got I
		//IL_05cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d4: Expected I4, but got Unknown
		//IL_0609: Expected O, but got I4
		//IL_0398: Expected I, but got O
		//IL_0508: Unknown result type (might be due to invalid IL or missing references)
		//IL_050d: Expected O, but got Unknown
		//IL_0541: Expected O, but got I4
		//IL_078e: Expected O, but got I4
		//IL_06b0: Expected O, but got I4
		//IL_06b5: Expected I, but got O
		//IL_06ba: Expected I, but got O
		//IL_0739: Expected O, but got I4
		//IL_0704: Expected O, but got I4
		//IL_0958: Expected O, but got I
		//IL_0a7a: Expected I4, but got O
		//IL_08fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0902: Expected O, but got Unknown
		//IL_092d: Expected I, but got O
		//IL_0932: Expected I, but got O
		//IL_09a9: Expected O, but got I
		//IL_09b1: Expected I, but got O
		//IL_09fa: Expected O, but got I4
		//IL_085a: Unknown result type (might be due to invalid IL or missing references)
		//IL_085f: Expected O, but got Unknown
		//IL_0868: Unknown result type (might be due to invalid IL or missing references)
		//IL_086d: Expected O, but got Unknown
		//IL_0b36: Expected O, but got I4
		//IL_17a6: Expected O, but got I4
		//IL_17ab: Expected I, but got O
		//IL_0a20: Expected I, but got O
		//IL_08a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a7: Expected O, but got Unknown
		//IL_08e6: Expected I, but got O
		//IL_17c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c8: Expected O, but got Unknown
		//IL_17f4: Expected O, but got I
		//IL_0aff: Expected O, but got I
		//IL_0bda: Expected O, but got I4
		//IL_14e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ee: Expected O, but got Unknown
		//IL_0e3a: Expected O, but got I4
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e73: Expected I4, but got Unknown
		//IL_0ea8: Expected O, but got I4
		//IL_0eb0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb5: Expected O, but got Unknown
		//IL_0cc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc5: Expected O, but got Unknown
		//IL_0cef: Expected O, but got I4
		//IL_184d: Expected O, but got I4
		//IL_0d16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1b: Expected O, but got Unknown
		//IL_0d38: Expected O, but got I
		//IL_0c72: Expected O, but got I4
		//IL_0c7f: Expected I, but got O
		//IL_0d95: Expected O, but got I4
		//IL_0da7: Expected I, but got O
		//IL_0db1: Expected I, but got O
		//IL_0c9a: Expected I, but got O
		//IL_1562: Expected O, but got I
		//IL_156b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1570: Expected O, but got Unknown
		//IL_1580: Expected O, but got I
		//IL_1642: Expected O, but got I4
		//IL_0f4f: Expected O, but got I
		//IL_0f57: Expected I, but got O
		//IL_0f6c: Expected O, but got I
		//IL_0f8f: Expected O, but got I4
		//IL_0fbc: Expected I, but got O
		//IL_0fc4: Expected O, but got I4
		//IL_14cc: Expected I, but got O
		//IL_0ff3: Expected O, but got I4
		//IL_10c5: Expected O, but got I4
		//IL_10de: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e3: Expected O, but got Unknown
		//IL_1103: Unknown result type (might be due to invalid IL or missing references)
		//IL_1108: Expected O, but got Unknown
		//IL_1132: Expected O, but got I4
		//IL_1159: Unknown result type (might be due to invalid IL or missing references)
		//IL_115e: Expected O, but got Unknown
		//IL_116b: Expected O, but got Ref
		//IL_117e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1183: Expected O, but got Unknown
		//IL_11ae: Expected I, but got O
		//IL_11b7: Expected O, but got I4
		//IL_11dd: Expected O, but got I4
		//IL_1265: Expected I, but got O
		//IL_11f3: Expected I, but got O
		//IL_1203: Expected O, but got I
		//IL_1229: Expected I, but got O
		//IL_1239: Expected O, but got I
		//IL_1284: Unknown result type (might be due to invalid IL or missing references)
		//IL_1289: Expected O, but got Unknown
		//IL_1330: Expected O, but got I8
		//IL_134c: Expected I, but got O
		//IL_12c8: Expected I, but got O
		//IL_12d8: Expected O, but got I
		//IL_12fe: Expected I, but got O
		//IL_130e: Expected O, but got I
		//IL_136b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1370: Expected O, but got Unknown
		//IL_138c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1391: Expected O, but got Unknown
		//IL_13b6: Expected I, but got O
		//IL_13be: Expected I4, but got O
		object obj = typeof(XmlSchemaInclude) + 3656;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		bool flag = obj2 == null;
		QueuedItem queuedItem = null;
		object obj3;
		object obj5;
		if (!flag)
		{
			obj3 = obj2 + 16;
			obj3 = q;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj4 = obj3;
			bool flag2 = obj3 == null;
			queuedItem = q;
			if (!flag2)
			{
				obj5 = typeof(SqlSingle[]) + 2360;
				object obj6 = obj5;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X0_v13+E4]");
				if ((nint)0 != 0)
				{
					object obj7 = typeof(DeviceRemoveEvent) & 1;
					bool flag3 = obj7 == null;
					object obj8 = !flag3;
					if (obj8 == null)
					{
						goto IL_00e3;
					}
				}
				else
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
					object obj9 = typeof(DeviceRemoveEvent) & 1;
					if (obj9 == null)
					{
						goto IL_00e3;
					}
				}
				goto IL_16b7;
			}
		}
		goto IL_1650;
		IL_063a:
		UnityEngine.Object obj10;
		bool flag4 = obj10;
		bool flag5 = !flag4;
		string text = null;
		if (!flag5)
		{
			goto IL_0665;
		}
		goto IL_07a9;
		IL_15f8:
		Achievement achievement;
		object valueOrDefault;
		UserAchievementModel userAchievementModel = default(UserAchievementModel);
		Action<bool> action = default(Action<bool>);
		achievement.Initialize((GameAchievementViewModel)valueOrDefault, userAchievementModel, action);
		return;
		IL_0665:
		object obj11;
		text = (string)obj11;
		TextMeshProExtensions.Localize(actionLabel, (string)obj11);
		UnityEngine.Object obj12 = headline;
		object obj14;
		object obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v97+E4]");
		bool flag6 = (nint)0 == 0;
		object obj15 = !flag6;
		nint num = unchecked((nint)null);
		nint num2 = unchecked((nint)null);
		UnityEngine.Object obj16 = headline;
		if (obj15 == null)
		{
			goto IL_06d2;
		}
		goto IL_07f2;
		IL_075c:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		UnityEngine.Object obj17;
		bool flag7 = obj17;
		bool flag8 = !flag7;
		object obj18 = !flag8;
		object obj19;
		obj11 = obj19;
		text = null;
		if (obj18 != null)
		{
			goto IL_0665;
		}
		goto IL_07a9;
		IL_00e3:
		_ = 1;
		goto IL_16b7;
		IL_16b7:
		object obj20 = typeof(Queue<string>) + 848;
		object obj21 = (nint)0 + (nint)2080;
		object obj22 = obj5;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v16+E4]");
		bool flag9 = (nint)0 == 0;
		object obj23 = !flag9;
		if (obj23 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			obj22 = obj5;
		}
		object obj24 = (nint)0 + (nint)2200;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v421 @ X0_v16+B8]");
		object dictionary = 0;
		nint num3 = (nint)obj21;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v6+10]");
		valueOrDefault = CollectionExtensions.GetValueOrDefault((IReadOnlyDictionary<object, object>)dictionary, 0);
		object obj25 = obj20;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v483 @ X0_v19+E4]");
		bool flag10 = (nint)0 == 0;
		object obj26 = !flag10;
		if (obj26 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3CEC320");
		SessionModel sessionModel = default(SessionModel);
		bool flag11 = (object)sessionModel == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v263 @ X8_v6+10]");
		queuedItem = (QueuedItem)0;
		nint num4;
		QueuedItem queuedItem2;
		PlayerProfileModel playerProfileModel2;
		QueuedItem queuedItem3;
		if (!flag11)
		{
			object obj27 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			User localUser = sessionModel.LocalUser;
			string dbId = SFSKammelnaUserExtensions.GetDbId(localUser);
			object obj28 = obj27;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v12+E4]");
			PlayerProfileModel playerProfileModel;
			if ((nint)0 != 0)
			{
				bool flag12 = PlayerProfilesHandler.TryGetCached(dbId, out playerProfileModel);
				bool flag13 = playerProfileModel == null;
				object obj29 = !flag13;
				num4 = unchecked((nint)null);
				queuedItem2 = (QueuedItem)(&playerProfileModel);
				playerProfileModel2 = playerProfileModel;
				if (obj29 != null)
				{
					goto IL_02aa;
				}
				num = unchecked((nint)null);
				queuedItem3 = (QueuedItem)(&playerProfileModel);
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag14 = PlayerProfilesHandler.TryGetCached(dbId, out playerProfileModel);
				bool flag15 = playerProfileModel == null;
				num4 = unchecked((nint)null);
				queuedItem2 = (QueuedItem)(&playerProfileModel);
				playerProfileModel2 = playerProfileModel;
				num = unchecked((nint)null);
				queuedItem3 = (QueuedItem)(&playerProfileModel);
				if (!flag15)
				{
					goto IL_02aa;
				}
			}
			goto IL_03a5;
		}
		goto IL_1650;
		IL_06d2:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag16 = obj12;
		bool flag17 = !flag16;
		object obj30 = !flag17;
		num2 = num;
		string text2 = null;
		if (obj30 == null)
		{
			goto IL_071f;
		}
		goto IL_081d;
		IL_07a9:
		obj12 = headline;
		obj13 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v796 @ X8_v97+E4]");
		bool flag18 = (nint)0 == 0;
		num2 = num;
		obj16 = headline;
		if (flag18)
		{
			goto IL_06d2;
		}
		goto IL_07f2;
		IL_071f:
		bool flag19 = valueOrDefault == null;
		object obj31 = !flag19;
		if (obj31 != null)
		{
			goto IL_0948;
		}
		nint num5 = num2;
		string text3 = text2;
		goto IL_0a2f;
		IL_07f2:
		bool flag20 = obj16;
		bool flag21 = !flag20;
		text2 = null;
		if (flag21)
		{
			goto IL_071f;
		}
		goto IL_081d;
		IL_166c:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1ABC");
		throw new OutOfMemoryException();
		IL_0ad2:
		string text4;
		if (valueOrDefault != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v18 (System.Object)+20]");
			text4 = (string)0;
		}
		else
		{
			text4 = null;
		}
		object obj32 = (nint)0 + (nint)2000;
		string text5 = (string)((text4 != null) ? text4 : obj32);
		int num6;
		UnityEngine.Object obj33;
		int num7;
		nint num8;
		Action<bool> action2;
		UnityEngine.Object obj36;
		int num9;
		object obj34;
		string text6;
		if (num6 < 2)
		{
			TextMeshProExtensions.FixArabic(achievementName, text5);
			obj33 = pointsText;
			obj34 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1152 @ X8_v53+E4]");
			bool flag22 = (nint)0 == 0;
			object obj35 = !flag22;
			num7 = num6;
			num8 = unchecked((nint)null);
			if (obj35 != null)
			{
				goto IL_0bb7;
			}
			action = action2;
			num3 = unchecked((nint)null);
			text6 = text5;
			obj36 = pointsText;
		}
		else
		{
			object obj37 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 2656;
			object obj38 = obj37;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1226 @ X0_v85+E4]");
			bool flag23 = (nint)0 == 0;
			object obj39 = !flag23;
			if (obj39 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			object input = "Network Authentication Required" + 3280;
			string text7 = LocalizationUtil.LocalizeOrdinal((string)input, num9);
			object obj40 = (nint)0 + (nint)3488;
			string text8 = text5 + (string)obj40 + text7;
			TextMeshProExtensions.FixArabic(achievementName, text8);
			obj33 = pointsText;
			obj34 = obj14;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1152 @ X8_v53+E4]");
			bool flag24 = (nint)0 == 0;
			object obj41 = !flag24;
			num7 = num6;
			action2 = null;
			num8 = unchecked((nint)null);
			action = null;
			num3 = unchecked((nint)null);
			text6 = text8;
			obj36 = pointsText;
			if (obj41 != null)
			{
				goto IL_0bb7;
			}
		}
		goto IL_0dd1;
		IL_081d:
		System.Int32Enum? int32Enum = default(System.Int32Enum?);
		if (valueOrDefault != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v18 (System.Object)+28]");
			int32Enum = (System.Int32Enum)0;
			object obj42 = "Network Authentication Required" + 72;
			object obj43 = (??)int32Enum & 1;
			if (obj43 != null)
			{
				object obj44 = (object?)int32Enum >> 32;
				object obj45 = "Network Authentication Required" + 120;
				if ((nint)obj44 == 2)
				{
					obj42 = obj45;
				}
				object obj46 = "Network Authentication Required" + 112;
				if ((nint)obj44 == 1)
				{
					obj42 = obj46;
				}
			}
			text2 = (string)obj42;
			TextMeshProExtensions.Localize(headline, (string)obj42);
			bool flag25 = valueOrDefault == null;
			object obj47 = !flag25;
			num2 = unchecked((nint)null);
			if (obj47 != null)
			{
				goto IL_0948;
			}
			num5 = unchecked((nint)null);
			text3 = (string)obj42;
		}
		else
		{
			object obj48 = "Network Authentication Required" + 72;
			text2 = (string)obj48;
			TextMeshProExtensions.Localize(headline, (string)obj48);
			bool flag26 = valueOrDefault == null;
			num2 = unchecked((nint)null);
			num5 = unchecked((nint)null);
			text3 = (string)obj48;
			if (!flag26)
			{
				goto IL_0948;
			}
		}
		goto IL_0a2f;
		IL_02aa:
		bool flag27 = playerProfileModel2.<gameAchievements>k__BackingField == null;
		num = num4;
		queuedItem3 = queuedItem2;
		if (flag27)
		{
			goto IL_03a5;
		}
		object obj49 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj50 = (nint)0 + (nint)1968;
		Func<object, bool> func = default(Func<object, bool>);
		func..ctor(obj2, (IntPtr)obj50);
		object obj51 = (nint)0 + (nint)1376;
		num = (nint)obj51;
		object obj52 = Enumerable.FirstOrDefault(playerProfileModel2.<gameAchievements>k__BackingField, func);
		object obj53 = obj3;
		bool flag28 = obj3 == null;
		object obj54 = !flag28;
		action2 = null;
		queuedItem3 = (QueuedItem)(object)func;
		object obj55 = obj52;
		if (obj54 != null)
		{
			goto IL_03e7;
		}
		action = null;
		num3 = (nint)obj51;
		queuedItem = (QueuedItem)(object)func;
		goto IL_1650;
		IL_0bb7:
		bool flag29 = obj33;
		bool flag30 = !flag29;
		object obj56 = !flag30;
		queuedItem = null;
		if (obj56 != null)
		{
			goto IL_0e2c;
		}
		action = action2;
		num3 = num8;
		bool flag31 = false;
		goto IL_14da;
		IL_0e2c:
		object obj57 = num7 - 1;
		bool flag32 = (nint)obj57 < 0;
		bool flag33 = obj57 == null;
		int num10 = num7 ^ 1;
		int num11 = num7 ^ obj57;
		int num12 = num10 & num11;
		bool flag34 = num12 < 0;
		bool flag35 = flag32 == flag34;
		object obj58 = !flag33;
		object obj59 = flag35 & obj58;
		object obj60 = ~obj59;
		int num13 = ((obj60 != null) ? 1 : num7);
		bool flag36 = num9 < num13;
		object obj61 = !flag36;
		object obj62 = ~obj61;
		object obj63 = ~obj62;
		if (obj63 == null)
		{
			num13 = num9;
		}
		IndexOutOfRangeException ex = default(IndexOutOfRangeException);
		if (valueOrDefault != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v18 (System.Object)+38]");
			if ((nint)0 != 0 && num13 <= num7)
			{
				int num14 = num13 - 1;
				object obj64 = (nint)0 + (nint)296;
				num3 = (nint)obj64;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v18 (System.Object)+38]");
				object obj65 = ((List<object>)0).get_Item(num14);
				bool flag37 = obj65 == null;
				action = action2;
				queuedItem = (QueuedItem)num14;
				if (!flag37)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v228 @ X0_v41 (System.Object)+18]");
					bool flag38 = (nint)0 < (nint)1;
					num8 = (nint)obj64;
					queuedItem = (QueuedItem)num14;
					if (flag38)
					{
						goto IL_13c3;
					}
					bool flag39 = (object)pointsText == null;
					action = action2;
					queuedItem = (QueuedItem)num14;
					if (!flag39)
					{
						Transform transform = pointsText.transform;
						bool flag40 = (object)transform == null;
						action = action2;
						queuedItem = null;
						if (!flag40)
						{
							Transform parent = transform.parent;
							bool flag41 = (object)parent == null;
							action = action2;
							queuedItem = null;
							if (!flag41)
							{
								GameObject gameObject = parent.gameObject;
								bool flag42 = (object)gameObject == null;
								action = action2;
								queuedItem = null;
								if (!flag42)
								{
									gameObject.SetActive(value: true);
									object obj66 = 153100288 + 1024;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC195C");
									object format = "1.2.840.113549.1.12.1.5" + 3512;
									object arg = default(object);
									string text9 = string.Format((string)format, arg);
									object obj67 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2504;
									object obj68 = obj67;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1293 @ X0_v50+E4]");
									bool flag43 = (nint)0 == 0;
									object obj69 = !flag43;
									if (obj69 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
									}
									object iconName = "___# Content push apply failed [{0}]: {1}" + 2944;
									string text10 = StringUtil.Sprite((string)iconName, (Color?)(object)(&int32Enum));
									object obj70 = typeof(TypeConverter<ushort, char>) + 3400;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
									object[] array = default(object[]);
									bool flag44 = array == null;
									action = action2;
									num3 = unchecked((nint)null);
									queuedItem = (QueuedItem)2;
									if (!flag44)
									{
										bool flag45 = text9 == null;
										QueuedItem queuedItem4 = (QueuedItem)2;
										if (!flag45)
										{
											nint num15 = (nint)array;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
											queuedItem4 = (QueuedItem)0;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
											bool flag46 = ex == null;
											action = action2;
											num3 = unchecked((nint)null);
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v373 @ X8_v48 (Il2CppClass<System.Object[]>)+40]");
											queuedItem = (QueuedItem)0;
											if (flag46)
											{
												goto IL_166c;
											}
										}
										bool flag47 = array.Length == 0;
										action = action2;
										num3 = unchecked((nint)null);
										queuedItem = queuedItem4;
										if (!flag47)
										{
											object obj71 = array + 32;
											obj71 = text9;
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
											bool flag48 = text10 == null;
											QueuedItem queuedItem5 = (QueuedItem)(object)text9;
											if (!flag48)
											{
												nint num16 = (nint)array;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
												queuedItem5 = (QueuedItem)0;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
												bool flag49 = ex == null;
												action = action2;
												num3 = unchecked((nint)null);
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v47 (Il2CppClass<System.Object[]>)+40]");
												queuedItem = (QueuedItem)0;
												if (flag49)
												{
													goto IL_166c;
												}
											}
											object obj72 = array.Length & 0xFFFFFFFEL;
											bool flag50 = obj72 == null;
											action = action2;
											num3 = unchecked((nint)null);
											queuedItem = queuedItem5;
											if (!flag50)
											{
												object obj73 = array + 40;
												obj73 = text10;
												Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
												object obj74 = "WhiteSmoke" + 1880;
												TextMeshProExtensions.Localize(pointsText, (string)obj74, array);
												action = null;
												num3 = (nint)array;
												flag31 = (byte)(int)obj74 != 0;
												goto IL_14da;
											}
										}
										goto IL_165e;
									}
								}
							}
						}
					}
				}
				goto IL_1650;
			}
		}
		goto IL_13c3;
		IL_0b5e:
		obj33 = pointsText;
		obj34 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1152 @ X8_v53+E4]");
		bool flag51 = (nint)0 == 0;
		num6 = num7;
		action = action2;
		num3 = num8;
		obj36 = pointsText;
		if (!flag51)
		{
			goto IL_0bb7;
		}
		goto IL_0dd1;
		IL_03a5:
		obj53 = obj3;
		bool flag52 = obj3 == null;
		action2 = action;
		obj55 = null;
		num3 = num;
		queuedItem = queuedItem3;
		if (!flag52)
		{
			goto IL_03e7;
		}
		goto IL_1650;
		IL_03e7:
		obj14 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v13+18]");
		object obj75 = -1;
		bool flag53 = (nint)obj75 < 0;
		bool flag54 = obj75 == null;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v13+18]");
		int num17 = (int)((nint)0 ^ (nint)1);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v13+18]");
		int num18 = 0 ^ obj75;
		int num19 = num17 & num18;
		bool flag55 = num19 < 0;
		bool flag56 = flag53 == flag55;
		object obj76 = !flag54;
		object obj77 = flag56 & obj76;
		object obj78 = ~obj77;
		if (obj78 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v13+18]");
			num9 = 0;
		}
		else
		{
			num9 = 1;
		}
		object obj79;
		if (valueOrDefault != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v18 (System.Object)+28]");
			if ((nint)0 == 2)
			{
				obj11 = "Cannot populate JSON object onto type '{0}'." + 2824;
				obj10 = actionLabel;
				obj79 = obj14;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v95+E4]");
				bool flag57 = (nint)0 == 0;
				object obj80 = !flag57;
				if (obj80 != null)
				{
					goto IL_063a;
				}
				obj19 = obj11;
				obj17 = actionLabel;
				goto IL_075c;
			}
		}
		object obj81 = "Unsupported map type" + 256;
		object obj82 = "Cannot populate JSON object onto type '{0}'." + 2824;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v13+18]");
		object obj83 = -2;
		bool flag58 = (nint)obj83 < 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v13+18]");
		int num20 = (int)((nint)0 ^ (nint)2);
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v13+18]");
		int num21 = 0 ^ obj83;
		int num22 = num20 & num21;
		bool flag59 = num22 < 0;
		bool flag60 = flag58 == flag59;
		object obj84 = !flag60;
		object obj85 = ~obj84;
		obj11 = ((obj85 != null) ? obj81 : obj82);
		obj10 = actionLabel;
		obj79 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X8_v95+E4]");
		bool flag61 = (nint)0 == 0;
		obj19 = obj11;
		obj17 = actionLabel;
		if (!flag61)
		{
			goto IL_063a;
		}
		goto IL_075c;
		IL_165e:
		ex = new IndexOutOfRangeException();
		goto IL_166c;
		IL_0dd1:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag62 = obj36;
		bool flag63 = !flag62;
		num7 = num6;
		action2 = action;
		num8 = num3;
		queuedItem = null;
		flag31 = false;
		if (!flag63)
		{
			goto IL_0e2c;
		}
		goto IL_14da;
		IL_14da:
		object obj86 = typeof(UsageHint) + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		userAchievementModel..ctor();
		object obj87 = obj3;
		bool flag64 = obj3 == null;
		queuedItem = null;
		if (!flag64)
		{
			bool flag65 = userAchievementModel == null;
			queuedItem = null;
			if (!flag65)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v18+10]");
				queuedItem = (QueuedItem)0;
				object obj88 = userAchievementModel + 16;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X8_v18+10]");
				obj88 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				if (obj55 != null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v273 @ X22_v6 (System.Object)+58]");
					bool <claimed>k__BackingField = (byte)((nuint)0u & (nuint)1u) != 0;
					userAchievementModel.<claimed>k__BackingField = <claimed>k__BackingField;
					achievement = achievementUi;
					if ((object)achievementUi != null)
					{
						goto IL_15f8;
					}
				}
				else
				{
					userAchievementModel.<claimed>k__BackingField = false;
					achievement = achievementUi;
					bool flag66 = (object)achievementUi == null;
					object obj89 = !flag66;
					if (obj89 != null)
					{
						goto IL_15f8;
					}
				}
			}
		}
		goto IL_1650;
		IL_13c3:
		bool flag67 = (object)pointsText == null;
		action = action2;
		num3 = num8;
		if (!flag67)
		{
			Transform transform2 = pointsText.transform;
			bool flag68 = (object)transform2 == null;
			action = action2;
			num3 = num8;
			queuedItem = null;
			if (!flag68)
			{
				Transform parent2 = transform2.parent;
				bool flag69 = (object)parent2 == null;
				action = action2;
				num3 = num8;
				queuedItem = null;
				if (!flag69)
				{
					GameObject gameObject2 = parent2.gameObject;
					bool flag70 = (object)gameObject2 == null;
					action = action2;
					num3 = num8;
					queuedItem = null;
					if (!flag70)
					{
						gameObject2.SetActive(value: false);
						action = action2;
						num3 = unchecked((nint)null);
						flag31 = false;
						goto IL_14da;
					}
				}
			}
		}
		goto IL_1650;
		IL_0948:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v18 (System.Object)+38]");
		object obj90 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X0_v18 (System.Object)+38]");
		bool flag71 = (nint)0 == 0;
		num5 = num2;
		text3 = text2;
		if (flag71)
		{
			goto IL_0a2f;
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v75+18]");
		int num23 = 0;
		object obj91 = (nint)0 + (nint)3136;
		num5 = (nint)obj91;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v904 @ X8_v75+18]");
		int? num24 = 0;
		UnityEngine.Object obj92 = achievementName;
		object obj93 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X8_v57+E4]");
		bool flag72 = (nint)0 == 0;
		object obj94 = !flag72;
		int num25 = default(int);
		num6 = num25;
		if (obj94 != null)
		{
			goto IL_0a92;
		}
		num7 = num25;
		num8 = (nint)obj91;
		UnityEngine.Object obj95 = achievementName;
		goto IL_0b04;
		IL_0a92:
		bool flag73 = obj92;
		bool flag74 = !flag73;
		string text11 = null;
		num7 = num6;
		num8 = num5;
		text6 = null;
		if (!flag74)
		{
			goto IL_0ad2;
		}
		goto IL_0b5e;
		IL_0b04:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		bool flag75 = obj95;
		bool flag76 = !flag75;
		object obj96 = !flag76;
		num6 = num7;
		num5 = num8;
		text11 = null;
		text6 = null;
		if (obj96 != null)
		{
			goto IL_0ad2;
		}
		goto IL_0b5e;
		IL_0a2f:
		obj92 = achievementName;
		obj93 = obj14;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1015 @ X8_v57+E4]");
		bool flag77 = (nint)0 == 0;
		num6 = 0;
		num7 = 0;
		num8 = num5;
		num23 = (int)text3;
		obj95 = achievementName;
		if (!flag77)
		{
			goto IL_0a92;
		}
		goto IL_0b04;
		IL_1650:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_165e;
	}

	private void OnAction()
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_006b: Expected O, but got I4
		//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_012f: Expected O, but got Unknown
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0175: Expected O, but got I
		//IL_019f: Expected I, but got O
		if (_current == null)
		{
			return;
		}
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		object obj2 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v2+E4]");
		bool flag3;
		if ((nint)0 != 0)
		{
			bool flag = actionButton;
			bool flag2 = !flag;
			object obj3 = !flag2;
			if (obj3 != null)
			{
				goto IL_00c8;
			}
			flag3 = false;
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag4 = actionButton;
			bool flag5 = !flag4;
			flag3 = false;
			if (!flag5)
			{
				goto IL_00c8;
			}
		}
		goto IL_00e6;
		IL_00c8:
		actionButton.interactable = false;
		flag3 = false;
		goto IL_00e6;
		IL_00e6:
		object obj4 = typeof(UsageHint) + 16;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		UserAchievementModel userAchievementModel = default(UserAchievementModel);
		userAchievementModel..ctor();
		QueuedItem current = _current;
		object obj5 = userAchievementModel + 16;
		obj5 = current.Id;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		QueuedItem current2 = _current;
		object obj6 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 496;
		object obj7 = (nint)0 + (nint)1640;
		userAchievementModel.<levelId>k__BackingField = current2.Level;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Action<object> action = default(Action<object>);
		action..ctor((object)this, (IntPtr)obj7);
		KammelnaRequests.SendClaimAchievement(userAchievementModel, action);
	}

	private void CloseOrNext()
	{
		//IL_0037: Expected O, but got I4
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		//IL_0061: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_00e2: Expected O, but got I4
		Queue<QueuedItem> queue = _queue;
		if (queue._size >= 1)
		{
			ShowNext();
			return;
		}
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BB6]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v7+E4]");
			bool flag = (nint)0 == 0;
			obj5 = popup;
			obj6 = popup;
			if (!flag)
			{
				goto IL_00bf;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X0_v7+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = popup;
			obj6 = popup;
			if (obj7 != null)
			{
				goto IL_00bf;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj6)
		{
			goto IL_00f2;
		}
		goto IL_018d;
		IL_00bf:
		bool flag3 = obj5;
		bool flag4 = !flag3;
		object obj8 = !flag4;
		if (obj8 == null)
		{
			goto IL_00f2;
		}
		goto IL_018d;
		IL_00f2:
		_visible = false;
		UpdateQueueCounter();
		return;
		IL_018d:
		PopupUI popupUI = popup;
		if (popupUI.<IsCurrentlyShown>k__BackingField)
		{
			popupUI.ShrinkToParent();
			_visible = false;
			UpdateQueueCounter();
			return;
		}
		goto IL_00f2;
	}

	private void UpdateQueueCounter()
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00fd: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_020a: Expected O, but got I4
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected I4, but got Unknown
		//IL_0283: Expected O, but got I4
		//IL_0293: Expected O, but got I
		//IL_02a3: Expected O, but got I
		//IL_02c7: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B12]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v13+E4]");
			bool flag = (nint)0 == 0;
			obj5 = queueCounter;
			obj6 = queueCounter;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = queueCounter;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v13+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = queueCounter;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if (!obj6)
		{
			return;
		}
		goto IL_014a;
		IL_014a:
		Queue<QueuedItem> queue = _queue;
		Transform transform = queueCounter.transform;
		Transform parent = transform.parent;
		GameObject gameObject = parent.gameObject;
		bool flag3 = queue._size < 0;
		bool flag4 = queue._size == 0;
		int num = queue._size ^ queue._size;
		int num2 = queue._size & num;
		bool flag5 = num2 < 0;
		bool flag6 = flag3 == flag5;
		object obj8 = !flag4;
		bool active = (byte)((flag6 & obj8) ? 1 : 0) != 0;
		gameObject.SetActive(active);
		string text2;
		if (queue._size > 0)
		{
			int num3 = default(int);
			string text = num3.ToString();
			text2 = text;
		}
		else
		{
			object obj9 = 153100288 + 1024;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X8_v6+90]");
			object obj10 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v212 @ X8_v7+B8]");
			object obj11 = 0;
			text2 = (string)obj11;
			bool flag7 = (object)queueCounter == null;
			object obj12 = !flag7;
			if (obj12 == null)
			{
				throw new NullReferenceException();
			}
		}
		queueCounter.text = text2;
		return;
		IL_0091:
		bool flag8 = obj5;
		bool flag9 = !flag8;
		object obj13 = !flag9;
		if (obj13 == null)
		{
			return;
		}
		goto IL_014a;
	}

	private void SetVisible(bool on)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0190: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BB6]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag = (nint)0 == 0;
			obj5 = popup;
			obj6 = popup;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v5+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = popup;
			obj6 = popup;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		return;
		IL_014e:
		PopupUI popupUI = popup;
		if (on)
		{
			bool flag3 = !popupUI.<IsCurrentlyShown>k__BackingField;
			object obj8 = !flag3;
			if (obj8 == null)
			{
				popupUI.PopFromParent();
			}
		}
		else if (popupUI.<IsCurrentlyShown>k__BackingField)
		{
			popupUI.ShrinkToParent();
		}
		return;
		IL_0091:
		bool flag4 = obj5;
		bool flag5 = !flag4;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			return;
		}
		goto IL_014e;
	}

	private IEnumerator PopAfterFrame()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(XmlSchemaInclude) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	public AchievementClaimPopup()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004a: Expected O, but got Unknown
		object obj = typeof(Queue<string>) + 56;
		popDuration = 0.4f;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		Queue<object> queue = default(Queue<object>);
		queue..ctor();
		object obj2 = this + 128;
		obj2 = queue;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		base..ctor();
	}

	static AchievementClaimPopup()
	{
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		object obj = "<ds.DataTable.OnColumnChanging|INFO> {0}" + 3304;
		object obj2 = typeof(ConsentForm.<Show>c__AnonStorey2.<Show>c__AnonStorey3) + 2984;
		object obj3 = typeof(SqlSingle[]) + 2304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4933C3C");
		object obj4 = obj3;
		object obj6 = default(object);
		object obj5 = obj6;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void <ShowNext>b__27_0(PlayerProfileModel _)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_00f7: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_017c: Expected O, but got I4
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Expected O, but got Unknown
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6BB6]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
			bool flag = (nint)0 == 0;
			obj5 = popup;
			obj6 = popup;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			int num = 1;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X0_v18+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj5 = popup;
			obj6 = popup;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		goto IL_0198;
		IL_0198:
		Bind(_current);
		object obj8 = typeof(XmlSchemaInclude) + 3664;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj9 = default(object);
		obj9..ctor();
		int num2 = 0;
		object obj10 = obj9 + 32;
		obj10 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Coroutine coroutine = StartCoroutine((IEnumerator)obj9);
		UpdateQueueCounter();
		return;
		IL_014e:
		PopupUI popupUI = popup;
		bool flag3 = !popupUI.<IsCurrentlyShown>k__BackingField;
		object obj11 = !flag3;
		if (obj11 == null)
		{
			popupUI.PopFromParent();
		}
		goto IL_0198;
		IL_0091:
		bool flag4 = obj5;
		bool flag5 = !flag4;
		object obj12 = !flag5;
		if (obj12 != null)
		{
			goto IL_014e;
		}
		goto IL_0198;
	}

	private void <OnAction>b__30_0(KammelnaResponseModel<bool> resp)
	{
		//IL_0009: Expected O, but got I4
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		//IL_0033: Expected O, but got I
		//IL_0101: Expected O, but got I4
		//IL_00b4: Expected O, but got I4
		//IL_0163: Expected I, but got O
		//IL_0174: Expected O, but got I
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b6: Expected O, but got Unknown
		//IL_01e0: Expected O, but got I4
		//IL_035f: Expected O, but got I
		//IL_0398: Expected O, but got I4
		//IL_0254: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Expected O, but got Unknown
		//IL_026f: Expected O, but got I
		//IL_027d: Expected I, but got O
		//IL_028e: Expected O, but got I
		//IL_0296: Expected I, but got O
		//IL_02c4: Expected O, but got I4
		//IL_02e9: Expected O, but got I4
		object obj = 152985600;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E6B15]");
		object obj3 = (nint)0 & (nint)1;
		UnityEngine.Object obj5;
		UnityEngine.Object obj6;
		if (obj3 != null)
		{
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v28+E4]");
			bool flag = (nint)0 == 0;
			obj5 = actionButton;
			obj6 = actionButton;
			if (!flag)
			{
				goto IL_0091;
			}
		}
		else
		{
			_ = 1;
			obj5 = actionButton;
			object obj4 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v28+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			obj6 = actionButton;
			if (obj7 != null)
			{
				goto IL_0091;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		if ((bool)obj6)
		{
			goto IL_014e;
		}
		goto IL_0168;
		IL_0168:
		object obj8 = (nint)0 + (nint)1048;
		Func<object, bool> func = (Func<object, bool>)obj8;
		nint num;
		if (resp.Succeeded)
		{
			object obj9 = typeof(System.Buffers.Text.ParserHelpers) + 1056;
			object obj10 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v152 @ X0_v11+E4]");
			bool flag3 = (nint)0 == 0;
			object obj11 = !flag3;
			if (obj11 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerProfileModel myCachedProfile = PlayerProfilesHandler.GetMyCachedProfile();
			if (myCachedProfile != null && myCachedProfile.<gameAchievements>k__BackingField != null)
			{
				object obj12 = typeof(Func<Type, Microsoft.Extensions.DependencyInjection.ServiceLookup.ServiceCallSite>) + 80;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
				object obj13 = (nint)0 + (nint)1648;
				Func<object, bool> func2 = default(Func<object, bool>);
				func2..ctor((object)this, (IntPtr)obj13);
				object obj14 = (nint)0 + (nint)1376;
				num = (nint)obj14;
				object obj15 = Enumerable.FirstOrDefault(myCachedProfile.<gameAchievements>k__BackingField, func2);
				bool flag4 = obj15 == null;
				object obj16 = 0;
				func = func2;
				if (!flag4)
				{
					_ = 1;
					obj16 = 0;
					func = func2;
				}
			}
			object obj17 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v16+E4]");
			bool flag5 = (nint)0 == 0;
			object obj18 = !flag5;
			if (obj18 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			PlayerProfilesHandler.RemoveMyselfFromCache();
			SFS.SendRefreshStatus();
		}
		QueuedItem current = _current;
		Action onClaim = current.OnClaim;
		if (current.OnClaim != null)
		{
			func = (Func<object, bool>)(nint)((Delegate)onClaim).method;
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v139.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		CloseOrNext();
		return;
		IL_014e:
		actionButton.interactable = true;
		num = unchecked((nint)null);
		goto IL_0168;
		IL_0091:
		bool flag6 = obj5;
		bool flag7 = !flag6;
		object obj19 = !flag7;
		if (obj19 != null)
		{
			goto IL_014e;
		}
		goto IL_0168;
	}

	private bool <OnAction>b__30_1(UserAchievementModel u)
	{
		//IL_0137: Expected I4, but got O
		//IL_00ba: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected I4, but got Unknown
		if (u != null)
		{
			QueuedItem current = _current;
			if (_current != null)
			{
				bool flag = u.<gameAchievementId>k__BackingField == current.Id;
				if (flag)
				{
					QueuedItem current2 = _current;
					if (_current == null)
					{
						goto IL_0129;
					}
					object obj = u.<levelId>k__BackingField - current2.Level;
					bool flag2 = (nint)obj < 0;
					int num = u.<levelId>k__BackingField ^ current2.Level;
					int num2 = u.<levelId>k__BackingField ^ obj;
					int num3 = num & num2;
					bool flag3 = num3 < 0;
					bool flag4 = flag2 == flag3;
					flag = flag4;
				}
				return flag;
			}
		}
		goto IL_0129;
		IL_0129:
		NullReferenceException ex = new NullReferenceException();
		return (byte)(int)ex != 0;
	}
}
