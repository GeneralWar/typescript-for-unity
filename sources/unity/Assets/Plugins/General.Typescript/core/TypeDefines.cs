namespace General.Typescript
{
	public enum JSValueType : byte
	{
		Object = 1,
		Number,
		String,
		Boolean,
		Array,
		Function,
		Constructor,
		Null,
		Undefined,
		Unknown = 255,
	}

	public enum JSNumberType : byte
	{
		SByte = 1,
		Byte,
		Int16,
		UInt16,
		Int32,
		UInt32,
		Int64,
		UInt64,
		Single,
		Double,
	};
}