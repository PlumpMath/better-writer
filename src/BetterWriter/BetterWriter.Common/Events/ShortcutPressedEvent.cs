﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Prism.Events;

namespace BetterWriter.Common.Events {
    public class ShortcutPressedEvent : CompositePresentationEvent<Shortcut> {
    }
}
