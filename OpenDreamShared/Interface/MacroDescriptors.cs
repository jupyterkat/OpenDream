﻿using System.Collections.Generic;
using Robust.Shared.Serialization.Manager.Attributes;

namespace OpenDreamShared.Interface {
    public class MacroSetDescriptor {
        public string Name;
        public List<MacroDescriptor> Macros;

        public MacroSetDescriptor(string name, List<MacroDescriptor> macros) {
            Name = name;
            Macros = macros;
        }
    }

    public class MacroDescriptor : ElementDescriptor {
        public string Id {
            get => _id ?? Command;
            set => _id = value;
        }

        [DataField("id")]
        private string _id;

        [DataField("command")]
        public string Command;
    }
}
