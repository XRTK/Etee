// Copyright (c) XRTK. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using XRTK.Definitions.Controllers;
using XRTK.Definitions.Utilities;
using XRTK.Etee.Providers.Controllers;

namespace XRTK.Etee.Profiles
{
    public class EteeControllerDataProviderProfile : BaseMixedRealityControllerDataProviderProfile
    {
        public override ControllerDefinition[] GetDefaultControllerOptions()
        {
            return new[]
            {
                new ControllerDefinition(typeof(EteeController), Handedness.Left),
                new ControllerDefinition(typeof(EteeController), Handedness.Right)
            };
        }
    }
}

