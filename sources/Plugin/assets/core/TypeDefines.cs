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
}