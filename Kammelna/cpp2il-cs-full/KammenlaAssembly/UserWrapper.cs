using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using DataTracking;
using ListView;

public struct UserWrapper : IGridViewItemData<int>, IListViewItemData<int>
{
	private readonly string <template>k__BackingField;

	private readonly int <index>k__BackingField;

	private readonly PlayerInfo <User>k__BackingField;

	private readonly TrackingPlacement <TrackingPlacement>k__BackingField;

	public string template => <template>k__BackingField;

	public int columns => 1;

	public int index => <index>k__BackingField;

	public PlayerInfo User => <User>k__BackingField;

	public TrackingPlacement TrackingPlacement => <TrackingPlacement>k__BackingField;

	public unsafe UserWrapper(PlayerInfo user, string templateName, TrackingPlacement placement)
	{
		//IL_002e: Expected O, but got Ref
		<index>k__BackingField = user.<DBID>k__BackingField;
		<template>k__BackingField = templateName;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
		object obj = (object)System.Runtime.CompilerServices.Unsafe.AsPointer(ref System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		obj = user;
		Cpp2ILHelpers.NoteDecompilerIssue("Method not found @AC174C");
	}
}
