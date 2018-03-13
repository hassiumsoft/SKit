using ProtoBuf;
using System.Collections.Generic;
using System;

namespace protocol
{
    /// <summary>
    /// 查看资源点详情 协议:-820
    /// </summary>
	[Proto(value=-820,description="查看资源点详情")]
	[ProtoContract]
	public class ResPointResponse
	{
        /// <summary>
        ///  resPointInfo
        /// </summary>
		[ProtoMember(3, IsRequired = false)]
		public ResPointInfo resPointInfo;
        /// <summary>
        ///  是否成功
        /// </summary>
		[ProtoMember(1, IsRequired = false)]
		public bool success;
        /// <summary>
        ///  错误码
        /// </summary>
		[ProtoMember(2, IsRequired = false)]
		public string info;

	}
}