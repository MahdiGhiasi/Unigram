// <auto-generated/>
using System;

namespace Telegram.Api.TL
{
	public partial class TLSendMessageUploadRoundAction : TLSendMessageActionBase 
	{
		public Int32 Progress { get; set; }

		public TLSendMessageUploadRoundAction() { }
		public TLSendMessageUploadRoundAction(TLBinaryReader from)
		{
			Read(from);
		}

		public override TLType TypeId { get { return TLType.SendMessageUploadRoundAction; } }

		public override void Read(TLBinaryReader from)
		{
			Progress = from.ReadInt32();
		}

		public override void Write(TLBinaryWriter to)
		{
			to.Write(0x243E1C66);
			to.Write(Progress);
		}
	}
}