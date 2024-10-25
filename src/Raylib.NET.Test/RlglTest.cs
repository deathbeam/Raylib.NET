using Xunit;
using Bindgen.Test;

namespace RaylibNET.Test;

public class RlglTest
{
    private unsafe void CheckType<T>() where T : unmanaged
    {
        Assert.True(BlittableHelper.IsBlittable<T>());
    }

    [Fact]
    public void CheckTypes()
    {
        CheckType<GlVersion>();
        CheckType<TraceLogLevel>();
        CheckType<PixelFormat>();
        CheckType<TextureFilter>();
        CheckType<BlendMode>();
        CheckType<ShaderLocationIndex>();
        CheckType<ShaderUniformDataType>();
        CheckType<ShaderAttributeDataType>();
        CheckType<FramebufferAttachType>();
        CheckType<FramebufferAttachTextureType>();
        CheckType<CullMode>();
        CheckType<VertexBuffer>();
        CheckType<DrawCall>();
        CheckType<RenderBatch>();
    }
}
