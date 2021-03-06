using ProtoBuf;
using System.Collections.Generic;
using System;

namespace protocol
{
	[ProtoContract]
	public class EquipInfo
	{
        /// <summary>
        ///  装备id
        /// </summary>
		[ProtoMember(1, IsRequired = false)]
		public int equipId;
        /// <summary>
        ///  等级
        /// </summary>
		[ProtoMember(2, IsRequired = false)]
		public int level;
        /// <summary>
        ///  阶
        /// </summary>
		[ProtoMember(3, IsRequired = false)]
		public int grade;

	}
}