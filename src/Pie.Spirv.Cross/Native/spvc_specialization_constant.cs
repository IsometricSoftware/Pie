namespace Pie.Spirv.Cross.Native;

public partial struct spvc_specialization_constant
{
    [NativeTypeName("spvc_constant_id")]
    public uint id;

    [NativeTypeName("unsigned int")]
    public uint constant_id;
}
