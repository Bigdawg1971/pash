namespace System.Management.Automation.Interpreter
{
    using System;
    using System.Linq;

    internal static class DelegateHelpers
    {
        private const int MaximumArity = 0x11;

        internal static Type MakeDelegate(Type[] types)
        {
            if ((types.Length <= 0x11) && !types.Any<Type>(t => t.IsByRef))
            {
                Type type = types[types.Length - 1];
                if (type == typeof(void))
                {
                    Array.Resize<Type>(ref types, types.Length - 1);
                    switch (types.Length)
                    {
                        case 0:
                            return typeof(Action);

                        case 1:
                            return typeof(Action<>).MakeGenericType(types);

                        case 2:
                            return typeof(Action<,>).MakeGenericType(types);

                        case 3:
                            return typeof(Action<,,>).MakeGenericType(types);

                        case 4:
                            return typeof(Action<,,,>).MakeGenericType(types);

                        case 5:
                            return typeof(Action<,,,,>).MakeGenericType(types);

                        case 6:
                            return typeof(Action<,,,,,>).MakeGenericType(types);

                        case 7:
                            return typeof(Action<,,,,,,>).MakeGenericType(types);

                        case 8:
                            return typeof(Action<,,,,,,,>).MakeGenericType(types);

                        case 9:
                            return typeof(Action<,,,,,,,,>).MakeGenericType(types);

                        case 10:
                            return typeof(Action<,,,,,,,,,>).MakeGenericType(types);

                        case 11:
                            return typeof(Action<,,,,,,,,,,>).MakeGenericType(types);

                        case 12:
                            return typeof(Action<,,,,,,,,,,,>).MakeGenericType(types);

                        case 13:
                            return typeof(Action<,,,,,,,,,,,,>).MakeGenericType(types);

                        case 14:
                            return typeof(Action<,,,,,,,,,,,,,>).MakeGenericType(types);

                        case 15:
                            return typeof(Action<,,,,,,,,,,,,,,>).MakeGenericType(types);

                        case 0x10:
                            return typeof(Action<,,,,,,,,,,,,,,,>).MakeGenericType(types);
                    }
                }
                else
                {
                    switch (types.Length)
                    {
                        case 1:
                            return typeof(Func<>).MakeGenericType(types);

                        case 2:
                            return typeof(Func<,>).MakeGenericType(types);

                        case 3:
                            return typeof(Func<,,>).MakeGenericType(types);

                        case 4:
                            return typeof(Func<,,,>).MakeGenericType(types);

                        case 5:
                            return typeof(Func<,,,,>).MakeGenericType(types);

                        case 6:
                            return typeof(Func<,,,,,>).MakeGenericType(types);

                        case 7:
                            return typeof(Func<,,,,,,>).MakeGenericType(types);

                        case 8:
                            return typeof(Func<,,,,,,,>).MakeGenericType(types);

                        case 9:
                            return typeof(Func<,,,,,,,,>).MakeGenericType(types);

                        case 10:
                            return typeof(Func<,,,,,,,,,>).MakeGenericType(types);

                        case 11:
                            return typeof(Func<,,,,,,,,,,>).MakeGenericType(types);

                        case 12:
                            return typeof(Func<,,,,,,,,,,,>).MakeGenericType(types);

                        case 13:
                            return typeof(Func<,,,,,,,,,,,,>).MakeGenericType(types);

                        case 14:
                            return typeof(Func<,,,,,,,,,,,,,>).MakeGenericType(types);

                        case 15:
                            return typeof(Func<,,,,,,,,,,,,,,>).MakeGenericType(types);

                        case 0x10:
                            return typeof(Func<,,,,,,,,,,,,,,,>).MakeGenericType(types);

                        case 0x11:
                            return typeof(Func<,,,,,,,,,,,,,,,,>).MakeGenericType(types);
                    }
                }
                throw Assert.Unreachable;
            }
            throw Assert.Unreachable;
        }
    }
}

