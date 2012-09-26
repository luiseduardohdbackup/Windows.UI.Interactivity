﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Windows.UI.Interactivity
{
    public interface ILifetimeTarget
    {
        void AssociatedObjectLoaded();
        void AssociatedObjectUnloaded();
    }
}
