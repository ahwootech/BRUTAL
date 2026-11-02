/*
 * HelloShaderC
 *
 * Compiles a small inline GLSL vertex shader to SPIR-V with shaderc and prints its size.
 */

#:package Ahwoo.Brutal.ShaderC@2026.10.3
#:package Ahwoo.Brutal.Core@2026.10.4
#:package Ahwoo.Brutal.Strings@2026.10.2

using Brutal.ShaderCApi;

Run();

static void Run()
{
    // Disposed in reverse when Run returns: the result, the options, then the compiler.
    using var compiler = ShaderC.CreateCompiler();
    using var options = ShaderC.CreateCompilerOptions();

    using var result = compiler.Compile(
        """
        #version 450

        void main()
        {
            gl_Position = vec4(0.0, 0.0, 0.0, 1.0);
        }
        """u8,
        ShaderKind.VertexShader,
        "hello.vert"u8,
        "main"u8,
        options
    );

    Console.WriteLine($"Compiled GLSL to {result.GetLength().Value} bytes of SPIR-V");
}
