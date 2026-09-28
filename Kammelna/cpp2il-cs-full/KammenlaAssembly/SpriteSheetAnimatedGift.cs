using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Spine;
using UnityEngine;
using UnityEngine.InputSystem.XR;
using UnityEngine.UI;

public class SpriteSheetAnimatedGift : AnimatedElement, IAnimatedGift
{
	private sealed class <SpriteSheetAnimation>d__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public SpriteSheetAnimatedGift <>4__this;

		private int <endFrameIndex>5__2;

		private int <i>5__3;

		private float <spriteDuration>5__4;

		private float <spriteTime>5__5;

		private int <frameIndex>5__6;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <SpriteSheetAnimation>d__46(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_0a5b: Expected O, but got I4
			//IL_0a75: Expected O, but got I4
			//IL_02c4: Expected I4, but got I8
			//IL_02fa: Expected O, but got I4
			//IL_01ef: Expected I4, but got I8
			//IL_0209: Expected O, but got I4
			//IL_034d: Expected O, but got I4
			//IL_0465: Expected I4, but got I8
			//IL_047f: Expected O, but got I4
			//IL_0717: Expected F4, but got I
			//IL_0729: Expected F4, but got I
			//IL_0241: Expected O, but got I4
			//IL_0361: Expected I4, but got I8
			//IL_037b: Expected O, but got I4
			//IL_0883: Expected I4, but got O
			//IL_04b7: Expected O, but got I4
			//IL_09e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_09e9: Expected O, but got Unknown
			//IL_013b: Expected I4, but got I8
			//IL_016f: Expected O, but got I4
			//IL_0765: Invalid comparison between I4 and F4
			//IL_0777: Expected F4, but got I4
			//IL_025e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0263: Expected O, but got Unknown
			//IL_03b3: Expected O, but got I4
			//IL_08bd: Expected O, but got I
			//IL_0a0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a12: Expected O, but got Unknown
			//IL_04f3: Expected I4, but got O
			//IL_04fc: Expected O, but got I4
			//IL_07d4: Expected F4, but got I4
			//IL_0810: Expected I, but got O
			//IL_0843: Expected F4, but got I4
			//IL_028a: Unknown result type (might be due to invalid IL or missing references)
			//IL_028f: Expected O, but got Unknown
			//IL_0077: Expected I4, but got I8
			//IL_00a9: Expected O, but got I4
			//IL_0a32: Expected O, but got I4
			//IL_01a7: Expected O, but got I4
			//IL_0796: Expected F4, but got I4
			//IL_03ed: Expected O, but got I4
			//IL_0525: Expected O, but got I4
			//IL_0ab5: Expected O, but got I4
			//IL_00c0: Expected O, but got I4
			//IL_0439: Expected O, but got I4
			//IL_0920: Unknown result type (might be due to invalid IL or missing references)
			//IL_0925: Expected O, but got Unknown
			//IL_0944: Expected F4, but got I
			//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05aa: Expected O, but got Unknown
			//IL_094f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0954: Expected O, but got Unknown
			//IL_096f: Expected O, but got I4
			//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d3: Expected O, but got Unknown
			//IL_05f3: Expected O, but got I4
			//IL_06ad: Invalid comparison between F4 and I4
			//IL_06de: Expected I4, but got F4
			//IL_0afc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b01: Expected O, but got Unknown
			//IL_0b0a: Expected O, but got I4
			//IL_06d1: Expected I4, but got I8
			//IL_06ec: Expected O, but got I4
			int num = <>1__state;
			SpriteSheetAnimatedGift spriteSheetAnimatedGift = <>4__this;
			object obj = <>1__state - 2;
			bool flag = obj == null;
			object obj2 = !flag;
			bool result;
			SpriteSheetAnimatedGift spriteSheetAnimatedGift2;
			SpriteSheetAnimatedGift spriteSheetAnimatedGift3;
			int num4;
			object obj5;
			object obj6 = default(object);
			object obj7;
			int num6;
			int num7;
			float num8;
			SpriteSheetAnimatedGift spriteSheetAnimatedGift4;
			int frame;
			float num3 = default(float);
			float num2 = default(float);
			nint num5;
			if (<>1__state <= 2)
			{
				if (num != 0)
				{
					if (num != 1)
					{
						bool flag2 = num != 2;
						result = false;
						if (!flag2)
						{
							<>1__state = -1;
							num2 = <spriteDuration>5__4;
							num3 = <spriteTime>5__5;
							bool flag3 = !(<spriteTime>5__5 < <spriteDuration>5__4);
							spriteSheetAnimatedGift2 = (SpriteSheetAnimatedGift)152989696;
							if (!flag3)
							{
								spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
								goto IL_05f8;
							}
							goto IL_0861;
						}
						goto IL_0a94;
					}
					<>1__state = -1;
					bool flag4 = (object)<>4__this == null;
					spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
					if (!flag4)
					{
						SpriteSheetGiftData <GiftData>k__BackingField = spriteSheetAnimatedGift.<GiftData>k__BackingField;
						bool flag5 = (object)spriteSheetAnimatedGift.<GiftData>k__BackingField == null;
						spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
						if (!flag5)
						{
							num = <GiftData>k__BackingField.endFrameIndex;
							bool flag6 = <GiftData>k__BackingField.endFrameIndex == 0;
							obj2 = !flag6;
							if (<GiftData>k__BackingField.endFrameIndex <= 0)
							{
								Sprite[] spriteFrames = spriteSheetAnimatedGift.spriteFrames;
								bool flag7 = spriteSheetAnimatedGift.spriteFrames == null;
								spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
								if (flag7)
								{
									goto IL_06f1;
								}
								num = spriteFrames.Length;
							}
							<endFrameIndex>5__2 = num;
							num4 = 1;
							spriteSheetAnimatedGift2 = (SpriteSheetAnimatedGift)152989696;
							goto IL_0b19;
						}
					}
				}
				else
				{
					<>1__state = -1;
					bool flag8 = (object)<>4__this == null;
					spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
					if (!flag8)
					{
						SpriteSheetGiftData <GiftData>k__BackingField2 = spriteSheetAnimatedGift.<GiftData>k__BackingField;
						bool flag9 = (object)spriteSheetAnimatedGift.<GiftData>k__BackingField == null;
						spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
						if (!flag9)
						{
							object obj3 = typeof(UsageHint) + 1640;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
							WaitForSeconds waitForSeconds = default(WaitForSeconds);
							waitForSeconds..ctor(<GiftData>k__BackingField2.spriteSheetDelay);
							object obj4 = this + 24;
							obj4 = waitForSeconds;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							_ = 1;
							result = true;
							goto IL_0a94;
						}
					}
				}
			}
			else
			{
				if (<>1__state == 3)
				{
					<>1__state = -1;
					num5 = <frameIndex>5__6 + 1;
					<frameIndex>5__6 = (int)num5;
					bool flag10 = num5 >= <endFrameIndex>5__2;
					spriteSheetAnimatedGift2 = (SpriteSheetAnimatedGift)152989696;
					if (flag10)
					{
						goto IL_0861;
					}
					obj5 = obj6;
					obj7 = obj2;
					num6 = <>1__state;
					num7 = (int)num5;
					num8 = num3;
					float num9 = num2;
					spriteSheetAnimatedGift4 = <>4__this;
					spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
					goto IL_0983;
				}
				if (<>1__state != 4)
				{
					bool flag11 = num != 5;
					result = false;
					if (flag11)
					{
						goto IL_0a94;
					}
					<>1__state = -1;
					num5 = <i>5__3 + 1;
					<i>5__3 = (int)num5;
					bool flag12 = (object)<>4__this == null;
					spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
					if (!flag12)
					{
						Sprite[] spriteFrames2 = spriteSheetAnimatedGift.spriteFrames;
						bool flag13 = spriteSheetAnimatedGift.spriteFrames == null;
						spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
						if (!flag13)
						{
							bool flag14 = num5 < spriteFrames2.Length;
							frame = (int)num5;
							if (flag14)
							{
								goto IL_0589;
							}
							goto IL_0974;
						}
					}
				}
				else
				{
					<>1__state = -1;
					bool flag15 = (object)<>4__this == null;
					spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
					if (!flag15)
					{
						Sprite[] spriteFrames3 = spriteSheetAnimatedGift.spriteFrames;
						bool flag16 = spriteSheetAnimatedGift.spriteFrames == null;
						spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
						if (!flag16)
						{
							SpriteSheetGiftData <GiftData>k__BackingField3 = spriteSheetAnimatedGift.<GiftData>k__BackingField;
							bool flag17 = (object)spriteSheetAnimatedGift.<GiftData>k__BackingField == null;
							num = (int)spriteSheetAnimatedGift.<GiftData>k__BackingField;
							spriteSheetAnimatedGift3 = (SpriteSheetAnimatedGift)152989696;
							if (!flag17)
							{
								frame = <endFrameIndex>5__2;
								object obj8 = spriteFrames3.Length - <endFrameIndex>5__2;
								num3 = <GiftData>k__BackingField3.fadeDuration;
								num2 = <GiftData>k__BackingField3.fadeDuration / (float)obj8;
								<spriteDuration>5__4 = num2;
								<i>5__3 = <endFrameIndex>5__2;
								bool flag18 = <endFrameIndex>5__2 >= spriteFrames3.Length;
								num5 = <endFrameIndex>5__2;
								if (!flag18)
								{
									goto IL_0589;
								}
								goto IL_0974;
							}
						}
					}
				}
			}
			goto IL_06f1;
			IL_06f1:
			NullReferenceException ex = new NullReferenceException();
			spriteSheetAnimatedGift = (SpriteSheetAnimatedGift)(object)ex;
			goto IL_0707;
			IL_0861:
			num4 = <i>5__3 + 1;
			goto IL_0b19;
			IL_0983:
			bool flag19 = (object)spriteSheetAnimatedGift4 == null;
			obj6 = obj5;
			obj2 = obj7;
			num = num6;
			num5 = num7;
			num3 = num8;
			if (flag19)
			{
				goto IL_06f1;
			}
			spriteSheetAnimatedGift4.SetFrame(num7);
			object obj9 = typeof(UsageHint) + 1640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitForSeconds waitForSeconds2 = default(WaitForSeconds);
			waitForSeconds2..ctor(<spriteTime>5__5);
			object obj10 = this + 24;
			obj10 = waitForSeconds2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			object obj11 = 3;
			goto IL_0aba;
			IL_0a94:
			return result;
			IL_05f8:
			if ((object)spriteSheetAnimatedGift != null)
			{
				SpriteSheetGiftData <GiftData>k__BackingField4 = spriteSheetAnimatedGift.<GiftData>k__BackingField;
				if ((object)spriteSheetAnimatedGift.<GiftData>k__BackingField != null)
				{
					bool flag20 = <GiftData>k__BackingField4.spritePositionCurve == null;
					spriteSheetAnimatedGift3 = spriteSheetAnimatedGift;
					if (!flag20)
					{
						float time = num3 / num2;
						float num10 = <GiftData>k__BackingField4.spritePositionCurve.Evaluate(time);
						float num11 = num10 * (float)<endFrameIndex>5__2;
						int frame2 = (int)((num11 != 2.139095E+09f) ? ((int)num11) : 2147483648L);
						spriteSheetAnimatedGift.SetFrame(frame2);
						float deltaTime = Time.deltaTime;
						float num12 = <spriteTime>5__5 + deltaTime;
						<spriteTime>5__5 = num12;
						obj10 = this + 24;
						obj10 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						obj11 = 2;
						goto IL_0aba;
					}
				}
			}
			goto IL_06f1;
			IL_0707:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v10 (System.Int32)+100]");
			num2 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v10 (System.Int32)+100]");
			<spriteDuration>5__4 = 0f;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v10 (System.Int32)+108]");
			if ((nint)0 == 1)
			{
				<spriteTime>5__5 = 0f;
				bool flag21 = !(0f < num2);
				num3 = 0f;
				spriteSheetAnimatedGift2 = spriteSheetAnimatedGift3;
				if (!flag21)
				{
					num3 = 0f;
					goto IL_05f8;
				}
			}
			else
			{
				Sprite[] spriteFrames4 = spriteSheetAnimatedGift.spriteFrames;
				if (spriteSheetAnimatedGift.spriteFrames == null)
				{
					goto IL_06f1;
				}
				num3 = spriteFrames4.Length;
				num2 = (<spriteTime>5__5 = num2 / (float)spriteFrames4.Length);
				<frameIndex>5__6 = 0;
				bool flag22 = 0 < <endFrameIndex>5__2;
				num5 = unchecked((nint)null);
				spriteSheetAnimatedGift2 = spriteSheetAnimatedGift3;
				obj5 = obj6;
				obj7 = obj2;
				num6 = num;
				num7 = 0;
				num8 = spriteFrames4.Length;
				float num9 = num2;
				spriteSheetAnimatedGift4 = spriteSheetAnimatedGift;
				if (flag22)
				{
					goto IL_0983;
				}
			}
			goto IL_0861;
			IL_0aba:
			return true;
			IL_0974:
			spriteSheetAnimatedGift.OnAnimationSheetFinished();
			return false;
			IL_0589:
			spriteSheetAnimatedGift.SetFrame(frame);
			object obj12 = typeof(UsageHint) + 1640;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			WaitForSeconds waitForSeconds3 = default(WaitForSeconds);
			waitForSeconds3..ctor(<spriteDuration>5__4);
			obj10 = this + 24;
			obj10 = waitForSeconds3;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			obj11 = 5;
			goto IL_0aba;
			IL_0b19:
			<i>5__3 = num4;
			bool flag23 = (object)spriteSheetAnimatedGift == null;
			spriteSheetAnimatedGift3 = spriteSheetAnimatedGift2;
			if (!flag23)
			{
				num = (int)spriteSheetAnimatedGift.<GiftData>k__BackingField;
				bool flag24 = (object)spriteSheetAnimatedGift.<GiftData>k__BackingField == null;
				spriteSheetAnimatedGift3 = spriteSheetAnimatedGift2;
				if (!flag24)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v10 (System.Int32)+118]");
					obj6 = 0;
					int num13 = num4;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v10 (System.Int32)+118]");
					bool flag25 = (nint)num13 <= (nint)0;
					spriteSheetAnimatedGift3 = spriteSheetAnimatedGift2;
					if (flag25)
					{
						goto IL_0707;
					}
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v10 (System.Int32)+FC]");
					if ((nint)0 < (nint)1)
					{
						goto IL_0974;
					}
					object obj13 = typeof(UsageHint) + 1640;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v130 @ X9_v10 (System.Int32)+14C]");
					WaitForSeconds waitForSeconds4 = default(WaitForSeconds);
					waitForSeconds4..ctor(0f);
					obj10 = this + 24;
					obj10 = waitForSeconds4;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					obj11 = 4;
					goto IL_0aba;
				}
			}
			goto IL_06f1;
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
			object obj2 = (nint)0 + (nint)1016;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			throw new OutOfMemoryException();
		}
	}

	public Transform root;

	private Userbox senderUserbox;

	private Userbox receiverUserbox;

	private Vector3 mainShiftPosition;

	public AudioSource audioSource;

	private SpriteRenderer spriteRenderer;

	private Image imageRenderer;

	private TrailRenderer trailRenderer;

	private Sprite[] spriteFrames;

	private SpriteSheetGiftData <GiftData>k__BackingField;

	private bool <allowClearing>k__BackingField;

	private readonly bool <isCleared>k__BackingField;

	private bool <affectCards>k__BackingField;

	private bool <isSpriteAnimationStarted>k__BackingField;

	public SpriteSheetGiftData GiftData
	{
		get
		{
			return <GiftData>k__BackingField;
		}
		set
		{
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Expected O, but got Unknown
			<GiftData>k__BackingField = value;
			object obj = this + 376;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		}
	}

	public Vector3 startPosition
	{
		get
		{
			if ((object)senderUserbox != null)
			{
				Transform transform = senderUserbox.transform;
				if ((object)transform != null)
				{
					return transform.position;
				}
			}
			return (Vector3)new NullReferenceException();
		}
	}

	public Vector3 targetPosition
	{
		get
		{
			if ((object)receiverUserbox != null)
			{
				Transform transform = receiverUserbox.transform;
				if ((object)transform != null)
				{
					return transform.position;
				}
			}
			return (Vector3)new NullReferenceException();
		}
	}

	public Userbox fromUserBox => senderUserbox;

	public Userbox toUserbox => receiverUserbox;

	public float canvasScale
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_013f: Expected O, but got I4
			//IL_0093: Expected O, but got I
			//IL_01c5: Expected O, but got I4
			//IL_016d: Expected O, but got I
			//IL_0187: Expected O, but got I4
			//IL_00f5: Expected O, but got I
			//IL_010f: Expected F4, but got I
			//IL_01fd: Expected O, but got I
			//IL_021f: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(SqlSingle[]) + 3832;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78F5]");
			object obj3 = (nint)0 & (nint)1;
			if (obj3 != null)
			{
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				if ((nint)0 != 0)
				{
					goto IL_007d;
				}
			}
			else
			{
				_ = 1;
				object obj4 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v11+E4]");
				bool flag = (nint)0 == 0;
				object obj5 = !flag;
				if (obj5 != null)
				{
					goto IL_007d;
				}
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj6 = (nint)0 & (nint)1;
			bool flag2 = obj6 == null;
			object obj7 = !flag2;
			if (obj7 != null)
			{
				goto IL_00b0;
			}
			goto IL_0195;
			IL_00e5:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+B8]");
			object obj8 = 0;
			object obj9 = obj8;
			goto IL_0102;
			IL_0102:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v13+38]");
			return 0f;
			IL_01db:
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			object obj10 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v5+B8]");
			object obj11 = 0;
			obj9 = obj11;
			bool flag3 = obj11 == null;
			object obj12 = !flag3;
			if (obj12 == null)
			{
				throw new NullReferenceException();
			}
			goto IL_0102;
			IL_007d:
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
			object obj13 = (nint)0 & (nint)1;
			if (obj13 != null)
			{
				goto IL_00b0;
			}
			goto IL_0195;
			IL_0195:
			_ = 1;
			object obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+E4]");
			bool flag4 = (nint)0 == 0;
			object obj15 = !flag4;
			object obj16 = obj14;
			if (obj15 != null)
			{
				goto IL_00e5;
			}
			goto IL_01db;
			IL_00b0:
			obj14 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X0_v18+E4]");
			bool flag5 = (nint)0 == 0;
			obj16 = obj14;
			if (!flag5)
			{
				goto IL_00e5;
			}
			goto IL_01db;
		}
	}

	public bool allowClearing
	{
		get
		{
			return <allowClearing>k__BackingField;
		}
		set
		{
			<allowClearing>k__BackingField = value;
		}
	}

	public bool isCleared => <isCleared>k__BackingField;

	public bool affectCards
	{
		get
		{
			return <affectCards>k__BackingField;
		}
		set
		{
			<affectCards>k__BackingField = value;
		}
	}

	public bool isSpriteAnimationStarted
	{
		get
		{
			return <isSpriteAnimationStarted>k__BackingField;
		}
		private set
		{
			<isSpriteAnimationStarted>k__BackingField = value;
		}
	}

	public bool isTargetMainPlayer
	{
		get
		{
			//IL_0074: Expected I4, but got O
			//IL_0037: Expected I4, but got O
			//IL_0066: Expected I4, but got O
			Userbox userbox = receiverUserbox;
			if ((object)receiverUserbox != null)
			{
				if ((int)(~userbox.<player>k__BackingField) == 0)
				{
					return userbox.<player>k__BackingField.IsMe;
				}
				return (byte)(int)userbox.<player>k__BackingField != 0;
			}
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
		}
	}

	public override void Start()
	{
		<GiftData>k__BackingField.Apply(this);
		SetupTrailRenderer();
		base.Start();
	}

	public void StartAnimation()
	{
		//IL_006d: Expected I, but got O
		//IL_007d: Expected O, but got I
		//IL_008d: Expected O, but got I
		<isSpriteAnimationStarted>k__BackingField = false;
		SpriteSheetGiftData spriteSheetGiftData = <GiftData>k__BackingField;
		if (spriteSheetGiftData.displayOnStart)
		{
			ActivateFrameRenderer();
			SpriteSheetGiftData spriteSheetGiftData2 = <GiftData>k__BackingField;
			SetFrame(spriteSheetGiftData2.startFrameIndex);
		}
		nint num = (nint)this;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (Il2CppClass<SpriteSheetAnimatedGift>)+1B8]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X8_v5 (Il2CppClass<SpriteSheetAnimatedGift>)+1C0]");
		object obj2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v73 @ X2_v1 (should have been resolved before IL gen)");
		/*Error: End of method reached without returning.*/;
	}

	public void Setup()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cc: Expected O, but got Unknown
		//IL_018e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0193: Expected O, but got Unknown
		//IL_01a9: Expected O, but got I
		//IL_02c9: Expected O, but got I4
		//IL_0209: Expected O, but got I
		//IL_034f: Expected O, but got I4
		//IL_02f7: Expected O, but got I
		//IL_0311: Expected O, but got I4
		//IL_026b: Expected O, but got I
		//IL_0285: Expected O, but got I4
		//IL_03ce: Expected O, but got I4
		Userbox userbox = receiverUserbox;
		bool flag = userbox.<player>k__BackingField == null;
		Component component = userbox;
		object obj2 = default(object);
		object obj4 = default(object);
		object obj6 = default(object);
		object obj5;
		object obj3;
		object obj;
		if (!flag)
		{
			bool isMe = userbox.<player>k__BackingField.IsMe;
			component = receiverUserbox;
			if (isMe)
			{
				Transform transform = receiverUserbox.transform;
				Vector3 position = transform.position;
				obj = (object)mainShiftPosition + obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetAnimatedGift)+144]");
				obj3 = 0 + obj4;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SpriteSheetAnimatedGift)+148]");
				obj5 = 0 + obj6;
				goto IL_010d;
			}
		}
		Transform transform2 = component.transform;
		Vector3 position2 = transform2.position;
		obj5 = obj6;
		obj3 = obj4;
		obj = obj2;
		goto IL_010d;
		IL_01f3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
		object obj7 = (nint)0 & (nint)1;
		if (obj7 != null)
		{
			goto IL_0226;
		}
		goto IL_031f;
		IL_0365:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		goto IL_0374;
		IL_031f:
		_ = 1;
		object obj9;
		object obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v26+E4]");
		bool flag2 = (nint)0 == 0;
		object obj10 = !flag2;
		object obj11 = obj8;
		if (obj10 != null)
		{
			goto IL_025b;
		}
		goto IL_0365;
		IL_010d:
		Vector3 vector = default(Vector3);
		spline.Prepare(this, vector);
		SpriteSheetGiftData spriteSheetGiftData = <GiftData>k__BackingField;
		Vector3[] splineLastPointPositions = spriteSheetGiftData.splineLastPointPositions;
		if (splineLastPointPositions.Length == 0)
		{
			return;
		}
		Userbox userbox2 = receiverUserbox;
		Vector3 lastPointPlacement = GetLastPointPlacement(userbox2.direction);
		obj9 = typeof(SqlSingle[]) + 3832;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E78F5]");
		object obj12 = (nint)0 & (nint)1;
		if (obj12 != null)
		{
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v20+E4]");
			if ((nint)0 != 0)
			{
				goto IL_01f3;
			}
		}
		else
		{
			_ = 1;
			object obj13 = obj9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v235 @ X0_v20+E4]");
			bool flag3 = (nint)0 == 0;
			object obj14 = !flag3;
			if (obj14 != null)
			{
				goto IL_01f3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
		object obj15 = (nint)0 & (nint)1;
		bool flag4 = obj15 == null;
		object obj16 = !flag4;
		if (obj16 != null)
		{
			goto IL_0226;
		}
		goto IL_031f;
		IL_0226:
		obj8 = obj9;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v26+E4]");
		bool flag5 = (nint)0 == 0;
		obj11 = obj8;
		if (!flag5)
		{
			goto IL_025b;
		}
		goto IL_0365;
		IL_0374:
		SplineHolder splineHolder = spline;
		int pointCount = splineHolder.spline.pointCount;
		SplineHolder splineHolder2 = spline;
		int index = pointCount - 1;
		splineHolder2.spline.SetPointPosition(index, (Vector3)0);
		return;
		IL_025b:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X0_v26+B8]");
		object obj17 = 0;
		bool flag6 = obj17 == null;
		object obj18 = !flag6;
		if (obj18 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0374;
	}

	private Vector3 GetLastPointPlacement(Userbox.UserBoxDirection direction)
	{
		//IL_0044: Expected O, but got I
		//IL_009e: Expected O, but got I4
		//IL_035e: Expected O, but got I4
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0240: Expected O, but got I
		//IL_025a: Expected O, but got I4
		//IL_0135: Expected O, but got I
		//IL_02d0: Expected O, but got I
		//IL_02f2: Expected O, but got I4
		//IL_0298: Expected O, but got I4
		//IL_0197: Expected O, but got I
		//IL_020e: Expected O, but got I
		//IL_0216: Expected O, but got I4
		SpriteSheetGiftData spriteSheetGiftData = <GiftData>k__BackingField;
		object obj;
		Vector3 result;
		object obj3;
		object obj8;
		object obj10;
		if ((object)<GiftData>k__BackingField != null)
		{
			IEnumerable<Vector3> splineLastPointPositions = spriteSheetGiftData.splineLastPointPositions;
			if (spriteSheetGiftData.splineLastPointPositions != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v4 (System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)+18]");
				obj = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v4 (System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)+18]");
				if ((nint)0 == 1)
				{
					return Enumerable.First(spriteSheetGiftData.splineLastPointPositions);
				}
				bool flag = direction == Userbox.UserBoxDirection.Bottom;
				object obj2 = !flag;
				result = (Vector3)this;
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v4 (System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)+18]");
					bool flag2 = (nint)0 != 4;
					result = (Vector3)this;
					if (!flag2)
					{
						obj3 = typeof(SqlSingle[]) + 3832;
						object obj4 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v210 @ X0_v7+E4]");
						if ((nint)0 != 0)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
							object obj5 = (nint)0 & (nint)1;
							if (obj5 != null)
							{
								goto IL_0152;
							}
						}
						else
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [8BE45A6]");
							object obj6 = (nint)0 & (nint)1;
							bool flag3 = obj6 == null;
							object obj7 = !flag3;
							if (obj7 != null)
							{
								goto IL_0152;
							}
						}
						_ = 1;
						obj8 = obj3;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v22+E4]");
						bool flag4 = (nint)0 == 0;
						object obj9 = !flag4;
						obj10 = obj8;
						if (obj9 != null)
						{
							goto IL_0187;
						}
						goto IL_02ae;
					}
				}
				goto IL_0345;
			}
		}
		goto IL_0300;
		IL_02ae:
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		object obj11 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X0_v10+B8]");
		object obj12 = 0;
		AnimatedItemController animatedItemController = (AnimatedItemController)obj12;
		bool flag5 = obj12 == null;
		object obj13 = !flag5;
		if (obj13 != null)
		{
			goto IL_01bc;
		}
		goto IL_0300;
		IL_0152:
		obj8 = obj3;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v22+E4]");
		bool flag6 = (nint)0 == 0;
		obj10 = obj8;
		if (!flag6)
		{
			goto IL_0187;
		}
		goto IL_02ae;
		IL_0187:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v238 @ X0_v22+B8]");
		object obj14 = 0;
		animatedItemController = (AnimatedItemController)obj14;
		if (obj14 != null)
		{
			goto IL_01bc;
		}
		goto IL_0300;
		IL_0300:
		NullReferenceException ex = new NullReferenceException();
		goto IL_030e;
		IL_01bc:
		bool isSpectator = animatedItemController.isSpectator;
		if (isSpectator)
		{
			return Enumerable.Last(spriteSheetGiftData.splineLastPointPositions);
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X20_v4 (System.Collections.Generic.IEnumerable`1<UnityEngine.Vector3>)+18]");
		obj = 0;
		result = (Vector3)isSpectator;
		goto IL_0345;
		IL_030e:
		return (Vector3)new IndexOutOfRangeException();
		IL_0345:
		bool flag7 = (nint)direction < (nint)obj;
		object obj15 = !flag7;
		if (obj15 == null)
		{
			return result;
		}
		goto IL_030e;
	}

	public void Setup(Texture2D framesTexture, AudioClip clip = null)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Expected O, but got Unknown
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_00f3: Expected O, but got I4
		//IL_00a3: Expected O, but got I4
		//IL_00ad: Expected O, but got I4
		//IL_011a: Unknown result type (might be due to invalid IL or missing references)
		//IL_011f: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_0167: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_01aa: Expected O, but got Unknown
		//IL_021b: Expected O, but got I4
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_025b: Expected O, but got Unknown
		//IL_0264: Unknown result type (might be due to invalid IL or missing references)
		//IL_0269: Expected O, but got Unknown
		SpriteSheetGiftData spriteSheetGiftData = <GiftData>k__BackingField;
		object obj = typeof(MemberAchievementClanFeedData) + 2976;
		Sprite[] array = SpriteExensions.CreateSprites(framesTexture, spriteSheetGiftData.sliceGridSize);
		spriteFrames = array;
		object obj2 = this + 368;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj3 = obj;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag = clip;
			bool flag2 = !flag;
			object obj4 = !flag2;
			object obj5 = 0;
			if (obj4 == null)
			{
				goto IL_00bb;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag3 = clip;
			bool flag4 = !flag3;
			object obj5 = 0;
			if (flag4)
			{
				goto IL_00bb;
			}
		}
		List<object> list = (List<object>)(object)activators;
		object obj6 = typeof(SqlSingle[]) + 4064;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		AnimetedElementActivator animetedElementActivator = default(AnimetedElementActivator);
		animetedElementActivator..ctor();
		animetedElementActivator.type = ActivatorType.AudioClip;
		SpriteSheetGiftData spriteSheetGiftData2 = <GiftData>k__BackingField;
		Vector2 activateRange = (Vector2)(spriteSheetGiftData2.playAudioPosition * 1065017672);
		animetedElementActivator.activateRange = activateRange;
		_ = 1065353216;
		object obj7 = animetedElementActivator + 48;
		obj7 = audioSource;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj8 = animetedElementActivator + 56;
		obj8 = clip;
		_ = 1;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		int version = list._version + 1;
		list._version = version;
		object[] items = list._items;
		bool flag5 = list._size < items.Length;
		object obj9 = !flag5;
		if (obj9 == null)
		{
			int size = list._size + 1;
			list._size = size;
			object obj10 = items + list._size;
			object obj11 = obj10 + 32;
			obj11 = animetedElementActivator;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Setup();
		}
		else
		{
			list.AddWithResize((object)animetedElementActivator);
			Setup();
		}
		return;
		IL_00bb:
		Setup();
	}

	private void SetupTrailRenderer()
	{
		//IL_0092: Expected O, but got I4
		SpriteSheetGiftData spriteSheetGiftData = <GiftData>k__BackingField;
		if (spriteSheetGiftData.useTrail)
		{
			trailRenderer.widthCurve = spriteSheetGiftData.trailWidthCurve;
			SpriteSheetGiftData spriteSheetGiftData2 = <GiftData>k__BackingField;
			trailRenderer.time = spriteSheetGiftData2.trailLifeTime;
			Transform transform = trailRenderer.transform;
			transform.position = (Vector3)0;
		}
	}

	private IEnumerator SpriteSheetAnimation()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Expected O, but got Unknown
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		object obj = typeof(SkeletonBinary.SkeletonInput) + 1104;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj2 = default(object);
		obj2..ctor();
		_ = 0;
		object obj3 = obj2 + 32;
		obj3 = this;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		return (IEnumerator)obj2;
	}

	private void SetFrame(int index)
	{
		//IL_0120: Expected O, but got I4
		//IL_0092: Expected O, but got I4
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Expected O, but got Unknown
		//IL_0173: Expected O, but got I
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ce: Expected O, but got Unknown
		//IL_00e5: Expected O, but got I
		SpriteSheetGiftData spriteSheetGiftData = <GiftData>k__BackingField;
		if ((object)<GiftData>k__BackingField != null)
		{
			Sprite[] array = spriteFrames;
			if (spriteSheetGiftData.useSpriteRenderer)
			{
				if (spriteFrames != null)
				{
					bool flag = index < array.Length;
					object obj = !flag;
					if (obj != null)
					{
						goto IL_0182;
					}
					if ((object)spriteRenderer != null)
					{
						object obj2 = spriteFrames + index;
						SpriteRenderer obj3 = spriteRenderer;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v122 @ X8_v6+20]");
						obj3.sprite = (Sprite)0;
						return;
					}
				}
			}
			else if (spriteFrames != null)
			{
				bool flag2 = index < array.Length;
				object obj4 = !flag2;
				if (obj4 != null)
				{
					goto IL_0182;
				}
				if ((object)imageRenderer != null)
				{
					object obj5 = spriteFrames + index;
					Image image = imageRenderer;
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X8_v5+20]");
					image.sprite = (Sprite)0;
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0182;
		IL_0182:
		throw new IndexOutOfRangeException();
	}

	protected override void OnAnimationChanged(float position)
	{
		//IL_0026: Expected O, but got I4
		//IL_0101: Invalid comparison between F4 and O
		//IL_0138: Invalid comparison between F4 and I4
		//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_018c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		base.OnAnimationChanged(position);
		bool flag = !<isSpriteAnimationStarted>k__BackingField;
		object obj = !flag;
		if (obj == null)
		{
			SpriteSheetGiftData spriteSheetGiftData = <GiftData>k__BackingField;
			if (!(position < spriteSheetGiftData.spritePlayPosition))
			{
				<isSpriteAnimationStarted>k__BackingField = true;
				if (spriteFrames != null)
				{
					ActivateFrameRenderer();
					object obj2 = typeof(SkeletonBinary.SkeletonInput) + 1104;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					object obj3 = default(object);
					obj3..ctor();
					_ = 0;
					object obj4 = obj3 + 32;
					obj4 = this;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
					Coroutine coroutine = StartCoroutine((IEnumerator)obj3);
				}
			}
		}
		SpriteSheetGiftData spriteSheetGiftData2 = <GiftData>k__BackingField;
		if (spriteSheetGiftData2.useTrail)
		{
			bool emitting;
			if ((object)position > spriteSheetGiftData2.trailActiveRange)
			{
				float num = position;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X8_v4 (SpriteSheetGiftData)+138]");
				float num2 = num - 0f;
				bool flag2 = num2 < 0f;
				emitting = flag2;
			}
			else
			{
				emitting = false;
			}
			trailRenderer.emitting = emitting;
		}
	}

	private void OnAnimationSheetFinished()
	{
		//IL_01af: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b4: Expected O, but got Unknown
		//IL_007c: Expected F4, but got I4
		//IL_0092: Expected F4, but got I4
		//IL_02b9: Expected O, but got I4
		//IL_014c: Expected O, but got I
		//IL_020e: Expected F4, but got I4
		//IL_0224: Expected F4, but got I4
		SpriteSheetGiftData spriteSheetGiftData = <GiftData>k__BackingField;
		float num;
		TweenerCore<Color, Color, ColorOptions> tweenerCore;
		float fadeDuration;
		if (spriteSheetGiftData.useOpacityFading)
		{
			float fadeDuration2;
			float num2;
			if (spriteSheetGiftData.endFrameIndex > 0)
			{
				fadeDuration = spriteSheetGiftData.fadeDuration;
				bool flag = !spriteSheetGiftData.useSpriteRenderer;
				num = 0f;
				fadeDuration2 = spriteSheetGiftData.fadeDuration;
				num2 = 0f;
				if (!flag)
				{
					goto IL_00a0;
				}
			}
			else
			{
				num = spriteSheetGiftData.fadeDelay;
				fadeDuration = spriteSheetGiftData.fadeDuration;
				bool flag2 = spriteSheetGiftData.useSpriteRenderer;
				fadeDuration2 = spriteSheetGiftData.fadeDuration;
				num2 = spriteSheetGiftData.fadeDelay;
				if (flag2)
				{
					goto IL_00a0;
				}
			}
			tweenerCore = DOTweenModuleUI.DOFade(imageRenderer, 0f, fadeDuration2);
			fadeDuration = fadeDuration2;
			num = num2;
			goto IL_0140;
		}
		goto IL_0163;
		IL_00a0:
		tweenerCore = DOTweenModuleSprite.DOFade(spriteRenderer, 0f, fadeDuration);
		goto IL_0140;
		IL_0232:
		float destroyDelay;
		float num3;
		float t = destroyDelay + num3;
		GameObject obj;
		UnityEngine.Object.Destroy(obj, t);
		return;
		IL_0163:
		Transform transform = base.transform;
		Transform parent = transform.parent;
		obj = parent.gameObject;
		SpriteSheetGiftData spriteSheetGiftData2 = <GiftData>k__BackingField;
		object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
		float destroyDelay2;
		float num4;
		float fadeDelay;
		if (spriteSheetGiftData2.endFrameIndex > 0)
		{
			destroyDelay = spriteSheetGiftData2.destroyDelay;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v7+E4]");
			bool flag3 = (nint)0 == 0;
			num3 = 0f;
			destroyDelay2 = spriteSheetGiftData2.destroyDelay;
			num4 = 0f;
			if (!flag3)
			{
				goto IL_0232;
			}
		}
		else
		{
			fadeDelay = spriteSheetGiftData2.fadeDelay;
			fadeDuration = spriteSheetGiftData2.fadeDuration;
			num3 = spriteSheetGiftData2.fadeDelay + spriteSheetGiftData2.fadeDuration;
			destroyDelay = spriteSheetGiftData2.destroyDelay;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v216 @ X8_v7+E4]");
			bool flag4 = (nint)0 == 0;
			object obj4 = !flag4;
			destroyDelay2 = spriteSheetGiftData2.destroyDelay;
			num4 = num3;
			if (obj4 != null)
			{
				goto IL_0232;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		float t2 = destroyDelay2 + num4;
		UnityEngine.Object.Destroy(obj, t2);
		return;
		IL_0140:
		object obj5 = (nint)0 + (nint)2736;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058C78");
		fadeDelay = num;
		goto IL_0163;
	}

	private void ActivateFrameRenderer()
	{
		//IL_0050: Expected O, but got I4
		SpriteSheetGiftData spriteSheetGiftData = <GiftData>k__BackingField;
		Component component;
		if (spriteSheetGiftData.useSpriteRenderer)
		{
			bool flag = (object)spriteRenderer == null;
			object obj = !flag;
			component = spriteRenderer;
			if (obj == null)
			{
				throw new NullReferenceException();
			}
		}
		else
		{
			component = imageRenderer;
		}
		GameObject gameObject = component.gameObject;
		gameObject.SetActive(value: true);
	}

	public void PlaySheetAnimation()
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		if (spriteFrames != null)
		{
			ActivateFrameRenderer();
			object obj = typeof(SkeletonBinary.SkeletonInput) + 1104;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			object obj2 = default(object);
			obj2..ctor();
			_ = 0;
			object obj3 = obj2 + 32;
			obj3 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Coroutine coroutine = StartCoroutine((IEnumerator)obj2);
		}
	}

	public void SetUserboxes(Userbox sender, Userbox receiver)
	{
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Expected O, but got Unknown
		//IL_002f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		senderUserbox = sender;
		object obj = this + 304;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		receiverUserbox = receiver;
		object obj2 = this + 312;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public void Clear()
	{
	}

	public void OnSplinePrepared()
	{
		//IL_005d: Unsupported input type for neg.
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected F4, but got Unknown
		Transform transform = receiverUserbox.transform;
		Vector3 position = transform.position;
		Transform transform2 = senderUserbox.transform;
		Vector3 position2 = transform2.position;
		object obj2 = default(object);
		object obj = obj2 - obj2;
		float scaleXSign = 0 - obj;
		spline.SetScaleXSign(scaleXSign);
	}

	public void SetActive(bool active)
	{
		GameObject gameObject = root.gameObject;
		gameObject.SetActive(active);
	}

	public void AttachToCanvas(Transform canvasTransform)
	{
		root.SetParent(canvasTransform, worldPositionStays: false);
	}
}
