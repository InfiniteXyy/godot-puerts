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
        public static RegisterInfo GetRegisterInfo_JsComponent_Wrap() 
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
                    , Constructor = JsComponent_Wrap.Constructor
#endif
                    }},
                    {"_Ready", new MemberRegisterInfo { Name = "_Ready", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = JsComponent_Wrap.M__Ready
#endif
                    }},
                    {"_Process", new MemberRegisterInfo { Name = "_Process", IsStatic = false, MemberType = MemberType.Method, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , Method = JsComponent_Wrap.M__Process
#endif
                    }},
                    {"jsOnReady", new MemberRegisterInfo { Name = "jsOnReady", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = JsComponent_Wrap.G_jsOnReady, PropertySetter = JsComponent_Wrap.S_jsOnReady
#endif
                    }},
                    {"jsOnProcess", new MemberRegisterInfo { Name = "jsOnProcess", IsStatic = false, MemberType = MemberType.Property, UseBindingMode = BindingMode.FastBinding
#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
                    , PropertyGetter = JsComponent_Wrap.G_jsOnProcess, PropertySetter = JsComponent_Wrap.S_jsOnProcess
#endif
                    }},
                }
            };
        }

        public static void AddRegisterInfoGetterIntoJsEnv(JsEnv jsEnv)
        {
            
                jsEnv.AddRegisterInfoGetter(typeof(Godot.GD), GetRegisterInfo_Godot_GD_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.StringName), GetRegisterInfo_Godot_StringName_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.NodePath), GetRegisterInfo_Godot_NodePath_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Input), GetRegisterInfo_Godot_Input_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.InputEvent), GetRegisterInfo_Godot_InputEvent_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Node), GetRegisterInfo_Godot_Node_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Node2D), GetRegisterInfo_Godot_Node2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Vector2), GetRegisterInfo_Godot_Vector2_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Area2D), GetRegisterInfo_Godot_Area2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Sprite2D), GetRegisterInfo_Godot_Sprite2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.CollisionObject2D), GetRegisterInfo_Godot_CollisionObject2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Texture), GetRegisterInfo_Godot_Texture_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Texture2D), GetRegisterInfo_Godot_Texture2D_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.Color), GetRegisterInfo_Godot_Color_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(Godot.CanvasItem), GetRegisterInfo_Godot_CanvasItem_Wrap);
                jsEnv.AddRegisterInfoGetter(typeof(JsComponent), GetRegisterInfo_JsComponent_Wrap);
        }
    }
}