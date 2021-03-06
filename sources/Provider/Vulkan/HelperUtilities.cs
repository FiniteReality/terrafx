// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.	

using TerraFX.Interop;
using static TerraFX.Interop.VkResult;
using static TerraFX.Utilities.ExceptionUtilities;

namespace TerraFX.Provider.Vulkan
{
    internal static partial class HelperUtilities
    {
        public static void ThrowExternalExceptionIfFailed(string methodName, VkResult result)
        {
            if (result != VK_SUCCESS)
            {
                ThrowExternalException(methodName, (int)result);
            }
        }
    }
}
