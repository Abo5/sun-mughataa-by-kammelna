using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using Cpp2ILInjected;
using Kammelna.Server.Models.Clans;
using Server.Models;
using Unity.Services.Authentication.Shared;
using UnityEngine.Networking;
using UnityEngine.TextCore;
using Util;

namespace Kammelna.Server.WebRequests.Cache;

public class CachedRequestDecorator<TResponse> : WebRequestDecorator<TResponse>
{
	private sealed class <Execute>d__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public CachedRequestDecorator<TResponse> <>4__this;

		private IEnumerator <requestSteps>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Execute>d__5(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_010e: Expected I4, but got I8
			//IL_002c: Expected I4, but got I8
			//IL_03d6: Expected I4, but got O
			//IL_0122: Unknown result type (might be due to invalid IL or missing references)
			//IL_0127: Expected O, but got Unknown
			//IL_012f: Expected I, but got O
			//IL_013f: Expected O, but got I
			//IL_0056: Expected O, but got I4
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dd: Expected O, but got Unknown
			//IL_01f5: Expected O, but got I4
			//IL_017a: Expected O, but got I
			//IL_007c: Expected I4, but got I8
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e5: Expected O, but got Unknown
			//IL_02ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Expected O, but got Unknown
			//IL_0306: Unknown result type (might be due to invalid IL or missing references)
			//IL_030b: Expected O, but got Unknown
			//IL_0325: Expected O, but got I4
			//IL_0234: Expected I, but got O
			//IL_0244: Expected O, but got I
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Expected O, but got Unknown
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Expected O, but got Unknown
			//IL_035a: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Expected O, but got Unknown
			//IL_02d3: Expected O, but got I4
			//IL_0384: Expected O, but got I4
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Expected O, but got Unknown
			//IL_027f: Expected O, but got I
			//IL_04a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Expected O, but got Unknown
			//IL_03a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a8: Expected O, but got Unknown
			//IL_03b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b5: Expected O, but got Unknown
			//IL_03be: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c3: Expected O, but got Unknown
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0292: Expected O, but got Unknown
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Expected O, but got Unknown
			bool result;
			int num;
			bool result2;
			CachedModelLoadOperation cachedModelLoadOperation2;
			object obj4;
			if (<>1__state != 2)
			{
				bool flag = <>1__state == 1;
				result = false;
				num = -1;
				if (flag)
				{
					goto IL_03f5;
				}
				bool flag2 = <>1__state == 0;
				object obj = !flag2;
				result2 = false;
				if (obj != null)
				{
					goto IL_0404;
				}
				<>1__state = -1;
				if (<>4__this == null)
				{
					goto IL_03c8;
				}
				nint num2 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F2AC");
				nint num3 = 0;
				object obj2 = default(object);
				if (obj2 == null)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4382198");
					object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4032;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
					CachedModelLoadOperation cachedModelLoadOperation = default(CachedModelLoadOperation);
					ICachedModel model = default(ICachedModel);
					cachedModelLoadOperation..ctor(model);
					obj4 = 0;
					num = 1;
					cachedModelLoadOperation2 = cachedModelLoadOperation;
					goto IL_049a;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @438269C");
				object obj5 = this + 40;
				object obj6 = default(object);
				obj5 = obj6;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			}
			else
			{
				<>1__state = -1;
			}
			IEnumerator enumerator = <requestSteps>5__2;
			object obj7;
			if (<requestSteps>5__2 != null)
			{
				obj7 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num4 = (nint)enumerator;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v6 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj8 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v6 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01bb;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v226 @ X8_v6 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj9 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X10_v13-8]");
					if (0 == (nint)obj7)
					{
						break;
					}
					obj9 += 16;
					obj8--;
					if ((nint)obj8 != 1)
					{
						continue;
					}
					goto IL_01bb;
				}
				object obj10 = num4 + obj9;
				object obj11 = obj10 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v319 @ X0_v21] (should have been resolved before IL gen)");
				object obj13 = default(object);
				object obj12 = obj13 & 1;
				bool flag3 = obj12 == null;
				object obj14 = !flag3;
				if (obj14 != null)
				{
					goto IL_0203;
				}
				goto IL_0333;
			}
			goto IL_03c8;
			IL_02c0:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj4 = 1;
			goto IL_047a;
			IL_03f5:
			<>1__state = num;
			return result;
			IL_049a:
			object obj15 = this + 24;
			obj15 = cachedModelLoadOperation2;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			result = true;
			goto IL_03f5;
			IL_01bb:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v281 @ X0_v18] (should have been resolved before IL gen)");
			object obj17 = default(object);
			object obj16 = obj17 & 1;
			bool flag4 = obj16 == null;
			obj4 = 0;
			if (!flag4)
			{
				goto IL_0203;
			}
			goto IL_0333;
			IL_0333:
			result2 = false;
			goto IL_0404;
			IL_0203:
			IEnumerator enumerator2 = <requestSteps>5__2;
			if (<requestSteps>5__2 == null)
			{
				goto IL_03c8;
			}
			nint num5 = (nint)enumerator2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v9 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj18 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v9 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_02c0;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v337 @ X8_v9 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj19 = (nint)0 + (nint)8;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v375 @ X10_v8-8]");
				if (0 == (nint)obj7)
				{
					break;
				}
				obj19 += 16;
				obj18--;
				if ((nint)obj18 != 1)
				{
					continue;
				}
				goto IL_02c0;
			}
			object obj20 = obj19 + 1;
			object obj21 = num5 + obj20;
			object obj22 = obj21 + 312;
			goto IL_047a;
			IL_0404:
			return result2;
			IL_047a:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v422 @ X0_v11] (should have been resolved before IL gen)");
			num = 2;
			CachedModelLoadOperation cachedModelLoadOperation3 = default(CachedModelLoadOperation);
			cachedModelLoadOperation2 = cachedModelLoadOperation3;
			goto IL_049a;
			IL_03c8:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
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
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	private sealed class <Materialize>d__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int <>1__state;

		private object <>2__current;

		public CachedRequestDecorator<TResponse> <>4__this;

		private IEnumerator <requestSteps>5__2;

		object IEnumerator<object>.Current => <>2__current;

		object IEnumerator.Current => <>2__current;

		public <Materialize>d__6(int <>1__state)
		{
			this.<>1__state = <>1__state;
		}

		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			//IL_00d0: Expected I4, but got I8
			//IL_0021: Expected O, but got I4
			//IL_0777: Expected I4, but got O
			//IL_00e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e9: Expected O, but got Unknown
			//IL_00f1: Expected I, but got O
			//IL_0101: Expected O, but got I
			//IL_003e: Expected I4, but got I8
			//IL_019a: Unknown result type (might be due to invalid IL or missing references)
			//IL_019f: Expected O, but got Unknown
			//IL_01b7: Expected O, but got I4
			//IL_01c0: Expected O, but got I4
			//IL_013c: Expected O, but got I
			//IL_061a: Expected O, but got I
			//IL_0630: Expected O, but got I
			//IL_0639: Unknown result type (might be due to invalid IL or missing references)
			//IL_063e: Expected O, but got Unknown
			//IL_0658: Expected O, but got I4
			//IL_02b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Expected O, but got Unknown
			//IL_02c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cc: Expected O, but got Unknown
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e4: Expected O, but got Unknown
			//IL_02fe: Expected O, but got I4
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Expected O, but got Unknown
			//IL_01ff: Expected I, but got O
			//IL_020f: Expected O, but got I
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014f: Expected O, but got Unknown
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_015d: Expected O, but got Unknown
			//IL_029e: Expected O, but got I4
			//IL_0817: Unknown result type (might be due to invalid IL or missing references)
			//IL_081c: Expected O, but got Unknown
			//IL_024a: Expected O, but got I
			//IL_0744: Unknown result type (might be due to invalid IL or missing references)
			//IL_0749: Expected O, but got Unknown
			//IL_0751: Unknown result type (might be due to invalid IL or missing references)
			//IL_0756: Expected O, but got Unknown
			//IL_075f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0764: Expected O, but got Unknown
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Expected O, but got Unknown
			//IL_0266: Unknown result type (might be due to invalid IL or missing references)
			//IL_026b: Expected O, but got Unknown
			//IL_054b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0550: Expected O, but got Unknown
			//IL_057a: Expected O, but got I4
			if (<>1__state != 1)
			{
				bool flag = <>1__state == 0;
				object obj = !flag;
				if (obj == null)
				{
					<>1__state = -1;
					if (<>4__this != null)
					{
						nint num = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F2AC");
						nint num2 = 0;
						object obj2 = default(object);
						if (obj2 != null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @43826BC");
							object obj3 = this + 40;
							object obj4 = default(object);
							obj3 = obj4;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
							goto IL_0796;
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v57 (Il2CppRgctx<Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1+<Materialize>d__6>)+18]");
						object obj5 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v57 (Il2CppRgctx<Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1+<Materialize>d__6>)+18]");
						object obj6 = (nint)0 + (nint)309;
						object obj7 = obj6 & 1;
						bool flag2 = obj7 == null;
						object obj8 = !flag2;
						if (obj8 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
						}
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
						nint num3 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D137C0");
						nint num4 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4382198");
						object obj9 = default(object);
						if (obj9 != null)
						{
							nint num5 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D800");
							object obj10 = default(object);
							if (obj10 != null)
							{
								nint num6 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F404");
								nint num7 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F358");
								object obj11 = default(object);
								if (obj11 != null)
								{
									return false;
								}
							}
						}
					}
					goto IL_0769;
				}
				return false;
			}
			<>1__state = -1;
			goto IL_0796;
			IL_01ce:
			IEnumerator enumerator = <requestSteps>5__2;
			if (<requestSteps>5__2 == null)
			{
				goto IL_0769;
			}
			nint num8 = (nint)enumerator;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v44 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v44 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_028b;
			}
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v411 @ X8_v44 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
			object obj13 = (nint)0 + (nint)8;
			object obj14;
			while (true)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v456 @ X10_v8-8]");
				if (0 == (nint)obj14)
				{
					break;
				}
				obj13 += 16;
				obj12--;
				if ((nint)obj12 != 1)
				{
					continue;
				}
				goto IL_028b;
			}
			object obj15 = obj13 + 1;
			object obj16 = num8 + obj15;
			object obj17 = obj16 + 312;
			goto IL_0807;
			IL_0807:
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v477 @ X0_v38] (should have been resolved before IL gen)");
			object obj18 = this + 24;
			object obj19 = default(object);
			obj18 = obj19;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			_ = 1;
			return true;
			IL_017d:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v352 @ X0_v48] (should have been resolved before IL gen)");
			object obj21 = default(object);
			object obj20 = obj21 & 1;
			bool flag3 = obj20 == null;
			object obj22 = 0;
			object obj23 = 0;
			if (!flag3)
			{
				goto IL_01ce;
			}
			goto IL_0314;
			IL_028b:
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0D070");
			obj22 = 1;
			goto IL_0807;
			IL_0796:
			IEnumerator enumerator2 = <requestSteps>5__2;
			if (<requestSteps>5__2 != null)
			{
				obj14 = typeof(UnityEngine.TextCore.HorizontalAlignment) + 2528;
				nint num9 = (nint)enumerator2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v6 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				object obj24 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v6 (Il2CppClass<System.Collections.IEnumerator>)+12E]");
				if ((nint)0 == 0)
				{
					goto IL_017d;
				}
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v239 @ X8_v6 (Il2CppClass<System.Collections.IEnumerator>)+B0]");
				object obj25 = (nint)0 + (nint)8;
				while (true)
				{
					Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X10_v13-8]");
					if (0 == (nint)obj14)
					{
						break;
					}
					obj25 += 16;
					obj24--;
					if ((nint)obj24 != 1)
					{
						continue;
					}
					goto IL_017d;
				}
				object obj26 = num9 + obj25;
				object obj27 = obj26 + 312;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v397 @ X0_v51] (should have been resolved before IL gen)");
				object obj29 = default(object);
				object obj28 = obj29 & 1;
				bool flag4 = obj28 == null;
				object obj30 = !flag4;
				obj23 = obj22;
				if (obj30 != null)
				{
					goto IL_01ce;
				}
				goto IL_0314;
			}
			goto IL_0769;
			IL_0314:
			if (<>4__this != null)
			{
				nint num10 = 0;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F358");
				object obj31 = default(object);
				if (obj31 != null)
				{
					nint num11 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4D1375C");
					nint num12 = 0;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4382198");
					object obj32 = default(object);
					bool flag5 = default(bool);
					if (obj32 != null)
					{
						if (!flag5)
						{
							return flag5;
						}
						nint num13 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4382198");
						nint num14 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F358");
						object obj33 = default(object);
						if (obj33 != null)
						{
							nint num15 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F358");
							object obj34 = default(object);
							if (obj34 != null)
							{
								nint num16 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F358");
								object obj35 = default(object);
								object obj36 = default(object);
								if (obj35 != null && obj36 != null)
								{
									nint num17 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437DCD4");
									nint num18 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F358");
									nint num19 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4382198");
									object obj37 = default(object);
									if (obj37 != null)
									{
										nint num20 = 0;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D800");
										object obj38 = default(object);
										if (obj38 != null)
										{
											return false;
										}
									}
								}
							}
						}
					}
					else if (flag5)
					{
						nint num21 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D800");
						nint num22 = 0;
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4382198");
						object obj39 = typeof(DataRelation) + 712;
						object obj40 = obj39;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v511 @ X0_v13+E4]");
						bool flag6 = (nint)0 == 0;
						object obj41 = !flag6;
						if (obj41 == null)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
						}
						DateTime now = DateTime.Now;
						object obj42 = default(object);
						if (obj42 != null)
						{
							nint num23 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D714");
							nint num24 = 0;
							Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F358");
							object obj43 = default(object);
							if (obj43 != null)
							{
								return false;
							}
						}
					}
				}
			}
			goto IL_0769;
			IL_0769:
			NullReferenceException ex = new NullReferenceException();
			return (byte)(int)ex != 0;
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
			object obj = typeof(MemberAchievementClanFeedData) + 2648;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			NotSupportedException ex = default(NotSupportedException);
			ex..ctor();
			throw new OutOfMemoryException();
		}
	}

	private readonly string _cachedModelKey;

	private CachedModel<TResponse> CachedModel
	{
		get
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0067: Expected O, but got I4
			object obj = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
			object obj2 = obj;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v2+E4]");
			bool flag = (nint)0 == 0;
			object obj3 = !flag;
			if (obj3 == null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			}
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D1E924");
			CachedModel<TResponse> result = default(CachedModel<TResponse>);
			return result;
		}
	}

	public CachedRequestDecorator(string cachedModelKey, IWebRequest<TResponse> webRequest)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F4BC");
		object obj = this + 24;
		obj = cachedModelKey;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	public override void Setup()
	{
		//IL_0016: Expected O, but got I
		//IL_001f: Expected O, but got I4
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		//IL_0049: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_015e: Expected O, but got I4
		//IL_016e: Expected O, but got I
		//IL_00c3: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_0076: Expected O, but got I
		//IL_00a5: Expected O, but got I
		//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0100: Expected O, but got Unknown
		//IL_0196: Expected O, but got I
		//IL_01a6: Expected O, but got I
		//IL_01cf: Expected O, but got I4
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1>)+30]");
		object obj = 0;
		object obj2 = 152973312;
		object obj3 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E33B6]");
		object obj4 = (nint)0 & (nint)1;
		if (obj4 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj5 = 0;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj7 = 0;
			if (!flag)
			{
				goto IL_00b3;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj5 = 0;
			object obj6 = obj3;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v6+E4]");
			bool flag2 = (nint)0 == 0;
			object obj8 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj7 = 0;
			if (obj8 != null)
			{
				goto IL_00b3;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X22_v1+20]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X8_v11+C0]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D1E924");
		object obj11 = default(object);
		bool flag3 = obj11 == null;
		object obj12 = !flag3;
		if (obj12 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_00e2;
		IL_00b3:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X22_v1+20]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v19+C0]");
		object obj14 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D1E924");
		goto IL_00e2;
		IL_00e2:
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437DA58");
		object obj16 = default(object);
		object obj15 = obj16 & 1;
		if (obj15 == null)
		{
			nint num3 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F4F0");
			nint num4 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @4382450");
		}
	}

	public override IEnumerator Execute()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1>)+50]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1>)+50]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @449BB68");
		IEnumerator enumerator = default(IEnumerator);
		if (enumerator != null)
		{
			object obj5 = enumerator + 32;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	public override IEnumerator Materialize()
	{
		//IL_0016: Expected O, but got I
		//IL_002c: Expected O, but got I
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_0054: Expected O, but got I4
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1>)+60]");
		object obj = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v19 @ X8_v2 (Il2CppRgctx<Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1>)+60]");
		object obj2 = (nint)0 + (nint)309;
		object obj3 = obj2 & 1;
		bool flag = obj3 == null;
		object obj4 = !flag;
		if (obj4 == null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @B0CCA4");
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @45A7EE8");
		IEnumerator enumerator = default(IEnumerator);
		if (enumerator != null)
		{
			object obj5 = enumerator + 32;
			obj5 = this;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return enumerator;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private void InitializeETagHeader()
	{
		//IL_047e: Expected O, but got I
		//IL_048d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0492: Expected O, but got Unknown
		//IL_04a8: Expected O, but got I
		//IL_00cf: Expected O, but got I
		//IL_00f9: Expected O, but got I4
		//IL_0109: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_0072: Expected O, but got I
		//IL_0082: Expected O, but got I
		//IL_00a6: Expected O, but got I4
		//IL_0015: Expected O, but got I
		//IL_0044: Expected O, but got I
		//IL_0131: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_018c: Expected O, but got Unknown
		//IL_024f: Expected O, but got I4
		//IL_0258: Expected O, but got I4
		//IL_01ef: Expected O, but got I4
		//IL_0207: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_027c: Expected O, but got I
		//IL_0292: Expected O, but got I
		//IL_0379: Expected O, but got I
		//IL_03a3: Expected O, but got I4
		//IL_03b3: Expected O, but got I
		//IL_044a: Unknown result type (might be due to invalid IL or missing references)
		//IL_044f: Expected O, but got Unknown
		//IL_030c: Expected O, but got I
		//IL_031c: Expected O, but got I
		//IL_032c: Expected O, but got I
		//IL_0350: Expected O, but got I4
		//IL_02bf: Expected O, but got I
		//IL_02ee: Expected O, but got I
		//IL_03db: Expected O, but got I
		//IL_03eb: Expected O, but got I
		//IL_03fb: Expected O, but got I
		nint num = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X8_v4 (Il2CppRgctx<Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1>)+30]");
		object obj = 0;
		object obj2 = typeof(Unity.Services.Authentication.Shared.ApiConfiguration) + 4040;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E33B6]");
		object obj3 = (nint)0 & (nint)1;
		if (obj3 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj4 = 0;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+E4]");
			bool flag = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj6 = 0;
			if (!flag)
			{
				goto IL_0052;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj4 = 0;
			object obj5 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v40+E4]");
			bool flag2 = (nint)0 == 0;
			object obj7 = !flag2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj6 = 0;
			if (obj7 != null)
			{
				goto IL_0052;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X22_v1+20]");
		object obj8 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X8_v30+C0]");
		object obj9 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X8_v31+8]");
		object obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D1E924");
		goto IL_0160;
		IL_04c5:
		nint num2 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F2AC");
		object name = "HH:mm:ss.ffZ" + 3384;
		UnityWebRequest unityWebRequest = default(UnityWebRequest);
		string value;
		unityWebRequest.SetRequestHeader((string)name, value);
		return;
		IL_0461:
		throw new NullReferenceException();
		IL_01fd:
		object obj11 = "Drop Menu Toggle" + 136;
		value = (string)obj11;
		goto IL_04c5;
		IL_0052:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X22_v1+20]");
		object obj12 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v35+C0]");
		object obj13 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v36+8]");
		obj10 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D1E924");
		object obj14 = default(object);
		bool flag3 = obj14 == null;
		object obj15 = !flag3;
		if (obj15 != null)
		{
			goto IL_0160;
		}
		goto IL_0461;
		IL_0160:
		ETagStorage instance = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		object obj16 = typeof(System.Formats.Asn1.SetOfValueComparer) + 2536;
		string key = default(string);
		string eTag = instance.GetETag(key);
		object obj17 = obj16;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X8_v8+E4]");
		if ((nint)0 != 0)
		{
			bool flag4 = StringsExtensions.IsNullOrEmpty(eTag);
			bool flag5 = !flag4;
			object obj18 = 0;
			if (!flag5)
			{
				goto IL_01fd;
			}
		}
		else
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
			bool flag6 = StringsExtensions.IsNullOrEmpty(eTag);
			bool flag7 = !flag6;
			object obj19 = !flag7;
			object obj18 = 0;
			if (obj19 != null)
			{
				goto IL_01fd;
			}
		}
		nint num3 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X8_v15 (Il2CppRgctx<Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1>)+30]");
		object obj20 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E33B6]");
		object obj21 = (nint)0 & (nint)1;
		if (obj21 != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj22 = 0;
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v22+E4]");
			bool flag8 = (nint)0 == 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj24 = 0;
			if (!flag8)
			{
				goto IL_02fc;
			}
		}
		else
		{
			_ = 1;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj22 = 0;
			object obj23 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X0_v22+E4]");
			bool flag9 = (nint)0 == 0;
			object obj25 = !flag9;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Kammelna.Server.WebRequests.Cache.CachedRequestDecorator`1<TResponse>)+18]");
			object obj24 = 0;
			if (obj25 != null)
			{
				goto IL_02fc;
			}
		}
		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X22_v6+20]");
		object obj26 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v19+C0]");
		object obj27 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v20+8]");
		object obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D1E924");
		goto IL_040a;
		IL_040a:
		ETagStorage instance2 = ETagStorage.GetInstance();
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @437D538");
		string key2 = default(string);
		string eTag2 = instance2.GetETag(key2);
		value = eTag2;
		goto IL_04c5;
		IL_02fc:
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X22_v6+20]");
		object obj29 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X8_v24+C0]");
		object obj30 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v134 @ X8_v25+8]");
		obj28 = 0;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D1E924");
		object obj31 = default(object);
		bool flag10 = obj31 == null;
		object obj32 = !flag10;
		if (obj32 != null)
		{
			goto IL_040a;
		}
		goto IL_0461;
	}

	private IEnumerator <>n__0()
	{
		if (this != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F59C");
			IEnumerator result = default(IEnumerator);
			return result;
		}
		return (IEnumerator)new NullReferenceException();
	}

	private IEnumerator <>n__1()
	{
		if (this != null)
		{
			nint num = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @424F618");
			IEnumerator result = default(IEnumerator);
			return result;
		}
		return (IEnumerator)new NullReferenceException();
	}
}
