using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using Cpp2ILInjected;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Plugins.Options;
using Kammelna.Server.Models.Clans;
using Newtonsoft.Json.Linq.JsonPath;
using Unity.Properties;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem.UI;
using UnityEngine.InputSystem.XR;
using UnityEngine.Purchasing.Telemetry;
using UnityEngine.UI;

public class UIPicker : MonoBehaviour, IBeginDragHandler, IEventSystemHandler, IEndDragHandler
{
	public delegate void OnSelectDelegate();

	private bool wasDragging;

	public GameObject[] items;

	public bool isInitialized;

	private RectTransform center;

	private float[] distance;

	private bool isDragging;

	private bool justEndedDrag;

	private int offset;

	private int closestItemIndex;

	private ScrollRect _scrollRect;

	private Vector3 previousSnapPoint;

	public GameObject currentSelection;

	private int _currentSelectionIndex;

	private OnSelectDelegate m_OnChange;

	private Action m_OnUserInteraction;

	private Action m_onUIPickerInitialized;

	public bool enableSnap = true;

	private ScrollRect scrollRect
	{
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			//IL_0033: Expected O, but got I
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Expected O, but got Unknown
			//IL_0124: Expected O, but got I4
			//IL_00c6: Expected O, but got I4
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Expected O, but got Unknown
			//IL_019e: Expected O, but got I
			//IL_0179: Expected O, but got I4
			//IL_018a: Expected O, but got I4
			object obj = 152989696;
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75DE]");
			object obj3 = (nint)0 & (nint)1;
			object obj4;
			UnityEngine.Object obj5;
			UnityEngine.Object obj7;
			object obj8;
			if (obj3 != null)
			{
				obj4 = this + 88;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
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
				obj4 = this + 88;
				obj5 = (UnityEngine.Object)obj4;
				object obj6 = obj2;
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X0_v7+E4]");
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
			if (obj10 != null)
			{
				goto IL_00dc;
			}
			goto IL_0198;
			IL_00dc:
			return (ScrollRect)obj4;
			IL_0198:
			object obj12 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D3103C");
			ScrollRect result = default(ScrollRect);
			_scrollRect = result;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			return result;
			IL_00a0:
			bool flag5 = obj5 != null;
			bool flag6 = !flag5;
			obj11 = 0;
			obj8 = obj4;
			if (!flag6)
			{
				goto IL_00dc;
			}
			goto IL_0198;
		}
	}

	private RectTransform content
	{
		get
		{
			ScrollRect scrollRect = this.scrollRect;
			if ((object)scrollRect != null)
			{
				return scrollRect.m_Content;
			}
			return (RectTransform)(object)new NullReferenceException();
		}
	}

	private RectTransform scrollRectTransform
	{
		get
		{
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Expected O, but got Unknown
			ScrollRect scrollRect = this.scrollRect;
			if ((object)scrollRect != null)
			{
				RectTransform rectTransform = (RectTransform)scrollRect.transform;
				if ((object)rectTransform != null)
				{
					object obj = typeof(System.Buffers.Text.ParserHelpers) + 3600;
					if (rectTransform != obj)
					{
						goto IL_0075;
					}
				}
				return rectTransform;
			}
			NullReferenceException ex = new NullReferenceException();
			goto IL_0075;
			IL_0075:
			return (RectTransform)(object)new InvalidCastException();
		}
	}

	public int currentSelectionIndex
	{
		get
		{
			return _currentSelectionIndex;
		}
		private set
		{
			_currentSelectionIndex = value;
			OnSelectDelegate onChange = this.OnChange;
			if (this.OnChange != null)
			{
				IntPtr invoke_impl = ((Delegate)onChange).invoke_impl;
				IntPtr method_code = ((Delegate)onChange).method_code;
				IntPtr method = ((Delegate)onChange).method;
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v4 @ X2_v1 (System.IntPtr) (should have been resolved before IL gen)");
			}
		}
	}

	public event OnSelectDelegate OnChange
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 968;
			object obj2 = this + 128;
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
			object obj = typeof(TrackedDeviceRaycaster.<>c) + 968;
			object obj2 = this + 128;
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

	public event Action OnUserInteraction
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 136;
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
			object obj2 = this + 136;
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

	public event Action onUIPickerInitialized
	{
		add
		{
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Expected O, but got Unknown
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Expected O, but got Unknown
			object obj = typeof(SqlSingle[]) + 2376;
			object obj2 = this + 144;
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
			object obj2 = this + 144;
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

	public void setItemsList(IEnumerable<GameObject> gOL)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Expected O, but got Unknown
		object[] array = Enumerable.ToArray((IEnumerable<object>)gOL);
		object obj = this + 40;
		obj = array;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		Start();
	}

	private void Start()
	{
		//IL_0dd8: Expected O, but got I
		//IL_0022: Expected O, but got I4
		//IL_002a: Expected O, but got I
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0077: Expected O, but got Unknown
		//IL_0087: Expected O, but got I
		//IL_00e7: Expected O, but got I
		//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_0dfe: Expected O, but got I4
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01eb: Expected O, but got Unknown
		//IL_0203: Expected O, but got I
		//IL_0223: Expected O, but got I
		//IL_0239: Expected O, but got I4
		//IL_0e35: Expected O, but got I4
		//IL_0256: Expected O, but got I
		//IL_0276: Expected O, but got I
		//IL_0286: Expected O, but got I
		//IL_0294: Expected O, but got I4
		//IL_02b8: Expected O, but got I4
		//IL_02e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e8: Expected O, but got Unknown
		//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fd: Expected O, but got Unknown
		//IL_0336: Expected O, but got I4
		//IL_0419: Expected O, but got I4
		//IL_039c: Expected O, but got I4
		//IL_0756: Expected O, but got I4
		//IL_03d8: Expected O, but got I4
		//IL_047f: Expected O, but got I4
		//IL_0d6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d71: Expected O, but got Unknown
		//IL_0d9f: Expected O, but got I
		//IL_0ead: Expected O, but got I4
		//IL_07c4: Expected O, but got I4
		//IL_0ac2: Expected O, but got I4
		//IL_04dc: Expected O, but got I4
		//IL_0ae8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aed: Expected O, but got Unknown
		//IL_050e: Expected O, but got I4
		//IL_0829: Expected O, but got I4
		//IL_0b48: Expected O, but got I4
		//IL_0541: Expected O, but got I8
		//IL_0559: Expected O, but got I4
		//IL_0c2e: Expected O, but got I4
		//IL_0863: Expected O, but got I4
		//IL_059a: Expected O, but got I4
		//IL_0c56: Expected O, but got I4
		//IL_0896: Expected O, but got I8
		//IL_08ae: Expected O, but got I4
		//IL_05e8: Expected O, but got I4
		//IL_0c86: Expected O, but got I4
		//IL_08ef: Expected O, but got I4
		//IL_0635: Expected O, but got I4
		//IL_0cc3: Expected O, but got I4
		//IL_093d: Expected O, but got I4
		//IL_066b: Expected O, but got I4
		//IL_0d28: Expected O, but got I4
		//IL_098a: Expected O, but got I4
		//IL_06a9: Expected O, but got I4
		//IL_09c0: Expected O, but got I4
		//IL_06f4: Expected O, but got I4
		//IL_09fe: Expected O, but got I4
		//IL_072a: Expected O, but got I4
		//IL_0a49: Expected O, but got I4
		//IL_0e64: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e69: Expected O, but got Unknown
		//IL_0a96: Expected I4, but got I8
		GameObject[] array = items;
		bool flag = items == null;
		IntPtr intPtr = default(IntPtr);
		string text = (string)(nint)intPtr;
		int num;
		Vector3 vector;
		bool flag4;
		object obj8;
		if (!flag)
		{
			bool flag2 = _currentSelectionIndex < array.Length;
			object obj = !flag2;
			text = (string)(nint)intPtr;
			if (obj != null)
			{
				goto IL_0d52;
			}
			object obj2 = typeof(System.ComponentModel.ExtendedPropertyDescriptor) + 2096;
			object obj3 = "because MSAA is on. Turn MSAA off on the camera or current URP Asset." + 2600;
			object obj4 = items + _currentSelectionIndex;
			object obj5 = this + 112;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v7+20]");
			obj5 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			text = (string)obj3;
			GameObject gameObject = default(GameObject);
			gameObject..ctor((string)obj3);
			bool flag3 = (object)gameObject == null;
			flag4 = false;
			if (!flag3)
			{
				object obj6 = (nint)0 + (nint)840;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32E24");
				object obj7 = this + 56;
				string text2 = default(string);
				obj7 = text2;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
				bool flag5 = obj7 == null;
				flag4 = false;
				text = text2;
				if (!flag5)
				{
					Transform transform = ((UnityEngine.Component)obj7).transform;
					ScrollRect scrollRect = this.scrollRect;
					bool flag6 = (object)scrollRect == null;
					flag4 = false;
					text = null;
					if (!flag6)
					{
						Transform transform2 = scrollRect.transform;
						bool flag7 = (object)transform == null;
						flag4 = false;
						text = null;
						if (!flag7)
						{
							transform.SetParent(transform2, worldPositionStays: false);
							bool flag8 = obj7 == null;
							obj8 = 0;
							flag4 = false;
							text = (string)(object)transform2;
							if (!flag8)
							{
								object obj9 = typeof(UsageHint) + 816;
								object obj10 = obj9;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v12+B8]");
								object obj11 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v13+4]");
								num = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v13+8]");
								object obj12 = 0;
								vector = (Vector3)obj11;
								((Transform)obj7).localPosition = (Vector3)0;
								bool flag9 = obj7 == null;
								obj8 = 0;
								flag4 = false;
								text = null;
								if (!flag9)
								{
									object obj13 = obj9;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v472 @ X8_v16+B8]");
									object obj14 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v17+10]");
									num = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v17+14]");
									obj12 = 0;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v17+C]");
									vector = (Vector3)0;
									((Transform)obj7).localScale = (Vector3)0;
									GameObject[] array2 = items;
									bool flag10 = items == null;
									obj8 = 0;
									flag4 = false;
									text = null;
									if (!flag10)
									{
										object obj15 = typeof(TypeConverter<ushort, char>) + 3912;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC18B4");
										object obj16 = this + 64;
										string text3 = default(string);
										obj16 = text3;
										Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
										ScrollRect scrollRect2 = this.scrollRect;
										bool flag11 = (object)scrollRect2 == null;
										obj8 = 0;
										flag4 = false;
										text = text3;
										if (!flag11)
										{
											if (scrollRect2.m_Vertical)
											{
												ScrollRect scrollRect3 = this.scrollRect;
												bool flag12 = (object)scrollRect3 == null;
												obj8 = 0;
												flag4 = false;
												text = text3;
												if (flag12)
												{
													goto IL_0d44;
												}
												bool flag13 = scrollRect3.m_Horizontal;
												obj8 = 0;
												flag4 = false;
												text = text3;
												if (flag13)
												{
													object obj17 = typeof(MemberAchievementClanFeedData) + 2632;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
													NotImplementedException ex = default(NotImplementedException);
													ex..ctor();
													object obj18 = (nint)0 + (nint)760;
													Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC17CC");
													throw new OutOfMemoryException();
												}
											}
											ScrollRect scrollRect4 = this.scrollRect;
											bool flag14 = (object)scrollRect4 == null;
											obj8 = 0;
											flag4 = false;
											text = text3;
											if (!flag14)
											{
												if (scrollRect4.m_Vertical)
												{
													ScrollRect scrollRect5 = this.scrollRect;
													bool flag15 = (object)scrollRect5 == null;
													obj8 = 0;
													flag4 = false;
													text = text3;
													if (flag15)
													{
														goto IL_0d44;
													}
													if (array2.Length >= 2)
													{
														bool flag16 = !scrollRect5.m_Horizontal;
														object obj19 = !flag16;
														if (obj19 == null)
														{
															GameObject[] array3 = items;
															bool flag17 = items == null;
															obj8 = 0;
															flag4 = false;
															text = text3;
															if (!flag17)
															{
																object obj20 = array3.Length & 0xFFFFFFFEL;
																bool flag18 = obj20 == null;
																obj8 = 0;
																flag4 = false;
																text = text3;
																if (flag18)
																{
																	goto IL_0d52;
																}
																bool flag19 = (object)array3[1] == null;
																obj8 = 0;
																flag4 = false;
																text = text3;
																if (!flag19)
																{
																	Transform transform3 = array3[1].transform;
																	bool flag20 = (object)transform3 == null;
																	obj8 = 0;
																	flag4 = false;
																	text = null;
																	if (!flag20)
																	{
																		Vector3 localPosition = transform3.localPosition;
																		GameObject[] array4 = items;
																		bool flag21 = items == null;
																		obj8 = 0;
																		flag4 = false;
																		text = null;
																		if (!flag21)
																		{
																			bool flag22 = array4.Length == 0;
																			obj8 = 0;
																			flag4 = false;
																			text = null;
																			if (flag22)
																			{
																				goto IL_0d52;
																			}
																			bool flag23 = (object)array4[0] == null;
																			obj8 = 0;
																			flag4 = false;
																			text = null;
																			if (!flag23)
																			{
																				Transform transform4 = array4[0].transform;
																				bool flag24 = (object)transform4 == null;
																				obj8 = 0;
																				flag4 = false;
																				text = null;
																				if (!flag24)
																				{
																					Vector3 localPosition2 = transform4.localPosition;
																					vector = (Vector3)(num - num);
																					text = null;
																					goto IL_0e51;
																				}
																			}
																		}
																	}
																}
															}
															goto IL_0d44;
														}
													}
												}
												ScrollRect scrollRect6 = this.scrollRect;
												bool flag25 = (object)scrollRect6 == null;
												obj8 = 0;
												flag4 = false;
												text = text3;
												if (!flag25)
												{
													bool flag26 = !scrollRect6.m_Horizontal;
													text = text3;
													if (!flag26)
													{
														ScrollRect scrollRect7 = this.scrollRect;
														bool flag27 = (object)scrollRect7 == null;
														obj8 = 0;
														flag4 = false;
														text = text3;
														if (flag27)
														{
															goto IL_0d44;
														}
														bool flag28 = array2.Length < 2;
														text = text3;
														if (!flag28)
														{
															bool flag29 = !scrollRect7.m_Vertical;
															object obj21 = !flag29;
															text = text3;
															if (obj21 == null)
															{
																GameObject[] array5 = items;
																bool flag30 = items == null;
																obj8 = 0;
																flag4 = false;
																text = text3;
																if (!flag30)
																{
																	object obj22 = array5.Length & 0xFFFFFFFEL;
																	bool flag31 = obj22 == null;
																	obj8 = 0;
																	flag4 = false;
																	text = text3;
																	if (flag31)
																	{
																		goto IL_0d52;
																	}
																	bool flag32 = (object)array5[1] == null;
																	obj8 = 0;
																	flag4 = false;
																	text = text3;
																	if (!flag32)
																	{
																		Transform transform5 = array5[1].transform;
																		bool flag33 = (object)transform5 == null;
																		obj8 = 0;
																		flag4 = false;
																		text = null;
																		if (!flag33)
																		{
																			Vector3 localPosition3 = transform5.localPosition;
																			GameObject[] array6 = items;
																			bool flag34 = items == null;
																			obj8 = 0;
																			flag4 = false;
																			text = null;
																			if (!flag34)
																			{
																				bool flag35 = array6.Length == 0;
																				obj8 = 0;
																				flag4 = false;
																				text = null;
																				if (flag35)
																				{
																					goto IL_0d52;
																				}
																				bool flag36 = (object)array6[0] == null;
																				obj8 = 0;
																				flag4 = false;
																				text = null;
																				if (!flag36)
																				{
																					Transform transform6 = array6[0].transform;
																					bool flag37 = (object)transform6 == null;
																					obj8 = 0;
																					flag4 = false;
																					text = null;
																					if (!flag37)
																					{
																						Vector3 localPosition4 = transform6.localPosition;
																						vector -= vector;
																						text = null;
																						goto IL_0e51;
																					}
																				}
																			}
																		}
																	}
																}
																goto IL_0d44;
															}
														}
													}
													goto IL_0e89;
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
		goto IL_0d44;
		IL_0b6e:
		isInitialized = true;
		Action action = this.onUIPickerInitialized;
		if (this.onUIPickerInitialized != null)
		{
			goto IL_0ba2;
		}
		goto IL_0ed3;
		IL_0d44:
		NullReferenceException ex2 = new NullReferenceException();
		goto IL_0d52;
		IL_0d52:
		throw new IndexOutOfRangeException();
		IL_0ba2:
		Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v559.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		goto IL_0ed3;
		IL_0e89:
		GameObject[] array7 = items;
		bool flag38 = items == null;
		obj8 = 0;
		flag4 = false;
		if (!flag38)
		{
			bool flag39 = array7.Length == 0;
			obj8 = 0;
			flag4 = false;
			if (flag39)
			{
				goto IL_0d52;
			}
			object obj23 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj24 = obj23;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X0_v46+E4]");
			if ((nint)0 != 0)
			{
				bool flag40 = array7[0] != null;
				bool flag41 = !flag40;
				object obj25 = !flag41;
				bool flag42 = false;
				flag4 = false;
				text = null;
				if (obj25 == null)
				{
					goto IL_0b6e;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				bool flag43 = array7[0] != null;
				bool flag44 = !flag43;
				bool flag42 = false;
				flag4 = false;
				text = null;
				if (flag44)
				{
					goto IL_0b6e;
				}
			}
			GameObject[] array8 = items;
			bool flag45 = items == null;
			obj8 = 0;
			if (!flag45)
			{
				bool flag46 = array8.Length == 0;
				obj8 = 0;
				if (flag46)
				{
					goto IL_0d52;
				}
				bool flag47 = (object)array8[0] == null;
				obj8 = 0;
				if (!flag47)
				{
					Transform transform7 = array8[0].transform;
					bool flag48 = (object)transform7 == null;
					obj8 = 0;
					text = null;
					if (!flag48)
					{
						Vector3 localPosition5 = transform7.localPosition;
						previousSnapPoint = vector;
						isInitialized = true;
						action = this.onUIPickerInitialized;
						bool flag49 = this.onUIPickerInitialized == null;
						object obj26 = !flag49;
						bool flag42 = flag4;
						if (obj26 != null)
						{
							goto IL_0ba2;
						}
						goto IL_0ed3;
					}
				}
			}
		}
		goto IL_0d44;
		IL_0ed3:
		DontSnapOnScroll();
		return;
		IL_0e51:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj27 = vector & 0x7FFFFFFF;
		int num2 = (int)(((nint)obj27 != 2139095040) ? num : 2147483648L);
		offset = num2;
		goto IL_0e89;
	}

	private void DontSnapOnScroll()
	{
		//IL_0010: Expected O, but got I
		//IL_001c: Expected O, but got I
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Expected O, but got Unknown
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_007e: Expected O, but got I
		//IL_008c: Expected I, but got O
		//IL_00ba: Expected O, but got I4
		//IL_00c3: Expected O, but got I4
		//IL_02a8: Expected O, but got I4
		//IL_02cc: Expected O, but got I4
		//IL_02d5: Expected O, but got I4
		//IL_0193: Unknown result type (might be due to invalid IL or missing references)
		//IL_0198: Expected O, but got Unknown
		//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01c2: Expected O, but got I
		//IL_01d0: Expected I, but got O
		//IL_01fe: Expected O, but got I4
		//IL_0207: Expected O, but got I4
		//IL_0317: Expected O, but got I4
		//IL_0283: Expected O, but got I4
		//IL_028c: Expected O, but got I4
		//IL_0149: Expected O, but got I4
		//IL_015a: Expected O, but got I4
		//IL_016b: Expected O, but got I4
		//IL_0174: Expected O, but got I4
		//IL_025b: Expected O, but got I4
		//IL_0264: Expected O, but got I4
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75E6]");
		Delegate obj = (Delegate)0;
		object obj2 = (nint)0 + (nint)1104;
		object obj3 = obj2;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj4 = default(object);
		if (obj4 == null)
		{
			return;
		}
		object obj5 = default(object);
		bool flag = obj5 == null;
		object obj6 = obj5;
		object obj14;
		object obj15;
		if (!flag)
		{
			obj6 = obj5 + 32;
			object obj7 = typeof(System.Diagnostics.DiagnosticSourceEventSource.TransformSpec.PropertySpec.PropertyFetch.EnumeratePropertyFetch<>) + 3016;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
			obj = (Delegate)((nint)0 + (nint)712);
			Action<object> action = default(Action<object>);
			action..ctor((object)this, (IntPtr)obj);
			Delegate obj8 = Delegate.Combine((Delegate)obj6, action);
			bool flag2 = (object)obj8 == null;
			object obj9 = 0;
			object obj10 = 0;
			object obj13;
			if (!flag2)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
				object obj11 = default(object);
				if (obj11 != null)
				{
					obj6 = obj11;
					Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1958");
					object obj12 = default(object);
					if (obj12 != null)
					{
						Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
						bool flag3 = obj5 == null;
						obj9 = 0;
						obj13 = obj12;
						obj10 = 0;
						obj14 = obj5;
						obj15 = 0;
						obj3 = 0;
						obj6 = obj5;
						if (!flag3)
						{
							goto IL_018a;
						}
						goto IL_0303;
					}
				}
				throw new InvalidCastException();
			}
			obj6 = 0;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
			bool flag4 = obj5 == null;
			object obj16 = !flag4;
			obj13 = 0;
			obj14 = obj5;
			obj15 = obj9;
			obj3 = obj10;
			obj6 = obj5;
			if (obj16 != null)
			{
				goto IL_018a;
			}
		}
		goto IL_0303;
		IL_0303:
		throw new NullReferenceException();
		IL_018a:
		obj6 = obj14 + 48;
		object obj17 = typeof(SqlSingle[]) + 2376;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		object obj18 = (nint)0 + (nint)720;
		Action action2 = default(Action);
		action2..ctor(this, (IntPtr)obj18);
		Delegate obj19 = Delegate.Combine((Delegate)obj6, action2);
		bool flag5 = (object)obj19 == null;
		obj15 = 0;
		obj3 = 0;
		obj = obj19;
		if (!flag5)
		{
			if (obj19 == obj17)
			{
				obj6 = obj19;
				bool flag6 = obj19 == obj17;
				obj15 = 0;
				obj3 = 0;
				obj = obj19;
				if (flag6)
				{
					goto IL_0353;
				}
			}
			object obj9 = 0;
			object obj10 = 0;
			obj = obj19;
			throw new InvalidCastException();
		}
		obj6 = 0;
		goto IL_0353;
		IL_0353:
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}

	private void Update()
	{
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b7: Expected O, but got Unknown
		//IL_0140: Expected O, but got I
		//IL_014f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0154: Expected O, but got Unknown
		//IL_016a: Expected O, but got I4
		//IL_02e4: Expected O, but got I4
		//IL_0337: Expected O, but got I
		//IL_03f7: Expected O, but got I4
		//IL_0476: Expected O, but got I4
		//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_0523: Expected O, but got I4
		//IL_0588: Invalid comparison between F8 and I4
		//IL_0597: Invalid comparison between F8 and I4
		//IL_05af: Expected O, but got F8
		//IL_05bc: Expected O, but got F8
		//IL_05f1: Expected O, but got I4
		//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Expected O, but got Unknown
		//IL_0740: Invalid comparison between F8 and I4
		//IL_063d: Expected F8, but got I4
		//IL_066a: Expected O, but got I4
		//IL_06bd: Expected O, but got I
		//IL_01a4: Expected O, but got I
		//IL_01e1: Expected O, but got I4
		ScrollRect scrollRect = this.scrollRect;
		if ((object)scrollRect != null)
		{
			if (!scrollRect.m_Vertical)
			{
				return;
			}
			ScrollRect scrollRect2 = this.scrollRect;
			if ((object)scrollRect2 != null)
			{
				if (scrollRect2.m_Horizontal)
				{
					return;
				}
				ScrollRect scrollRect3 = this.scrollRect;
				if ((object)scrollRect3 != null)
				{
					Transform transform = scrollRect3.transform;
					if ((object)transform != null)
					{
						object obj = typeof(System.Buffers.Text.ParserHelpers) + 3600;
						if (transform != obj)
						{
							goto IL_06e2;
						}
						Vector2 sizeDelta = ((RectTransform)transform).sizeDelta;
						GameObject[] array = items;
						if (items != null)
						{
							object obj2 = default(object);
							double num = (double)obj2 * 3.0;
							double num2 = num * 0.25;
							object obj3 = (nint)0 + (nint)1864;
							object obj4 = typeof(UsageHint) + 816;
							double num3 = 0.25;
							object obj5 = 0;
							object obj12 = default(object);
							Graphic img = default(Graphic);
							do
							{
								if ((nint)obj5 >= array.Length)
								{
									return;
								}
								if ((object)center == null)
								{
									break;
								}
								float[] array2 = distance;
								Transform transform2 = center.transform;
								if ((object)transform2 == null)
								{
									break;
								}
								Vector3 position = transform2.position;
								GameObject[] array3 = items;
								if (items == null)
								{
									break;
								}
								bool flag = (nint)obj5 < array3.Length;
								object obj6 = !flag;
								if (obj6 == null)
								{
									object obj7 = (object)items + obj5;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v18+20]");
									if ((nint)0 == 0)
									{
										break;
									}
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v293 @ X8_v18+20]");
									Transform transform3 = ((GameObject)0).transform;
									if ((object)transform3 == null)
									{
										break;
									}
									Vector3 position2 = transform3.position;
									if ((object)center == null)
									{
										break;
									}
									Transform transform4 = center.transform;
									if ((object)transform4 == null)
									{
										break;
									}
									Vector3 lossyScale = transform4.lossyScale;
									if (distance == null)
									{
										break;
									}
									bool flag2 = (nint)obj5 < array2.Length;
									object obj8 = !flag2;
									if (obj8 == null)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
										num = num3 / num;
										object obj9 = (object)distance + obj5;
										GameObject[] array4 = items;
										if (items == null)
										{
											break;
										}
										bool flag3 = (nint)obj5 < array4.Length;
										object obj10 = !flag3;
										if (obj10 == null)
										{
											object obj11 = (object)items + obj5;
											Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v295 @ X8_v22+20]");
											if ((nint)0 == 0)
											{
												break;
											}
											Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
											if (obj12 == null)
											{
												goto IL_01e6;
											}
											float[] array5 = distance;
											if (distance == null)
											{
												break;
											}
											bool flag4 = (nint)obj5 < array5.Length;
											object obj13 = !flag4;
											if (obj13 == null)
											{
												object obj14 = (object)distance + obj5;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v24+20]");
												double num4 = 0.0 / num2;
												double num5 = 1.0 - num4;
												double num6 = num5 - 1.0;
												bool flag5 = num6 < 0.0;
												bool flag6 = num6 == 0.0;
												object obj15 = num5 ^ 1.0;
												object obj16 = num5 ^ num6;
												object obj17 = obj15 & obj16;
												bool flag7 = (nint)obj17 < 0;
												bool flag8 = flag5 == flag7;
												object obj18 = !flag6;
												object obj19 = flag8 & obj18;
												object obj20 = ~obj19;
												double num7 = ((obj20 != null) ? num5 : 1.0);
												double num8 = ((!(num5 < 0.0)) ? num7 : 0.0);
												UIExtensions.SetAlpha(img, (float)num8);
												GameObject[] array6 = items;
												if (items == null)
												{
													break;
												}
												bool flag9 = (nint)obj5 < array6.Length;
												object obj21 = !flag9;
												if (obj21 == null)
												{
													object obj22 = (object)items + obj5;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v26+20]");
													if ((nint)0 == 0)
													{
														break;
													}
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v26+20]");
													Transform transform5 = ((GameObject)0).transform;
													if ((object)transform5 == null)
													{
														break;
													}
													object obj23 = obj4;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v28+B8]");
													object obj24 = 0;
													double num9 = num8;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v29+10]");
													num3 = num9 * 0.0;
													double num10 = num8;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v521 @ X8_v29+C]");
													num = num10 * 0.0;
													transform5.localScale = (Vector3)0;
													goto IL_01e6;
												}
											}
										}
									}
								}
								goto IL_06d4;
								IL_01e6:
								obj5++;
								array = items;
							}
							while (items != null);
						}
					}
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_06d4;
		IL_06e2:
		throw new InvalidCastException();
		IL_06d4:
		IndexOutOfRangeException ex2 = new IndexOutOfRangeException();
		goto IL_06e2;
	}

	private unsafe void Snap()
	{
		//IL_0024: Expected O, but got I4
		//IL_0042: Invalid comparison between F4 and I4
		//IL_01f6: Expected F4, but got I4
		//IL_0165: Expected O, but got I4
		//IL_0180: Invalid comparison between F4 and I4
		//IL_01ba: Expected O, but got I4
		//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		//IL_0c79: Expected O, but got I
		//IL_02e6: Expected O, but got I4
		//IL_0301: Expected O, but got I4
		//IL_031b: Invalid comparison between F4 and I4
		//IL_1882: Expected F4, but got O
		//IL_188b: Unknown result type (might be due to invalid IL or missing references)
		//IL_1890: Expected O, but got Unknown
		//IL_1898: Invalid comparison between O and F4
		//IL_0dd3: Expected O, but got I4
		//IL_0ded: Invalid comparison between F4 and I4
		//IL_0578: Expected O, but got I4
		//IL_1793: Unknown result type (might be due to invalid IL or missing references)
		//IL_1798: Expected O, but got Unknown
		//IL_17b2: Expected O, but got I4
		//IL_17cb: Invalid comparison between F4 and I4
		//IL_01e3: Expected F4, but got O
		//IL_03b4: Expected O, but got I4
		//IL_03cf: Expected O, but got I4
		//IL_03e9: Invalid comparison between F4 and I4
		//IL_0efb: Expected I, but got O
		//IL_05cc: Expected O, but got I4
		//IL_05ea: Invalid comparison between F4 and I4
		//IL_041a: Unknown result type (might be due to invalid IL or missing references)
		//IL_041f: Expected O, but got Unknown
		//IL_0454: Expected O, but got I4
		//IL_0476: Invalid comparison between F4 and I4
		//IL_0f68: Expected I, but got O
		//IL_06a9: Expected O, but got I4
		//IL_06c7: Invalid comparison between F4 and I4
		//IL_14ab: Expected O, but got I4
		//IL_14c8: Expected O, but got I4
		//IL_14e4: Invalid comparison between F4 and I4
		//IL_14f9: Expected O, but got I4
		//IL_0f98: Expected O, but got I4
		//IL_0fb3: Expected O, but got I4
		//IL_0fcd: Invalid comparison between F4 and I4
		//IL_0ff7: Expected I, but got O
		//IL_022b: Expected O, but got I4
		//IL_0246: Expected O, but got I4
		//IL_0260: Invalid comparison between F4 and I4
		//IL_1513: Unknown result type (might be due to invalid IL or missing references)
		//IL_1518: Expected O, but got Unknown
		//IL_051a: Expected O, but got I4
		//IL_101f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1024: Expected O, but got Unknown
		//IL_105a: Expected I, but got O
		//IL_106c: Expected O, but got I4
		//IL_0291: Unknown result type (might be due to invalid IL or missing references)
		//IL_0296: Expected O, but got Unknown
		//IL_02b8: Expected O, but got I
		//IL_02be: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c3: Expected O, but got Unknown
		//IL_0755: Expected O, but got I4
		//IL_154e: Expected O, but got I
		//IL_1566: Expected I, but got O
		//IL_1093: Expected O, but got I
		//IL_10c5: Expected I, but got O
		//IL_10d7: Expected O, but got I4
		//IL_112a: Expected I, but got O
		//IL_113c: Expected O, but got I4
		//IL_07ae: Expected O, but got I4
		//IL_07b8: Expected O, but got I4
		//IL_07d5: Expected O, but got I4
		//IL_07f1: Invalid comparison between F4 and I4
		//IL_15ba: Expected I, but got O
		//IL_116d: Expected O, but got I4
		//IL_1187: Invalid comparison between F4 and I4
		//IL_11b1: Expected I, but got O
		//IL_0816: Unknown result type (might be due to invalid IL or missing references)
		//IL_081b: Expected O, but got Unknown
		//IL_15d2: Expected O, but got I4
		//IL_15dc: Expected O, but got I4
		//IL_15f9: Expected O, but got I4
		//IL_1615: Invalid comparison between F4 and I4
		//IL_1625: Expected I, but got O
		//IL_11e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e8: Expected O, but got Unknown
		//IL_1227: Expected I, but got O
		//IL_1239: Expected O, but got I4
		//IL_0851: Expected O, but got I
		//IL_0869: Expected I, but got O
		//IL_163f: Unknown result type (might be due to invalid IL or missing references)
		//IL_1644: Expected O, but got Unknown
		//IL_1660: Expected I, but got O
		//IL_1259: Expected O, but got I4
		//IL_1274: Expected O, but got I4
		//IL_128e: Invalid comparison between F4 and I4
		//IL_12b8: Expected I, but got O
		//IL_167f: Expected O, but got I
		//IL_1697: Expected I, but got O
		//IL_12e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e5: Expected O, but got Unknown
		//IL_131b: Expected I, but got O
		//IL_132d: Expected O, but got I4
		//IL_08bd: Expected I, but got O
		//IL_16da: Expected I, but got O
		//IL_08d5: Expected O, but got I4
		//IL_08df: Expected O, but got I4
		//IL_08fc: Expected O, but got I4
		//IL_0918: Invalid comparison between F4 and I4
		//IL_0928: Expected I, but got O
		//IL_13c9: Expected O, but got I4
		//IL_0942: Unknown result type (might be due to invalid IL or missing references)
		//IL_0947: Expected O, but got Unknown
		//IL_0963: Expected I, but got O
		//IL_13e9: Expected O, but got I4
		//IL_1404: Expected O, but got I4
		//IL_141e: Invalid comparison between F4 and I4
		//IL_1432: Expected I4, but got O
		//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd3: Expected O, but got Unknown
		//IL_0d1d: Expected F8, but got I8
		//IL_0d22: Expected I, but got O
		//IL_0982: Expected O, but got I
		//IL_099a: Expected I, but got O
		//IL_09d5: Expected I, but got O
		//IL_09ed: Expected O, but got I4
		//IL_09f7: Expected O, but got I4
		//IL_0a14: Expected O, but got I4
		//IL_0a30: Invalid comparison between F4 and I4
		//IL_0a40: Expected I, but got O
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a5f: Expected O, but got Unknown
		//IL_0a7b: Expected I, but got O
		//IL_0a9a: Expected O, but got I
		//IL_0ab3: Expected I, but got O
		//IL_0af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0afa: Expected O, but got Unknown
		//IL_186c: Expected O, but got I4
		//IL_0bd1: Expected O, but got I4
		//IL_0c0b: Expected O, but got F4
		//IL_0c28: Expected I, but got O
		ScrollRect scrollRect = this.scrollRect;
		bool flag = (object)scrollRect == null;
		Graphic graphic = null;
		int num = 152989696;
		double num17;
		float num18;
		double num16 = default(double);
		double num4 = default(double);
		float num6 = default(float);
		if (!flag)
		{
			bool flag2 = (scrollRect.m_Horizontal ? 1 : 0) < (true ? 1 : 0);
			object obj = !flag2;
			float num2 = (float)(scrollRect.m_Horizontal ? 1 : 0) - 1f;
			bool flag3 = num2 < 0f;
			bool flag4 = !scrollRect.m_Horizontal;
			graphic = null;
			num = 152989696;
			OnSelectDelegate onSelectDelegate2 = default(OnSelectDelegate);
			nint num8 = default(nint);
			if (!flag4)
			{
				scrollRect = this.scrollRect;
				bool flag5 = (object)scrollRect == null;
				graphic = null;
				num = 152989696;
				if (flag5)
				{
					goto IL_0551;
				}
				bool flag6 = !scrollRect.m_Vertical;
				graphic = null;
				num = 152989696;
				if (flag6)
				{
					GameObject[] array = items;
					bool flag7 = items == null;
					graphic = null;
					num = 152989696;
					if (flag7)
					{
						goto IL_0551;
					}
					object obj2 = (nint)0 + (nint)1864;
					graphic = null;
					object obj4 = default(object);
					object obj3 = obj4;
					float[] array3 = default(float[]);
					float[] array2 = array3;
					double num3 = num4;
					float num5 = num6;
					nint num7 = num8;
					float num10 = default(float);
					float num9 = num10;
					OnSelectDelegate onSelectDelegate = onSelectDelegate2;
					int num11 = 0;
					while (true)
					{
						bool flag8 = num11 < array.Length;
						obj = !flag8;
						num2 = (float)num11 - (float)array.Length;
						flag3 = num2 < 0f;
						flag4 = num11 >= array.Length;
						obj4 = obj3;
						array3 = array2;
						num4 = num3;
						num6 = num5;
						num8 = num7;
						num10 = num9;
						num = num11;
						if (flag4)
						{
							break;
						}
						bool flag9 = (object)center == null;
						obj4 = obj3;
						array3 = array2;
						num4 = num3;
						num6 = num5;
						num8 = num7;
						num10 = num9;
						onSelectDelegate2 = onSelectDelegate;
						num = num11;
						if (!flag9)
						{
							array3 = distance;
							Transform transform = center.transform;
							bool flag10 = (object)transform == null;
							obj4 = obj3;
							num4 = num3;
							num6 = num5;
							num8 = unchecked((nint)null);
							num10 = num9;
							onSelectDelegate2 = onSelectDelegate;
							num = num11;
							if (!flag10)
							{
								Vector3 position = transform.position;
								GameObject[] array4 = items;
								bool flag11 = items == null;
								obj4 = obj3;
								num4 = num3;
								num6 = num5;
								num8 = unchecked((nint)null);
								num10 = num9;
								onSelectDelegate2 = onSelectDelegate;
								num = num11;
								if (!flag11)
								{
									float[] array5 = (float[])array4.Length;
									bool flag12 = num11 < array4.Length;
									obj = !flag12;
									num2 = (float)num11 - (float)array4.Length;
									flag3 = num2 < 0f;
									obj4 = obj3;
									num4 = num3;
									num6 = num5;
									num8 = unchecked((nint)null);
									num10 = num9;
									num = num11;
									if (obj != null)
									{
										goto IL_146a;
									}
									object obj5 = items + num11;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v51+20]");
									bool flag13 = (nint)0 == 0;
									obj4 = obj3;
									num4 = num3;
									num6 = num5;
									num8 = unchecked((nint)null);
									num10 = num9;
									onSelectDelegate2 = (OnSelectDelegate)array4.Length;
									num = num11;
									if (!flag13)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v507 @ X8_v51+20]");
										Transform transform2 = ((GameObject)0).transform;
										bool flag14 = (object)transform2 == null;
										obj4 = obj3;
										num4 = num3;
										num6 = num5;
										num8 = unchecked((nint)null);
										num10 = num5;
										onSelectDelegate2 = (OnSelectDelegate)array4.Length;
										num = num11;
										if (!flag14)
										{
											Vector3 position2 = transform2.position;
											bool flag15 = distance == null;
											obj4 = obj3;
											num4 = num3;
											num6 = num5;
											num8 = unchecked((nint)null);
											num10 = num5;
											onSelectDelegate2 = (OnSelectDelegate)array4.Length;
											num = num11;
											if (!flag15)
											{
												bool flag16 = num11 < array3.Length;
												obj = !flag16;
												num2 = (float)num11 - (float)array3.Length;
												flag3 = num2 < 0f;
												obj4 = obj3;
												num4 = num3;
												num6 = num5;
												num8 = unchecked((nint)null);
												num10 = num5;
												num = num11;
												if (obj != null)
												{
													goto IL_146a;
												}
												Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABD not yet implemented.\"");
												object obj6 = distance + num11;
												GameObject[] array6 = items;
												bool flag17 = items == null;
												obj4 = obj3;
												num4 = num3;
												num6 = num5;
												num8 = unchecked((nint)null);
												num10 = num5;
												onSelectDelegate2 = (OnSelectDelegate)array4.Length;
												num = num11;
												if (!flag17)
												{
													array5 = (float[])array6.Length;
													bool flag18 = num11 < array6.Length;
													obj = !flag18;
													num2 = (float)num11 - (float)array6.Length;
													flag3 = num2 < 0f;
													obj4 = obj3;
													num4 = num3;
													num6 = num5;
													num8 = unchecked((nint)null);
													num10 = num5;
													num = num11;
													if (obj != null)
													{
														goto IL_146a;
													}
													object obj7 = items + num11;
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v509 @ X8_v55+20]");
													bool flag19 = (nint)0 == 0;
													obj4 = obj3;
													num4 = num3;
													num6 = num5;
													num8 = unchecked((nint)null);
													num10 = num5;
													onSelectDelegate2 = (OnSelectDelegate)array6.Length;
													num = num11;
													if (!flag19)
													{
														obj4 = obj2;
														Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E3438C");
														bool flag20 = (object)scrollRect == null;
														num6 = num5;
														num8 = (nint)(&graphic);
														if (!flag20)
														{
															float[] array7 = distance;
															bool flag21 = distance == null;
															num4 = num3;
															num6 = num5;
															num8 = (nint)(&graphic);
															num10 = num5;
															onSelectDelegate2 = (OnSelectDelegate)array6.Length;
															num = num11;
															if (flag21)
															{
																goto IL_0551;
															}
															array5 = (float[])array7.Length;
															bool flag22 = num11 < array7.Length;
															obj = !flag22;
															num2 = (float)num11 - (float)array7.Length;
															flag3 = num2 < 0f;
															flag4 = (byte)(int)(~obj) != 0;
															num4 = num3;
															num6 = num5;
															num8 = (nint)(&graphic);
															num10 = num5;
															num = num11;
															if (!flag4)
															{
																goto IL_146a;
															}
															object obj8 = distance + num11;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v817 @ X8_v57+20]");
															double num12 = 0.0 / 3281387520.0;
															num6 = (float)num12 + 1f;
															UIExtensions.SetAlpha(graphic, num6);
															num3 = 3281387520.0;
															num8 = unchecked((nint)null);
															scrollRect = (ScrollRect)(object)graphic;
														}
														num = num11 + 1;
														array = items;
														bool flag23 = items == null;
														num4 = num3;
														num10 = num5;
														onSelectDelegate2 = (OnSelectDelegate)(object)array5;
														obj3 = obj4;
														array2 = array3;
														num5 = num6;
														num7 = num8;
														num9 = num6;
														onSelectDelegate = (OnSelectDelegate)(object)array5;
														num11 = num;
														if (!flag23)
														{
															continue;
														}
													}
												}
											}
										}
									}
								}
							}
						}
						goto IL_0551;
					}
				}
			}
			float[] array8 = distance;
			bool flag24 = distance == null;
			onSelectDelegate2 = (OnSelectDelegate)(object)distance;
			if (!flag24)
			{
				float num10;
				if (array8.Length != 0)
				{
					num10 = array8[0];
					bool flag25 = array8.Length < 2;
					obj = !flag25;
					num2 = (float)array8.Length - 2f;
					flag3 = num2 < 0f;
					if (array8.Length >= 2)
					{
						object obj9 = array8.Length & 0x7FFFFFFF;
						object obj10 = obj9 - 1;
						array8 = (float[])(array8 + 36);
						do
						{
							num6 = (float)array8;
							array8 = (float[])(array8 + 4);
							if (array8 < (object)num10)
							{
								num10 = (float)array8;
							}
							obj10--;
							bool flag26 = (nint)obj10 < 1;
							obj = !flag26;
							num2 = (float)obj10 - 1f;
							flag3 = num2 < 0f;
						}
						while ((nint)obj10 != 1);
					}
				}
				else
				{
					num10 = 0f;
				}
				GameObject[] array9 = items;
				bool flag27 = items == null;
				onSelectDelegate2 = (OnSelectDelegate)(object)array8;
				if (!flag27)
				{
					float num13 = num6;
					object obj12 = default(object);
					object obj11 = obj12;
					nint num14 = num8;
					int num15 = 0;
					while (true)
					{
						onSelectDelegate2 = (OnSelectDelegate)array9.Length;
						bool flag28 = num15 < array9.Length;
						obj = !flag28;
						num2 = (float)num15 - (float)array9.Length;
						flag3 = num2 < 0f;
						flag4 = num15 >= array9.Length;
						num6 = num13;
						obj12 = obj11;
						num8 = num14;
						if (flag4)
						{
							break;
						}
						float[] array5 = distance;
						bool flag29 = distance == null;
						num6 = num13;
						obj12 = obj11;
						num8 = num14;
						onSelectDelegate2 = (OnSelectDelegate)(object)distance;
						if (!flag29)
						{
							obj12 = array5.Length;
							bool flag30 = num15 < array5.Length;
							obj = !flag30;
							num2 = (float)num15 - (float)array5.Length;
							flag3 = num2 < 0f;
							num6 = num13;
							num8 = num14;
							if (obj != null)
							{
								goto IL_146a;
							}
							array5 = (float[])(array5 + num15);
							num13 = array5[0];
							bool flag31 = num10 < array5[0];
							obj = !flag31;
							num2 = num10 - array5[0];
							flag3 = num2 < 0f;
							if (num10 == array5[0])
							{
								closestItemIndex = num15;
								_currentSelectionIndex = num15;
								onSelectDelegate2 = this.OnChange;
								if (this.OnChange != null)
								{
									num14 = ((Delegate)onSelectDelegate2).method;
									Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v225.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
									bool flag32 = items == null;
									object obj13 = !flag32;
									array9 = items;
									num6 = array5[0];
									num8 = ((Delegate)onSelectDelegate2).method;
									if (obj13 == null)
									{
										goto IL_0551;
									}
								}
								array5 = (float[])array9.Length;
								bool flag33 = num15 < array9.Length;
								obj = !flag33;
								num2 = (float)num15 - (float)array9.Length;
								flag3 = num2 < 0f;
								num6 = num13;
								num8 = num14;
								if (obj != null)
								{
									goto IL_146a;
								}
								object obj14 = array9 + num15;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X8_v40+20]");
								num14 = 0;
								Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X8_v40+20]");
								currentSelection = (GameObject)0;
								object obj15 = this + 112;
								Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
								array9 = items;
							}
							num15++;
							bool flag34 = array9 == null;
							obj11 = obj12;
							num6 = num13;
							num8 = num14;
							onSelectDelegate2 = (OnSelectDelegate)(object)array5;
							if (!flag34)
							{
								continue;
							}
						}
						goto IL_0551;
					}
					bool flag35 = !isDragging;
					object obj16 = !flag35;
					if (obj16 != null)
					{
						return;
					}
					ScrollRect scrollRect2 = this.scrollRect;
					if ((object)scrollRect2 != null)
					{
						bool flag36 = (scrollRect2.m_Vertical ? 1 : 0) < (true ? 1 : 0);
						obj = !flag36;
						num2 = (float)(scrollRect2.m_Vertical ? 1 : 0) - 1f;
						flag3 = num2 < 0f;
						if (scrollRect2.m_Vertical)
						{
							ScrollRect scrollRect3 = this.scrollRect;
							if ((object)scrollRect3 == null)
							{
								goto IL_0551;
							}
							if (!scrollRect3.m_Horizontal)
							{
								goto IL_1478;
							}
						}
						ScrollRect scrollRect4 = this.scrollRect;
						if ((object)scrollRect4 != null)
						{
							bool flag37 = (scrollRect4.m_Horizontal ? 1 : 0) < (true ? 1 : 0);
							obj = !flag37;
							num2 = (float)(scrollRect4.m_Horizontal ? 1 : 0) - 1f;
							flag3 = num2 < 0f;
							flag4 = !scrollRect4.m_Horizontal;
							num16 = num16;
							num17 = num4;
							num18 = num6;
							if (flag4)
							{
								goto IL_16df;
							}
							ScrollRect scrollRect5 = this.scrollRect;
							if ((object)scrollRect5 != null)
							{
								bool flag38 = !scrollRect5.m_Vertical;
								object obj17 = !flag38;
								num16 = num16;
								num17 = num4;
								num18 = num6;
								if (obj17 != null)
								{
									goto IL_16df;
								}
								GameObject[] array10 = items;
								if (items != null)
								{
									float[] array5 = (float[])closestItemIndex;
									obj12 = array10.Length;
									bool flag39 = closestItemIndex < array10.Length;
									obj = !flag39;
									num2 = (float)closestItemIndex - (float)array10.Length;
									flag3 = num2 < 0f;
									if (obj != null)
									{
										goto IL_146a;
									}
									object obj18 = items + closestItemIndex;
									Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v19+20]");
									if ((nint)0 != 0)
									{
										Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X8_v19+20]");
										GameObject gameObject = ((GameObject)0).gameObject;
										bool flag40 = (object)gameObject == null;
										num8 = unchecked((nint)null);
										if (!flag40)
										{
											if (!gameObject.activeSelf)
											{
												return;
											}
											GameObject[] array11 = items;
											bool flag41 = items == null;
											num8 = unchecked((nint)null);
											if (!flag41)
											{
												array5 = (float[])closestItemIndex;
												obj12 = array11.Length;
												bool flag42 = closestItemIndex < array11.Length;
												obj = !flag42;
												num2 = (float)closestItemIndex - (float)array11.Length;
												flag3 = num2 < 0f;
												num8 = unchecked((nint)null);
												if (obj != null)
												{
													goto IL_146a;
												}
												object obj19 = items + closestItemIndex;
												Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v21+20]");
												bool flag43 = (nint)0 == 0;
												num8 = unchecked((nint)null);
												if (!flag43)
												{
													Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X8_v21+20]");
													Transform transform3 = ((GameObject)0).transform;
													bool flag44 = (object)transform3 == null;
													num8 = unchecked((nint)null);
													if (!flag44)
													{
														Vector3 localPosition = transform3.localPosition;
														GameObject[] array12 = items;
														bool flag45 = items == null;
														num8 = unchecked((nint)null);
														if (!flag45)
														{
															array5 = (float[])closestItemIndex;
															obj12 = array12.Length;
															bool flag46 = closestItemIndex < array12.Length;
															obj = !flag46;
															num2 = (float)closestItemIndex - (float)array12.Length;
															flag3 = num2 < 0f;
															num8 = unchecked((nint)null);
															if (obj != null)
															{
																goto IL_146a;
															}
															object obj20 = items + closestItemIndex;
															Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v23+20]");
															bool flag47 = (nint)0 == 0;
															num8 = unchecked((nint)null);
															if (!flag47)
															{
																Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v502 @ X8_v23+20]");
																Transform transform4 = ((GameObject)0).transform;
																bool flag48 = (object)transform4 == null;
																num8 = unchecked((nint)null);
																if (!flag48)
																{
																	Vector3 localPosition2 = transform4.localPosition;
																	float position3 = 0f - num6;
																	LerpToItem(position3);
																	object obj2 = typeof(Newtonsoft.Json.Linq.JsonPath.JPath) + 4000;
																	object obj21 = obj2;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v836 @ X0_v38+E4]");
																	bool flag49 = (nint)0 == 0;
																	object obj22 = !flag49;
																	if (obj22 == null)
																	{
																		Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
																	}
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UIPicker)+68]");
																	double num19 = 0.0 - num16;
																	Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (UIPicker)+64]");
																	double num20 = 0.0 - num4;
																	float num21 = (float)previousSnapPoint - num6;
																	float num22 = num21 * num21;
																	double num23 = num20 * num20;
																	float num24 = num22 + (float)num23;
																	double num25 = num19 * num19;
																	num18 = (float)num25 + num24;
																	Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FSQRT not yet implemented.\"");
																	num17 = (double)offset / 10.0;
																	bool flag50 = (double)num18 < num17;
																	obj = !flag50;
																	num2 = num18 - (float)num17;
																	if (!((double)num18 < num17))
																	{
																		previousSnapPoint = (Vector3)num6;
																		num16 = 10.0;
																		num8 = unchecked((nint)null);
																		num = 146599936;
																		goto IL_16df;
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
								}
							}
						}
					}
				}
			}
		}
		goto IL_0551;
		IL_0551:
		throw new NullReferenceException();
		IL_1478:
		GameObject[] array13 = items;
		if (items != null)
		{
			object obj12 = array13.Length;
			bool flag51 = closestItemIndex < array13.Length;
			object obj = !flag51;
			float num2 = (float)closestItemIndex - (float)array13.Length;
			bool flag3 = num2 < 0f;
			float[] array5 = (float[])closestItemIndex;
			if (obj != null)
			{
				goto IL_146a;
			}
			object obj23 = items + closestItemIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v8+20]");
			if ((nint)0 != 0)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v512 @ X8_v8+20]");
				GameObject gameObject2 = ((GameObject)0).gameObject;
				bool flag52 = (object)gameObject2 == null;
				nint num8 = unchecked((nint)null);
				if (!flag52)
				{
					if (!gameObject2.activeSelf)
					{
						return;
					}
					GameObject[] array14 = items;
					bool flag53 = items == null;
					num8 = unchecked((nint)null);
					if (!flag53)
					{
						array5 = (float[])closestItemIndex;
						obj12 = array14.Length;
						bool flag54 = closestItemIndex < array14.Length;
						obj = !flag54;
						num2 = (float)closestItemIndex - (float)array14.Length;
						flag3 = num2 < 0f;
						num8 = unchecked((nint)null);
						if (obj != null)
						{
							goto IL_146a;
						}
						object obj24 = items + closestItemIndex;
						Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v10+20]");
						bool flag55 = (nint)0 == 0;
						num8 = unchecked((nint)null);
						if (!flag55)
						{
							Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v514 @ X8_v10+20]");
							Transform transform5 = ((GameObject)0).transform;
							bool flag56 = (object)transform5 == null;
							num8 = unchecked((nint)null);
							if (!flag56)
							{
								Vector3 localPosition3 = transform5.localPosition;
								num18 = (float)(0.0 - num4);
								LerpToItem(num18);
								num16 = num16;
								num17 = num4;
								num8 = unchecked((nint)null);
								goto IL_16df;
							}
						}
					}
				}
			}
		}
		goto IL_0551;
		IL_146a:
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		goto IL_1478;
		IL_16df:
		ScrollRect scrollRect6 = this.scrollRect;
		bool flag57 = (object)scrollRect6 == null;
		num4 = num17;
		num6 = num18;
		if (!flag57)
		{
			scrollRect6.StopMovement();
			return;
		}
		goto IL_0551;
	}

	private void LerpToItem(float position)
	{
		//IL_01d2: Expected O, but got I4
		//IL_0168: Expected O, but got I
		//IL_0184: Expected O, but got I4
		//IL_00e9: Expected O, but got I4
		ScrollRect scrollRect = this.scrollRect;
		Vector2 anchoredPosition = scrollRect.m_Content.anchoredPosition;
		ScrollRect scrollRect2 = this.scrollRect;
		ScrollRect scrollRect4;
		float duration;
		if (scrollRect2.m_Vertical)
		{
			ScrollRect scrollRect3 = this.scrollRect;
			if (!scrollRect3.m_Horizontal)
			{
				scrollRect4 = this.scrollRect;
				duration = position;
				goto IL_0136;
			}
		}
		ScrollRect scrollRect5 = this.scrollRect;
		bool flag = !scrollRect5.m_Horizontal;
		duration = position;
		if (!flag)
		{
			ScrollRect scrollRect6 = this.scrollRect;
			bool flag2 = !scrollRect6.m_Vertical;
			object obj = !flag2;
			object obj2 = ~obj;
			duration = ((obj2 != null) ? position : position);
		}
		scrollRect4 = this.scrollRect;
		bool flag3 = (object)scrollRect4 == null;
		object obj3 = !flag3;
		if (obj3 == null)
		{
			throw new NullReferenceException();
		}
		goto IL_0136;
		IL_0136:
		int num = ShortcutExtensions.DOKill(scrollRect4.m_Content);
		ScrollRect scrollRect7 = this.scrollRect;
		object obj4 = (nint)0 + (nint)2872;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(scrollRect7.m_Content, (Vector2)0, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058EEC");
	}

	public void LerpToItemWithIndex(int index, int? offset = null)
	{
		//IL_073b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_075a: Expected O, but got I4
		//IL_00f9: Expected O, but got I4
		//IL_01ec: Expected O, but got I4
		//IL_05fb: Expected O, but got I4
		//IL_06c3: Expected O, but got I
		//IL_06cc: Expected O, but got I4
		//IL_06d5: Expected F4, but got I4
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d7: Expected O, but got Unknown
		//IL_07ef: Expected I, but got O
		//IL_07fb: Expected O, but got I
		//IL_0648: Expected O, but got I
		//IL_0651: Expected O, but got I4
		//IL_065a: Expected F4, but got I4
		//IL_0463: Expected O, but got I4
		//IL_0783: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_0475: Expected I4, but got I8
		GameObject[] array = items;
		int? num;
		object obj4;
		int num2 = default(int);
		if (items != null)
		{
			if (index > array.Length)
			{
				return;
			}
			_currentSelectionIndex = index;
			OnSelectDelegate onChange = this.OnChange;
			if (this.OnChange != null)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v236.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
			}
			object obj = (??)offset & 1;
			bool flag = obj == null;
			object obj2 = !flag;
			num = offset;
			if (obj2 != null)
			{
				goto IL_0487;
			}
			ScrollRect scrollRect = this.scrollRect;
			if ((object)scrollRect != null)
			{
				if (!scrollRect.m_Vertical)
				{
					goto IL_0152;
				}
				ScrollRect scrollRect2 = this.scrollRect;
				if ((object)scrollRect2 != null)
				{
					bool flag2 = !scrollRect2.m_Horizontal;
					object obj3 = !flag2;
					if (obj3 != null)
					{
						goto IL_0152;
					}
					GameObject[] array2 = items;
					if (items != null)
					{
						if (array2.Length < 2)
						{
							goto IL_0152;
						}
						if ((object)array2[1] != null)
						{
							Transform transform = array2[1].transform;
							if ((object)transform != null)
							{
								Vector3 localPosition = transform.localPosition;
								GameObject[] array3 = items;
								if (items != null && (object)array3[0] != null)
								{
									Transform transform2 = array3[0].transform;
									if ((object)transform2 != null)
									{
										Vector3 localPosition2 = transform2.localPosition;
										obj4 = num2 - num2;
										goto IL_0770;
									}
								}
							}
						}
					}
				}
			}
		}
		goto IL_06f4;
		IL_0770:
		Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FABS not yet implemented.\"");
		object obj5 = obj4 & 0x7FFFFFFF;
		int value = (int)(((nint)obj5 != 2139095040) ? num2 : 2147483648L);
		int? num3 = value;
		num = num3;
		goto IL_0487;
		IL_07c3:
		object obj6 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		object obj7;
		tweenCallback..ctor(this, (IntPtr)obj7);
		object obj8 = (nint)0 + (nint)2504;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
		return;
		IL_0569:
		ScrollRect scrollRect3 = this.scrollRect;
		float num4;
		if ((object)scrollRect3 != null)
		{
			if (!scrollRect3.m_Horizontal)
			{
				return;
			}
			ScrollRect scrollRect4 = this.scrollRect;
			if ((object)scrollRect4 != null)
			{
				bool flag3 = !scrollRect4.m_Vertical;
				object obj9 = !flag3;
				if (obj9 == null)
				{
					RectTransform target = content;
					float endValue = 0f - num4;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore = ShortcutExtensions.DOLocalMoveX(target, endValue, 0.3f, snapping: true);
					obj7 = (nint)0 + (nint)736;
					object obj10 = 0;
					float num5 = 1.0502537E+09f;
					bool flag4 = true;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = tweenerCore;
					goto IL_07c3;
				}
				return;
			}
		}
		goto IL_06f4;
		IL_06f4:
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
		IL_0152:
		ScrollRect scrollRect5 = this.scrollRect;
		if ((object)scrollRect5 != null)
		{
			bool flag5 = !scrollRect5.m_Horizontal;
			num = offset;
			if (flag5)
			{
				goto IL_0487;
			}
			ScrollRect scrollRect6 = this.scrollRect;
			if ((object)scrollRect6 != null)
			{
				bool flag6 = !scrollRect6.m_Vertical;
				object obj11 = !flag6;
				num = offset;
				if (obj11 != null)
				{
					goto IL_0487;
				}
				GameObject[] array4 = items;
				if (items != null)
				{
					bool flag7 = array4.Length < 2;
					num = offset;
					if (flag7)
					{
						goto IL_0487;
					}
					if ((object)array4[1] != null)
					{
						Transform transform3 = array4[1].transform;
						if ((object)transform3 != null)
						{
							Vector3 localPosition3 = transform3.localPosition;
							GameObject[] array5 = items;
							if (items != null && (object)array5[0] != null)
							{
								Transform transform4 = array5[0].transform;
								if ((object)transform4 != null)
								{
									Vector3 localPosition4 = transform4.localPosition;
									object obj12 = default(object);
									obj4 = obj12 - obj12;
									goto IL_0770;
								}
							}
						}
					}
				}
			}
		}
		goto IL_06f4;
		IL_0487:
		if ((nint)num != 1)
		{
			return;
		}
		int value2 = num.Value;
		isDragging = true;
		ScrollRect scrollRect7 = this.scrollRect;
		if ((object)scrollRect7 != null)
		{
			num4 = (float)value2 * (float)index;
			if (!scrollRect7.m_Vertical)
			{
				goto IL_0569;
			}
			ScrollRect scrollRect8 = this.scrollRect;
			if ((object)scrollRect8 != null)
			{
				if (scrollRect8.m_Horizontal)
				{
					goto IL_0569;
				}
				ScrollRect scrollRect9 = this.scrollRect;
				if ((object)scrollRect9 != null)
				{
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore3 = ShortcutExtensions.DOLocalMoveY(scrollRect9.m_Content, num4, 0.3f, snapping: true);
					obj7 = (nint)0 + (nint)728;
					object obj10 = 0;
					float num5 = 1.0502537E+09f;
					float endValue = num4;
					bool flag4 = true;
					TweenerCore<Vector3, Vector3, VectorOptions> tweenerCore2 = tweenerCore3;
					goto IL_07c3;
				}
			}
		}
		goto IL_06f4;
	}

	public void MoveToNext()
	{
		//IL_0015: Expected O, but got I4
		//IL_00d4: Expected O, but got I4
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		//IL_0122: Expected O, but got I
		GameObject[] array = items;
		if (items != null)
		{
			object obj = array.Length - 1;
			if (_currentSelectionIndex == (nint)obj)
			{
				return;
			}
			int num = _currentSelectionIndex + 1;
			_currentSelectionIndex = num;
			OnSelectDelegate onChange = this.OnChange;
			bool flag = this.OnChange == null;
			GameObject[] array2 = items;
			if (!flag)
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v87.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				array2 = items;
				if (items == null)
				{
					goto IL_0166;
				}
			}
			bool flag2 = _currentSelectionIndex < array2.Length;
			object obj2 = !flag2;
			if (obj2 != null)
			{
				goto IL_0174;
			}
			object obj3 = array2 + _currentSelectionIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X8_v7+20]");
			if ((nint)0 != 0)
			{
				object obj4 = (nint)0 + (nint)1360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				Transform transform = default(Transform);
				if ((object)transform != null)
				{
					Vector3 localPosition = transform.localPosition;
					float position = default(float);
					SmoothLerpToItem(position);
					return;
				}
			}
		}
		goto IL_0166;
		IL_0174:
		throw new IndexOutOfRangeException();
		IL_0166:
		NullReferenceException ex = new NullReferenceException();
		goto IL_0174;
	}

	public void MoveToPrevious()
	{
		//IL_0074: Expected O, but got I4
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0093: Expected O, but got Unknown
		//IL_00c4: Expected O, but got I
		if (_currentSelectionIndex == 0)
		{
			return;
		}
		int num = _currentSelectionIndex - 1;
		_currentSelectionIndex = num;
		OnSelectDelegate onChange = this.OnChange;
		if (this.OnChange != null)
		{
			Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v41.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		GameObject[] array = items;
		if (items != null)
		{
			bool flag = _currentSelectionIndex < array.Length;
			object obj = !flag;
			if (obj != null)
			{
				goto IL_0117;
			}
			object obj2 = items + _currentSelectionIndex;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X8_v9+20]");
			if ((nint)0 != 0)
			{
				object obj3 = (nint)0 + (nint)1360;
				Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
				Transform transform = default(Transform);
				if ((object)transform != null)
				{
					Vector3 localPosition = transform.localPosition;
					float position = default(float);
					SmoothLerpToItem(position);
					return;
				}
			}
		}
		NullReferenceException ex = new NullReferenceException();
		goto IL_0117;
		IL_0117:
		throw new IndexOutOfRangeException();
	}

	public void MoveToHome()
	{
		//IL_0038: Expected O, but got I
		GameObject[] array = items;
		if (items != null && (object)array[0] != null)
		{
			object obj = (nint)0 + (nint)1360;
			Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2E32EDC");
			Transform transform = default(Transform);
			if ((object)transform != null)
			{
				Vector3 localPosition = transform.localPosition;
				float position = default(float);
				SmoothLerpToItem(position);
				return;
			}
		}
		NullReferenceException ex = new NullReferenceException();
		throw new IndexOutOfRangeException();
	}

	public void MoveToNextCircular()
	{
		//IL_001f: Expected O, but got I4
		GameObject[] array = items;
		object obj = array.Length - 1;
		if (_currentSelectionIndex == (nint)obj)
		{
			MoveToHome();
		}
		else
		{
			MoveToNext();
		}
	}

	public void DisableScrolling()
	{
		//IL_0011: Expected O, but got I
		ScrollRect scrollRect = this.scrollRect;
		object obj = (nint)0 + (nint)1096;
		scrollRect.enabled = false;
		enableSnap = false;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @2D321D8");
		object obj2 = default(object);
		if (obj2 != null)
		{
			Behaviour behaviour = default(Behaviour);
			behaviour.enabled = false;
		}
	}

	public void SmoothLerpToItem(float position)
	{
		//IL_0132: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		//IL_0143: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_016b: Expected O, but got I4
		//IL_01cb: Expected O, but got I4
		//IL_018c: Expected I, but got O
		//IL_00f2: Expected O, but got I4
		ScrollRect scrollRect = this.scrollRect;
		Vector2 anchoredPosition = scrollRect.m_Content.anchoredPosition;
		ScrollRect scrollRect2 = this.scrollRect;
		ScrollRect scrollRect4;
		float duration;
		float num;
		if (scrollRect2.m_Vertical)
		{
			ScrollRect scrollRect3 = this.scrollRect;
			if (!scrollRect3.m_Horizontal)
			{
				isDragging = true;
				scrollRect4 = this.scrollRect;
				bool flag = (object)scrollRect4 == null;
				object obj = !flag;
				num = position;
				duration = position;
				if (obj == null)
				{
					throw new NullReferenceException();
				}
				goto IL_0123;
			}
		}
		ScrollRect scrollRect5 = this.scrollRect;
		bool flag2 = !scrollRect5.m_Horizontal;
		duration = position;
		if (!flag2)
		{
			ScrollRect scrollRect6 = this.scrollRect;
			float num2 = 0f - position;
			bool flag3 = !scrollRect6.m_Vertical;
			object obj2 = !flag3;
			object obj3 = ~obj2;
			duration = ((obj3 != null) ? num2 : position);
		}
		isDragging = true;
		scrollRect4 = this.scrollRect;
		float num3 = default(float);
		num = num3;
		goto IL_0123;
		IL_0123:
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj5 = (nint)0 + (nint)744;
		object obj6 = (nint)0 + (nint)2488;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(scrollRect4.m_Content, (Vector2)1, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public void SmoothLerpToItem(RectTransform item)
	{
		//IL_0165: Unknown result type (might be due to invalid IL or missing references)
		//IL_016a: Expected O, but got Unknown
		//IL_0176: Expected O, but got I
		//IL_0182: Expected O, but got I
		//IL_019e: Expected O, but got I4
		//IL_0143: Unsupported input type for neg.
		//IL_0143: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Expected O, but got Unknown
		//IL_01bf: Expected I, but got O
		//IL_00ef: Expected O, but got I4
		ScrollRect scrollRect = this.scrollRect;
		Vector2 anchoredPosition = scrollRect.m_Content.anchoredPosition;
		ScrollRect scrollRect2 = this.scrollRect;
		object obj2 = default(object);
		float duration;
		float num = default(float);
		object obj;
		if (scrollRect2.m_Vertical)
		{
			ScrollRect scrollRect3 = this.scrollRect;
			if (!scrollRect3.m_Horizontal)
			{
				Vector2 anchoredPosition2 = item.anchoredPosition;
				obj = 0 - obj2;
				duration = num;
				goto IL_01de;
			}
		}
		ScrollRect scrollRect4 = this.scrollRect;
		bool flag = !scrollRect4.m_Horizontal;
		obj = obj2;
		duration = num;
		if (!flag)
		{
			ScrollRect scrollRect5 = this.scrollRect;
			bool flag2 = !scrollRect5.m_Vertical;
			object obj3 = !flag2;
			obj = obj2;
			duration = num;
			if (obj3 == null)
			{
				Vector2 anchoredPosition3 = item.anchoredPosition;
				duration = 0f - num;
				obj = obj2;
			}
		}
		goto IL_01de;
		IL_01de:
		isDragging = true;
		ScrollRect scrollRect6 = this.scrollRect;
		object obj4 = typeof(UnityEngine.Purchasing.Telemetry.TelemetryMetricsInstanceWrapper) + 2344;
		object obj5 = (nint)0 + (nint)752;
		object obj6 = (nint)0 + (nint)2488;
		TweenerCore<Vector2, Vector2, VectorOptions> tweenerCore = DOTweenModuleUI.DOAnchorPos(scrollRect6.m_Content, (Vector2)1, duration);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC1A7C");
		TweenCallback tweenCallback = default(TweenCallback);
		tweenCallback..ctor(this, (IntPtr)obj5);
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @3058630");
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		isDragging = true;
	}

	public void OnEndDrag(PointerEventData eventData)
	{
		//IL_0016: Expected O, but got I
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0198: Expected O, but got I4
		//IL_0236: Unknown result type (might be due to invalid IL or missing references)
		//IL_023b: Expected O, but got Unknown
		Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [91E75F0]");
		object obj = (nint)0 & (nint)1;
		if (obj != null)
		{
			if (!isDragging)
			{
				goto IL_0052;
			}
		}
		else
		{
			_ = 1;
			if (!isDragging)
			{
				goto IL_0052;
			}
		}
		Actions.SafeInvoke(this.OnUserInteraction);
		isDragging = false;
		if (enableSnap)
		{
			goto IL_00e1;
		}
		return;
		IL_00e1:
		GameObject[] array = items;
		if (items == null)
		{
			return;
		}
		if (array.Length != 0)
		{
			object obj2 = typeof(MemberAchievementClanFeedData) + 2976;
			object obj3 = obj2;
			Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X0_v6+E4]");
			if ((nint)0 != 0)
			{
				bool flag = array[0] != null;
				bool flag2 = !flag;
				object obj4 = !flag2;
				if (obj4 == null)
				{
					return;
				}
			}
			else
			{
				Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_is_inst\"");
				if (!(array[0] != null))
				{
					return;
				}
			}
			float[] array2 = distance;
			GameObject[] array3 = items;
			if (array2.Length == array3.Length)
			{
				object methodName = "SetRoomVariables request error" + 1424;
				Invoke((string)methodName, 0.3f);
			}
			return;
		}
		IndexOutOfRangeException ex = new IndexOutOfRangeException();
		throw new NullReferenceException();
		IL_0052:
		isDragging = false;
		if (!enableSnap)
		{
			return;
		}
		goto IL_00e1;
	}

	private void <DontSnapOnScroll>b__34_0(PointerEventData data)
	{
		isDragging = true;
	}

	private void <DontSnapOnScroll>b__34_1()
	{
		isDragging = false;
	}

	private void <LerpToItemWithIndex>b__39_0()
	{
		isDragging = false;
	}

	private void <LerpToItemWithIndex>b__39_1()
	{
		isDragging = false;
	}

	private void <SmoothLerpToItem>b__45_0()
	{
		isDragging = false;
	}

	private void <SmoothLerpToItem>b__46_0()
	{
		isDragging = false;
	}
}
