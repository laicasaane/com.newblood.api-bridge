using System;

namespace UnityEngine;

public class Object
{
    public static class MarshalledUnityObject
    {
        public static IntPtr Marshal(object obj)
        {
            return default;
        }

        public static IntPtr MarshalNotNull(object obj)
        {
            return default;
        }

        public static void TryThrowEditorNullExceptionObject(Object unityObj, string parameterName)
        {
        }
    }
}
