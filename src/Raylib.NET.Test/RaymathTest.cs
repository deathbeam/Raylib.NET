using Xunit;
using Bindgen.Test;

namespace RaylibNET.Test;

public class RaymathTest
{
    private unsafe void CheckType<T>() where T : unmanaged
    {
        Assert.True(BlittableHelper.IsBlittable<T>());
    }

    [Fact]
    public void CheckTypes()
    {
        CheckType<float3>();
        CheckType<float16>();
    }
}
