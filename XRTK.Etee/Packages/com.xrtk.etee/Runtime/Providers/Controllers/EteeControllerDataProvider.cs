// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Attributes;
using XRTK.Definitions.Platforms;
using XRTK.Interfaces.InputSystem;
using XRTK.Etee.Profiles;
using XRTK.Providers.Controllers;

namespace XRTK.Etee.Providers.Controllers
{
    [RuntimePlatform(typeof(AllPlatforms))]
    [System.Runtime.InteropServices.Guid("E6769870-23E7-471D-A42D-1331BF393790")]
    public class EteeControllerDataProvider : BaseControllerDataProvider
    {
        /// <inheritdoc />
        public EteeControllerDataProvider(string name, uint priority, EteeControllerDataProviderProfile profile, IMixedRealityInputSystem parentService)
            : base(name, priority, profile, parentService)
        {
        }
    }
}

