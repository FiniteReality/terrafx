// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;
using static System.Runtime.InteropServices.Marshal;
using static TerraFX.Utilities.ExceptionUtilities;

namespace TerraFX.Utilities
{
    /// <summary>Defines a delegate that can be passed to native code.</summary>
    /// <typeparam name="TDelegate">The type of the delegate.</typeparam>
    public readonly struct NativeDelegate<TDelegate> where TDelegate : Delegate
    {
        private readonly IntPtr _handle;
        private readonly TDelegate _value;

        /// <summary>Initializes a new instance of the <see cref="NativeDelegate{TDelegate}" /> struct.</summary>
        /// <param name="value">The managed delegate represented by the instance.</param>
        /// <exception cref="ArgumentNullException"><paramref name="value" /> is <c>null</c>.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="value" /> does not target a static method.</exception>
        /// <exception cref="ArgumentOutOfRangeException"><paramref name="value" /> targets more than one method.</exception>
        public NativeDelegate(TDelegate value)
        {
            ThrowIfNull(value, nameof(value));

            if (value.Target != null)
            {
                ThrowArgumentOutOfRangeException(nameof(value), value);
            }

            if (value.GetInvocationList().Length != 1)
            {
                ThrowArgumentOutOfRangeException(nameof(value), value);
            }

            _value = value;
            _handle = GetFunctionPointerForDelegate(value);
        }

        /// <summary>Implicitly converts a <see cref="NativeDelegate{TDelegate}" /> to a <see cref="IntPtr" />.</summary>
        /// <param name="value">The <see cref="NativeDelegate{TDelegate}" /> to convert.</param>
        public static implicit operator IntPtr(NativeDelegate<TDelegate> value) => value._handle;

        /// <summary>Implicitly converts a <see cref="NativeDelegate{TDelegate}" /> to a <typeparamref name="TDelegate" />.</summary>
        /// <param name="value">The <see cref="NativeDelegate{TDelegate}" /> to convert.</param>
        public static implicit operator TDelegate(NativeDelegate<TDelegate> value) => value._value;
    }
}
