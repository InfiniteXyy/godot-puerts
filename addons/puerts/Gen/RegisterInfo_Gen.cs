using Puerts.TypeMapping;
using Puerts;

namespace PuertsStaticWrap
{
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class PuerRegisterInfo_Gen
    {
        
        public static RegisterInfo GetRegisterInfo_Godot_GD_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"Convert_static", new MemberRegisterInfo { Name = "Convert", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Convert
#endif
                    }},
                    {"Hash_static", new MemberRegisterInfo { Name = "Hash", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Hash
#endif
                    }},
                    {"Load_static", new MemberRegisterInfo { Name = "Load", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Load
#endif
                    }},
                    {"Print_static", new MemberRegisterInfo { Name = "Print", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Print
#endif
                    }},
                    {"PrintRich_static", new MemberRegisterInfo { Name = "PrintRich", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_PrintRich
#endif
                    }},
                    {"PrintErr_static", new MemberRegisterInfo { Name = "PrintErr", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_PrintErr
#endif
                    }},
                    {"PrintRaw_static", new MemberRegisterInfo { Name = "PrintRaw", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_PrintRaw
#endif
                    }},
                    {"PrintS_static", new MemberRegisterInfo { Name = "PrintS", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_PrintS
#endif
                    }},
                    {"PrintT_static", new MemberRegisterInfo { Name = "PrintT", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_PrintT
#endif
                    }},
                    {"PushError_static", new MemberRegisterInfo { Name = "PushError", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_PushError
#endif
                    }},
                    {"PushWarning_static", new MemberRegisterInfo { Name = "PushWarning", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_PushWarning
#endif
                    }},
                    {"Randf_static", new MemberRegisterInfo { Name = "Randf", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Randf
#endif
                    }},
                    {"Randfn_static", new MemberRegisterInfo { Name = "Randfn", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Randfn
#endif
                    }},
                    {"Randi_static", new MemberRegisterInfo { Name = "Randi", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Randi
#endif
                    }},
                    {"Randomize_static", new MemberRegisterInfo { Name = "Randomize", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Randomize
#endif
                    }},
                    {"RandRange_static", new MemberRegisterInfo { Name = "RandRange", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_RandRange
#endif
                    }},
                    {"RandFromSeed_static", new MemberRegisterInfo { Name = "RandFromSeed", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_RandFromSeed
#endif
                    }},
                    {"Range_static", new MemberRegisterInfo { Name = "Range", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Range
#endif
                    }},
                    {"Seed_static", new MemberRegisterInfo { Name = "Seed", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Seed
#endif
                    }},
                    {"StrToVar_static", new MemberRegisterInfo { Name = "StrToVar", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_StrToVar
#endif
                    }},
                    {"VarToBytes_static", new MemberRegisterInfo { Name = "VarToBytes", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_VarToBytes
#endif
                    }},
                    {"VarToBytesWithObjects_static", new MemberRegisterInfo { Name = "VarToBytesWithObjects", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_VarToBytesWithObjects
#endif
                    }},
                    {"VarToStr_static", new MemberRegisterInfo { Name = "VarToStr", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_VarToStr
#endif
                    }},
                    {"TypeToVariantType_static", new MemberRegisterInfo { Name = "TypeToVariantType", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_TypeToVariantType
#endif
                    }},
                    {"Compress_static", new MemberRegisterInfo { Name = "Compress", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Compress
#endif
                    }},
                    {"Decompress_static", new MemberRegisterInfo { Name = "Decompress", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Decompress
#endif
                    }},
                    {"DecompressDynamic_static", new MemberRegisterInfo { Name = "DecompressDynamic", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_DecompressDynamic
#endif
                    }},
                    {"IsEmpty_static", new MemberRegisterInfo { Name = "IsEmpty", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_IsEmpty
#endif
                    }},
                    {"Join_static", new MemberRegisterInfo { Name = "Join", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Join
#endif
                    }},
                    {"Stringify_static", new MemberRegisterInfo { Name = "Stringify", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_GD_Wrap.F_Stringify
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_StringName_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_StringName_Wrap.Constructor
#endif
                    }},
                    {"Dispose", new MemberRegisterInfo { Name = "Dispose", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_StringName_Wrap.M_Dispose
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_StringName_Wrap.M_ToString
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_StringName_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_StringName_Wrap.O_op_Inequality
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_StringName_Wrap.M_Equals
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_StringName_Wrap.M_GetHashCode
#endif
                    }},
                    {"IsEmpty", new MemberRegisterInfo { Name = "IsEmpty", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_StringName_Wrap.G_IsEmpty
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Viewport_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"SetWorld2D", new MemberRegisterInfo { Name = "SetWorld2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetWorld2D
#endif
                    }},
                    {"GetWorld2D", new MemberRegisterInfo { Name = "GetWorld2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetWorld2D
#endif
                    }},
                    {"FindWorld2D", new MemberRegisterInfo { Name = "FindWorld2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_FindWorld2D
#endif
                    }},
                    {"SetCanvasTransform", new MemberRegisterInfo { Name = "SetCanvasTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetCanvasTransform
#endif
                    }},
                    {"GetCanvasTransform", new MemberRegisterInfo { Name = "GetCanvasTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetCanvasTransform
#endif
                    }},
                    {"SetGlobalCanvasTransform", new MemberRegisterInfo { Name = "SetGlobalCanvasTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetGlobalCanvasTransform
#endif
                    }},
                    {"GetGlobalCanvasTransform", new MemberRegisterInfo { Name = "GetGlobalCanvasTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetGlobalCanvasTransform
#endif
                    }},
                    {"GetStretchTransform", new MemberRegisterInfo { Name = "GetStretchTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetStretchTransform
#endif
                    }},
                    {"GetFinalTransform", new MemberRegisterInfo { Name = "GetFinalTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetFinalTransform
#endif
                    }},
                    {"GetScreenTransform", new MemberRegisterInfo { Name = "GetScreenTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetScreenTransform
#endif
                    }},
                    {"GetVisibleRect", new MemberRegisterInfo { Name = "GetVisibleRect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetVisibleRect
#endif
                    }},
                    {"SetTransparentBackground", new MemberRegisterInfo { Name = "SetTransparentBackground", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetTransparentBackground
#endif
                    }},
                    {"HasTransparentBackground", new MemberRegisterInfo { Name = "HasTransparentBackground", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_HasTransparentBackground
#endif
                    }},
                    {"SetUseHdr2D", new MemberRegisterInfo { Name = "SetUseHdr2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetUseHdr2D
#endif
                    }},
                    {"IsUsingHdr2D", new MemberRegisterInfo { Name = "IsUsingHdr2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsUsingHdr2D
#endif
                    }},
                    {"SetMsaa2D", new MemberRegisterInfo { Name = "SetMsaa2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetMsaa2D
#endif
                    }},
                    {"GetMsaa2D", new MemberRegisterInfo { Name = "GetMsaa2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetMsaa2D
#endif
                    }},
                    {"SetMsaa3D", new MemberRegisterInfo { Name = "SetMsaa3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetMsaa3D
#endif
                    }},
                    {"GetMsaa3D", new MemberRegisterInfo { Name = "GetMsaa3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetMsaa3D
#endif
                    }},
                    {"SetScreenSpaceAA", new MemberRegisterInfo { Name = "SetScreenSpaceAA", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetScreenSpaceAA
#endif
                    }},
                    {"GetScreenSpaceAA", new MemberRegisterInfo { Name = "GetScreenSpaceAA", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetScreenSpaceAA
#endif
                    }},
                    {"SetUseTaa", new MemberRegisterInfo { Name = "SetUseTaa", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetUseTaa
#endif
                    }},
                    {"IsUsingTaa", new MemberRegisterInfo { Name = "IsUsingTaa", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsUsingTaa
#endif
                    }},
                    {"SetUseDebanding", new MemberRegisterInfo { Name = "SetUseDebanding", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetUseDebanding
#endif
                    }},
                    {"IsUsingDebanding", new MemberRegisterInfo { Name = "IsUsingDebanding", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsUsingDebanding
#endif
                    }},
                    {"SetUseOcclusionCulling", new MemberRegisterInfo { Name = "SetUseOcclusionCulling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetUseOcclusionCulling
#endif
                    }},
                    {"IsUsingOcclusionCulling", new MemberRegisterInfo { Name = "IsUsingOcclusionCulling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsUsingOcclusionCulling
#endif
                    }},
                    {"SetDebugDraw", new MemberRegisterInfo { Name = "SetDebugDraw", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetDebugDraw
#endif
                    }},
                    {"GetDebugDraw", new MemberRegisterInfo { Name = "GetDebugDraw", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetDebugDraw
#endif
                    }},
                    {"SetUseOversampling", new MemberRegisterInfo { Name = "SetUseOversampling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetUseOversampling
#endif
                    }},
                    {"IsUsingOversampling", new MemberRegisterInfo { Name = "IsUsingOversampling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsUsingOversampling
#endif
                    }},
                    {"SetOversamplingOverride", new MemberRegisterInfo { Name = "SetOversamplingOverride", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetOversamplingOverride
#endif
                    }},
                    {"GetOversamplingOverride", new MemberRegisterInfo { Name = "GetOversamplingOverride", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetOversamplingOverride
#endif
                    }},
                    {"GetOversampling", new MemberRegisterInfo { Name = "GetOversampling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetOversampling
#endif
                    }},
                    {"GetRenderInfo", new MemberRegisterInfo { Name = "GetRenderInfo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetRenderInfo
#endif
                    }},
                    {"GetTexture", new MemberRegisterInfo { Name = "GetTexture", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetTexture
#endif
                    }},
                    {"SetPhysicsObjectPicking", new MemberRegisterInfo { Name = "SetPhysicsObjectPicking", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetPhysicsObjectPicking
#endif
                    }},
                    {"GetPhysicsObjectPicking", new MemberRegisterInfo { Name = "GetPhysicsObjectPicking", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetPhysicsObjectPicking
#endif
                    }},
                    {"SetPhysicsObjectPickingSort", new MemberRegisterInfo { Name = "SetPhysicsObjectPickingSort", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetPhysicsObjectPickingSort
#endif
                    }},
                    {"GetPhysicsObjectPickingSort", new MemberRegisterInfo { Name = "GetPhysicsObjectPickingSort", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetPhysicsObjectPickingSort
#endif
                    }},
                    {"SetPhysicsObjectPickingFirstOnly", new MemberRegisterInfo { Name = "SetPhysicsObjectPickingFirstOnly", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetPhysicsObjectPickingFirstOnly
#endif
                    }},
                    {"GetPhysicsObjectPickingFirstOnly", new MemberRegisterInfo { Name = "GetPhysicsObjectPickingFirstOnly", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetPhysicsObjectPickingFirstOnly
#endif
                    }},
                    {"GetViewportRid", new MemberRegisterInfo { Name = "GetViewportRid", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetViewportRid
#endif
                    }},
                    {"PushTextInput", new MemberRegisterInfo { Name = "PushTextInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_PushTextInput
#endif
                    }},
                    {"PushInput", new MemberRegisterInfo { Name = "PushInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_PushInput
#endif
                    }},
                    {"NotifyMouseEntered", new MemberRegisterInfo { Name = "NotifyMouseEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_NotifyMouseEntered
#endif
                    }},
                    {"NotifyMouseExited", new MemberRegisterInfo { Name = "NotifyMouseExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_NotifyMouseExited
#endif
                    }},
                    {"GetMousePosition", new MemberRegisterInfo { Name = "GetMousePosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetMousePosition
#endif
                    }},
                    {"WarpMouse", new MemberRegisterInfo { Name = "WarpMouse", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_WarpMouse
#endif
                    }},
                    {"UpdateMouseCursorState", new MemberRegisterInfo { Name = "UpdateMouseCursorState", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_UpdateMouseCursorState
#endif
                    }},
                    {"GuiCancelDrag", new MemberRegisterInfo { Name = "GuiCancelDrag", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GuiCancelDrag
#endif
                    }},
                    {"GuiGetDragData", new MemberRegisterInfo { Name = "GuiGetDragData", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GuiGetDragData
#endif
                    }},
                    {"GuiGetDragDescription", new MemberRegisterInfo { Name = "GuiGetDragDescription", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GuiGetDragDescription
#endif
                    }},
                    {"GuiSetDragDescription", new MemberRegisterInfo { Name = "GuiSetDragDescription", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GuiSetDragDescription
#endif
                    }},
                    {"GuiIsDragging", new MemberRegisterInfo { Name = "GuiIsDragging", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GuiIsDragging
#endif
                    }},
                    {"GuiIsDragSuccessful", new MemberRegisterInfo { Name = "GuiIsDragSuccessful", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GuiIsDragSuccessful
#endif
                    }},
                    {"GuiReleaseFocus", new MemberRegisterInfo { Name = "GuiReleaseFocus", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GuiReleaseFocus
#endif
                    }},
                    {"GuiGetFocusOwner", new MemberRegisterInfo { Name = "GuiGetFocusOwner", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GuiGetFocusOwner
#endif
                    }},
                    {"GuiGetHoveredControl", new MemberRegisterInfo { Name = "GuiGetHoveredControl", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GuiGetHoveredControl
#endif
                    }},
                    {"SetDisableInput", new MemberRegisterInfo { Name = "SetDisableInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetDisableInput
#endif
                    }},
                    {"IsInputDisabled", new MemberRegisterInfo { Name = "IsInputDisabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsInputDisabled
#endif
                    }},
                    {"SetPositionalShadowAtlasSize", new MemberRegisterInfo { Name = "SetPositionalShadowAtlasSize", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetPositionalShadowAtlasSize
#endif
                    }},
                    {"GetPositionalShadowAtlasSize", new MemberRegisterInfo { Name = "GetPositionalShadowAtlasSize", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetPositionalShadowAtlasSize
#endif
                    }},
                    {"SetPositionalShadowAtlas16Bits", new MemberRegisterInfo { Name = "SetPositionalShadowAtlas16Bits", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetPositionalShadowAtlas16Bits
#endif
                    }},
                    {"GetPositionalShadowAtlas16Bits", new MemberRegisterInfo { Name = "GetPositionalShadowAtlas16Bits", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetPositionalShadowAtlas16Bits
#endif
                    }},
                    {"SetSnapControlsToPixels", new MemberRegisterInfo { Name = "SetSnapControlsToPixels", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetSnapControlsToPixels
#endif
                    }},
                    {"IsSnapControlsToPixelsEnabled", new MemberRegisterInfo { Name = "IsSnapControlsToPixelsEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsSnapControlsToPixelsEnabled
#endif
                    }},
                    {"SetSnap2DTransformsToPixel", new MemberRegisterInfo { Name = "SetSnap2DTransformsToPixel", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetSnap2DTransformsToPixel
#endif
                    }},
                    {"IsSnap2DTransformsToPixelEnabled", new MemberRegisterInfo { Name = "IsSnap2DTransformsToPixelEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsSnap2DTransformsToPixelEnabled
#endif
                    }},
                    {"SetSnap2DVerticesToPixel", new MemberRegisterInfo { Name = "SetSnap2DVerticesToPixel", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetSnap2DVerticesToPixel
#endif
                    }},
                    {"IsSnap2DVerticesToPixelEnabled", new MemberRegisterInfo { Name = "IsSnap2DVerticesToPixelEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsSnap2DVerticesToPixelEnabled
#endif
                    }},
                    {"SetPositionalShadowAtlasQuadrantSubdiv", new MemberRegisterInfo { Name = "SetPositionalShadowAtlasQuadrantSubdiv", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetPositionalShadowAtlasQuadrantSubdiv
#endif
                    }},
                    {"GetPositionalShadowAtlasQuadrantSubdiv", new MemberRegisterInfo { Name = "GetPositionalShadowAtlasQuadrantSubdiv", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetPositionalShadowAtlasQuadrantSubdiv
#endif
                    }},
                    {"SetInputAsHandled", new MemberRegisterInfo { Name = "SetInputAsHandled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetInputAsHandled
#endif
                    }},
                    {"IsInputHandled", new MemberRegisterInfo { Name = "IsInputHandled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsInputHandled
#endif
                    }},
                    {"SetHandleInputLocally", new MemberRegisterInfo { Name = "SetHandleInputLocally", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetHandleInputLocally
#endif
                    }},
                    {"IsHandlingInputLocally", new MemberRegisterInfo { Name = "IsHandlingInputLocally", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsHandlingInputLocally
#endif
                    }},
                    {"SetDefaultCanvasItemTextureFilter", new MemberRegisterInfo { Name = "SetDefaultCanvasItemTextureFilter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetDefaultCanvasItemTextureFilter
#endif
                    }},
                    {"GetDefaultCanvasItemTextureFilter", new MemberRegisterInfo { Name = "GetDefaultCanvasItemTextureFilter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetDefaultCanvasItemTextureFilter
#endif
                    }},
                    {"SetEmbeddingSubwindows", new MemberRegisterInfo { Name = "SetEmbeddingSubwindows", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetEmbeddingSubwindows
#endif
                    }},
                    {"IsEmbeddingSubwindows", new MemberRegisterInfo { Name = "IsEmbeddingSubwindows", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsEmbeddingSubwindows
#endif
                    }},
                    {"GetEmbeddedSubwindows", new MemberRegisterInfo { Name = "GetEmbeddedSubwindows", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetEmbeddedSubwindows
#endif
                    }},
                    {"SetCanvasCullMask", new MemberRegisterInfo { Name = "SetCanvasCullMask", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetCanvasCullMask
#endif
                    }},
                    {"GetCanvasCullMask", new MemberRegisterInfo { Name = "GetCanvasCullMask", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetCanvasCullMask
#endif
                    }},
                    {"SetCanvasCullMaskBit", new MemberRegisterInfo { Name = "SetCanvasCullMaskBit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetCanvasCullMaskBit
#endif
                    }},
                    {"GetCanvasCullMaskBit", new MemberRegisterInfo { Name = "GetCanvasCullMaskBit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetCanvasCullMaskBit
#endif
                    }},
                    {"SetDefaultCanvasItemTextureRepeat", new MemberRegisterInfo { Name = "SetDefaultCanvasItemTextureRepeat", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetDefaultCanvasItemTextureRepeat
#endif
                    }},
                    {"GetDefaultCanvasItemTextureRepeat", new MemberRegisterInfo { Name = "GetDefaultCanvasItemTextureRepeat", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetDefaultCanvasItemTextureRepeat
#endif
                    }},
                    {"SetSdfOversize", new MemberRegisterInfo { Name = "SetSdfOversize", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetSdfOversize
#endif
                    }},
                    {"GetSdfOversize", new MemberRegisterInfo { Name = "GetSdfOversize", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetSdfOversize
#endif
                    }},
                    {"SetSdfScale", new MemberRegisterInfo { Name = "SetSdfScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetSdfScale
#endif
                    }},
                    {"GetSdfScale", new MemberRegisterInfo { Name = "GetSdfScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetSdfScale
#endif
                    }},
                    {"SetMeshLodThreshold", new MemberRegisterInfo { Name = "SetMeshLodThreshold", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetMeshLodThreshold
#endif
                    }},
                    {"GetMeshLodThreshold", new MemberRegisterInfo { Name = "GetMeshLodThreshold", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetMeshLodThreshold
#endif
                    }},
                    {"SetAsAudioListener2D", new MemberRegisterInfo { Name = "SetAsAudioListener2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetAsAudioListener2D
#endif
                    }},
                    {"IsAudioListener2D", new MemberRegisterInfo { Name = "IsAudioListener2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsAudioListener2D
#endif
                    }},
                    {"GetAudioListener2D", new MemberRegisterInfo { Name = "GetAudioListener2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetAudioListener2D
#endif
                    }},
                    {"GetCamera2D", new MemberRegisterInfo { Name = "GetCamera2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetCamera2D
#endif
                    }},
                    {"SetWorld3D", new MemberRegisterInfo { Name = "SetWorld3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetWorld3D
#endif
                    }},
                    {"GetWorld3D", new MemberRegisterInfo { Name = "GetWorld3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetWorld3D
#endif
                    }},
                    {"FindWorld3D", new MemberRegisterInfo { Name = "FindWorld3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_FindWorld3D
#endif
                    }},
                    {"SetUseOwnWorld3D", new MemberRegisterInfo { Name = "SetUseOwnWorld3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetUseOwnWorld3D
#endif
                    }},
                    {"IsUsingOwnWorld3D", new MemberRegisterInfo { Name = "IsUsingOwnWorld3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsUsingOwnWorld3D
#endif
                    }},
                    {"GetAudioListener3D", new MemberRegisterInfo { Name = "GetAudioListener3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetAudioListener3D
#endif
                    }},
                    {"GetCamera3D", new MemberRegisterInfo { Name = "GetCamera3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetCamera3D
#endif
                    }},
                    {"SetAsAudioListener3D", new MemberRegisterInfo { Name = "SetAsAudioListener3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetAsAudioListener3D
#endif
                    }},
                    {"IsAudioListener3D", new MemberRegisterInfo { Name = "IsAudioListener3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsAudioListener3D
#endif
                    }},
                    {"SetDisable3D", new MemberRegisterInfo { Name = "SetDisable3D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetDisable3D
#endif
                    }},
                    {"Is3DDisabled", new MemberRegisterInfo { Name = "Is3DDisabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_Is3DDisabled
#endif
                    }},
                    {"SetUseXR", new MemberRegisterInfo { Name = "SetUseXR", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetUseXR
#endif
                    }},
                    {"IsUsingXR", new MemberRegisterInfo { Name = "IsUsingXR", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_IsUsingXR
#endif
                    }},
                    {"SetScaling3DMode", new MemberRegisterInfo { Name = "SetScaling3DMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetScaling3DMode
#endif
                    }},
                    {"GetScaling3DMode", new MemberRegisterInfo { Name = "GetScaling3DMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetScaling3DMode
#endif
                    }},
                    {"SetScaling3DScale", new MemberRegisterInfo { Name = "SetScaling3DScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetScaling3DScale
#endif
                    }},
                    {"GetScaling3DScale", new MemberRegisterInfo { Name = "GetScaling3DScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetScaling3DScale
#endif
                    }},
                    {"SetFsrSharpness", new MemberRegisterInfo { Name = "SetFsrSharpness", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetFsrSharpness
#endif
                    }},
                    {"GetFsrSharpness", new MemberRegisterInfo { Name = "GetFsrSharpness", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetFsrSharpness
#endif
                    }},
                    {"SetTextureMipmapBias", new MemberRegisterInfo { Name = "SetTextureMipmapBias", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetTextureMipmapBias
#endif
                    }},
                    {"GetTextureMipmapBias", new MemberRegisterInfo { Name = "GetTextureMipmapBias", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetTextureMipmapBias
#endif
                    }},
                    {"SetAnisotropicFilteringLevel", new MemberRegisterInfo { Name = "SetAnisotropicFilteringLevel", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetAnisotropicFilteringLevel
#endif
                    }},
                    {"GetAnisotropicFilteringLevel", new MemberRegisterInfo { Name = "GetAnisotropicFilteringLevel", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetAnisotropicFilteringLevel
#endif
                    }},
                    {"SetVrsMode", new MemberRegisterInfo { Name = "SetVrsMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetVrsMode
#endif
                    }},
                    {"GetVrsMode", new MemberRegisterInfo { Name = "GetVrsMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetVrsMode
#endif
                    }},
                    {"SetVrsUpdateMode", new MemberRegisterInfo { Name = "SetVrsUpdateMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetVrsUpdateMode
#endif
                    }},
                    {"GetVrsUpdateMode", new MemberRegisterInfo { Name = "GetVrsUpdateMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetVrsUpdateMode
#endif
                    }},
                    {"SetVrsTexture", new MemberRegisterInfo { Name = "SetVrsTexture", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_SetVrsTexture
#endif
                    }},
                    {"GetVrsTexture", new MemberRegisterInfo { Name = "GetVrsTexture", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.M_GetVrsTexture
#endif
                    }},
                    {"add_SizeChanged", new MemberRegisterInfo { Name = "add_SizeChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.A_SizeChanged
#endif
                    }},
                    {"remove_SizeChanged", new MemberRegisterInfo { Name = "remove_SizeChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.R_SizeChanged
#endif
                    }},
                    {"add_GuiFocusChanged", new MemberRegisterInfo { Name = "add_GuiFocusChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.A_GuiFocusChanged
#endif
                    }},
                    {"remove_GuiFocusChanged", new MemberRegisterInfo { Name = "remove_GuiFocusChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Viewport_Wrap.R_GuiFocusChanged
#endif
                    }},
                    {"Disable3D", new MemberRegisterInfo { Name = "Disable3D", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_Disable3D, PropertySetter = Godot_Viewport_Wrap.S_Disable3D
#endif
                    }},
                    {"UseXR", new MemberRegisterInfo { Name = "UseXR", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_UseXR, PropertySetter = Godot_Viewport_Wrap.S_UseXR
#endif
                    }},
                    {"OwnWorld3D", new MemberRegisterInfo { Name = "OwnWorld3D", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_OwnWorld3D, PropertySetter = Godot_Viewport_Wrap.S_OwnWorld3D
#endif
                    }},
                    {"World3D", new MemberRegisterInfo { Name = "World3D", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_World3D, PropertySetter = Godot_Viewport_Wrap.S_World3D
#endif
                    }},
                    {"World2D", new MemberRegisterInfo { Name = "World2D", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_World2D, PropertySetter = Godot_Viewport_Wrap.S_World2D
#endif
                    }},
                    {"TransparentBg", new MemberRegisterInfo { Name = "TransparentBg", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_TransparentBg, PropertySetter = Godot_Viewport_Wrap.S_TransparentBg
#endif
                    }},
                    {"HandleInputLocally", new MemberRegisterInfo { Name = "HandleInputLocally", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_HandleInputLocally, PropertySetter = Godot_Viewport_Wrap.S_HandleInputLocally
#endif
                    }},
                    {"Snap2DTransformsToPixel", new MemberRegisterInfo { Name = "Snap2DTransformsToPixel", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_Snap2DTransformsToPixel, PropertySetter = Godot_Viewport_Wrap.S_Snap2DTransformsToPixel
#endif
                    }},
                    {"Snap2DVerticesToPixel", new MemberRegisterInfo { Name = "Snap2DVerticesToPixel", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_Snap2DVerticesToPixel, PropertySetter = Godot_Viewport_Wrap.S_Snap2DVerticesToPixel
#endif
                    }},
                    {"Msaa2D", new MemberRegisterInfo { Name = "Msaa2D", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_Msaa2D, PropertySetter = Godot_Viewport_Wrap.S_Msaa2D
#endif
                    }},
                    {"Msaa3D", new MemberRegisterInfo { Name = "Msaa3D", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_Msaa3D, PropertySetter = Godot_Viewport_Wrap.S_Msaa3D
#endif
                    }},
                    {"ScreenSpaceAA", new MemberRegisterInfo { Name = "ScreenSpaceAA", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_ScreenSpaceAA, PropertySetter = Godot_Viewport_Wrap.S_ScreenSpaceAA
#endif
                    }},
                    {"UseTaa", new MemberRegisterInfo { Name = "UseTaa", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_UseTaa, PropertySetter = Godot_Viewport_Wrap.S_UseTaa
#endif
                    }},
                    {"UseDebanding", new MemberRegisterInfo { Name = "UseDebanding", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_UseDebanding, PropertySetter = Godot_Viewport_Wrap.S_UseDebanding
#endif
                    }},
                    {"UseOcclusionCulling", new MemberRegisterInfo { Name = "UseOcclusionCulling", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_UseOcclusionCulling, PropertySetter = Godot_Viewport_Wrap.S_UseOcclusionCulling
#endif
                    }},
                    {"MeshLodThreshold", new MemberRegisterInfo { Name = "MeshLodThreshold", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_MeshLodThreshold, PropertySetter = Godot_Viewport_Wrap.S_MeshLodThreshold
#endif
                    }},
                    {"DebugDraw", new MemberRegisterInfo { Name = "DebugDraw", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_DebugDraw, PropertySetter = Godot_Viewport_Wrap.S_DebugDraw
#endif
                    }},
                    {"UseHdr2D", new MemberRegisterInfo { Name = "UseHdr2D", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_UseHdr2D, PropertySetter = Godot_Viewport_Wrap.S_UseHdr2D
#endif
                    }},
                    {"Scaling3DMode", new MemberRegisterInfo { Name = "Scaling3DMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_Scaling3DMode, PropertySetter = Godot_Viewport_Wrap.S_Scaling3DMode
#endif
                    }},
                    {"Scaling3DScale", new MemberRegisterInfo { Name = "Scaling3DScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_Scaling3DScale, PropertySetter = Godot_Viewport_Wrap.S_Scaling3DScale
#endif
                    }},
                    {"TextureMipmapBias", new MemberRegisterInfo { Name = "TextureMipmapBias", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_TextureMipmapBias, PropertySetter = Godot_Viewport_Wrap.S_TextureMipmapBias
#endif
                    }},
                    {"AnisotropicFilteringLevel", new MemberRegisterInfo { Name = "AnisotropicFilteringLevel", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_AnisotropicFilteringLevel, PropertySetter = Godot_Viewport_Wrap.S_AnisotropicFilteringLevel
#endif
                    }},
                    {"FsrSharpness", new MemberRegisterInfo { Name = "FsrSharpness", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_FsrSharpness, PropertySetter = Godot_Viewport_Wrap.S_FsrSharpness
#endif
                    }},
                    {"VrsMode", new MemberRegisterInfo { Name = "VrsMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_VrsMode, PropertySetter = Godot_Viewport_Wrap.S_VrsMode
#endif
                    }},
                    {"VrsUpdateMode", new MemberRegisterInfo { Name = "VrsUpdateMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_VrsUpdateMode, PropertySetter = Godot_Viewport_Wrap.S_VrsUpdateMode
#endif
                    }},
                    {"VrsTexture", new MemberRegisterInfo { Name = "VrsTexture", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_VrsTexture, PropertySetter = Godot_Viewport_Wrap.S_VrsTexture
#endif
                    }},
                    {"CanvasItemDefaultTextureFilter", new MemberRegisterInfo { Name = "CanvasItemDefaultTextureFilter", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_CanvasItemDefaultTextureFilter, PropertySetter = Godot_Viewport_Wrap.S_CanvasItemDefaultTextureFilter
#endif
                    }},
                    {"CanvasItemDefaultTextureRepeat", new MemberRegisterInfo { Name = "CanvasItemDefaultTextureRepeat", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_CanvasItemDefaultTextureRepeat, PropertySetter = Godot_Viewport_Wrap.S_CanvasItemDefaultTextureRepeat
#endif
                    }},
                    {"AudioListenerEnable2D", new MemberRegisterInfo { Name = "AudioListenerEnable2D", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_AudioListenerEnable2D, PropertySetter = Godot_Viewport_Wrap.S_AudioListenerEnable2D
#endif
                    }},
                    {"AudioListenerEnable3D", new MemberRegisterInfo { Name = "AudioListenerEnable3D", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_AudioListenerEnable3D, PropertySetter = Godot_Viewport_Wrap.S_AudioListenerEnable3D
#endif
                    }},
                    {"PhysicsObjectPicking", new MemberRegisterInfo { Name = "PhysicsObjectPicking", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_PhysicsObjectPicking, PropertySetter = Godot_Viewport_Wrap.S_PhysicsObjectPicking
#endif
                    }},
                    {"PhysicsObjectPickingSort", new MemberRegisterInfo { Name = "PhysicsObjectPickingSort", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_PhysicsObjectPickingSort, PropertySetter = Godot_Viewport_Wrap.S_PhysicsObjectPickingSort
#endif
                    }},
                    {"PhysicsObjectPickingFirstOnly", new MemberRegisterInfo { Name = "PhysicsObjectPickingFirstOnly", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_PhysicsObjectPickingFirstOnly, PropertySetter = Godot_Viewport_Wrap.S_PhysicsObjectPickingFirstOnly
#endif
                    }},
                    {"GuiDisableInput", new MemberRegisterInfo { Name = "GuiDisableInput", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_GuiDisableInput, PropertySetter = Godot_Viewport_Wrap.S_GuiDisableInput
#endif
                    }},
                    {"GuiSnapControlsToPixels", new MemberRegisterInfo { Name = "GuiSnapControlsToPixels", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_GuiSnapControlsToPixels, PropertySetter = Godot_Viewport_Wrap.S_GuiSnapControlsToPixels
#endif
                    }},
                    {"GuiEmbedSubwindows", new MemberRegisterInfo { Name = "GuiEmbedSubwindows", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_GuiEmbedSubwindows, PropertySetter = Godot_Viewport_Wrap.S_GuiEmbedSubwindows
#endif
                    }},
                    {"SdfOversize", new MemberRegisterInfo { Name = "SdfOversize", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_SdfOversize, PropertySetter = Godot_Viewport_Wrap.S_SdfOversize
#endif
                    }},
                    {"SdfScale", new MemberRegisterInfo { Name = "SdfScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_SdfScale, PropertySetter = Godot_Viewport_Wrap.S_SdfScale
#endif
                    }},
                    {"PositionalShadowAtlasSize", new MemberRegisterInfo { Name = "PositionalShadowAtlasSize", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_PositionalShadowAtlasSize, PropertySetter = Godot_Viewport_Wrap.S_PositionalShadowAtlasSize
#endif
                    }},
                    {"PositionalShadowAtlas16Bits", new MemberRegisterInfo { Name = "PositionalShadowAtlas16Bits", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_PositionalShadowAtlas16Bits, PropertySetter = Godot_Viewport_Wrap.S_PositionalShadowAtlas16Bits
#endif
                    }},
                    {"PositionalShadowAtlasQuad0", new MemberRegisterInfo { Name = "PositionalShadowAtlasQuad0", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_PositionalShadowAtlasQuad0, PropertySetter = Godot_Viewport_Wrap.S_PositionalShadowAtlasQuad0
#endif
                    }},
                    {"PositionalShadowAtlasQuad1", new MemberRegisterInfo { Name = "PositionalShadowAtlasQuad1", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_PositionalShadowAtlasQuad1, PropertySetter = Godot_Viewport_Wrap.S_PositionalShadowAtlasQuad1
#endif
                    }},
                    {"PositionalShadowAtlasQuad2", new MemberRegisterInfo { Name = "PositionalShadowAtlasQuad2", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_PositionalShadowAtlasQuad2, PropertySetter = Godot_Viewport_Wrap.S_PositionalShadowAtlasQuad2
#endif
                    }},
                    {"PositionalShadowAtlasQuad3", new MemberRegisterInfo { Name = "PositionalShadowAtlasQuad3", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_PositionalShadowAtlasQuad3, PropertySetter = Godot_Viewport_Wrap.S_PositionalShadowAtlasQuad3
#endif
                    }},
                    {"CanvasTransform", new MemberRegisterInfo { Name = "CanvasTransform", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_CanvasTransform, PropertySetter = Godot_Viewport_Wrap.S_CanvasTransform
#endif
                    }},
                    {"GlobalCanvasTransform", new MemberRegisterInfo { Name = "GlobalCanvasTransform", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_GlobalCanvasTransform, PropertySetter = Godot_Viewport_Wrap.S_GlobalCanvasTransform
#endif
                    }},
                    {"CanvasCullMask", new MemberRegisterInfo { Name = "CanvasCullMask", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_CanvasCullMask, PropertySetter = Godot_Viewport_Wrap.S_CanvasCullMask
#endif
                    }},
                    {"Oversampling", new MemberRegisterInfo { Name = "Oversampling", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_Oversampling, PropertySetter = Godot_Viewport_Wrap.S_Oversampling
#endif
                    }},
                    {"OversamplingOverride", new MemberRegisterInfo { Name = "OversamplingOverride", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Viewport_Wrap.G_OversamplingOverride, PropertySetter = Godot_Viewport_Wrap.S_OversamplingOverride
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_NodePath_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_NodePath_Wrap.Constructor
#endif
                    }},
                    {"Dispose", new MemberRegisterInfo { Name = "Dispose", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_Dispose
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_ToString
#endif
                    }},
                    {"GetAsPropertyPath", new MemberRegisterInfo { Name = "GetAsPropertyPath", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_GetAsPropertyPath
#endif
                    }},
                    {"GetConcatenatedNames", new MemberRegisterInfo { Name = "GetConcatenatedNames", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_GetConcatenatedNames
#endif
                    }},
                    {"GetConcatenatedSubNames", new MemberRegisterInfo { Name = "GetConcatenatedSubNames", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_GetConcatenatedSubNames
#endif
                    }},
                    {"GetName", new MemberRegisterInfo { Name = "GetName", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_GetName
#endif
                    }},
                    {"GetNameCount", new MemberRegisterInfo { Name = "GetNameCount", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_GetNameCount
#endif
                    }},
                    {"GetSubName", new MemberRegisterInfo { Name = "GetSubName", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_GetSubName
#endif
                    }},
                    {"GetSubNameCount", new MemberRegisterInfo { Name = "GetSubNameCount", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_GetSubNameCount
#endif
                    }},
                    {"IsAbsolute", new MemberRegisterInfo { Name = "IsAbsolute", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_IsAbsolute
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.O_op_Inequality
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_Equals
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_NodePath_Wrap.M_GetHashCode
#endif
                    }},
                    {"IsEmpty", new MemberRegisterInfo { Name = "IsEmpty", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_NodePath_Wrap.G_IsEmpty
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Input_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"add_JoyConnectionChanged_static", new MemberRegisterInfo { Name = "add_JoyConnectionChanged", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.A_JoyConnectionChanged
#endif
                    }},
                    {"remove_JoyConnectionChanged_static", new MemberRegisterInfo { Name = "remove_JoyConnectionChanged", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.R_JoyConnectionChanged
#endif
                    }},
                    {"IsAnythingPressed_static", new MemberRegisterInfo { Name = "IsAnythingPressed", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsAnythingPressed
#endif
                    }},
                    {"IsKeyPressed_static", new MemberRegisterInfo { Name = "IsKeyPressed", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsKeyPressed
#endif
                    }},
                    {"IsPhysicalKeyPressed_static", new MemberRegisterInfo { Name = "IsPhysicalKeyPressed", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsPhysicalKeyPressed
#endif
                    }},
                    {"IsKeyLabelPressed_static", new MemberRegisterInfo { Name = "IsKeyLabelPressed", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsKeyLabelPressed
#endif
                    }},
                    {"IsMouseButtonPressed_static", new MemberRegisterInfo { Name = "IsMouseButtonPressed", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsMouseButtonPressed
#endif
                    }},
                    {"IsJoyButtonPressed_static", new MemberRegisterInfo { Name = "IsJoyButtonPressed", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsJoyButtonPressed
#endif
                    }},
                    {"IsActionPressed_static", new MemberRegisterInfo { Name = "IsActionPressed", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsActionPressed
#endif
                    }},
                    {"IsActionJustPressed_static", new MemberRegisterInfo { Name = "IsActionJustPressed", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsActionJustPressed
#endif
                    }},
                    {"IsActionJustReleased_static", new MemberRegisterInfo { Name = "IsActionJustReleased", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsActionJustReleased
#endif
                    }},
                    {"GetActionStrength_static", new MemberRegisterInfo { Name = "GetActionStrength", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetActionStrength
#endif
                    }},
                    {"GetActionRawStrength_static", new MemberRegisterInfo { Name = "GetActionRawStrength", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetActionRawStrength
#endif
                    }},
                    {"GetAxis_static", new MemberRegisterInfo { Name = "GetAxis", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetAxis
#endif
                    }},
                    {"GetVector_static", new MemberRegisterInfo { Name = "GetVector", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetVector
#endif
                    }},
                    {"AddJoyMapping_static", new MemberRegisterInfo { Name = "AddJoyMapping", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_AddJoyMapping
#endif
                    }},
                    {"RemoveJoyMapping_static", new MemberRegisterInfo { Name = "RemoveJoyMapping", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_RemoveJoyMapping
#endif
                    }},
                    {"IsJoyKnown_static", new MemberRegisterInfo { Name = "IsJoyKnown", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsJoyKnown
#endif
                    }},
                    {"GetJoyAxis_static", new MemberRegisterInfo { Name = "GetJoyAxis", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetJoyAxis
#endif
                    }},
                    {"GetJoyName_static", new MemberRegisterInfo { Name = "GetJoyName", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetJoyName
#endif
                    }},
                    {"GetJoyGuid_static", new MemberRegisterInfo { Name = "GetJoyGuid", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetJoyGuid
#endif
                    }},
                    {"GetJoyInfo_static", new MemberRegisterInfo { Name = "GetJoyInfo", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetJoyInfo
#endif
                    }},
                    {"ShouldIgnoreDevice_static", new MemberRegisterInfo { Name = "ShouldIgnoreDevice", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_ShouldIgnoreDevice
#endif
                    }},
                    {"GetConnectedJoypads_static", new MemberRegisterInfo { Name = "GetConnectedJoypads", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetConnectedJoypads
#endif
                    }},
                    {"GetJoyVibrationStrength_static", new MemberRegisterInfo { Name = "GetJoyVibrationStrength", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetJoyVibrationStrength
#endif
                    }},
                    {"GetJoyVibrationDuration_static", new MemberRegisterInfo { Name = "GetJoyVibrationDuration", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetJoyVibrationDuration
#endif
                    }},
                    {"StartJoyVibration_static", new MemberRegisterInfo { Name = "StartJoyVibration", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_StartJoyVibration
#endif
                    }},
                    {"StopJoyVibration_static", new MemberRegisterInfo { Name = "StopJoyVibration", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_StopJoyVibration
#endif
                    }},
                    {"VibrateHandheld_static", new MemberRegisterInfo { Name = "VibrateHandheld", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_VibrateHandheld
#endif
                    }},
                    {"GetGravity_static", new MemberRegisterInfo { Name = "GetGravity", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetGravity
#endif
                    }},
                    {"GetAccelerometer_static", new MemberRegisterInfo { Name = "GetAccelerometer", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetAccelerometer
#endif
                    }},
                    {"GetMagnetometer_static", new MemberRegisterInfo { Name = "GetMagnetometer", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetMagnetometer
#endif
                    }},
                    {"GetGyroscope_static", new MemberRegisterInfo { Name = "GetGyroscope", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetGyroscope
#endif
                    }},
                    {"SetGravity_static", new MemberRegisterInfo { Name = "SetGravity", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_SetGravity
#endif
                    }},
                    {"SetAccelerometer_static", new MemberRegisterInfo { Name = "SetAccelerometer", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_SetAccelerometer
#endif
                    }},
                    {"SetMagnetometer_static", new MemberRegisterInfo { Name = "SetMagnetometer", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_SetMagnetometer
#endif
                    }},
                    {"SetGyroscope_static", new MemberRegisterInfo { Name = "SetGyroscope", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_SetGyroscope
#endif
                    }},
                    {"GetLastMouseVelocity_static", new MemberRegisterInfo { Name = "GetLastMouseVelocity", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetLastMouseVelocity
#endif
                    }},
                    {"GetLastMouseScreenVelocity_static", new MemberRegisterInfo { Name = "GetLastMouseScreenVelocity", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetLastMouseScreenVelocity
#endif
                    }},
                    {"GetMouseButtonMask_static", new MemberRegisterInfo { Name = "GetMouseButtonMask", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetMouseButtonMask
#endif
                    }},
                    {"SetMouseMode_static", new MemberRegisterInfo { Name = "SetMouseMode", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_SetMouseMode
#endif
                    }},
                    {"GetMouseMode_static", new MemberRegisterInfo { Name = "GetMouseMode", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetMouseMode
#endif
                    }},
                    {"WarpMouse_static", new MemberRegisterInfo { Name = "WarpMouse", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_WarpMouse
#endif
                    }},
                    {"ActionPress_static", new MemberRegisterInfo { Name = "ActionPress", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_ActionPress
#endif
                    }},
                    {"ActionRelease_static", new MemberRegisterInfo { Name = "ActionRelease", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_ActionRelease
#endif
                    }},
                    {"SetDefaultCursorShape_static", new MemberRegisterInfo { Name = "SetDefaultCursorShape", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_SetDefaultCursorShape
#endif
                    }},
                    {"GetCurrentCursorShape_static", new MemberRegisterInfo { Name = "GetCurrentCursorShape", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_GetCurrentCursorShape
#endif
                    }},
                    {"SetCustomMouseCursor_static", new MemberRegisterInfo { Name = "SetCustomMouseCursor", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_SetCustomMouseCursor
#endif
                    }},
                    {"ParseInputEvent_static", new MemberRegisterInfo { Name = "ParseInputEvent", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_ParseInputEvent
#endif
                    }},
                    {"SetUseAccumulatedInput_static", new MemberRegisterInfo { Name = "SetUseAccumulatedInput", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_SetUseAccumulatedInput
#endif
                    }},
                    {"IsUsingAccumulatedInput_static", new MemberRegisterInfo { Name = "IsUsingAccumulatedInput", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsUsingAccumulatedInput
#endif
                    }},
                    {"FlushBufferedEvents_static", new MemberRegisterInfo { Name = "FlushBufferedEvents", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_FlushBufferedEvents
#endif
                    }},
                    {"SetEmulateMouseFromTouch_static", new MemberRegisterInfo { Name = "SetEmulateMouseFromTouch", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_SetEmulateMouseFromTouch
#endif
                    }},
                    {"IsEmulatingMouseFromTouch_static", new MemberRegisterInfo { Name = "IsEmulatingMouseFromTouch", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsEmulatingMouseFromTouch
#endif
                    }},
                    {"SetEmulateTouchFromMouse_static", new MemberRegisterInfo { Name = "SetEmulateTouchFromMouse", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_SetEmulateTouchFromMouse
#endif
                    }},
                    {"IsEmulatingTouchFromMouse_static", new MemberRegisterInfo { Name = "IsEmulatingTouchFromMouse", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Input_Wrap.F_IsEmulatingTouchFromMouse
#endif
                    }},
                    {"MouseMode_static", new MemberRegisterInfo { Name = "MouseMode", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Input_Wrap.G_MouseMode, PropertySetter = Godot_Input_Wrap.S_MouseMode
#endif
                    }},
                    {"UseAccumulatedInput_static", new MemberRegisterInfo { Name = "UseAccumulatedInput", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Input_Wrap.G_UseAccumulatedInput, PropertySetter = Godot_Input_Wrap.S_UseAccumulatedInput
#endif
                    }},
                    {"EmulateMouseFromTouch_static", new MemberRegisterInfo { Name = "EmulateMouseFromTouch", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Input_Wrap.G_EmulateMouseFromTouch, PropertySetter = Godot_Input_Wrap.S_EmulateMouseFromTouch
#endif
                    }},
                    {"EmulateTouchFromMouse_static", new MemberRegisterInfo { Name = "EmulateTouchFromMouse", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Input_Wrap.G_EmulateTouchFromMouse, PropertySetter = Godot_Input_Wrap.S_EmulateTouchFromMouse
#endif
                    }},
                    {"Singleton_static", new MemberRegisterInfo { Name = "Singleton", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Input_Wrap.G_Singleton
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_InputEvent_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"SetDevice", new MemberRegisterInfo { Name = "SetDevice", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_SetDevice
#endif
                    }},
                    {"GetDevice", new MemberRegisterInfo { Name = "GetDevice", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_GetDevice
#endif
                    }},
                    {"IsAction", new MemberRegisterInfo { Name = "IsAction", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_IsAction
#endif
                    }},
                    {"IsActionPressed", new MemberRegisterInfo { Name = "IsActionPressed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_IsActionPressed
#endif
                    }},
                    {"IsActionReleased", new MemberRegisterInfo { Name = "IsActionReleased", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_IsActionReleased
#endif
                    }},
                    {"GetActionStrength", new MemberRegisterInfo { Name = "GetActionStrength", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_GetActionStrength
#endif
                    }},
                    {"IsCanceled", new MemberRegisterInfo { Name = "IsCanceled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_IsCanceled
#endif
                    }},
                    {"IsPressed", new MemberRegisterInfo { Name = "IsPressed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_IsPressed
#endif
                    }},
                    {"IsReleased", new MemberRegisterInfo { Name = "IsReleased", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_IsReleased
#endif
                    }},
                    {"IsEcho", new MemberRegisterInfo { Name = "IsEcho", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_IsEcho
#endif
                    }},
                    {"AsText", new MemberRegisterInfo { Name = "AsText", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_AsText
#endif
                    }},
                    {"IsMatch", new MemberRegisterInfo { Name = "IsMatch", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_IsMatch
#endif
                    }},
                    {"IsActionType", new MemberRegisterInfo { Name = "IsActionType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_IsActionType
#endif
                    }},
                    {"Accumulate", new MemberRegisterInfo { Name = "Accumulate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_Accumulate
#endif
                    }},
                    {"XformedBy", new MemberRegisterInfo { Name = "XformedBy", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEvent_Wrap.M_XformedBy
#endif
                    }},
                    {"Device", new MemberRegisterInfo { Name = "Device", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_InputEvent_Wrap.G_Device, PropertySetter = Godot_InputEvent_Wrap.S_Device
#endif
                    }},
                    {"DeviceIdEmulation_static", new MemberRegisterInfo { Name = "DeviceIdEmulation", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_InputEvent_Wrap.G_DeviceIdEmulation
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_InputEventMouse_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"SetButtonMask", new MemberRegisterInfo { Name = "SetButtonMask", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouse_Wrap.M_SetButtonMask
#endif
                    }},
                    {"GetButtonMask", new MemberRegisterInfo { Name = "GetButtonMask", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouse_Wrap.M_GetButtonMask
#endif
                    }},
                    {"SetPosition", new MemberRegisterInfo { Name = "SetPosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouse_Wrap.M_SetPosition
#endif
                    }},
                    {"GetPosition", new MemberRegisterInfo { Name = "GetPosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouse_Wrap.M_GetPosition
#endif
                    }},
                    {"SetGlobalPosition", new MemberRegisterInfo { Name = "SetGlobalPosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouse_Wrap.M_SetGlobalPosition
#endif
                    }},
                    {"GetGlobalPosition", new MemberRegisterInfo { Name = "GetGlobalPosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouse_Wrap.M_GetGlobalPosition
#endif
                    }},
                    {"ButtonMask", new MemberRegisterInfo { Name = "ButtonMask", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_InputEventMouse_Wrap.G_ButtonMask, PropertySetter = Godot_InputEventMouse_Wrap.S_ButtonMask
#endif
                    }},
                    {"Position", new MemberRegisterInfo { Name = "Position", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_InputEventMouse_Wrap.G_Position, PropertySetter = Godot_InputEventMouse_Wrap.S_Position
#endif
                    }},
                    {"GlobalPosition", new MemberRegisterInfo { Name = "GlobalPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_InputEventMouse_Wrap.G_GlobalPosition, PropertySetter = Godot_InputEventMouse_Wrap.S_GlobalPosition
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_InputEventMouseButton_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_InputEventMouseButton_Wrap.Constructor
#endif
                    }},
                    {"SetFactor", new MemberRegisterInfo { Name = "SetFactor", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouseButton_Wrap.M_SetFactor
#endif
                    }},
                    {"GetFactor", new MemberRegisterInfo { Name = "GetFactor", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouseButton_Wrap.M_GetFactor
#endif
                    }},
                    {"SetButtonIndex", new MemberRegisterInfo { Name = "SetButtonIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouseButton_Wrap.M_SetButtonIndex
#endif
                    }},
                    {"GetButtonIndex", new MemberRegisterInfo { Name = "GetButtonIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouseButton_Wrap.M_GetButtonIndex
#endif
                    }},
                    {"SetPressed", new MemberRegisterInfo { Name = "SetPressed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouseButton_Wrap.M_SetPressed
#endif
                    }},
                    {"SetCanceled", new MemberRegisterInfo { Name = "SetCanceled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouseButton_Wrap.M_SetCanceled
#endif
                    }},
                    {"SetDoubleClick", new MemberRegisterInfo { Name = "SetDoubleClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouseButton_Wrap.M_SetDoubleClick
#endif
                    }},
                    {"IsDoubleClick", new MemberRegisterInfo { Name = "IsDoubleClick", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_InputEventMouseButton_Wrap.M_IsDoubleClick
#endif
                    }},
                    {"Factor", new MemberRegisterInfo { Name = "Factor", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_InputEventMouseButton_Wrap.G_Factor, PropertySetter = Godot_InputEventMouseButton_Wrap.S_Factor
#endif
                    }},
                    {"ButtonIndex", new MemberRegisterInfo { Name = "ButtonIndex", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_InputEventMouseButton_Wrap.G_ButtonIndex, PropertySetter = Godot_InputEventMouseButton_Wrap.S_ButtonIndex
#endif
                    }},
                    {"Canceled", new MemberRegisterInfo { Name = "Canceled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_InputEventMouseButton_Wrap.G_Canceled, PropertySetter = Godot_InputEventMouseButton_Wrap.S_Canceled
#endif
                    }},
                    {"Pressed", new MemberRegisterInfo { Name = "Pressed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_InputEventMouseButton_Wrap.G_Pressed, PropertySetter = Godot_InputEventMouseButton_Wrap.S_Pressed
#endif
                    }},
                    {"DoubleClick", new MemberRegisterInfo { Name = "DoubleClick", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_InputEventMouseButton_Wrap.G_DoubleClick, PropertySetter = Godot_InputEventMouseButton_Wrap.S_DoubleClick
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Time_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"GetDatetimeDictFromUnixTime_static", new MemberRegisterInfo { Name = "GetDatetimeDictFromUnixTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetDatetimeDictFromUnixTime
#endif
                    }},
                    {"GetDateDictFromUnixTime_static", new MemberRegisterInfo { Name = "GetDateDictFromUnixTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetDateDictFromUnixTime
#endif
                    }},
                    {"GetTimeDictFromUnixTime_static", new MemberRegisterInfo { Name = "GetTimeDictFromUnixTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetTimeDictFromUnixTime
#endif
                    }},
                    {"GetDatetimeStringFromUnixTime_static", new MemberRegisterInfo { Name = "GetDatetimeStringFromUnixTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetDatetimeStringFromUnixTime
#endif
                    }},
                    {"GetDateStringFromUnixTime_static", new MemberRegisterInfo { Name = "GetDateStringFromUnixTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetDateStringFromUnixTime
#endif
                    }},
                    {"GetTimeStringFromUnixTime_static", new MemberRegisterInfo { Name = "GetTimeStringFromUnixTime", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetTimeStringFromUnixTime
#endif
                    }},
                    {"GetDatetimeDictFromDatetimeString_static", new MemberRegisterInfo { Name = "GetDatetimeDictFromDatetimeString", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetDatetimeDictFromDatetimeString
#endif
                    }},
                    {"GetDatetimeStringFromDatetimeDict_static", new MemberRegisterInfo { Name = "GetDatetimeStringFromDatetimeDict", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetDatetimeStringFromDatetimeDict
#endif
                    }},
                    {"GetUnixTimeFromDatetimeDict_static", new MemberRegisterInfo { Name = "GetUnixTimeFromDatetimeDict", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetUnixTimeFromDatetimeDict
#endif
                    }},
                    {"GetUnixTimeFromDatetimeString_static", new MemberRegisterInfo { Name = "GetUnixTimeFromDatetimeString", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetUnixTimeFromDatetimeString
#endif
                    }},
                    {"GetOffsetStringFromOffsetMinutes_static", new MemberRegisterInfo { Name = "GetOffsetStringFromOffsetMinutes", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetOffsetStringFromOffsetMinutes
#endif
                    }},
                    {"GetDatetimeDictFromSystem_static", new MemberRegisterInfo { Name = "GetDatetimeDictFromSystem", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetDatetimeDictFromSystem
#endif
                    }},
                    {"GetDateDictFromSystem_static", new MemberRegisterInfo { Name = "GetDateDictFromSystem", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetDateDictFromSystem
#endif
                    }},
                    {"GetTimeDictFromSystem_static", new MemberRegisterInfo { Name = "GetTimeDictFromSystem", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetTimeDictFromSystem
#endif
                    }},
                    {"GetDatetimeStringFromSystem_static", new MemberRegisterInfo { Name = "GetDatetimeStringFromSystem", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetDatetimeStringFromSystem
#endif
                    }},
                    {"GetDateStringFromSystem_static", new MemberRegisterInfo { Name = "GetDateStringFromSystem", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetDateStringFromSystem
#endif
                    }},
                    {"GetTimeStringFromSystem_static", new MemberRegisterInfo { Name = "GetTimeStringFromSystem", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetTimeStringFromSystem
#endif
                    }},
                    {"GetTimeZoneFromSystem_static", new MemberRegisterInfo { Name = "GetTimeZoneFromSystem", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetTimeZoneFromSystem
#endif
                    }},
                    {"GetUnixTimeFromSystem_static", new MemberRegisterInfo { Name = "GetUnixTimeFromSystem", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetUnixTimeFromSystem
#endif
                    }},
                    {"GetTicksMsec_static", new MemberRegisterInfo { Name = "GetTicksMsec", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetTicksMsec
#endif
                    }},
                    {"GetTicksUsec_static", new MemberRegisterInfo { Name = "GetTicksUsec", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Time_Wrap.F_GetTicksUsec
#endif
                    }},
                    {"Singleton_static", new MemberRegisterInfo { Name = "Singleton", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Time_Wrap.G_Singleton
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Node_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_Node_Wrap.Constructor
#endif
                    }},
                    {"_EnterTree", new MemberRegisterInfo { Name = "_EnterTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__EnterTree
#endif
                    }},
                    {"_ExitTree", new MemberRegisterInfo { Name = "_ExitTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__ExitTree
#endif
                    }},
                    {"_GetAccessibilityConfigurationWarnings", new MemberRegisterInfo { Name = "_GetAccessibilityConfigurationWarnings", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__GetAccessibilityConfigurationWarnings
#endif
                    }},
                    {"_GetConfigurationWarnings", new MemberRegisterInfo { Name = "_GetConfigurationWarnings", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__GetConfigurationWarnings
#endif
                    }},
                    {"_GetFocusedAccessibilityElement", new MemberRegisterInfo { Name = "_GetFocusedAccessibilityElement", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__GetFocusedAccessibilityElement
#endif
                    }},
                    {"_Input", new MemberRegisterInfo { Name = "_Input", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__Input
#endif
                    }},
                    {"_PhysicsProcess", new MemberRegisterInfo { Name = "_PhysicsProcess", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__PhysicsProcess
#endif
                    }},
                    {"_Process", new MemberRegisterInfo { Name = "_Process", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__Process
#endif
                    }},
                    {"_Ready", new MemberRegisterInfo { Name = "_Ready", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__Ready
#endif
                    }},
                    {"_ShortcutInput", new MemberRegisterInfo { Name = "_ShortcutInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__ShortcutInput
#endif
                    }},
                    {"_UnhandledInput", new MemberRegisterInfo { Name = "_UnhandledInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__UnhandledInput
#endif
                    }},
                    {"_UnhandledKeyInput", new MemberRegisterInfo { Name = "_UnhandledKeyInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M__UnhandledKeyInput
#endif
                    }},
                    {"AddSibling", new MemberRegisterInfo { Name = "AddSibling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_AddSibling
#endif
                    }},
                    {"SetName", new MemberRegisterInfo { Name = "SetName", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetName
#endif
                    }},
                    {"GetName", new MemberRegisterInfo { Name = "GetName", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetName
#endif
                    }},
                    {"AddChild", new MemberRegisterInfo { Name = "AddChild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_AddChild
#endif
                    }},
                    {"RemoveChild", new MemberRegisterInfo { Name = "RemoveChild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_RemoveChild
#endif
                    }},
                    {"Reparent", new MemberRegisterInfo { Name = "Reparent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_Reparent
#endif
                    }},
                    {"GetChildCount", new MemberRegisterInfo { Name = "GetChildCount", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetChildCount
#endif
                    }},
                    {"GetChildren", new MemberRegisterInfo { Name = "GetChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetChildren
#endif
                    }},
                    {"GetChild", new MemberRegisterInfo { Name = "GetChild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetChild
#endif
                    }},
                    {"HasNode", new MemberRegisterInfo { Name = "HasNode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_HasNode
#endif
                    }},
                    {"GetNode", new MemberRegisterInfo { Name = "GetNode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetNode
#endif
                    }},
                    {"GetNodeOrNull", new MemberRegisterInfo { Name = "GetNodeOrNull", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetNodeOrNull
#endif
                    }},
                    {"GetParent", new MemberRegisterInfo { Name = "GetParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetParent
#endif
                    }},
                    {"FindChild", new MemberRegisterInfo { Name = "FindChild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_FindChild
#endif
                    }},
                    {"FindChildren", new MemberRegisterInfo { Name = "FindChildren", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_FindChildren
#endif
                    }},
                    {"FindParent", new MemberRegisterInfo { Name = "FindParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_FindParent
#endif
                    }},
                    {"HasNodeAndResource", new MemberRegisterInfo { Name = "HasNodeAndResource", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_HasNodeAndResource
#endif
                    }},
                    {"GetNodeAndResource", new MemberRegisterInfo { Name = "GetNodeAndResource", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetNodeAndResource
#endif
                    }},
                    {"IsInsideTree", new MemberRegisterInfo { Name = "IsInsideTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsInsideTree
#endif
                    }},
                    {"IsPartOfEditedScene", new MemberRegisterInfo { Name = "IsPartOfEditedScene", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsPartOfEditedScene
#endif
                    }},
                    {"IsAncestorOf", new MemberRegisterInfo { Name = "IsAncestorOf", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsAncestorOf
#endif
                    }},
                    {"IsGreaterThan", new MemberRegisterInfo { Name = "IsGreaterThan", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsGreaterThan
#endif
                    }},
                    {"GetPath", new MemberRegisterInfo { Name = "GetPath", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetPath
#endif
                    }},
                    {"GetPathTo", new MemberRegisterInfo { Name = "GetPathTo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetPathTo
#endif
                    }},
                    {"AddToGroup", new MemberRegisterInfo { Name = "AddToGroup", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_AddToGroup
#endif
                    }},
                    {"RemoveFromGroup", new MemberRegisterInfo { Name = "RemoveFromGroup", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_RemoveFromGroup
#endif
                    }},
                    {"IsInGroup", new MemberRegisterInfo { Name = "IsInGroup", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsInGroup
#endif
                    }},
                    {"MoveChild", new MemberRegisterInfo { Name = "MoveChild", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_MoveChild
#endif
                    }},
                    {"GetGroups", new MemberRegisterInfo { Name = "GetGroups", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetGroups
#endif
                    }},
                    {"SetOwner", new MemberRegisterInfo { Name = "SetOwner", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetOwner
#endif
                    }},
                    {"GetOwner", new MemberRegisterInfo { Name = "GetOwner", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetOwner
#endif
                    }},
                    {"GetIndex", new MemberRegisterInfo { Name = "GetIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetIndex
#endif
                    }},
                    {"PrintTree", new MemberRegisterInfo { Name = "PrintTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_PrintTree
#endif
                    }},
                    {"PrintTreePretty", new MemberRegisterInfo { Name = "PrintTreePretty", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_PrintTreePretty
#endif
                    }},
                    {"GetTreeString", new MemberRegisterInfo { Name = "GetTreeString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetTreeString
#endif
                    }},
                    {"GetTreeStringPretty", new MemberRegisterInfo { Name = "GetTreeStringPretty", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetTreeStringPretty
#endif
                    }},
                    {"SetSceneFilePath", new MemberRegisterInfo { Name = "SetSceneFilePath", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetSceneFilePath
#endif
                    }},
                    {"GetSceneFilePath", new MemberRegisterInfo { Name = "GetSceneFilePath", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetSceneFilePath
#endif
                    }},
                    {"PropagateNotification", new MemberRegisterInfo { Name = "PropagateNotification", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_PropagateNotification
#endif
                    }},
                    {"PropagateCall", new MemberRegisterInfo { Name = "PropagateCall", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_PropagateCall
#endif
                    }},
                    {"SetPhysicsProcess", new MemberRegisterInfo { Name = "SetPhysicsProcess", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetPhysicsProcess
#endif
                    }},
                    {"GetPhysicsProcessDeltaTime", new MemberRegisterInfo { Name = "GetPhysicsProcessDeltaTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetPhysicsProcessDeltaTime
#endif
                    }},
                    {"IsPhysicsProcessing", new MemberRegisterInfo { Name = "IsPhysicsProcessing", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsPhysicsProcessing
#endif
                    }},
                    {"GetProcessDeltaTime", new MemberRegisterInfo { Name = "GetProcessDeltaTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetProcessDeltaTime
#endif
                    }},
                    {"SetProcess", new MemberRegisterInfo { Name = "SetProcess", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcess
#endif
                    }},
                    {"SetProcessPriority", new MemberRegisterInfo { Name = "SetProcessPriority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcessPriority
#endif
                    }},
                    {"GetProcessPriority", new MemberRegisterInfo { Name = "GetProcessPriority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetProcessPriority
#endif
                    }},
                    {"SetPhysicsProcessPriority", new MemberRegisterInfo { Name = "SetPhysicsProcessPriority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetPhysicsProcessPriority
#endif
                    }},
                    {"GetPhysicsProcessPriority", new MemberRegisterInfo { Name = "GetPhysicsProcessPriority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetPhysicsProcessPriority
#endif
                    }},
                    {"IsProcessing", new MemberRegisterInfo { Name = "IsProcessing", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsProcessing
#endif
                    }},
                    {"SetProcessInput", new MemberRegisterInfo { Name = "SetProcessInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcessInput
#endif
                    }},
                    {"IsProcessingInput", new MemberRegisterInfo { Name = "IsProcessingInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsProcessingInput
#endif
                    }},
                    {"SetProcessShortcutInput", new MemberRegisterInfo { Name = "SetProcessShortcutInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcessShortcutInput
#endif
                    }},
                    {"IsProcessingShortcutInput", new MemberRegisterInfo { Name = "IsProcessingShortcutInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsProcessingShortcutInput
#endif
                    }},
                    {"SetProcessUnhandledInput", new MemberRegisterInfo { Name = "SetProcessUnhandledInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcessUnhandledInput
#endif
                    }},
                    {"IsProcessingUnhandledInput", new MemberRegisterInfo { Name = "IsProcessingUnhandledInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsProcessingUnhandledInput
#endif
                    }},
                    {"SetProcessUnhandledKeyInput", new MemberRegisterInfo { Name = "SetProcessUnhandledKeyInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcessUnhandledKeyInput
#endif
                    }},
                    {"IsProcessingUnhandledKeyInput", new MemberRegisterInfo { Name = "IsProcessingUnhandledKeyInput", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsProcessingUnhandledKeyInput
#endif
                    }},
                    {"SetProcessMode", new MemberRegisterInfo { Name = "SetProcessMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcessMode
#endif
                    }},
                    {"GetProcessMode", new MemberRegisterInfo { Name = "GetProcessMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetProcessMode
#endif
                    }},
                    {"CanProcess", new MemberRegisterInfo { Name = "CanProcess", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_CanProcess
#endif
                    }},
                    {"SetProcessThreadGroup", new MemberRegisterInfo { Name = "SetProcessThreadGroup", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcessThreadGroup
#endif
                    }},
                    {"GetProcessThreadGroup", new MemberRegisterInfo { Name = "GetProcessThreadGroup", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetProcessThreadGroup
#endif
                    }},
                    {"SetProcessThreadMessages", new MemberRegisterInfo { Name = "SetProcessThreadMessages", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcessThreadMessages
#endif
                    }},
                    {"GetProcessThreadMessages", new MemberRegisterInfo { Name = "GetProcessThreadMessages", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetProcessThreadMessages
#endif
                    }},
                    {"SetProcessThreadGroupOrder", new MemberRegisterInfo { Name = "SetProcessThreadGroupOrder", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcessThreadGroupOrder
#endif
                    }},
                    {"GetProcessThreadGroupOrder", new MemberRegisterInfo { Name = "GetProcessThreadGroupOrder", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetProcessThreadGroupOrder
#endif
                    }},
                    {"QueueAccessibilityUpdate", new MemberRegisterInfo { Name = "QueueAccessibilityUpdate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_QueueAccessibilityUpdate
#endif
                    }},
                    {"GetAccessibilityElement", new MemberRegisterInfo { Name = "GetAccessibilityElement", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetAccessibilityElement
#endif
                    }},
                    {"SetDisplayFolded", new MemberRegisterInfo { Name = "SetDisplayFolded", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetDisplayFolded
#endif
                    }},
                    {"IsDisplayedFolded", new MemberRegisterInfo { Name = "IsDisplayedFolded", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsDisplayedFolded
#endif
                    }},
                    {"SetProcessInternal", new MemberRegisterInfo { Name = "SetProcessInternal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetProcessInternal
#endif
                    }},
                    {"IsProcessingInternal", new MemberRegisterInfo { Name = "IsProcessingInternal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsProcessingInternal
#endif
                    }},
                    {"SetPhysicsProcessInternal", new MemberRegisterInfo { Name = "SetPhysicsProcessInternal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetPhysicsProcessInternal
#endif
                    }},
                    {"IsPhysicsProcessingInternal", new MemberRegisterInfo { Name = "IsPhysicsProcessingInternal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsPhysicsProcessingInternal
#endif
                    }},
                    {"SetPhysicsInterpolationMode", new MemberRegisterInfo { Name = "SetPhysicsInterpolationMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetPhysicsInterpolationMode
#endif
                    }},
                    {"GetPhysicsInterpolationMode", new MemberRegisterInfo { Name = "GetPhysicsInterpolationMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetPhysicsInterpolationMode
#endif
                    }},
                    {"IsPhysicsInterpolated", new MemberRegisterInfo { Name = "IsPhysicsInterpolated", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsPhysicsInterpolated
#endif
                    }},
                    {"IsPhysicsInterpolatedAndEnabled", new MemberRegisterInfo { Name = "IsPhysicsInterpolatedAndEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsPhysicsInterpolatedAndEnabled
#endif
                    }},
                    {"ResetPhysicsInterpolation", new MemberRegisterInfo { Name = "ResetPhysicsInterpolation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_ResetPhysicsInterpolation
#endif
                    }},
                    {"SetAutoTranslateMode", new MemberRegisterInfo { Name = "SetAutoTranslateMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetAutoTranslateMode
#endif
                    }},
                    {"GetAutoTranslateMode", new MemberRegisterInfo { Name = "GetAutoTranslateMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetAutoTranslateMode
#endif
                    }},
                    {"CanAutoTranslate", new MemberRegisterInfo { Name = "CanAutoTranslate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_CanAutoTranslate
#endif
                    }},
                    {"SetTranslationDomainInherited", new MemberRegisterInfo { Name = "SetTranslationDomainInherited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetTranslationDomainInherited
#endif
                    }},
                    {"GetWindow", new MemberRegisterInfo { Name = "GetWindow", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetWindow
#endif
                    }},
                    {"GetLastExclusiveWindow", new MemberRegisterInfo { Name = "GetLastExclusiveWindow", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetLastExclusiveWindow
#endif
                    }},
                    {"GetTree", new MemberRegisterInfo { Name = "GetTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetTree
#endif
                    }},
                    {"CreateTween", new MemberRegisterInfo { Name = "CreateTween", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_CreateTween
#endif
                    }},
                    {"Duplicate", new MemberRegisterInfo { Name = "Duplicate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_Duplicate
#endif
                    }},
                    {"ReplaceBy", new MemberRegisterInfo { Name = "ReplaceBy", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_ReplaceBy
#endif
                    }},
                    {"SetSceneInstanceLoadPlaceholder", new MemberRegisterInfo { Name = "SetSceneInstanceLoadPlaceholder", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetSceneInstanceLoadPlaceholder
#endif
                    }},
                    {"GetSceneInstanceLoadPlaceholder", new MemberRegisterInfo { Name = "GetSceneInstanceLoadPlaceholder", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetSceneInstanceLoadPlaceholder
#endif
                    }},
                    {"SetEditableInstance", new MemberRegisterInfo { Name = "SetEditableInstance", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetEditableInstance
#endif
                    }},
                    {"IsEditableInstance", new MemberRegisterInfo { Name = "IsEditableInstance", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsEditableInstance
#endif
                    }},
                    {"GetViewport", new MemberRegisterInfo { Name = "GetViewport", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetViewport
#endif
                    }},
                    {"QueueFree", new MemberRegisterInfo { Name = "QueueFree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_QueueFree
#endif
                    }},
                    {"RequestReady", new MemberRegisterInfo { Name = "RequestReady", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_RequestReady
#endif
                    }},
                    {"IsNodeReady", new MemberRegisterInfo { Name = "IsNodeReady", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsNodeReady
#endif
                    }},
                    {"SetMultiplayerAuthority", new MemberRegisterInfo { Name = "SetMultiplayerAuthority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetMultiplayerAuthority
#endif
                    }},
                    {"GetMultiplayerAuthority", new MemberRegisterInfo { Name = "GetMultiplayerAuthority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetMultiplayerAuthority
#endif
                    }},
                    {"IsMultiplayerAuthority", new MemberRegisterInfo { Name = "IsMultiplayerAuthority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsMultiplayerAuthority
#endif
                    }},
                    {"GetMultiplayer", new MemberRegisterInfo { Name = "GetMultiplayer", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetMultiplayer
#endif
                    }},
                    {"RpcConfig", new MemberRegisterInfo { Name = "RpcConfig", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_RpcConfig
#endif
                    }},
                    {"GetNodeRpcConfig", new MemberRegisterInfo { Name = "GetNodeRpcConfig", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetNodeRpcConfig
#endif
                    }},
                    {"SetEditorDescription", new MemberRegisterInfo { Name = "SetEditorDescription", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetEditorDescription
#endif
                    }},
                    {"GetEditorDescription", new MemberRegisterInfo { Name = "GetEditorDescription", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetEditorDescription
#endif
                    }},
                    {"SetUniqueNameInOwner", new MemberRegisterInfo { Name = "SetUniqueNameInOwner", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetUniqueNameInOwner
#endif
                    }},
                    {"IsUniqueNameInOwner", new MemberRegisterInfo { Name = "IsUniqueNameInOwner", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_IsUniqueNameInOwner
#endif
                    }},
                    {"Atr", new MemberRegisterInfo { Name = "Atr", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_Atr
#endif
                    }},
                    {"AtrN", new MemberRegisterInfo { Name = "AtrN", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_AtrN
#endif
                    }},
                    {"Rpc", new MemberRegisterInfo { Name = "Rpc", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_Rpc
#endif
                    }},
                    {"RpcId", new MemberRegisterInfo { Name = "RpcId", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_RpcId
#endif
                    }},
                    {"UpdateConfigurationWarnings", new MemberRegisterInfo { Name = "UpdateConfigurationWarnings", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_UpdateConfigurationWarnings
#endif
                    }},
                    {"CallDeferredThreadGroup", new MemberRegisterInfo { Name = "CallDeferredThreadGroup", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_CallDeferredThreadGroup
#endif
                    }},
                    {"SetDeferredThreadGroup", new MemberRegisterInfo { Name = "SetDeferredThreadGroup", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetDeferredThreadGroup
#endif
                    }},
                    {"NotifyDeferredThreadGroup", new MemberRegisterInfo { Name = "NotifyDeferredThreadGroup", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_NotifyDeferredThreadGroup
#endif
                    }},
                    {"CallThreadSafe", new MemberRegisterInfo { Name = "CallThreadSafe", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_CallThreadSafe
#endif
                    }},
                    {"SetThreadSafe", new MemberRegisterInfo { Name = "SetThreadSafe", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_SetThreadSafe
#endif
                    }},
                    {"NotifyThreadSafe", new MemberRegisterInfo { Name = "NotifyThreadSafe", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_NotifyThreadSafe
#endif
                    }},
                    {"GetRpcConfig", new MemberRegisterInfo { Name = "GetRpcConfig", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.M_GetRpcConfig
#endif
                    }},
                    {"add_Ready", new MemberRegisterInfo { Name = "add_Ready", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_Ready
#endif
                    }},
                    {"remove_Ready", new MemberRegisterInfo { Name = "remove_Ready", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_Ready
#endif
                    }},
                    {"add_Renamed", new MemberRegisterInfo { Name = "add_Renamed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_Renamed
#endif
                    }},
                    {"remove_Renamed", new MemberRegisterInfo { Name = "remove_Renamed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_Renamed
#endif
                    }},
                    {"add_TreeEntered", new MemberRegisterInfo { Name = "add_TreeEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_TreeEntered
#endif
                    }},
                    {"remove_TreeEntered", new MemberRegisterInfo { Name = "remove_TreeEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_TreeEntered
#endif
                    }},
                    {"add_TreeExiting", new MemberRegisterInfo { Name = "add_TreeExiting", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_TreeExiting
#endif
                    }},
                    {"remove_TreeExiting", new MemberRegisterInfo { Name = "remove_TreeExiting", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_TreeExiting
#endif
                    }},
                    {"add_TreeExited", new MemberRegisterInfo { Name = "add_TreeExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_TreeExited
#endif
                    }},
                    {"remove_TreeExited", new MemberRegisterInfo { Name = "remove_TreeExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_TreeExited
#endif
                    }},
                    {"add_ChildEnteredTree", new MemberRegisterInfo { Name = "add_ChildEnteredTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_ChildEnteredTree
#endif
                    }},
                    {"remove_ChildEnteredTree", new MemberRegisterInfo { Name = "remove_ChildEnteredTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_ChildEnteredTree
#endif
                    }},
                    {"add_ChildExitingTree", new MemberRegisterInfo { Name = "add_ChildExitingTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_ChildExitingTree
#endif
                    }},
                    {"remove_ChildExitingTree", new MemberRegisterInfo { Name = "remove_ChildExitingTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_ChildExitingTree
#endif
                    }},
                    {"add_ChildOrderChanged", new MemberRegisterInfo { Name = "add_ChildOrderChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_ChildOrderChanged
#endif
                    }},
                    {"remove_ChildOrderChanged", new MemberRegisterInfo { Name = "remove_ChildOrderChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_ChildOrderChanged
#endif
                    }},
                    {"add_ReplacingBy", new MemberRegisterInfo { Name = "add_ReplacingBy", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_ReplacingBy
#endif
                    }},
                    {"remove_ReplacingBy", new MemberRegisterInfo { Name = "remove_ReplacingBy", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_ReplacingBy
#endif
                    }},
                    {"add_EditorDescriptionChanged", new MemberRegisterInfo { Name = "add_EditorDescriptionChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_EditorDescriptionChanged
#endif
                    }},
                    {"remove_EditorDescriptionChanged", new MemberRegisterInfo { Name = "remove_EditorDescriptionChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_EditorDescriptionChanged
#endif
                    }},
                    {"add_EditorStateChanged", new MemberRegisterInfo { Name = "add_EditorStateChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.A_EditorStateChanged
#endif
                    }},
                    {"remove_EditorStateChanged", new MemberRegisterInfo { Name = "remove_EditorStateChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.R_EditorStateChanged
#endif
                    }},
                    {"_ImportPath", new MemberRegisterInfo { Name = "_ImportPath", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G__ImportPath, PropertySetter = Godot_Node_Wrap.S__ImportPath
#endif
                    }},
                    {"Name", new MemberRegisterInfo { Name = "Name", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_Name, PropertySetter = Godot_Node_Wrap.S_Name
#endif
                    }},
                    {"UniqueNameInOwner", new MemberRegisterInfo { Name = "UniqueNameInOwner", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_UniqueNameInOwner, PropertySetter = Godot_Node_Wrap.S_UniqueNameInOwner
#endif
                    }},
                    {"SceneFilePath", new MemberRegisterInfo { Name = "SceneFilePath", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_SceneFilePath, PropertySetter = Godot_Node_Wrap.S_SceneFilePath
#endif
                    }},
                    {"Owner", new MemberRegisterInfo { Name = "Owner", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_Owner, PropertySetter = Godot_Node_Wrap.S_Owner
#endif
                    }},
                    {"Multiplayer", new MemberRegisterInfo { Name = "Multiplayer", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_Multiplayer
#endif
                    }},
                    {"ProcessMode", new MemberRegisterInfo { Name = "ProcessMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_ProcessMode, PropertySetter = Godot_Node_Wrap.S_ProcessMode
#endif
                    }},
                    {"ProcessPriority", new MemberRegisterInfo { Name = "ProcessPriority", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_ProcessPriority, PropertySetter = Godot_Node_Wrap.S_ProcessPriority
#endif
                    }},
                    {"ProcessPhysicsPriority", new MemberRegisterInfo { Name = "ProcessPhysicsPriority", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_ProcessPhysicsPriority, PropertySetter = Godot_Node_Wrap.S_ProcessPhysicsPriority
#endif
                    }},
                    {"ProcessThreadGroup", new MemberRegisterInfo { Name = "ProcessThreadGroup", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_ProcessThreadGroup, PropertySetter = Godot_Node_Wrap.S_ProcessThreadGroup
#endif
                    }},
                    {"ProcessThreadGroupOrder", new MemberRegisterInfo { Name = "ProcessThreadGroupOrder", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_ProcessThreadGroupOrder, PropertySetter = Godot_Node_Wrap.S_ProcessThreadGroupOrder
#endif
                    }},
                    {"ProcessThreadMessages", new MemberRegisterInfo { Name = "ProcessThreadMessages", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_ProcessThreadMessages, PropertySetter = Godot_Node_Wrap.S_ProcessThreadMessages
#endif
                    }},
                    {"PhysicsInterpolationMode", new MemberRegisterInfo { Name = "PhysicsInterpolationMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_PhysicsInterpolationMode, PropertySetter = Godot_Node_Wrap.S_PhysicsInterpolationMode
#endif
                    }},
                    {"AutoTranslateMode", new MemberRegisterInfo { Name = "AutoTranslateMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_AutoTranslateMode, PropertySetter = Godot_Node_Wrap.S_AutoTranslateMode
#endif
                    }},
                    {"EditorDescription", new MemberRegisterInfo { Name = "EditorDescription", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_EditorDescription, PropertySetter = Godot_Node_Wrap.S_EditorDescription
#endif
                    }},
                    {"PrintOrphanNodes_static", new MemberRegisterInfo { Name = "PrintOrphanNodes", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.F_PrintOrphanNodes
#endif
                    }},
                    {"GetOrphanNodeIds_static", new MemberRegisterInfo { Name = "GetOrphanNodeIds", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node_Wrap.F_GetOrphanNodeIds
#endif
                    }},
                    {"NotificationEnterTree_static", new MemberRegisterInfo { Name = "NotificationEnterTree", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationEnterTree
#endif
                    }},
                    {"NotificationExitTree_static", new MemberRegisterInfo { Name = "NotificationExitTree", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationExitTree
#endif
                    }},
                    {"NotificationReady_static", new MemberRegisterInfo { Name = "NotificationReady", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationReady
#endif
                    }},
                    {"NotificationPaused_static", new MemberRegisterInfo { Name = "NotificationPaused", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationPaused
#endif
                    }},
                    {"NotificationUnpaused_static", new MemberRegisterInfo { Name = "NotificationUnpaused", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationUnpaused
#endif
                    }},
                    {"NotificationPhysicsProcess_static", new MemberRegisterInfo { Name = "NotificationPhysicsProcess", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationPhysicsProcess
#endif
                    }},
                    {"NotificationProcess_static", new MemberRegisterInfo { Name = "NotificationProcess", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationProcess
#endif
                    }},
                    {"NotificationParented_static", new MemberRegisterInfo { Name = "NotificationParented", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationParented
#endif
                    }},
                    {"NotificationUnparented_static", new MemberRegisterInfo { Name = "NotificationUnparented", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationUnparented
#endif
                    }},
                    {"NotificationSceneInstantiated_static", new MemberRegisterInfo { Name = "NotificationSceneInstantiated", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationSceneInstantiated
#endif
                    }},
                    {"NotificationDragBegin_static", new MemberRegisterInfo { Name = "NotificationDragBegin", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationDragBegin
#endif
                    }},
                    {"NotificationDragEnd_static", new MemberRegisterInfo { Name = "NotificationDragEnd", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationDragEnd
#endif
                    }},
                    {"NotificationPathRenamed_static", new MemberRegisterInfo { Name = "NotificationPathRenamed", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationPathRenamed
#endif
                    }},
                    {"NotificationChildOrderChanged_static", new MemberRegisterInfo { Name = "NotificationChildOrderChanged", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationChildOrderChanged
#endif
                    }},
                    {"NotificationInternalProcess_static", new MemberRegisterInfo { Name = "NotificationInternalProcess", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationInternalProcess
#endif
                    }},
                    {"NotificationInternalPhysicsProcess_static", new MemberRegisterInfo { Name = "NotificationInternalPhysicsProcess", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationInternalPhysicsProcess
#endif
                    }},
                    {"NotificationPostEnterTree_static", new MemberRegisterInfo { Name = "NotificationPostEnterTree", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationPostEnterTree
#endif
                    }},
                    {"NotificationDisabled_static", new MemberRegisterInfo { Name = "NotificationDisabled", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationDisabled
#endif
                    }},
                    {"NotificationEnabled_static", new MemberRegisterInfo { Name = "NotificationEnabled", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationEnabled
#endif
                    }},
                    {"NotificationResetPhysicsInterpolation_static", new MemberRegisterInfo { Name = "NotificationResetPhysicsInterpolation", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationResetPhysicsInterpolation
#endif
                    }},
                    {"NotificationEditorPreSave_static", new MemberRegisterInfo { Name = "NotificationEditorPreSave", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationEditorPreSave
#endif
                    }},
                    {"NotificationEditorPostSave_static", new MemberRegisterInfo { Name = "NotificationEditorPostSave", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationEditorPostSave
#endif
                    }},
                    {"NotificationWMMouseEnter_static", new MemberRegisterInfo { Name = "NotificationWMMouseEnter", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationWMMouseEnter
#endif
                    }},
                    {"NotificationWMMouseExit_static", new MemberRegisterInfo { Name = "NotificationWMMouseExit", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationWMMouseExit
#endif
                    }},
                    {"NotificationWMWindowFocusIn_static", new MemberRegisterInfo { Name = "NotificationWMWindowFocusIn", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationWMWindowFocusIn
#endif
                    }},
                    {"NotificationWMWindowFocusOut_static", new MemberRegisterInfo { Name = "NotificationWMWindowFocusOut", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationWMWindowFocusOut
#endif
                    }},
                    {"NotificationWMCloseRequest_static", new MemberRegisterInfo { Name = "NotificationWMCloseRequest", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationWMCloseRequest
#endif
                    }},
                    {"NotificationWMGoBackRequest_static", new MemberRegisterInfo { Name = "NotificationWMGoBackRequest", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationWMGoBackRequest
#endif
                    }},
                    {"NotificationWMSizeChanged_static", new MemberRegisterInfo { Name = "NotificationWMSizeChanged", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationWMSizeChanged
#endif
                    }},
                    {"NotificationWMDpiChange_static", new MemberRegisterInfo { Name = "NotificationWMDpiChange", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationWMDpiChange
#endif
                    }},
                    {"NotificationVpMouseEnter_static", new MemberRegisterInfo { Name = "NotificationVpMouseEnter", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationVpMouseEnter
#endif
                    }},
                    {"NotificationVpMouseExit_static", new MemberRegisterInfo { Name = "NotificationVpMouseExit", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationVpMouseExit
#endif
                    }},
                    {"NotificationWMPositionChanged_static", new MemberRegisterInfo { Name = "NotificationWMPositionChanged", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationWMPositionChanged
#endif
                    }},
                    {"NotificationOsMemoryWarning_static", new MemberRegisterInfo { Name = "NotificationOsMemoryWarning", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationOsMemoryWarning
#endif
                    }},
                    {"NotificationTranslationChanged_static", new MemberRegisterInfo { Name = "NotificationTranslationChanged", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationTranslationChanged
#endif
                    }},
                    {"NotificationWMAbout_static", new MemberRegisterInfo { Name = "NotificationWMAbout", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationWMAbout
#endif
                    }},
                    {"NotificationCrash_static", new MemberRegisterInfo { Name = "NotificationCrash", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationCrash
#endif
                    }},
                    {"NotificationOsImeUpdate_static", new MemberRegisterInfo { Name = "NotificationOsImeUpdate", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationOsImeUpdate
#endif
                    }},
                    {"NotificationApplicationResumed_static", new MemberRegisterInfo { Name = "NotificationApplicationResumed", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationApplicationResumed
#endif
                    }},
                    {"NotificationApplicationPaused_static", new MemberRegisterInfo { Name = "NotificationApplicationPaused", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationApplicationPaused
#endif
                    }},
                    {"NotificationApplicationFocusIn_static", new MemberRegisterInfo { Name = "NotificationApplicationFocusIn", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationApplicationFocusIn
#endif
                    }},
                    {"NotificationApplicationFocusOut_static", new MemberRegisterInfo { Name = "NotificationApplicationFocusOut", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationApplicationFocusOut
#endif
                    }},
                    {"NotificationTextServerChanged_static", new MemberRegisterInfo { Name = "NotificationTextServerChanged", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationTextServerChanged
#endif
                    }},
                    {"NotificationAccessibilityUpdate_static", new MemberRegisterInfo { Name = "NotificationAccessibilityUpdate", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationAccessibilityUpdate
#endif
                    }},
                    {"NotificationAccessibilityInvalidate_static", new MemberRegisterInfo { Name = "NotificationAccessibilityInvalidate", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node_Wrap.G_NotificationAccessibilityInvalidate
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Node2D_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_Node2D_Wrap.Constructor
#endif
                    }},
                    {"SetPosition", new MemberRegisterInfo { Name = "SetPosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetPosition
#endif
                    }},
                    {"SetRotation", new MemberRegisterInfo { Name = "SetRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetRotation
#endif
                    }},
                    {"SetRotationDegrees", new MemberRegisterInfo { Name = "SetRotationDegrees", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetRotationDegrees
#endif
                    }},
                    {"SetSkew", new MemberRegisterInfo { Name = "SetSkew", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetSkew
#endif
                    }},
                    {"SetScale", new MemberRegisterInfo { Name = "SetScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetScale
#endif
                    }},
                    {"GetPosition", new MemberRegisterInfo { Name = "GetPosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetPosition
#endif
                    }},
                    {"GetRotation", new MemberRegisterInfo { Name = "GetRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetRotation
#endif
                    }},
                    {"GetRotationDegrees", new MemberRegisterInfo { Name = "GetRotationDegrees", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetRotationDegrees
#endif
                    }},
                    {"GetSkew", new MemberRegisterInfo { Name = "GetSkew", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetSkew
#endif
                    }},
                    {"GetScale", new MemberRegisterInfo { Name = "GetScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetScale
#endif
                    }},
                    {"Rotate", new MemberRegisterInfo { Name = "Rotate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_Rotate
#endif
                    }},
                    {"MoveLocalX", new MemberRegisterInfo { Name = "MoveLocalX", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_MoveLocalX
#endif
                    }},
                    {"MoveLocalY", new MemberRegisterInfo { Name = "MoveLocalY", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_MoveLocalY
#endif
                    }},
                    {"Translate", new MemberRegisterInfo { Name = "Translate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_Translate
#endif
                    }},
                    {"GlobalTranslate", new MemberRegisterInfo { Name = "GlobalTranslate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GlobalTranslate
#endif
                    }},
                    {"ApplyScale", new MemberRegisterInfo { Name = "ApplyScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_ApplyScale
#endif
                    }},
                    {"SetGlobalPosition", new MemberRegisterInfo { Name = "SetGlobalPosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetGlobalPosition
#endif
                    }},
                    {"GetGlobalPosition", new MemberRegisterInfo { Name = "GetGlobalPosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetGlobalPosition
#endif
                    }},
                    {"SetGlobalRotation", new MemberRegisterInfo { Name = "SetGlobalRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetGlobalRotation
#endif
                    }},
                    {"SetGlobalRotationDegrees", new MemberRegisterInfo { Name = "SetGlobalRotationDegrees", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetGlobalRotationDegrees
#endif
                    }},
                    {"GetGlobalRotation", new MemberRegisterInfo { Name = "GetGlobalRotation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetGlobalRotation
#endif
                    }},
                    {"GetGlobalRotationDegrees", new MemberRegisterInfo { Name = "GetGlobalRotationDegrees", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetGlobalRotationDegrees
#endif
                    }},
                    {"SetGlobalSkew", new MemberRegisterInfo { Name = "SetGlobalSkew", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetGlobalSkew
#endif
                    }},
                    {"GetGlobalSkew", new MemberRegisterInfo { Name = "GetGlobalSkew", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetGlobalSkew
#endif
                    }},
                    {"SetGlobalScale", new MemberRegisterInfo { Name = "SetGlobalScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetGlobalScale
#endif
                    }},
                    {"GetGlobalScale", new MemberRegisterInfo { Name = "GetGlobalScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetGlobalScale
#endif
                    }},
                    {"SetTransform", new MemberRegisterInfo { Name = "SetTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetTransform
#endif
                    }},
                    {"SetGlobalTransform", new MemberRegisterInfo { Name = "SetGlobalTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_SetGlobalTransform
#endif
                    }},
                    {"LookAt", new MemberRegisterInfo { Name = "LookAt", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_LookAt
#endif
                    }},
                    {"GetAngleTo", new MemberRegisterInfo { Name = "GetAngleTo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetAngleTo
#endif
                    }},
                    {"ToLocal", new MemberRegisterInfo { Name = "ToLocal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_ToLocal
#endif
                    }},
                    {"ToGlobal", new MemberRegisterInfo { Name = "ToGlobal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_ToGlobal
#endif
                    }},
                    {"GetRelativeTransformToParent", new MemberRegisterInfo { Name = "GetRelativeTransformToParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Node2D_Wrap.M_GetRelativeTransformToParent
#endif
                    }},
                    {"Position", new MemberRegisterInfo { Name = "Position", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_Position, PropertySetter = Godot_Node2D_Wrap.S_Position
#endif
                    }},
                    {"Rotation", new MemberRegisterInfo { Name = "Rotation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_Rotation, PropertySetter = Godot_Node2D_Wrap.S_Rotation
#endif
                    }},
                    {"RotationDegrees", new MemberRegisterInfo { Name = "RotationDegrees", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_RotationDegrees, PropertySetter = Godot_Node2D_Wrap.S_RotationDegrees
#endif
                    }},
                    {"Scale", new MemberRegisterInfo { Name = "Scale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_Scale, PropertySetter = Godot_Node2D_Wrap.S_Scale
#endif
                    }},
                    {"Skew", new MemberRegisterInfo { Name = "Skew", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_Skew, PropertySetter = Godot_Node2D_Wrap.S_Skew
#endif
                    }},
                    {"Transform", new MemberRegisterInfo { Name = "Transform", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_Transform, PropertySetter = Godot_Node2D_Wrap.S_Transform
#endif
                    }},
                    {"GlobalPosition", new MemberRegisterInfo { Name = "GlobalPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_GlobalPosition, PropertySetter = Godot_Node2D_Wrap.S_GlobalPosition
#endif
                    }},
                    {"GlobalRotation", new MemberRegisterInfo { Name = "GlobalRotation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_GlobalRotation, PropertySetter = Godot_Node2D_Wrap.S_GlobalRotation
#endif
                    }},
                    {"GlobalRotationDegrees", new MemberRegisterInfo { Name = "GlobalRotationDegrees", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_GlobalRotationDegrees, PropertySetter = Godot_Node2D_Wrap.S_GlobalRotationDegrees
#endif
                    }},
                    {"GlobalScale", new MemberRegisterInfo { Name = "GlobalScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_GlobalScale, PropertySetter = Godot_Node2D_Wrap.S_GlobalScale
#endif
                    }},
                    {"GlobalSkew", new MemberRegisterInfo { Name = "GlobalSkew", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_GlobalSkew, PropertySetter = Godot_Node2D_Wrap.S_GlobalSkew
#endif
                    }},
                    {"GlobalTransform", new MemberRegisterInfo { Name = "GlobalTransform", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Node2D_Wrap.G_GlobalTransform, PropertySetter = Godot_Node2D_Wrap.S_GlobalTransform
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Vector2_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_Vector2_Wrap.Constructor
#endif
                    }},
                    {"Deconstruct", new MemberRegisterInfo { Name = "Deconstruct", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Deconstruct
#endif
                    }},
                    {"Abs", new MemberRegisterInfo { Name = "Abs", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Abs
#endif
                    }},
                    {"Angle", new MemberRegisterInfo { Name = "Angle", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Angle
#endif
                    }},
                    {"AngleTo", new MemberRegisterInfo { Name = "AngleTo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_AngleTo
#endif
                    }},
                    {"AngleToPoint", new MemberRegisterInfo { Name = "AngleToPoint", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_AngleToPoint
#endif
                    }},
                    {"Aspect", new MemberRegisterInfo { Name = "Aspect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Aspect
#endif
                    }},
                    {"Bounce", new MemberRegisterInfo { Name = "Bounce", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Bounce
#endif
                    }},
                    {"Ceil", new MemberRegisterInfo { Name = "Ceil", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Ceil
#endif
                    }},
                    {"Clamp", new MemberRegisterInfo { Name = "Clamp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Clamp
#endif
                    }},
                    {"Cross", new MemberRegisterInfo { Name = "Cross", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Cross
#endif
                    }},
                    {"CubicInterpolate", new MemberRegisterInfo { Name = "CubicInterpolate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_CubicInterpolate
#endif
                    }},
                    {"CubicInterpolateInTime", new MemberRegisterInfo { Name = "CubicInterpolateInTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_CubicInterpolateInTime
#endif
                    }},
                    {"BezierInterpolate", new MemberRegisterInfo { Name = "BezierInterpolate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_BezierInterpolate
#endif
                    }},
                    {"BezierDerivative", new MemberRegisterInfo { Name = "BezierDerivative", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_BezierDerivative
#endif
                    }},
                    {"DirectionTo", new MemberRegisterInfo { Name = "DirectionTo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_DirectionTo
#endif
                    }},
                    {"DistanceSquaredTo", new MemberRegisterInfo { Name = "DistanceSquaredTo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_DistanceSquaredTo
#endif
                    }},
                    {"DistanceTo", new MemberRegisterInfo { Name = "DistanceTo", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_DistanceTo
#endif
                    }},
                    {"Dot", new MemberRegisterInfo { Name = "Dot", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Dot
#endif
                    }},
                    {"Floor", new MemberRegisterInfo { Name = "Floor", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Floor
#endif
                    }},
                    {"Inverse", new MemberRegisterInfo { Name = "Inverse", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Inverse
#endif
                    }},
                    {"IsFinite", new MemberRegisterInfo { Name = "IsFinite", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_IsFinite
#endif
                    }},
                    {"IsNormalized", new MemberRegisterInfo { Name = "IsNormalized", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_IsNormalized
#endif
                    }},
                    {"Length", new MemberRegisterInfo { Name = "Length", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Length
#endif
                    }},
                    {"LengthSquared", new MemberRegisterInfo { Name = "LengthSquared", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_LengthSquared
#endif
                    }},
                    {"Lerp", new MemberRegisterInfo { Name = "Lerp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Lerp
#endif
                    }},
                    {"LimitLength", new MemberRegisterInfo { Name = "LimitLength", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_LimitLength
#endif
                    }},
                    {"Max", new MemberRegisterInfo { Name = "Max", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Max
#endif
                    }},
                    {"Min", new MemberRegisterInfo { Name = "Min", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Min
#endif
                    }},
                    {"MaxAxisIndex", new MemberRegisterInfo { Name = "MaxAxisIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_MaxAxisIndex
#endif
                    }},
                    {"MinAxisIndex", new MemberRegisterInfo { Name = "MinAxisIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_MinAxisIndex
#endif
                    }},
                    {"MoveToward", new MemberRegisterInfo { Name = "MoveToward", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_MoveToward
#endif
                    }},
                    {"Normalized", new MemberRegisterInfo { Name = "Normalized", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Normalized
#endif
                    }},
                    {"PosMod", new MemberRegisterInfo { Name = "PosMod", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_PosMod
#endif
                    }},
                    {"Project", new MemberRegisterInfo { Name = "Project", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Project
#endif
                    }},
                    {"Reflect", new MemberRegisterInfo { Name = "Reflect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Reflect
#endif
                    }},
                    {"Rotated", new MemberRegisterInfo { Name = "Rotated", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Rotated
#endif
                    }},
                    {"Round", new MemberRegisterInfo { Name = "Round", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Round
#endif
                    }},
                    {"Sign", new MemberRegisterInfo { Name = "Sign", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Sign
#endif
                    }},
                    {"Slerp", new MemberRegisterInfo { Name = "Slerp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Slerp
#endif
                    }},
                    {"Slide", new MemberRegisterInfo { Name = "Slide", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Slide
#endif
                    }},
                    {"Snapped", new MemberRegisterInfo { Name = "Snapped", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Snapped
#endif
                    }},
                    {"Orthogonal", new MemberRegisterInfo { Name = "Orthogonal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Orthogonal
#endif
                    }},
                    {"op_Addition_static", new MemberRegisterInfo { Name = "op_Addition", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_Addition
#endif
                    }},
                    {"op_Subtraction_static", new MemberRegisterInfo { Name = "op_Subtraction", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_Subtraction
#endif
                    }},
                    {"op_UnaryNegation_static", new MemberRegisterInfo { Name = "op_UnaryNegation", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_UnaryNegation
#endif
                    }},
                    {"op_Multiply_static", new MemberRegisterInfo { Name = "op_Multiply", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_Multiply
#endif
                    }},
                    {"op_Division_static", new MemberRegisterInfo { Name = "op_Division", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_Division
#endif
                    }},
                    {"op_Modulus_static", new MemberRegisterInfo { Name = "op_Modulus", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_Modulus
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_Inequality
#endif
                    }},
                    {"op_LessThan_static", new MemberRegisterInfo { Name = "op_LessThan", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_LessThan
#endif
                    }},
                    {"op_GreaterThan_static", new MemberRegisterInfo { Name = "op_GreaterThan", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_GreaterThan
#endif
                    }},
                    {"op_LessThanOrEqual_static", new MemberRegisterInfo { Name = "op_LessThanOrEqual", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_LessThanOrEqual
#endif
                    }},
                    {"op_GreaterThanOrEqual_static", new MemberRegisterInfo { Name = "op_GreaterThanOrEqual", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.O_op_GreaterThanOrEqual
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_Equals
#endif
                    }},
                    {"IsEqualApprox", new MemberRegisterInfo { Name = "IsEqualApprox", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_IsEqualApprox
#endif
                    }},
                    {"IsZeroApprox", new MemberRegisterInfo { Name = "IsZeroApprox", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_IsZeroApprox
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_GetHashCode
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.M_ToString
#endif
                    }},
                    {"get_Item", new MemberRegisterInfo { Name = "get_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.GetItem
#endif
                    }},
                    {"set_Item", new MemberRegisterInfo { Name = "set_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.SetItem
#endif
                    }},
                    {"X", new MemberRegisterInfo { Name = "X", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Vector2_Wrap.G_X, PropertySetter = Godot_Vector2_Wrap.S_X
#endif
                    }},
                    {"Y", new MemberRegisterInfo { Name = "Y", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Vector2_Wrap.G_Y, PropertySetter = Godot_Vector2_Wrap.S_Y
#endif
                    }},
                    {"FromAngle_static", new MemberRegisterInfo { Name = "FromAngle", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Vector2_Wrap.F_FromAngle
#endif
                    }},
                    {"Zero_static", new MemberRegisterInfo { Name = "Zero", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Vector2_Wrap.G_Zero
#endif
                    }},
                    {"One_static", new MemberRegisterInfo { Name = "One", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Vector2_Wrap.G_One
#endif
                    }},
                    {"Inf_static", new MemberRegisterInfo { Name = "Inf", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Vector2_Wrap.G_Inf
#endif
                    }},
                    {"Up_static", new MemberRegisterInfo { Name = "Up", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Vector2_Wrap.G_Up
#endif
                    }},
                    {"Down_static", new MemberRegisterInfo { Name = "Down", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Vector2_Wrap.G_Down
#endif
                    }},
                    {"Right_static", new MemberRegisterInfo { Name = "Right", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Vector2_Wrap.G_Right
#endif
                    }},
                    {"Left_static", new MemberRegisterInfo { Name = "Left", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Vector2_Wrap.G_Left
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Area2D_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_Area2D_Wrap.Constructor
#endif
                    }},
                    {"SetGravitySpaceOverrideMode", new MemberRegisterInfo { Name = "SetGravitySpaceOverrideMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetGravitySpaceOverrideMode
#endif
                    }},
                    {"GetGravitySpaceOverrideMode", new MemberRegisterInfo { Name = "GetGravitySpaceOverrideMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetGravitySpaceOverrideMode
#endif
                    }},
                    {"SetGravityIsPoint", new MemberRegisterInfo { Name = "SetGravityIsPoint", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetGravityIsPoint
#endif
                    }},
                    {"IsGravityAPoint", new MemberRegisterInfo { Name = "IsGravityAPoint", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_IsGravityAPoint
#endif
                    }},
                    {"SetGravityPointUnitDistance", new MemberRegisterInfo { Name = "SetGravityPointUnitDistance", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetGravityPointUnitDistance
#endif
                    }},
                    {"GetGravityPointUnitDistance", new MemberRegisterInfo { Name = "GetGravityPointUnitDistance", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetGravityPointUnitDistance
#endif
                    }},
                    {"SetGravityPointCenter", new MemberRegisterInfo { Name = "SetGravityPointCenter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetGravityPointCenter
#endif
                    }},
                    {"GetGravityPointCenter", new MemberRegisterInfo { Name = "GetGravityPointCenter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetGravityPointCenter
#endif
                    }},
                    {"SetGravityDirection", new MemberRegisterInfo { Name = "SetGravityDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetGravityDirection
#endif
                    }},
                    {"GetGravityDirection", new MemberRegisterInfo { Name = "GetGravityDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetGravityDirection
#endif
                    }},
                    {"SetGravity", new MemberRegisterInfo { Name = "SetGravity", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetGravity
#endif
                    }},
                    {"GetGravity", new MemberRegisterInfo { Name = "GetGravity", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetGravity
#endif
                    }},
                    {"SetLinearDampSpaceOverrideMode", new MemberRegisterInfo { Name = "SetLinearDampSpaceOverrideMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetLinearDampSpaceOverrideMode
#endif
                    }},
                    {"GetLinearDampSpaceOverrideMode", new MemberRegisterInfo { Name = "GetLinearDampSpaceOverrideMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetLinearDampSpaceOverrideMode
#endif
                    }},
                    {"SetAngularDampSpaceOverrideMode", new MemberRegisterInfo { Name = "SetAngularDampSpaceOverrideMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetAngularDampSpaceOverrideMode
#endif
                    }},
                    {"GetAngularDampSpaceOverrideMode", new MemberRegisterInfo { Name = "GetAngularDampSpaceOverrideMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetAngularDampSpaceOverrideMode
#endif
                    }},
                    {"SetLinearDamp", new MemberRegisterInfo { Name = "SetLinearDamp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetLinearDamp
#endif
                    }},
                    {"GetLinearDamp", new MemberRegisterInfo { Name = "GetLinearDamp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetLinearDamp
#endif
                    }},
                    {"SetAngularDamp", new MemberRegisterInfo { Name = "SetAngularDamp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetAngularDamp
#endif
                    }},
                    {"GetAngularDamp", new MemberRegisterInfo { Name = "GetAngularDamp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetAngularDamp
#endif
                    }},
                    {"SetPriority", new MemberRegisterInfo { Name = "SetPriority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetPriority
#endif
                    }},
                    {"GetPriority", new MemberRegisterInfo { Name = "GetPriority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetPriority
#endif
                    }},
                    {"SetMonitoring", new MemberRegisterInfo { Name = "SetMonitoring", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetMonitoring
#endif
                    }},
                    {"IsMonitoring", new MemberRegisterInfo { Name = "IsMonitoring", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_IsMonitoring
#endif
                    }},
                    {"SetMonitorable", new MemberRegisterInfo { Name = "SetMonitorable", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetMonitorable
#endif
                    }},
                    {"IsMonitorable", new MemberRegisterInfo { Name = "IsMonitorable", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_IsMonitorable
#endif
                    }},
                    {"GetOverlappingBodies", new MemberRegisterInfo { Name = "GetOverlappingBodies", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetOverlappingBodies
#endif
                    }},
                    {"GetOverlappingAreas", new MemberRegisterInfo { Name = "GetOverlappingAreas", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetOverlappingAreas
#endif
                    }},
                    {"HasOverlappingBodies", new MemberRegisterInfo { Name = "HasOverlappingBodies", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_HasOverlappingBodies
#endif
                    }},
                    {"HasOverlappingAreas", new MemberRegisterInfo { Name = "HasOverlappingAreas", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_HasOverlappingAreas
#endif
                    }},
                    {"OverlapsBody", new MemberRegisterInfo { Name = "OverlapsBody", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_OverlapsBody
#endif
                    }},
                    {"OverlapsArea", new MemberRegisterInfo { Name = "OverlapsArea", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_OverlapsArea
#endif
                    }},
                    {"SetAudioBusName", new MemberRegisterInfo { Name = "SetAudioBusName", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetAudioBusName
#endif
                    }},
                    {"GetAudioBusName", new MemberRegisterInfo { Name = "GetAudioBusName", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_GetAudioBusName
#endif
                    }},
                    {"SetAudioBusOverride", new MemberRegisterInfo { Name = "SetAudioBusOverride", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_SetAudioBusOverride
#endif
                    }},
                    {"IsOverridingAudioBus", new MemberRegisterInfo { Name = "IsOverridingAudioBus", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.M_IsOverridingAudioBus
#endif
                    }},
                    {"add_BodyShapeEntered", new MemberRegisterInfo { Name = "add_BodyShapeEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.A_BodyShapeEntered
#endif
                    }},
                    {"remove_BodyShapeEntered", new MemberRegisterInfo { Name = "remove_BodyShapeEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.R_BodyShapeEntered
#endif
                    }},
                    {"add_BodyShapeExited", new MemberRegisterInfo { Name = "add_BodyShapeExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.A_BodyShapeExited
#endif
                    }},
                    {"remove_BodyShapeExited", new MemberRegisterInfo { Name = "remove_BodyShapeExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.R_BodyShapeExited
#endif
                    }},
                    {"add_BodyEntered", new MemberRegisterInfo { Name = "add_BodyEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.A_BodyEntered
#endif
                    }},
                    {"remove_BodyEntered", new MemberRegisterInfo { Name = "remove_BodyEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.R_BodyEntered
#endif
                    }},
                    {"add_BodyExited", new MemberRegisterInfo { Name = "add_BodyExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.A_BodyExited
#endif
                    }},
                    {"remove_BodyExited", new MemberRegisterInfo { Name = "remove_BodyExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.R_BodyExited
#endif
                    }},
                    {"add_AreaShapeEntered", new MemberRegisterInfo { Name = "add_AreaShapeEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.A_AreaShapeEntered
#endif
                    }},
                    {"remove_AreaShapeEntered", new MemberRegisterInfo { Name = "remove_AreaShapeEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.R_AreaShapeEntered
#endif
                    }},
                    {"add_AreaShapeExited", new MemberRegisterInfo { Name = "add_AreaShapeExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.A_AreaShapeExited
#endif
                    }},
                    {"remove_AreaShapeExited", new MemberRegisterInfo { Name = "remove_AreaShapeExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.R_AreaShapeExited
#endif
                    }},
                    {"add_AreaEntered", new MemberRegisterInfo { Name = "add_AreaEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.A_AreaEntered
#endif
                    }},
                    {"remove_AreaEntered", new MemberRegisterInfo { Name = "remove_AreaEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.R_AreaEntered
#endif
                    }},
                    {"add_AreaExited", new MemberRegisterInfo { Name = "add_AreaExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.A_AreaExited
#endif
                    }},
                    {"remove_AreaExited", new MemberRegisterInfo { Name = "remove_AreaExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Area2D_Wrap.R_AreaExited
#endif
                    }},
                    {"Monitoring", new MemberRegisterInfo { Name = "Monitoring", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_Monitoring, PropertySetter = Godot_Area2D_Wrap.S_Monitoring
#endif
                    }},
                    {"Monitorable", new MemberRegisterInfo { Name = "Monitorable", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_Monitorable, PropertySetter = Godot_Area2D_Wrap.S_Monitorable
#endif
                    }},
                    {"Priority", new MemberRegisterInfo { Name = "Priority", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_Priority, PropertySetter = Godot_Area2D_Wrap.S_Priority
#endif
                    }},
                    {"GravitySpaceOverride", new MemberRegisterInfo { Name = "GravitySpaceOverride", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_GravitySpaceOverride, PropertySetter = Godot_Area2D_Wrap.S_GravitySpaceOverride
#endif
                    }},
                    {"GravityPoint", new MemberRegisterInfo { Name = "GravityPoint", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_GravityPoint, PropertySetter = Godot_Area2D_Wrap.S_GravityPoint
#endif
                    }},
                    {"GravityPointUnitDistance", new MemberRegisterInfo { Name = "GravityPointUnitDistance", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_GravityPointUnitDistance, PropertySetter = Godot_Area2D_Wrap.S_GravityPointUnitDistance
#endif
                    }},
                    {"GravityPointCenter", new MemberRegisterInfo { Name = "GravityPointCenter", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_GravityPointCenter, PropertySetter = Godot_Area2D_Wrap.S_GravityPointCenter
#endif
                    }},
                    {"GravityDirection", new MemberRegisterInfo { Name = "GravityDirection", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_GravityDirection, PropertySetter = Godot_Area2D_Wrap.S_GravityDirection
#endif
                    }},
                    {"Gravity", new MemberRegisterInfo { Name = "Gravity", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_Gravity, PropertySetter = Godot_Area2D_Wrap.S_Gravity
#endif
                    }},
                    {"LinearDampSpaceOverride", new MemberRegisterInfo { Name = "LinearDampSpaceOverride", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_LinearDampSpaceOverride, PropertySetter = Godot_Area2D_Wrap.S_LinearDampSpaceOverride
#endif
                    }},
                    {"LinearDamp", new MemberRegisterInfo { Name = "LinearDamp", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_LinearDamp, PropertySetter = Godot_Area2D_Wrap.S_LinearDamp
#endif
                    }},
                    {"AngularDampSpaceOverride", new MemberRegisterInfo { Name = "AngularDampSpaceOverride", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_AngularDampSpaceOverride, PropertySetter = Godot_Area2D_Wrap.S_AngularDampSpaceOverride
#endif
                    }},
                    {"AngularDamp", new MemberRegisterInfo { Name = "AngularDamp", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_AngularDamp, PropertySetter = Godot_Area2D_Wrap.S_AngularDamp
#endif
                    }},
                    {"AudioBusOverride", new MemberRegisterInfo { Name = "AudioBusOverride", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_AudioBusOverride, PropertySetter = Godot_Area2D_Wrap.S_AudioBusOverride
#endif
                    }},
                    {"AudioBusName", new MemberRegisterInfo { Name = "AudioBusName", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Area2D_Wrap.G_AudioBusName, PropertySetter = Godot_Area2D_Wrap.S_AudioBusName
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Sprite2D_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_Sprite2D_Wrap.Constructor
#endif
                    }},
                    {"SetTexture", new MemberRegisterInfo { Name = "SetTexture", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetTexture
#endif
                    }},
                    {"GetTexture", new MemberRegisterInfo { Name = "GetTexture", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_GetTexture
#endif
                    }},
                    {"SetCentered", new MemberRegisterInfo { Name = "SetCentered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetCentered
#endif
                    }},
                    {"IsCentered", new MemberRegisterInfo { Name = "IsCentered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_IsCentered
#endif
                    }},
                    {"SetOffset", new MemberRegisterInfo { Name = "SetOffset", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetOffset
#endif
                    }},
                    {"GetOffset", new MemberRegisterInfo { Name = "GetOffset", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_GetOffset
#endif
                    }},
                    {"SetFlipH", new MemberRegisterInfo { Name = "SetFlipH", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetFlipH
#endif
                    }},
                    {"IsFlippedH", new MemberRegisterInfo { Name = "IsFlippedH", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_IsFlippedH
#endif
                    }},
                    {"SetFlipV", new MemberRegisterInfo { Name = "SetFlipV", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetFlipV
#endif
                    }},
                    {"IsFlippedV", new MemberRegisterInfo { Name = "IsFlippedV", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_IsFlippedV
#endif
                    }},
                    {"SetRegionEnabled", new MemberRegisterInfo { Name = "SetRegionEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetRegionEnabled
#endif
                    }},
                    {"IsRegionEnabled", new MemberRegisterInfo { Name = "IsRegionEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_IsRegionEnabled
#endif
                    }},
                    {"IsPixelOpaque", new MemberRegisterInfo { Name = "IsPixelOpaque", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_IsPixelOpaque
#endif
                    }},
                    {"SetRegionRect", new MemberRegisterInfo { Name = "SetRegionRect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetRegionRect
#endif
                    }},
                    {"GetRegionRect", new MemberRegisterInfo { Name = "GetRegionRect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_GetRegionRect
#endif
                    }},
                    {"SetRegionFilterClipEnabled", new MemberRegisterInfo { Name = "SetRegionFilterClipEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetRegionFilterClipEnabled
#endif
                    }},
                    {"IsRegionFilterClipEnabled", new MemberRegisterInfo { Name = "IsRegionFilterClipEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_IsRegionFilterClipEnabled
#endif
                    }},
                    {"SetFrame", new MemberRegisterInfo { Name = "SetFrame", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetFrame
#endif
                    }},
                    {"GetFrame", new MemberRegisterInfo { Name = "GetFrame", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_GetFrame
#endif
                    }},
                    {"SetFrameCoords", new MemberRegisterInfo { Name = "SetFrameCoords", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetFrameCoords
#endif
                    }},
                    {"GetFrameCoords", new MemberRegisterInfo { Name = "GetFrameCoords", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_GetFrameCoords
#endif
                    }},
                    {"SetVframes", new MemberRegisterInfo { Name = "SetVframes", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetVframes
#endif
                    }},
                    {"GetVframes", new MemberRegisterInfo { Name = "GetVframes", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_GetVframes
#endif
                    }},
                    {"SetHframes", new MemberRegisterInfo { Name = "SetHframes", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_SetHframes
#endif
                    }},
                    {"GetHframes", new MemberRegisterInfo { Name = "GetHframes", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_GetHframes
#endif
                    }},
                    {"GetRect", new MemberRegisterInfo { Name = "GetRect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.M_GetRect
#endif
                    }},
                    {"add_FrameChanged", new MemberRegisterInfo { Name = "add_FrameChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.A_FrameChanged
#endif
                    }},
                    {"remove_FrameChanged", new MemberRegisterInfo { Name = "remove_FrameChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.R_FrameChanged
#endif
                    }},
                    {"add_TextureChanged", new MemberRegisterInfo { Name = "add_TextureChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.A_TextureChanged
#endif
                    }},
                    {"remove_TextureChanged", new MemberRegisterInfo { Name = "remove_TextureChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Sprite2D_Wrap.R_TextureChanged
#endif
                    }},
                    {"Texture", new MemberRegisterInfo { Name = "Texture", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_Texture, PropertySetter = Godot_Sprite2D_Wrap.S_Texture
#endif
                    }},
                    {"Centered", new MemberRegisterInfo { Name = "Centered", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_Centered, PropertySetter = Godot_Sprite2D_Wrap.S_Centered
#endif
                    }},
                    {"Offset", new MemberRegisterInfo { Name = "Offset", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_Offset, PropertySetter = Godot_Sprite2D_Wrap.S_Offset
#endif
                    }},
                    {"FlipH", new MemberRegisterInfo { Name = "FlipH", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_FlipH, PropertySetter = Godot_Sprite2D_Wrap.S_FlipH
#endif
                    }},
                    {"FlipV", new MemberRegisterInfo { Name = "FlipV", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_FlipV, PropertySetter = Godot_Sprite2D_Wrap.S_FlipV
#endif
                    }},
                    {"Hframes", new MemberRegisterInfo { Name = "Hframes", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_Hframes, PropertySetter = Godot_Sprite2D_Wrap.S_Hframes
#endif
                    }},
                    {"Vframes", new MemberRegisterInfo { Name = "Vframes", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_Vframes, PropertySetter = Godot_Sprite2D_Wrap.S_Vframes
#endif
                    }},
                    {"Frame", new MemberRegisterInfo { Name = "Frame", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_Frame, PropertySetter = Godot_Sprite2D_Wrap.S_Frame
#endif
                    }},
                    {"FrameCoords", new MemberRegisterInfo { Name = "FrameCoords", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_FrameCoords, PropertySetter = Godot_Sprite2D_Wrap.S_FrameCoords
#endif
                    }},
                    {"RegionEnabled", new MemberRegisterInfo { Name = "RegionEnabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_RegionEnabled, PropertySetter = Godot_Sprite2D_Wrap.S_RegionEnabled
#endif
                    }},
                    {"RegionRect", new MemberRegisterInfo { Name = "RegionRect", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_RegionRect, PropertySetter = Godot_Sprite2D_Wrap.S_RegionRect
#endif
                    }},
                    {"RegionFilterClipEnabled", new MemberRegisterInfo { Name = "RegionFilterClipEnabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Sprite2D_Wrap.G_RegionFilterClipEnabled, PropertySetter = Godot_Sprite2D_Wrap.S_RegionFilterClipEnabled
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_AnimationPlayer_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_AnimationPlayer_Wrap.Constructor
#endif
                    }},
                    {"AnimationSetNext", new MemberRegisterInfo { Name = "AnimationSetNext", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_AnimationSetNext
#endif
                    }},
                    {"AnimationGetNext", new MemberRegisterInfo { Name = "AnimationGetNext", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_AnimationGetNext
#endif
                    }},
                    {"SetBlendTime", new MemberRegisterInfo { Name = "SetBlendTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetBlendTime
#endif
                    }},
                    {"GetBlendTime", new MemberRegisterInfo { Name = "GetBlendTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetBlendTime
#endif
                    }},
                    {"SetDefaultBlendTime", new MemberRegisterInfo { Name = "SetDefaultBlendTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetDefaultBlendTime
#endif
                    }},
                    {"GetDefaultBlendTime", new MemberRegisterInfo { Name = "GetDefaultBlendTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetDefaultBlendTime
#endif
                    }},
                    {"SetAutoCapture", new MemberRegisterInfo { Name = "SetAutoCapture", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetAutoCapture
#endif
                    }},
                    {"IsAutoCapture", new MemberRegisterInfo { Name = "IsAutoCapture", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_IsAutoCapture
#endif
                    }},
                    {"SetAutoCaptureDuration", new MemberRegisterInfo { Name = "SetAutoCaptureDuration", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetAutoCaptureDuration
#endif
                    }},
                    {"GetAutoCaptureDuration", new MemberRegisterInfo { Name = "GetAutoCaptureDuration", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetAutoCaptureDuration
#endif
                    }},
                    {"SetAutoCaptureTransitionType", new MemberRegisterInfo { Name = "SetAutoCaptureTransitionType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetAutoCaptureTransitionType
#endif
                    }},
                    {"GetAutoCaptureTransitionType", new MemberRegisterInfo { Name = "GetAutoCaptureTransitionType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetAutoCaptureTransitionType
#endif
                    }},
                    {"SetAutoCaptureEaseType", new MemberRegisterInfo { Name = "SetAutoCaptureEaseType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetAutoCaptureEaseType
#endif
                    }},
                    {"GetAutoCaptureEaseType", new MemberRegisterInfo { Name = "GetAutoCaptureEaseType", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetAutoCaptureEaseType
#endif
                    }},
                    {"Play", new MemberRegisterInfo { Name = "Play", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_Play
#endif
                    }},
                    {"PlaySectionWithMarkers", new MemberRegisterInfo { Name = "PlaySectionWithMarkers", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_PlaySectionWithMarkers
#endif
                    }},
                    {"PlaySection", new MemberRegisterInfo { Name = "PlaySection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_PlaySection
#endif
                    }},
                    {"PlayBackwards", new MemberRegisterInfo { Name = "PlayBackwards", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_PlayBackwards
#endif
                    }},
                    {"PlaySectionWithMarkersBackwards", new MemberRegisterInfo { Name = "PlaySectionWithMarkersBackwards", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_PlaySectionWithMarkersBackwards
#endif
                    }},
                    {"PlaySectionBackwards", new MemberRegisterInfo { Name = "PlaySectionBackwards", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_PlaySectionBackwards
#endif
                    }},
                    {"PlayWithCapture", new MemberRegisterInfo { Name = "PlayWithCapture", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_PlayWithCapture
#endif
                    }},
                    {"Pause", new MemberRegisterInfo { Name = "Pause", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_Pause
#endif
                    }},
                    {"Stop", new MemberRegisterInfo { Name = "Stop", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_Stop
#endif
                    }},
                    {"IsPlaying", new MemberRegisterInfo { Name = "IsPlaying", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_IsPlaying
#endif
                    }},
                    {"SetCurrentAnimation", new MemberRegisterInfo { Name = "SetCurrentAnimation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetCurrentAnimation
#endif
                    }},
                    {"GetCurrentAnimation", new MemberRegisterInfo { Name = "GetCurrentAnimation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetCurrentAnimation
#endif
                    }},
                    {"SetAssignedAnimation", new MemberRegisterInfo { Name = "SetAssignedAnimation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetAssignedAnimation
#endif
                    }},
                    {"GetAssignedAnimation", new MemberRegisterInfo { Name = "GetAssignedAnimation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetAssignedAnimation
#endif
                    }},
                    {"Queue", new MemberRegisterInfo { Name = "Queue", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_Queue
#endif
                    }},
                    {"GetQueue", new MemberRegisterInfo { Name = "GetQueue", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetQueue
#endif
                    }},
                    {"ClearQueue", new MemberRegisterInfo { Name = "ClearQueue", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_ClearQueue
#endif
                    }},
                    {"SetSpeedScale", new MemberRegisterInfo { Name = "SetSpeedScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetSpeedScale
#endif
                    }},
                    {"GetSpeedScale", new MemberRegisterInfo { Name = "GetSpeedScale", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetSpeedScale
#endif
                    }},
                    {"GetPlayingSpeed", new MemberRegisterInfo { Name = "GetPlayingSpeed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetPlayingSpeed
#endif
                    }},
                    {"SetAutoplay", new MemberRegisterInfo { Name = "SetAutoplay", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetAutoplay
#endif
                    }},
                    {"GetAutoplay", new MemberRegisterInfo { Name = "GetAutoplay", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetAutoplay
#endif
                    }},
                    {"SetMovieQuitOnFinishEnabled", new MemberRegisterInfo { Name = "SetMovieQuitOnFinishEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetMovieQuitOnFinishEnabled
#endif
                    }},
                    {"IsMovieQuitOnFinishEnabled", new MemberRegisterInfo { Name = "IsMovieQuitOnFinishEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_IsMovieQuitOnFinishEnabled
#endif
                    }},
                    {"GetCurrentAnimationPosition", new MemberRegisterInfo { Name = "GetCurrentAnimationPosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetCurrentAnimationPosition
#endif
                    }},
                    {"GetCurrentAnimationLength", new MemberRegisterInfo { Name = "GetCurrentAnimationLength", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetCurrentAnimationLength
#endif
                    }},
                    {"SetSectionWithMarkers", new MemberRegisterInfo { Name = "SetSectionWithMarkers", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetSectionWithMarkers
#endif
                    }},
                    {"SetSection", new MemberRegisterInfo { Name = "SetSection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_SetSection
#endif
                    }},
                    {"ResetSection", new MemberRegisterInfo { Name = "ResetSection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_ResetSection
#endif
                    }},
                    {"GetSectionStartTime", new MemberRegisterInfo { Name = "GetSectionStartTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetSectionStartTime
#endif
                    }},
                    {"GetSectionEndTime", new MemberRegisterInfo { Name = "GetSectionEndTime", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_GetSectionEndTime
#endif
                    }},
                    {"HasSection", new MemberRegisterInfo { Name = "HasSection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_HasSection
#endif
                    }},
                    {"Seek", new MemberRegisterInfo { Name = "Seek", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.M_Seek
#endif
                    }},
                    {"add_CurrentAnimationChanged", new MemberRegisterInfo { Name = "add_CurrentAnimationChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.A_CurrentAnimationChanged
#endif
                    }},
                    {"remove_CurrentAnimationChanged", new MemberRegisterInfo { Name = "remove_CurrentAnimationChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.R_CurrentAnimationChanged
#endif
                    }},
                    {"add_AnimationChanged", new MemberRegisterInfo { Name = "add_AnimationChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.A_AnimationChanged
#endif
                    }},
                    {"remove_AnimationChanged", new MemberRegisterInfo { Name = "remove_AnimationChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_AnimationPlayer_Wrap.R_AnimationChanged
#endif
                    }},
                    {"MethodCallMode", new MemberRegisterInfo { Name = "MethodCallMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_MethodCallMode, PropertySetter = Godot_AnimationPlayer_Wrap.S_MethodCallMode
#endif
                    }},
                    {"PlaybackActive", new MemberRegisterInfo { Name = "PlaybackActive", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_PlaybackActive, PropertySetter = Godot_AnimationPlayer_Wrap.S_PlaybackActive
#endif
                    }},
                    {"PlaybackProcessMode", new MemberRegisterInfo { Name = "PlaybackProcessMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_PlaybackProcessMode, PropertySetter = Godot_AnimationPlayer_Wrap.S_PlaybackProcessMode
#endif
                    }},
                    {"CurrentAnimation", new MemberRegisterInfo { Name = "CurrentAnimation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_CurrentAnimation, PropertySetter = Godot_AnimationPlayer_Wrap.S_CurrentAnimation
#endif
                    }},
                    {"AssignedAnimation", new MemberRegisterInfo { Name = "AssignedAnimation", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_AssignedAnimation, PropertySetter = Godot_AnimationPlayer_Wrap.S_AssignedAnimation
#endif
                    }},
                    {"Autoplay", new MemberRegisterInfo { Name = "Autoplay", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_Autoplay, PropertySetter = Godot_AnimationPlayer_Wrap.S_Autoplay
#endif
                    }},
                    {"CurrentAnimationLength", new MemberRegisterInfo { Name = "CurrentAnimationLength", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_CurrentAnimationLength
#endif
                    }},
                    {"CurrentAnimationPosition", new MemberRegisterInfo { Name = "CurrentAnimationPosition", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_CurrentAnimationPosition
#endif
                    }},
                    {"PlaybackAutoCapture", new MemberRegisterInfo { Name = "PlaybackAutoCapture", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_PlaybackAutoCapture, PropertySetter = Godot_AnimationPlayer_Wrap.S_PlaybackAutoCapture
#endif
                    }},
                    {"PlaybackAutoCaptureDuration", new MemberRegisterInfo { Name = "PlaybackAutoCaptureDuration", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_PlaybackAutoCaptureDuration, PropertySetter = Godot_AnimationPlayer_Wrap.S_PlaybackAutoCaptureDuration
#endif
                    }},
                    {"PlaybackAutoCaptureTransitionType", new MemberRegisterInfo { Name = "PlaybackAutoCaptureTransitionType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_PlaybackAutoCaptureTransitionType, PropertySetter = Godot_AnimationPlayer_Wrap.S_PlaybackAutoCaptureTransitionType
#endif
                    }},
                    {"PlaybackAutoCaptureEaseType", new MemberRegisterInfo { Name = "PlaybackAutoCaptureEaseType", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_PlaybackAutoCaptureEaseType, PropertySetter = Godot_AnimationPlayer_Wrap.S_PlaybackAutoCaptureEaseType
#endif
                    }},
                    {"PlaybackDefaultBlendTime", new MemberRegisterInfo { Name = "PlaybackDefaultBlendTime", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_PlaybackDefaultBlendTime, PropertySetter = Godot_AnimationPlayer_Wrap.S_PlaybackDefaultBlendTime
#endif
                    }},
                    {"SpeedScale", new MemberRegisterInfo { Name = "SpeedScale", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_SpeedScale, PropertySetter = Godot_AnimationPlayer_Wrap.S_SpeedScale
#endif
                    }},
                    {"MovieQuitOnFinish", new MemberRegisterInfo { Name = "MovieQuitOnFinish", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_AnimationPlayer_Wrap.G_MovieQuitOnFinish, PropertySetter = Godot_AnimationPlayer_Wrap.S_MovieQuitOnFinish
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_PhysicsBody2D_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"MoveAndCollide", new MemberRegisterInfo { Name = "MoveAndCollide", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_PhysicsBody2D_Wrap.M_MoveAndCollide
#endif
                    }},
                    {"TestMove", new MemberRegisterInfo { Name = "TestMove", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_PhysicsBody2D_Wrap.M_TestMove
#endif
                    }},
                    {"GetGravity", new MemberRegisterInfo { Name = "GetGravity", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_PhysicsBody2D_Wrap.M_GetGravity
#endif
                    }},
                    {"GetCollisionExceptions", new MemberRegisterInfo { Name = "GetCollisionExceptions", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_PhysicsBody2D_Wrap.M_GetCollisionExceptions
#endif
                    }},
                    {"AddCollisionExceptionWith", new MemberRegisterInfo { Name = "AddCollisionExceptionWith", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_PhysicsBody2D_Wrap.M_AddCollisionExceptionWith
#endif
                    }},
                    {"RemoveCollisionExceptionWith", new MemberRegisterInfo { Name = "RemoveCollisionExceptionWith", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_PhysicsBody2D_Wrap.M_RemoveCollisionExceptionWith
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_CharacterBody2D_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_CharacterBody2D_Wrap.Constructor
#endif
                    }},
                    {"MoveAndSlide", new MemberRegisterInfo { Name = "MoveAndSlide", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_MoveAndSlide
#endif
                    }},
                    {"ApplyFloorSnap", new MemberRegisterInfo { Name = "ApplyFloorSnap", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_ApplyFloorSnap
#endif
                    }},
                    {"SetVelocity", new MemberRegisterInfo { Name = "SetVelocity", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetVelocity
#endif
                    }},
                    {"GetVelocity", new MemberRegisterInfo { Name = "GetVelocity", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetVelocity
#endif
                    }},
                    {"SetSafeMargin", new MemberRegisterInfo { Name = "SetSafeMargin", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetSafeMargin
#endif
                    }},
                    {"GetSafeMargin", new MemberRegisterInfo { Name = "GetSafeMargin", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetSafeMargin
#endif
                    }},
                    {"IsFloorStopOnSlopeEnabled", new MemberRegisterInfo { Name = "IsFloorStopOnSlopeEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_IsFloorStopOnSlopeEnabled
#endif
                    }},
                    {"SetFloorStopOnSlopeEnabled", new MemberRegisterInfo { Name = "SetFloorStopOnSlopeEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetFloorStopOnSlopeEnabled
#endif
                    }},
                    {"SetFloorConstantSpeedEnabled", new MemberRegisterInfo { Name = "SetFloorConstantSpeedEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetFloorConstantSpeedEnabled
#endif
                    }},
                    {"IsFloorConstantSpeedEnabled", new MemberRegisterInfo { Name = "IsFloorConstantSpeedEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_IsFloorConstantSpeedEnabled
#endif
                    }},
                    {"SetFloorBlockOnWallEnabled", new MemberRegisterInfo { Name = "SetFloorBlockOnWallEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetFloorBlockOnWallEnabled
#endif
                    }},
                    {"IsFloorBlockOnWallEnabled", new MemberRegisterInfo { Name = "IsFloorBlockOnWallEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_IsFloorBlockOnWallEnabled
#endif
                    }},
                    {"SetSlideOnCeilingEnabled", new MemberRegisterInfo { Name = "SetSlideOnCeilingEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetSlideOnCeilingEnabled
#endif
                    }},
                    {"IsSlideOnCeilingEnabled", new MemberRegisterInfo { Name = "IsSlideOnCeilingEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_IsSlideOnCeilingEnabled
#endif
                    }},
                    {"SetPlatformFloorLayers", new MemberRegisterInfo { Name = "SetPlatformFloorLayers", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetPlatformFloorLayers
#endif
                    }},
                    {"GetPlatformFloorLayers", new MemberRegisterInfo { Name = "GetPlatformFloorLayers", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetPlatformFloorLayers
#endif
                    }},
                    {"SetPlatformWallLayers", new MemberRegisterInfo { Name = "SetPlatformWallLayers", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetPlatformWallLayers
#endif
                    }},
                    {"GetPlatformWallLayers", new MemberRegisterInfo { Name = "GetPlatformWallLayers", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetPlatformWallLayers
#endif
                    }},
                    {"GetMaxSlides", new MemberRegisterInfo { Name = "GetMaxSlides", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetMaxSlides
#endif
                    }},
                    {"SetMaxSlides", new MemberRegisterInfo { Name = "SetMaxSlides", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetMaxSlides
#endif
                    }},
                    {"GetFloorMaxAngle", new MemberRegisterInfo { Name = "GetFloorMaxAngle", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetFloorMaxAngle
#endif
                    }},
                    {"SetFloorMaxAngle", new MemberRegisterInfo { Name = "SetFloorMaxAngle", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetFloorMaxAngle
#endif
                    }},
                    {"GetFloorSnapLength", new MemberRegisterInfo { Name = "GetFloorSnapLength", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetFloorSnapLength
#endif
                    }},
                    {"SetFloorSnapLength", new MemberRegisterInfo { Name = "SetFloorSnapLength", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetFloorSnapLength
#endif
                    }},
                    {"GetWallMinSlideAngle", new MemberRegisterInfo { Name = "GetWallMinSlideAngle", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetWallMinSlideAngle
#endif
                    }},
                    {"SetWallMinSlideAngle", new MemberRegisterInfo { Name = "SetWallMinSlideAngle", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetWallMinSlideAngle
#endif
                    }},
                    {"GetUpDirection", new MemberRegisterInfo { Name = "GetUpDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetUpDirection
#endif
                    }},
                    {"SetUpDirection", new MemberRegisterInfo { Name = "SetUpDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetUpDirection
#endif
                    }},
                    {"SetMotionMode", new MemberRegisterInfo { Name = "SetMotionMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetMotionMode
#endif
                    }},
                    {"GetMotionMode", new MemberRegisterInfo { Name = "GetMotionMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetMotionMode
#endif
                    }},
                    {"SetPlatformOnLeave", new MemberRegisterInfo { Name = "SetPlatformOnLeave", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_SetPlatformOnLeave
#endif
                    }},
                    {"GetPlatformOnLeave", new MemberRegisterInfo { Name = "GetPlatformOnLeave", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetPlatformOnLeave
#endif
                    }},
                    {"IsOnFloor", new MemberRegisterInfo { Name = "IsOnFloor", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_IsOnFloor
#endif
                    }},
                    {"IsOnFloorOnly", new MemberRegisterInfo { Name = "IsOnFloorOnly", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_IsOnFloorOnly
#endif
                    }},
                    {"IsOnCeiling", new MemberRegisterInfo { Name = "IsOnCeiling", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_IsOnCeiling
#endif
                    }},
                    {"IsOnCeilingOnly", new MemberRegisterInfo { Name = "IsOnCeilingOnly", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_IsOnCeilingOnly
#endif
                    }},
                    {"IsOnWall", new MemberRegisterInfo { Name = "IsOnWall", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_IsOnWall
#endif
                    }},
                    {"IsOnWallOnly", new MemberRegisterInfo { Name = "IsOnWallOnly", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_IsOnWallOnly
#endif
                    }},
                    {"GetFloorNormal", new MemberRegisterInfo { Name = "GetFloorNormal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetFloorNormal
#endif
                    }},
                    {"GetWallNormal", new MemberRegisterInfo { Name = "GetWallNormal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetWallNormal
#endif
                    }},
                    {"GetLastMotion", new MemberRegisterInfo { Name = "GetLastMotion", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetLastMotion
#endif
                    }},
                    {"GetPositionDelta", new MemberRegisterInfo { Name = "GetPositionDelta", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetPositionDelta
#endif
                    }},
                    {"GetRealVelocity", new MemberRegisterInfo { Name = "GetRealVelocity", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetRealVelocity
#endif
                    }},
                    {"GetFloorAngle", new MemberRegisterInfo { Name = "GetFloorAngle", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetFloorAngle
#endif
                    }},
                    {"GetPlatformVelocity", new MemberRegisterInfo { Name = "GetPlatformVelocity", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetPlatformVelocity
#endif
                    }},
                    {"GetSlideCollisionCount", new MemberRegisterInfo { Name = "GetSlideCollisionCount", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetSlideCollisionCount
#endif
                    }},
                    {"GetSlideCollision", new MemberRegisterInfo { Name = "GetSlideCollision", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetSlideCollision
#endif
                    }},
                    {"GetLastSlideCollision", new MemberRegisterInfo { Name = "GetLastSlideCollision", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CharacterBody2D_Wrap.M_GetLastSlideCollision
#endif
                    }},
                    {"MotionMode", new MemberRegisterInfo { Name = "MotionMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_MotionMode, PropertySetter = Godot_CharacterBody2D_Wrap.S_MotionMode
#endif
                    }},
                    {"UpDirection", new MemberRegisterInfo { Name = "UpDirection", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_UpDirection, PropertySetter = Godot_CharacterBody2D_Wrap.S_UpDirection
#endif
                    }},
                    {"Velocity", new MemberRegisterInfo { Name = "Velocity", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_Velocity, PropertySetter = Godot_CharacterBody2D_Wrap.S_Velocity
#endif
                    }},
                    {"SlideOnCeiling", new MemberRegisterInfo { Name = "SlideOnCeiling", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_SlideOnCeiling, PropertySetter = Godot_CharacterBody2D_Wrap.S_SlideOnCeiling
#endif
                    }},
                    {"MaxSlides", new MemberRegisterInfo { Name = "MaxSlides", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_MaxSlides, PropertySetter = Godot_CharacterBody2D_Wrap.S_MaxSlides
#endif
                    }},
                    {"WallMinSlideAngle", new MemberRegisterInfo { Name = "WallMinSlideAngle", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_WallMinSlideAngle, PropertySetter = Godot_CharacterBody2D_Wrap.S_WallMinSlideAngle
#endif
                    }},
                    {"FloorStopOnSlope", new MemberRegisterInfo { Name = "FloorStopOnSlope", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_FloorStopOnSlope, PropertySetter = Godot_CharacterBody2D_Wrap.S_FloorStopOnSlope
#endif
                    }},
                    {"FloorConstantSpeed", new MemberRegisterInfo { Name = "FloorConstantSpeed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_FloorConstantSpeed, PropertySetter = Godot_CharacterBody2D_Wrap.S_FloorConstantSpeed
#endif
                    }},
                    {"FloorBlockOnWall", new MemberRegisterInfo { Name = "FloorBlockOnWall", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_FloorBlockOnWall, PropertySetter = Godot_CharacterBody2D_Wrap.S_FloorBlockOnWall
#endif
                    }},
                    {"FloorMaxAngle", new MemberRegisterInfo { Name = "FloorMaxAngle", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_FloorMaxAngle, PropertySetter = Godot_CharacterBody2D_Wrap.S_FloorMaxAngle
#endif
                    }},
                    {"FloorSnapLength", new MemberRegisterInfo { Name = "FloorSnapLength", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_FloorSnapLength, PropertySetter = Godot_CharacterBody2D_Wrap.S_FloorSnapLength
#endif
                    }},
                    {"PlatformOnLeave", new MemberRegisterInfo { Name = "PlatformOnLeave", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_PlatformOnLeave, PropertySetter = Godot_CharacterBody2D_Wrap.S_PlatformOnLeave
#endif
                    }},
                    {"PlatformFloorLayers", new MemberRegisterInfo { Name = "PlatformFloorLayers", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_PlatformFloorLayers, PropertySetter = Godot_CharacterBody2D_Wrap.S_PlatformFloorLayers
#endif
                    }},
                    {"PlatformWallLayers", new MemberRegisterInfo { Name = "PlatformWallLayers", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_PlatformWallLayers, PropertySetter = Godot_CharacterBody2D_Wrap.S_PlatformWallLayers
#endif
                    }},
                    {"SafeMargin", new MemberRegisterInfo { Name = "SafeMargin", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CharacterBody2D_Wrap.G_SafeMargin, PropertySetter = Godot_CharacterBody2D_Wrap.S_SafeMargin
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_CollisionObject2D_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"_InputEvent", new MemberRegisterInfo { Name = "_InputEvent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M__InputEvent
#endif
                    }},
                    {"_MouseEnter", new MemberRegisterInfo { Name = "_MouseEnter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M__MouseEnter
#endif
                    }},
                    {"_MouseExit", new MemberRegisterInfo { Name = "_MouseExit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M__MouseExit
#endif
                    }},
                    {"_MouseShapeEnter", new MemberRegisterInfo { Name = "_MouseShapeEnter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M__MouseShapeEnter
#endif
                    }},
                    {"_MouseShapeExit", new MemberRegisterInfo { Name = "_MouseShapeExit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M__MouseShapeExit
#endif
                    }},
                    {"GetRid", new MemberRegisterInfo { Name = "GetRid", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_GetRid
#endif
                    }},
                    {"SetCollisionLayer", new MemberRegisterInfo { Name = "SetCollisionLayer", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_SetCollisionLayer
#endif
                    }},
                    {"GetCollisionLayer", new MemberRegisterInfo { Name = "GetCollisionLayer", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_GetCollisionLayer
#endif
                    }},
                    {"SetCollisionMask", new MemberRegisterInfo { Name = "SetCollisionMask", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_SetCollisionMask
#endif
                    }},
                    {"GetCollisionMask", new MemberRegisterInfo { Name = "GetCollisionMask", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_GetCollisionMask
#endif
                    }},
                    {"SetCollisionLayerValue", new MemberRegisterInfo { Name = "SetCollisionLayerValue", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_SetCollisionLayerValue
#endif
                    }},
                    {"GetCollisionLayerValue", new MemberRegisterInfo { Name = "GetCollisionLayerValue", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_GetCollisionLayerValue
#endif
                    }},
                    {"SetCollisionMaskValue", new MemberRegisterInfo { Name = "SetCollisionMaskValue", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_SetCollisionMaskValue
#endif
                    }},
                    {"GetCollisionMaskValue", new MemberRegisterInfo { Name = "GetCollisionMaskValue", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_GetCollisionMaskValue
#endif
                    }},
                    {"SetCollisionPriority", new MemberRegisterInfo { Name = "SetCollisionPriority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_SetCollisionPriority
#endif
                    }},
                    {"GetCollisionPriority", new MemberRegisterInfo { Name = "GetCollisionPriority", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_GetCollisionPriority
#endif
                    }},
                    {"SetDisableMode", new MemberRegisterInfo { Name = "SetDisableMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_SetDisableMode
#endif
                    }},
                    {"GetDisableMode", new MemberRegisterInfo { Name = "GetDisableMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_GetDisableMode
#endif
                    }},
                    {"SetPickable", new MemberRegisterInfo { Name = "SetPickable", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_SetPickable
#endif
                    }},
                    {"IsPickable", new MemberRegisterInfo { Name = "IsPickable", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_IsPickable
#endif
                    }},
                    {"CreateShapeOwner", new MemberRegisterInfo { Name = "CreateShapeOwner", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_CreateShapeOwner
#endif
                    }},
                    {"RemoveShapeOwner", new MemberRegisterInfo { Name = "RemoveShapeOwner", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_RemoveShapeOwner
#endif
                    }},
                    {"GetShapeOwners", new MemberRegisterInfo { Name = "GetShapeOwners", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_GetShapeOwners
#endif
                    }},
                    {"ShapeOwnerSetTransform", new MemberRegisterInfo { Name = "ShapeOwnerSetTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerSetTransform
#endif
                    }},
                    {"ShapeOwnerGetTransform", new MemberRegisterInfo { Name = "ShapeOwnerGetTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerGetTransform
#endif
                    }},
                    {"ShapeOwnerGetOwner", new MemberRegisterInfo { Name = "ShapeOwnerGetOwner", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerGetOwner
#endif
                    }},
                    {"ShapeOwnerSetDisabled", new MemberRegisterInfo { Name = "ShapeOwnerSetDisabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerSetDisabled
#endif
                    }},
                    {"IsShapeOwnerDisabled", new MemberRegisterInfo { Name = "IsShapeOwnerDisabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_IsShapeOwnerDisabled
#endif
                    }},
                    {"ShapeOwnerSetOneWayCollision", new MemberRegisterInfo { Name = "ShapeOwnerSetOneWayCollision", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerSetOneWayCollision
#endif
                    }},
                    {"IsShapeOwnerOneWayCollisionEnabled", new MemberRegisterInfo { Name = "IsShapeOwnerOneWayCollisionEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_IsShapeOwnerOneWayCollisionEnabled
#endif
                    }},
                    {"ShapeOwnerSetOneWayCollisionMargin", new MemberRegisterInfo { Name = "ShapeOwnerSetOneWayCollisionMargin", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerSetOneWayCollisionMargin
#endif
                    }},
                    {"GetShapeOwnerOneWayCollisionMargin", new MemberRegisterInfo { Name = "GetShapeOwnerOneWayCollisionMargin", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_GetShapeOwnerOneWayCollisionMargin
#endif
                    }},
                    {"ShapeOwnerAddShape", new MemberRegisterInfo { Name = "ShapeOwnerAddShape", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerAddShape
#endif
                    }},
                    {"ShapeOwnerGetShapeCount", new MemberRegisterInfo { Name = "ShapeOwnerGetShapeCount", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerGetShapeCount
#endif
                    }},
                    {"ShapeOwnerGetShape", new MemberRegisterInfo { Name = "ShapeOwnerGetShape", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerGetShape
#endif
                    }},
                    {"ShapeOwnerGetShapeIndex", new MemberRegisterInfo { Name = "ShapeOwnerGetShapeIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerGetShapeIndex
#endif
                    }},
                    {"ShapeOwnerRemoveShape", new MemberRegisterInfo { Name = "ShapeOwnerRemoveShape", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerRemoveShape
#endif
                    }},
                    {"ShapeOwnerClearShapes", new MemberRegisterInfo { Name = "ShapeOwnerClearShapes", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeOwnerClearShapes
#endif
                    }},
                    {"ShapeFindOwner", new MemberRegisterInfo { Name = "ShapeFindOwner", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.M_ShapeFindOwner
#endif
                    }},
                    {"add_InputEvent", new MemberRegisterInfo { Name = "add_InputEvent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.A_InputEvent
#endif
                    }},
                    {"remove_InputEvent", new MemberRegisterInfo { Name = "remove_InputEvent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.R_InputEvent
#endif
                    }},
                    {"add_MouseEntered", new MemberRegisterInfo { Name = "add_MouseEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.A_MouseEntered
#endif
                    }},
                    {"remove_MouseEntered", new MemberRegisterInfo { Name = "remove_MouseEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.R_MouseEntered
#endif
                    }},
                    {"add_MouseExited", new MemberRegisterInfo { Name = "add_MouseExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.A_MouseExited
#endif
                    }},
                    {"remove_MouseExited", new MemberRegisterInfo { Name = "remove_MouseExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.R_MouseExited
#endif
                    }},
                    {"add_MouseShapeEntered", new MemberRegisterInfo { Name = "add_MouseShapeEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.A_MouseShapeEntered
#endif
                    }},
                    {"remove_MouseShapeEntered", new MemberRegisterInfo { Name = "remove_MouseShapeEntered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.R_MouseShapeEntered
#endif
                    }},
                    {"add_MouseShapeExited", new MemberRegisterInfo { Name = "add_MouseShapeExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.A_MouseShapeExited
#endif
                    }},
                    {"remove_MouseShapeExited", new MemberRegisterInfo { Name = "remove_MouseShapeExited", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CollisionObject2D_Wrap.R_MouseShapeExited
#endif
                    }},
                    {"DisableMode", new MemberRegisterInfo { Name = "DisableMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CollisionObject2D_Wrap.G_DisableMode, PropertySetter = Godot_CollisionObject2D_Wrap.S_DisableMode
#endif
                    }},
                    {"CollisionLayer", new MemberRegisterInfo { Name = "CollisionLayer", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CollisionObject2D_Wrap.G_CollisionLayer, PropertySetter = Godot_CollisionObject2D_Wrap.S_CollisionLayer
#endif
                    }},
                    {"CollisionMask", new MemberRegisterInfo { Name = "CollisionMask", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CollisionObject2D_Wrap.G_CollisionMask, PropertySetter = Godot_CollisionObject2D_Wrap.S_CollisionMask
#endif
                    }},
                    {"CollisionPriority", new MemberRegisterInfo { Name = "CollisionPriority", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CollisionObject2D_Wrap.G_CollisionPriority, PropertySetter = Godot_CollisionObject2D_Wrap.S_CollisionPriority
#endif
                    }},
                    {"InputPickable", new MemberRegisterInfo { Name = "InputPickable", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CollisionObject2D_Wrap.G_InputPickable, PropertySetter = Godot_CollisionObject2D_Wrap.S_InputPickable
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Texture_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_Texture_Wrap.Constructor
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Texture2D_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_Texture2D_Wrap.Constructor
#endif
                    }},
                    {"_Draw", new MemberRegisterInfo { Name = "_Draw", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M__Draw
#endif
                    }},
                    {"_DrawRect", new MemberRegisterInfo { Name = "_DrawRect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M__DrawRect
#endif
                    }},
                    {"_DrawRectRegion", new MemberRegisterInfo { Name = "_DrawRectRegion", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M__DrawRectRegion
#endif
                    }},
                    {"_GetHeight", new MemberRegisterInfo { Name = "_GetHeight", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M__GetHeight
#endif
                    }},
                    {"_GetWidth", new MemberRegisterInfo { Name = "_GetWidth", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M__GetWidth
#endif
                    }},
                    {"_HasAlpha", new MemberRegisterInfo { Name = "_HasAlpha", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M__HasAlpha
#endif
                    }},
                    {"_IsPixelOpaque", new MemberRegisterInfo { Name = "_IsPixelOpaque", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M__IsPixelOpaque
#endif
                    }},
                    {"GetWidth", new MemberRegisterInfo { Name = "GetWidth", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M_GetWidth
#endif
                    }},
                    {"GetHeight", new MemberRegisterInfo { Name = "GetHeight", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M_GetHeight
#endif
                    }},
                    {"GetSize", new MemberRegisterInfo { Name = "GetSize", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M_GetSize
#endif
                    }},
                    {"HasAlpha", new MemberRegisterInfo { Name = "HasAlpha", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M_HasAlpha
#endif
                    }},
                    {"Draw", new MemberRegisterInfo { Name = "Draw", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M_Draw
#endif
                    }},
                    {"DrawRect", new MemberRegisterInfo { Name = "DrawRect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M_DrawRect
#endif
                    }},
                    {"DrawRectRegion", new MemberRegisterInfo { Name = "DrawRectRegion", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M_DrawRectRegion
#endif
                    }},
                    {"GetImage", new MemberRegisterInfo { Name = "GetImage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M_GetImage
#endif
                    }},
                    {"CreatePlaceholder", new MemberRegisterInfo { Name = "CreatePlaceholder", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Texture2D_Wrap.M_CreatePlaceholder
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Color_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_Color_Wrap.Constructor
#endif
                    }},
                    {"Blend", new MemberRegisterInfo { Name = "Blend", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_Blend
#endif
                    }},
                    {"Clamp", new MemberRegisterInfo { Name = "Clamp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_Clamp
#endif
                    }},
                    {"Darkened", new MemberRegisterInfo { Name = "Darkened", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_Darkened
#endif
                    }},
                    {"Inverted", new MemberRegisterInfo { Name = "Inverted", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_Inverted
#endif
                    }},
                    {"Lightened", new MemberRegisterInfo { Name = "Lightened", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_Lightened
#endif
                    }},
                    {"Lerp", new MemberRegisterInfo { Name = "Lerp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_Lerp
#endif
                    }},
                    {"LinearToSrgb", new MemberRegisterInfo { Name = "LinearToSrgb", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_LinearToSrgb
#endif
                    }},
                    {"SrgbToLinear", new MemberRegisterInfo { Name = "SrgbToLinear", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_SrgbToLinear
#endif
                    }},
                    {"ToAbgr32", new MemberRegisterInfo { Name = "ToAbgr32", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_ToAbgr32
#endif
                    }},
                    {"ToAbgr64", new MemberRegisterInfo { Name = "ToAbgr64", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_ToAbgr64
#endif
                    }},
                    {"ToArgb32", new MemberRegisterInfo { Name = "ToArgb32", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_ToArgb32
#endif
                    }},
                    {"ToArgb64", new MemberRegisterInfo { Name = "ToArgb64", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_ToArgb64
#endif
                    }},
                    {"ToRgba32", new MemberRegisterInfo { Name = "ToRgba32", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_ToRgba32
#endif
                    }},
                    {"ToRgba64", new MemberRegisterInfo { Name = "ToRgba64", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_ToRgba64
#endif
                    }},
                    {"ToHtml", new MemberRegisterInfo { Name = "ToHtml", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_ToHtml
#endif
                    }},
                    {"ToHsv", new MemberRegisterInfo { Name = "ToHsv", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_ToHsv
#endif
                    }},
                    {"op_Addition_static", new MemberRegisterInfo { Name = "op_Addition", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_Addition
#endif
                    }},
                    {"op_Subtraction_static", new MemberRegisterInfo { Name = "op_Subtraction", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_Subtraction
#endif
                    }},
                    {"op_UnaryNegation_static", new MemberRegisterInfo { Name = "op_UnaryNegation", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_UnaryNegation
#endif
                    }},
                    {"op_Multiply_static", new MemberRegisterInfo { Name = "op_Multiply", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_Multiply
#endif
                    }},
                    {"op_Division_static", new MemberRegisterInfo { Name = "op_Division", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_Division
#endif
                    }},
                    {"op_Equality_static", new MemberRegisterInfo { Name = "op_Equality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_Equality
#endif
                    }},
                    {"op_Inequality_static", new MemberRegisterInfo { Name = "op_Inequality", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_Inequality
#endif
                    }},
                    {"op_LessThan_static", new MemberRegisterInfo { Name = "op_LessThan", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_LessThan
#endif
                    }},
                    {"op_GreaterThan_static", new MemberRegisterInfo { Name = "op_GreaterThan", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_GreaterThan
#endif
                    }},
                    {"op_LessThanOrEqual_static", new MemberRegisterInfo { Name = "op_LessThanOrEqual", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_LessThanOrEqual
#endif
                    }},
                    {"op_GreaterThanOrEqual_static", new MemberRegisterInfo { Name = "op_GreaterThanOrEqual", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.O_op_GreaterThanOrEqual
#endif
                    }},
                    {"Equals", new MemberRegisterInfo { Name = "Equals", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_Equals
#endif
                    }},
                    {"IsEqualApprox", new MemberRegisterInfo { Name = "IsEqualApprox", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_IsEqualApprox
#endif
                    }},
                    {"GetHashCode", new MemberRegisterInfo { Name = "GetHashCode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_GetHashCode
#endif
                    }},
                    {"ToString", new MemberRegisterInfo { Name = "ToString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.M_ToString
#endif
                    }},
                    {"R8", new MemberRegisterInfo { Name = "R8", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_R8, PropertySetter = Godot_Color_Wrap.S_R8
#endif
                    }},
                    {"G8", new MemberRegisterInfo { Name = "G8", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_G8, PropertySetter = Godot_Color_Wrap.S_G8
#endif
                    }},
                    {"B8", new MemberRegisterInfo { Name = "B8", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_B8, PropertySetter = Godot_Color_Wrap.S_B8
#endif
                    }},
                    {"A8", new MemberRegisterInfo { Name = "A8", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_A8, PropertySetter = Godot_Color_Wrap.S_A8
#endif
                    }},
                    {"H", new MemberRegisterInfo { Name = "H", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_H, PropertySetter = Godot_Color_Wrap.S_H
#endif
                    }},
                    {"S", new MemberRegisterInfo { Name = "S", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_S, PropertySetter = Godot_Color_Wrap.S_S
#endif
                    }},
                    {"V", new MemberRegisterInfo { Name = "V", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_V, PropertySetter = Godot_Color_Wrap.S_V
#endif
                    }},
                    {"OkHslH", new MemberRegisterInfo { Name = "OkHslH", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_OkHslH, PropertySetter = Godot_Color_Wrap.S_OkHslH
#endif
                    }},
                    {"OkHslS", new MemberRegisterInfo { Name = "OkHslS", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_OkHslS, PropertySetter = Godot_Color_Wrap.S_OkHslS
#endif
                    }},
                    {"OkHslL", new MemberRegisterInfo { Name = "OkHslL", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_OkHslL, PropertySetter = Godot_Color_Wrap.S_OkHslL
#endif
                    }},
                    {"Luminance", new MemberRegisterInfo { Name = "Luminance", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_Luminance
#endif
                    }},
                    {"get_Item", new MemberRegisterInfo { Name = "get_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.GetItem
#endif
                    }},
                    {"set_Item", new MemberRegisterInfo { Name = "set_Item", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.SetItem
#endif
                    }},
                    {"R", new MemberRegisterInfo { Name = "R", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_R, PropertySetter = Godot_Color_Wrap.S_R
#endif
                    }},
                    {"G", new MemberRegisterInfo { Name = "G", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_G, PropertySetter = Godot_Color_Wrap.S_G
#endif
                    }},
                    {"B", new MemberRegisterInfo { Name = "B", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_B, PropertySetter = Godot_Color_Wrap.S_B
#endif
                    }},
                    {"A", new MemberRegisterInfo { Name = "A", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Color_Wrap.G_A, PropertySetter = Godot_Color_Wrap.S_A
#endif
                    }},
                    {"Color8_static", new MemberRegisterInfo { Name = "Color8", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.F_Color8
#endif
                    }},
                    {"FromHsv_static", new MemberRegisterInfo { Name = "FromHsv", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.F_FromHsv
#endif
                    }},
                    {"FromOkHsl_static", new MemberRegisterInfo { Name = "FromOkHsl", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.F_FromOkHsl
#endif
                    }},
                    {"FromRgbe9995_static", new MemberRegisterInfo { Name = "FromRgbe9995", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.F_FromRgbe9995
#endif
                    }},
                    {"FromString_static", new MemberRegisterInfo { Name = "FromString", IsStatic = true, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Color_Wrap.F_FromString
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_CanvasItem_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {"_Draw", new MemberRegisterInfo { Name = "_Draw", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M__Draw
#endif
                    }},
                    {"GetCanvasItem", new MemberRegisterInfo { Name = "GetCanvasItem", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetCanvasItem
#endif
                    }},
                    {"SetVisible", new MemberRegisterInfo { Name = "SetVisible", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetVisible
#endif
                    }},
                    {"IsVisible", new MemberRegisterInfo { Name = "IsVisible", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_IsVisible
#endif
                    }},
                    {"IsVisibleInTree", new MemberRegisterInfo { Name = "IsVisibleInTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_IsVisibleInTree
#endif
                    }},
                    {"Show", new MemberRegisterInfo { Name = "Show", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_Show
#endif
                    }},
                    {"Hide", new MemberRegisterInfo { Name = "Hide", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_Hide
#endif
                    }},
                    {"QueueRedraw", new MemberRegisterInfo { Name = "QueueRedraw", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_QueueRedraw
#endif
                    }},
                    {"MoveToFront", new MemberRegisterInfo { Name = "MoveToFront", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_MoveToFront
#endif
                    }},
                    {"SetAsTopLevel", new MemberRegisterInfo { Name = "SetAsTopLevel", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetAsTopLevel
#endif
                    }},
                    {"IsSetAsTopLevel", new MemberRegisterInfo { Name = "IsSetAsTopLevel", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_IsSetAsTopLevel
#endif
                    }},
                    {"SetLightMask", new MemberRegisterInfo { Name = "SetLightMask", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetLightMask
#endif
                    }},
                    {"GetLightMask", new MemberRegisterInfo { Name = "GetLightMask", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetLightMask
#endif
                    }},
                    {"SetModulate", new MemberRegisterInfo { Name = "SetModulate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetModulate
#endif
                    }},
                    {"GetModulate", new MemberRegisterInfo { Name = "GetModulate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetModulate
#endif
                    }},
                    {"SetSelfModulate", new MemberRegisterInfo { Name = "SetSelfModulate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetSelfModulate
#endif
                    }},
                    {"GetSelfModulate", new MemberRegisterInfo { Name = "GetSelfModulate", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetSelfModulate
#endif
                    }},
                    {"SetZIndex", new MemberRegisterInfo { Name = "SetZIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetZIndex
#endif
                    }},
                    {"GetZIndex", new MemberRegisterInfo { Name = "GetZIndex", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetZIndex
#endif
                    }},
                    {"SetZAsRelative", new MemberRegisterInfo { Name = "SetZAsRelative", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetZAsRelative
#endif
                    }},
                    {"IsZRelative", new MemberRegisterInfo { Name = "IsZRelative", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_IsZRelative
#endif
                    }},
                    {"SetYSortEnabled", new MemberRegisterInfo { Name = "SetYSortEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetYSortEnabled
#endif
                    }},
                    {"IsYSortEnabled", new MemberRegisterInfo { Name = "IsYSortEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_IsYSortEnabled
#endif
                    }},
                    {"SetDrawBehindParent", new MemberRegisterInfo { Name = "SetDrawBehindParent", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetDrawBehindParent
#endif
                    }},
                    {"IsDrawBehindParentEnabled", new MemberRegisterInfo { Name = "IsDrawBehindParentEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_IsDrawBehindParentEnabled
#endif
                    }},
                    {"DrawLine", new MemberRegisterInfo { Name = "DrawLine", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawLine
#endif
                    }},
                    {"DrawDashedLine", new MemberRegisterInfo { Name = "DrawDashedLine", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawDashedLine
#endif
                    }},
                    {"DrawPolyline", new MemberRegisterInfo { Name = "DrawPolyline", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawPolyline
#endif
                    }},
                    {"DrawPolylineColors", new MemberRegisterInfo { Name = "DrawPolylineColors", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawPolylineColors
#endif
                    }},
                    {"DrawArc", new MemberRegisterInfo { Name = "DrawArc", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawArc
#endif
                    }},
                    {"DrawMultiline", new MemberRegisterInfo { Name = "DrawMultiline", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawMultiline
#endif
                    }},
                    {"DrawMultilineColors", new MemberRegisterInfo { Name = "DrawMultilineColors", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawMultilineColors
#endif
                    }},
                    {"DrawRect", new MemberRegisterInfo { Name = "DrawRect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawRect
#endif
                    }},
                    {"DrawCircle", new MemberRegisterInfo { Name = "DrawCircle", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawCircle
#endif
                    }},
                    {"DrawTexture", new MemberRegisterInfo { Name = "DrawTexture", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawTexture
#endif
                    }},
                    {"DrawTextureRect", new MemberRegisterInfo { Name = "DrawTextureRect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawTextureRect
#endif
                    }},
                    {"DrawTextureRectRegion", new MemberRegisterInfo { Name = "DrawTextureRectRegion", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawTextureRectRegion
#endif
                    }},
                    {"DrawMsdfTextureRectRegion", new MemberRegisterInfo { Name = "DrawMsdfTextureRectRegion", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawMsdfTextureRectRegion
#endif
                    }},
                    {"DrawLcdTextureRectRegion", new MemberRegisterInfo { Name = "DrawLcdTextureRectRegion", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawLcdTextureRectRegion
#endif
                    }},
                    {"DrawStyleBox", new MemberRegisterInfo { Name = "DrawStyleBox", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawStyleBox
#endif
                    }},
                    {"DrawPrimitive", new MemberRegisterInfo { Name = "DrawPrimitive", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawPrimitive
#endif
                    }},
                    {"DrawPolygon", new MemberRegisterInfo { Name = "DrawPolygon", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawPolygon
#endif
                    }},
                    {"DrawColoredPolygon", new MemberRegisterInfo { Name = "DrawColoredPolygon", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawColoredPolygon
#endif
                    }},
                    {"DrawString", new MemberRegisterInfo { Name = "DrawString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawString
#endif
                    }},
                    {"DrawMultilineString", new MemberRegisterInfo { Name = "DrawMultilineString", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawMultilineString
#endif
                    }},
                    {"DrawStringOutline", new MemberRegisterInfo { Name = "DrawStringOutline", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawStringOutline
#endif
                    }},
                    {"DrawMultilineStringOutline", new MemberRegisterInfo { Name = "DrawMultilineStringOutline", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawMultilineStringOutline
#endif
                    }},
                    {"DrawChar", new MemberRegisterInfo { Name = "DrawChar", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawChar
#endif
                    }},
                    {"DrawCharOutline", new MemberRegisterInfo { Name = "DrawCharOutline", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawCharOutline
#endif
                    }},
                    {"DrawMesh", new MemberRegisterInfo { Name = "DrawMesh", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawMesh
#endif
                    }},
                    {"DrawMultimesh", new MemberRegisterInfo { Name = "DrawMultimesh", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawMultimesh
#endif
                    }},
                    {"DrawSetTransform", new MemberRegisterInfo { Name = "DrawSetTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawSetTransform
#endif
                    }},
                    {"DrawSetTransformMatrix", new MemberRegisterInfo { Name = "DrawSetTransformMatrix", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawSetTransformMatrix
#endif
                    }},
                    {"DrawAnimationSlice", new MemberRegisterInfo { Name = "DrawAnimationSlice", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawAnimationSlice
#endif
                    }},
                    {"DrawEndAnimation", new MemberRegisterInfo { Name = "DrawEndAnimation", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_DrawEndAnimation
#endif
                    }},
                    {"GetTransform", new MemberRegisterInfo { Name = "GetTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetTransform
#endif
                    }},
                    {"GetGlobalTransform", new MemberRegisterInfo { Name = "GetGlobalTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetGlobalTransform
#endif
                    }},
                    {"GetGlobalTransformWithCanvas", new MemberRegisterInfo { Name = "GetGlobalTransformWithCanvas", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetGlobalTransformWithCanvas
#endif
                    }},
                    {"GetViewportTransform", new MemberRegisterInfo { Name = "GetViewportTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetViewportTransform
#endif
                    }},
                    {"GetViewportRect", new MemberRegisterInfo { Name = "GetViewportRect", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetViewportRect
#endif
                    }},
                    {"GetCanvasTransform", new MemberRegisterInfo { Name = "GetCanvasTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetCanvasTransform
#endif
                    }},
                    {"GetScreenTransform", new MemberRegisterInfo { Name = "GetScreenTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetScreenTransform
#endif
                    }},
                    {"GetLocalMousePosition", new MemberRegisterInfo { Name = "GetLocalMousePosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetLocalMousePosition
#endif
                    }},
                    {"GetGlobalMousePosition", new MemberRegisterInfo { Name = "GetGlobalMousePosition", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetGlobalMousePosition
#endif
                    }},
                    {"GetCanvas", new MemberRegisterInfo { Name = "GetCanvas", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetCanvas
#endif
                    }},
                    {"GetCanvasLayerNode", new MemberRegisterInfo { Name = "GetCanvasLayerNode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetCanvasLayerNode
#endif
                    }},
                    {"GetWorld2D", new MemberRegisterInfo { Name = "GetWorld2D", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetWorld2D
#endif
                    }},
                    {"SetMaterial", new MemberRegisterInfo { Name = "SetMaterial", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetMaterial
#endif
                    }},
                    {"GetMaterial", new MemberRegisterInfo { Name = "GetMaterial", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetMaterial
#endif
                    }},
                    {"SetInstanceShaderParameter", new MemberRegisterInfo { Name = "SetInstanceShaderParameter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetInstanceShaderParameter
#endif
                    }},
                    {"GetInstanceShaderParameter", new MemberRegisterInfo { Name = "GetInstanceShaderParameter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetInstanceShaderParameter
#endif
                    }},
                    {"SetUseParentMaterial", new MemberRegisterInfo { Name = "SetUseParentMaterial", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetUseParentMaterial
#endif
                    }},
                    {"GetUseParentMaterial", new MemberRegisterInfo { Name = "GetUseParentMaterial", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetUseParentMaterial
#endif
                    }},
                    {"SetNotifyLocalTransform", new MemberRegisterInfo { Name = "SetNotifyLocalTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetNotifyLocalTransform
#endif
                    }},
                    {"IsLocalTransformNotificationEnabled", new MemberRegisterInfo { Name = "IsLocalTransformNotificationEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_IsLocalTransformNotificationEnabled
#endif
                    }},
                    {"SetNotifyTransform", new MemberRegisterInfo { Name = "SetNotifyTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetNotifyTransform
#endif
                    }},
                    {"IsTransformNotificationEnabled", new MemberRegisterInfo { Name = "IsTransformNotificationEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_IsTransformNotificationEnabled
#endif
                    }},
                    {"ForceUpdateTransform", new MemberRegisterInfo { Name = "ForceUpdateTransform", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_ForceUpdateTransform
#endif
                    }},
                    {"MakeCanvasPositionLocal", new MemberRegisterInfo { Name = "MakeCanvasPositionLocal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_MakeCanvasPositionLocal
#endif
                    }},
                    {"MakeInputLocal", new MemberRegisterInfo { Name = "MakeInputLocal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_MakeInputLocal
#endif
                    }},
                    {"SetVisibilityLayer", new MemberRegisterInfo { Name = "SetVisibilityLayer", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetVisibilityLayer
#endif
                    }},
                    {"GetVisibilityLayer", new MemberRegisterInfo { Name = "GetVisibilityLayer", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetVisibilityLayer
#endif
                    }},
                    {"SetVisibilityLayerBit", new MemberRegisterInfo { Name = "SetVisibilityLayerBit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetVisibilityLayerBit
#endif
                    }},
                    {"GetVisibilityLayerBit", new MemberRegisterInfo { Name = "GetVisibilityLayerBit", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetVisibilityLayerBit
#endif
                    }},
                    {"SetTextureFilter", new MemberRegisterInfo { Name = "SetTextureFilter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetTextureFilter
#endif
                    }},
                    {"GetTextureFilter", new MemberRegisterInfo { Name = "GetTextureFilter", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetTextureFilter
#endif
                    }},
                    {"SetTextureRepeat", new MemberRegisterInfo { Name = "SetTextureRepeat", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetTextureRepeat
#endif
                    }},
                    {"GetTextureRepeat", new MemberRegisterInfo { Name = "GetTextureRepeat", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetTextureRepeat
#endif
                    }},
                    {"SetClipChildrenMode", new MemberRegisterInfo { Name = "SetClipChildrenMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_SetClipChildrenMode
#endif
                    }},
                    {"GetClipChildrenMode", new MemberRegisterInfo { Name = "GetClipChildrenMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.M_GetClipChildrenMode
#endif
                    }},
                    {"add_Draw", new MemberRegisterInfo { Name = "add_Draw", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.A_Draw
#endif
                    }},
                    {"remove_Draw", new MemberRegisterInfo { Name = "remove_Draw", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.R_Draw
#endif
                    }},
                    {"add_VisibilityChanged", new MemberRegisterInfo { Name = "add_VisibilityChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.A_VisibilityChanged
#endif
                    }},
                    {"remove_VisibilityChanged", new MemberRegisterInfo { Name = "remove_VisibilityChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.R_VisibilityChanged
#endif
                    }},
                    {"add_Hidden", new MemberRegisterInfo { Name = "add_Hidden", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.A_Hidden
#endif
                    }},
                    {"remove_Hidden", new MemberRegisterInfo { Name = "remove_Hidden", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.R_Hidden
#endif
                    }},
                    {"add_ItemRectChanged", new MemberRegisterInfo { Name = "add_ItemRectChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.A_ItemRectChanged
#endif
                    }},
                    {"remove_ItemRectChanged", new MemberRegisterInfo { Name = "remove_ItemRectChanged", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_CanvasItem_Wrap.R_ItemRectChanged
#endif
                    }},
                    {"Visible", new MemberRegisterInfo { Name = "Visible", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_Visible, PropertySetter = Godot_CanvasItem_Wrap.S_Visible
#endif
                    }},
                    {"Modulate", new MemberRegisterInfo { Name = "Modulate", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_Modulate, PropertySetter = Godot_CanvasItem_Wrap.S_Modulate
#endif
                    }},
                    {"SelfModulate", new MemberRegisterInfo { Name = "SelfModulate", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_SelfModulate, PropertySetter = Godot_CanvasItem_Wrap.S_SelfModulate
#endif
                    }},
                    {"ShowBehindParent", new MemberRegisterInfo { Name = "ShowBehindParent", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_ShowBehindParent, PropertySetter = Godot_CanvasItem_Wrap.S_ShowBehindParent
#endif
                    }},
                    {"TopLevel", new MemberRegisterInfo { Name = "TopLevel", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_TopLevel, PropertySetter = Godot_CanvasItem_Wrap.S_TopLevel
#endif
                    }},
                    {"ClipChildren", new MemberRegisterInfo { Name = "ClipChildren", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_ClipChildren, PropertySetter = Godot_CanvasItem_Wrap.S_ClipChildren
#endif
                    }},
                    {"LightMask", new MemberRegisterInfo { Name = "LightMask", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_LightMask, PropertySetter = Godot_CanvasItem_Wrap.S_LightMask
#endif
                    }},
                    {"VisibilityLayer", new MemberRegisterInfo { Name = "VisibilityLayer", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_VisibilityLayer, PropertySetter = Godot_CanvasItem_Wrap.S_VisibilityLayer
#endif
                    }},
                    {"ZIndex", new MemberRegisterInfo { Name = "ZIndex", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_ZIndex, PropertySetter = Godot_CanvasItem_Wrap.S_ZIndex
#endif
                    }},
                    {"ZAsRelative", new MemberRegisterInfo { Name = "ZAsRelative", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_ZAsRelative, PropertySetter = Godot_CanvasItem_Wrap.S_ZAsRelative
#endif
                    }},
                    {"YSortEnabled", new MemberRegisterInfo { Name = "YSortEnabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_YSortEnabled, PropertySetter = Godot_CanvasItem_Wrap.S_YSortEnabled
#endif
                    }},
                    {"TextureFilter", new MemberRegisterInfo { Name = "TextureFilter", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_TextureFilter, PropertySetter = Godot_CanvasItem_Wrap.S_TextureFilter
#endif
                    }},
                    {"TextureRepeat", new MemberRegisterInfo { Name = "TextureRepeat", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_TextureRepeat, PropertySetter = Godot_CanvasItem_Wrap.S_TextureRepeat
#endif
                    }},
                    {"Material", new MemberRegisterInfo { Name = "Material", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_Material, PropertySetter = Godot_CanvasItem_Wrap.S_Material
#endif
                    }},
                    {"UseParentMaterial", new MemberRegisterInfo { Name = "UseParentMaterial", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_UseParentMaterial, PropertySetter = Godot_CanvasItem_Wrap.S_UseParentMaterial
#endif
                    }},
                    {"NotificationTransformChanged_static", new MemberRegisterInfo { Name = "NotificationTransformChanged", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_NotificationTransformChanged
#endif
                    }},
                    {"NotificationLocalTransformChanged_static", new MemberRegisterInfo { Name = "NotificationLocalTransformChanged", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_NotificationLocalTransformChanged
#endif
                    }},
                    {"NotificationDraw_static", new MemberRegisterInfo { Name = "NotificationDraw", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_NotificationDraw
#endif
                    }},
                    {"NotificationVisibilityChanged_static", new MemberRegisterInfo { Name = "NotificationVisibilityChanged", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_NotificationVisibilityChanged
#endif
                    }},
                    {"NotificationEnterCanvas_static", new MemberRegisterInfo { Name = "NotificationEnterCanvas", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_NotificationEnterCanvas
#endif
                    }},
                    {"NotificationExitCanvas_static", new MemberRegisterInfo { Name = "NotificationExitCanvas", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_NotificationExitCanvas
#endif
                    }},
                    {"NotificationWorld2DChanged_static", new MemberRegisterInfo { Name = "NotificationWorld2DChanged", IsStatic = true, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_CanvasItem_Wrap.G_NotificationWorld2DChanged
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Label_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_Label_Wrap.Constructor
#endif
                    }},
                    {"SetHorizontalAlignment", new MemberRegisterInfo { Name = "SetHorizontalAlignment", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetHorizontalAlignment
#endif
                    }},
                    {"GetHorizontalAlignment", new MemberRegisterInfo { Name = "GetHorizontalAlignment", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetHorizontalAlignment
#endif
                    }},
                    {"SetVerticalAlignment", new MemberRegisterInfo { Name = "SetVerticalAlignment", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetVerticalAlignment
#endif
                    }},
                    {"GetVerticalAlignment", new MemberRegisterInfo { Name = "GetVerticalAlignment", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetVerticalAlignment
#endif
                    }},
                    {"SetText", new MemberRegisterInfo { Name = "SetText", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetText
#endif
                    }},
                    {"GetText", new MemberRegisterInfo { Name = "GetText", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetText
#endif
                    }},
                    {"SetLabelSettings", new MemberRegisterInfo { Name = "SetLabelSettings", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetLabelSettings
#endif
                    }},
                    {"GetLabelSettings", new MemberRegisterInfo { Name = "GetLabelSettings", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetLabelSettings
#endif
                    }},
                    {"SetTextDirection", new MemberRegisterInfo { Name = "SetTextDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetTextDirection
#endif
                    }},
                    {"GetTextDirection", new MemberRegisterInfo { Name = "GetTextDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetTextDirection
#endif
                    }},
                    {"SetLanguage", new MemberRegisterInfo { Name = "SetLanguage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetLanguage
#endif
                    }},
                    {"GetLanguage", new MemberRegisterInfo { Name = "GetLanguage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetLanguage
#endif
                    }},
                    {"SetParagraphSeparator", new MemberRegisterInfo { Name = "SetParagraphSeparator", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetParagraphSeparator
#endif
                    }},
                    {"GetParagraphSeparator", new MemberRegisterInfo { Name = "GetParagraphSeparator", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetParagraphSeparator
#endif
                    }},
                    {"SetAutowrapMode", new MemberRegisterInfo { Name = "SetAutowrapMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetAutowrapMode
#endif
                    }},
                    {"GetAutowrapMode", new MemberRegisterInfo { Name = "GetAutowrapMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetAutowrapMode
#endif
                    }},
                    {"SetAutowrapTrimFlags", new MemberRegisterInfo { Name = "SetAutowrapTrimFlags", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetAutowrapTrimFlags
#endif
                    }},
                    {"GetAutowrapTrimFlags", new MemberRegisterInfo { Name = "GetAutowrapTrimFlags", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetAutowrapTrimFlags
#endif
                    }},
                    {"SetJustificationFlags", new MemberRegisterInfo { Name = "SetJustificationFlags", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetJustificationFlags
#endif
                    }},
                    {"GetJustificationFlags", new MemberRegisterInfo { Name = "GetJustificationFlags", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetJustificationFlags
#endif
                    }},
                    {"SetClipText", new MemberRegisterInfo { Name = "SetClipText", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetClipText
#endif
                    }},
                    {"IsClippingText", new MemberRegisterInfo { Name = "IsClippingText", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_IsClippingText
#endif
                    }},
                    {"SetTabStops", new MemberRegisterInfo { Name = "SetTabStops", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetTabStops
#endif
                    }},
                    {"GetTabStops", new MemberRegisterInfo { Name = "GetTabStops", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetTabStops
#endif
                    }},
                    {"SetTextOverrunBehavior", new MemberRegisterInfo { Name = "SetTextOverrunBehavior", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetTextOverrunBehavior
#endif
                    }},
                    {"GetTextOverrunBehavior", new MemberRegisterInfo { Name = "GetTextOverrunBehavior", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetTextOverrunBehavior
#endif
                    }},
                    {"SetEllipsisChar", new MemberRegisterInfo { Name = "SetEllipsisChar", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetEllipsisChar
#endif
                    }},
                    {"GetEllipsisChar", new MemberRegisterInfo { Name = "GetEllipsisChar", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetEllipsisChar
#endif
                    }},
                    {"SetUppercase", new MemberRegisterInfo { Name = "SetUppercase", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetUppercase
#endif
                    }},
                    {"IsUppercase", new MemberRegisterInfo { Name = "IsUppercase", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_IsUppercase
#endif
                    }},
                    {"GetLineHeight", new MemberRegisterInfo { Name = "GetLineHeight", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetLineHeight
#endif
                    }},
                    {"GetLineCount", new MemberRegisterInfo { Name = "GetLineCount", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetLineCount
#endif
                    }},
                    {"GetVisibleLineCount", new MemberRegisterInfo { Name = "GetVisibleLineCount", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetVisibleLineCount
#endif
                    }},
                    {"GetTotalCharacterCount", new MemberRegisterInfo { Name = "GetTotalCharacterCount", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetTotalCharacterCount
#endif
                    }},
                    {"SetVisibleCharacters", new MemberRegisterInfo { Name = "SetVisibleCharacters", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetVisibleCharacters
#endif
                    }},
                    {"GetVisibleCharacters", new MemberRegisterInfo { Name = "GetVisibleCharacters", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetVisibleCharacters
#endif
                    }},
                    {"GetVisibleCharactersBehavior", new MemberRegisterInfo { Name = "GetVisibleCharactersBehavior", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetVisibleCharactersBehavior
#endif
                    }},
                    {"SetVisibleCharactersBehavior", new MemberRegisterInfo { Name = "SetVisibleCharactersBehavior", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetVisibleCharactersBehavior
#endif
                    }},
                    {"SetVisibleRatio", new MemberRegisterInfo { Name = "SetVisibleRatio", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetVisibleRatio
#endif
                    }},
                    {"GetVisibleRatio", new MemberRegisterInfo { Name = "GetVisibleRatio", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetVisibleRatio
#endif
                    }},
                    {"SetLinesSkipped", new MemberRegisterInfo { Name = "SetLinesSkipped", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetLinesSkipped
#endif
                    }},
                    {"GetLinesSkipped", new MemberRegisterInfo { Name = "GetLinesSkipped", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetLinesSkipped
#endif
                    }},
                    {"SetMaxLinesVisible", new MemberRegisterInfo { Name = "SetMaxLinesVisible", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetMaxLinesVisible
#endif
                    }},
                    {"GetMaxLinesVisible", new MemberRegisterInfo { Name = "GetMaxLinesVisible", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetMaxLinesVisible
#endif
                    }},
                    {"SetStructuredTextBidiOverride", new MemberRegisterInfo { Name = "SetStructuredTextBidiOverride", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetStructuredTextBidiOverride
#endif
                    }},
                    {"GetStructuredTextBidiOverride", new MemberRegisterInfo { Name = "GetStructuredTextBidiOverride", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetStructuredTextBidiOverride
#endif
                    }},
                    {"SetStructuredTextBidiOverrideOptions", new MemberRegisterInfo { Name = "SetStructuredTextBidiOverrideOptions", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_SetStructuredTextBidiOverrideOptions
#endif
                    }},
                    {"GetStructuredTextBidiOverrideOptions", new MemberRegisterInfo { Name = "GetStructuredTextBidiOverrideOptions", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetStructuredTextBidiOverrideOptions
#endif
                    }},
                    {"GetCharacterBounds", new MemberRegisterInfo { Name = "GetCharacterBounds", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Label_Wrap.M_GetCharacterBounds
#endif
                    }},
                    {"Text", new MemberRegisterInfo { Name = "Text", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_Text, PropertySetter = Godot_Label_Wrap.S_Text
#endif
                    }},
                    {"LabelSettings", new MemberRegisterInfo { Name = "LabelSettings", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_LabelSettings, PropertySetter = Godot_Label_Wrap.S_LabelSettings
#endif
                    }},
                    {"HorizontalAlignment", new MemberRegisterInfo { Name = "HorizontalAlignment", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_HorizontalAlignment, PropertySetter = Godot_Label_Wrap.S_HorizontalAlignment
#endif
                    }},
                    {"VerticalAlignment", new MemberRegisterInfo { Name = "VerticalAlignment", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_VerticalAlignment, PropertySetter = Godot_Label_Wrap.S_VerticalAlignment
#endif
                    }},
                    {"AutowrapMode", new MemberRegisterInfo { Name = "AutowrapMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_AutowrapMode, PropertySetter = Godot_Label_Wrap.S_AutowrapMode
#endif
                    }},
                    {"AutowrapTrimFlags", new MemberRegisterInfo { Name = "AutowrapTrimFlags", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_AutowrapTrimFlags, PropertySetter = Godot_Label_Wrap.S_AutowrapTrimFlags
#endif
                    }},
                    {"JustificationFlags", new MemberRegisterInfo { Name = "JustificationFlags", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_JustificationFlags, PropertySetter = Godot_Label_Wrap.S_JustificationFlags
#endif
                    }},
                    {"ParagraphSeparator", new MemberRegisterInfo { Name = "ParagraphSeparator", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_ParagraphSeparator, PropertySetter = Godot_Label_Wrap.S_ParagraphSeparator
#endif
                    }},
                    {"ClipText", new MemberRegisterInfo { Name = "ClipText", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_ClipText, PropertySetter = Godot_Label_Wrap.S_ClipText
#endif
                    }},
                    {"TextOverrunBehavior", new MemberRegisterInfo { Name = "TextOverrunBehavior", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_TextOverrunBehavior, PropertySetter = Godot_Label_Wrap.S_TextOverrunBehavior
#endif
                    }},
                    {"EllipsisChar", new MemberRegisterInfo { Name = "EllipsisChar", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_EllipsisChar, PropertySetter = Godot_Label_Wrap.S_EllipsisChar
#endif
                    }},
                    {"Uppercase", new MemberRegisterInfo { Name = "Uppercase", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_Uppercase, PropertySetter = Godot_Label_Wrap.S_Uppercase
#endif
                    }},
                    {"TabStops", new MemberRegisterInfo { Name = "TabStops", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_TabStops, PropertySetter = Godot_Label_Wrap.S_TabStops
#endif
                    }},
                    {"LinesSkipped", new MemberRegisterInfo { Name = "LinesSkipped", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_LinesSkipped, PropertySetter = Godot_Label_Wrap.S_LinesSkipped
#endif
                    }},
                    {"MaxLinesVisible", new MemberRegisterInfo { Name = "MaxLinesVisible", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_MaxLinesVisible, PropertySetter = Godot_Label_Wrap.S_MaxLinesVisible
#endif
                    }},
                    {"VisibleCharacters", new MemberRegisterInfo { Name = "VisibleCharacters", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_VisibleCharacters, PropertySetter = Godot_Label_Wrap.S_VisibleCharacters
#endif
                    }},
                    {"VisibleCharactersBehavior", new MemberRegisterInfo { Name = "VisibleCharactersBehavior", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_VisibleCharactersBehavior, PropertySetter = Godot_Label_Wrap.S_VisibleCharactersBehavior
#endif
                    }},
                    {"VisibleRatio", new MemberRegisterInfo { Name = "VisibleRatio", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_VisibleRatio, PropertySetter = Godot_Label_Wrap.S_VisibleRatio
#endif
                    }},
                    {"TextDirection", new MemberRegisterInfo { Name = "TextDirection", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_TextDirection, PropertySetter = Godot_Label_Wrap.S_TextDirection
#endif
                    }},
                    {"Language", new MemberRegisterInfo { Name = "Language", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_Language, PropertySetter = Godot_Label_Wrap.S_Language
#endif
                    }},
                    {"StructuredTextBidiOverride", new MemberRegisterInfo { Name = "StructuredTextBidiOverride", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_StructuredTextBidiOverride, PropertySetter = Godot_Label_Wrap.S_StructuredTextBidiOverride
#endif
                    }},
                    {"StructuredTextBidiOverrideOptions", new MemberRegisterInfo { Name = "StructuredTextBidiOverrideOptions", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Label_Wrap.G_StructuredTextBidiOverrideOptions, PropertySetter = Godot_Label_Wrap.S_StructuredTextBidiOverrideOptions
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_BaseButton_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_BaseButton_Wrap.Constructor
#endif
                    }},
                    {"_Pressed", new MemberRegisterInfo { Name = "_Pressed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M__Pressed
#endif
                    }},
                    {"_Toggled", new MemberRegisterInfo { Name = "_Toggled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M__Toggled
#endif
                    }},
                    {"SetPressed", new MemberRegisterInfo { Name = "SetPressed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetPressed
#endif
                    }},
                    {"IsPressed", new MemberRegisterInfo { Name = "IsPressed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_IsPressed
#endif
                    }},
                    {"SetPressedNoSignal", new MemberRegisterInfo { Name = "SetPressedNoSignal", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetPressedNoSignal
#endif
                    }},
                    {"IsHovered", new MemberRegisterInfo { Name = "IsHovered", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_IsHovered
#endif
                    }},
                    {"SetToggleMode", new MemberRegisterInfo { Name = "SetToggleMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetToggleMode
#endif
                    }},
                    {"IsToggleMode", new MemberRegisterInfo { Name = "IsToggleMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_IsToggleMode
#endif
                    }},
                    {"SetShortcutInTooltip", new MemberRegisterInfo { Name = "SetShortcutInTooltip", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetShortcutInTooltip
#endif
                    }},
                    {"IsShortcutInTooltipEnabled", new MemberRegisterInfo { Name = "IsShortcutInTooltipEnabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_IsShortcutInTooltipEnabled
#endif
                    }},
                    {"SetDisabled", new MemberRegisterInfo { Name = "SetDisabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetDisabled
#endif
                    }},
                    {"IsDisabled", new MemberRegisterInfo { Name = "IsDisabled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_IsDisabled
#endif
                    }},
                    {"SetActionMode", new MemberRegisterInfo { Name = "SetActionMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetActionMode
#endif
                    }},
                    {"GetActionMode", new MemberRegisterInfo { Name = "GetActionMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_GetActionMode
#endif
                    }},
                    {"SetButtonMask", new MemberRegisterInfo { Name = "SetButtonMask", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetButtonMask
#endif
                    }},
                    {"GetButtonMask", new MemberRegisterInfo { Name = "GetButtonMask", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_GetButtonMask
#endif
                    }},
                    {"GetDrawMode", new MemberRegisterInfo { Name = "GetDrawMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_GetDrawMode
#endif
                    }},
                    {"SetKeepPressedOutside", new MemberRegisterInfo { Name = "SetKeepPressedOutside", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetKeepPressedOutside
#endif
                    }},
                    {"IsKeepPressedOutside", new MemberRegisterInfo { Name = "IsKeepPressedOutside", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_IsKeepPressedOutside
#endif
                    }},
                    {"SetShortcutFeedback", new MemberRegisterInfo { Name = "SetShortcutFeedback", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetShortcutFeedback
#endif
                    }},
                    {"IsShortcutFeedback", new MemberRegisterInfo { Name = "IsShortcutFeedback", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_IsShortcutFeedback
#endif
                    }},
                    {"SetShortcut", new MemberRegisterInfo { Name = "SetShortcut", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetShortcut
#endif
                    }},
                    {"GetShortcut", new MemberRegisterInfo { Name = "GetShortcut", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_GetShortcut
#endif
                    }},
                    {"SetButtonGroup", new MemberRegisterInfo { Name = "SetButtonGroup", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_SetButtonGroup
#endif
                    }},
                    {"GetButtonGroup", new MemberRegisterInfo { Name = "GetButtonGroup", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.M_GetButtonGroup
#endif
                    }},
                    {"add_Pressed", new MemberRegisterInfo { Name = "add_Pressed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.A_Pressed
#endif
                    }},
                    {"remove_Pressed", new MemberRegisterInfo { Name = "remove_Pressed", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.R_Pressed
#endif
                    }},
                    {"add_ButtonUp", new MemberRegisterInfo { Name = "add_ButtonUp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.A_ButtonUp
#endif
                    }},
                    {"remove_ButtonUp", new MemberRegisterInfo { Name = "remove_ButtonUp", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.R_ButtonUp
#endif
                    }},
                    {"add_ButtonDown", new MemberRegisterInfo { Name = "add_ButtonDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.A_ButtonDown
#endif
                    }},
                    {"remove_ButtonDown", new MemberRegisterInfo { Name = "remove_ButtonDown", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.R_ButtonDown
#endif
                    }},
                    {"add_Toggled", new MemberRegisterInfo { Name = "add_Toggled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.A_Toggled
#endif
                    }},
                    {"remove_Toggled", new MemberRegisterInfo { Name = "remove_Toggled", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_BaseButton_Wrap.R_Toggled
#endif
                    }},
                    {"Disabled", new MemberRegisterInfo { Name = "Disabled", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_BaseButton_Wrap.G_Disabled, PropertySetter = Godot_BaseButton_Wrap.S_Disabled
#endif
                    }},
                    {"ToggleMode", new MemberRegisterInfo { Name = "ToggleMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_BaseButton_Wrap.G_ToggleMode, PropertySetter = Godot_BaseButton_Wrap.S_ToggleMode
#endif
                    }},
                    {"ButtonPressed", new MemberRegisterInfo { Name = "ButtonPressed", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_BaseButton_Wrap.G_ButtonPressed, PropertySetter = Godot_BaseButton_Wrap.S_ButtonPressed
#endif
                    }},
                    {"ActionMode", new MemberRegisterInfo { Name = "ActionMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_BaseButton_Wrap.G_ActionMode, PropertySetter = Godot_BaseButton_Wrap.S_ActionMode
#endif
                    }},
                    {"ButtonMask", new MemberRegisterInfo { Name = "ButtonMask", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_BaseButton_Wrap.G_ButtonMask, PropertySetter = Godot_BaseButton_Wrap.S_ButtonMask
#endif
                    }},
                    {"KeepPressedOutside", new MemberRegisterInfo { Name = "KeepPressedOutside", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_BaseButton_Wrap.G_KeepPressedOutside, PropertySetter = Godot_BaseButton_Wrap.S_KeepPressedOutside
#endif
                    }},
                    {"ButtonGroup", new MemberRegisterInfo { Name = "ButtonGroup", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_BaseButton_Wrap.G_ButtonGroup, PropertySetter = Godot_BaseButton_Wrap.S_ButtonGroup
#endif
                    }},
                    {"Shortcut", new MemberRegisterInfo { Name = "Shortcut", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_BaseButton_Wrap.G_Shortcut, PropertySetter = Godot_BaseButton_Wrap.S_Shortcut
#endif
                    }},
                    {"ShortcutFeedback", new MemberRegisterInfo { Name = "ShortcutFeedback", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_BaseButton_Wrap.G_ShortcutFeedback, PropertySetter = Godot_BaseButton_Wrap.S_ShortcutFeedback
#endif
                    }},
                    {"ShortcutInTooltip", new MemberRegisterInfo { Name = "ShortcutInTooltip", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_BaseButton_Wrap.G_ShortcutInTooltip, PropertySetter = Godot_BaseButton_Wrap.S_ShortcutInTooltip
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_Button_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_Button_Wrap.Constructor
#endif
                    }},
                    {"SetText", new MemberRegisterInfo { Name = "SetText", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetText
#endif
                    }},
                    {"GetText", new MemberRegisterInfo { Name = "GetText", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetText
#endif
                    }},
                    {"SetTextOverrunBehavior", new MemberRegisterInfo { Name = "SetTextOverrunBehavior", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetTextOverrunBehavior
#endif
                    }},
                    {"GetTextOverrunBehavior", new MemberRegisterInfo { Name = "GetTextOverrunBehavior", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetTextOverrunBehavior
#endif
                    }},
                    {"SetAutowrapMode", new MemberRegisterInfo { Name = "SetAutowrapMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetAutowrapMode
#endif
                    }},
                    {"GetAutowrapMode", new MemberRegisterInfo { Name = "GetAutowrapMode", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetAutowrapMode
#endif
                    }},
                    {"SetAutowrapTrimFlags", new MemberRegisterInfo { Name = "SetAutowrapTrimFlags", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetAutowrapTrimFlags
#endif
                    }},
                    {"GetAutowrapTrimFlags", new MemberRegisterInfo { Name = "GetAutowrapTrimFlags", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetAutowrapTrimFlags
#endif
                    }},
                    {"SetTextDirection", new MemberRegisterInfo { Name = "SetTextDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetTextDirection
#endif
                    }},
                    {"GetTextDirection", new MemberRegisterInfo { Name = "GetTextDirection", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetTextDirection
#endif
                    }},
                    {"SetLanguage", new MemberRegisterInfo { Name = "SetLanguage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetLanguage
#endif
                    }},
                    {"GetLanguage", new MemberRegisterInfo { Name = "GetLanguage", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetLanguage
#endif
                    }},
                    {"SetButtonIcon", new MemberRegisterInfo { Name = "SetButtonIcon", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetButtonIcon
#endif
                    }},
                    {"GetButtonIcon", new MemberRegisterInfo { Name = "GetButtonIcon", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetButtonIcon
#endif
                    }},
                    {"SetFlat", new MemberRegisterInfo { Name = "SetFlat", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetFlat
#endif
                    }},
                    {"IsFlat", new MemberRegisterInfo { Name = "IsFlat", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_IsFlat
#endif
                    }},
                    {"SetClipText", new MemberRegisterInfo { Name = "SetClipText", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetClipText
#endif
                    }},
                    {"GetClipText", new MemberRegisterInfo { Name = "GetClipText", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetClipText
#endif
                    }},
                    {"SetTextAlignment", new MemberRegisterInfo { Name = "SetTextAlignment", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetTextAlignment
#endif
                    }},
                    {"GetTextAlignment", new MemberRegisterInfo { Name = "GetTextAlignment", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetTextAlignment
#endif
                    }},
                    {"SetIconAlignment", new MemberRegisterInfo { Name = "SetIconAlignment", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetIconAlignment
#endif
                    }},
                    {"GetIconAlignment", new MemberRegisterInfo { Name = "GetIconAlignment", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetIconAlignment
#endif
                    }},
                    {"SetVerticalIconAlignment", new MemberRegisterInfo { Name = "SetVerticalIconAlignment", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetVerticalIconAlignment
#endif
                    }},
                    {"GetVerticalIconAlignment", new MemberRegisterInfo { Name = "GetVerticalIconAlignment", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_GetVerticalIconAlignment
#endif
                    }},
                    {"SetExpandIcon", new MemberRegisterInfo { Name = "SetExpandIcon", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_SetExpandIcon
#endif
                    }},
                    {"IsExpandIcon", new MemberRegisterInfo { Name = "IsExpandIcon", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = Godot_Button_Wrap.M_IsExpandIcon
#endif
                    }},
                    {"Text", new MemberRegisterInfo { Name = "Text", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_Text, PropertySetter = Godot_Button_Wrap.S_Text
#endif
                    }},
                    {"Icon", new MemberRegisterInfo { Name = "Icon", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_Icon, PropertySetter = Godot_Button_Wrap.S_Icon
#endif
                    }},
                    {"Flat", new MemberRegisterInfo { Name = "Flat", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_Flat, PropertySetter = Godot_Button_Wrap.S_Flat
#endif
                    }},
                    {"Alignment", new MemberRegisterInfo { Name = "Alignment", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_Alignment, PropertySetter = Godot_Button_Wrap.S_Alignment
#endif
                    }},
                    {"TextOverrunBehavior", new MemberRegisterInfo { Name = "TextOverrunBehavior", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_TextOverrunBehavior, PropertySetter = Godot_Button_Wrap.S_TextOverrunBehavior
#endif
                    }},
                    {"AutowrapMode", new MemberRegisterInfo { Name = "AutowrapMode", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_AutowrapMode, PropertySetter = Godot_Button_Wrap.S_AutowrapMode
#endif
                    }},
                    {"AutowrapTrimFlags", new MemberRegisterInfo { Name = "AutowrapTrimFlags", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_AutowrapTrimFlags, PropertySetter = Godot_Button_Wrap.S_AutowrapTrimFlags
#endif
                    }},
                    {"ClipText", new MemberRegisterInfo { Name = "ClipText", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_ClipText, PropertySetter = Godot_Button_Wrap.S_ClipText
#endif
                    }},
                    {"IconAlignment", new MemberRegisterInfo { Name = "IconAlignment", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_IconAlignment, PropertySetter = Godot_Button_Wrap.S_IconAlignment
#endif
                    }},
                    {"VerticalIconAlignment", new MemberRegisterInfo { Name = "VerticalIconAlignment", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_VerticalIconAlignment, PropertySetter = Godot_Button_Wrap.S_VerticalIconAlignment
#endif
                    }},
                    {"ExpandIcon", new MemberRegisterInfo { Name = "ExpandIcon", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_ExpandIcon, PropertySetter = Godot_Button_Wrap.S_ExpandIcon
#endif
                    }},
                    {"TextDirection", new MemberRegisterInfo { Name = "TextDirection", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_TextDirection, PropertySetter = Godot_Button_Wrap.S_TextDirection
#endif
                    }},
                    {"Language", new MemberRegisterInfo { Name = "Language", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = Godot_Button_Wrap.G_Language, PropertySetter = Godot_Button_Wrap.S_Language
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_HBoxContainer_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_HBoxContainer_Wrap.Constructor
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_Godot_VBoxContainer_Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = Godot_VBoxContainer_Wrap.Constructor
#endif
                    }},
                }
            };
        }
        public static RegisterInfo GetRegisterInfo_JsComponentHook_1_Godot_Node__Wrap() 
        {
            return new RegisterInfo 
            {
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                BlittableCopy = false,
#endif

                Members = new System.Collections.Generic.Dictionary<string, MemberRegisterInfo>
                {
                    
                    {".ctor", new MemberRegisterInfo { Name = ".ctor", IsStatic = false, MemberType = MemberType.Constructor, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Constructor = JsComponentHook_1_Godot_Node__Wrap.Constructor
#endif
                    }},
                    {"_Ready", new MemberRegisterInfo { Name = "_Ready", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = JsComponentHook_1_Godot_Node__Wrap.M__Ready
#endif
                    }},
                    {"_Process", new MemberRegisterInfo { Name = "_Process", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = JsComponentHook_1_Godot_Node__Wrap.M__Process
#endif
                    }},
                    {"_PhysicsProcess", new MemberRegisterInfo { Name = "_PhysicsProcess", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = JsComponentHook_1_Godot_Node__Wrap.M__PhysicsProcess
#endif
                    }},
                    {"_Input", new MemberRegisterInfo { Name = "_Input", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = JsComponentHook_1_Godot_Node__Wrap.M__Input
#endif
                    }},
                    {"_ExitTree", new MemberRegisterInfo { Name = "_ExitTree", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = JsComponentHook_1_Godot_Node__Wrap.M__ExitTree
#endif
                    }},
                    {"JsOnReady", new MemberRegisterInfo { Name = "JsOnReady", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = JsComponentHook_1_Godot_Node__Wrap.G_JsOnReady, PropertySetter = JsComponentHook_1_Godot_Node__Wrap.S_JsOnReady
#endif
                    }},
                    {"JsOnProcess", new MemberRegisterInfo { Name = "JsOnProcess", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = JsComponentHook_1_Godot_Node__Wrap.G_JsOnProcess, PropertySetter = JsComponentHook_1_Godot_Node__Wrap.S_JsOnProcess
#endif
                    }},
                    {"JsOnPhysicsProcess", new MemberRegisterInfo { Name = "JsOnPhysicsProcess", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = JsComponentHook_1_Godot_Node__Wrap.G_JsOnPhysicsProcess, PropertySetter = JsComponentHook_1_Godot_Node__Wrap.S_JsOnPhysicsProcess
#endif
                    }},
                    {"JsOnInput", new MemberRegisterInfo { Name = "JsOnInput", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = JsComponentHook_1_Godot_Node__Wrap.G_JsOnInput, PropertySetter = JsComponentHook_1_Godot_Node__Wrap.S_JsOnInput
#endif
                    }},
                    {"JsOnExitTree", new MemberRegisterInfo { Name = "JsOnExitTree", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = JsComponentHook_1_Godot_Node__Wrap.G_JsOnExitTree, PropertySetter = JsComponentHook_1_Godot_Node__Wrap.S_JsOnExitTree
#endif
                    }},
                }
            };
        }

        public static void AddRegisterInfoGetterIntoJsEnv(JsEnv jsEnv)
        {
            
                jsEnv.AddRegisterInfoGetter(typeof(Godot.GD), GetRegisterInfo_Godot_GD_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.StringName), GetRegisterInfo_Godot_StringName_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Viewport), GetRegisterInfo_Godot_Viewport_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.NodePath), GetRegisterInfo_Godot_NodePath_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Input), GetRegisterInfo_Godot_Input_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.InputEvent), GetRegisterInfo_Godot_InputEvent_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.InputEventMouse), GetRegisterInfo_Godot_InputEventMouse_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.InputEventMouseButton), GetRegisterInfo_Godot_InputEventMouseButton_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Time), GetRegisterInfo_Godot_Time_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Node), GetRegisterInfo_Godot_Node_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Node2D), GetRegisterInfo_Godot_Node2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Vector2), GetRegisterInfo_Godot_Vector2_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Area2D), GetRegisterInfo_Godot_Area2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Sprite2D), GetRegisterInfo_Godot_Sprite2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.AnimationPlayer), GetRegisterInfo_Godot_AnimationPlayer_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.PhysicsBody2D), GetRegisterInfo_Godot_PhysicsBody2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.CharacterBody2D), GetRegisterInfo_Godot_CharacterBody2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.CollisionObject2D), GetRegisterInfo_Godot_CollisionObject2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Texture), GetRegisterInfo_Godot_Texture_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Texture2D), GetRegisterInfo_Godot_Texture2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Color), GetRegisterInfo_Godot_Color_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.CanvasItem), GetRegisterInfo_Godot_CanvasItem_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Label), GetRegisterInfo_Godot_Label_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.BaseButton), GetRegisterInfo_Godot_BaseButton_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Button), GetRegisterInfo_Godot_Button_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.HBoxContainer), GetRegisterInfo_Godot_HBoxContainer_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.VBoxContainer), GetRegisterInfo_Godot_VBoxContainer_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(JsComponentHook<Godot.Node>), GetRegisterInfo_JsComponentHook_1_Godot_Node__Wrap);
        }
    }
}