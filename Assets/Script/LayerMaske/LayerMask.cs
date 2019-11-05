using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Startup
{
    public static class LayerMaske
    {
        public static bool Contains(this LayerMask layers,GameObject gameObject)
        {
            return 0!=(layers.value&1<< gameObject.layer);
        }
    }
}

