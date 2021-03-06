using ProtoBuf;
using System.Collections.Generic;
using System;

namespace protocol
{
    /// <summary>
    /// 扫荡副本 协议:46
    /// </summary>
	[Proto(value=46,description="扫荡副本")]
	[ProtoContract]
	public class FBWipeRequest
	{
        /// <summary>
        ///  关卡ID（数据库id）
        /// </summary>
		[ProtoMember(1, IsRequired = false)]
		public string id;
        /// <summary>
        ///  扫荡次数
        /// </summary>
		[ProtoMember(2, IsRequired = false)]
		public int count;

	}
}