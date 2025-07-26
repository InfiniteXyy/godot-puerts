#if PUERTS_DISABLE_IL2CPP_OPTIMIZATION || (!PUERTS_IL2CPP_OPTIMIZATION && UNITY_IPHONE)
using System;
using Puerts;

namespace PuertsStaticWrap
{
#pragma warning disable 0219
#if !PUERTS_GENERAL
    [UnityEngine.Scripting.Preserve]
#endif
    public static class Godot_Texture2D_Wrap 
    {
    
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8ConstructorCallback))]
        internal static IntPtr Constructor(IntPtr isolate, IntPtr info, int paramLen, long data)
        {
            try
            {

                {

                    {
                        var result = new Godot.Texture2D();


                        return Puerts.Utils.GetObjectPtr((int)data, typeof(Godot.Texture2D), result);
                    }
                }

            } catch (Exception e) {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
            return IntPtr.Zero;
        }
    // ==================== constructor end ====================

    // ==================== methods start ====================
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M__Draw(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    ;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    ;
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Vector2 arg1 = argobj1 != null ? (Godot.Vector2)argobj1 : StaticTranslate<Godot.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        Godot.Color arg2 = argobj2 != null ? (Godot.Color)argobj2 : StaticTranslate<Godot.Color>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        bool arg3 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value3, false);

                        obj._Draw (arg0, arg1, arg2, arg3);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M__DrawRect(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    ;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    ;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    ;
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Rect2 arg1 = argobj1 != null ? (Godot.Rect2)argobj1 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);
                        Godot.Color arg3 = argobj3 != null ? (Godot.Color)argobj3 : StaticTranslate<Godot.Color>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        bool arg4 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value4, false);

                        obj._DrawRect (arg0, arg1, arg2, arg3, arg4);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M__DrawRectRegion(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    ;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    ;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    ;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    ;
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Rect2 arg1 = argobj1 != null ? (Godot.Rect2)argobj1 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        Godot.Rect2 arg2 = argobj2 != null ? (Godot.Rect2)argobj2 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        Godot.Color arg3 = argobj3 != null ? (Godot.Color)argobj3 : StaticTranslate<Godot.Color>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        bool arg4 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value4, false);
                        bool arg5 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value5, false);

                        obj._DrawRectRegion (arg0, arg1, arg2, arg3, arg4, arg5);

                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M__GetHeight(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    {

                        var result = obj._GetHeight ();

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M__GetWidth(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    {

                        var result = obj._GetWidth ();

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M__HasAlpha(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    {

                        var result = obj._HasAlpha ();

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M__IsPixelOpaque(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    ;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    ;
                    {
                        int arg0 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value0, false);
                        int arg1 = (int)PuertsDLL.GetNumberFromValue(isolate, v8Value1, false);

                        var result = obj._IsPixelOpaque (arg0, arg1);

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetWidth(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    {

                        var result = obj.GetWidth ();

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetHeight(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    {

                        var result = obj.GetHeight ();

                        Puerts.PuertsDLL.ReturnNumber(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetSize(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    {

                        var result = obj.GetSize ();

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_HasAlpha(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    {

                        var result = obj.HasAlpha ();

                        Puerts.PuertsDLL.ReturnBoolean(isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_Draw(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                if (paramLen == 4)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rid), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<Godot.Color>), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Vector2 arg1 = argobj1 != null ? (Godot.Vector2)argobj1 : StaticTranslate<Godot.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        System.Nullable<Godot.Color> arg2 = argobj2 != null ? (System.Nullable<Godot.Color>)argobj2 : StaticTranslate<System.Nullable<Godot.Color>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        bool arg3 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value3, false);

                        obj.Draw (arg0, arg1, arg2, arg3);

                        return;
                    }
                }
                if (paramLen == 3)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rid), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Vector2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<Godot.Color>), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Vector2 arg1 = argobj1 != null ? (Godot.Vector2)argobj1 : StaticTranslate<Godot.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        System.Nullable<Godot.Color> arg2 = argobj2 != null ? (System.Nullable<Godot.Color>)argobj2 : StaticTranslate<System.Nullable<Godot.Color>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.Draw (arg0, arg1, arg2, false);

                        return;
                    }
                }
                if (paramLen == 2)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rid), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Vector2), false, false, v8Value1, ref argobj1, ref argType1))
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Vector2 arg1 = argobj1 != null ? (Godot.Vector2)argobj1 : StaticTranslate<Godot.Vector2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;

                        obj.Draw (arg0, arg1, default(System.Nullable<Godot.Color>), false);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to Draw");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_DrawRect(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                if (paramLen == 5)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rid), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<Godot.Color>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Rect2 arg1 = argobj1 != null ? (Godot.Rect2)argobj1 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);
                        System.Nullable<Godot.Color> arg3 = argobj3 != null ? (System.Nullable<Godot.Color>)argobj3 : StaticTranslate<System.Nullable<Godot.Color>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        bool arg4 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value4, false);

                        obj.DrawRect (arg0, arg1, arg2, arg3, arg4);

                        return;
                    }
                }
                if (paramLen == 4)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rid), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<Godot.Color>), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Rect2 arg1 = argobj1 != null ? (Godot.Rect2)argobj1 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);
                        System.Nullable<Godot.Color> arg3 = argobj3 != null ? (System.Nullable<Godot.Color>)argobj3 : StaticTranslate<System.Nullable<Godot.Color>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        obj.DrawRect (arg0, arg1, arg2, arg3, false);

                        return;
                    }
                }
                if (paramLen == 3)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rid), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Rect2 arg1 = argobj1 != null ? (Godot.Rect2)argobj1 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        bool arg2 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value2, false);

                        obj.DrawRect (arg0, arg1, arg2, default(System.Nullable<Godot.Color>), false);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawRect");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_DrawRectRegion(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                if (paramLen == 6)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    IntPtr v8Value5 = PuertsDLL.GetArgumentValue(isolate, info, 5);
                    object argobj5 = null;
                    JsValueType argType5 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rid), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<Godot.Color>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value4, ref argobj4, ref argType4) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value5, ref argobj5, ref argType5))
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Rect2 arg1 = argobj1 != null ? (Godot.Rect2)argobj1 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        Godot.Rect2 arg2 = argobj2 != null ? (Godot.Rect2)argobj2 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Nullable<Godot.Color> arg3 = argobj3 != null ? (System.Nullable<Godot.Color>)argobj3 : StaticTranslate<System.Nullable<Godot.Color>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        bool arg4 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value4, false);
                        bool arg5 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value5, false);

                        obj.DrawRectRegion (arg0, arg1, arg2, arg3, arg4, arg5);

                        return;
                    }
                }
                if (paramLen == 5)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    IntPtr v8Value4 = PuertsDLL.GetArgumentValue(isolate, info, 4);
                    object argobj4 = null;
                    JsValueType argType4 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rid), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<Godot.Color>), false, false, v8Value3, ref argobj3, ref argType3) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.Boolean, typeof(bool), false, false, v8Value4, ref argobj4, ref argType4))
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Rect2 arg1 = argobj1 != null ? (Godot.Rect2)argobj1 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        Godot.Rect2 arg2 = argobj2 != null ? (Godot.Rect2)argobj2 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Nullable<Godot.Color> arg3 = argobj3 != null ? (System.Nullable<Godot.Color>)argobj3 : StaticTranslate<System.Nullable<Godot.Color>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;
                        bool arg4 = (bool)PuertsDLL.GetBooleanFromValue(isolate, v8Value4, false);

                        obj.DrawRectRegion (arg0, arg1, arg2, arg3, arg4, true);

                        return;
                    }
                }
                if (paramLen == 4)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    IntPtr v8Value3 = PuertsDLL.GetArgumentValue(isolate, info, 3);
                    object argobj3 = null;
                    JsValueType argType3 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rid), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value2, ref argobj2, ref argType2) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NullOrUndefined | Puerts.JsValueType.NativeObject, typeof(System.Nullable<Godot.Color>), false, false, v8Value3, ref argobj3, ref argType3))
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Rect2 arg1 = argobj1 != null ? (Godot.Rect2)argobj1 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        Godot.Rect2 arg2 = argobj2 != null ? (Godot.Rect2)argobj2 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;
                        System.Nullable<Godot.Color> arg3 = argobj3 != null ? (System.Nullable<Godot.Color>)argobj3 : StaticTranslate<System.Nullable<Godot.Color>>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value3, false);;

                        obj.DrawRectRegion (arg0, arg1, arg2, arg3, false, true);

                        return;
                    }
                }
                if (paramLen == 3)
                {
            
                    IntPtr v8Value0 = PuertsDLL.GetArgumentValue(isolate, info, 0);
                    object argobj0 = null;
                    JsValueType argType0 = JsValueType.Invalid;
                    IntPtr v8Value1 = PuertsDLL.GetArgumentValue(isolate, info, 1);
                    object argobj1 = null;
                    JsValueType argType1 = JsValueType.Invalid;
                    IntPtr v8Value2 = PuertsDLL.GetArgumentValue(isolate, info, 2);
                    object argobj2 = null;
                    JsValueType argType2 = JsValueType.Invalid;
                    if (ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rid), false, false, v8Value0, ref argobj0, ref argType0) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value1, ref argobj1, ref argType1) && ArgHelper.IsMatch((int)data, isolate, Puerts.JsValueType.NativeObject, typeof(Godot.Rect2), false, false, v8Value2, ref argobj2, ref argType2))
                    {
                        Godot.Rid arg0 = argobj0 != null ? (Godot.Rid)argobj0 : StaticTranslate<Godot.Rid>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value0, false);;
                        Godot.Rect2 arg1 = argobj1 != null ? (Godot.Rect2)argobj1 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value1, false);;
                        Godot.Rect2 arg2 = argobj2 != null ? (Godot.Rect2)argobj2 : StaticTranslate<Godot.Rect2>.Get((int)data, isolate, NativeValueApi.GetValueFromArgument, v8Value2, false);;

                        obj.DrawRectRegion (arg0, arg1, arg2, default(System.Nullable<Godot.Color>), false, true);

                        return;
                    }
                }
                Puerts.PuertsDLL.ThrowException(isolate, "invalid arguments to DrawRectRegion");
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_GetImage(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    {

                        var result = obj.GetImage ();

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
        [Puerts.MonoPInvokeCallback(typeof(Puerts.V8FunctionCallback))]
        internal static void M_CreatePlaceholder(IntPtr isolate, IntPtr info, IntPtr self, int paramLen, long data)
        {
            try
            {
                var obj = Puerts.Utils.GetSelf((int)data, self) as Godot.Texture2D;
        
                {
            
                    {

                        var result = obj.CreatePlaceholder ();

                        Puerts.ResultHelper.Set((int)data, isolate, info, result);
                    }
                }
            }
            catch (Exception e)
            {
                Puerts.PuertsDLL.ThrowException(isolate, "c# exception:" + e.Message + ",stack:" + e.StackTrace);
            }
        }
    // ==================== methods end ====================

    // ==================== properties start ====================
    // ==================== properties end ====================
    // ==================== array item get/set start ====================
    
    
    // ==================== array item get/set end ====================
    // ==================== operator start ====================
    // ==================== operator end ====================
    // ==================== events start ====================
    // ==================== events end ====================

    
    }
#pragma warning disable 0219
}
#endif
