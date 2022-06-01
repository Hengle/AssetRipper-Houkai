using AssetRipper.Core.IO.Asset;

namespace AssetRipper.Core.Classes.AnimationClip.Clip
{
	public sealed class AclClip : IAssetReadable
	{
		public byte[] ClipData { get; set; }

		public uint CurveCount { get; set; }
		public void Read(AssetReader reader)
		{
			ClipData = reader.ReadByteArray();
			reader.AlignStream();
			CurveCount = reader.ReadUInt32();
		}
	}
}
