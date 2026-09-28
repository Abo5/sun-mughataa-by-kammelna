namespace Kammelna.Server;

public interface IContentApplier
{
	string WireKey { get; }

	void ApplyChanged();

	void ApplyDelta(string payloadJson);

	void ApplyBlob(string modelJson);
}
