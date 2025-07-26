
    declare namespace CS {
    //keep type incompatibility / 此属性保持类型不兼容
    const __keep_incompatibility: unique symbol;
    interface $Ref<T> {
        __doNoAccess: T
    }
    namespace System {
        interface Array$1<T> extends System.Array {
            get_Item(index: number):T;
            set_Item(index: number, value: T):void;
        }
    }
    interface $Task<T> {}
    namespace System {
        class Object
        {
            protected [__keep_incompatibility]: never;
        }
        class ValueType extends System.Object
        {
            protected [__keep_incompatibility]: never;
        }
        interface IDisposable
        {
        }
        class Byte extends System.ValueType implements System.IComparable, System.IConvertible, System.ISpanFormattable, System.IFormattable, System.IComparable$1<number>, System.IEquatable$1<number>, System.Numerics.IBinaryInteger$1<number>, System.Numerics.IBinaryNumber$1<number>, System.Numerics.IBitwiseOperators$3<number, number, number>, System.Numerics.INumber$1<number>, System.Numerics.IComparisonOperators$3<number, number, boolean>, System.Numerics.IEqualityOperators$3<number, number, boolean>, System.Numerics.IModulusOperators$3<number, number, number>, System.Numerics.INumberBase$1<number>, System.Numerics.IAdditionOperators$3<number, number, number>, System.Numerics.IAdditiveIdentity$2<number, number>, System.Numerics.IDecrementOperators$1<number>, System.Numerics.IDivisionOperators$3<number, number, number>, System.Numerics.IIncrementOperators$1<number>, System.Numerics.IMultiplicativeIdentity$2<number, number>, System.Numerics.IMultiplyOperators$3<number, number, number>, System.ISpanParsable$1<number>, System.IParsable$1<number>, System.Numerics.ISubtractionOperators$3<number, number, number>, System.Numerics.IUnaryPlusOperators$2<number, number>, System.Numerics.IUnaryNegationOperators$2<number, number>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<number>, System.Numerics.IShiftOperators$3<number, number, number>, System.Numerics.IMinMaxValue$1<number>, System.Numerics.IUnsignedNumber$1<number>, System.IUtfChar$1<number>, System.IBinaryIntegerParseAndFormatInfo$1<number>
        {
            protected [__keep_incompatibility]: never;
        }
        interface IComparable
        {
        }
        interface IConvertible
        {
        }
        interface ISpanFormattable extends System.IFormattable
        {
        }
        interface IFormattable
        {
        }
        interface IComparable$1<T>
        {
        }
        interface IEquatable$1<T>
        {
        }
        class Boolean extends System.ValueType implements System.IComparable, System.IConvertible, System.IComparable$1<boolean>, System.IEquatable$1<boolean>, System.ISpanParsable$1<boolean>, System.IParsable$1<boolean>
        {
            protected [__keep_incompatibility]: never;
        }
        interface ISpanParsable$1<TSelf> extends System.IParsable$1<TSelf>
        {
        }
        interface IParsable$1<TSelf>
        {
        }
        interface IUtf8SpanFormattable
        {
        }
        interface IUtf8SpanParsable$1<TSelf>
        {
        }
        class Int32 extends System.ValueType implements System.IComparable, System.IConvertible, System.ISpanFormattable, System.IFormattable, System.IComparable$1<number>, System.IEquatable$1<number>, System.Numerics.IBinaryInteger$1<number>, System.Numerics.IBinaryNumber$1<number>, System.Numerics.IBitwiseOperators$3<number, number, number>, System.Numerics.INumber$1<number>, System.Numerics.IComparisonOperators$3<number, number, boolean>, System.Numerics.IEqualityOperators$3<number, number, boolean>, System.Numerics.IModulusOperators$3<number, number, number>, System.Numerics.INumberBase$1<number>, System.Numerics.IAdditionOperators$3<number, number, number>, System.Numerics.IAdditiveIdentity$2<number, number>, System.Numerics.IDecrementOperators$1<number>, System.Numerics.IDivisionOperators$3<number, number, number>, System.Numerics.IIncrementOperators$1<number>, System.Numerics.IMultiplicativeIdentity$2<number, number>, System.Numerics.IMultiplyOperators$3<number, number, number>, System.ISpanParsable$1<number>, System.IParsable$1<number>, System.Numerics.ISubtractionOperators$3<number, number, number>, System.Numerics.IUnaryPlusOperators$2<number, number>, System.Numerics.IUnaryNegationOperators$2<number, number>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<number>, System.Numerics.IShiftOperators$3<number, number, number>, System.Numerics.IMinMaxValue$1<number>, System.Numerics.ISignedNumber$1<number>, System.IBinaryIntegerParseAndFormatInfo$1<number>
        {
            protected [__keep_incompatibility]: never;
        }
        interface IBinaryIntegerParseAndFormatInfo$1<TSelf> extends System.Numerics.IBinaryInteger$1<TSelf>, System.Numerics.IBinaryNumber$1<TSelf>, System.Numerics.IBitwiseOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumber$1<TSelf>, System.IComparable, System.IComparable$1<TSelf>, System.Numerics.IComparisonOperators$3<TSelf, TSelf, boolean>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IModulusOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>, System.Numerics.IShiftOperators$3<TSelf, number, TSelf>, System.Numerics.IMinMaxValue$1<TSelf>
        {
        }
        interface IUtfChar$1<TSelf> extends System.Numerics.IBinaryInteger$1<TSelf>, System.Numerics.IBinaryNumber$1<TSelf>, System.Numerics.IBitwiseOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumber$1<TSelf>, System.IComparable, System.IComparable$1<TSelf>, System.Numerics.IComparisonOperators$3<TSelf, TSelf, boolean>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IModulusOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>, System.Numerics.IShiftOperators$3<TSelf, number, TSelf>
        {
        }
        class Span$1<T> extends System.ValueType
        {
            protected [__keep_incompatibility]: never;
        }
        class Enum extends System.ValueType implements System.IComparable, System.ISpanFormattable, System.IFormattable, System.IConvertible
        {
            protected [__keep_incompatibility]: never;
        }
        class String extends System.Object implements System.IComparable, System.Collections.IEnumerable, System.IConvertible, System.Collections.Generic.IEnumerable$1<number>, System.IComparable$1<string>, System.IEquatable$1<string>, System.ICloneable, System.ISpanParsable$1<string>, System.IParsable$1<string>
        {
            protected [__keep_incompatibility]: never;
        }
        class Char extends System.ValueType implements System.IComparable, System.IComparable$1<number>, System.IEquatable$1<number>, System.IConvertible, System.ISpanFormattable, System.IFormattable, System.Numerics.IBinaryInteger$1<number>, System.Numerics.IBinaryNumber$1<number>, System.Numerics.IBitwiseOperators$3<number, number, number>, System.Numerics.INumber$1<number>, System.Numerics.IComparisonOperators$3<number, number, boolean>, System.Numerics.IEqualityOperators$3<number, number, boolean>, System.Numerics.IModulusOperators$3<number, number, number>, System.Numerics.INumberBase$1<number>, System.Numerics.IAdditionOperators$3<number, number, number>, System.Numerics.IAdditiveIdentity$2<number, number>, System.Numerics.IDecrementOperators$1<number>, System.Numerics.IDivisionOperators$3<number, number, number>, System.Numerics.IIncrementOperators$1<number>, System.Numerics.IMultiplicativeIdentity$2<number, number>, System.Numerics.IMultiplyOperators$3<number, number, number>, System.ISpanParsable$1<number>, System.IParsable$1<number>, System.Numerics.ISubtractionOperators$3<number, number, number>, System.Numerics.IUnaryPlusOperators$2<number, number>, System.Numerics.IUnaryNegationOperators$2<number, number>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<number>, System.Numerics.IShiftOperators$3<number, number, number>, System.Numerics.IMinMaxValue$1<number>, System.Numerics.IUnsignedNumber$1<number>, System.IUtfChar$1<number>, System.IBinaryIntegerParseAndFormatInfo$1<number>
        {
            protected [__keep_incompatibility]: never;
        }
        interface ICloneable
        {
        }
        class Void extends System.ValueType
        {
            protected [__keep_incompatibility]: never;
        }
        class Array extends System.Object implements System.ICloneable, System.Collections.IList, System.Collections.ICollection, System.Collections.IEnumerable, System.Collections.IStructuralComparable, System.Collections.IStructuralEquatable
        {
            protected [__keep_incompatibility]: never;
        }
        class Single extends System.ValueType implements System.IComparable, System.IConvertible, System.ISpanFormattable, System.IFormattable, System.IComparable$1<number>, System.IEquatable$1<number>, System.Numerics.IBinaryFloatingPointIeee754$1<number>, System.Numerics.IBinaryNumber$1<number>, System.Numerics.IBitwiseOperators$3<number, number, number>, System.Numerics.INumber$1<number>, System.Numerics.IComparisonOperators$3<number, number, boolean>, System.Numerics.IEqualityOperators$3<number, number, boolean>, System.Numerics.IModulusOperators$3<number, number, number>, System.Numerics.INumberBase$1<number>, System.Numerics.IAdditionOperators$3<number, number, number>, System.Numerics.IAdditiveIdentity$2<number, number>, System.Numerics.IDecrementOperators$1<number>, System.Numerics.IDivisionOperators$3<number, number, number>, System.Numerics.IIncrementOperators$1<number>, System.Numerics.IMultiplicativeIdentity$2<number, number>, System.Numerics.IMultiplyOperators$3<number, number, number>, System.ISpanParsable$1<number>, System.IParsable$1<number>, System.Numerics.ISubtractionOperators$3<number, number, number>, System.Numerics.IUnaryPlusOperators$2<number, number>, System.Numerics.IUnaryNegationOperators$2<number, number>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<number>, System.Numerics.IFloatingPointIeee754$1<number>, System.Numerics.IExponentialFunctions$1<number>, System.Numerics.IFloatingPointConstants$1<number>, System.Numerics.IFloatingPoint$1<number>, System.Numerics.ISignedNumber$1<number>, System.Numerics.IHyperbolicFunctions$1<number>, System.Numerics.ILogarithmicFunctions$1<number>, System.Numerics.IPowerFunctions$1<number>, System.Numerics.IRootFunctions$1<number>, System.Numerics.ITrigonometricFunctions$1<number>, System.Numerics.IMinMaxValue$1<number>, System.IBinaryFloatParseAndFormatInfo$1<number>
        {
            protected [__keep_incompatibility]: never;
        }
        interface IBinaryFloatParseAndFormatInfo$1<TSelf> extends System.Numerics.IBinaryFloatingPointIeee754$1<TSelf>, System.Numerics.IBinaryNumber$1<TSelf>, System.Numerics.IBitwiseOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumber$1<TSelf>, System.IComparable, System.IComparable$1<TSelf>, System.Numerics.IComparisonOperators$3<TSelf, TSelf, boolean>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IModulusOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>, System.Numerics.IFloatingPointIeee754$1<TSelf>, System.Numerics.IExponentialFunctions$1<TSelf>, System.Numerics.IFloatingPointConstants$1<TSelf>, System.Numerics.IFloatingPoint$1<TSelf>, System.Numerics.ISignedNumber$1<TSelf>, System.Numerics.IHyperbolicFunctions$1<TSelf>, System.Numerics.ILogarithmicFunctions$1<TSelf>, System.Numerics.IPowerFunctions$1<TSelf>, System.Numerics.IRootFunctions$1<TSelf>, System.Numerics.ITrigonometricFunctions$1<TSelf>, System.Numerics.IMinMaxValue$1<TSelf>
        {
        }
        class Double extends System.ValueType implements System.IComparable, System.IConvertible, System.ISpanFormattable, System.IFormattable, System.IComparable$1<number>, System.IEquatable$1<number>, System.Numerics.IBinaryFloatingPointIeee754$1<number>, System.Numerics.IBinaryNumber$1<number>, System.Numerics.IBitwiseOperators$3<number, number, number>, System.Numerics.INumber$1<number>, System.Numerics.IComparisonOperators$3<number, number, boolean>, System.Numerics.IEqualityOperators$3<number, number, boolean>, System.Numerics.IModulusOperators$3<number, number, number>, System.Numerics.INumberBase$1<number>, System.Numerics.IAdditionOperators$3<number, number, number>, System.Numerics.IAdditiveIdentity$2<number, number>, System.Numerics.IDecrementOperators$1<number>, System.Numerics.IDivisionOperators$3<number, number, number>, System.Numerics.IIncrementOperators$1<number>, System.Numerics.IMultiplicativeIdentity$2<number, number>, System.Numerics.IMultiplyOperators$3<number, number, number>, System.ISpanParsable$1<number>, System.IParsable$1<number>, System.Numerics.ISubtractionOperators$3<number, number, number>, System.Numerics.IUnaryPlusOperators$2<number, number>, System.Numerics.IUnaryNegationOperators$2<number, number>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<number>, System.Numerics.IFloatingPointIeee754$1<number>, System.Numerics.IExponentialFunctions$1<number>, System.Numerics.IFloatingPointConstants$1<number>, System.Numerics.IFloatingPoint$1<number>, System.Numerics.ISignedNumber$1<number>, System.Numerics.IHyperbolicFunctions$1<number>, System.Numerics.ILogarithmicFunctions$1<number>, System.Numerics.IPowerFunctions$1<number>, System.Numerics.IRootFunctions$1<number>, System.Numerics.ITrigonometricFunctions$1<number>, System.Numerics.IMinMaxValue$1<number>, System.IBinaryFloatParseAndFormatInfo$1<number>
        {
            protected [__keep_incompatibility]: never;
        }
        class UInt32 extends System.ValueType implements System.IComparable, System.IConvertible, System.ISpanFormattable, System.IFormattable, System.IComparable$1<number>, System.IEquatable$1<number>, System.Numerics.IBinaryInteger$1<number>, System.Numerics.IBinaryNumber$1<number>, System.Numerics.IBitwiseOperators$3<number, number, number>, System.Numerics.INumber$1<number>, System.Numerics.IComparisonOperators$3<number, number, boolean>, System.Numerics.IEqualityOperators$3<number, number, boolean>, System.Numerics.IModulusOperators$3<number, number, number>, System.Numerics.INumberBase$1<number>, System.Numerics.IAdditionOperators$3<number, number, number>, System.Numerics.IAdditiveIdentity$2<number, number>, System.Numerics.IDecrementOperators$1<number>, System.Numerics.IDivisionOperators$3<number, number, number>, System.Numerics.IIncrementOperators$1<number>, System.Numerics.IMultiplicativeIdentity$2<number, number>, System.Numerics.IMultiplyOperators$3<number, number, number>, System.ISpanParsable$1<number>, System.IParsable$1<number>, System.Numerics.ISubtractionOperators$3<number, number, number>, System.Numerics.IUnaryPlusOperators$2<number, number>, System.Numerics.IUnaryNegationOperators$2<number, number>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<number>, System.Numerics.IShiftOperators$3<number, number, number>, System.Numerics.IMinMaxValue$1<number>, System.Numerics.IUnsignedNumber$1<number>, System.IBinaryIntegerParseAndFormatInfo$1<number>
        {
            protected [__keep_incompatibility]: never;
        }
        class UInt64 extends System.ValueType implements System.IComparable, System.IConvertible, System.ISpanFormattable, System.IFormattable, System.IComparable$1<bigint>, System.IEquatable$1<bigint>, System.Numerics.IBinaryInteger$1<bigint>, System.Numerics.IBinaryNumber$1<bigint>, System.Numerics.IBitwiseOperators$3<bigint, bigint, bigint>, System.Numerics.INumber$1<bigint>, System.Numerics.IComparisonOperators$3<bigint, bigint, boolean>, System.Numerics.IEqualityOperators$3<bigint, bigint, boolean>, System.Numerics.IModulusOperators$3<bigint, bigint, bigint>, System.Numerics.INumberBase$1<bigint>, System.Numerics.IAdditionOperators$3<bigint, bigint, bigint>, System.Numerics.IAdditiveIdentity$2<bigint, bigint>, System.Numerics.IDecrementOperators$1<bigint>, System.Numerics.IDivisionOperators$3<bigint, bigint, bigint>, System.Numerics.IIncrementOperators$1<bigint>, System.Numerics.IMultiplicativeIdentity$2<bigint, bigint>, System.Numerics.IMultiplyOperators$3<bigint, bigint, bigint>, System.ISpanParsable$1<bigint>, System.IParsable$1<bigint>, System.Numerics.ISubtractionOperators$3<bigint, bigint, bigint>, System.Numerics.IUnaryPlusOperators$2<bigint, bigint>, System.Numerics.IUnaryNegationOperators$2<bigint, bigint>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<bigint>, System.Numerics.IShiftOperators$3<bigint, number, bigint>, System.Numerics.IMinMaxValue$1<bigint>, System.Numerics.IUnsignedNumber$1<bigint>, System.IBinaryIntegerParseAndFormatInfo$1<bigint>
        {
            protected [__keep_incompatibility]: never;
        }
        class Type extends System.Reflection.MemberInfo implements System.Reflection.ICustomAttributeProvider, System.Reflection.IReflect
        {
            protected [__keep_incompatibility]: never;
            public static Delimiter : number
            public static EmptyTypes : System.Array$1<System.Type>
            public static Missing : any
            public static FilterAttribute : System.Reflection.MemberFilter
            public static FilterName : System.Reflection.MemberFilter
            public static FilterNameIgnoreCase : System.Reflection.MemberFilter
            public get MemberType(): System.Reflection.MemberTypes;
            public get Namespace(): string;
            public get AssemblyQualifiedName(): string;
            public get FullName(): string;
            public get Assembly(): System.Reflection.Assembly;
            public get Module(): System.Reflection.Module;
            public get IsInterface(): boolean;
            public get IsNested(): boolean;
            public get DeclaringType(): System.Type;
            public get DeclaringMethod(): System.Reflection.MethodBase;
            public get ReflectedType(): System.Type;
            public get UnderlyingSystemType(): System.Type;
            public get IsTypeDefinition(): boolean;
            public get IsArray(): boolean;
            public get IsByRef(): boolean;
            public get IsPointer(): boolean;
            public get IsConstructedGenericType(): boolean;
            public get IsGenericParameter(): boolean;
            public get IsGenericTypeParameter(): boolean;
            public get IsGenericMethodParameter(): boolean;
            public get IsGenericType(): boolean;
            public get IsGenericTypeDefinition(): boolean;
            public get IsSZArray(): boolean;
            public get IsVariableBoundArray(): boolean;
            public get IsByRefLike(): boolean;
            public get IsFunctionPointer(): boolean;
            public get IsUnmanagedFunctionPointer(): boolean;
            public get HasElementType(): boolean;
            public get GenericTypeArguments(): System.Array$1<System.Type>;
            public get GenericParameterPosition(): number;
            public get GenericParameterAttributes(): System.Reflection.GenericParameterAttributes;
            public get Attributes(): System.Reflection.TypeAttributes;
            public get IsAbstract(): boolean;
            public get IsImport(): boolean;
            public get IsSealed(): boolean;
            public get IsSpecialName(): boolean;
            public get IsClass(): boolean;
            public get IsNestedAssembly(): boolean;
            public get IsNestedFamANDAssem(): boolean;
            public get IsNestedFamily(): boolean;
            public get IsNestedFamORAssem(): boolean;
            public get IsNestedPrivate(): boolean;
            public get IsNestedPublic(): boolean;
            public get IsNotPublic(): boolean;
            public get IsPublic(): boolean;
            public get IsAutoLayout(): boolean;
            public get IsExplicitLayout(): boolean;
            public get IsLayoutSequential(): boolean;
            public get IsAnsiClass(): boolean;
            public get IsAutoClass(): boolean;
            public get IsUnicodeClass(): boolean;
            public get IsCOMObject(): boolean;
            public get IsContextful(): boolean;
            public get IsEnum(): boolean;
            public get IsMarshalByRef(): boolean;
            public get IsPrimitive(): boolean;
            public get IsValueType(): boolean;
            public get IsSignatureType(): boolean;
            public get IsSecurityCritical(): boolean;
            public get IsSecuritySafeCritical(): boolean;
            public get IsSecurityTransparent(): boolean;
            public get StructLayoutAttribute(): System.Runtime.InteropServices.StructLayoutAttribute;
            public get TypeInitializer(): System.Reflection.ConstructorInfo;
            public get TypeHandle(): System.RuntimeTypeHandle;
            public get GUID(): System.Guid;
            public get BaseType(): System.Type;
            public static get DefaultBinder(): System.Reflection.Binder;
            public get ContainsGenericParameters(): boolean;
            public get IsVisible(): boolean;
            public static GetType ($typeName: string, $throwOnError: boolean, $ignoreCase: boolean) : System.Type
            public static GetType ($typeName: string, $throwOnError: boolean) : System.Type
            public static GetType ($typeName: string) : System.Type
            public static GetType ($typeName: string, $assemblyResolver: System.Func$2<System.Reflection.AssemblyName, System.Reflection.Assembly>, $typeResolver: System.Func$4<System.Reflection.Assembly, string, boolean, System.Type>) : System.Type
            public static GetType ($typeName: string, $assemblyResolver: System.Func$2<System.Reflection.AssemblyName, System.Reflection.Assembly>, $typeResolver: System.Func$4<System.Reflection.Assembly, string, boolean, System.Type>, $throwOnError: boolean) : System.Type
            public static GetType ($typeName: string, $assemblyResolver: System.Func$2<System.Reflection.AssemblyName, System.Reflection.Assembly>, $typeResolver: System.Func$4<System.Reflection.Assembly, string, boolean, System.Type>, $throwOnError: boolean, $ignoreCase: boolean) : System.Type
            public static GetTypeFromHandle ($handle: System.RuntimeTypeHandle) : System.Type
            public GetType () : System.Type
            public GetElementType () : System.Type
            public GetArrayRank () : number
            public GetGenericTypeDefinition () : System.Type
            public GetGenericArguments () : System.Array$1<System.Type>
            public GetOptionalCustomModifiers () : System.Array$1<System.Type>
            public GetRequiredCustomModifiers () : System.Array$1<System.Type>
            public GetGenericParameterConstraints () : System.Array$1<System.Type>
            public IsAssignableTo ($targetType: System.Type) : boolean
            public GetConstructor ($types: System.Array$1<System.Type>) : System.Reflection.ConstructorInfo
            public GetConstructor ($bindingAttr: System.Reflection.BindingFlags, $types: System.Array$1<System.Type>) : System.Reflection.ConstructorInfo
            public GetConstructor ($bindingAttr: System.Reflection.BindingFlags, $binder: System.Reflection.Binder, $types: System.Array$1<System.Type>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>) : System.Reflection.ConstructorInfo
            public GetConstructor ($bindingAttr: System.Reflection.BindingFlags, $binder: System.Reflection.Binder, $callConvention: System.Reflection.CallingConventions, $types: System.Array$1<System.Type>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>) : System.Reflection.ConstructorInfo
            public GetConstructors () : System.Array$1<System.Reflection.ConstructorInfo>
            public GetConstructors ($bindingAttr: System.Reflection.BindingFlags) : System.Array$1<System.Reflection.ConstructorInfo>
            public GetEvent ($name: string) : System.Reflection.EventInfo
            public GetEvent ($name: string, $bindingAttr: System.Reflection.BindingFlags) : System.Reflection.EventInfo
            public GetEvents () : System.Array$1<System.Reflection.EventInfo>
            public GetEvents ($bindingAttr: System.Reflection.BindingFlags) : System.Array$1<System.Reflection.EventInfo>
            public GetField ($name: string) : System.Reflection.FieldInfo
            public GetField ($name: string, $bindingAttr: System.Reflection.BindingFlags) : System.Reflection.FieldInfo
            public GetFields () : System.Array$1<System.Reflection.FieldInfo>
            public GetFields ($bindingAttr: System.Reflection.BindingFlags) : System.Array$1<System.Reflection.FieldInfo>
            public GetFunctionPointerCallingConventions () : System.Array$1<System.Type>
            public GetFunctionPointerReturnType () : System.Type
            public GetFunctionPointerParameterTypes () : System.Array$1<System.Type>
            public GetMember ($name: string) : System.Array$1<System.Reflection.MemberInfo>
            public GetMember ($name: string, $bindingAttr: System.Reflection.BindingFlags) : System.Array$1<System.Reflection.MemberInfo>
            public GetMember ($name: string, $type: System.Reflection.MemberTypes, $bindingAttr: System.Reflection.BindingFlags) : System.Array$1<System.Reflection.MemberInfo>
            public GetMembers () : System.Array$1<System.Reflection.MemberInfo>
            public GetMemberWithSameMetadataDefinitionAs ($member: System.Reflection.MemberInfo) : System.Reflection.MemberInfo
            public GetMembers ($bindingAttr: System.Reflection.BindingFlags) : System.Array$1<System.Reflection.MemberInfo>
            public GetMethod ($name: string) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $bindingAttr: System.Reflection.BindingFlags) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $bindingAttr: System.Reflection.BindingFlags, $types: System.Array$1<System.Type>) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $types: System.Array$1<System.Type>) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $types: System.Array$1<System.Type>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $bindingAttr: System.Reflection.BindingFlags, $binder: System.Reflection.Binder, $types: System.Array$1<System.Type>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $bindingAttr: System.Reflection.BindingFlags, $binder: System.Reflection.Binder, $callConvention: System.Reflection.CallingConventions, $types: System.Array$1<System.Type>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $genericParameterCount: number, $types: System.Array$1<System.Type>) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $genericParameterCount: number, $types: System.Array$1<System.Type>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $genericParameterCount: number, $bindingAttr: System.Reflection.BindingFlags, $types: System.Array$1<System.Type>) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $genericParameterCount: number, $bindingAttr: System.Reflection.BindingFlags, $binder: System.Reflection.Binder, $types: System.Array$1<System.Type>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>) : System.Reflection.MethodInfo
            public GetMethod ($name: string, $genericParameterCount: number, $bindingAttr: System.Reflection.BindingFlags, $binder: System.Reflection.Binder, $callConvention: System.Reflection.CallingConventions, $types: System.Array$1<System.Type>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>) : System.Reflection.MethodInfo
            public GetMethods () : System.Array$1<System.Reflection.MethodInfo>
            public GetMethods ($bindingAttr: System.Reflection.BindingFlags) : System.Array$1<System.Reflection.MethodInfo>
            public GetNestedType ($name: string) : System.Type
            public GetNestedType ($name: string, $bindingAttr: System.Reflection.BindingFlags) : System.Type
            public GetNestedTypes () : System.Array$1<System.Type>
            public GetNestedTypes ($bindingAttr: System.Reflection.BindingFlags) : System.Array$1<System.Type>
            public GetProperty ($name: string) : System.Reflection.PropertyInfo
            public GetProperty ($name: string, $bindingAttr: System.Reflection.BindingFlags) : System.Reflection.PropertyInfo
            public GetProperty ($name: string, $returnType: System.Type) : System.Reflection.PropertyInfo
            public GetProperty ($name: string, $types: System.Array$1<System.Type>) : System.Reflection.PropertyInfo
            public GetProperty ($name: string, $returnType: System.Type, $types: System.Array$1<System.Type>) : System.Reflection.PropertyInfo
            public GetProperty ($name: string, $returnType: System.Type, $types: System.Array$1<System.Type>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>) : System.Reflection.PropertyInfo
            public GetProperty ($name: string, $bindingAttr: System.Reflection.BindingFlags, $binder: System.Reflection.Binder, $returnType: System.Type, $types: System.Array$1<System.Type>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>) : System.Reflection.PropertyInfo
            public GetProperties () : System.Array$1<System.Reflection.PropertyInfo>
            public GetProperties ($bindingAttr: System.Reflection.BindingFlags) : System.Array$1<System.Reflection.PropertyInfo>
            public GetDefaultMembers () : System.Array$1<System.Reflection.MemberInfo>
            public static GetTypeHandle ($o: any) : System.RuntimeTypeHandle
            public static GetTypeArray ($args: System.Array$1<any>) : System.Array$1<System.Type>
            public static GetTypeCode ($type: System.Type) : System.TypeCode
            public static GetTypeFromCLSID ($clsid: System.Guid) : System.Type
            public static GetTypeFromCLSID ($clsid: System.Guid, $throwOnError: boolean) : System.Type
            public static GetTypeFromCLSID ($clsid: System.Guid, $server: string) : System.Type
            public static GetTypeFromCLSID ($clsid: System.Guid, $server: string, $throwOnError: boolean) : System.Type
            public static GetTypeFromProgID ($progID: string) : System.Type
            public static GetTypeFromProgID ($progID: string, $throwOnError: boolean) : System.Type
            public static GetTypeFromProgID ($progID: string, $server: string) : System.Type
            public static GetTypeFromProgID ($progID: string, $server: string, $throwOnError: boolean) : System.Type
            public InvokeMember ($name: string, $invokeAttr: System.Reflection.BindingFlags, $binder: System.Reflection.Binder, $target: any, $args: System.Array$1<any>) : any
            public InvokeMember ($name: string, $invokeAttr: System.Reflection.BindingFlags, $binder: System.Reflection.Binder, $target: any, $args: System.Array$1<any>, $culture: System.Globalization.CultureInfo) : any
            public InvokeMember ($name: string, $invokeAttr: System.Reflection.BindingFlags, $binder: System.Reflection.Binder, $target: any, $args: System.Array$1<any>, $modifiers: System.Array$1<System.Reflection.ParameterModifier>, $culture: System.Globalization.CultureInfo, $namedParameters: System.Array$1<string>) : any
            public GetInterface ($name: string) : System.Type
            public GetInterface ($name: string, $ignoreCase: boolean) : System.Type
            public GetInterfaces () : System.Array$1<System.Type>
            public GetInterfaceMap ($interfaceType: System.Type) : System.Reflection.InterfaceMapping
            public IsInstanceOfType ($o: any) : boolean
            public IsEquivalentTo ($other: System.Type) : boolean
            public GetEnumUnderlyingType () : System.Type
            public GetEnumValues () : System.Array
            public GetEnumValuesAsUnderlyingType () : System.Array
            public MakeArrayType () : System.Type
            public MakeArrayType ($rank: number) : System.Type
            public MakeByRefType () : System.Type
            public MakeGenericType (...typeArguments: System.Type[]) : System.Type
            public MakePointerType () : System.Type
            public static MakeGenericSignatureType ($genericTypeDefinition: System.Type, ...typeArguments: System.Type[]) : System.Type
            public static MakeGenericMethodParameter ($position: number) : System.Type
            public Equals ($o: any) : boolean
            public Equals ($o: System.Type) : boolean
            public static op_Equality ($left: System.Type, $right: System.Type) : boolean
            public static op_Inequality ($left: System.Type, $right: System.Type) : boolean
            public IsEnumDefined ($value: any) : boolean
            public GetEnumName ($value: any) : string
            public GetEnumNames () : System.Array$1<string>
            public FindInterfaces ($filter: System.Reflection.TypeFilter, $filterCriteria: any) : System.Array$1<System.Type>
            public FindMembers ($memberType: System.Reflection.MemberTypes, $bindingAttr: System.Reflection.BindingFlags, $filter: System.Reflection.MemberFilter, $filterCriteria: any) : System.Array$1<System.Reflection.MemberInfo>
            public IsSubclassOf ($c: System.Type) : boolean
            public IsAssignableFrom ($c: System.Type) : boolean
        }
        class Int64 extends System.ValueType implements System.IComparable, System.IConvertible, System.ISpanFormattable, System.IFormattable, System.IComparable$1<bigint>, System.IEquatable$1<bigint>, System.Numerics.IBinaryInteger$1<bigint>, System.Numerics.IBinaryNumber$1<bigint>, System.Numerics.IBitwiseOperators$3<bigint, bigint, bigint>, System.Numerics.INumber$1<bigint>, System.Numerics.IComparisonOperators$3<bigint, bigint, boolean>, System.Numerics.IEqualityOperators$3<bigint, bigint, boolean>, System.Numerics.IModulusOperators$3<bigint, bigint, bigint>, System.Numerics.INumberBase$1<bigint>, System.Numerics.IAdditionOperators$3<bigint, bigint, bigint>, System.Numerics.IAdditiveIdentity$2<bigint, bigint>, System.Numerics.IDecrementOperators$1<bigint>, System.Numerics.IDivisionOperators$3<bigint, bigint, bigint>, System.Numerics.IIncrementOperators$1<bigint>, System.Numerics.IMultiplicativeIdentity$2<bigint, bigint>, System.Numerics.IMultiplyOperators$3<bigint, bigint, bigint>, System.ISpanParsable$1<bigint>, System.IParsable$1<bigint>, System.Numerics.ISubtractionOperators$3<bigint, bigint, bigint>, System.Numerics.IUnaryPlusOperators$2<bigint, bigint>, System.Numerics.IUnaryNegationOperators$2<bigint, bigint>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<bigint>, System.Numerics.IShiftOperators$3<bigint, number, bigint>, System.Numerics.IMinMaxValue$1<bigint>, System.Numerics.ISignedNumber$1<bigint>, System.IBinaryIntegerParseAndFormatInfo$1<bigint>
        {
            protected [__keep_incompatibility]: never;
        }
        class Delegate extends System.Object implements System.ICloneable, System.Runtime.Serialization.ISerializable
        {
            protected [__keep_incompatibility]: never;
        }
        interface MulticastDelegate
        { 
        (...args:any[]) : any; 
        Invoke?: (...args:any[]) => any;
        }
        var MulticastDelegate: { new (func: (...args:any[]) => any): MulticastDelegate; }
        interface Action
        { 
        () : void; 
        Invoke?: () => void;
        }
        var Action: { new (func: () => void): Action; }
        class Nullable$1<T> extends System.ValueType
        {
            protected [__keep_incompatibility]: never;
        }
        class ReadOnlySpan$1<T> extends System.ValueType
        {
            protected [__keep_incompatibility]: never;
        }
        interface Action$1<T>
        { 
        (obj: T) : void; 
        Invoke?: (obj: T) => void;
        }
        interface Func$2<T, TResult>
        { 
        (arg: T) : TResult; 
        Invoke?: (arg: T) => TResult;
        }
        interface Func$4<T1, T2, T3, TResult>
        { 
        (arg1: T1, arg2: T2, arg3: T3) : TResult; 
        Invoke?: (arg1: T1, arg2: T2, arg3: T3) => TResult;
        }
        class RuntimeTypeHandle extends System.ValueType implements System.IEquatable$1<System.RuntimeTypeHandle>, System.Runtime.Serialization.ISerializable
        {
            protected [__keep_incompatibility]: never;
        }
        class Attribute extends System.Object
        {
            protected [__keep_incompatibility]: never;
        }
        enum TypeCode
        { Empty = 0, Object = 1, DBNull = 2, Boolean = 3, Char = 4, SByte = 5, Byte = 6, Int16 = 7, UInt16 = 8, Int32 = 9, UInt32 = 10, Int64 = 11, UInt64 = 12, Single = 13, Double = 14, Decimal = 15, DateTime = 16, String = 18 }
        class Guid extends System.ValueType implements System.ISpanFormattable, System.IFormattable, System.IComparable, System.IComparable$1<System.Guid>, System.IEquatable$1<System.Guid>, System.ISpanParsable$1<System.Guid>, System.IParsable$1<System.Guid>, System.IUtf8SpanFormattable
        {
            protected [__keep_incompatibility]: never;
        }
        interface IFormatProvider
        {
        }
    }
    namespace Godot {
        /** Godot's global functions.
        */
        class GD extends System.Object
        {
            protected [__keep_incompatibility]: never;
            public static Convert ($what: Godot.Variant, $type: Godot.Variant.Type) : Godot.Variant
            /**
            * Returns the integer hash of the passed
            * .
            * @param $var Variable that will be hashed.
            * @returns Hash of the variable passed.
            */
            public static Hash ($var: Godot.Variant) : number
            /**
            * Loads a resource from the filesystem located at
            * .
            * The resource is loaded on the method call (unless it's referenced already
            * elsewhere, e.g. in another script or in the scene), which might cause slight delay,
            * especially when loading scenes. To avoid unnecessary delays when loading something
            * multiple times, either store the resource in a variable.
            * Note: Resource paths can be obtained by right-clicking on a resource in the FileSystem
            * dock and choosing "Copy Path" or by dragging the file from the FileSystem dock into the script.
            * Important: The path must be absolute, a local path will just return
            * .
            * This method is a simplified version of
            * , which can be used
            * for more advanced scenarios.
            * @param $path Path of the  to load.
            * @returns The loaded .
            */
            public static Load ($path: string) : Godot.Resource
            /**
            * Prints a message to the console.
            * Note: Consider using
            * and
            * to print error and warning messages instead of
            * .
            * This distinguishes them from print messages used for debugging purposes,
            * while also displaying a stack trace when an error or warning is printed.
            * @param $what Message that will be printed.
            */
            public static Print ($what: string) : void
            /**
            * Converts one or more arguments of any type to string in the best way possible
            * and prints them to the console.
            * Note: Consider using
            * and
            * to print error and warning messages instead of
            * .
            * This distinguishes them from print messages used for debugging purposes,
            * while also displaying a stack trace when an error or warning is printed.
            * @param $what Arguments that will be printed.
            */
            public static Print (...what: any[]) : void
            /**
            * Prints a message to the console.
            * The following BBCode tags are supported: b, i, u, s, indent, code, url, center,
            * right, color, bgcolor, fgcolor.
            * Color tags only support named colors such as
            * red
            * , not hexadecimal color codes.
            * Unsupported tags will be left as-is in standard output.
            * When printing to standard output, the supported subset of BBCode is converted to
            * ANSI escape codes for the terminal emulator to display. Displaying ANSI escape codes
            * is currently only supported on Linux and macOS. Support for ANSI escape codes may vary
            * across terminal emulators, especially for italic and strikethrough.
            * Note: Consider using
            * and
            * to print error and warning messages instead of
            * or
            * .
            * This distinguishes them from print messages used for debugging purposes,
            * while also displaying a stack trace when an error or warning is printed.
            * @param $what Message that will be printed.
            */
            public static PrintRich ($what: string) : void
            /**
            * Converts one or more arguments of any type to string in the best way possible
            * and prints them to the console.
            * The following BBCode tags are supported: b, i, u, s, indent, code, url, center,
            * right, color, bgcolor, fgcolor.
            * Color tags only support named colors such as
            * red
            * , not hexadecimal color codes.
            * Unsupported tags will be left as-is in standard output.
            * When printing to standard output, the supported subset of BBCode is converted to
            * ANSI escape codes for the terminal emulator to display. Displaying ANSI escape codes
            * is currently only supported on Linux and macOS. Support for ANSI escape codes may vary
            * across terminal emulators, especially for italic and strikethrough.
            * Note: Consider using
            * and
            * to print error and warning messages instead of
            * or
            * .
            * This distinguishes them from print messages used for debugging purposes,
            * while also displaying a stack trace when an error or warning is printed.
            * @param $what Arguments that will be printed.
            */
            public static PrintRich (...what: any[]) : void
            /** Prints a message to standard error line.
            * @param $what Message that will be printed.
            */
            public static PrintErr ($what: string) : void
            /** Prints one or more arguments to strings in the best way possible to standard error line.
            * @param $what Arguments that will be printed.
            */
            public static PrintErr (...what: any[]) : void
            /**
            * Prints a message to the OS terminal.
            * Unlike
            * , no newline is added at the end.
            * @param $what Message that will be printed.
            */
            public static PrintRaw ($what: string) : void
            /**
            * Prints one or more arguments to strings in the best way possible to the OS terminal.
            * Unlike
            * , no newline is added at the end.
            * @param $what Arguments that will be printed.
            */
            public static PrintRaw (...what: any[]) : void
            /** Prints one or more arguments to the console with a space between each argument.
            * @param $what Arguments that will be printed.
            */
            public static PrintS (...what: any[]) : void
            /** Prints one or more arguments to the console with a tab between each argument.
            * @param $what Arguments that will be printed.
            */
            public static PrintT (...what: any[]) : void
            /**
            * Pushes an error message to Godot's built-in debugger and to the OS terminal.
            * Note: Errors printed this way will not pause project execution.
            * @param $message Error message.
            */
            public static PushError ($message: string) : void
            /**
            * Pushes an error message to Godot's built-in debugger and to the OS terminal.
            * Note: Errors printed this way will not pause project execution.
            * @param $what Arguments that form the error message.
            */
            public static PushError (...what: any[]) : void
            /** Pushes a warning message to Godot's built-in debugger and to the OS terminal.
            * @param $message Warning message.
            */
            public static PushWarning ($message: string) : void
            /** Pushes a warning message to Godot's built-in debugger and to the OS terminal.
            * @param $what Arguments that form the warning message.
            */
            public static PushWarning (...what: any[]) : void
            /**
            * Returns a random floating point value between
            * 0.0
            * and
            * 1.0
            * (inclusive).
            * @returns A random  number.
            */
            public static Randf () : number
            /**
            * Returns a normally-distributed pseudo-random floating point value
            * using Box-Muller transform with the specified
            * and a standard
            * .
            * This is also called Gaussian distribution.
            * @returns A random normally-distributed  number.
            */
            public static Randfn ($mean: number, $deviation: number) : number
            /**
            * Returns a random unsigned 32-bit integer.
            * Use remainder to obtain a random value in the interval
            * [0, N - 1]
            * (where N is smaller than 2^32).
            * @returns A random  number.
            */
            public static Randi () : number
            /**
            * Randomizes the seed (or the internal state) of the random number generator.
            * The current implementation uses a number based on the device's time.
            * Note: This method is called automatically when the project is run.
            * If you need to fix the seed to have consistent, reproducible results,
            * use
            * to initialize the random number generator.
            */
            public static Randomize () : void
            /**
            * Returns a random floating point value between
            * and
            * (inclusive).
            * @returns A random  number inside the given range.
            */
            public static RandRange ($from: number, $to: number) : number
            public static RandFromSeed ($seed: $Ref<bigint>) : number
            /**
            * Returns a
            * that iterates from
            * 0
            * (inclusive) to
            * (exclusive)
            * in steps of
            * 1
            * .
            * @param $end The last index.
            */
            public static Range ($end: number) : System.Collections.Generic.IEnumerable$1<number>
            /**
            * Returns a
            * that iterates from
            * (inclusive) to
            * (exclusive)
            * in steps of
            * 1
            * .
            * @param $start The first index.
            * @param $end The last index.
            */
            public static Range ($start: number, $end: number) : System.Collections.Generic.IEnumerable$1<number>
            /**
            * Returns a
            * that iterates from
            * (inclusive) to
            * (exclusive)
            * in steps of
            * .
            * The argument
            * can be negative, but not
            * 0
            * .
            * @param $start The first index.
            * @param $end The last index.
            * @param $step The amount by which to increment the index on each iteration.
            */
            public static Range ($start: number, $end: number, $step: number) : System.Collections.Generic.IEnumerable$1<number>
            /**
            * Sets seed for the random number generator to
            * .
            * Setting the seed manually can ensure consistent, repeatable results for
            * most random functions.
            * @param $seed Seed that will be used.
            */
            public static Seed ($seed: bigint) : void
            /**
            * Converts a formatted string that was returned by
            * to the original value.
            * @param $str String that will be converted to Variant.
            * @returns The decoded Variant.
            */
            public static StrToVar ($str: string) : Godot.Variant
            /**
            * Encodes a
            * value to a byte array, without encoding objects.
            * Deserialization can be done with
            * .
            * Note: If you need object serialization, see
            * .
            * @param $var  that will be encoded.
            * @returns The  encoded as an array of bytes.
            */
            public static VarToBytes ($var: Godot.Variant) : System.Array$1<number>
            /**
            * Encodes a
            * . Encoding objects is allowed (and can potentially
            * include executable code). Deserialization can be done with
            * .
            * @param $var  that will be encoded.
            * @returns The  encoded as an array of bytes.
            */
            public static VarToBytesWithObjects ($var: Godot.Variant) : System.Array$1<number>
            /**
            * Converts a
            * to a formatted string that
            * can later be parsed using
            * .
            * @param $var Variant that will be converted to string.
            * @returns The  encoded as a string.
            */
            public static VarToStr ($var: Godot.Variant) : string
            /**
            * Get the
            * that corresponds for the given
            * .
            * @returns The  for the given .
            */
            public static TypeToVariantType ($type: System.Type) : Godot.Variant.Type
            public static Compress ($instance: System.Array$1<number>, $compressionMode?: Godot.FileAccess.CompressionMode) : System.Array$1<number>
            public static Decompress ($instance: System.Array$1<number>, $bufferSize: bigint, $compressionMode?: Godot.FileAccess.CompressionMode) : System.Array$1<number>
            public static DecompressDynamic ($instance: System.Array$1<number>, $maxOutputSize: bigint, $compressionMode?: Godot.FileAccess.CompressionMode) : System.Array$1<number>
            /** Returns true if this byte array is empty or doesn't exist.
            * @param $instance The byte array check.
            * @returns Whether or not the array is empty.
            */
            public static IsEmpty ($instance: System.Array$1<number>) : boolean
            /** Converts this byte array to a string delimited by the given string.
            * @param $instance The byte array to convert.
            * @param $delimiter The delimiter to use between items.
            * @returns A single string with all items.
            */
            public static Join ($instance: System.Array$1<number>, $delimiter?: string) : string
            /** Converts this byte array to a string with brackets.
            * @param $instance The byte array to convert.
            * @returns A single string with all items.
            */
            public static Stringify ($instance: System.Array$1<number>) : string
            /** Returns true if this long array is empty or doesn't exist.
            * @param $instance The long array check.
            * @returns Whether or not the array is empty.
            */
            public static IsEmpty ($instance: System.Array$1<bigint>) : boolean
            /** Converts this long array to a string delimited by the given string.
            * @param $instance The long array to convert.
            * @param $delimiter The delimiter to use between items.
            * @returns A single string with all items.
            */
            public static Join ($instance: System.Array$1<bigint>, $delimiter?: string) : string
            /** Converts this long array to a string with brackets.
            * @param $instance The long array to convert.
            * @returns A single string with all items.
            */
            public static Stringify ($instance: System.Array$1<bigint>) : string
            /** Returns true if this string array is empty or doesn't exist.
            * @param $instance The string array check.
            * @returns Whether or not the array is empty.
            */
            public static IsEmpty ($instance: System.Array$1<string>) : boolean
            /** Converts this string array to a string delimited by the given string.
            * @param $instance The string array to convert.
            * @param $delimiter The delimiter to use between items.
            * @returns A single string with all items.
            */
            public static Join ($instance: System.Array$1<string>, $delimiter?: string) : string
            /** Converts this string array to a string with brackets.
            * @param $instance The string array to convert.
            * @returns A single string with all items.
            */
            public static Stringify ($instance: System.Array$1<string>) : string
            /** Returns true if this Color array is empty or doesn't exist.
            * @param $instance The Color array check.
            * @returns Whether or not the array is empty.
            */
            public static IsEmpty ($instance: System.Array$1<Godot.Color>) : boolean
            /** Converts this Color array to a string delimited by the given string.
            * @param $instance The Color array to convert.
            * @param $delimiter The delimiter to use between items.
            * @returns A single string with all items.
            */
            public static Join ($instance: System.Array$1<Godot.Color>, $delimiter?: string) : string
            /** Converts this Color array to a string with brackets.
            * @param $instance The Color array to convert.
            * @returns A single string with all items.
            */
            public static Stringify ($instance: System.Array$1<Godot.Color>) : string
            /** Returns true if this Vector2 array is empty or doesn't exist.
            * @param $instance The Vector2 array check.
            * @returns Whether or not the array is empty.
            */
            public static IsEmpty ($instance: System.Array$1<Godot.Vector2>) : boolean
            /** Converts this Vector2 array to a string delimited by the given string.
            * @param $instance The Vector2 array to convert.
            * @param $delimiter The delimiter to use between items.
            * @returns A single string with all items.
            */
            public static Join ($instance: System.Array$1<Godot.Vector2>, $delimiter?: string) : string
            /** Converts this Vector2 array to a string with brackets.
            * @param $instance The Vector2 array to convert.
            * @returns A single string with all items.
            */
            public static Stringify ($instance: System.Array$1<Godot.Vector2>) : string
            /** Returns true if this Vector2I array is empty or doesn't exist.
            * @param $instance The Vector2I array check.
            * @returns Whether or not the array is empty.
            */
            public static IsEmpty ($instance: System.Array$1<Godot.Vector2I>) : boolean
            /** Converts this Vector2I array to a string delimited by the given string.
            * @param $instance The Vector2I array to convert.
            * @param $delimiter The delimiter to use between items.
            * @returns A single string with all items.
            */
            public static Join ($instance: System.Array$1<Godot.Vector2I>, $delimiter?: string) : string
            /** Converts this Vector2I array to a string with brackets.
            * @param $instance The Vector2I array to convert.
            * @returns A single string with all items.
            */
            public static Stringify ($instance: System.Array$1<Godot.Vector2I>) : string
            /** Returns true if this Vector3 array is empty or doesn't exist.
            * @param $instance The Vector3 array check.
            * @returns Whether or not the array is empty.
            */
            public static IsEmpty ($instance: System.Array$1<Godot.Vector3>) : boolean
            /** Converts this Vector3 array to a string delimited by the given string.
            * @param $instance The Vector3 array to convert.
            * @param $delimiter The delimiter to use between items.
            * @returns A single string with all items.
            */
            public static Join ($instance: System.Array$1<Godot.Vector3>, $delimiter?: string) : string
            /** Converts this Vector3 array to a string with brackets.
            * @param $instance The Vector3 array to convert.
            * @returns A single string with all items.
            */
            public static Stringify ($instance: System.Array$1<Godot.Vector3>) : string
            /** Returns true if this Vector3I array is empty or doesn't exist.
            * @param $instance The Vector3I array check.
            * @returns Whether or not the array is empty.
            */
            public static IsEmpty ($instance: System.Array$1<Godot.Vector3I>) : boolean
            /** Converts this Vector3I array to a string delimited by the given string.
            * @param $instance The Vector3I array to convert.
            * @param $delimiter The delimiter to use between items.
            * @returns A single string with all items.
            */
            public static Join ($instance: System.Array$1<Godot.Vector3I>, $delimiter?: string) : string
            /** Converts this Vector3I array to a string with brackets.
            * @param $instance The Vector3I array to convert.
            * @returns A single string with all items.
            */
            public static Stringify ($instance: System.Array$1<Godot.Vector3I>) : string
            /** Returns true if this Vector4 array is empty or doesn't exist.
            * @param $instance The Vector4 array check.
            * @returns Whether or not the array is empty.
            */
            public static IsEmpty ($instance: System.Array$1<Godot.Vector4>) : boolean
            /** Converts this Vector4 array to a string delimited by the given string.
            * @param $instance The Vector4 array to convert.
            * @param $delimiter The delimiter to use between items.
            * @returns A single string with all items.
            */
            public static Join ($instance: System.Array$1<Godot.Vector4>, $delimiter?: string) : string
            /** Converts this Vector4 array to a string with brackets.
            * @param $instance The Vector4 array to convert.
            * @returns A single string with all items.
            */
            public static Stringify ($instance: System.Array$1<Godot.Vector4>) : string
            /** Returns true if this Vector4I array is empty or doesn't exist.
            * @param $instance The Vector4I array check.
            * @returns Whether or not the array is empty.
            */
            public static IsEmpty ($instance: System.Array$1<Godot.Vector4I>) : boolean
            /** Converts this Vector4I array to a string delimited by the given string.
            * @param $instance The Vector4I array to convert.
            * @param $delimiter The delimiter to use between items.
            * @returns A single string with all items.
            */
            public static Join ($instance: System.Array$1<Godot.Vector4I>, $delimiter?: string) : string
            /** Converts this Vector4I array to a string with brackets.
            * @param $instance The Vector4I array to convert.
            * @returns A single string with all items.
            */
            public static Stringify ($instance: System.Array$1<Godot.Vector4I>) : string
        }
        class Variant extends System.ValueType implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * .
        *  in C#.
        *  deletes its children when freed.
        *  is instantiated, it effectively acts as an extension to the base class, allowing it to define and inherit new properties, methods and signals.
        *  may be overridden to customize properties in several ways. This allows them to be available to the editor, display as lists of options, sub-divide into groups, save on disk, etc. Scripting languages offer easier ways to customize properties, such as with the [annotation @GDScript.@export] annotation.
        *  slower than direct references.
        *  operator:
        * 
        var node = Node.new()
        print("name" in node)         # Prints true
        print("get_parent" in node)   # Prints true
        print("tree_entered" in node) # Prints true
        print("unknown" in node)      # Prints false
        * .
        *  can be useful to store information that the object itself does not depend on. To keep your code clean, making excessive use of metadata is discouraged.
        * .
        * , respectively.
        * .
        */
        class GodotObject extends System.Object implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        *  and many other helper objects inherit this class.
        * .
        * .
        * -derived types is all you need to do. The methods provided in this class are only for advanced users, and can cause issues if misused.
        *  In C#, reference-counted objects will not be freed instantly after they are no longer in use. Instead, garbage collection will run periodically and will free reference-counted objects that are no longer in use. This means that unused ones will remain in memory for a while before being removed.
        */
        class RefCounted extends Godot.GodotObject implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * s it contains as many times as desired.
        * .
        * ). A resource will be cached when loaded for the first time and removed from cache once all references are released. When a resource is cached, subsequent loads using its path will return the cached reference.
        *  In C#, resources will not be freed instantly after they are no longer in use. Instead, garbage collection will run periodically and will free resources that are no longer in use. This means that unused resources will remain in memory for a while before being removed.
        */
        class Resource extends Godot.RefCounted implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * A color represented by red, green, blue, and alpha (RGBA) components.
        * The alpha component is often used for transparency.
        * Values are in floating-point and usually range from 0 to 1.
        * Some properties (such as
        * ) may accept values
        * greater than 1 (overbright or HDR colors).
        * If you want to supply values in a range of 0 to 255, you should use
        * and the
        * r8
        * /
        * g8
        * /
        * b8
        * /
        * a8
        * properties.
        */
        class Color extends System.ValueType implements System.IEquatable$1<Godot.Color>
        {
            protected [__keep_incompatibility]: never;
            /** The color's red component, typically on the range of 0 to 1.
            */
            public R : number
            /** The color's green component, typically on the range of 0 to 1.
            */
            public G : number
            /** The color's blue component, typically on the range of 0 to 1.
            */
            public B : number
            /**
            * The color's alpha component, typically on the range of 0 to 1.
            * A value of 0 means that the color is fully transparent.
            * A value of 1 means that the color is fully opaque.
            */
            public A : number
            /**
            * Wrapper for
            * that uses the range 0 to 255 instead of 0 to 1.
            */
            public get R8(): number;
            public set R8(value: number);
            /**
            * Wrapper for
            * that uses the range 0 to 255 instead of 0 to 1.
            */
            public get G8(): number;
            public set G8(value: number);
            /**
            * Wrapper for
            * that uses the range 0 to 255 instead of 0 to 1.
            */
            public get B8(): number;
            public set B8(value: number);
            /**
            * Wrapper for
            * that uses the range 0 to 255 instead of 0 to 1.
            */
            public get A8(): number;
            public set A8(value: number);
            /** The HSV hue of this color, on the range 0 to 1.
            */
            public get H(): number;
            public set H(value: number);
            /** The HSV saturation of this color, on the range 0 to 1.
            */
            public get S(): number;
            public set S(value: number);
            /** The HSV value (brightness) of this color, on the range 0 to 1.
            */
            public get V(): number;
            public set V(value: number);
            /** The OKHSL hue of this color, on the range 0 to 1.
            */
            public get OkHslH(): number;
            public set OkHslH(value: number);
            /** The OKHSL saturation of this color, on the range 0 to 1.
            */
            public get OkHslS(): number;
            public set OkHslS(value: number);
            /** The OKHSL lightness of this color, on the range 0 to 1.
            */
            public get OkHslL(): number;
            public set OkHslL(value: number);
            /**
            * Returns the light intensity of the color, as a value between 0.0 and 1.0 (inclusive).
            * This is useful when determining light or dark color. Colors with a luminance smaller
            * than 0.5 can be generally considered dark.
            * Note:
            * relies on the color being in the linear color space to
            * return an accurate relative luminance value. If the color is in the sRGB color space
            * use
            * to convert it to the linear color space first.
            */
            public get Luminance(): number;
            public get_Item ($index: number) : number
            public set_Item ($index: number, $value: number) : void
            /**
            * Returns a new color resulting from blending this color over another.
            * If the color is opaque, the result is also opaque.
            * The second color may have a range of alpha values.
            * @param $over The color to blend over.
            * @returns This color blended over .
            */
            public Blend ($over: Godot.Color) : Godot.Color
            public Clamp ($min?: Godot.Color | null, $max?: Godot.Color | null) : Godot.Color
            /**
            * Returns a new color resulting from making this color darker
            * by the specified ratio (on the range of 0 to 1).
            * @param $amount The ratio to darken by.
            * @returns The darkened color.
            */
            public Darkened ($amount: number) : Godot.Color
            /**
            * Returns the inverted color:
            * (1 - r, 1 - g, 1 - b, a)
            * .
            * @returns The inverted color.
            */
            public Inverted () : Godot.Color
            /**
            * Returns a new color resulting from making this color lighter
            * by the specified ratio (on the range of 0 to 1).
            * @param $amount The ratio to lighten by.
            * @returns The lightened color.
            */
            public Lightened ($amount: number) : Godot.Color
            /**
            * Returns the result of the linear interpolation between
            * this color and
            * by amount
            * .
            * @param $to The destination color for interpolation.
            * @param $weight A value on the range of 0.0 to 1.0, representing the amount of interpolation.
            * @returns The resulting color of the interpolation.
            */
            public Lerp ($to: Godot.Color, $weight: number) : Godot.Color
            /**
            * Returns the color converted to the sRGB color space.
            * This method assumes the original color is in the linear color space.
            * See also
            * which performs the opposite operation.
            * @returns The sRGB color.
            */
            public LinearToSrgb () : Godot.Color
            /**
            * Returns the color converted to linear color space.
            * This method assumes the original color already is in sRGB color space.
            * See also
            * which performs the opposite operation.
            * @returns The color in linear color space.
            */
            public SrgbToLinear () : Godot.Color
            /**
            * Returns the color converted to an unsigned 32-bit integer in ABGR
            * format (each byte represents a color channel).
            * ABGR is the reversed version of the default format.
            * @returns A  representing this color in ABGR32 format.
            */
            public ToAbgr32 () : number
            /**
            * Returns the color converted to an unsigned 64-bit integer in ABGR
            * format (each word represents a color channel).
            * ABGR is the reversed version of the default format.
            * @returns A  representing this color in ABGR64 format.
            */
            public ToAbgr64 () : bigint
            /**
            * Returns the color converted to an unsigned 32-bit integer in ARGB
            * format (each byte represents a color channel).
            * ARGB is more compatible with DirectX, but not used much in Godot.
            * @returns A  representing this color in ARGB32 format.
            */
            public ToArgb32 () : number
            /**
            * Returns the color converted to an unsigned 64-bit integer in ARGB
            * format (each word represents a color channel).
            * ARGB is more compatible with DirectX, but not used much in Godot.
            * @returns A  representing this color in ARGB64 format.
            */
            public ToArgb64 () : bigint
            /**
            * Returns the color converted to an unsigned 32-bit integer in RGBA
            * format (each byte represents a color channel).
            * RGBA is Godot's default and recommended format.
            * @returns A  representing this color in RGBA32 format.
            */
            public ToRgba32 () : number
            /**
            * Returns the color converted to an unsigned 64-bit integer in RGBA
            * format (each word represents a color channel).
            * RGBA is Godot's default and recommended format.
            * @returns A  representing this color in RGBA64 format.
            */
            public ToRgba64 () : bigint
            /** Returns the color's HTML hexadecimal color string in RGBA format.
            * @param $includeAlpha 
            Whether or not to include alpha. If , the color is RGB instead of RGBA.
            * @returns A string for the HTML hexadecimal representation of this color.
            */
            public ToHtml ($includeAlpha?: boolean) : string
            /**
            * Returns a color constructed from integer red, green, blue, and alpha channels.
            * Each channel should have 8 bits of information ranging from 0 to 255.
            * @param $r8 The red component represented on the range of 0 to 255.
            * @param $g8 The green component represented on the range of 0 to 255.
            * @param $b8 The blue component represented on the range of 0 to 255.
            * @param $a8 The alpha (transparency) component represented on the range of 0 to 255.
            * @returns The constructed color.
            */
            public static Color8 ($r8: number, $g8: number, $b8: number, $a8?: number) : Godot.Color
            /**
            * Constructs a color from an HSV profile. The
            * ,
            * , and
            * are typically
            * between 0.0 and 1.0.
            * @param $hue The HSV hue, typically on the range of 0 to 1.
            * @param $saturation The HSV saturation, typically on the range of 0 to 1.
            * @param $value The HSV value (brightness), typically on the range of 0 to 1.
            * @param $alpha The alpha (transparency) value, typically on the range of 0 to 1.
            * @returns The constructed color.
            */
            public static FromHsv ($hue: number, $saturation: number, $value: number, $alpha?: number) : Godot.Color
            public ToHsv ($hue: $Ref<number>, $saturation: $Ref<number>, $value: $Ref<number>) : void
            /**
            * Constructs a color from an OK HSL profile. The
            * ,
            * , and
            * are typically
            * between 0.0 and 1.0.
            * @param $hue The OK HSL hue, typically on the range of 0 to 1.
            * @param $saturation The OK HSL saturation, typically on the range of 0 to 1.
            * @param $lightness The OK HSL lightness, typically on the range of 0 to 1.
            * @param $alpha The alpha (transparency) value, typically on the range of 0 to 1.
            * @returns The constructed color.
            */
            public static FromOkHsl ($hue: number, $saturation: number, $lightness: number, $alpha?: number) : Godot.Color
            /**
            * Encodes a
            * from a RGBE9995 format integer.
            * See
            * .
            * @param $rgbe The RGBE9995 encoded color.
            * @returns The constructed color.
            */
            public static FromRgbe9995 ($rgbe: number) : Godot.Color
            /**
            * Constructs a color from the given string, which can be either an HTML color
            * code or a named color. Returns
            * if the color cannot
            * be inferred from the string. Supported color names are the same as the
            * constants.
            * @param $str The HTML color code or color name.
            * @param $default The fallback color to return if the color cannot be inferred.
            * @returns The constructed color.
            */
            public static FromString ($str: string, $default: Godot.Color) : Godot.Color
            /**
            * Adds each component of the
            * with the components of the given
            * .
            * @param $left The left color.
            * @param $right The right color.
            * @returns The added color.
            */
            public static op_Addition ($left: Godot.Color, $right: Godot.Color) : Godot.Color
            /**
            * Subtracts each component of the
            * by the components of the given
            * .
            * @param $left The left color.
            * @param $right The right color.
            * @returns The subtracted color.
            */
            public static op_Subtraction ($left: Godot.Color, $right: Godot.Color) : Godot.Color
            /**
            * Inverts the given color. This is equivalent to
            * Colors.White - c
            * or
            * new Color(1 - c.R, 1 - c.G, 1 - c.B, 1 - c.A)
            * .
            * @param $color The color to invert.
            * @returns The inverted color.
            */
            public static op_UnaryNegation ($color: Godot.Color) : Godot.Color
            /**
            * Multiplies each component of the
            * by the given
            * .
            * @param $color The color to multiply.
            * @param $scale The value to multiply by.
            * @returns The multiplied color.
            */
            public static op_Multiply ($color: Godot.Color, $scale: number) : Godot.Color
            /**
            * Multiplies each component of the
            * by the given
            * .
            * @param $scale The value to multiply by.
            * @param $color The color to multiply.
            * @returns The multiplied color.
            */
            public static op_Multiply ($scale: number, $color: Godot.Color) : Godot.Color
            /**
            * Multiplies each component of the
            * by the components of the given
            * .
            * @param $left The left color.
            * @param $right The right color.
            * @returns The multiplied color.
            */
            public static op_Multiply ($left: Godot.Color, $right: Godot.Color) : Godot.Color
            /**
            * Divides each component of the
            * by the given
            * .
            * @param $color The dividend vector.
            * @param $scale The divisor value.
            * @returns The divided color.
            */
            public static op_Division ($color: Godot.Color, $scale: number) : Godot.Color
            /**
            * Divides each component of the
            * by the components of the given
            * .
            * @param $left The dividend color.
            * @param $right The divisor color.
            * @returns The divided color.
            */
            public static op_Division ($left: Godot.Color, $right: Godot.Color) : Godot.Color
            /**
            * Returns
            * if the colors are exactly equal.
            * Note: Due to floating-point precision errors, consider using
            * instead, which is more reliable.
            * @param $left The left color.
            * @param $right The right color.
            * @returns Whether or not the colors are equal.
            */
            public static op_Equality ($left: Godot.Color, $right: Godot.Color) : boolean
            /**
            * Returns
            * if the colors are not equal.
            * Note: Due to floating-point precision errors, consider using
            * instead, which is more reliable.
            * @param $left The left color.
            * @param $right The right color.
            * @returns Whether or not the colors are equal.
            */
            public static op_Inequality ($left: Godot.Color, $right: Godot.Color) : boolean
            /**
            * Compares two
            * s by first checking if
            * the red value of the
            * color is less than
            * the red value of the
            * color.
            * If the red values are exactly equal, then it repeats this check
            * with the green values of the two colors, then with the blue values,
            * and then with the alpha value.
            * This operator is useful for sorting colors.
            * @param $left The left color.
            * @param $right The right color.
            * @returns Whether or not the left is less than the right.
            */
            public static op_LessThan ($left: Godot.Color, $right: Godot.Color) : boolean
            /**
            * Compares two
            * s by first checking if
            * the red value of the
            * color is greater than
            * the red value of the
            * color.
            * If the red values are exactly equal, then it repeats this check
            * with the green values of the two colors, then with the blue values,
            * and then with the alpha value.
            * This operator is useful for sorting colors.
            * @param $left The left color.
            * @param $right The right color.
            * @returns Whether or not the left is greater than the right.
            */
            public static op_GreaterThan ($left: Godot.Color, $right: Godot.Color) : boolean
            /**
            * Compares two
            * s by first checking if
            * the red value of the
            * color is less than
            * or equal to the red value of the
            * color.
            * If the red values are exactly equal, then it repeats this check
            * with the green values of the two colors, then with the blue values,
            * and then with the alpha value.
            * This operator is useful for sorting colors.
            * @param $left The left color.
            * @param $right The right color.
            * @returns Whether or not the left is less than or equal to the right.
            */
            public static op_LessThanOrEqual ($left: Godot.Color, $right: Godot.Color) : boolean
            /**
            * Compares two
            * s by first checking if
            * the red value of the
            * color is greater than
            * or equal to the red value of the
            * color.
            * If the red values are exactly equal, then it repeats this check
            * with the green values of the two colors, then with the blue values,
            * and then with the alpha value.
            * This operator is useful for sorting colors.
            * @param $left The left color.
            * @param $right The right color.
            * @returns Whether or not the left is greater than or equal to the right.
            */
            public static op_GreaterThanOrEqual ($left: Godot.Color, $right: Godot.Color) : boolean
            /**
            * Returns
            * if this color and
            * are equal.
            * @param $obj The other object to compare.
            * @returns Whether or not the color and the other object are equal.
            */
            public Equals ($obj: any) : boolean
            /**
            * Returns
            * if the colors are exactly equal.
            * Note: Due to floating-point precision errors, consider using
            * instead, which is more reliable.
            * @param $other The other color.
            * @returns Whether or not the colors are equal.
            */
            public Equals ($other: Godot.Color) : boolean
            /**
            * Returns
            * if this color and
            * are approximately equal,
            * by running
            * on each component.
            * @param $other The other color to compare.
            * @returns Whether or not the colors are approximately equal.
            */
            public IsEqualApprox ($other: Godot.Color) : boolean
            /**
            * Converts this
            * to a string.
            * @returns A string representation of this color.
            */
            public ToString () : string
            /**
            * Converts this
            * to a string with the given
            * .
            * @returns A string representation of this color.
            */
            public ToString ($format: string) : string
            public constructor ($r: number, $g: number, $b: number, $a?: number)
            public constructor ($c: Godot.Color, $a?: number)
            public constructor ($rgba: number)
            public constructor ($rgba: bigint)
            public constructor ($code: string)
            public constructor ($code: string, $alpha: number)
        }
        /** 2-element structure that can be used to represent positions in 2D space or any other pair of numeric values.
        */
        class Vector2 extends System.ValueType implements System.IEquatable$1<Godot.Vector2>
        {
            protected [__keep_incompatibility]: never;
            /**
            * The vector's X component. Also accessible by using the index position
            * [0]
            * .
            */
            public X : number
            /**
            * The vector's Y component. Also accessible by using the index position
            * [1]
            * .
            */
            public Y : number
            /**
            * Zero vector, a vector with all components set to
            * 0
            * .
            */
            public static get Zero(): Godot.Vector2;
            /**
            * One vector, a vector with all components set to
            * 1
            * .
            */
            public static get One(): Godot.Vector2;
            /**
            * Infinity vector, a vector with all components set to
            * .
            */
            public static get Inf(): Godot.Vector2;
            /** Up unit vector. Y is down in 2D, so this vector points -Y.
            */
            public static get Up(): Godot.Vector2;
            /** Down unit vector. Y is down in 2D, so this vector points +Y.
            */
            public static get Down(): Godot.Vector2;
            /** Right unit vector. Represents the direction of right.
            */
            public static get Right(): Godot.Vector2;
            /** Left unit vector. Represents the direction of left.
            */
            public static get Left(): Godot.Vector2;
            public get_Item ($index: number) : number
            public set_Item ($index: number, $value: number) : void
            public Deconstruct ($x: $Ref<number>, $y: $Ref<number>) : void
            /** Returns a new vector with all components in absolute values (i.e. positive).
            * @returns A vector with  called on each component.
            */
            public Abs () : Godot.Vector2
            /**
            * Returns this vector's angle with respect to the X axis, or (1, 0) vector, in radians.
            * Equivalent to the result of
            * when
            * called with the vector's
            * and
            * as parameters:
            * Mathf.Atan2(v.Y, v.X)
            * .
            * @returns The angle of this vector, in radians.
            */
            public Angle () : number
            /** Returns the angle to the given vector, in radians.
            * @param $to The other vector to compare this vector to.
            * @returns The angle between the two vectors, in radians.
            */
            public AngleTo ($to: Godot.Vector2) : number
            /** Returns the angle between the line connecting the two points and the X axis, in radians.
            * @param $to The other vector to compare this vector to.
            * @returns The angle between the two vectors, in radians.
            */
            public AngleToPoint ($to: Godot.Vector2) : number
            /**
            * Returns the aspect ratio of this vector, the ratio of
            * to
            * .
            * @returns The  component divided by the  component.
            */
            public Aspect () : number
            /** Returns the vector "bounced off" from a plane defined by the given normal.
            * @param $normal The normal vector defining the plane to bounce off. Must be normalized.
            * @returns The bounced vector.
            */
            public Bounce ($normal: Godot.Vector2) : Godot.Vector2
            /** Returns a new vector with all components rounded up (towards positive infinity).
            * @returns A vector with  called on each component.
            */
            public Ceil () : Godot.Vector2
            /**
            * Returns a new vector with all components clamped between the
            * components of
            * and
            * using
            * .
            * @param $min The vector with minimum allowed values.
            * @param $max The vector with maximum allowed values.
            * @returns The vector with all components clamped.
            */
            public Clamp ($min: Godot.Vector2, $max: Godot.Vector2) : Godot.Vector2
            /**
            * Returns a new vector with all components clamped between the
            * and
            * using
            * .
            * @param $min The minimum allowed value.
            * @param $max The maximum allowed value.
            * @returns The vector with all components clamped.
            */
            public Clamp ($min: number, $max: number) : Godot.Vector2
            /**
            * Returns the cross product of this vector and
            * .
            * @param $with The other vector.
            * @returns The cross product value.
            */
            public Cross ($with: Godot.Vector2) : number
            /**
            * Performs a cubic interpolation between vectors
            * , this vector,
            * , and
            * , by the given amount
            * .
            * @param $b The destination vector.
            * @param $preA A vector before this vector.
            * @param $postB A vector after .
            * @param $weight A value on the range of 0.0 to 1.0, representing the amount of interpolation.
            * @returns The interpolated vector.
            */
            public CubicInterpolate ($b: Godot.Vector2, $preA: Godot.Vector2, $postB: Godot.Vector2, $weight: number) : Godot.Vector2
            /**
            * Performs a cubic interpolation between vectors
            * , this vector,
            * , and
            * , by the given amount
            * .
            * It can perform smoother interpolation than
            * by the time values.
            * @param $b The destination vector.
            * @param $preA A vector before this vector.
            * @param $postB A vector after .
            * @param $weight A value on the range of 0.0 to 1.0, representing the amount of interpolation.
            * @returns The interpolated vector.
            */
            public CubicInterpolateInTime ($b: Godot.Vector2, $preA: Godot.Vector2, $postB: Godot.Vector2, $weight: number, $t: number, $preAT: number, $postBT: number) : Godot.Vector2
            /**
            * Returns the point at the given
            * on a one-dimensional Bezier curve defined by this vector
            * and the given
            * ,
            * , and
            * points.
            * @param $control1 Control point that defines the bezier curve.
            * @param $control2 Control point that defines the bezier curve.
            * @param $end The destination vector.
            * @param $t A value on the range of 0.0 to 1.0, representing the amount of interpolation.
            * @returns The interpolated vector.
            */
            public BezierInterpolate ($control1: Godot.Vector2, $control2: Godot.Vector2, $end: Godot.Vector2, $t: number) : Godot.Vector2
            /**
            * Returns the derivative at the given
            * on the Bezier curve defined by this vector
            * and the given
            * ,
            * , and
            * points.
            * @param $control1 Control point that defines the bezier curve.
            * @param $control2 Control point that defines the bezier curve.
            * @param $end The destination value for the interpolation.
            * @param $t A value on the range of 0.0 to 1.0, representing the amount of interpolation.
            * @returns The resulting value of the interpolation.
            */
            public BezierDerivative ($control1: Godot.Vector2, $control2: Godot.Vector2, $end: Godot.Vector2, $t: number) : Godot.Vector2
            /**
            * Returns the normalized vector pointing from this vector to
            * .
            * @param $to The other vector to point towards.
            * @returns The direction from this vector to .
            */
            public DirectionTo ($to: Godot.Vector2) : Godot.Vector2
            /**
            * Returns the squared distance between this vector and
            * .
            * This method runs faster than
            * , so prefer it if
            * you need to compare vectors or need the squared distance for some formula.
            * @param $to The other vector to use.
            * @returns The squared distance between the two vectors.
            */
            public DistanceSquaredTo ($to: Godot.Vector2) : number
            /**
            * Returns the distance between this vector and
            * .
            * @param $to The other vector to use.
            * @returns The distance between the two vectors.
            */
            public DistanceTo ($to: Godot.Vector2) : number
            /**
            * Returns the dot product of this vector and
            * .
            * @param $with The other vector to use.
            * @returns The dot product of the two vectors.
            */
            public Dot ($with: Godot.Vector2) : number
            /** Returns a new vector with all components rounded down (towards negative infinity).
            * @returns A vector with  called on each component.
            */
            public Floor () : Godot.Vector2
            /**
            * Returns the inverse of this vector. This is the same as
            * new Vector2(1 / v.X, 1 / v.Y)
            * .
            * @returns The inverse of this vector.
            */
            public Inverse () : Godot.Vector2
            /**
            * Returns
            * if this vector is finite, by calling
            * on each component.
            * @returns Whether this vector is finite or not.
            */
            public IsFinite () : boolean
            /**
            * Returns
            * if the vector is normalized, and
            * otherwise.
            * @returns A  indicating whether or not the vector is normalized.
            */
            public IsNormalized () : boolean
            /** Returns the length (magnitude) of this vector.
            * @returns The length of this vector.
            */
            public Length () : number
            /**
            * Returns the squared length (squared magnitude) of this vector.
            * This method runs faster than
            * , so prefer it if
            * you need to compare vectors or need the squared length for some formula.
            * @returns The squared length of this vector.
            */
            public LengthSquared () : number
            /**
            * Returns the result of the linear interpolation between
            * this vector and
            * by amount
            * .
            * @param $to The destination vector for interpolation.
            * @param $weight A value on the range of 0.0 to 1.0, representing the amount of interpolation.
            * @returns The resulting vector of the interpolation.
            */
            public Lerp ($to: Godot.Vector2, $weight: number) : Godot.Vector2
            /**
            * Returns the vector with a maximum length by limiting its length to
            * .
            * @param $length The length to limit to.
            * @returns The vector with its length limited.
            */
            public LimitLength ($length?: number) : Godot.Vector2
            /**
            * Returns the result of the component-wise maximum between
            * this vector and
            * .
            * Equivalent to
            * new Vector2(Mathf.Max(X, with.X), Mathf.Max(Y, with.Y))
            * .
            * @param $with The other vector to use.
            * @returns The resulting maximum vector.
            */
            public Max ($with: Godot.Vector2) : Godot.Vector2
            /**
            * Returns the result of the component-wise maximum between
            * this vector and
            * .
            * Equivalent to
            * new Vector2(Mathf.Max(X, with), Mathf.Max(Y, with))
            * .
            * @param $with The other value to use.
            * @returns The resulting maximum vector.
            */
            public Max ($with: number) : Godot.Vector2
            /**
            * Returns the result of the component-wise minimum between
            * this vector and
            * .
            * Equivalent to
            * new Vector2(Mathf.Min(X, with.X), Mathf.Min(Y, with.Y))
            * .
            * @param $with The other vector to use.
            * @returns The resulting minimum vector.
            */
            public Min ($with: Godot.Vector2) : Godot.Vector2
            /**
            * Returns the result of the component-wise minimum between
            * this vector and
            * .
            * Equivalent to
            * new Vector2(Mathf.Min(X, with), Mathf.Min(Y, with))
            * .
            * @param $with The other value to use.
            * @returns The resulting minimum vector.
            */
            public Min ($with: number) : Godot.Vector2
            /**
            * Returns the axis of the vector's highest value. See
            * .
            * If both components are equal, this method returns
            * .
            * @returns The index of the highest axis.
            */
            public MaxAxisIndex () : Godot.Vector2.Axis
            /**
            * Returns the axis of the vector's lowest value. See
            * .
            * If both components are equal, this method returns
            * .
            * @returns The index of the lowest axis.
            */
            public MinAxisIndex () : Godot.Vector2.Axis
            /**
            * Moves this vector toward
            * by the fixed
            * amount.
            * @param $to The vector to move towards.
            * @param $delta The amount to move towards by.
            * @returns The resulting vector.
            */
            public MoveToward ($to: Godot.Vector2, $delta: number) : Godot.Vector2
            /**
            * Returns the vector scaled to unit length. Equivalent to
            * v / v.Length()
            * .
            * @returns A normalized version of the vector.
            */
            public Normalized () : Godot.Vector2
            /**
            * Returns a vector composed of the
            * of this vector's components
            * and
            * .
            * @param $mod A value representing the divisor of the operation.
            * @returns 
            A vector with each component  by .
            */
            public PosMod ($mod: number) : Godot.Vector2
            /**
            * Returns a vector composed of the
            * of this vector's components
            * and
            * 's components.
            * @param $modv A vector representing the divisors of the operation.
            * @returns 
            A vector with each component  by 's components.
            */
            public PosMod ($modv: Godot.Vector2) : Godot.Vector2
            /**
            * Returns a new vector resulting from projecting this vector onto the given vector
            * .
            * The resulting new vector is parallel to
            * .
            * See also
            * .
            * Note: If the vector
            * is a zero vector, the components of the resulting new vector will be
            * .
            * @param $onNormal The vector to project onto.
            * @returns The projected vector.
            */
            public Project ($onNormal: Godot.Vector2) : Godot.Vector2
            /**
            * Returns this vector reflected from a plane defined by the given
            * .
            * @param $normal The normal vector defining the plane to reflect from. Must be normalized.
            * @returns The reflected vector.
            */
            public Reflect ($normal: Godot.Vector2) : Godot.Vector2
            /**
            * Rotates this vector by
            * radians.
            * @param $angle The angle to rotate by, in radians.
            * @returns The rotated vector.
            */
            public Rotated ($angle: number) : Godot.Vector2
            /**
            * Returns this vector with all components rounded to the nearest integer,
            * with halfway cases rounded towards the nearest multiple of two.
            * @returns The rounded vector.
            */
            public Round () : Godot.Vector2
            /**
            * Returns a vector with each component set to one or negative one, depending
            * on the signs of this vector's components, or zero if the component is zero,
            * by calling
            * on each component.
            * @returns A vector with all components as either 1, -1, or 0.
            */
            public Sign () : Godot.Vector2
            /**
            * Returns the result of the spherical linear interpolation between
            * this vector and
            * by amount
            * .
            * This method also handles interpolating the lengths if the input vectors
            * have different lengths. For the special case of one or both input vectors
            * having zero length, this method behaves like
            * .
            * @param $to The destination vector for interpolation.
            * @param $weight A value on the range of 0.0 to 1.0, representing the amount of interpolation.
            * @returns The resulting vector of the interpolation.
            */
            public Slerp ($to: Godot.Vector2, $weight: number) : Godot.Vector2
            /**
            * Returns a new vector resulting from sliding this vector along a line with normal
            * .
            * The resulting new vector is perpendicular to
            * , and is equivalent to this vector minus its projection on
            * .
            * See also
            * .
            * Note: The vector
            * must be normalized. See also
            * .
            * @param $normal The normal vector of the plane to slide on.
            * @returns The slid vector.
            */
            public Slide ($normal: Godot.Vector2) : Godot.Vector2
            /**
            * Returns a new vector with each component snapped to the nearest multiple of the corresponding component in
            * .
            * This can also be used to round to an arbitrary number of decimals.
            * @param $step A vector value representing the step size to snap to.
            * @returns The snapped vector.
            */
            public Snapped ($step: Godot.Vector2) : Godot.Vector2
            /**
            * Returns a new vector with each component snapped to the nearest multiple of
            * .
            * This can also be used to round to an arbitrary number of decimals.
            * @param $step The step size to snap to.
            * @returns The snapped vector.
            */
            public Snapped ($step: number) : Godot.Vector2
            /**
            * Returns a perpendicular vector rotated 90 degrees counter-clockwise
            * compared to the original, with the same length.
            * @returns The perpendicular vector.
            */
            public Orthogonal () : Godot.Vector2
            /**
            * Creates a unit Vector2 rotated to the given angle. This is equivalent to doing
            * Vector2(Mathf.Cos(angle), Mathf.Sin(angle))
            * or
            * Vector2.Right.Rotated(angle)
            * .
            * @param $angle Angle of the vector, in radians.
            * @returns The resulting vector.
            */
            public static FromAngle ($angle: number) : Godot.Vector2
            /**
            * Adds each component of the
            * with the components of the given
            * .
            * @param $left The left vector.
            * @param $right The right vector.
            * @returns The added vector.
            */
            public static op_Addition ($left: Godot.Vector2, $right: Godot.Vector2) : Godot.Vector2
            /**
            * Subtracts each component of the
            * by the components of the given
            * .
            * @param $left The left vector.
            * @param $right The right vector.
            * @returns The subtracted vector.
            */
            public static op_Subtraction ($left: Godot.Vector2, $right: Godot.Vector2) : Godot.Vector2
            /**
            * Returns the negative value of the
            * .
            * This is the same as writing
            * new Vector2(-v.X, -v.Y)
            * .
            * This operation flips the direction of the vector while
            * keeping the same magnitude.
            * With floats, the number zero can be either positive or negative.
            * @param $vec The vector to negate/flip.
            * @returns The negated/flipped vector.
            */
            public static op_UnaryNegation ($vec: Godot.Vector2) : Godot.Vector2
            /**
            * Multiplies each component of the
            * by the given
            * .
            * @param $vec The vector to multiply.
            * @param $scale The scale to multiply by.
            * @returns The multiplied vector.
            */
            public static op_Multiply ($vec: Godot.Vector2, $scale: number) : Godot.Vector2
            /**
            * Multiplies each component of the
            * by the given
            * .
            * @param $scale The scale to multiply by.
            * @param $vec The vector to multiply.
            * @returns The multiplied vector.
            */
            public static op_Multiply ($scale: number, $vec: Godot.Vector2) : Godot.Vector2
            /**
            * Multiplies each component of the
            * by the components of the given
            * .
            * @param $left The left vector.
            * @param $right The right vector.
            * @returns The multiplied vector.
            */
            public static op_Multiply ($left: Godot.Vector2, $right: Godot.Vector2) : Godot.Vector2
            /**
            * Divides each component of the
            * by the given
            * .
            * @param $vec The dividend vector.
            * @param $divisor The divisor value.
            * @returns The divided vector.
            */
            public static op_Division ($vec: Godot.Vector2, $divisor: number) : Godot.Vector2
            /**
            * Divides each component of the
            * by the components of the given
            * .
            * @param $vec The dividend vector.
            * @param $divisorv The divisor vector.
            * @returns The divided vector.
            */
            public static op_Division ($vec: Godot.Vector2, $divisorv: Godot.Vector2) : Godot.Vector2
            /**
            * Gets the remainder of each component of the
            * with the components of the given
            * .
            * This operation uses truncated division, which is often not desired
            * as it does not work well with negative numbers.
            * Consider using
            * instead
            * if you want to handle negative numbers.
            * @param $vec The dividend vector.
            * @param $divisor The divisor value.
            * @returns The remainder vector.
            */
            public static op_Modulus ($vec: Godot.Vector2, $divisor: number) : Godot.Vector2
            /**
            * Gets the remainder of each component of the
            * with the components of the given
            * .
            * This operation uses truncated division, which is often not desired
            * as it does not work well with negative numbers.
            * Consider using
            * instead
            * if you want to handle negative numbers.
            * @param $vec The dividend vector.
            * @param $divisorv The divisor vector.
            * @returns The remainder vector.
            */
            public static op_Modulus ($vec: Godot.Vector2, $divisorv: Godot.Vector2) : Godot.Vector2
            /**
            * Returns
            * if the vectors are exactly equal.
            * Note: Due to floating-point precision errors, consider using
            * instead, which is more reliable.
            * @param $left The left vector.
            * @param $right The right vector.
            * @returns Whether or not the vectors are exactly equal.
            */
            public static op_Equality ($left: Godot.Vector2, $right: Godot.Vector2) : boolean
            /**
            * Returns
            * if the vectors are not equal.
            * Note: Due to floating-point precision errors, consider using
            * instead, which is more reliable.
            * @param $left The left vector.
            * @param $right The right vector.
            * @returns Whether or not the vectors are not equal.
            */
            public static op_Inequality ($left: Godot.Vector2, $right: Godot.Vector2) : boolean
            /**
            * Compares two
            * vectors by first checking if
            * the X value of the
            * vector is less than
            * the X value of the
            * vector.
            * If the X values are exactly equal, then it repeats this check
            * with the Y values of the two vectors.
            * This operator is useful for sorting vectors.
            * @param $left The left vector.
            * @param $right The right vector.
            * @returns Whether or not the left is less than the right.
            */
            public static op_LessThan ($left: Godot.Vector2, $right: Godot.Vector2) : boolean
            /**
            * Compares two
            * vectors by first checking if
            * the X value of the
            * vector is greater than
            * the X value of the
            * vector.
            * If the X values are exactly equal, then it repeats this check
            * with the Y values of the two vectors.
            * This operator is useful for sorting vectors.
            * @param $left The left vector.
            * @param $right The right vector.
            * @returns Whether or not the left is greater than the right.
            */
            public static op_GreaterThan ($left: Godot.Vector2, $right: Godot.Vector2) : boolean
            /**
            * Compares two
            * vectors by first checking if
            * the X value of the
            * vector is less than
            * or equal to the X value of the
            * vector.
            * If the X values are exactly equal, then it repeats this check
            * with the Y values of the two vectors.
            * This operator is useful for sorting vectors.
            * @param $left The left vector.
            * @param $right The right vector.
            * @returns Whether or not the left is less than or equal to the right.
            */
            public static op_LessThanOrEqual ($left: Godot.Vector2, $right: Godot.Vector2) : boolean
            /**
            * Compares two
            * vectors by first checking if
            * the X value of the
            * vector is greater than
            * or equal to the X value of the
            * vector.
            * If the X values are exactly equal, then it repeats this check
            * with the Y values of the two vectors.
            * This operator is useful for sorting vectors.
            * @param $left The left vector.
            * @param $right The right vector.
            * @returns Whether or not the left is greater than or equal to the right.
            */
            public static op_GreaterThanOrEqual ($left: Godot.Vector2, $right: Godot.Vector2) : boolean
            /**
            * Returns
            * if the vector is exactly equal
            * to the given object (
            * ).
            * Note: Due to floating-point precision errors, consider using
            * instead, which is more reliable.
            * @param $obj The object to compare with.
            * @returns Whether or not the vector and the object are equal.
            */
            public Equals ($obj: any) : boolean
            /**
            * Returns
            * if the vectors are exactly equal.
            * Note: Due to floating-point precision errors, consider using
            * instead, which is more reliable.
            * @param $other The other vector.
            * @returns Whether or not the vectors are exactly equal.
            */
            public Equals ($other: Godot.Vector2) : boolean
            /**
            * Returns
            * if this vector and
            * are approximately equal,
            * by running
            * on each component.
            * @param $other The other vector to compare.
            * @returns Whether or not the vectors are approximately equal.
            */
            public IsEqualApprox ($other: Godot.Vector2) : boolean
            /**
            * Returns
            * if this vector's values are approximately zero,
            * by running
            * on each component.
            * This method is faster than using
            * with one value
            * as a zero vector.
            * @returns Whether or not the vector is approximately zero.
            */
            public IsZeroApprox () : boolean
            /**
            * Converts this
            * to a string.
            * @returns A string representation of this vector.
            */
            public ToString () : string
            /**
            * Converts this
            * to a string with the given
            * .
            * @returns A string representation of this vector.
            */
            public ToString ($format: string) : string
            public constructor ($x: number, $y: number)
        }
        /** 2-element structure that can be used to represent 2D grid coordinates or pairs of integers.
        */
        class Vector2I extends System.ValueType implements System.IEquatable$1<Godot.Vector2I>
        {
            protected [__keep_incompatibility]: never;
        }
        /** 3-element structure that can be used to represent positions in 3D space or any other pair of numeric values.
        */
        class Vector3 extends System.ValueType implements System.IEquatable$1<Godot.Vector3>
        {
            protected [__keep_incompatibility]: never;
        }
        /** 3-element structure that can be used to represent 3D grid coordinates or sets of integers.
        */
        class Vector3I extends System.ValueType implements System.IEquatable$1<Godot.Vector3I>
        {
            protected [__keep_incompatibility]: never;
        }
        /** 4-element structure that can be used to represent positions in 4D space or any other pair of numeric values.
        */
        class Vector4 extends System.ValueType implements System.IEquatable$1<Godot.Vector4>
        {
            protected [__keep_incompatibility]: never;
        }
        /** 4-element structure that can be used to represent 4D grid coordinates or sets of integers.
        */
        class Vector4I extends System.ValueType implements System.IEquatable$1<Godot.Vector4I>
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * StringNames are immutable strings designed for general-purpose representation of unique names.
        * StringName ensures that only one instance of a given name exists (so two StringNames with the
        * same value are the same object).
        * Comparing them is much faster than with regular strings, because only the pointers are compared,
        * not the whole strings.
        */
        class StringName extends System.Object implements System.IDisposable, System.IEquatable$1<Godot.StringName>
        {
            protected [__keep_incompatibility]: never;
            /**
            * Check whether this
            * is empty.
            * @returns If the  is empty.
            */
            public get IsEmpty(): boolean;
            /**
            * Disposes of this
            * .
            */
            public Dispose () : void
            public Dispose ($disposing: boolean) : void
            public static op_Implicit ($from: string) : Godot.StringName
            public static op_Implicit ($from: Godot.StringName) : string
            public static op_Equality ($left: Godot.StringName, $right: Godot.StringName) : boolean
            public static op_Inequality ($left: Godot.StringName, $right: Godot.StringName) : boolean
            public Equals ($other: Godot.StringName) : boolean
            public static op_Equality ($left: Godot.StringName, $right: $Ref<Godot.NativeInterop.godot_string_name>) : boolean
            public static op_Inequality ($left: Godot.StringName, $right: $Ref<Godot.NativeInterop.godot_string_name>) : boolean
            public static op_Equality ($left: $Ref<Godot.NativeInterop.godot_string_name>, $right: Godot.StringName) : boolean
            public static op_Inequality ($left: $Ref<Godot.NativeInterop.godot_string_name>, $right: Godot.StringName) : boolean
            public Equals ($other: $Ref<Godot.NativeInterop.godot_string_name>) : boolean
            public Equals ($obj: any) : boolean
            public constructor ()
            public constructor ($name: string)
        }
        /**
        * Nodes are Godot's building blocks. They can be assigned as the child of another node, resulting in a tree arrangement. A given node can contain any number of nodes as children with the requirement that all siblings (direct children of a node) should have unique names.
        * . Scenes can be saved to the disk and then instantiated into other scenes. This allows for very high flexibility in the architecture and data model of Godot projects.
        *  callback of a parent node will be triggered before its child's.
        *  callback is called in reverse order, starting with the children and moving up to the parent nodes.
        *  of the parent (recursively for the entire scene tree).
        * ) happens a fixed number of times per second (60 by default) and is useful for code related to the physics engine.
        *  nodes), ensuring that the node only receives the events that were meant for it.
        *  property. This keeps track of who instantiated what. This is mostly useful when writing editors and tools, though.
        * , it will also free all its children.
        * .
        *  (make sure node names are the same on all peers). Also, take a look at the high-level networking tutorial and corresponding demos.
        * ).
        */
        class Node extends Godot.GodotObject implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /**
            * .
            *  signal.
            */
            public static NotificationEnterTree : bigint
            /**
            * .
            *  signal.
            */
            public static NotificationExitTree : bigint
            /** .
            */
            public static NotificationReady : bigint
            /** .
            */
            public static NotificationPaused : bigint
            /** .
            */
            public static NotificationUnpaused : bigint
            /** .
            */
            public static NotificationPhysicsProcess : bigint
            /** .
            */
            public static NotificationProcess : bigint
            /**
            * ).
            * .
            */
            public static NotificationParented : bigint
            /**
            *  on this node.
            * .
            */
            public static NotificationUnparented : bigint
            /**  is completed.
            */
            public static NotificationSceneInstantiated : bigint
            /**
            * Notification received when a drag operation begins. All nodes receive this notification, not only the dragged one.
            * .
            *  to get the dragged data.
            */
            public static NotificationDragBegin : bigint
            /**
            * Notification received when a drag operation ends.
            *  to check if the drag succeeded.
            */
            public static NotificationDragEnd : bigint
            /** .
            */
            public static NotificationPathRenamed : bigint
            /** Notification received when the list of children is changed. This happens when child nodes are added, moved or removed.
            */
            public static NotificationChildOrderChanged : bigint
            /** .
            */
            public static NotificationInternalProcess : bigint
            /** .
            */
            public static NotificationInternalPhysicsProcess : bigint
            /**  may be received. Unlike the latter, it is sent every time the node enters tree, not just once.
            */
            public static NotificationPostEnterTree : bigint
            /** .
            */
            public static NotificationDisabled : bigint
            /** .
            */
            public static NotificationEnabled : bigint
            /**  is called on the node or its ancestors.
            */
            public static NotificationResetPhysicsInterpolation : bigint
            /** Notification received right before the scene with the node is saved in the editor. This notification is only sent in the Godot editor and will not occur in exported projects.
            */
            public static NotificationEditorPreSave : bigint
            /** Notification received right after the scene with the node is saved in the editor. This notification is only sent in the Godot editor and will not occur in exported projects.
            */
            public static NotificationEditorPostSave : bigint
            /**
            * Notification received when the mouse enters the window.
            * Implemented for embedded windows and on desktop and web platforms.
            */
            public static NotificationWMMouseEnter : bigint
            /**
            * Notification received when the mouse leaves the window.
            * Implemented for embedded windows and on desktop and web platforms.
            */
            public static NotificationWMMouseExit : bigint
            /**
            *  is also received).
            *  node receives this notification when it is focused.
            */
            public static NotificationWMWindowFocusIn : bigint
            /**
            *  is also received).
            *  node receives this notification when it is defocused.
            */
            public static NotificationWMWindowFocusOut : bigint
            /**
            * Notification received from the OS when a close request is sent (e.g. closing the window with a "Close" button or Alt + F4).
            * Implemented on desktop platforms.
            */
            public static NotificationWMCloseRequest : bigint
            /**
            * Notification received from the OS when a go back request is sent (e.g. pressing the "Back" button on Android).
            * Implemented only on Android.
            */
            public static NotificationWMGoBackRequest : bigint
            /**
            * Notification received when the window is resized.
            *  node receives this notification, and it's not propagated to the child nodes.
            */
            public static NotificationWMSizeChanged : bigint
            /** Notification received from the OS when the screen's dots per inch (DPI) scale is changed. Only implemented on macOS.
            */
            public static NotificationWMDpiChange : bigint
            /**  and regardless if it's currently focused or not.
            */
            public static NotificationVpMouseEnter : bigint
            /**  and regardless if it's currently focused or not.
            */
            public static NotificationVpMouseExit : bigint
            /** Notification received when the window is moved.
            */
            public static NotificationWMPositionChanged : bigint
            /**
            * Notification received from the OS when the application is exceeding its allocated memory.
            * Implemented only on iOS.
            */
            public static NotificationOsMemoryWarning : bigint
            /**
            * .
            * .
            * 
            func _notification(what):
            if what == NOTIFICATION_TRANSLATION_CHANGED:
            if not is_node_ready():
            await ready # Wait until ready signal.
            $Label.text = atr("%d Bananas") % banana_counter
            */
            public static NotificationTranslationChanged : bigint
            /**
            * Notification received from the OS when a request for "About" information is sent.
            * Implemented only on macOS.
            */
            public static NotificationWMAbout : bigint
            /**
            * Notification received from Godot's crash handler when the engine is about to crash.
            * Implemented on desktop platforms, if the crash handler is enabled.
            */
            public static NotificationCrash : bigint
            /**
            * Notification received from the OS when an update of the Input Method Engine occurs (e.g. change of IME cursor position or composition string).
            * Implemented only on macOS.
            */
            public static NotificationOsImeUpdate : bigint
            /**
            * Notification received from the OS when the application is resumed.
            * Specific to the Android and iOS platforms.
            */
            public static NotificationApplicationResumed : bigint
            /**
            * Notification received from the OS when the application is paused.
            * Specific to the Android and iOS platforms.
            *  On iOS, you only have approximately 5 seconds to finish a task started by this signal. If you go over this allotment, iOS will kill the app instead of pausing it.
            */
            public static NotificationApplicationPaused : bigint
            /**
            * Notification received from the OS when the application is focused, i.e. when changing the focus from the OS desktop or a thirdparty application to any open window of the Godot instance.
            * Implemented on desktop and mobile platforms.
            */
            public static NotificationApplicationFocusIn : bigint
            /**
            * Notification received from the OS when the application is defocused, i.e. when changing the focus from any open window of the Godot instance to the OS desktop or a thirdparty application.
            * Implemented on desktop and mobile platforms.
            */
            public static NotificationApplicationFocusOut : bigint
            /**  is changed.
            */
            public static NotificationTextServerChanged : bigint
            /** Notification received when an accessibility information update is required.
            */
            public static NotificationAccessibilityUpdate : bigint
            /** Notification received when accessibility elements are invalidated. All node accessibility elements are automatically deleted after receiving this message, therefore all existing references to such elements should be discarded.
            */
            public static NotificationAccessibilityInvalidate : bigint
            public get _ImportPath(): Godot.NodePath;
            public set _ImportPath(value: Godot.NodePath);
            /**
            * The name of the node. This name must be unique among the siblings (other child nodes from the same parent). When set to an existing sibling's name, the node is automatically renamed.
            * .
            */
            public get Name(): Godot.StringName;
            public set Name(value: Godot.StringName);
            /**
            * .
            *  as this node, the other node will no longer be accessible as unique.
            */
            public get UniqueNameInOwner(): boolean;
            public set UniqueNameInOwner(value: boolean);
            /**  file. Only scene root nodes contains this.
            */
            public get SceneFilePath(): string;
            public set SceneFilePath(value: string);
            /**
            * .
            * .
            */
            public get Owner(): Godot.Node;
            public set Owner(value: Godot.Node);
            /**
            * .
            *  to the new path, you will have to update this manually.
            */
            public get Multiplayer(): Godot.MultiplayerApi;
            /** .
            */
            public get ProcessMode(): Godot.Node.ProcessModeEnum;
            public set ProcessMode(value: Godot.Node.ProcessModeEnum);
            /**  call their process callbacks first, regardless of tree order.
            */
            public get ProcessPriority(): number;
            public set ProcessPriority(value: number);
            /** .
            */
            public get ProcessPhysicsPriority(): number;
            public set ProcessPhysicsPriority(value: number);
            /**
            *  (and the internal versions) on the main thread or in a sub-thread.
            * . This default group will process on the main thread and its group order is 0.
            *  and the likes in order to communicate from the thread groups to the main thread (or to other thread groups).
            *  will include any child (and grandchild) nodes set to inherit into its process thread group. This means that the processing of all the nodes in the group will happen together, at the same time as the node including them.
            */
            public get ProcessThreadGroup(): Godot.Node.ProcessThreadGroupEnum;
            public set ProcessThreadGroup(value: Godot.Node.ProcessThreadGroupEnum);
            /** Change the process thread group order. Groups with a lesser order will process before groups with a greater order. This is useful when a large amount of nodes process in sub thread and, afterwards, another group wants to collect their result in the main thread, as an example.
            */
            public get ProcessThreadGroupOrder(): number;
            public set ProcessThreadGroupOrder(value: number);
            /**  on threads), and whether it wants to receive them during regular process or physics process callbacks.
            */
            public get ProcessThreadMessages(): Godot.Node.ProcessThreadMessagesEnum;
            public set ProcessThreadMessages(value: Godot.Node.ProcessThreadMessagesEnum);
            /**
            * .
            * By default, nodes inherit the physics interpolation mode from their parent. This property can enable or disable physics interpolation individually for each node, regardless of their parents' physics interpolation mode.
            *  have physics interpolation disabled by default, as they rely on their own custom solution.
            *  moving the node. This avoids creating a visual streak between the old and new positions.
            */
            public get PhysicsInterpolationMode(): Godot.Node.PhysicsInterpolationModeEnum;
            public set PhysicsInterpolationMode(value: Godot.Node.PhysicsInterpolationModeEnum);
            /**
            * , etc.). Also decides if the node's strings should be parsed for POT generation.
            * .
            */
            public get AutoTranslateMode(): Godot.Node.AutoTranslateModeEnum;
            public set AutoTranslateMode(value: Godot.Node.AutoTranslateModeEnum);
            /** An optional description to the node. It will be displayed as a tooltip when hovering over the node in the editor's Scene dock.
            */
            public get EditorDescription(): string;
            public set EditorDescription(value: string);
            /**
            *  callback will be called first, and then that of the children.
            * .
            */
            public _EnterTree () : void
            /**
            *  callback will be called last, after all its children have left the tree.
            * .
            */
            public _ExitTree () : void
            /**
            *  script, and accessibility warnings are enabled in the editor settings.
            * Returning an empty array produces no warnings.
            */
            public _GetAccessibilityConfigurationWarnings () : System.Array$1<string>
            /**
            *  script.
            * Returning an empty array produces no warnings.
            *  when the warnings need to be updated for this node.
            * 
            @export var energy = 0:
            set(value):
            energy = value
            update_configuration_warnings()
            func _get_configuration_warnings():
            if energy < 0:
            return ["Energy must be 0 or greater."]
            else:
            return []
            */
            public _GetConfigurationWarnings () : System.Array$1<string>
            /** .
            */
            public _GetFocusedAccessibilityElement () : Godot.Rid
            /**
            * Called when there is an input event. The input event propagates up through the node tree until a node consumes it.
            * .
            *  can be called.
            *  are usually a better fit as they allow the GUI to intercept the events first.
            *  This method is only called if the node is present in the scene tree (i.e. if it's not an orphan).
            */
            public _Input ($event: Godot.InputEvent) : void
            /**
            *  is in seconds.
            * .
            * , lower priority values are called first. Nodes with the same priority are processed in tree order, or top to bottom as seen in the editor (also known as pre-order traversal).
            * .
            *  This method is only called if the node is present in the scene tree (i.e. if it's not an orphan).
            * .
            */
            public _PhysicsProcess ($delta: number) : void
            /**
            *  is in seconds.
            * .
            * , lower priority values are called first. Nodes with the same priority are processed in tree order, or top to bottom as seen in the editor (also known as pre-order traversal).
            * .
            *  This method is only called if the node is present in the scene tree (i.e. if it's not an orphan).
            * .
            */
            public _Process ($delta: number) : void
            /**
            *  callbacks get triggered first, and the parent node will receive the ready notification afterwards.
            *  annotation for variables.
            * .
            * , which may be called anywhere before adding the node again.
            */
            public _Ready () : void
            /**
            * . The input event propagates up through the node tree until a node consumes it.
            * .
            *  can be called.
            * .
            *  This method is only called if the node is present in the scene tree (i.e. if it's not orphan).
            */
            public _ShortcutInput ($event: Godot.InputEvent) : void
            /**
            * . The input event propagates up through the node tree until a node consumes it.
            * .
            *  can be called.
            *  for performance reasons.
            *  This method is only called if the node is present in the scene tree (i.e. if it's not an orphan).
            */
            public _UnhandledInput ($event: Godot.InputEvent) : void
            /**
            * . The input event propagates up through the node tree until a node consumes it.
            * .
            *  can be called.
            * This method can be used to handle Unicode character input with Alt, Alt + Ctrl, and Alt + Shift modifiers, after shortcuts were handled.
            *  instead.
            *  This method is only called if the node is present in the scene tree (i.e. if it's not an orphan).
            */
            public _UnhandledKeyInput ($event: Godot.InputEvent) : void
            /**
            * ). Useful for debugging.
            *  This method only works in debug builds. Does nothing in a project exported in release mode.
            */
            public static PrintOrphanNodes () : void
            /**
            * ). Used for debugging.
            *  will return an empty array.
            */
            public static GetOrphanNodeIds () : Godot.Collections.Array$1<number>
            /**
            *  node to this node's parent, and moves the added sibling right below this node.
            *  in both situations.
            *  instead of this method if you don't need the child node to be added below a specific node in the list of children.
            *  parameter).
            */
            public AddSibling ($sibling: Godot.Node, $forceReadableName?: boolean) : void
            public SetName ($name: Godot.StringName) : void
            public GetName () : Godot.StringName
            public AddChild ($node: Godot.Node, $forceReadableName?: boolean, $internal?: Godot.Node.InternalMode) : void
            /**
            * .
            * ).
            */
            public RemoveChild ($node: Godot.Node) : void
            /**
            *  is preserved if its owner is still reachable from the new location (i.e., the node is still a descendant of the new parent after the operation).
            *  keeps only position).
            */
            public Reparent ($newParent: Godot.Node, $keepGlobalTransform?: boolean) : void
            /**
            * Returns the number of children of this node.
            *  parameter).
            */
            public GetChildCount ($includeInternal?: boolean) : number
            /**
            * .
            *  parameter).
            */
            public GetChildren ($includeInternal?: boolean) : Godot.Collections.Array$1<Godot.Node>
            /**
            *  and an error is generated.
            *  parameter).
            * 
            # Assuming the following are children of this node, in order:
            # First, Middle, Last.
            var a = get_child(0).name  # a is "First"
            var b = get_child(1).name  # b is "Middle"
            var b = get_child(2).name  # b is "Last"
            var c = get_child(-1).name # c is "Last"
            * .
            */
            public GetChild ($idx: number, $includeInternal?: boolean) : Godot.Node
            /** .
            */
            public HasNode ($path: Godot.NodePath) : boolean
            /**
            *  error.
            * ).
            *  Assume this method is called from the Character node, inside the following tree:
            * 
            ┖╴root
            ┠╴Character (you are here!)
            ┃  ┠╴Sword
            ┃  ┖╴Backpack
            ┃     ┖╴Dagger
            ┠╴MyGame
            ┖╴Swamp
            ┠╴Alligator
            ┠╴Mosquito
            ┖╴Goblin
            * The following calls will return a valid node:
            * 
            GetNode("Sword");
            GetNode("Backpack/Dagger");
            GetNode("../Swamp/Alligator");
            GetNode("/root/MyGame");
            */
            public GetNode ($path: Godot.NodePath) : Godot.Node
            /**  does not point to a valid node.
            */
            public GetNodeOrNull ($path: Godot.NodePath) : Godot.Node
            /**  if the node doesn't have a parent.
            */
            public GetParent () : Godot.Node
            /**
            *  matches any single character.
            * ).
            *  node are checked.
            * ).
            * .
            */
            public FindChild ($pattern: string, $recursive?: boolean, $owned?: boolean) : Godot.Node
            /**
            *  matches any single character.
            * ).
            * ).
            *  node are checked.
            *  This method can be very slow. Consider storing references to the found nodes in a variable.
            * .
            */
            public FindChildren ($pattern: string, $type?: string, $recursive?: boolean, $owned?: boolean) : Godot.Collections.Array$1<Godot.Node>
            /**
            * .
            * ).
            */
            public FindParent ($pattern: string) : Godot.Node
            /** .
            */
            public HasNodeAndResource ($path: Godot.NodePath) : boolean
            /**
            *  where:
            *  if not found;
            *  if not found;
            * ).
            * :
            * 
            var a = GetNodeAndResource(NodePath("Area2D/Sprite2D"));
            GD.Print(a[0].Name); // Prints Sprite2D
            GD.Print(a[1]);      // Prints <null>
            GD.Print(a[2]);      // Prints ^"
            var b = GetNodeAndResource(NodePath("Area2D/Sprite2D:texture:atlas"));
            GD.Print(b[0].name);        // Prints Sprite2D
            GD.Print(b[1].get_class()); // Prints AtlasTexture
            GD.Print(b[2]);             // Prints ^""
            var c = GetNodeAndResource(NodePath("Area2D/Sprite2D:texture:atlas:region"));
            GD.Print(c[0].name);        // Prints Sprite2D
            GD.Print(c[1].get_class()); // Prints AtlasTexture
            GD.Print(c[2]);             // Prints ^":region"
            */
            public GetNodeAndResource ($path: Godot.NodePath) : Godot.Collections.Array
            /** .
            */
            public IsInsideTree () : boolean
            /**  if the node is part of the scene currently opened in the editor.
            */
            public IsPartOfEditedScene () : boolean
            /**  is a direct or indirect child of this node.
            */
            public IsAncestorOf ($node: Godot.Node) : boolean
            /**  occurs later in the scene hierarchy than this node. A node occurring later is usually processed last.
            */
            public IsGreaterThan ($node: Godot.Node) : boolean
            /** .
            */
            public GetPath () : Godot.NodePath
            /**
            * .
            * ).
            *  If you get a relative path which starts from a unique node, the path may be longer than a normal relative path, due to the addition of the unique node's name.
            */
            public GetPathTo ($node: Godot.Node, $useUniquePath?: boolean) : Godot.NodePath
            /**
            * .
            * . All groups created and displayed in the Node dock are persistent.
            *  guaranteed and may vary between project runs. Therefore, do not rely on the group order.
            * ).
            */
            public AddToGroup ($group: Godot.StringName, $persistent?: boolean) : void
            /** 's group methods.
            */
            public RemoveFromGroup ($group: Godot.StringName) : void
            /** 's group methods.
            */
            public IsInGroup ($group: Godot.StringName) : boolean
            /**
            * .
            * .
            */
            public MoveChild ($childNode: Godot.Node, $toIndex: number) : void
            /**
            *  of group names that the node has been added to.
            *  guaranteed and may vary between project runs. Therefore, do not rely on the group order.
            * ). These are internally used by the engine. To avoid conflicts, do not use custom groups starting with underscores. To exclude internal groups, see the following code snippet:
            * 
            // Stores the node's non-internal groups only (as a List of StringNames).
            List<string> nonInternalGroups = new List<string>();
            foreach (string group in GetGroups())
            {
            if (!group.BeginsWith("_"))
            nonInternalGroups.Add(group);
            }
            */
            public GetGroups () : Godot.Collections.Array$1<Godot.StringName>
            public SetOwner ($owner: Godot.Node) : void
            public GetOwner () : Godot.Node
            /**
            * .
            *  parameter).
            */
            public GetIndex ($includeInternal?: boolean) : number
            /**
            * .
            * May print, for example:
            * 
            .
            Menu
            Menu/Label
            Menu/Camera2D
            SplashScreen
            SplashScreen/Camera2D
            */
            public PrintTree () : void
            /**
            * , but the graphical representation looks like what is displayed in the editor's Scene dock. It is useful for inspecting larger trees.
            * May print, for example:
            * 
            ┖╴TheGame
            ┠╴Menu
            ┃  ┠╴Label
            ┃  ┖╴Camera2D
            ┖╴SplashScreen
            ┖╴Camera2D
            */
            public PrintTreePretty () : void
            /**
            *  function. It also can be used in game UI/UX.
            * May print, for example:
            * 
            TheGame
            TheGame/Menu
            TheGame/Menu/Label
            TheGame/Menu/Camera2D
            TheGame/SplashScreen
            TheGame/SplashScreen/Camera2D
            */
            public GetTreeString () : string
            /**
            * . This version displays a more graphical representation similar to what is displayed in the Scene Dock. It is useful for inspecting larger trees.
            * May print, for example:
            * 
            ┖╴TheGame
            ┠╴Menu
            ┃  ┠╴Label
            ┃  ┖╴Camera2D
            ┖╴SplashScreen
            ┖╴Camera2D
            */
            public GetTreeStringPretty () : string
            public SetSceneFilePath ($sceneFilePath: string) : void
            public GetSceneFilePath () : string
            /**  on this node and all of its children, recursively.
            */
            public PropagateNotification ($what: number) : void
            /**
            *  as arguments, on this node and all of its children, recursively.
            * , the children's methods are called first.
            */
            public PropagateCall ($method: Godot.StringName, $args?: Godot.Collections.Array, $parentFirst?: boolean) : void
            /**
            *  callback will be called if it exists).
            *  is called.
            */
            public SetPhysicsProcess ($enable: boolean) : void
            /**
            * .
            * .
            */
            public GetPhysicsProcessDeltaTime () : number
            /** ).
            */
            public IsPhysicsProcessing () : boolean
            /**
            * .
            * .
            */
            public GetProcessDeltaTime () : number
            /**
            *  callback will be called if it exists).
            *  is called.
            * .
            */
            public SetProcess ($enable: boolean) : void
            public SetProcessPriority ($priority: number) : void
            public GetProcessPriority () : number
            public SetPhysicsProcessPriority ($priority: number) : void
            public GetPhysicsProcessPriority () : number
            /** ).
            */
            public IsProcessing () : boolean
            /**
            * , enables input processing.
            * .
            */
            public SetProcessInput ($enable: boolean) : void
            /** ).
            */
            public IsProcessingInput () : boolean
            /**
            * , enables shortcut processing for this node.
            *  is called.
            */
            public SetProcessShortcutInput ($enable: boolean) : void
            /** ).
            */
            public IsProcessingShortcutInput () : boolean
            /**
            * ).
            * .
            */
            public SetProcessUnhandledInput ($enable: boolean) : void
            /** ).
            */
            public IsProcessingUnhandledInput () : boolean
            /**
            * , enables unhandled key input processing.
            *  is called.
            */
            public SetProcessUnhandledKeyInput ($enable: boolean) : void
            /** ).
            */
            public IsProcessingUnhandledKeyInput () : boolean
            public SetProcessMode ($mode: Godot.Node.ProcessModeEnum) : void
            public GetProcessMode () : Godot.Node.ProcessModeEnum
            /**
            * :
            * ;
            * ;
            * ;
            * ;
            *  to determine the result.
            * .
            */
            public CanProcess () : boolean
            public SetProcessThreadGroup ($mode: Godot.Node.ProcessThreadGroupEnum) : void
            public GetProcessThreadGroup () : Godot.Node.ProcessThreadGroupEnum
            public SetProcessThreadMessages ($flags: Godot.Node.ProcessThreadMessagesEnum) : void
            public GetProcessThreadMessages () : Godot.Node.ProcessThreadMessagesEnum
            public SetProcessThreadGroupOrder ($order: number) : void
            public GetProcessThreadGroupOrder () : number
            /** Queues an accessibility information update for this node.
            */
            public QueueAccessibilityUpdate () : void
            /**
            * Returns main accessibility element RID.
            * ).
            */
            public GetAccessibilityElement () : Godot.Rid
            /** .
            */
            public SetDisplayFolded ($fold: boolean) : void
            /** .
            */
            public IsDisplayedFolded () : boolean
            /**
            * ).
            *  Built-in nodes rely on internal processing for their internal logic. Disabling it is unsafe and may lead to unexpected behavior. Use this method if you know what you are doing.
            */
            public SetProcessInternal ($enable: boolean) : void
            /** ).
            */
            public IsProcessingInternal () : boolean
            /**
            * ).
            *  Built-in nodes rely on internal processing for their internal logic. Disabling it is unsafe and may lead to unexpected behavior. Use this method if you know what you are doing.
            */
            public SetPhysicsProcessInternal ($enable: boolean) : void
            /** ).
            */
            public IsPhysicsProcessingInternal () : boolean
            public SetPhysicsInterpolationMode ($mode: Godot.Node.PhysicsInterpolationModeEnum) : void
            public GetPhysicsInterpolationMode () : Godot.Node.PhysicsInterpolationModeEnum
            /**
            * ).
            * .
            */
            public IsPhysicsInterpolated () : boolean
            /**
            * .
            *  that also checks whether physics interpolation is enabled globally.
            * .
            */
            public IsPhysicsInterpolatedAndEnabled () : boolean
            /**
            * When physics interpolation is active, moving a node to a radically different transform (such as placement within a level) can result in a visible glitch as the object is rendered moving from the old to new position over the physics tick.
            * That glitch can be prevented by calling this method, which temporarily disables interpolation until the physics tick is complete.
            *  will be received by the node and all children recursively.
            *  moving the node, rather than before.
            */
            public ResetPhysicsInterpolation () : void
            public SetAutoTranslateMode ($mode: Godot.Node.AutoTranslateModeEnum) : void
            public GetAutoTranslateMode () : Godot.Node.AutoTranslateModeEnum
            /** .
            */
            public CanAutoTranslate () : boolean
            /**
            * Makes this node inherit the translation domain from its parent node. If this node has no parent, the main translation domain will be used.
            *  disables this behavior.
            */
            public SetTranslationDomainInherited () : void
            /** ).
            */
            public GetWindow () : Godot.Window
            /**  that contains this node, or the last exclusive child in a chain of windows starting with the one that contains this node.
            */
            public GetLastExclusiveWindow () : Godot.Window
            /** .
            */
            public GetTree () : Godot.SceneTree
            /**
            *  and binds it to this node.
            * This is the equivalent of doing:
            * 
            GetTree().CreateTween().BindNode(this);
            *  for more info on Tweens bound to nodes.
            * .
            */
            public CreateTween () : Godot.Tween
            /**
            * ). Internal nodes are not duplicated.
            * .
            */
            public Duplicate ($flags?: number) : Godot.Node
            /**
            * .
            * ).
            * .
            */
            public ReplaceBy ($node: Godot.Node, $keepGroups?: boolean) : void
            /** .
            */
            public SetSceneInstanceLoadPlaceholder ($loadPlaceholder: boolean) : void
            /** .
            */
            public GetSceneInstanceLoadPlaceholder () : boolean
            /** .
            */
            public SetEditableInstance ($node: Godot.Node, $isEditable: boolean) : void
            /** .
            */
            public IsEditableInstance ($node: Godot.Node) : boolean
            /** .
            */
            public GetViewport () : Godot.Viewport
            /**
            * Queues this node to be deleted at the end of the current frame. When deleted, all of its children are deleted as well, and all references to the node and its children become invalid.
            *  to check if the node will be deleted at the end of the frame.
            * .
            */
            public QueueFree () : void
            /**
            * .
            *  callbacks will be the same as normal.
            */
            public RequestReady () : void
            /**
            *  if the node is ready, i.e. it's inside scene tree and all its children are initialized.
            * .
            */
            public IsNodeReady () : boolean
            /**
            * .
            * , the given peer is recursively set as the authority for all children of this node.
            *  propagate to newly added children.
            */
            public SetMultiplayerAuthority ($id: number, $recursive?: boolean) : void
            /** .
            */
            public GetMultiplayerAuthority () : number
            /**  if the local system is the multiplayer authority of this node.
            */
            public IsMultiplayerAuthority () : boolean
            public GetMultiplayer () : Godot.MultiplayerApi
            /**
            *  containing the following entries:
            * ;
            * ;
            * , the method will also be called locally;
            *  representing the channel to send the RPC on.
            *  tutorial.
            */
            public RpcConfig ($method: Godot.StringName, $config: Godot.Variant) : void
            /**
            * .
            * .
            */
            public GetNodeRpcConfig () : Godot.Variant
            public SetEditorDescription ($editorDescription: string) : void
            public GetEditorDescription () : string
            public SetUniqueNameInOwner ($enable: boolean) : void
            public IsUniqueNameInOwner () : boolean
            /**
            *  nodes automatically translate their strings, so this method is mostly useful for formatted strings or custom drawn text.
            *  state.
            * .
            * .
            */
            public Atr ($message: string, $context?: Godot.StringName) : string
            /**
            *  can be specified to help with the translation.
            *  state.
            * .
            *  is the number, or amount, of the message's subject. It is used by the translation system to fetch the correct plural form for the current language.
            * .
            * .
            */
            public AtrN ($message: string, $pluralMessage: Godot.StringName, $n: number, $context?: Godot.StringName) : string
            /**
            *  and [annotation @GDScript.@rpc]). By default, methods are not exposed to RPCs.
            * 's connection is not available.
            * ).
            */
            public Rpc ($method: Godot.StringName, ...args: Godot.Variant[]) : Godot.Error
            /**
            * ).
            * 's connection is not available.
            */
            public RpcId ($peerId: bigint, $method: Godot.StringName, ...args: Godot.Variant[]) : Godot.Error
            /**  to customize the warning messages to display.
            */
            public UpdateConfigurationWarnings () : void
            /**  or their internal versions are called.
            */
            public CallDeferredThreadGroup ($method: Godot.StringName, ...args: Godot.Variant[]) : Godot.Variant
            /** , but for setting properties.
            */
            public SetDeferredThreadGroup ($property: Godot.StringName, $value: Godot.Variant) : void
            /** , but for notifications.
            */
            public NotifyDeferredThreadGroup ($what: number) : void
            /** This function ensures that the calling of this function will succeed, no matter whether it's being done from a thread or not. If called from a thread that is not allowed to call the function, the call will become deferred. Otherwise, the call will go through directly.
            */
            public CallThreadSafe ($method: Godot.StringName, ...args: Godot.Variant[]) : Godot.Variant
            /** , but for setting properties.
            */
            public SetThreadSafe ($property: Godot.StringName, $value: Godot.Variant) : void
            /** , but for notifications.
            */
            public NotifyThreadSafe ($what: number) : void
            public GetRpcConfig () : Godot.Variant
            public SetName ($name: string) : void
            public add_Ready ($value: System.Action) : void
            public remove_Ready ($value: System.Action) : void
            public add_Renamed ($value: System.Action) : void
            public remove_Renamed ($value: System.Action) : void
            public add_TreeEntered ($value: System.Action) : void
            public remove_TreeEntered ($value: System.Action) : void
            public add_TreeExiting ($value: System.Action) : void
            public remove_TreeExiting ($value: System.Action) : void
            public add_TreeExited ($value: System.Action) : void
            public remove_TreeExited ($value: System.Action) : void
            public add_ChildEnteredTree ($value: Godot.Node.ChildEnteredTreeEventHandler) : void
            public remove_ChildEnteredTree ($value: Godot.Node.ChildEnteredTreeEventHandler) : void
            public add_ChildExitingTree ($value: Godot.Node.ChildExitingTreeEventHandler) : void
            public remove_ChildExitingTree ($value: Godot.Node.ChildExitingTreeEventHandler) : void
            public add_ChildOrderChanged ($value: System.Action) : void
            public remove_ChildOrderChanged ($value: System.Action) : void
            public add_ReplacingBy ($value: Godot.Node.ReplacingByEventHandler) : void
            public remove_ReplacingBy ($value: Godot.Node.ReplacingByEventHandler) : void
            public add_EditorDescriptionChanged ($value: Godot.Node.EditorDescriptionChangedEventHandler) : void
            public remove_EditorDescriptionChanged ($value: Godot.Node.EditorDescriptionChangedEventHandler) : void
            public add_EditorStateChanged ($value: System.Action) : void
            public remove_EditorStateChanged ($value: System.Action) : void
            public constructor ()
        }
        /**
        *  creates a different view into the screen, or a sub-view inside another viewport. Child 2D nodes will display on it, and child Camera3D 3D nodes will render on it too.
        * Optionally, a viewport can have its own 2D or 3D world, so it doesn't share what it draws with other viewports.
        * Viewports can also choose to be audio listeners, so they generate positional audio depending on a 2D or 3D camera child of it.
        * Also, viewports can be assigned to different screens in case the devices have multiple screens.
        * Finally, viewports can also behave as render targets, in which case they will not be visible unless the associated texture is used to draw.
        */
        class Viewport extends Godot.Node implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /** Disable 3D rendering (but keep 2D rendering).
            */
            public get Disable3D(): boolean;
            public set Disable3D(value: boolean);
            /** , the viewport will use the primary XR interface to render XR output. When applicable this can result in a stereoscopic image and the resulting render being output to a headset.
            */
            public get UseXR(): boolean;
            public set UseXR(value: boolean);
            /** .
            */
            public get OwnWorld3D(): boolean;
            public set OwnWorld3D(value: boolean);
            /**  which can be used as 3D environment source.
            */
            public get World3D(): Godot.World3D;
            public set World3D(value: Godot.World3D);
            /**  which can be used as 2D environment source.
            */
            public get World2D(): Godot.World2D;
            public set World2D(value: Godot.World2D);
            /** , the viewport should render its background as transparent.
            */
            public get TransparentBg(): boolean;
            public set TransparentBg(value: boolean);
            /**
            * , this is instead done by the first parent viewport that is set to handle input locally.
            *  contained inside of it.
            * .
            */
            public get HandleInputLocally(): boolean;
            public set HandleInputLocally(value: boolean);
            /**  smoothing is enabled.
            */
            public get Snap2DTransformsToPixel(): boolean;
            public set Snap2DTransformsToPixel(value: boolean);
            /**  smoothing is enabled.
            */
            public get Snap2DVerticesToPixel(): boolean;
            public set Snap2DVerticesToPixel(value: boolean);
            /**
            *  is best unless targeting very high-end systems. This has no effect on shader-induced aliasing or texture aliasing.
            * .
            */
            public get Msaa2D(): Godot.Viewport.Msaa;
            public set Msaa2D(value: Godot.Viewport.Msaa);
            /**
            *  for supersampling, which provides higher quality but is much more expensive. This has no effect on shader-induced aliasing or texture aliasing.
            * .
            */
            public get Msaa3D(): Godot.Viewport.Msaa;
            public set Msaa3D(value: Godot.Viewport.Msaa);
            /**
            * Sets the screen-space antialiasing method used. Screen-space antialiasing works by selectively blurring edges in a post-process shader. It differs from MSAA which takes multiple coverage samples while rendering objects. Screen-space AA methods are typically faster than MSAA and will smooth out specular aliasing, but tend to make scenes appear blurry.
            * .
            */
            public get ScreenSpaceAA(): Godot.Viewport.ScreenSpaceAAEnum;
            public set ScreenSpaceAA(value: Godot.Viewport.ScreenSpaceAAEnum);
            /**
            * Enables temporal antialiasing for this viewport. TAA works by jittering the camera and accumulating the images of the last rendered frames, motion vector rendering is used to account for camera and object motion.
            *  The implementation is not complete yet, some visual instances such as particles and skinned meshes may show artifacts.
            * .
            */
            public get UseTaa(): boolean;
            public set UseTaa(value: boolean);
            /**
            * .
            * In some cases, debanding may introduce a slightly noticeable dithering pattern. It's recommended to enable debanding only when actually needed since the dithering pattern will make lossless-compressed screenshots larger.
            * .
            */
            public get UseDebanding(): boolean;
            public set UseDebanding(value: boolean);
            /**
            *  instead.
            * ) compared to occlusion culling.
            * .
            */
            public get UseOcclusionCulling(): boolean;
            public set UseOcclusionCulling(value: boolean);
            /**
            *  to improve performance at the cost of geometry detail.
            *  project setting.
            *  visibility ranges (also known as "manual" LOD or hierarchical LOD).
            */
            public get MeshLodThreshold(): number;
            public set MeshLodThreshold(value: number);
            /** The overlay mode for test rendered geometry in debug purposes.
            */
            public get DebugDraw(): Godot.Viewport.DebugDrawEnum;
            public set DebugDraw(value: Godot.Viewport.DebugDrawEnum);
            /**
            *  range and can be used in 3D rendering without color space adjustments. This allows 2D rendering to take advantage of effects requiring high dynamic range (e.g. 2D glow) as well as substantially improves the appearance of effects requiring highly detailed gradients.
            *  This setting will have no effect when using the Compatibility renderer, which always renders in low dynamic range for performance reasons.
            */
            public get UseHdr2D(): boolean;
            public set UseHdr2D(value: boolean);
            /**
            * Sets scaling 3D mode. Bilinear scaling renders at different resolution to either undersample or supersample the viewport. FidelityFX Super Resolution 1.0, abbreviated to FSR, is an upscaling technology that produces high quality images at fast framerates by using a spatially aware upscaling algorithm. FSR is slightly more expensive than bilinear, but it produces significantly higher image quality. FSR should be used where possible.
            *  project setting.
            */
            public get Scaling3DMode(): Godot.Viewport.Scaling3DModeEnum;
            public set Scaling3DMode(value: Godot.Viewport.Scaling3DModeEnum);
            /**
            *  for multi-sample antialiasing, which is significantly cheaper but only smooths the edges of polygons.
            * When using FSR upscaling, AMD recommends exposing the following values as preset options to users "Ultra Quality: 0.77", "Quality: 0.67", "Balanced: 0.59", "Performance: 0.5" instead of exposing the entire scale.
            *  project setting.
            */
            public get Scaling3DScale(): number;
            public set Scaling3DScale(value: number);
            /**
            * Affects the final texture sharpness by reading from a lower or higher mipmap (also called "texture LOD bias"). Negative values make mipmapped textures sharper but grainier when viewed at a distance, while positive values make mipmapped textures blurrier (even when up close).
            *  is applied to this value.
            * .
            *  project setting.
            */
            public get TextureMipmapBias(): number;
            public set TextureMipmapBias(value: number);
            /**
            *  forcibly disables anisotropic filtering, even on materials where it is enabled.
            * .
            *  on materials.
            * ). However, anisotropic filtering is rarely useful in 2D, so only enable it for textures in 2D if it makes a meaningful visual difference.
            */
            public get AnisotropicFilteringLevel(): Godot.Viewport.AnisotropicFiltering;
            public set AnisotropicFilteringLevel(value: Godot.Viewport.AnisotropicFiltering);
            /**
            * Determines how sharp the upscaled image will be when using the FSR upscaling mode. Sharpness halves with every whole number. Values go from 0.0 (sharpest) to 2.0. Values above 2.0 won't make a visible difference.
            *  project setting.
            */
            public get FsrSharpness(): number;
            public set FsrSharpness(value: number);
            /** The Variable Rate Shading (VRS) mode that is used for this viewport. Note, if hardware does not support VRS this property is ignored.
            */
            public get VrsMode(): Godot.Viewport.VrsModeEnum;
            public set VrsMode(value: Godot.Viewport.VrsModeEnum);
            /** Sets the update mode for Variable Rate Shading (VRS) for the viewport. VRS requires the input texture to be converted to the format usable by the VRS method supported by the hardware. The update mode defines how often this happens. If the GPU does not support VRS, or VRS is not enabled, this property is ignored.
            */
            public get VrsUpdateMode(): Godot.Viewport.VrsUpdateModeEnum;
            public set VrsUpdateMode(value: Godot.Viewport.VrsUpdateModeEnum);
            /**
            * .
            *  use a lossless compression format so that colors can be matched precisely. The following VRS densities are mapped to various colors, with brighter colors representing a lower level of shading precision:
            * 
            - 1×1 = rgb(0, 0, 0)     - #000000
            - 1×2 = rgb(0, 85, 0)    - #005500
            - 2×1 = rgb(85, 0, 0)    - #550000
            - 2×2 = rgb(85, 85, 0)   - #555500
            - 2×4 = rgb(85, 170, 0)  - #55aa00
            - 4×2 = rgb(170, 85, 0)  - #aa5500
            - 4×4 = rgb(170, 170, 0) - #aaaa00
            - 4×8 = rgb(170, 255, 0) - #aaff00 - Not supported on most hardware
            - 8×4 = rgb(255, 170, 0) - #ffaa00 - Not supported on most hardware
            - 8×8 = rgb(255, 255, 0) - #ffff00 - Not supported on most hardware
            */
            public get VrsTexture(): Godot.Texture2D;
            public set VrsTexture(value: Godot.Texture2D);
            /** s in this Viewport.
            */
            public get CanvasItemDefaultTextureFilter(): Godot.Viewport.DefaultCanvasItemTextureFilter;
            public set CanvasItemDefaultTextureFilter(value: Godot.Viewport.DefaultCanvasItemTextureFilter);
            /** s in this Viewport.
            */
            public get CanvasItemDefaultTextureRepeat(): Godot.Viewport.DefaultCanvasItemTextureRepeat;
            public set CanvasItemDefaultTextureRepeat(value: Godot.Viewport.DefaultCanvasItemTextureRepeat);
            /** , the viewport will process 2D audio streams.
            */
            public get AudioListenerEnable2D(): boolean;
            public set AudioListenerEnable2D(value: boolean);
            /** , the viewport will process 3D audio streams.
            */
            public get AudioListenerEnable3D(): boolean;
            public set AudioListenerEnable3D(value: boolean);
            /**
            * , the objects rendered by viewport become subjects of mouse picking process.
            *  The number of simultaneously pickable objects is limited to 64 and they are selected in a non-deterministic order, which can be different in each picking process.
            */
            public get PhysicsObjectPicking(): boolean;
            public set PhysicsObjectPicking(value: boolean);
            /**
            * , the order is undetermined.
            *  This setting is disabled by default because of its potential expensive computational cost.
            *  receives the picking event.
            */
            public get PhysicsObjectPickingSort(): boolean;
            public set PhysicsObjectPickingSort(value: boolean);
            /**
            * .
            * , an input_event signal will be sent to all physics objects in the mouse picking process.
            * This applies to 2D CanvasItem object picking only.
            */
            public get PhysicsObjectPickingFirstOnly(): boolean;
            public set PhysicsObjectPickingFirstOnly(value: boolean);
            /** , the viewport will not receive input events.
            */
            public get GuiDisableInput(): boolean;
            public set GuiDisableInput(value: boolean);
            /** , the GUI controls on the viewport will lay pixel perfectly.
            */
            public get GuiSnapControlsToPixels(): boolean;
            public set GuiSnapControlsToPixels(value: boolean);
            /** , they will appear as separate windows handled by the operating system.
            */
            public get GuiEmbedSubwindows(): boolean;
            public set GuiEmbedSubwindows(value: boolean);
            /**
            * s as the occluders leave the viewport, increase this setting.
            * , the signed distance field will cover 20% of the viewport's size outside the viewport on each side (top, right, bottom, left).
            */
            public get SdfOversize(): Godot.Viewport.SdfOversizeEnum;
            public set SdfOversize(value: Godot.Viewport.SdfOversizeEnum);
            /** The resolution scale to use for the 2D signed distance field. Higher values lead to a more precise and more stable signed distance field as the camera moves, at the cost of performance.
            */
            public get SdfScale(): Godot.Viewport.SdfScaleEnum;
            public set SdfScale(value: Godot.Viewport.SdfScaleEnum);
            /**
            * The shadow atlas' resolution (used for omni and spot lights). The value is rounded up to the nearest power of 2.
            * , no positional shadows will be visible at all. This can improve performance significantly on low-end systems by reducing both the CPU and GPU load (as fewer draw calls are needed to draw the scene without shadows).
            */
            public get PositionalShadowAtlasSize(): number;
            public set PositionalShadowAtlasSize(value: number);
            /** Use 16 bits for the omni/spot shadow depth map. Enabling this results in shadows having less precision and may result in shadow acne, but can lead to performance improvements on some devices.
            */
            public get PositionalShadowAtlas16Bits(): boolean;
            public set PositionalShadowAtlas16Bits(value: boolean);
            /** The subdivision amount of the first quadrant on the shadow atlas.
            */
            public get PositionalShadowAtlasQuad0(): Godot.Viewport.PositionalShadowAtlasQuadrantSubdiv;
            public set PositionalShadowAtlasQuad0(value: Godot.Viewport.PositionalShadowAtlasQuadrantSubdiv);
            /** The subdivision amount of the second quadrant on the shadow atlas.
            */
            public get PositionalShadowAtlasQuad1(): Godot.Viewport.PositionalShadowAtlasQuadrantSubdiv;
            public set PositionalShadowAtlasQuad1(value: Godot.Viewport.PositionalShadowAtlasQuadrantSubdiv);
            /** The subdivision amount of the third quadrant on the shadow atlas.
            */
            public get PositionalShadowAtlasQuad2(): Godot.Viewport.PositionalShadowAtlasQuadrantSubdiv;
            public set PositionalShadowAtlasQuad2(value: Godot.Viewport.PositionalShadowAtlasQuadrantSubdiv);
            /** The subdivision amount of the fourth quadrant on the shadow atlas.
            */
            public get PositionalShadowAtlasQuad3(): Godot.Viewport.PositionalShadowAtlasQuadrantSubdiv;
            public set PositionalShadowAtlasQuad3(value: Godot.Viewport.PositionalShadowAtlasQuadrantSubdiv);
            /** s. This is relative to the global canvas transform of the viewport.
            */
            public get CanvasTransform(): Godot.Transform2D;
            public set CanvasTransform(value: Godot.Transform2D);
            /** The global canvas transform of the viewport. The canvas transform is relative to this.
            */
            public get GlobalCanvasTransform(): Godot.Transform2D;
            public set GlobalCanvasTransform(value: Godot.Transform2D);
            /**  nodes.
            */
            public get CanvasCullMask(): number;
            public set CanvasCullMask(value: number);
            /**  oversampling is enabled.
            */
            public get Oversampling(): boolean;
            public set Oversampling(value: boolean);
            /** If greater than zero, this value is used as the font oversampling factor, otherwise oversampling is equal to viewport scale.
            */
            public get OversamplingOverride(): number;
            public set OversamplingOverride(value: number);
            public SetWorld2D ($world2D: Godot.World2D) : void
            public GetWorld2D () : Godot.World2D
            /**  property of itself and any Viewport ancestor.
            */
            public FindWorld2D () : Godot.World2D
            public SetCanvasTransform ($xform: Godot.Transform2D) : void
            public GetCanvasTransform () : Godot.Transform2D
            public SetGlobalCanvasTransform ($xform: Godot.Transform2D) : void
            public GetGlobalCanvasTransform () : Godot.Transform2D
            /**
            *  to be pixel-perfect regardless of the automatically computed scale factor.
            * .
            */
            public GetStretchTransform () : Godot.Transform2D
            /** Returns the transform from the viewport's coordinate system to the embedder's coordinate system.
            */
            public GetFinalTransform () : Godot.Transform2D
            /** Returns the transform from the Viewport's coordinates to the screen coordinates of the containing window manager window.
            */
            public GetScreenTransform () : Godot.Transform2D
            /** Returns the visible rectangle in global screen coordinates.
            */
            public GetVisibleRect () : Godot.Rect2
            public SetTransparentBackground ($enable: boolean) : void
            public HasTransparentBackground () : boolean
            public SetUseHdr2D ($enable: boolean) : void
            public IsUsingHdr2D () : boolean
            public SetMsaa2D ($msaa: Godot.Viewport.Msaa) : void
            public GetMsaa2D () : Godot.Viewport.Msaa
            public SetMsaa3D ($msaa: Godot.Viewport.Msaa) : void
            public GetMsaa3D () : Godot.Viewport.Msaa
            public SetScreenSpaceAA ($screenSpaceAA: Godot.Viewport.ScreenSpaceAAEnum) : void
            public GetScreenSpaceAA () : Godot.Viewport.ScreenSpaceAAEnum
            public SetUseTaa ($enable: boolean) : void
            public IsUsingTaa () : boolean
            public SetUseDebanding ($enable: boolean) : void
            public IsUsingDebanding () : boolean
            public SetUseOcclusionCulling ($enable: boolean) : void
            public IsUsingOcclusionCulling () : boolean
            public SetDebugDraw ($debugDraw: Godot.Viewport.DebugDrawEnum) : void
            public GetDebugDraw () : Godot.Viewport.DebugDrawEnum
            public SetUseOversampling ($enable: boolean) : void
            public IsUsingOversampling () : boolean
            public SetOversamplingOverride ($oversampling: number) : void
            public GetOversamplingOverride () : number
            /** Returns viewport oversampling factor.
            */
            public GetOversampling () : number
            public GetRenderInfo ($type: Godot.Viewport.RenderInfoType, $info: Godot.Viewport.RenderInfo) : number
            /**
            * Returns the viewport's texture.
            *  signal.
            * 
            func _ready():
            await RenderingServer.frame_post_draw
            $Viewport.get_texture().get_image().save_png("user://Screenshot.png")
            *  the returned texture will be an HDR image encoded in linear space.
            */
            public GetTexture () : Godot.ViewportTexture
            public SetPhysicsObjectPicking ($enable: boolean) : void
            public GetPhysicsObjectPicking () : boolean
            public SetPhysicsObjectPickingSort ($enable: boolean) : void
            public GetPhysicsObjectPickingSort () : boolean
            public SetPhysicsObjectPickingFirstOnly ($enable: boolean) : void
            public GetPhysicsObjectPickingFirstOnly () : boolean
            /** .
            */
            public GetViewportRid () : Godot.Rid
            /** ).
            */
            public PushTextInput ($text: string) : void
            /**
            *  between viewports, or to locally apply inputs that were sent over the network or saved to a file.
            * , the event's position is in viewport coordinates.
            * .
            * Calling this method will propagate calls to child nodes for following methods in the given order:
            * - 
            *  nodes
            * - 
            * - 
            * - 
            * , any later method in this list will not be called.
            * , the event is used for physics object picking.
            */
            public PushInput ($event: Godot.InputEvent, $inLocalCoords?: boolean) : void
            /**
            * .
            *  that forwards input events.
            */
            public NotifyMouseEntered () : void
            /**
            * .
            *  that forwards input events.
            */
            public NotifyMouseExited () : void
            /** .
            */
            public GetMousePosition () : Godot.Vector2
            /**
            * .
            *  is only supported on Windows, macOS and Linux. It has no effect on Android, iOS and Web.
            */
            public WarpMouse ($position: Godot.Vector2) : void
            /**  counterparts.
            */
            public UpdateMouseCursorState () : void
            /** .
            */
            public GuiCancelDrag () : void
            /** .
            */
            public GuiGetDragData () : Godot.Variant
            /** Returns the drag data human-readable description.
            */
            public GuiGetDragDescription () : string
            /** Sets the drag data human-readable description.
            */
            public GuiSetDragDescription ($description: string) : void
            /**
            *  if a drag operation is currently ongoing and where the drop action could happen in this viewport.
            *  when you prefer polling the value.
            */
            public GuiIsDragging () : boolean
            /**  if the drag operation is successful.
            */
            public GuiIsDragSuccessful () : boolean
            /**  has the focus, does nothing.
            */
            public GuiReleaseFocus () : void
            /** .
            */
            public GuiGetFocusOwner () : Godot.Control
            /**
            * .
            *  to find if the mouse is within a control tree.
            */
            public GuiGetHoveredControl () : Godot.Control
            public SetDisableInput ($disable: boolean) : void
            public IsInputDisabled () : boolean
            public SetPositionalShadowAtlasSize ($size: number) : void
            public GetPositionalShadowAtlasSize () : number
            public SetPositionalShadowAtlas16Bits ($enable: boolean) : void
            public GetPositionalShadowAtlas16Bits () : boolean
            public SetSnapControlsToPixels ($enabled: boolean) : void
            public IsSnapControlsToPixelsEnabled () : boolean
            public SetSnap2DTransformsToPixel ($enabled: boolean) : void
            public IsSnap2DTransformsToPixelEnabled () : boolean
            public SetSnap2DVerticesToPixel ($enabled: boolean) : void
            public IsSnap2DVerticesToPixelEnabled () : boolean
            public SetPositionalShadowAtlasQuadrantSubdiv ($quadrant: number, $subdiv: Godot.Viewport.PositionalShadowAtlasQuadrantSubdiv) : void
            /** Returns the positional shadow atlas quadrant subdivision of the specified quadrant.
            */
            public GetPositionalShadowAtlasQuadrantSubdiv ($quadrant: number) : Godot.Viewport.PositionalShadowAtlasQuadrantSubdiv
            /**
            * .
            * , only the way events are propagated.
            */
            public SetInputAsHandled () : void
            /**
            * .
            *  or others, as well as in corresponding signal handlers.
            *  instead.
            */
            public IsInputHandled () : boolean
            public SetHandleInputLocally ($enable: boolean) : void
            public IsHandlingInputLocally () : boolean
            public SetDefaultCanvasItemTextureFilter ($mode: Godot.Viewport.DefaultCanvasItemTextureFilter) : void
            public GetDefaultCanvasItemTextureFilter () : Godot.Viewport.DefaultCanvasItemTextureFilter
            public SetEmbeddingSubwindows ($enable: boolean) : void
            public IsEmbeddingSubwindows () : boolean
            /**
            * s inside the viewport.
            * s inside other viewports will not be listed.
            */
            public GetEmbeddedSubwindows () : Godot.Collections.Array$1<Godot.Window>
            public SetCanvasCullMask ($mask: number) : void
            public GetCanvasCullMask () : number
            /** 's layers.
            */
            public SetCanvasCullMaskBit ($layer: number, $enable: boolean) : void
            /** Returns an individual bit on the rendering layer mask.
            */
            public GetCanvasCullMaskBit ($layer: number) : boolean
            public SetDefaultCanvasItemTextureRepeat ($mode: Godot.Viewport.DefaultCanvasItemTextureRepeat) : void
            public GetDefaultCanvasItemTextureRepeat () : Godot.Viewport.DefaultCanvasItemTextureRepeat
            public SetSdfOversize ($oversize: Godot.Viewport.SdfOversizeEnum) : void
            public GetSdfOversize () : Godot.Viewport.SdfOversizeEnum
            public SetSdfScale ($scale: Godot.Viewport.SdfScaleEnum) : void
            public GetSdfScale () : Godot.Viewport.SdfScaleEnum
            public SetMeshLodThreshold ($pixels: number) : void
            public GetMeshLodThreshold () : number
            public SetAsAudioListener2D ($enable: boolean) : void
            public IsAudioListener2D () : boolean
            /**  if there are no active 2D audio listeners, in which case the active 2D camera will be treated as listener.
            */
            public GetAudioListener2D () : Godot.AudioListener2D
            /**  if there are no active cameras.
            */
            public GetCamera2D () : Godot.Camera2D
            public SetWorld3D ($world3D: Godot.World3D) : void
            public GetWorld3D () : Godot.World3D
            /**  property of itself and any Viewport ancestor.
            */
            public FindWorld3D () : Godot.World3D
            public SetUseOwnWorld3D ($enable: boolean) : void
            public IsUsingOwnWorld3D () : boolean
            /**  if there are no active 3D audio listeners, in which case the active 3D camera will be treated as listener.
            */
            public GetAudioListener3D () : Godot.AudioListener3D
            /** Returns the currently active 3D camera.
            */
            public GetCamera3D () : Godot.Camera3D
            public SetAsAudioListener3D ($enable: boolean) : void
            public IsAudioListener3D () : boolean
            public SetDisable3D ($disable: boolean) : void
            public Is3DDisabled () : boolean
            public SetUseXR ($use: boolean) : void
            public IsUsingXR () : boolean
            public SetScaling3DMode ($scaling3DMode: Godot.Viewport.Scaling3DModeEnum) : void
            public GetScaling3DMode () : Godot.Viewport.Scaling3DModeEnum
            public SetScaling3DScale ($scale: number) : void
            public GetScaling3DScale () : number
            public SetFsrSharpness ($fsrSharpness: number) : void
            public GetFsrSharpness () : number
            public SetTextureMipmapBias ($textureMipmapBias: number) : void
            public GetTextureMipmapBias () : number
            public SetAnisotropicFilteringLevel ($anisotropicFilteringLevel: Godot.Viewport.AnisotropicFiltering) : void
            public GetAnisotropicFilteringLevel () : Godot.Viewport.AnisotropicFiltering
            public SetVrsMode ($mode: Godot.Viewport.VrsModeEnum) : void
            public GetVrsMode () : Godot.Viewport.VrsModeEnum
            public SetVrsUpdateMode ($mode: Godot.Viewport.VrsUpdateModeEnum) : void
            public GetVrsUpdateMode () : Godot.Viewport.VrsUpdateModeEnum
            public SetVrsTexture ($texture: Godot.Texture2D) : void
            public GetVrsTexture () : Godot.Texture2D
            public add_SizeChanged ($value: System.Action) : void
            public remove_SizeChanged ($value: System.Action) : void
            public add_GuiFocusChanged ($value: Godot.Viewport.GuiFocusChangedEventHandler) : void
            public remove_GuiFocusChanged ($value: Godot.Viewport.GuiFocusChangedEventHandler) : void
        }
        /** Class that has everything pertaining to a world: A physics space, a visual scenario, and a sound space. 3D nodes register their resources into the current 3D world.
        */
        class World3D extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /** Class that has everything pertaining to a 2D world: A physics space, a canvas, and a sound space. 2D nodes register their resources into the current 2D world.
        */
        class World2D extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /** .
        */
        class Texture extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            public constructor ()
        }
        /**
        * .
        * .
        *  is a base for other resources. It cannot be used directly.
        *  The maximum texture size is 16384×16384 pixels due to graphics hardware limitations. Larger textures may fail to import.
        */
        class Texture2D extends Godot.Texture implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /**
            *  specifies whether drawing should be performed in column-major order instead of row-major order (resulting in 90-degree clockwise rotation).
            *  This is only used in 2D rendering, not 3D.
            */
            public _Draw ($toCanvasItem: Godot.Rid, $pos: Godot.Vector2, $modulate: Godot.Color, $transpose: boolean) : void
            /**
            *  specifies whether drawing should be performed in column-major order instead of row-major order (resulting in 90-degree clockwise rotation).
            *  This is only used in 2D rendering, not 3D.
            */
            public _DrawRect ($toCanvasItem: Godot.Rid, $rect: Godot.Rect2, $tile: boolean, $modulate: Godot.Color, $transpose: boolean) : void
            /**
            *  specifies whether drawing should be performed in column-major order instead of row-major order (resulting in 90-degree clockwise rotation).
            *  This is only used in 2D rendering, not 3D.
            */
            public _DrawRectRegion ($toCanvasItem: Godot.Rid, $rect: Godot.Rect2, $srcRect: Godot.Rect2, $modulate: Godot.Color, $transpose: boolean, $clipUV: boolean) : void
            /** 's height is queried.
            */
            public _GetHeight () : number
            /** 's width is queried.
            */
            public _GetWidth () : number
            /**  is queried.
            */
            public _HasAlpha () : boolean
            /**  position.
            */
            public _IsPixelOpaque ($x: number, $y: number) : boolean
            /** Returns the texture width in pixels.
            */
            public GetWidth () : number
            /** Returns the texture height in pixels.
            */
            public GetHeight () : number
            /** Returns the texture size in pixels.
            */
            public GetSize () : Godot.Vector2
            /**  has an alpha channel.
            */
            public HasAlpha () : boolean
            public Draw ($canvasItem: Godot.Rid, $position: Godot.Vector2, $modulate?: Godot.Color | null, $transpose?: boolean) : void
            public DrawRect ($canvasItem: Godot.Rid, $rect: Godot.Rect2, $tile: boolean, $modulate?: Godot.Color | null, $transpose?: boolean) : void
            public DrawRectRegion ($canvasItem: Godot.Rid, $rect: Godot.Rect2, $srcRect: Godot.Rect2, $modulate?: Godot.Color | null, $transpose?: boolean, $clipUV?: boolean) : void
            /**
            * s can be accessed and manipulated directly.
            *  is invalid.
            *  every frame, especially on large textures.
            */
            public GetImage () : Godot.Image
            /** ).
            */
            public CreatePlaceholder () : Godot.Resource
            public constructor ()
        }
        /**
        * 2×3 matrix (2 rows, 3 columns) used for 2D linear transformations.
        * It can represent transformations such as translation, rotation, or scaling.
        * It consists of a three
        * values: x, y, and the origin.
        * For more information, read this documentation article:
        * https://docs.godotengine.org/en/latest/tutorials/math/matrices_and_transforms.html
        */
        class Transform2D extends System.ValueType implements System.IEquatable$1<Godot.Transform2D>
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * 2D axis-aligned bounding box. Rect2 consists of a position, a size, and
        * several utility functions. It is typically used for fast overlap tests.
        */
        class Rect2 extends System.ValueType implements System.IEquatable$1<Godot.Rect2>
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * .
        *  method on the target viewport.
        * ).
        *  may cause noticeable stutter.
        * , the returned texture will be an HDR image encoded in linear space. This may look darker than normal when displayed directly on screen. To convert to gamma space, you can do the following:
        * 
        img.convert(Image.FORMAT_RGBA8)
        imb.linear_to_srgb()
        * . This conversion is a slow operation, so it should not be performed every frame.
        */
        class ViewportTexture extends Godot.Texture2D implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * The RID type is used to access a low-level resource by its unique ID.
        * RIDs are opaque, which means they do not grant access to the resource
        * by themselves. They are used by the low-level server classes, such as
        * ,
        * ,
        * , etc.
        * A low-level resource may correspond to a high-level
        * ,
        * such as
        * or
        */
        class Rid extends System.ValueType implements System.IEquatable$1<Godot.Rid>
        {
            protected [__keep_incompatibility]: never;
        }
        /** .
        */
        class InputEvent extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /** Device ID used for emulated mouse input from a touchscreen, or for emulated touch input from a mouse. This can be used to distinguish emulated mouse input from physical mouse input, or emulated touch input from physical touch input.
            */
            public static DeviceIdEmulation : bigint
            /**
            * The event's device ID.
            * .
            */
            public get Device(): number;
            public set Device(value: number);
            public SetDevice ($device: number) : void
            public GetDevice () : number
            /**
            *  if this input event matches a pre-defined action of any type.
            *  events.
            */
            public IsAction ($action: Godot.StringName, $exactMatch?: boolean) : boolean
            /**
            * .
            *  events.
            *  in the documentation for more information.
            */
            public IsActionPressed ($action: Godot.StringName, $allowEcho?: boolean, $exactMatch?: boolean) : boolean
            /**
            * .
            *  events.
            */
            public IsActionReleased ($action: Godot.StringName, $exactMatch?: boolean) : boolean
            /**
            * .
            *  events.
            */
            public GetActionStrength ($action: Godot.StringName, $exactMatch?: boolean) : number
            /**  if this input event has been canceled.
            */
            public IsCanceled () : boolean
            /**
            * .
            *  in the documentation for more information.
            */
            public IsPressed () : boolean
            /** .
            */
            public IsReleased () : boolean
            /**
            * .
            *  The rate at which echo events are sent is typically around 20 events per second (after holding down the key for roughly half a second). However, the key repeat delay/speed can be changed by the user or disabled entirely in the operating system settings. To ensure your project works correctly on all configurations, do not assume the user has a specific key repeat configuration in your project's behavior.
            */
            public IsEcho () : boolean
            /**  representation of the event.
            */
            public AsText () : string
            /**
            * ) events.
            *  events.
            * .
            */
            public IsMatch ($event: Godot.InputEvent, $exactMatch?: boolean) : boolean
            /**  if this input event's type is one that can be assigned to an input action.
            */
            public IsActionType () : boolean
            /**
            * ).
            *  is a sum of both events. Both events' modifiers have to be identical.
            */
            public Accumulate ($withEvent: Godot.InputEvent) : boolean
            public XformedBy ($xform: Godot.Transform2D, $localOfs?: Godot.Vector2 | null) : Godot.InputEvent
        }
        /**
        *  for 2D game objects.
        *  signal.
        *  will be drawn behind everything. This behavior can be changed on a per-item basis.
        * ), change its Z-index, blend mode, and more.
        * .
        */
        class CanvasItem extends Godot.Node implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /**
            * .
            *  automatically enable this in order to function correctly.
            */
            public static NotificationTransformChanged : bigint
            /**
            * .
            *  automatically enable this in order to function correctly.
            */
            public static NotificationLocalTransformChanged : bigint
            /** ).
            */
            public static NotificationDraw : bigint
            /**
            * ).
            *  signal.
            */
            public static NotificationVisibilityChanged : bigint
            /**  has entered the canvas.
            */
            public static NotificationEnterCanvas : bigint
            /**  has exited the canvas.
            */
            public static NotificationExitCanvas : bigint
            /** ).
            */
            public static NotificationWorld2DChanged : bigint
            /**
            * .
            *  functions instead.
            */
            public get Visible(): boolean;
            public set Visible(value: boolean);
            /**  which only affects the node itself.
            */
            public get Modulate(): Godot.Color;
            public set Modulate(value: Godot.Color);
            /**
            *  which affects both the node itself and its children.
            * .
            */
            public get SelfModulate(): Godot.Color;
            public set SelfModulate(value: Godot.Color);
            /** , this node draws behind its parent.
            */
            public get ShowBehindParent(): boolean;
            public set ShowBehindParent(value: boolean);
            /** .
            */
            public get TopLevel(): boolean;
            public set TopLevel(value: boolean);
            /**
            * The mode in which this node clips its children, acting as a mask.
            *  to avoid unexpected behavior.
            */
            public get ClipChildren(): Godot.CanvasItem.ClipChildrenMode;
            public set ClipChildren(value: Godot.CanvasItem.ClipChildrenMode);
            /**  nodes.
            */
            public get LightMask(): number;
            public set LightMask(value: number);
            /** 's canvas cull mask.
            */
            public get VisibilityLayer(): number;
            public set VisibilityLayer(value: number);
            /**
            *  (inclusive).
            *  nodes.
            */
            public get ZIndex(): number;
            public set ZIndex(value: number);
            /**
            * , this node's final Z index is relative to its parent's Z index.
            * ).
            */
            public get ZAsRelative(): boolean;
            public set ZAsRelative(value: boolean);
            /**
            *  nodes are rendered normally in scene tree order.
            * With Y-sorting enabled on a parent node ('A') but disabled on a child node ('B'), the child node ('B') is sorted but its children ('C1', 'C2', etc.) render together on the same Y position as the child node ('B'). This allows you to organize the render order of a scene without changing the scene tree.
            * .
            */
            public get YSortEnabled(): boolean;
            public set YSortEnabled(value: boolean);
            /** 's texture(s).
            */
            public get TextureFilter(): Godot.CanvasItem.TextureFilterEnum;
            public set TextureFilter(value: Godot.CanvasItem.TextureFilterEnum);
            /**
            *  UV points outside the texture.
            * , as it uses its own texture repeating implementation.
            */
            public get TextureRepeat(): Godot.CanvasItem.TextureRepeatEnum;
            public set TextureRepeat(value: Godot.CanvasItem.TextureRepeatEnum);
            /** .
            */
            public get Material(): Godot.Material;
            public set Material(value: Godot.Material);
            /**  is used as this node's material.
            */
            public get UseParentMaterial(): boolean;
            public set UseParentMaterial(value: boolean);
            /**
            *  is called, either manually or by the engine).
            * .
            */
            public _Draw () : void
            /**  for this node.
            */
            public GetCanvasItem () : Godot.Rid
            public SetVisible ($visible: boolean) : void
            public IsVisible () : boolean
            /**
            * ).
            * ), it is assumed to be visible.
            * , the node might end up not being rendered.
            */
            public IsVisibleInTree () : boolean
            /**
            * .
            *  functions instead.
            */
            public Show () : void
            /** .
            */
            public Hide () : void
            /**  per frame, even if this method has been called multiple times.
            */
            public QueueRedraw () : void
            /** .
            */
            public MoveToFront () : void
            public SetAsTopLevel ($enable: boolean) : void
            public IsSetAsTopLevel () : boolean
            public SetLightMask ($lightMask: number) : void
            public GetLightMask () : number
            public SetModulate ($modulate: Godot.Color) : void
            public GetModulate () : Godot.Color
            public SetSelfModulate ($selfModulate: Godot.Color) : void
            public GetSelfModulate () : Godot.Color
            public SetZIndex ($zIndex: number) : void
            public GetZIndex () : number
            public SetZAsRelative ($enable: boolean) : void
            public IsZRelative () : boolean
            public SetYSortEnabled ($enabled: boolean) : void
            public IsYSortEnabled () : boolean
            public SetDrawBehindParent ($enable: boolean) : void
            public IsDrawBehindParentEnabled () : boolean
            /**
            * .
            * .
            */
            public DrawLine ($from: Godot.Vector2, $to: Godot.Vector2, $color: Godot.Color, $width?: number, $antialiased?: boolean) : void
            /**
            * .
            * .
            * .
            * , half transparent "feathers" will be attached to the boundary, making outlines smooth.
            * .
            */
            public DrawDashedLine ($from: Godot.Vector2, $to: Godot.Vector2, $color: Godot.Color, $width?: number, $dash?: number, $aligned?: boolean, $antialiased?: boolean) : void
            /**
            * .
            * .
            */
            public DrawPolyline ($points: System.Array$1<Godot.Vector2>, $color: Godot.Color, $width?: number, $antialiased?: boolean) : void
            /**
            * .
            * .
            */
            public DrawPolylineColors ($points: System.Array$1<Godot.Vector2>, $colors: System.Array$1<Godot.Color>, $width?: number, $antialiased?: boolean) : void
            /**
            * .
            * .
            *  radians, then a full circle arc is drawn (i.e. arc will not overlap itself).
            */
            public DrawArc ($center: Godot.Vector2, $radius: number, $startAngle: number, $endAngle: number, $pointCount: number, $color: Godot.Color, $width?: number, $antialiased?: boolean) : void
            /**
            *  instead.
            * .
            * .
            */
            public DrawMultiline ($points: System.Array$1<Godot.Vector2>, $color: Godot.Color, $width?: number, $antialiased?: boolean) : void
            /**
            *  instead.
            * .
            * .
            */
            public DrawMultilineColors ($points: System.Array$1<Godot.Vector2>, $colors: System.Array$1<Godot.Color>, $width?: number, $antialiased?: boolean) : void
            /**
            * .
            * .
            * , half transparent "feathers" will be attached to the boundary, making outlines smooth.
            * .
            * ).
            */
            public DrawRect ($rect: Godot.Rect2, $color: Godot.Color, $filled?: boolean, $width?: number, $antialiased?: boolean) : void
            /**
            * .
            *  specified.
            * .
            * , half transparent "feathers" will be attached to the boundary, making outlines smooth.
            * .
            */
            public DrawCircle ($position: Godot.Vector2, $radius: number, $color: Godot.Color, $filled?: boolean, $width?: number, $antialiased?: boolean) : void
            public DrawTexture ($texture: Godot.Texture2D, $position: Godot.Vector2, $modulate?: Godot.Color | null) : void
            public DrawTextureRect ($texture: Godot.Texture2D, $rect: Godot.Rect2, $tile: boolean, $modulate?: Godot.Color | null, $transpose?: boolean) : void
            public DrawTextureRectRegion ($texture: Godot.Texture2D, $rect: Godot.Rect2, $srcRect: Godot.Rect2, $modulate?: Godot.Color | null, $transpose?: boolean, $clipUV?: boolean) : void
            public DrawMsdfTextureRectRegion ($texture: Godot.Texture2D, $rect: Godot.Rect2, $srcRect: Godot.Rect2, $modulate?: Godot.Color | null, $outline?: number, $pixelRange?: number, $scale?: number) : void
            public DrawLcdTextureRectRegion ($texture: Godot.Texture2D, $rect: Godot.Rect2, $srcRect: Godot.Rect2, $modulate?: Godot.Color | null) : void
            /** Draws a styled rectangle.
            */
            public DrawStyleBox ($styleBox: Godot.StyleBox, $rect: Godot.Rect2) : void
            /** .
            */
            public DrawPrimitive ($points: System.Array$1<Godot.Vector2>, $colors: System.Array$1<Godot.Color>, $uvs: System.Array$1<Godot.Vector2>, $texture?: Godot.Texture2D) : void
            /**
            *  instead.
            * .
            * @param $uvs If the parameter is null, then the default value is Array.Empty<Vector2>().
            */
            public DrawPolygon ($points: System.Array$1<Godot.Vector2>, $colors: System.Array$1<Godot.Color>, $uvs?: System.Array$1<Godot.Vector2>, $texture?: Godot.Texture2D) : void
            /**
            * , a single color must be specified for the whole polygon.
            * .
            * @param $uvs If the parameter is null, then the default value is Array.Empty<Vector2>().
            */
            public DrawColoredPolygon ($points: System.Array$1<Godot.Vector2>, $color: Godot.Color, $uvs?: System.Array$1<Godot.Vector2>, $texture?: Godot.Texture2D) : void
            public DrawString ($font: Godot.Font, $pos: Godot.Vector2, $text: string, $alignment?: Godot.HorizontalAlignment, $width?: number, $fontSize?: number, $modulate?: Godot.Color | null, $justificationFlags?: Godot.TextServer.JustificationFlag, $direction?: Godot.TextServer.Direction, $orientation?: Godot.TextServer.Orientation, $oversampling?: number) : void
            public DrawMultilineString ($font: Godot.Font, $pos: Godot.Vector2, $text: string, $alignment?: Godot.HorizontalAlignment, $width?: number, $fontSize?: number, $maxLines?: number, $modulate?: Godot.Color | null, $brkFlags?: Godot.TextServer.LineBreakFlag, $justificationFlags?: Godot.TextServer.JustificationFlag, $direction?: Godot.TextServer.Direction, $orientation?: Godot.TextServer.Orientation, $oversampling?: number) : void
            public DrawStringOutline ($font: Godot.Font, $pos: Godot.Vector2, $text: string, $alignment?: Godot.HorizontalAlignment, $width?: number, $fontSize?: number, $size?: number, $modulate?: Godot.Color | null, $justificationFlags?: Godot.TextServer.JustificationFlag, $direction?: Godot.TextServer.Direction, $orientation?: Godot.TextServer.Orientation, $oversampling?: number) : void
            public DrawMultilineStringOutline ($font: Godot.Font, $pos: Godot.Vector2, $text: string, $alignment?: Godot.HorizontalAlignment, $width?: number, $fontSize?: number, $maxLines?: number, $size?: number, $modulate?: Godot.Color | null, $brkFlags?: Godot.TextServer.LineBreakFlag, $justificationFlags?: Godot.TextServer.JustificationFlag, $direction?: Godot.TextServer.Direction, $orientation?: Godot.TextServer.Orientation, $oversampling?: number) : void
            public DrawChar ($font: Godot.Font, $pos: Godot.Vector2, $char: string, $fontSize?: number, $modulate?: Godot.Color | null, $oversampling?: number) : void
            public DrawCharOutline ($font: Godot.Font, $pos: Godot.Vector2, $char: string, $fontSize?: number, $size?: number, $modulate?: Godot.Color | null, $oversampling?: number) : void
            public DrawMesh ($mesh: Godot.Mesh, $texture: Godot.Texture2D, $transform?: Godot.Transform2D | null, $modulate?: Godot.Color | null) : void
            /**  for related documentation.
            */
            public DrawMultimesh ($multimesh: Godot.MultiMesh, $texture: Godot.Texture2D) : void
            public DrawSetTransform ($position: Godot.Vector2, $rotation?: number, $scale?: Godot.Vector2 | null) : void
            /** Sets a custom transform for drawing via matrix. Anything drawn afterwards will be transformed by this.
            */
            public DrawSetTransformMatrix ($xform: Godot.Transform2D) : void
            /** Subsequent drawing commands will be ignored unless they fall within the specified animation slice. This is a faster way to implement animations that loop on background rather than redrawing constantly.
            */
            public DrawAnimationSlice ($animationLength: number, $sliceBegin: number, $sliceEnd: number, $offset?: number) : void
            /** , this function can be used to revert drawing to its default state (all subsequent drawing commands will be visible). If you don't care about this particular use case, usage of this function after submitting the slices is not required.
            */
            public DrawEndAnimation () : void
            /** .
            */
            public GetTransform () : Godot.Transform2D
            /**  enabled.
            */
            public GetGlobalTransform () : Godot.Transform2D
            /** s coordinate system.
            */
            public GetGlobalTransformWithCanvas () : Godot.Transform2D
            /** .
            */
            public GetViewportTransform () : Godot.Transform2D
            /** .
            */
            public GetViewportRect () : Godot.Rect2
            /** .
            */
            public GetCanvasTransform () : Godot.Transform2D
            /**
            *  in global screen coordinates (i.e. taking window position into account). Mostly useful for editor plugins.
            * ).
            */
            public GetScreenTransform () : Godot.Transform2D
            /** .
            */
            public GetLocalMousePosition () : Godot.Vector2
            /**
            *  that contains this node.
            * .
            */
            public GetGlobalMousePosition () : Godot.Vector2
            /** .
            */
            public GetCanvas () : Godot.Rid
            /** .
            */
            public GetCanvasLayerNode () : Godot.CanvasLayer
            /**
            *  this node is registered to.
            * ).
            */
            public GetWorld2D () : Godot.World2D
            public SetMaterial ($material: Godot.Material) : void
            public GetMaterial () : Godot.Material
            /**
            * .
            *  in the shader code.
            *  is case-sensitive and must match the name of the uniform in the code exactly (not the capitalized name in the inspector).
            */
            public SetInstanceShaderParameter ($name: Godot.StringName, $value: Godot.Variant) : void
            /** Get the value of a shader parameter as set on this instance.
            */
            public GetInstanceShaderParameter ($name: Godot.StringName) : Godot.Variant
            public SetUseParentMaterial ($enable: boolean) : void
            public GetUseParentMaterial () : boolean
            /**
            *  whenever its local transform changes.
            *  automatically enable this in order to function correctly.
            */
            public SetNotifyLocalTransform ($enable: boolean) : void
            /** .
            */
            public IsLocalTransformNotificationEnabled () : boolean
            /**
            *  whenever global transform changes.
            *  automatically enable this in order to function correctly.
            */
            public SetNotifyTransform ($enable: boolean) : void
            /** .
            */
            public IsTransformNotificationEnabled () : boolean
            /**
            * .
            *  children, as well. Therefore, use this method only when you need an up-to-date transform (such as during physics operations).
            */
            public ForceUpdateTransform () : void
            /**
            *  from the viewport's coordinates to this node's local coordinates.
            * .
            * 
            var viewport_point = get_global_transform_with_canvas() * local_point
            */
            public MakeCanvasPositionLocal ($viewportPoint: Godot.Vector2) : Godot.Vector2
            /**  unchanged.
            */
            public MakeInputLocal ($event: Godot.InputEvent) : Godot.InputEvent
            public SetVisibilityLayer ($layer: number) : void
            public GetVisibilityLayer () : number
            /** 's visibility layer.
            */
            public SetVisibilityLayerBit ($layer: number, $enabled: boolean) : void
            /** .
            */
            public GetVisibilityLayerBit ($layer: number) : boolean
            public SetTextureFilter ($mode: Godot.CanvasItem.TextureFilterEnum) : void
            public GetTextureFilter () : Godot.CanvasItem.TextureFilterEnum
            public SetTextureRepeat ($mode: Godot.CanvasItem.TextureRepeatEnum) : void
            public GetTextureRepeat () : Godot.CanvasItem.TextureRepeatEnum
            public SetClipChildrenMode ($mode: Godot.CanvasItem.ClipChildrenMode) : void
            public GetClipChildrenMode () : Godot.CanvasItem.ClipChildrenMode
            /**
            *  instead.
            * .
            * .
            */
            public DrawMultilineColors ($points: System.Array$1<Godot.Vector2>, $colors: System.Array$1<Godot.Color>, $width: number) : void
            /**
            *  instead.
            * .
            * .
            */
            public DrawMultiline ($points: System.Array$1<Godot.Vector2>, $color: Godot.Color, $width: number) : void
            /**
            * .
            * .
            * .
            * , half transparent "feathers" will be attached to the boundary, making outlines smooth.
            * .
            */
            public DrawDashedLine ($from: Godot.Vector2, $to: Godot.Vector2, $color: Godot.Color, $width: number, $dash: number, $aligned: boolean) : void
            /**
            * .
            * .
            * , half transparent "feathers" will be attached to the boundary, making outlines smooth.
            * .
            * ).
            */
            public DrawRect ($rect: Godot.Rect2, $color: Godot.Color, $filled: boolean, $width: number) : void
            /**
            * .
            *  specified.
            * .
            * , half transparent "feathers" will be attached to the boundary, making outlines smooth.
            * .
            */
            public DrawCircle ($position: Godot.Vector2, $radius: number, $color: Godot.Color) : void
            public DrawCharOutline ($font: Godot.Font, $pos: Godot.Vector2, $char: string, $fontSize: number, $size: number, $modulate: Godot.Color | null) : void
            public DrawChar ($font: Godot.Font, $pos: Godot.Vector2, $char: string, $fontSize: number, $modulate: Godot.Color | null) : void
            public DrawMultilineStringOutline ($font: Godot.Font, $pos: Godot.Vector2, $text: string, $alignment: Godot.HorizontalAlignment, $width: number, $fontSize: number, $maxLines: number, $size: number, $modulate: Godot.Color | null, $brkFlags: Godot.TextServer.LineBreakFlag, $justificationFlags: Godot.TextServer.JustificationFlag, $direction: Godot.TextServer.Direction, $orientation: Godot.TextServer.Orientation) : void
            public DrawStringOutline ($font: Godot.Font, $pos: Godot.Vector2, $text: string, $alignment: Godot.HorizontalAlignment, $width: number, $fontSize: number, $size: number, $modulate: Godot.Color | null, $justificationFlags: Godot.TextServer.JustificationFlag, $direction: Godot.TextServer.Direction, $orientation: Godot.TextServer.Orientation) : void
            public DrawMultilineString ($font: Godot.Font, $pos: Godot.Vector2, $text: string, $alignment: Godot.HorizontalAlignment, $width: number, $fontSize: number, $maxLines: number, $modulate: Godot.Color | null, $brkFlags: Godot.TextServer.LineBreakFlag, $justificationFlags: Godot.TextServer.JustificationFlag, $direction: Godot.TextServer.Direction, $orientation: Godot.TextServer.Orientation) : void
            public DrawString ($font: Godot.Font, $pos: Godot.Vector2, $text: string, $alignment: Godot.HorizontalAlignment, $width: number, $fontSize: number, $modulate: Godot.Color | null, $justificationFlags: Godot.TextServer.JustificationFlag, $direction: Godot.TextServer.Direction, $orientation: Godot.TextServer.Orientation) : void
            public add_Draw ($value: System.Action) : void
            public remove_Draw ($value: System.Action) : void
            public add_VisibilityChanged ($value: System.Action) : void
            public remove_VisibilityChanged ($value: System.Action) : void
            public add_Hidden ($value: System.Action) : void
            public remove_Hidden ($value: System.Action) : void
            public add_ItemRectChanged ($value: System.Action) : void
            public remove_ItemRectChanged ($value: System.Action) : void
        }
        /**
        *  features a bounding rectangle that defines its extents, an anchor position relative to its parent control or the current viewport, and offsets relative to the anchor. The offsets update automatically when the node, any of its parents, or the screen size change.
        *  nodes.
        *  properties.
        * User Interface nodes and input
        * , this already happens automatically for all UI elements in your game.
        * , focus, or if the event was inside of the control's bounding box.
        *  will not process it.
        *  nodes lose focus when another node grabs it, or if you hide the node in focus.
        *  node to ignore mouse or touch events. You'll need it if you place an icon on top of a button.
        * . You can also override theme items in the Inspector.
        *  methods provided by this class.
        */
        class Control extends Godot.CanvasItem implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * ).
        *  signal (this applies both to pressing the close button and clicking outside of a popup).
        */
        class Window extends Godot.Viewport implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * A 2D game object, with a transform (position, rotation, and scale). All 2D nodes, including physics objects and sprites, inherit from Node2D. Use Node2D as a parent node to move, scale and rotate children in a 2D project. Also gives control of the node's render order.
        *  properties.
        */
        class Node2D extends Godot.CanvasItem implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /** .
            */
            public get Position(): Godot.Vector2;
            public set Position(value: Godot.Vector2);
            /**
            * .
            * .
            */
            public get Rotation(): number;
            public set Rotation(value: number);
            /** .
            */
            public get RotationDegrees(): number;
            public set RotationDegrees(value: number);
            /**
            * .
            *  Negative X scales in 2D are not decomposable from the transformation matrix. Due to the way scale is represented with transformation matrices in Godot, negative scales on the X axis will be changed to negative scales on the Y axis and a rotation of 180 degrees when decomposed.
            */
            public get Scale(): Godot.Vector2;
            public set Scale(value: Godot.Vector2);
            /**
            * .
            *  rotation and scaling.
            * .
            */
            public get Skew(): number;
            public set Skew(value: number);
            /** .
            */
            public get Transform(): Godot.Transform2D;
            public set Transform(value: Godot.Transform2D);
            /** .
            */
            public get GlobalPosition(): Godot.Vector2;
            public set GlobalPosition(value: Godot.Vector2);
            /** .
            */
            public get GlobalRotation(): number;
            public set GlobalRotation(value: number);
            /** .
            */
            public get GlobalRotationDegrees(): number;
            public set GlobalRotationDegrees(value: number);
            /** .
            */
            public get GlobalScale(): Godot.Vector2;
            public set GlobalScale(value: Godot.Vector2);
            /** .
            */
            public get GlobalSkew(): number;
            public set GlobalSkew(value: number);
            /** .
            */
            public get GlobalTransform(): Godot.Transform2D;
            public set GlobalTransform(value: Godot.Transform2D);
            public SetPosition ($position: Godot.Vector2) : void
            public SetRotation ($radians: number) : void
            public SetRotationDegrees ($degrees: number) : void
            public SetSkew ($radians: number) : void
            public SetScale ($scale: Godot.Vector2) : void
            public GetPosition () : Godot.Vector2
            public GetRotation () : number
            public GetRotationDegrees () : number
            public GetSkew () : number
            public GetScale () : Godot.Vector2
            /** Applies a rotation to the node, in radians, starting from its current rotation.
            */
            public Rotate ($radians: number) : void
            /** , normalizes the movement.
            */
            public MoveLocalX ($delta: number, $scaled?: boolean) : void
            /** , normalizes the movement.
            */
            public MoveLocalY ($delta: number, $scaled?: boolean) : void
            /**  in local coordinates.
            */
            public Translate ($offset: Godot.Vector2) : void
            /**  vector to the node's global position.
            */
            public GlobalTranslate ($offset: Godot.Vector2) : void
            /**  vector.
            */
            public ApplyScale ($ratio: Godot.Vector2) : void
            public SetGlobalPosition ($position: Godot.Vector2) : void
            public GetGlobalPosition () : Godot.Vector2
            public SetGlobalRotation ($radians: number) : void
            public SetGlobalRotationDegrees ($degrees: number) : void
            public GetGlobalRotation () : number
            public GetGlobalRotationDegrees () : number
            public SetGlobalSkew ($radians: number) : void
            public GetGlobalSkew () : number
            public SetGlobalScale ($scale: Godot.Vector2) : void
            public GetGlobalScale () : Godot.Vector2
            public SetTransform ($xform: Godot.Transform2D) : void
            public SetGlobalTransform ($xform: Godot.Transform2D) : void
            /**
            * , which is expected to use global coordinates.
            *  should not be the same as the node's position, otherwise the node always looks to the right.
            */
            public LookAt ($point: Godot.Vector2) : void
            /**
            *  in radians.
            * Illustration of the returned angle.
            */
            public GetAngleTo ($point: Godot.Vector2) : number
            /**  it is called on. e.g. It is appropriate for determining the positions of child nodes, but it is not appropriate for determining its own position relative to its parent.
            */
            public ToLocal ($globalPoint: Godot.Vector2) : Godot.Vector2
            /**  it is called on. e.g. Applying this method to the positions of child nodes will correctly transform their positions into the global coordinate space, but applying it to a node's own position will give an incorrect result, as it will incorporate the node's own transformation into its global position.
            */
            public ToGlobal ($localPoint: Godot.Vector2) : Godot.Vector2
            /**  relative to this node's parent.
            */
            public GetRelativeTransformToParent ($parent: Godot.Node) : Godot.Transform2D
            public constructor ()
        }
        /**
        * .
        *  to function.
        */
        class AudioListener2D extends Godot.Node2D implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * -based nodes.
        *  node (when ascending the tree). Only one camera can be active per viewport. If no viewport is available ascending the tree, the camera will register in the global viewport.
        * ).
        *  to get the current rotation of the screen.
        */
        class Camera2D extends Godot.Node2D implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        *  node is the base representation of a node in 3D space. All other 3D nodes inherit from this class.
        * .
        * .
        * .
        */
        class Node3D extends Godot.Node implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /** .
        */
        class AudioListener3D extends Godot.Node3D implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**  (or higher viewports) can't be displayed.
        */
        class Camera3D extends Godot.Node3D implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * A pre-parsed relative or absolute path in a scene tree,
        * for use with
        * and similar functions.
        * It can reference a node, a resource within a node, or a property
        * of a node or resource.
        * For instance,
        * "Path2D/PathFollow2D/Sprite2D:texture:size"
        * would refer to the
        * size
        * property of the
        * texture
        * resource on the node named
        * "Sprite2D"
        * which is a child of
        * the other named nodes in the path.
        * You will usually just pass a string to
        * and it will be automatically converted, but you may occasionally
        * want to parse a path ahead of time with NodePath.
        * Exporting a NodePath variable will give you a node selection widget
        * in the properties panel of the editor, which can often be useful.
        * A NodePath is composed of a list of slash-separated node names
        * (like a filesystem path) and an optional colon-separated list of
        * "subnames" which can be resources or properties.
        * Note: In the editor, NodePath properties are automatically updated when moving,
        * renaming or deleting a node in the scene tree, but they are never updated at runtime.
        */
        class NodePath extends System.Object implements System.IDisposable, System.IEquatable$1<Godot.NodePath>
        {
            protected [__keep_incompatibility]: never;
            /**
            * Returns
            * if the node path is empty.
            * @returns If the  is empty.
            */
            public get IsEmpty(): boolean;
            /**
            * Disposes of this
            * .
            */
            public Dispose () : void
            public Dispose ($disposing: boolean) : void
            public static op_Implicit ($from: string) : Godot.NodePath
            public static op_Implicit ($from: Godot.NodePath) : string
            /**
            * Returns a node path with a colon character (
            * :
            * ) prepended,
            * transforming it to a pure property path with no node name (defaults
            * to resolving from the current node).
            * @returns The  as a pure property path.
            */
            public GetAsPropertyPath () : Godot.NodePath
            /**
            * Returns all names concatenated with a slash character (
            * /
            * ).
            * @returns The names concatenated with /.
            */
            public GetConcatenatedNames () : string
            /**
            * Returns all subnames concatenated with a colon character (
            * :
            * )
            * as separator, i.e. the right side of the first colon in a node path.
            * @returns The subnames concatenated with :.
            */
            public GetConcatenatedSubNames () : string
            /**
            * Gets the node name indicated by
            * (0 to
            * ).
            * @param $idx The name index.
            * @returns The name at the given index .
            */
            public GetName ($idx: number) : string
            /**
            * Gets the number of node names which make up the path.
            * Subnames (see
            * ) are not included.
            * For example,
            * "Path2D/PathFollow2D/Sprite2D"
            * has 3 names.
            * @returns The number of node names which make up the path.
            */
            public GetNameCount () : number
            /**
            * Gets the resource or property name indicated by
            * (0 to
            * ).
            * @param $idx The subname index.
            * @returns The subname at the given index .
            */
            public GetSubName ($idx: number) : string
            /**
            * Gets the number of resource or property names ("subnames") in the path.
            * Each subname is listed after a colon character (
            * :
            * ) in the node path.
            * For example,
            * "Path2D/PathFollow2D/Sprite2D:texture:load_path"
            * has 2 subnames.
            * @returns The number of subnames in the path.
            */
            public GetSubNameCount () : number
            /**
            * Returns
            * if the node path is absolute (as opposed to relative),
            * which means that it starts with a slash character (
            * /
            * ). Absolute node paths can
            * be used to access the root node (
            * "/root"
            * ) or autoloads (e.g.
            * "/global"
            * if a "global" autoload was registered).
            * @returns If the  is an absolute path.
            */
            public IsAbsolute () : boolean
            public static op_Equality ($left: Godot.NodePath, $right: Godot.NodePath) : boolean
            public static op_Inequality ($left: Godot.NodePath, $right: Godot.NodePath) : boolean
            public Equals ($other: Godot.NodePath) : boolean
            public Equals ($obj: any) : boolean
            public constructor ()
            public constructor ($path: string)
        }
        /**
        *  class.
        * .
        */
        class Input extends System.Object
        {
            protected [__keep_incompatibility]: never;
            /** Controls the mouse mode.
            */
            public static get MouseMode(): Godot.Input.MouseModeEnum;
            public static set MouseMode(value: Godot.Input.MouseModeEnum);
            /**
            * , similar input events sent by the operating system are accumulated. When input accumulation is enabled, all input events generated during a frame will be merged and emitted when the frame is done rendering. Therefore, this limits the number of input method calls per second to the rendering FPS.
            * Input accumulation can be disabled to get slightly more precise/reactive input at the cost of increased CPU usage. In applications where drawing freehand lines is required, input accumulation should generally be disabled while the user is drawing the line to get results that closely follow the actual input.
            *  by default.
            */
            public static get UseAccumulatedInput(): boolean;
            public static set UseAccumulatedInput(value: boolean);
            /** .
            */
            public static get EmulateMouseFromTouch(): boolean;
            public static set EmulateMouseFromTouch(value: boolean);
            /** .
            */
            public static get EmulateTouchFromMouse(): boolean;
            public static set EmulateTouchFromMouse(value: boolean);
            public static get Singleton(): Godot.InputInstance;
            /** .
            */
            public static IsAnythingPressed () : boolean
            /**
            *  constant.
            * .
            *  in the documentation for more information.
            */
            public static IsKeyPressed ($keycode: Godot.Key) : boolean
            /**
            *  constant.
            * .
            *  in the documentation for more information.
            */
            public static IsPhysicalKeyPressed ($keycode: Godot.Key) : boolean
            /**  constant or any Unicode character code.
            */
            public static IsKeyLabelPressed ($keycode: Godot.Key) : boolean
            /** .
            */
            public static IsMouseButtonPressed ($button: Godot.MouseButton) : boolean
            /** .
            */
            public static IsJoyButtonPressed ($device: number, $button: Godot.JoyButton) : boolean
            /**
            *  if you are pressing the action event.
            *  events.
            *  in the documentation for more information.
            */
            public static IsActionPressed ($action: Godot.StringName, $exactMatch?: boolean) : boolean
            /**
            *  on the frame or tick that the user pressed down the button.
            * This is useful for code that needs to run only once when an action is pressed, instead of every frame while it's pressed.
            *  events.
            *  will still be returned so as not to miss input.
            *  in the documentation for more information.
            *  instead to query the action state of the current event.
            */
            public static IsActionJustPressed ($action: Godot.StringName, $exactMatch?: boolean) : boolean
            /**
            *  on the frame or tick that the user releases the button.
            *  will still be returned so as not to miss input.
            *  events.
            *  instead to query the action state of the current event.
            */
            public static IsActionJustReleased ($action: Godot.StringName, $exactMatch?: boolean) : boolean
            /**
            * Returns a value between 0 and 1 representing the intensity of the given action. In a joypad, for example, the further away the axis (analog sticks or L2, R2 triggers) is from the dead zone, the closer the value will be to 1. If the action is mapped to a control that has no axis such as the keyboard, the value returned will be 0 or 1.
            *  events.
            */
            public static GetActionStrength ($action: Godot.StringName, $exactMatch?: boolean) : number
            /**
            *  instead.
            *  events.
            */
            public static GetActionRawStrength ($action: Godot.StringName, $exactMatch?: boolean) : number
            /**
            * Get axis input by specifying two actions, one negative and one positive.
            * .
            */
            public static GetAxis ($negativeAction: Godot.StringName, $positiveAction: Godot.StringName) : number
            /**
            * Gets an input vector by specifying four actions for the positive and negative X and Y axes.
            * This method is useful when getting vector input, such as from a joystick, directional pad, arrows, or WASD. The vector has its length limited to 1 and has a circular deadzone, which is useful for using vector input as movement.
            * By default, the deadzone is automatically calculated from the average of the action deadzones. However, you can override the deadzone to be whatever you want (on the range of 0 to 1).
            */
            public static GetVector ($negativeX: Godot.StringName, $positiveX: Godot.StringName, $negativeY: Godot.StringName, $positiveY: Godot.StringName, $deadzone?: number) : Godot.Vector2
            /** Adds a new mapping entry (in SDL2 format) to the mapping database. Optionally update already connected devices.
            */
            public static AddJoyMapping ($mapping: string, $updateExisting?: boolean) : void
            /**
            * Removes all mappings from the internal database that match the given GUID. All currently connected joypads that use this GUID will become unmapped.
            * On Android, Godot will map to an internal fallback mapping.
            */
            public static RemoveJoyMapping ($guid: string) : void
            /**  if the system knows the specified device. This means that it sets all button and axis indices. Unknown joypads are not expected to match these constants, but you can still retrieve events from them.
            */
            public static IsJoyKnown ($device: number) : boolean
            /** .
            */
            public static GetJoyAxis ($device: number, $axis: Godot.JoyAxis) : number
            /**  to determine gamepad names.
            */
            public static GetJoyName ($device: number) : string
            /**
            *  to determine gamepad names and mappings based on this GUID.
            * , because their mappings are the same.
            */
            public static GetJoyGuid ($device: number) : string
            /**
            * Returns a dictionary with extra platform-specific information about the device, e.g. the raw gamepad name from the OS or the Steam Input index.
            * On Windows, the dictionary contains the following fields:
            * : The index of the controller in the XInput system. Undefined for DirectInput devices.
            * : The USB vendor ID of the device.
            * : The USB product ID of the device.
            * On Linux:
            * : The name of the controller as it came from the OS, before getting renamed by the godot controller database.
            * : The USB vendor ID of the device.
            * : The USB product ID of the device.
            * : The Steam Input gamepad index, if the device is not a Steam Input device this key won't be present.
            *  The returned dictionary is always empty on Web, iOS, Android, and macOS.
            */
            public static GetJoyInfo ($device: number) : Godot.Collections.Dictionary
            /**
            *  for more information.
            *  creates virtual devices from physical devices for remapping purposes. To avoid handling the same input device twice, the original device is added to the ignore list.
            */
            public static ShouldIgnoreDevice ($vendorId: number, $productId: number) : boolean
            /**  containing the device IDs of all currently connected joypads.
            */
            public static GetConnectedJoypads () : Godot.Collections.Array$1<number>
            /** Returns the strength of the joypad vibration: x is the strength of the weak motor, and y is the strength of the strong motor.
            */
            public static GetJoyVibrationStrength ($device: number) : Godot.Vector2
            /** Returns the duration of the current vibration effect in seconds.
            */
            public static GetJoyVibrationDuration ($device: number) : number
            /**
            * .
            *  Not every hardware is compatible with long effect durations; it is recommended to restart an effect if it has to be played for more than a few seconds.
            *  For macOS, vibration is only supported in macOS 11 and later.
            */
            public static StartJoyVibration ($device: number, $weakMagnitude: number, $strongMagnitude: number, $duration?: number) : void
            /** .
            */
            public static StopJoyVibration ($device: number) : void
            /**
            * Vibrate the handheld device for the specified duration in milliseconds.
            * , the default vibration strength of the device is used.
            *  This method is implemented on Android, iOS, and Web. It has no effect on other platforms.
            *  will have no effect.
            *  For iOS, specifying the duration is only supported in iOS 13 and later.
            *  For Web, the amplitude cannot be changed.
            * .
            */
            public static VibrateHandheld ($durationMs?: number, $amplitude?: number) : void
            /**
            * .
            * .
            *  must be enabled.
            */
            public static GetGravity () : Godot.Vector3
            /**
            * .
            *  when running from the editor even when your device has an accelerometer. You must export your project to a supported device to read values from the accelerometer.
            * .
            *  must be enabled.
            */
            public static GetAccelerometer () : Godot.Vector3
            /**
            * .
            * .
            *  must be enabled.
            */
            public static GetMagnetometer () : Godot.Vector3
            /**
            * .
            * .
            *  must be enabled.
            */
            public static GetGyroscope () : Godot.Vector3
            /**
            * Sets the gravity value of the accelerometer sensor. Can be used for debugging on devices without a hardware sensor, for example in an editor on a PC.
            *  This value can be immediately overwritten by the hardware sensor value on Android and iOS.
            */
            public static SetGravity ($value: Godot.Vector3) : void
            /**
            * Sets the acceleration value of the accelerometer sensor. Can be used for debugging on devices without a hardware sensor, for example in an editor on a PC.
            *  This value can be immediately overwritten by the hardware sensor value on Android and iOS.
            */
            public static SetAccelerometer ($value: Godot.Vector3) : void
            /**
            * Sets the value of the magnetic field of the magnetometer sensor. Can be used for debugging on devices without a hardware sensor, for example in an editor on a PC.
            *  This value can be immediately overwritten by the hardware sensor value on Android and iOS.
            */
            public static SetMagnetometer ($value: Godot.Vector3) : void
            /**
            * Sets the value of the rotation rate of the gyroscope sensor. Can be used for debugging on devices without a hardware sensor, for example in an editor on a PC.
            *  This value can be immediately overwritten by the hardware sensor value on Android and iOS.
            */
            public static SetGyroscope ($value: Godot.Vector3) : void
            /** Returns the last mouse velocity. To provide a precise and jitter-free velocity, mouse velocity is only calculated every 0.1s. Therefore, mouse velocity will lag mouse movements.
            */
            public static GetLastMouseVelocity () : Godot.Vector2
            /** Returns the last mouse velocity in screen coordinates. To provide a precise and jitter-free velocity, mouse velocity is only calculated every 0.1s. Therefore, mouse velocity will lag mouse movements.
            */
            public static GetLastMouseScreenVelocity () : Godot.Vector2
            /** .
            */
            public static GetMouseButtonMask () : Godot.MouseButtonMask
            public static SetMouseMode ($mode: Godot.Input.MouseModeEnum) : void
            public static GetMouseMode () : Godot.Input.MouseModeEnum
            /**
            * Sets the mouse position to the specified vector, provided in pixels and relative to an origin at the upper left corner of the currently focused Window Manager game window.
            * .
            *  is only supported on Windows, macOS and Linux. It has no effect on Android, iOS and Web.
            */
            public static WarpMouse ($position: Godot.Vector2) : void
            /**
            * This will simulate pressing the specified action.
            * The strength can be used for non-boolean actions, it's ranged between 0 and 1 representing the intensity of the given action.
            *  instead.
            */
            public static ActionPress ($action: Godot.StringName, $strength?: number) : void
            /** If the specified action is already pressed, this will release it.
            */
            public static ActionRelease ($action: Godot.StringName) : void
            public static SetDefaultCursorShape ($shape?: Godot.Input.CursorShape) : void
            /** Returns the currently assigned cursor shape.
            */
            public static GetCurrentCursorShape () : Godot.Input.CursorShape
            public static SetCustomMouseCursor ($image: Godot.Resource, $shape?: Godot.Input.CursorShape, $hotspot?: Godot.Vector2 | null) : void
            /**
            *  calls.
            * 
            var cancelEvent = new InputEventAction();
            cancelEvent.Action = "ui_cancel";
            cancelEvent.Pressed = true;
            Input.ParseInputEvent(cancelEvent);
            *  won't toggle between active windows.
            */
            public static ParseInputEvent ($event: Godot.InputEvent) : void
            public static SetUseAccumulatedInput ($enable: boolean) : void
            public static IsUsingAccumulatedInput () : boolean
            /**
            * ).
            * The engine will already do this itself at key execution points (at least once per frame). However, this can be useful in advanced cases where you want precise control over the timing of event handling.
            */
            public static FlushBufferedEvents () : void
            public static SetEmulateMouseFromTouch ($enable: boolean) : void
            public static IsEmulatingMouseFromTouch () : boolean
            public static SetEmulateTouchFromMouse ($enable: boolean) : void
            public static IsEmulatingTouchFromMouse () : boolean
            /**
            * Vibrate the handheld device for the specified duration in milliseconds.
            * , the default vibration strength of the device is used.
            *  This method is implemented on Android, iOS, and Web. It has no effect on other platforms.
            *  will have no effect.
            *  For iOS, specifying the duration is only supported in iOS 13 and later.
            *  For Web, the amplitude cannot be changed.
            * .
            */
            public static VibrateHandheld ($durationMs: number) : void
            public static add_JoyConnectionChanged ($value: Godot.Input.JoyConnectionChangedEventHandler) : void
            public static remove_JoyConnectionChanged ($value: Godot.Input.JoyConnectionChangedEventHandler) : void
        }
        /**
        *  class.
        * .
        */
        class InputInstance extends Godot.GodotObject implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        enum Key
        { None = 0, Special = 4194304, Escape = 4194305, Tab = 4194306, Backtab = 4194307, Backspace = 4194308, Enter = 4194309, KpEnter = 4194310, Insert = 4194311, Delete = 4194312, Pause = 4194313, Print = 4194314, Sysreq = 4194315, Clear = 4194316, Home = 4194317, End = 4194318, Left = 4194319, Up = 4194320, Right = 4194321, Down = 4194322, Pageup = 4194323, Pagedown = 4194324, Shift = 4194325, Ctrl = 4194326, Meta = 4194327, Alt = 4194328, Capslock = 4194329, Numlock = 4194330, Scrolllock = 4194331, F1 = 4194332, F2 = 4194333, F3 = 4194334, F4 = 4194335, F5 = 4194336, F6 = 4194337, F7 = 4194338, F8 = 4194339, F9 = 4194340, F10 = 4194341, F11 = 4194342, F12 = 4194343, F13 = 4194344, F14 = 4194345, F15 = 4194346, F16 = 4194347, F17 = 4194348, F18 = 4194349, F19 = 4194350, F20 = 4194351, F21 = 4194352, F22 = 4194353, F23 = 4194354, F24 = 4194355, F25 = 4194356, F26 = 4194357, F27 = 4194358, F28 = 4194359, F29 = 4194360, F30 = 4194361, F31 = 4194362, F32 = 4194363, F33 = 4194364, F34 = 4194365, F35 = 4194366, KpMultiply = 4194433, KpDivide = 4194434, KpSubtract = 4194435, KpPeriod = 4194436, KpAdd = 4194437, Kp0 = 4194438, Kp1 = 4194439, Kp2 = 4194440, Kp3 = 4194441, Kp4 = 4194442, Kp5 = 4194443, Kp6 = 4194444, Kp7 = 4194445, Kp8 = 4194446, Kp9 = 4194447, Menu = 4194370, Hyper = 4194371, Help = 4194373, Back = 4194376, Forward = 4194377, Stop = 4194378, Refresh = 4194379, Volumedown = 4194380, Volumemute = 4194381, Volumeup = 4194382, Mediaplay = 4194388, Mediastop = 4194389, Mediaprevious = 4194390, Medianext = 4194391, Mediarecord = 4194392, Homepage = 4194393, Favorites = 4194394, Search = 4194395, Standby = 4194396, Openurl = 4194397, Launchmail = 4194398, Launchmedia = 4194399, Launch0 = 4194400, Launch1 = 4194401, Launch2 = 4194402, Launch3 = 4194403, Launch4 = 4194404, Launch5 = 4194405, Launch6 = 4194406, Launch7 = 4194407, Launch8 = 4194408, Launch9 = 4194409, Launcha = 4194410, Launchb = 4194411, Launchc = 4194412, Launchd = 4194413, Launche = 4194414, Launchf = 4194415, Globe = 4194416, Keyboard = 4194417, JisEisu = 4194418, JisKana = 4194419, Unknown = 8388607, Space = 32, Exclam = 33, Quotedbl = 34, Numbersign = 35, Dollar = 36, Percent = 37, Ampersand = 38, Apostrophe = 39, Parenleft = 40, Parenright = 41, Asterisk = 42, Plus = 43, Comma = 44, Minus = 45, Period = 46, Slash = 47, Key0 = 48, Key1 = 49, Key2 = 50, Key3 = 51, Key4 = 52, Key5 = 53, Key6 = 54, Key7 = 55, Key8 = 56, Key9 = 57, Colon = 58, Semicolon = 59, Less = 60, Equal = 61, Greater = 62, Question = 63, At = 64, A = 65, B = 66, C = 67, D = 68, E = 69, F = 70, G = 71, H = 72, I = 73, J = 74, K = 75, L = 76, M = 77, N = 78, O = 79, P = 80, Q = 81, R = 82, S = 83, T = 84, U = 85, V = 86, W = 87, X = 88, Y = 89, Z = 90, Bracketleft = 91, Backslash = 92, Bracketright = 93, Asciicircum = 94, Underscore = 95, Quoteleft = 96, Braceleft = 123, Bar = 124, Braceright = 125, Asciitilde = 126, Yen = 165, Section = 167 }
        enum MouseButton
        { None = 0, Left = 1, Right = 2, Middle = 3, WheelUp = 4, WheelDown = 5, WheelLeft = 6, WheelRight = 7, Xbutton1 = 8, Xbutton2 = 9 }
        enum JoyButton
        { Invalid = -1, A = 0, B = 1, X = 2, Y = 3, Back = 4, Guide = 5, Start = 6, LeftStick = 7, RightStick = 8, LeftShoulder = 9, RightShoulder = 10, DpadUp = 11, DpadDown = 12, DpadLeft = 13, DpadRight = 14, Misc1 = 15, Paddle1 = 16, Paddle2 = 17, Paddle3 = 18, Paddle4 = 19, Touchpad = 20, SdlMax = 21, Max = 128 }
        enum JoyAxis
        { Invalid = -1, LeftX = 0, LeftY = 1, RightX = 2, RightY = 3, TriggerLeft = 4, TriggerRight = 5, SdlMax = 6, Max = 10 }
        enum MouseButtonMask
        { Left = 1, Right = 2, Middle = 4, MbXbutton1 = 128, MbXbutton2 = 256 }
        /** InputEventFromWindow represents events specifically received by windows. This includes mouse events, keyboard events in focused windows or touch screen actions.
        */
        class InputEventFromWindow extends Godot.InputEvent implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * .
        *  if the key is pressed on its own.
        */
        class InputEventWithModifiers extends Godot.InputEventFromWindow implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /** Stores general information about mouse events.
        */
        class InputEventMouse extends Godot.InputEventWithModifiers implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /**  button masks.
            */
            public get ButtonMask(): Godot.MouseButtonMask;
            public set ButtonMask(value: Godot.MouseButtonMask);
            /**
            * .
            * .
            */
            public get Position(): Godot.Vector2;
            public set Position(value: Godot.Vector2);
            /**
            * .
            * .
            */
            public get GlobalPosition(): Godot.Vector2;
            public set GlobalPosition(value: Godot.Vector2);
            public SetButtonMask ($buttonMask: Godot.MouseButtonMask) : void
            public GetButtonMask () : Godot.MouseButtonMask
            public SetPosition ($position: Godot.Vector2) : void
            public GetPosition () : Godot.Vector2
            public SetGlobalPosition ($globalPosition: Godot.Vector2) : void
            public GetGlobalPosition () : Godot.Vector2
        }
        /**
        * .
        *  setting.
        */
        class InputEventMouseButton extends Godot.InputEventMouse implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /**  if not supported.
            */
            public get Factor(): number;
            public set Factor(value: number);
            /**  button or button wheel constants.
            */
            public get ButtonIndex(): Godot.MouseButton;
            public set ButtonIndex(value: Godot.MouseButton);
            /** , the mouse button event has been canceled.
            */
            public get Canceled(): boolean;
            public set Canceled(value: boolean);
            /** , the mouse button's state is released.
            */
            public get Pressed(): boolean;
            public set Pressed(value: boolean);
            /** , the mouse button's state is a double-click.
            */
            public get DoubleClick(): boolean;
            public set DoubleClick(value: boolean);
            public SetFactor ($factor: number) : void
            public GetFactor () : number
            public SetButtonIndex ($buttonIndex: Godot.MouseButton) : void
            public GetButtonIndex () : Godot.MouseButton
            public SetPressed ($pressed: boolean) : void
            public SetCanceled ($canceled: boolean) : void
            public SetDoubleClick ($doubleClick: boolean) : void
            public IsDoubleClick () : boolean
            public constructor ()
        }
        /**
        * .
        *  has a reference to an implementation of this class and uses it to provide multiplayer capabilities (i.e. RPCs) across the whole scene.
        *  method, effectively allowing to run both client and server in the same scene.
        *  for the details about the default implementation.
        */
        class MultiplayerApi extends Godot.RefCounted implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        *  subclass instead of the scene tree.
        *  project setting is overwritten.
        * :
        * 
        using Godot;
        [GlobalClass]
        public partial class CustomMainLoop : MainLoop
        {
        private double _timeElapsed = 0;
        public override void _Initialize()
        {
        GD.Print("Initialized:");
        GD.Print($"  Starting Time: {_timeElapsed}");
        }
        public override bool _Process(double delta)
        {
        _timeElapsed += delta;
        // Return true to end the main loop.
        return Input.GetMouseButtonMask() != 0 || Input.IsKeyPressed(Key.Escape);
        }
        private void _Finalize()
        {
        GD.Print("Finalized:");
        GD.Print($"  End Time: {_timeElapsed}");
        }
        }
        */
        class MainLoop extends Godot.GodotObject implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        *  manages the hierarchy of nodes in a scene, as well as scenes themselves. Nodes can be added, fetched and removed. The whole scene tree (and thus the current scene) can be paused. Scenes can be loaded, switched and reloaded.
        * : every node can be added to as many groups as you want to create, e.g. an "enemy" group. You can then iterate these groups or even call methods and set properties on all the nodes belonging to any given group.
        *  implementation used by the engine, and is thus in charge of the game loop.
        */
        class SceneTree extends Godot.MainLoop implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        *  is called tweening.
        *  with a delay.
        * ) are invalid and can't be used for tweening values.
        * :
        * 
        Tween tween = GetTree().CreateTween();
        tween.TweenProperty(GetNode("Sprite"), "modulate", Colors.Red, 1.0f);
        tween.TweenProperty(GetNode("Sprite"), "scale", Vector2.Zero, 1.0f);
        tween.TweenCallback(Callable.From(GetNode("Sprite").QueueFree));
        * .
        * :
        * 
        Tween tween = GetTree().CreateTween();
        tween.TweenProperty(GetNode("Sprite"), "modulate", Colors.Red, 1.0f).SetTrans(Tween.TransitionType.Sine);
        tween.TweenProperty(GetNode("Sprite"), "scale", Vector2.Zero, 1.0f).SetTrans(Tween.TransitionType.Bounce);
        tween.TweenCallback(Callable.From(GetNode("Sprite").QueueFree));
        * s:
        * 
        var tween = GetTree().CreateTween().BindNode(this).SetTrans(Tween.TransitionType.Elastic);
        tween.TweenProperty(GetNode("Sprite"), "modulate", Colors.Red, 1.0f);
        tween.TweenProperty(GetNode("Sprite"), "scale", Vector2.Zero, 1.0f);
        tween.TweenCallback(Callable.From(GetNode("Sprite").QueueFree));
        * s is animating arbitrary sets of objects:
        * 
        Tween tween = CreateTween();
        foreach (Node sprite in GetChildren())
        tween.TweenProperty(sprite, "position", Vector2.Zero, 1.0f);
        * .
        *  to a variable:
        * 
        private Tween _tween;
        public void Animate()
        {
        if (_tween != null)
        _tween.Kill(); // Abort the previous animation
        _tween = CreateTween();
        }
        * , and use the one that looks best.
        * Tween easing and transition types cheatsheet
        *  Tweens are not designed to be reused and trying to do so results in an undefined behavior. Create a new Tween for each animation and every time you replay an animation from start. Keep in mind that Tweens start immediately, so only create a Tween when you want to start animating.
        * ).
        */
        class Tween extends Godot.RefCounted implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        enum Error
        { Ok = 0, Failed = 1, Unavailable = 2, Unconfigured = 3, Unauthorized = 4, ParameterRangeError = 5, OutOfMemory = 6, FileNotFound = 7, FileBadDrive = 8, FileBadPath = 9, FileNoPermission = 10, FileAlreadyInUse = 11, FileCantOpen = 12, FileCantWrite = 13, FileCantRead = 14, FileUnrecognized = 15, FileCorrupt = 16, FileMissingDependencies = 17, FileEof = 18, CantOpen = 19, CantCreate = 20, QueryFailed = 21, AlreadyInUse = 22, Locked = 23, Timeout = 24, CantConnect = 25, CantResolve = 26, ConnectionError = 27, CantAcquireResource = 28, CantFork = 29, InvalidData = 30, InvalidParameter = 31, AlreadyExists = 32, DoesNotExist = 33, DatabaseCantRead = 34, DatabaseCantWrite = 35, CompilationFailed = 36, MethodNotFound = 37, LinkFailed = 38, ScriptFailed = 39, CyclicLink = 40, InvalidDeclaration = 41, DuplicateSymbol = 42, ParseError = 43, Busy = 44, Skip = 45, Help = 46, Bug = 47, PrinterOnFire = 48 }
        /**
        *  methods.
        * ) are supported. The behavior of collisions between objects in different canvases is undefined.
        */
        class CollisionObject2D extends Godot.Node2D implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /** .
            */
            public get DisableMode(): Godot.CollisionObject2D.DisableModeEnum;
            public set DisableMode(value: Godot.CollisionObject2D.DisableModeEnum);
            /**
            * .
            *  in the documentation for more information.
            */
            public get CollisionLayer(): number;
            public set CollisionLayer(value: number);
            /**
            * .
            *  in the documentation for more information.
            */
            public get CollisionMask(): number;
            public set CollisionMask(value: number);
            /** The priority used to solve colliding when occurring penetration. The higher the priority is, the lower the penetration into the object will be. This can for example be used to prevent the player from breaking through the boundaries of a level.
            */
            public get CollisionPriority(): number;
            public set CollisionPriority(value: number);
            /**  bit to be set.
            */
            public get InputPickable(): boolean;
            public set InputPickable(value: boolean);
            /**
            *  to easily pick up these events.
            *  bit to be set.
            */
            public _InputEvent ($viewport: Godot.Viewport, $event: Godot.InputEvent, $shapeIdx: number) : void
            /**  won't cause this function to be called.
            */
            public _MouseEnter () : void
            /**  won't cause this function to be called.
            */
            public _MouseExit () : void
            /**  bit to be called.
            */
            public _MouseShapeEnter ($shapeIdx: number) : void
            /**  bit to be called.
            */
            public _MouseShapeExit ($shapeIdx: number) : void
            /** .
            */
            public GetRid () : Godot.Rid
            public SetCollisionLayer ($layer: number) : void
            public GetCollisionLayer () : number
            public SetCollisionMask ($mask: number) : void
            public GetCollisionMask () : number
            /**  between 1 and 32.
            */
            public SetCollisionLayerValue ($layerNumber: number, $value: boolean) : void
            /**  between 1 and 32.
            */
            public GetCollisionLayerValue ($layerNumber: number) : boolean
            /**  between 1 and 32.
            */
            public SetCollisionMaskValue ($layerNumber: number, $value: boolean) : void
            /**  between 1 and 32.
            */
            public GetCollisionMaskValue ($layerNumber: number) : boolean
            public SetCollisionPriority ($priority: number) : void
            public GetCollisionPriority () : number
            public SetDisableMode ($mode: Godot.CollisionObject2D.DisableModeEnum) : void
            public GetDisableMode () : Godot.CollisionObject2D.DisableModeEnum
            public SetPickable ($enabled: boolean) : void
            public IsPickable () : boolean
            /**  of the new owner for future reference.
            */
            public CreateShapeOwner ($owner: Godot.GodotObject) : number
            /** Removes the given shape owner.
            */
            public RemoveShapeOwner ($ownerId: number) : void
            /**  as an argument.
            */
            public GetShapeOwners () : System.Array$1<number>
            /**  of the given shape owner.
            */
            public ShapeOwnerSetTransform ($ownerId: number, $transform: Godot.Transform2D) : void
            /** .
            */
            public ShapeOwnerGetTransform ($ownerId: number) : Godot.Transform2D
            /** Returns the parent object of the given shape owner.
            */
            public ShapeOwnerGetOwner ($ownerId: number) : Godot.GodotObject
            /** , disables the given shape owner.
            */
            public ShapeOwnerSetDisabled ($ownerId: number, $disabled: boolean) : void
            /** , the shape owner and its shapes are disabled.
            */
            public IsShapeOwnerDisabled ($ownerId: number) : boolean
            /** s.
            */
            public ShapeOwnerSetOneWayCollision ($ownerId: number, $enable: boolean) : void
            /** s.
            */
            public IsShapeOwnerOneWayCollisionEnabled ($ownerId: number) : boolean
            /**  pixels.
            */
            public ShapeOwnerSetOneWayCollisionMargin ($ownerId: number, $margin: number) : void
            /** .
            */
            public GetShapeOwnerOneWayCollisionMargin ($ownerId: number) : number
            /**  to the shape owner.
            */
            public ShapeOwnerAddShape ($ownerId: number, $shape: Godot.Shape2D) : void
            /** Returns the number of shapes the given shape owner contains.
            */
            public ShapeOwnerGetShapeCount ($ownerId: number) : number
            /**  with the given ID from the given shape owner.
            */
            public ShapeOwnerGetShape ($ownerId: number, $shapeId: number) : Godot.Shape2D
            /**  with the given ID from the given shape owner.
            */
            public ShapeOwnerGetShapeIndex ($ownerId: number, $shapeId: number) : number
            /** Removes a shape from the given shape owner.
            */
            public ShapeOwnerRemoveShape ($ownerId: number, $shapeId: number) : void
            /** Removes all shapes from the shape owner.
            */
            public ShapeOwnerClearShapes ($ownerId: number) : void
            /**  of the given shape.
            */
            public ShapeFindOwner ($shapeIndex: number) : number
            public add_InputEvent ($value: Godot.CollisionObject2D.InputEventEventHandler) : void
            public remove_InputEvent ($value: Godot.CollisionObject2D.InputEventEventHandler) : void
            public add_MouseEntered ($value: System.Action) : void
            public remove_MouseEntered ($value: System.Action) : void
            public add_MouseExited ($value: System.Action) : void
            public remove_MouseExited ($value: System.Action) : void
            public add_MouseShapeEntered ($value: Godot.CollisionObject2D.MouseShapeEnteredEventHandler) : void
            public remove_MouseShapeEntered ($value: Godot.CollisionObject2D.MouseShapeEnteredEventHandler) : void
            public add_MouseShapeExited ($value: Godot.CollisionObject2D.MouseShapeExitedEventHandler) : void
            public remove_MouseShapeExited ($value: Godot.CollisionObject2D.MouseShapeExitedEventHandler) : void
        }
        /**
        * s enter or exit it, and it also keeps track of which collision objects haven't exited it yet (i.e. which one are overlapping it).
        * This node can also locally alter or override physics parameters (gravity, damping) and route audio to custom audio buses.
        * s, and might not emit signals or track objects correctly.
        */
        class Area2D extends Godot.CollisionObject2D implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /** , the area detects bodies or areas entering and exiting it.
            */
            public get Monitoring(): boolean;
            public set Monitoring(value: boolean);
            /** , other monitoring areas can detect this area.
            */
            public get Monitorable(): boolean;
            public set Monitorable(value: boolean);
            /** 's physics is always processed last, after all areas.
            */
            public get Priority(): number;
            public set Priority(value: number);
            /** Override mode for gravity calculations within this area.
            */
            public get GravitySpaceOverride(): Godot.Area2D.SpaceOverride;
            public set GravitySpaceOverride(value: Godot.Area2D.SpaceOverride);
            /** .
            */
            public get GravityPoint(): boolean;
            public set GravityPoint(value: boolean);
            /**
            *  to 4.0 and the unit distance to 100.0. The gravity will have falloff according to the inverse square law, so in the example, at 200 pixels from the center the gravity will be 1.0 px/s² (twice the distance, 1/4th the gravity), at 50 pixels it will be 16.0 px/s² (half the distance, 4x the gravity), and so on.
            * The above is true only when the unit distance is a positive number. When this is set to 0.0, the gravity will be constant regardless of distance.
            */
            public get GravityPointUnitDistance(): number;
            public set GravityPointUnitDistance(value: number);
            /** ), this will be the point of attraction.
            */
            public get GravityPointCenter(): Godot.Vector2;
            public set GravityPointCenter(value: Godot.Vector2);
            /** The area's gravity vector (not normalized).
            */
            public get GravityDirection(): Godot.Vector2;
            public set GravityDirection(value: Godot.Vector2);
            /** The area's gravity intensity (in pixels per second squared). This value multiplies the gravity direction. This is useful to alter the force of gravity without altering its direction.
            */
            public get Gravity(): number;
            public set Gravity(value: number);
            /** Override mode for linear damping calculations within this area.
            */
            public get LinearDampSpaceOverride(): Godot.Area2D.SpaceOverride;
            public set LinearDampSpaceOverride(value: Godot.Area2D.SpaceOverride);
            /**
            * The rate at which objects stop moving in this area. Represents the linear velocity lost per second.
            *  for more details about damping.
            */
            public get LinearDamp(): number;
            public set LinearDamp(value: number);
            /** Override mode for angular damping calculations within this area.
            */
            public get AngularDampSpaceOverride(): Godot.Area2D.SpaceOverride;
            public set AngularDampSpaceOverride(value: Godot.Area2D.SpaceOverride);
            /**
            * The rate at which objects stop spinning in this area. Represents the angular velocity lost per second.
            *  for more details about damping.
            */
            public get AngularDamp(): number;
            public set AngularDamp(value: number);
            /** , the area's audio bus overrides the default audio bus.
            */
            public get AudioBusOverride(): boolean;
            public set AudioBusOverride(value: boolean);
            /** The name of the area's audio bus.
            */
            public get AudioBusName(): Godot.StringName;
            public set AudioBusName(value: Godot.StringName);
            public SetGravitySpaceOverrideMode ($spaceOverrideMode: Godot.Area2D.SpaceOverride) : void
            public GetGravitySpaceOverrideMode () : Godot.Area2D.SpaceOverride
            public SetGravityIsPoint ($enable: boolean) : void
            public IsGravityAPoint () : boolean
            public SetGravityPointUnitDistance ($distanceScale: number) : void
            public GetGravityPointUnitDistance () : number
            public SetGravityPointCenter ($center: Godot.Vector2) : void
            public GetGravityPointCenter () : Godot.Vector2
            public SetGravityDirection ($direction: Godot.Vector2) : void
            public GetGravityDirection () : Godot.Vector2
            public SetGravity ($gravity: number) : void
            public GetGravity () : number
            public SetLinearDampSpaceOverrideMode ($spaceOverrideMode: Godot.Area2D.SpaceOverride) : void
            public GetLinearDampSpaceOverrideMode () : Godot.Area2D.SpaceOverride
            public SetAngularDampSpaceOverrideMode ($spaceOverrideMode: Godot.Area2D.SpaceOverride) : void
            public GetAngularDampSpaceOverrideMode () : Godot.Area2D.SpaceOverride
            public SetLinearDamp ($linearDamp: number) : void
            public GetLinearDamp () : number
            public SetAngularDamp ($angularDamp: number) : void
            public GetAngularDamp () : number
            public SetPriority ($priority: number) : void
            public GetPriority () : number
            public SetMonitoring ($enable: boolean) : void
            public IsMonitoring () : boolean
            public SetMonitorable ($enable: boolean) : void
            public IsMonitorable () : boolean
            /**
            *  in order to be detected.
            * For performance reasons (collisions are all processed at the same time) this list is modified once during the physics step, not immediately after objects are moved. Consider using signals instead.
            */
            public GetOverlappingBodies () : Godot.Collections.Array$1<Godot.Node2D>
            /**
            *  in order to be detected.
            * For performance reasons (collisions are all processed at the same time) this list is modified once during the physics step, not immediately after objects are moved. Consider using signals instead.
            */
            public GetOverlappingAreas () : Godot.Collections.Array$1<Godot.Area2D>
            /**
            *  in order to be detected.
            * For performance reasons (collisions are all processed at the same time) the list of overlapping bodies is modified once during the physics step, not immediately after objects are moved. Consider using signals instead.
            */
            public HasOverlappingBodies () : boolean
            /**
            *  in order to be detected.
            * For performance reasons (collisions are all processed at the same time) the list of overlapping areas is modified once during the physics step, not immediately after objects are moved. Consider using signals instead.
            */
            public HasOverlappingAreas () : boolean
            /**
            *  otherwise.
            *  The result of this test is not immediate after moving objects. For performance, list of overlaps is updated once per frame and before the physics step. Consider using signals instead.
            *  instance. While TileMaps are not physics bodies themselves, they register their tiles with collision shapes as a virtual physics body.
            */
            public OverlapsBody ($body: Godot.Node) : boolean
            /**
            *  otherwise.
            *  The result of this test is not immediate after moving objects. For performance, the list of overlaps is updated once per frame and before the physics step. Consider using signals instead.
            */
            public OverlapsArea ($area: Godot.Node) : boolean
            public SetAudioBusName ($name: Godot.StringName) : void
            public GetAudioBusName () : Godot.StringName
            public SetAudioBusOverride ($enable: boolean) : void
            public IsOverridingAudioBus () : boolean
            public add_BodyShapeEntered ($value: Godot.Area2D.BodyShapeEnteredEventHandler) : void
            public remove_BodyShapeEntered ($value: Godot.Area2D.BodyShapeEnteredEventHandler) : void
            public add_BodyShapeExited ($value: Godot.Area2D.BodyShapeExitedEventHandler) : void
            public remove_BodyShapeExited ($value: Godot.Area2D.BodyShapeExitedEventHandler) : void
            public add_BodyEntered ($value: Godot.Area2D.BodyEnteredEventHandler) : void
            public remove_BodyEntered ($value: Godot.Area2D.BodyEnteredEventHandler) : void
            public add_BodyExited ($value: Godot.Area2D.BodyExitedEventHandler) : void
            public remove_BodyExited ($value: Godot.Area2D.BodyExitedEventHandler) : void
            public add_AreaShapeEntered ($value: Godot.Area2D.AreaShapeEnteredEventHandler) : void
            public remove_AreaShapeEntered ($value: Godot.Area2D.AreaShapeEnteredEventHandler) : void
            public add_AreaShapeExited ($value: Godot.Area2D.AreaShapeExitedEventHandler) : void
            public remove_AreaShapeExited ($value: Godot.Area2D.AreaShapeExitedEventHandler) : void
            public add_AreaEntered ($value: Godot.Area2D.AreaEnteredEventHandler) : void
            public remove_AreaEntered ($value: Godot.Area2D.AreaEnteredEventHandler) : void
            public add_AreaExited ($value: Godot.Area2D.AreaExitedEventHandler) : void
            public remove_AreaExited ($value: Godot.Area2D.AreaExitedEventHandler) : void
            public constructor ()
        }
        /** A node that displays a 2D texture. The texture displayed can be a region from a larger atlas texture, or a frame from a sprite sheet animation.
        */
        class Sprite2D extends Godot.Node2D implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /**  object to draw.
            */
            public get Texture(): Godot.Texture2D;
            public set Texture(value: Godot.Texture2D);
            /**
            * , texture is centered.
            * .
            */
            public get Centered(): boolean;
            public set Centered(value: boolean);
            /**
            * The texture's drawing offset.
            * .y in Sprite2D, the sprite moves downward on screen (i.e., +Y is down).
            */
            public get Offset(): Godot.Vector2;
            public set Offset(value: Godot.Vector2);
            /** , texture is flipped horizontally.
            */
            public get FlipH(): boolean;
            public set FlipH(value: boolean);
            /** , texture is flipped vertically.
            */
            public get FlipV(): boolean;
            public set FlipV(value: boolean);
            /** .
            */
            public get Hframes(): number;
            public set Hframes(value: number);
            /** .
            */
            public get Vframes(): number;
            public set Vframes(value: number);
            /** .
            */
            public get Frame(): number;
            public set Frame(value: number);
            /**  must be greater than 1.
            */
            public get FrameCoords(): Godot.Vector2I;
            public set FrameCoords(value: Godot.Vector2I);
            /** .
            */
            public get RegionEnabled(): boolean;
            public set RegionEnabled(value: boolean);
            /** .
            */
            public get RegionRect(): Godot.Rect2;
            public set RegionRect(value: Godot.Rect2);
            /** .
            */
            public get RegionFilterClipEnabled(): boolean;
            public set RegionFilterClipEnabled(value: boolean);
            public SetTexture ($texture: Godot.Texture2D) : void
            public GetTexture () : Godot.Texture2D
            public SetCentered ($centered: boolean) : void
            public IsCentered () : boolean
            public SetOffset ($offset: Godot.Vector2) : void
            public GetOffset () : Godot.Vector2
            public SetFlipH ($flipH: boolean) : void
            public IsFlippedH () : boolean
            public SetFlipV ($flipV: boolean) : void
            public IsFlippedV () : boolean
            public SetRegionEnabled ($enabled: boolean) : void
            public IsRegionEnabled () : boolean
            /**
            *  in other case. The position is in local coordinates.
            *  or if the given position is invalid.
            */
            public IsPixelOpaque ($pos: Godot.Vector2) : boolean
            public SetRegionRect ($rect: Godot.Rect2) : void
            public GetRegionRect () : Godot.Rect2
            public SetRegionFilterClipEnabled ($enabled: boolean) : void
            public IsRegionFilterClipEnabled () : boolean
            public SetFrame ($frame: number) : void
            public GetFrame () : number
            public SetFrameCoords ($coords: Godot.Vector2I) : void
            public GetFrameCoords () : Godot.Vector2I
            public SetVframes ($vframes: number) : void
            public GetVframes () : number
            public SetHframes ($hframes: number) : void
            public GetHframes () : number
            /**
            *  representing the Sprite2D's boundary in local coordinates.
            *  Detect if the Sprite2D was clicked:
            * 
            public override void _Input(InputEvent @event)
            {
            if (@event is InputEventMouseButton inputEventMouse)
            {
            if (inputEventMouse.Pressed && inputEventMouse.ButtonIndex == MouseButton.Left)
            {
            if (GetRect().HasPoint(ToLocal(inputEventMouse.Position)))
            {
            GD.Print("A click!");
            }
            }
            }
            }
            */
            public GetRect () : Godot.Rect2
            public add_FrameChanged ($value: System.Action) : void
            public remove_FrameChanged ($value: System.Action) : void
            public add_TextureChanged ($value: System.Action) : void
            public remove_TextureChanged ($value: System.Action) : void
            public constructor ()
        }
        /**
        * Abstract base class for all 2D shapes, intended for use in physics.
        *  is the slowest.
        */
        class Shape2D extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * .
        *  first.
        *  The maximum image size is 16384×16384 pixels due to graphics hardware limitations. Larger images may fail to import.
        */
        class Image extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * . A few flags and parameters are shared between all material types and are configured here.
        *  to create your own custom material type in script or in GDExtension.
        */
        class Material extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        *  assigned as mask to a control, clicks and motion signals will go through it to the one below.
        *  more reusable across different nodes.
        */
        class StyleBox extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /** Abstract base class for different font types. It has methods for drawing text and font character introspection.
        */
        class Font extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        enum HorizontalAlignment
        { Left = 0, Center = 1, Right = 2, Fill = 3 }
        /** .
        */
        class Mesh extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        *  nodes can be slow, since each object is submitted to the GPU then drawn individually.
        * MultiMesh is much faster as it can draw thousands of instances with a single draw call, resulting in less API overhead.
        * As a drawback, if the instances are too far away from each other, performance may be reduced as every single instance will always render (they are spatially indexed as one, for the whole object).
        * Since instances may have any behavior, the AABB used for visibility must be provided by the user.
        *  receive any lighting.
        *  Blend Shapes will be ignored if used in a MultiMesh.
        */
        class MultiMesh extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        *  of the nodes within each layer.
        *  and lower).
        *  and higher appear in front of embedded windows.
        *  you want it to be drawn on.
        */
        class CanvasLayer extends Godot.Node implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**  instead.
        */
        class Label extends Godot.Control implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
            /** The text to display on screen.
            */
            public get Text(): string;
            public set Text(value: string);
            /**  nodes. Takes priority over theme properties.
            */
            public get LabelSettings(): Godot.LabelSettings;
            public set LabelSettings(value: Godot.LabelSettings);
            /** Controls the text's horizontal alignment. Supports left, center, right, and fill (also known as justify).
            */
            public get HorizontalAlignment(): Godot.HorizontalAlignment;
            public set HorizontalAlignment(value: Godot.HorizontalAlignment);
            /** Controls the text's vertical alignment. Supports top, center, bottom, and fill.
            */
            public get VerticalAlignment(): Godot.VerticalAlignment;
            public set VerticalAlignment(value: Godot.VerticalAlignment);
            /** , the text gets wrapped inside the node's bounding rectangle. If you resize the node, it will change its height automatically to show all the text.
            */
            public get AutowrapMode(): Godot.TextServer.AutowrapMode;
            public set AutowrapMode(value: Godot.TextServer.AutowrapMode);
            /**  for more info.
            */
            public get AutowrapTrimFlags(): Godot.TextServer.LineBreakFlag;
            public set AutowrapTrimFlags(value: Godot.TextServer.LineBreakFlag);
            /** Line fill alignment rules.
            */
            public get JustificationFlags(): Godot.TextServer.JustificationFlag;
            public set JustificationFlags(value: Godot.TextServer.JustificationFlag);
            /** String used as a paragraph separator. Each paragraph is processed independently, in its own BiDi context.
            */
            public get ParagraphSeparator(): string;
            public set ParagraphSeparator(value: string);
            /** , the Label only shows the text that fits inside its bounding rectangle and will clip text horizontally.
            */
            public get ClipText(): boolean;
            public set ClipText(value: boolean);
            /** The clipping behavior when the text exceeds the node's bounding rectangle.
            */
            public get TextOverrunBehavior(): Godot.TextServer.OverrunBehavior;
            public set TextOverrunBehavior(value: Godot.TextServer.OverrunBehavior);
            /** Ellipsis character used for text clipping.
            */
            public get EllipsisChar(): string;
            public set EllipsisChar(value: string);
            /** , all the text displays as UPPERCASE.
            */
            public get Uppercase(): boolean;
            public set Uppercase(value: boolean);
            /** Aligns text to the given tab-stops.
            */
            public get TabStops(): System.Array$1<number>;
            public set TabStops(value: System.Array$1<number>);
            /**  value.
            */
            public get LinesSkipped(): number;
            public set LinesSkipped(value: number);
            /** Limits the lines of text the node shows on screen.
            */
            public get MaxLinesVisible(): number;
            public set MaxLinesVisible(value: number);
            /**
            * , all characters are displayed. This can be useful when animating the text appearing in a dialog box.
            *  accordingly.
            */
            public get VisibleCharacters(): number;
            public set VisibleCharacters(value: number);
            /**  is set.
            */
            public get VisibleCharactersBehavior(): Godot.TextServer.VisibleCharactersBehavior;
            public set VisibleCharactersBehavior(value: Godot.TextServer.VisibleCharactersBehavior);
            /**
            * , only half of the characters will be displayed. This can be useful when animating the text appearing in a dialog box.
            *  accordingly.
            */
            public get VisibleRatio(): number;
            public set VisibleRatio(value: number);
            /** Base text writing direction.
            */
            public get TextDirection(): Godot.Control.TextDirection;
            public set TextDirection(value: Godot.Control.TextDirection);
            /** Language code used for line-breaking and text shaping algorithms, if left empty current locale is used instead.
            */
            public get Language(): string;
            public set Language(value: string);
            /** Set BiDi algorithm override for the structured text.
            */
            public get StructuredTextBidiOverride(): Godot.TextServer.StructuredTextParser;
            public set StructuredTextBidiOverride(value: Godot.TextServer.StructuredTextParser);
            /** Set additional options for BiDi override.
            */
            public get StructuredTextBidiOverrideOptions(): Godot.Collections.Array;
            public set StructuredTextBidiOverrideOptions(value: Godot.Collections.Array);
            public SetHorizontalAlignment ($alignment: Godot.HorizontalAlignment) : void
            public GetHorizontalAlignment () : Godot.HorizontalAlignment
            public SetVerticalAlignment ($alignment: Godot.VerticalAlignment) : void
            public GetVerticalAlignment () : Godot.VerticalAlignment
            public SetText ($text: string) : void
            public GetText () : string
            public SetLabelSettings ($settings: Godot.LabelSettings) : void
            public GetLabelSettings () : Godot.LabelSettings
            public SetTextDirection ($direction: Godot.Control.TextDirection) : void
            public GetTextDirection () : Godot.Control.TextDirection
            public SetLanguage ($language: string) : void
            public GetLanguage () : string
            public SetParagraphSeparator ($paragraphSeparator: string) : void
            public GetParagraphSeparator () : string
            public SetAutowrapMode ($autowrapMode: Godot.TextServer.AutowrapMode) : void
            public GetAutowrapMode () : Godot.TextServer.AutowrapMode
            public SetAutowrapTrimFlags ($autowrapTrimFlags: Godot.TextServer.LineBreakFlag) : void
            public GetAutowrapTrimFlags () : Godot.TextServer.LineBreakFlag
            public SetJustificationFlags ($justificationFlags: Godot.TextServer.JustificationFlag) : void
            public GetJustificationFlags () : Godot.TextServer.JustificationFlag
            public SetClipText ($enable: boolean) : void
            public IsClippingText () : boolean
            public SetTabStops ($tabStops: System.Array$1<number>) : void
            public GetTabStops () : System.Array$1<number>
            public SetTextOverrunBehavior ($overrunBehavior: Godot.TextServer.OverrunBehavior) : void
            public GetTextOverrunBehavior () : Godot.TextServer.OverrunBehavior
            public SetEllipsisChar ($char: string) : void
            public GetEllipsisChar () : string
            public SetUppercase ($enable: boolean) : void
            public IsUppercase () : boolean
            /**
            * .
            * , returns the biggest line height.
            * If there are no lines, returns font size in pixels.
            */
            public GetLineHeight ($line?: number) : number
            /** Returns the number of lines of text the Label has.
            */
            public GetLineCount () : number
            /** 's height cannot currently display all lines.
            */
            public GetVisibleLineCount () : number
            /** Returns the total number of printable characters in the text (excluding spaces and newlines).
            */
            public GetTotalCharacterCount () : number
            public SetVisibleCharacters ($amount: number) : void
            public GetVisibleCharacters () : number
            public GetVisibleCharactersBehavior () : Godot.TextServer.VisibleCharactersBehavior
            public SetVisibleCharactersBehavior ($behavior: Godot.TextServer.VisibleCharactersBehavior) : void
            public SetVisibleRatio ($ratio: number) : void
            public GetVisibleRatio () : number
            public SetLinesSkipped ($linesSkipped: number) : void
            public GetLinesSkipped () : number
            public SetMaxLinesVisible ($linesVisible: number) : void
            public GetMaxLinesVisible () : number
            public SetStructuredTextBidiOverride ($parser: Godot.TextServer.StructuredTextParser) : void
            public GetStructuredTextBidiOverride () : Godot.TextServer.StructuredTextParser
            public SetStructuredTextBidiOverrideOptions ($args: Godot.Collections.Array) : void
            public GetStructuredTextBidiOverrideOptions () : Godot.Collections.Array
            /**  is returned. If the character is a part of a composite grapheme, the bounding rectangle of the whole grapheme is returned.
            */
            public GetCharacterBounds ($pos: number) : Godot.Rect2
            public constructor ()
        }
        /** . The resource can be shared between multiple labels and changed on the fly, so it's convenient and flexible way to setup text style.
        */
        class LabelSettings extends Godot.Resource implements System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        enum VerticalAlignment
        { Top = 0, Center = 1, Bottom = 2, Fill = 3 }
    }
    namespace System.Numerics {
        interface IBinaryInteger$1<TSelf> extends System.Numerics.IBinaryNumber$1<TSelf>, System.Numerics.IBitwiseOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumber$1<TSelf>, System.IComparable, System.IComparable$1<TSelf>, System.Numerics.IComparisonOperators$3<TSelf, TSelf, boolean>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IModulusOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>, System.Numerics.IShiftOperators$3<TSelf, number, TSelf>
        {
        }
        interface IBinaryNumber$1<TSelf> extends System.Numerics.IBitwiseOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumber$1<TSelf>, System.IComparable, System.IComparable$1<TSelf>, System.Numerics.IComparisonOperators$3<TSelf, TSelf, boolean>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IModulusOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface IBitwiseOperators$3<TSelf, TOther, TResult>
        {
        }
        interface INumber$1<TSelf> extends System.IComparable, System.IComparable$1<TSelf>, System.Numerics.IComparisonOperators$3<TSelf, TSelf, boolean>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IModulusOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface IComparisonOperators$3<TSelf, TOther, TResult> extends System.Numerics.IEqualityOperators$3<TSelf, TOther, TResult>
        {
        }
        interface IEqualityOperators$3<TSelf, TOther, TResult>
        {
        }
        interface IModulusOperators$3<TSelf, TOther, TResult>
        {
        }
        interface INumberBase$1<TSelf> extends System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface IAdditionOperators$3<TSelf, TOther, TResult>
        {
        }
        interface IAdditiveIdentity$2<TSelf, TResult>
        {
        }
        interface IDecrementOperators$1<TSelf>
        {
        }
        interface IDivisionOperators$3<TSelf, TOther, TResult>
        {
        }
        interface IIncrementOperators$1<TSelf>
        {
        }
        interface IMultiplicativeIdentity$2<TSelf, TResult>
        {
        }
        interface IMultiplyOperators$3<TSelf, TOther, TResult>
        {
        }
        interface ISubtractionOperators$3<TSelf, TOther, TResult>
        {
        }
        interface IUnaryPlusOperators$2<TSelf, TResult>
        {
        }
        interface IUnaryNegationOperators$2<TSelf, TResult>
        {
        }
        interface IShiftOperators$3<TSelf, TOther, TResult>
        {
        }
        interface IMinMaxValue$1<TSelf>
        {
        }
        interface ISignedNumber$1<TSelf> extends System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface IUnsignedNumber$1<TSelf> extends System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface IBinaryFloatingPointIeee754$1<TSelf> extends System.Numerics.IBinaryNumber$1<TSelf>, System.Numerics.IBitwiseOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumber$1<TSelf>, System.IComparable, System.IComparable$1<TSelf>, System.Numerics.IComparisonOperators$3<TSelf, TSelf, boolean>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IModulusOperators$3<TSelf, TSelf, TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>, System.Numerics.IFloatingPointIeee754$1<TSelf>, System.Numerics.IExponentialFunctions$1<TSelf>, System.Numerics.IFloatingPointConstants$1<TSelf>, System.Numerics.IFloatingPoint$1<TSelf>, System.Numerics.ISignedNumber$1<TSelf>, System.Numerics.IHyperbolicFunctions$1<TSelf>, System.Numerics.ILogarithmicFunctions$1<TSelf>, System.Numerics.IPowerFunctions$1<TSelf>, System.Numerics.IRootFunctions$1<TSelf>, System.Numerics.ITrigonometricFunctions$1<TSelf>
        {
        }
        interface IFloatingPointIeee754$1<TSelf> extends System.Numerics.IExponentialFunctions$1<TSelf>, System.Numerics.IFloatingPointConstants$1<TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>, System.Numerics.IFloatingPoint$1<TSelf>, System.Numerics.INumber$1<TSelf>, System.IComparable, System.IComparable$1<TSelf>, System.Numerics.IComparisonOperators$3<TSelf, TSelf, boolean>, System.Numerics.IModulusOperators$3<TSelf, TSelf, TSelf>, System.Numerics.ISignedNumber$1<TSelf>, System.Numerics.IHyperbolicFunctions$1<TSelf>, System.Numerics.ILogarithmicFunctions$1<TSelf>, System.Numerics.IPowerFunctions$1<TSelf>, System.Numerics.IRootFunctions$1<TSelf>, System.Numerics.ITrigonometricFunctions$1<TSelf>
        {
        }
        interface IExponentialFunctions$1<TSelf> extends System.Numerics.IFloatingPointConstants$1<TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface IFloatingPointConstants$1<TSelf> extends System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface IFloatingPoint$1<TSelf> extends System.Numerics.IFloatingPointConstants$1<TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>, System.Numerics.INumber$1<TSelf>, System.IComparable, System.IComparable$1<TSelf>, System.Numerics.IComparisonOperators$3<TSelf, TSelf, boolean>, System.Numerics.IModulusOperators$3<TSelf, TSelf, TSelf>, System.Numerics.ISignedNumber$1<TSelf>
        {
        }
        interface IHyperbolicFunctions$1<TSelf> extends System.Numerics.IFloatingPointConstants$1<TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface ILogarithmicFunctions$1<TSelf> extends System.Numerics.IFloatingPointConstants$1<TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface IPowerFunctions$1<TSelf> extends System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface IRootFunctions$1<TSelf> extends System.Numerics.IFloatingPointConstants$1<TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
        interface ITrigonometricFunctions$1<TSelf> extends System.Numerics.IFloatingPointConstants$1<TSelf>, System.Numerics.INumberBase$1<TSelf>, System.Numerics.IAdditionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IAdditiveIdentity$2<TSelf, TSelf>, System.Numerics.IDecrementOperators$1<TSelf>, System.Numerics.IDivisionOperators$3<TSelf, TSelf, TSelf>, System.IEquatable$1<TSelf>, System.Numerics.IEqualityOperators$3<TSelf, TSelf, boolean>, System.Numerics.IIncrementOperators$1<TSelf>, System.Numerics.IMultiplicativeIdentity$2<TSelf, TSelf>, System.Numerics.IMultiplyOperators$3<TSelf, TSelf, TSelf>, System.ISpanFormattable, System.IFormattable, System.ISpanParsable$1<TSelf>, System.IParsable$1<TSelf>, System.Numerics.ISubtractionOperators$3<TSelf, TSelf, TSelf>, System.Numerics.IUnaryPlusOperators$2<TSelf, TSelf>, System.Numerics.IUnaryNegationOperators$2<TSelf, TSelf>, System.IUtf8SpanFormattable, System.IUtf8SpanParsable$1<TSelf>
        {
        }
    }
    namespace Godot.Variant {
        enum Type
        { Nil = 0, Bool = 1, Int = 2, Float = 3, String = 4, Vector2 = 5, Vector2I = 6, Rect2 = 7, Rect2I = 8, Vector3 = 9, Vector3I = 10, Transform2D = 11, Vector4 = 12, Vector4I = 13, Plane = 14, Quaternion = 15, Aabb = 16, Basis = 17, Transform3D = 18, Projection = 19, Color = 20, StringName = 21, NodePath = 22, Rid = 23, Object = 24, Callable = 25, Signal = 26, Dictionary = 27, Array = 28, PackedByteArray = 29, PackedInt32Array = 30, PackedInt64Array = 31, PackedFloat32Array = 32, PackedFloat64Array = 33, PackedStringArray = 34, PackedVector2Array = 35, PackedVector3Array = 36, PackedColorArray = 37, PackedVector4Array = 38, Max = 39 }
    }
    namespace System.Collections {
        interface IEnumerable
        {
        }
        interface IList extends System.Collections.ICollection, System.Collections.IEnumerable
        {
        }
        interface ICollection extends System.Collections.IEnumerable
        {
        }
        interface IStructuralComparable
        {
        }
        interface IStructuralEquatable
        {
        }
    }
    namespace System.Collections.Generic {
        interface IEnumerable$1<T> extends System.Collections.IEnumerable
        {
        }
        interface IList$1<T> extends System.Collections.Generic.ICollection$1<T>, System.Collections.Generic.IEnumerable$1<T>, System.Collections.IEnumerable
        {
        }
        interface ICollection$1<T> extends System.Collections.Generic.IEnumerable$1<T>, System.Collections.IEnumerable
        {
        }
        interface IReadOnlyList$1<T> extends System.Collections.Generic.IReadOnlyCollection$1<T>, System.Collections.Generic.IEnumerable$1<T>, System.Collections.IEnumerable
        {
        }
        interface IReadOnlyCollection$1<T> extends System.Collections.Generic.IEnumerable$1<T>, System.Collections.IEnumerable
        {
        }
        interface IDictionary$2<TKey, TValue> extends System.Collections.Generic.ICollection$1<System.Collections.Generic.KeyValuePair$2<TKey, TValue>>, System.Collections.Generic.IEnumerable$1<System.Collections.Generic.KeyValuePair$2<TKey, TValue>>, System.Collections.IEnumerable
        {
        }
        class KeyValuePair$2<TKey, TValue> extends System.ValueType
        {
            protected [__keep_incompatibility]: never;
        }
        interface IReadOnlyDictionary$2<TKey, TValue> extends System.Collections.Generic.IReadOnlyCollection$1<System.Collections.Generic.KeyValuePair$2<TKey, TValue>>, System.Collections.Generic.IEnumerable$1<System.Collections.Generic.KeyValuePair$2<TKey, TValue>>, System.Collections.IEnumerable
        {
        }
    }
    namespace System.Reflection {
        class MemberInfo extends System.Object implements System.Reflection.ICustomAttributeProvider
        {
            protected [__keep_incompatibility]: never;
        }
        interface ICustomAttributeProvider
        {
        }
        interface IReflect
        {
        }
        interface MemberFilter
        { 
        (m: System.Reflection.MemberInfo, filterCriteria: any) : boolean; 
        Invoke?: (m: System.Reflection.MemberInfo, filterCriteria: any) => boolean;
        }
        var MemberFilter: { new (func: (m: System.Reflection.MemberInfo, filterCriteria: any) => boolean): MemberFilter; }
        class AssemblyName extends System.Object implements System.ICloneable, System.Runtime.Serialization.IDeserializationCallback, System.Runtime.Serialization.ISerializable
        {
            protected [__keep_incompatibility]: never;
        }
        class Assembly extends System.Object implements System.Reflection.ICustomAttributeProvider, System.Runtime.Serialization.ISerializable
        {
            protected [__keep_incompatibility]: never;
        }
        enum MemberTypes
        { Constructor = 1, Event = 2, Field = 4, Method = 8, Property = 16, TypeInfo = 32, Custom = 64, NestedType = 128, All = 191 }
        class Module extends System.Object implements System.Reflection.ICustomAttributeProvider, System.Runtime.Serialization.ISerializable
        {
            protected [__keep_incompatibility]: never;
        }
        class MethodBase extends System.Reflection.MemberInfo implements System.Reflection.ICustomAttributeProvider
        {
            protected [__keep_incompatibility]: never;
        }
        enum GenericParameterAttributes
        { None = 0, VarianceMask = 3, Covariant = 1, Contravariant = 2, SpecialConstraintMask = 28, ReferenceTypeConstraint = 4, NotNullableValueTypeConstraint = 8, DefaultConstructorConstraint = 16, AllowByRefLike = 32 }
        enum TypeAttributes
        { VisibilityMask = 7, NotPublic = 0, Public = 1, NestedPublic = 2, NestedPrivate = 3, NestedFamily = 4, NestedAssembly = 5, NestedFamANDAssem = 6, NestedFamORAssem = 7, LayoutMask = 24, AutoLayout = 0, SequentialLayout = 8, ExplicitLayout = 16, ClassSemanticsMask = 32, Class = 0, Interface = 32, Abstract = 128, Sealed = 256, SpecialName = 1024, Import = 4096, Serializable = 8192, WindowsRuntime = 16384, StringFormatMask = 196608, AnsiClass = 0, UnicodeClass = 65536, AutoClass = 131072, CustomFormatClass = 196608, CustomFormatMask = 12582912, BeforeFieldInit = 1048576, RTSpecialName = 2048, HasSecurity = 262144, ReservedMask = 264192 }
        class ConstructorInfo extends System.Reflection.MethodBase implements System.Reflection.ICustomAttributeProvider
        {
            protected [__keep_incompatibility]: never;
        }
        enum BindingFlags
        { Default = 0, IgnoreCase = 1, DeclaredOnly = 2, Instance = 4, Static = 8, Public = 16, NonPublic = 32, FlattenHierarchy = 64, InvokeMethod = 256, CreateInstance = 512, GetField = 1024, SetField = 2048, GetProperty = 4096, SetProperty = 8192, PutDispProperty = 16384, PutRefDispProperty = 32768, ExactBinding = 65536, SuppressChangeType = 131072, OptionalParamBinding = 262144, IgnoreReturn = 16777216, DoNotWrapExceptions = 33554432 }
        class Binder extends System.Object
        {
            protected [__keep_incompatibility]: never;
        }
        class ParameterModifier extends System.ValueType
        {
            protected [__keep_incompatibility]: never;
        }
        enum CallingConventions
        { Standard = 1, VarArgs = 2, Any = 3, HasThis = 32, ExplicitThis = 64 }
        class EventInfo extends System.Reflection.MemberInfo implements System.Reflection.ICustomAttributeProvider
        {
            protected [__keep_incompatibility]: never;
        }
        class FieldInfo extends System.Reflection.MemberInfo implements System.Reflection.ICustomAttributeProvider
        {
            protected [__keep_incompatibility]: never;
        }
        class MethodInfo extends System.Reflection.MethodBase implements System.Reflection.ICustomAttributeProvider
        {
            protected [__keep_incompatibility]: never;
        }
        class PropertyInfo extends System.Reflection.MemberInfo implements System.Reflection.ICustomAttributeProvider
        {
            protected [__keep_incompatibility]: never;
        }
        class InterfaceMapping extends System.ValueType
        {
            protected [__keep_incompatibility]: never;
        }
        interface TypeFilter
        { 
        (m: System.Type, filterCriteria: any) : boolean; 
        Invoke?: (m: System.Type, filterCriteria: any) => boolean;
        }
        var TypeFilter: { new (func: (m: System.Type, filterCriteria: any) => boolean): TypeFilter; }
    }
    namespace Godot.FileAccess {
        enum CompressionMode
        { Fastlz = 0, Deflate = 1, Zstd = 2, GZip = 3, Brotli = 4 }
    }
    namespace Godot.NativeInterop {
        class godot_string_name extends System.ValueType
        {
            protected [__keep_incompatibility]: never;
        }
    }
    namespace Godot.Viewport {
        enum Msaa
        { Disabled = 0, Msaa2X = 1, Msaa4X = 2, Msaa8X = 3, Max = 4 }
        enum ScreenSpaceAAEnum
        { Disabled = 0, Fxaa = 1, Smaa = 2, Max = 3 }
        enum DebugDrawEnum
        { Disabled = 0, Unshaded = 1, Lighting = 2, Overdraw = 3, Wireframe = 4, NormalBuffer = 5, VoxelGIAlbedo = 6, VoxelGILighting = 7, VoxelGIEmission = 8, ShadowAtlas = 9, DirectionalShadowAtlas = 10, SceneLuminance = 11, Ssao = 12, Ssil = 13, PssmSplits = 14, DecalAtlas = 15, Sdfgi = 16, SdfgiProbes = 17, GIBuffer = 18, DisableLod = 19, ClusterOmniLights = 20, ClusterSpotLights = 21, ClusterDecals = 22, ClusterReflectionProbes = 23, Occluders = 24, MotionVectors = 25, InternalBuffer = 26 }
        enum Scaling3DModeEnum
        { Bilinear = 0, Fsr = 1, Fsr2 = 2, MetalfxSpatial = 3, MetalfxTemporal = 4, Max = 5 }
        enum AnisotropicFiltering
        { Disabled = 0, Anisotropy2X = 1, Anisotropy4X = 2, Anisotropy8X = 3, Anisotropy16X = 4, Max = 5 }
        enum VrsModeEnum
        { Disabled = 0, Texture = 1, XR = 2, Max = 3 }
        enum VrsUpdateModeEnum
        { Disabled = 0, Once = 1, Always = 2, Max = 3 }
        enum DefaultCanvasItemTextureFilter
        { Nearest = 0, Linear = 1, LinearWithMipmaps = 2, NearestWithMipmaps = 3, Max = 4 }
        enum DefaultCanvasItemTextureRepeat
        { Disabled = 0, Enabled = 1, Mirror = 2, Max = 3 }
        enum SdfOversizeEnum
        { Oversize100Percent = 0, Oversize120Percent = 1, Oversize150Percent = 2, Oversize200Percent = 3, Max = 4 }
        enum SdfScaleEnum
        { Scale100Percent = 0, Scale50Percent = 1, Scale25Percent = 2, Max = 3 }
        enum PositionalShadowAtlasQuadrantSubdiv
        { Disabled = 0, Subdiv1 = 1, Subdiv4 = 2, Subdiv16 = 3, Subdiv64 = 4, Subdiv256 = 5, Subdiv1024 = 6, Max = 7 }
        enum RenderInfoType
        { Visible = 0, Shadow = 1, Canvas = 2, Max = 3 }
        enum RenderInfo
        { ObjectsInFrame = 0, PrimitivesInFrame = 1, DrawCallsInFrame = 2, Max = 3 }
        interface GuiFocusChangedEventHandler
        { 
        (node: Godot.Control) : void; 
        Invoke?: (node: Godot.Control) => void;
        }
        var GuiFocusChangedEventHandler: { new (func: (node: Godot.Control) => void): GuiFocusChangedEventHandler; }
    }
    namespace Godot.Collections {
        class Array$1<T> extends System.Object implements System.Collections.Generic.IList$1<T>, System.Collections.Generic.ICollection$1<T>, System.Collections.Generic.IEnumerable$1<T>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList$1<T>, System.Collections.Generic.IReadOnlyCollection$1<T>, Godot.Collections.IGenericGodotArray
        {
            protected [__keep_incompatibility]: never;
            public [Symbol.iterator]() : IterableIterator<T>
        }
        interface IGenericGodotArray
        {
        }
        /**
        * Wrapper around Godot's Dictionary class, a dictionary of Variant
        * typed elements allocated in the engine in C++. Useful when
        * interfacing with the engine.
        */
        class Dictionary extends System.Object implements System.Collections.Generic.IDictionary$2<Godot.Variant, Godot.Variant>, System.Collections.Generic.ICollection$1<System.Collections.Generic.KeyValuePair$2<Godot.Variant, Godot.Variant>>, System.Collections.Generic.IEnumerable$1<System.Collections.Generic.KeyValuePair$2<Godot.Variant, Godot.Variant>>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyDictionary$2<Godot.Variant, Godot.Variant>, System.Collections.Generic.IReadOnlyCollection$1<System.Collections.Generic.KeyValuePair$2<Godot.Variant, Godot.Variant>>, System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
        /**
        * Wrapper around Godot's Array class, an array of Variant
        * typed elements allocated in the engine in C++. Useful when
        * interfacing with the engine. Otherwise prefer .NET collections
        * such as
        * or
        * .
        */
        class Array extends System.Object implements System.Collections.Generic.IList$1<Godot.Variant>, System.Collections.Generic.ICollection$1<Godot.Variant>, System.Collections.Generic.IEnumerable$1<Godot.Variant>, System.Collections.IEnumerable, System.Collections.Generic.IReadOnlyList$1<Godot.Variant>, System.Collections.Generic.IReadOnlyCollection$1<Godot.Variant>, System.Collections.ICollection, System.IDisposable
        {
            protected [__keep_incompatibility]: never;
        }
    }
    namespace System.Runtime.Serialization {
        interface ISerializable
        {
        }
        interface IDeserializationCallback
        {
        }
    }
    namespace Godot.Input {
        enum MouseModeEnum
        { Visible = 0, Hidden = 1, Captured = 2, Confined = 3, ConfinedHidden = 4, Max = 5 }
        enum CursorShape
        { Arrow = 0, Ibeam = 1, PointingHand = 2, Cross = 3, Wait = 4, Busy = 5, Drag = 6, CanDrop = 7, Forbidden = 8, Vsize = 9, Hsize = 10, Bdiagsize = 11, Fdiagsize = 12, Move = 13, Vsplit = 14, Hsplit = 15, Help = 16 }
        interface JoyConnectionChangedEventHandler
        { 
        (device: bigint, connected: boolean) : void; 
        Invoke?: (device: bigint, connected: boolean) => void;
        }
        var JoyConnectionChangedEventHandler: { new (func: (device: bigint, connected: boolean) => void): JoyConnectionChangedEventHandler; }
    }
    namespace Godot.Node {
        enum ProcessModeEnum
        { Inherit = 0, Pausable = 1, WhenPaused = 2, Always = 3, Disabled = 4 }
        enum ProcessThreadGroupEnum
        { Inherit = 0, MainThread = 1, SubThread = 2 }
        enum ProcessThreadMessagesEnum
        { Messages = 1, MessagesPhysics = 2, MessagesAll = 3 }
        enum PhysicsInterpolationModeEnum
        { Inherit = 0, On = 1, Off = 2 }
        enum AutoTranslateModeEnum
        { Inherit = 0, Always = 1, Disabled = 2 }
        enum InternalMode
        { Disabled = 0, Front = 1, Back = 2 }
        interface ChildEnteredTreeEventHandler
        { 
        (node: Godot.Node) : void; 
        Invoke?: (node: Godot.Node) => void;
        }
        var ChildEnteredTreeEventHandler: { new (func: (node: Godot.Node) => void): ChildEnteredTreeEventHandler; }
        interface ChildExitingTreeEventHandler
        { 
        (node: Godot.Node) : void; 
        Invoke?: (node: Godot.Node) => void;
        }
        var ChildExitingTreeEventHandler: { new (func: (node: Godot.Node) => void): ChildExitingTreeEventHandler; }
        interface ReplacingByEventHandler
        { 
        (node: Godot.Node) : void; 
        Invoke?: (node: Godot.Node) => void;
        }
        var ReplacingByEventHandler: { new (func: (node: Godot.Node) => void): ReplacingByEventHandler; }
        interface EditorDescriptionChangedEventHandler
        { 
        (node: Godot.Node) : void; 
        Invoke?: (node: Godot.Node) => void;
        }
        var EditorDescriptionChangedEventHandler: { new (func: (node: Godot.Node) => void): EditorDescriptionChangedEventHandler; }
    }
    namespace Godot.Vector2 {
        enum Axis
        { X = 0, Y = 1 }
    }
    namespace Godot.Area2D {
        enum SpaceOverride
        { Disabled = 0, Combine = 1, CombineReplace = 2, Replace = 3, ReplaceCombine = 4 }
        interface BodyShapeEnteredEventHandler
        { 
        (bodyRid: Godot.Rid, body: Godot.Node2D, bodyShapeIndex: bigint, localShapeIndex: bigint) : void; 
        Invoke?: (bodyRid: Godot.Rid, body: Godot.Node2D, bodyShapeIndex: bigint, localShapeIndex: bigint) => void;
        }
        var BodyShapeEnteredEventHandler: { new (func: (bodyRid: Godot.Rid, body: Godot.Node2D, bodyShapeIndex: bigint, localShapeIndex: bigint) => void): BodyShapeEnteredEventHandler; }
        interface BodyShapeExitedEventHandler
        { 
        (bodyRid: Godot.Rid, body: Godot.Node2D, bodyShapeIndex: bigint, localShapeIndex: bigint) : void; 
        Invoke?: (bodyRid: Godot.Rid, body: Godot.Node2D, bodyShapeIndex: bigint, localShapeIndex: bigint) => void;
        }
        var BodyShapeExitedEventHandler: { new (func: (bodyRid: Godot.Rid, body: Godot.Node2D, bodyShapeIndex: bigint, localShapeIndex: bigint) => void): BodyShapeExitedEventHandler; }
        interface BodyEnteredEventHandler
        { 
        (body: Godot.Node2D) : void; 
        Invoke?: (body: Godot.Node2D) => void;
        }
        var BodyEnteredEventHandler: { new (func: (body: Godot.Node2D) => void): BodyEnteredEventHandler; }
        interface BodyExitedEventHandler
        { 
        (body: Godot.Node2D) : void; 
        Invoke?: (body: Godot.Node2D) => void;
        }
        var BodyExitedEventHandler: { new (func: (body: Godot.Node2D) => void): BodyExitedEventHandler; }
        interface AreaShapeEnteredEventHandler
        { 
        (areaRid: Godot.Rid, area: Godot.Area2D, areaShapeIndex: bigint, localShapeIndex: bigint) : void; 
        Invoke?: (areaRid: Godot.Rid, area: Godot.Area2D, areaShapeIndex: bigint, localShapeIndex: bigint) => void;
        }
        var AreaShapeEnteredEventHandler: { new (func: (areaRid: Godot.Rid, area: Godot.Area2D, areaShapeIndex: bigint, localShapeIndex: bigint) => void): AreaShapeEnteredEventHandler; }
        interface AreaShapeExitedEventHandler
        { 
        (areaRid: Godot.Rid, area: Godot.Area2D, areaShapeIndex: bigint, localShapeIndex: bigint) : void; 
        Invoke?: (areaRid: Godot.Rid, area: Godot.Area2D, areaShapeIndex: bigint, localShapeIndex: bigint) => void;
        }
        var AreaShapeExitedEventHandler: { new (func: (areaRid: Godot.Rid, area: Godot.Area2D, areaShapeIndex: bigint, localShapeIndex: bigint) => void): AreaShapeExitedEventHandler; }
        interface AreaEnteredEventHandler
        { 
        (area: Godot.Area2D) : void; 
        Invoke?: (area: Godot.Area2D) => void;
        }
        var AreaEnteredEventHandler: { new (func: (area: Godot.Area2D) => void): AreaEnteredEventHandler; }
        interface AreaExitedEventHandler
        { 
        (area: Godot.Area2D) : void; 
        Invoke?: (area: Godot.Area2D) => void;
        }
        var AreaExitedEventHandler: { new (func: (area: Godot.Area2D) => void): AreaExitedEventHandler; }
    }
    namespace Godot.CollisionObject2D {
        enum DisableModeEnum
        { Remove = 0, MakeStatic = 1, KeepActive = 2 }
        interface InputEventEventHandler
        { 
        (viewport: Godot.Node, event: Godot.InputEvent, shapeIdx: bigint) : void; 
        Invoke?: (viewport: Godot.Node, event: Godot.InputEvent, shapeIdx: bigint) => void;
        }
        var InputEventEventHandler: { new (func: (viewport: Godot.Node, event: Godot.InputEvent, shapeIdx: bigint) => void): InputEventEventHandler; }
        interface MouseShapeEnteredEventHandler
        { 
        (shapeIdx: bigint) : void; 
        Invoke?: (shapeIdx: bigint) => void;
        }
        var MouseShapeEnteredEventHandler: { new (func: (shapeIdx: bigint) => void): MouseShapeEnteredEventHandler; }
        interface MouseShapeExitedEventHandler
        { 
        (shapeIdx: bigint) : void; 
        Invoke?: (shapeIdx: bigint) => void;
        }
        var MouseShapeExitedEventHandler: { new (func: (shapeIdx: bigint) => void): MouseShapeExitedEventHandler; }
    }
    namespace Godot.CanvasItem {
        enum ClipChildrenMode
        { Disabled = 0, Only = 1, AndDraw = 2, Max = 3 }
        enum TextureFilterEnum
        { ParentNode = 0, Nearest = 1, Linear = 2, NearestWithMipmaps = 3, LinearWithMipmaps = 4, NearestWithMipmapsAnisotropic = 5, LinearWithMipmapsAnisotropic = 6, Max = 7 }
        enum TextureRepeatEnum
        { ParentNode = 0, Disabled = 1, Enabled = 2, Mirror = 3, Max = 4 }
    }
    namespace Godot.TextServer {
        enum JustificationFlag
        { None = 0, Kashida = 1, WordBound = 2, TrimEdgeSpaces = 4, AfterLastTab = 8, ConstrainEllipsis = 16, SkipLastLine = 32, SkipLastLineWithVisibleChars = 64, DoNotSkipSingleLine = 128 }
        enum Direction
        { Auto = 0, Ltr = 1, Rtl = 2, Inherited = 3 }
        enum Orientation
        { Horizontal = 0, Vertical = 1 }
        enum LineBreakFlag
        { None = 0, Mandatory = 1, WordBound = 2, GraphemeBound = 4, Adaptive = 8, TrimEdgeSpaces = 16, TrimIndent = 32, TrimStartEdgeSpaces = 64, TrimEndEdgeSpaces = 128 }
        enum AutowrapMode
        { Off = 0, Arbitrary = 1, Word = 2, WordSmart = 3 }
        enum OverrunBehavior
        { NoTrimming = 0, TrimChar = 1, TrimWord = 2, TrimEllipsis = 3, TrimWordEllipsis = 4, TrimEllipsisForce = 5, TrimWordEllipsisForce = 6 }
        enum VisibleCharactersBehavior
        { CharsBeforeShaping = 0, CharsAfterShaping = 1, GlyphsAuto = 2, GlyphsLtr = 3, GlyphsRtl = 4 }
        enum StructuredTextParser
        { Default = 0, Uri = 1, File = 2, Email = 3, List = 4, Gdscript = 5, Custom = 6 }
    }
    namespace Godot.Control {
        enum TextDirection
        { Inherited = 3, Auto = 0, Ltr = 1, Rtl = 2 }
    }
        interface IJsComponent
        {
            JsOnReady : System.Action
            JsOnProcess : System.Action$1<number>
            JsOnPhysicsProcess : System.Action$1<number>
            JsOnInput : System.Action$1<Godot.InputEvent>
            JsOnExitTree : System.Action
        }
        namespace System.Runtime.InteropServices {
        class StructLayoutAttribute extends System.Attribute
        {
            protected [__keep_incompatibility]: never;
        }
    }
    namespace System.Globalization {
        class CultureInfo extends System.Object implements System.IFormatProvider, System.ICloneable
        {
            protected [__keep_incompatibility]: never;
        }
    }
}
