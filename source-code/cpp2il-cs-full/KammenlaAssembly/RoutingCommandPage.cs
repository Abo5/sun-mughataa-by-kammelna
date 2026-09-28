using System;

[Serializable]
public struct RoutingCommandPage
{
	private RoutingCommand routingCommand;

	private int _pageNumber;

	public RoutingCommand RoutingCommand => routingCommand;

	public int PageNumber => _pageNumber;
}
